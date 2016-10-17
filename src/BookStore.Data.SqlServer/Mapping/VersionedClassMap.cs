using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookStore.Data.Entities;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace BookStore.Data.SqlServer.Mapping
{
    public abstract class VersionedClassMap <T> : ClassMap <T> where T : IVersionedEntity
    {
        protected VersionedClassMap()
        {
            Version(x => x.Version)
                .Column("ts")
                .CustomSqlType("Rowversion")
                .Generated.Always()
                .UnsavedValue("null");
        }
    }
}




