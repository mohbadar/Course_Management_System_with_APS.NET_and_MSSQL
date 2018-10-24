using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.SqlServer;
using System.Data.Entity.Infrastructure.Interception;

namespace WebUniversity.DAL
{
    public class SchoolConfiguration: DbConfiguration
    {
        public SchoolConfiguration()
        {
           // SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
            //DbInterception.Add(new SchoolTransientErrors());
           // DbInterception.Add(new SchoolInterceptorLogging());
        }
    }
}