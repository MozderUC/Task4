using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Entities;
using DAL.EF;
using System.Data.Entity;


namespace DAL.Repositories
{
    public class ManagerReportRepository : IRepository<ManagerReport>
    {
        private ManagerReportContext db;      
        
        public ManagerReportRepository()
        {
            this.db = new DAL.EF.ManagerReportContext();
        }
        public ManagerReportRepository(string connectionstring)
        {
            this.db = new DAL.EF.ManagerReportContext(connectionstring);
        }

        public IEnumerable<ManagerReport> GetAll()
        {
            return db.Reports;
        }

        public ManagerReport Get(int id)
        {
            return db.Reports.Find(id);
        }

        public void Create(ManagerReport report)
        {
            db.Reports.Add(report);
        }
        
        public void SaveChanges()
        {
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            ManagerReport report = db.Reports.Find(id);
            if (report != null)
                db.Reports.Remove(report);
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
