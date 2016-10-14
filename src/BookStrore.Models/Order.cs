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
        public  long OrderId { get; set; }
        public  IList<Book> Books { get { return _books; } }
        public  decimal Price { get; set; }
        public  int Quantity { get; set; }
    }
}
