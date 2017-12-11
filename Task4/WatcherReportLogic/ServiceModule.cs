using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.WatcherReportLogic
{
    class ServiceModule
    {
        public ServiceModule()
        {           
        }

        public void HandleReports(string path)
        {
            ReportParser parser = new ReportParser();
            DbHandler db = new DbHandler();

            List<DTO.ManagerReport> rep = parser.getReportList(path);

            foreach(DTO.ManagerReport r in rep)
            {
                db.AddReportToDatabase(r);
            }

            IEnumerable<DAL.Entities.ManagerReport> reports = db.getAll();
            string text = "";

            foreach(DAL.Entities.ManagerReport repo in reports)
            {
                text += repo.ClienFirstName + " " + repo.ClientLastName + " " + repo.ManagerLastName + "\n";
            }

            System.IO.File.WriteAllText(@"C:\someDir\ath.txt", text);

        }
    }

}
