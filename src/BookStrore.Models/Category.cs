using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStrore.Models
{
    class Category
    {

        public virtual long IdCategory { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
    }
}
