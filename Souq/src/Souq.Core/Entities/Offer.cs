using Clean.Architecture.Core.Entities;
using Souq.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Souq.Core.Entities
{

    public class Offer : BaseEntity
    {
        public int Id { get; set; }
        public int OfferId { get; set; }
        public int ItemId { get; set; }

        
        public Item item { get; set; }
        public Item offer { get; set; }




    }
}
