using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BookStore.Data.Entities;
namespace BookStore.Data.SqlServer.Mapping
{
    public class OrderMap : VersionedClassMap<Order>
    {
        public OrderMap()
        {
            Id(x => x.OrderId);
            HasManyToMany(x => x.Books).Access.ReadOnlyPropertyThroughCamelCaseField(Prefix.Underscore);

            Map(x => x.OrderBy).Not.Nullable();
            Map(x => x.Price).Not.Nullable();
            Map(x => x.Quantity).Not.Nullable();

        }
    }
}
