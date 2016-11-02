using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.Entities
{
    public class Author : IVersionedEntity
    {
        public virtual long AuthorId { get; set; }
        public virtual long BookId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual byte[] Version { get; set; }

    }
}
