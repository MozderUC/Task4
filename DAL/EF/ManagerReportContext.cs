using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL.EF
{
    public class ManagerReportContext : DbContext
    {
        public ManagerReportContext()
            : base("DbManagerConnection")
        { }

        public ManagerReportContext(string connectionString)
            : base(connectionString)
        {
        }

        public DbSet<DAL.Entities.ManagerReport> Reports { get; set; }
    }
}