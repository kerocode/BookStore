using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.Entities
{
    public class Book
    {
        public virtual long IdBook{  get; set;}
        public virtual long IdDiscount { get; set; }
        public virtual long IdCategory { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime PublishData { get; set; } 
        public virtual DateTime CreatedAt { get; set; }
        public virtual decimal Price { get; set; }
        public virtual bool IsEnabled { get; set; }


    }
}
