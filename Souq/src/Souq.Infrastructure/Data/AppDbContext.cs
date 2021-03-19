using Souq.SharedKernel.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Souq.Core.Entities;
using Souq.SharedKernel;
using Ardalis.EFCore.Extensions;
using System.Reflection;
using JetBrains.Annotations;
using Clean.Architecture.Core.Entities;

namespace Souq.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        private readonly IDomainEventDispatcher _dispatcher;

        //public AppDbContext(DbContextOptions options) : base(options)
        //{
        //}
        public AppDbContext(DbContextOptions<AppDbContext> options, IDomainEventDispatcher dispatcher)
            : base(options)
        {
            _dispatcher = dispatcher;
        }
       

        public DbSet<ToDoItem> ToDoItems { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItems> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Offer> Offers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyAllConfigurationsFromCurrentAssembly();



            modelBuilder.Entity<CartItems>().HasKey(sc => new { sc.ItemId, sc.CartID });

            modelBuilder.Entity<CartItems>()
                .HasOne<Item>(sc => sc.Item)
                .WithMany(s => s.Carts)
                .HasForeignKey(sc => sc.ItemId)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<CartItems>()
                .HasOne<Cart>(sc => sc.Cart)
                .WithMany(s => s.Items)
                .HasForeignKey(sc => sc.ItemId)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<OrderItems>().HasKey(sc => new { sc.ItemId, sc.OrderId });
            modelBuilder.Entity<OrderItems>()
                .HasOne<Item>(sc => sc.Item)
                .WithMany(s => s.OrderItems)
                .HasForeignKey(sc => sc.ItemId)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<OrderItems>()
                .HasOne<Order>(sc => sc.Order)
                .WithMany(s => s.OrderItems)
                .HasForeignKey(sc => sc.OrderId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Offer>()
                .HasOne<Item>(sc => sc.item)
                .WithMany(s => s.ItemsInOffer)
                .HasForeignKey(sc => sc.ItemId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Offer>()
                .HasOne<Item>(sc => sc.offer)
                .WithMany(s => s.OffersForItem)
                .HasForeignKey(sc => sc.OfferId)
                .OnDelete(DeleteBehavior.NoAction);
            // alternately this is built-in to EF Core 2.2
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            int result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

            // ignore events if no dispatcher provided
            if (_dispatcher == null) return result;

            // dispatch events only if save was successful
            var entitiesWithEvents = ChangeTracker.Entries<BaseEntity>()
                .Select(e => e.Entity)
                .Where(e => e.Events.Any())
                .ToArray();

            foreach (var entity in entitiesWithEvents)
            {
                var events = entity.Events.ToArray();
                entity.Events.Clear();
                foreach (var domainEvent in events)
                {
                    await _dispatcher.Dispatch(domainEvent).ConfigureAwait(false);
                }
            }

            return result;
        }

        public override int SaveChanges()
        {
            return SaveChangesAsync().GetAwaiter().GetResult();
        }

        ////////////////
        ///{
       
      
       
    }



}
