using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStrore.Models
{
    class Book
    {
        public virtual long BookId { get; set; }
        public virtual long DiscountId { get; set; }
        public virtual long CategoryId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime PublishData { get; set; }
        public virtual DateTime CreatedAt { get; set; }
        public virtual decimal Price { get; set; }
        public virtual bool IsEnabled { get; set; }
    }
}
