using BookStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.SqlServer.Mapping
{
    public class DiscountMapping: VersionedClassMap<Discount>
    {
        public DiscountMapping()
        {
            Id(x => x.DiscountId);
            HasMany(x => x.books);
            Map(x => x.CreatedAt);
            Map(x => x.Description);
            Map(x => x.IsEnabled);
            Map(x => x.Name);
            Map(x => x.ValidUntil);
        }
    }
}
