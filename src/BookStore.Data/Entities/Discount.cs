using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.Entities
{
     public class Discount
    {
        public virtual long DiscountId { get; set; }
        public virtual IList<Book> books { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime ValidUntil { get; set;}
        public virtual DateTime CreatedAt { get; set; }
        public virtual bool IsEnabled { get; set; }
        public virtual byte[] Version { get; set; }
    }
}
