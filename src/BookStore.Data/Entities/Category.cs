﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.Entities
{
    public class Category : IVersionedEntity
    {
        public virtual long CategoryId { get; set; }
        public virtual string Name { get; set;}
        public virtual string Description { get; set;}
        public virtual byte[] Version { get; set; }
    }
}
