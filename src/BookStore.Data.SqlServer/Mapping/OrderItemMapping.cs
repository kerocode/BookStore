using BookStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.SqlServer.Mapping
{
    public class OrderItemMapping : VersionedClassMap<OrderItem>
    {
        public OrderItemMapping()
        {
            Id(x => x.OrderItemId);
            Map(x => x.OrderId);
            Map(x => x.OrderDate);
            Map(x => x.Price);
            Map(x => x.Quantity);
            Map(x => x.UserId);
            Map(x => x.BookId);
        }
    }
}
