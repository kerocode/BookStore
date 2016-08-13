using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStrore.Models
{
    class Discount
    {
        public virtual long IdDiscount { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime ValidUntil { get; set; }
        public virtual DateTime CreatedAt { get; set; }
        public virtual bool IsEnabled { get; set; }
    }
}
