using BookStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.SqlServer.Mapping
{
    public class BookMapping : VersionedClassMap<Book>
    {
        public BookMapping()
        {
            Id(x => x.BookId);
            Map(x => x.CategoryId);
            Map(x => x.CreatedAt);
            Map(x => x.Description);
            Map(x => x.DiscountId);
            Map(x => x.IsEnabled);
            Map(x => x.Name);
            Map(x => x.Price);
            Map(x => x.PublishData);
        }
    }
}
