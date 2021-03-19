using Souq.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Core.Entities
{
    public class Category : BaseEntity
    {
        public  int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        

        public ICollection<Item> Items { get; set; }
        

    }
}
