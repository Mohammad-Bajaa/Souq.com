using Souq.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Core.Entities
{
    public class Order : BaseEntity
    {
        public int Id { get; set; }
        public ICollection<OrderItems> OrderItems { get; set; }

        public int CustomerId { get;set;}
        public Customer Customer { get;set; }
        public int StatusId { get;set; }
        public Status Status { get;set; }

    }
}
