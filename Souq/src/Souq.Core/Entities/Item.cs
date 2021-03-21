using Souq.Core.Entities;
using Souq.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [DisplayName("Production Date")]
        public DateTime ProductionDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [DisplayName("Expire Date")]
        public DateTime ExpireDate { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
        public string ImageName { get; set; }
        public string ImagePath { get; set; }
        public int CategoryID { get; set; } 
        public Category Category { get; set; }
        [DisplayName("Offer")]
        public bool isoffer { get; set; }
        public List<CartItems> Carts { get; set; }

        public ICollection<OrderItems> OrderItems { get; set; }


        public ICollection<Offer> ItemsInOffer { get; set; }
        public ICollection<Offer> OffersForItem { get; set; }

    }
}
