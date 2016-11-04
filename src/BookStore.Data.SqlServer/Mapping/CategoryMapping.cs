using BookStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.SqlServer.Mapping
{
    class CategoryMapping : VersionedClassMap<Category>
    {
        public CategoryMapping()
        {
            Id(x => x.CategoryId);
            Map(x => x.Description);
            Map(x => x.Name);
        }
    }
}
