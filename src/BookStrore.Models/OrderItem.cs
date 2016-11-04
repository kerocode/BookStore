using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStrore.Models
{
    public class OrderItem
    {
        public  long OrderItemId { get; set; }
        public  long OrderId { get; set; }
        public  long UserId { get; set; }
        public  long BookId { get; set; }
        public  int Quantity { get; set; }
        public  DateTime OrderDate { get; set; }
        public  decimal Price { get; set; }
        public  byte[] Version { get; set; }
    }
}
