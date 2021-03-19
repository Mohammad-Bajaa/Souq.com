using Souq.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Core.Entities
{
    public class OrderItems : BaseEntity
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
