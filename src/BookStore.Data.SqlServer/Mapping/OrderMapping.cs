using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BookStore.Data.Entities;
namespace BookStore.Data.SqlServer.Mapping
{
    public class OrderMapping : VersionedClassMap<Order>
    {
        public OrderMapping()
        {
            Id(x => x.OrderId);
            Map(x => x.Quantity).Not.Nullable();
            Map(x => x.OrderDate).Not.Nullable();
            Map(x => x.Total).Not.Nullable();
            Map(x => x.UserId).Not.Nullable();
            HasManyToMany(x => x.OrderItems).Access.ReadOnlyPropertyThroughCamelCaseField(Prefix.Underscore)
                .Table("OrderItem")
                .ParentKeyColumn("OrderId")
                .ChildKeyColumn("UserId");

        }
    }
}
