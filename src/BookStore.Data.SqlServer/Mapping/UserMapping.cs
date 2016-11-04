using BookStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace BookStore.Data.SqlServer.Mapping
{
    public class UserMapping : VersionedClassMap<User>
    {
        public UserMapping()
        {
            Id(x => x.UserId);
            Map(x=>x.UserName);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Password);
            Map(x => x.UpdatedAt);
            Map(x => x.CreatedAt);
            Map(x => x.Email);
            Map(x => x.IsEnabled);
        }
    }
}
