using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.Entities
{
    public class OrderItem : IVersionedEntity
    {
        public virtual long OrderItemId { get; set; }
        public virtual long OrderId { get; set; }
        public virtual long BookId { get; set; }
        public virtual long UserId { get; set; }
        public virtual int  Quantity { get; set; }
        public virtual DateTime OrderDate { get; set; }
        public virtual decimal Price { get; set; }
        public virtual byte[] Version { get; set; }
    }
}
