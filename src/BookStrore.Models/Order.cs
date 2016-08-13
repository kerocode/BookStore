using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStrore.Models
{
    class Order
    {
        private readonly IList<Book> _books = new List<Book>();
        public virtual long IdOrder { get; set; }
        public virtual long IdOrderList { get; set; }
        public virtual IList<Book> Books { get { return _books; } }
        public virtual decimal Price { get; set; }
        public virtual int Quantity { get; set; }
    }
}
