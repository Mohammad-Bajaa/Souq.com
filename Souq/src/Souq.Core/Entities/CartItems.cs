using Souq.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Core.Entities
{

    public class CartItems : BaseEntity
    {
        public int Id {get;set;} 
        public int Quantity {get;set; }

        public int CartID { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public Cart Cart { get; set; }


    }
}
