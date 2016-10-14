using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStrore.Models
{
    class Discount
    {

        public  long DiscountId { get; set; }
        public  IList <Book> books { get; set; }
        public  string Name { get; set; }
        public  string Description { get; set; }
        public  DateTime ValidUntil { get; set; }
        public  DateTime? CreatedAt { get; set; }
        public  bool IsEnabled { get; set; }
    }
}
