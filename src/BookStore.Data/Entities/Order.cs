using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.Entities
{
    public class Order
    {
        private readonly IList<Book> _books = new List<Book>();
        public virtual long OrderId { get; set;}
        public virtual User OrderBy { get; set;}
        public virtual IList<Book> Books { get { return _books; } }
        public virtual decimal Price { get; set; }
        public virtual int Quantity { get; set; }
        public virtual byte[] Version { get; set; }

    }
}
