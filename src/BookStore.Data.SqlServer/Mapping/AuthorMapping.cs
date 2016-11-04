using BookStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.SqlServer.Mapping
{
    public class AuthorMapping : VersionedClassMap<Author>
    {
       public AuthorMapping()
        {
            Id(x => x.AuthorId);
            Map(x => x.BookId);
            Map(x => x.FirstName);
            Map(x => x.LastName);
        }
    }
}
