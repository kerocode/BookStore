using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStrore.Models
{
    class Book
    {
        public  long BookId { get; set; }
        public  long? DiscountId { get; set; }
        public  Category Category { get; set; }
        public  string Name { get; set; }
        public  string Description { get; set; }
        public  DateTime? PublishData { get; set; }
        public  DateTime? CreatedAt { get; set; }
        public  decimal Price { get; set; }
        public  bool IsEnabled { get; set; }
    }
}
