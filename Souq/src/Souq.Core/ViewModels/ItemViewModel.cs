using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Souq.Core.ViewModels
{
   public class ItemViewModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [DisplayName("Production Date")]
        public DateTime ProductionDate { get; set; }
        [DisplayName("Expire Date")]
        public DateTime ExpireDate { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
        [DisplayName("Image")]
        public string ImageName { get; set; }
        public string ImagePath { get; set; }
        public int CategoryID { get; set; }
        [DisplayName("Offer")]
        public bool IsOffer { get; set; }
        public bool IsSelected { get; set; }
        [DisplayName("Addition Price")]
        public int AdditionalPrice { get; set; }
        //public ICollection<Offer> ItemsInOffer { get; set; }
        //public ICollection<Offer> OffersForItem { get; set; }
    }
}
