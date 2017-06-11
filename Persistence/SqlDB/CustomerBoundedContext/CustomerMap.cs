using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.CustomerBoundedContext;
using FluentNHibernate.Mapping;

namespace Persistence.SqlDB.CustomerBoundedContext
{
    public class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
        }
    }
}
