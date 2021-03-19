using Souq.Core.Entities;
using Souq.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Core.Entities
{
    public class Item : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
        public string ImageName { get; set; }
        public string ImagePath { get; set; }
        public int CategoryID { get; set; } 
        public Category Category { get; set; }
        public bool isoffer { get; set; }
        public List<CartItems> Carts { get; set; }

        public ICollection<OrderItems> OrderItems { get; set; }


        public ICollection<Offer> ItemsInOffer { get; set; }
        public ICollection<Offer> OffersForItem { get; set; }

    }
}
