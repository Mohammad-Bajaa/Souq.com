using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Souq.Core.Entities;

namespace Clean.Architecture.Core.Entities
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItems> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Offer> Offers { get; set; }
    }
}
