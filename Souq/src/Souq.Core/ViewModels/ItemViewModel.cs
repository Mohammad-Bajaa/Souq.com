using System;
using System.Collections.Generic;
using System.Text;

namespace Souq.Core.ViewModels
{
   public class ItemViewModel
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
        public bool IsOffer { get; set; }
        public bool IsSelected { get; set; }
        public int AdditionalPrice { get; set; }
        //public ICollection<Offer> ItemsInOffer { get; set; }
        //public ICollection<Offer> OffersForItem { get; set; }
    }
}
