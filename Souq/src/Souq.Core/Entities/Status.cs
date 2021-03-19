﻿using Souq.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Core.Entities
{
    public class Status : BaseEntity
    {
        public int Id { get; set; }

        public string status { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
