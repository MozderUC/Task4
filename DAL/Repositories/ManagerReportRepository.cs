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

        public ManagerReportRepository(ManagerReportContext context)
        {
            this.db = context;
        }

        public IEnumerable<ManagerReport> GetAll()
        {
            return db.Reports;
        }

        public ManagerReport Get(int id)
        {
            return db.Reports.Find(id);
        }

        public void Create(ManagerReport book)
        {
            db.Reports.Add(book);
        }

        public void Update(ManagerReport book)
        {
            db.Entry(book).State = EntityState.Modified;
        }

        public IEnumerable<ManagerReport> Find(Func<ManagerReport, Boolean> predicate)
        {
            return db.Reports.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            ManagerReport book = db.Reports.Find(id);
            if (book != null)
                db.Reports.Remove(book);
        }
    }
}
