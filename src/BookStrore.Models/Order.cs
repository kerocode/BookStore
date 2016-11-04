using BookStrore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Order
    {
        public  long OrderId { get; set; }
        public  IList<OrderItem> OrderItem { get; set; }
        public DateTime OrderDate { get; set; }
        public  decimal Total { get; set; }
        public  int Quantity { get; set; }
    }
}
