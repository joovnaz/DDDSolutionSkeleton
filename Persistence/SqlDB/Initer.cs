using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.SqlDB;
using Domain.Common;

namespace Persistence.SqlDB
{
    public static class Initer
    {
        public static void Init(string connectionString)
        {
            SessionFactory.Init(connectionString);
            DomainEvents.Init();
        }
    }
}
