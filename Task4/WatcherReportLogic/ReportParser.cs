using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;
using Task4.DTO;
using System.IO;

namespace Task4.WatcherReportLogic
{
    class ReportParser
    {
        public ReportParser()
        {
        }

        public List<ManagerReport> getReportList(string path)
        {           
            //string[] str = System.IO.Directory.GetFiles(path, "*.csv");

            CsvFileDescription inputFileDescription = new CsvFileDescription
            {
                SeparatorChar = ',',
                FirstLineHasColumnNames = false,
                EnforceCsvColumnAttribute = true,
            };

            CsvContext cc = new CsvContext();

            List<ManagerReport> rep = cc.Read<ManagerReport>(path, inputFileDescription).ToList<ManagerReport>();

            string managerName = Path.GetFileName(path).Split('_').First();
            string datestr = Path.GetFileName(path).Split('_').Last();
            DateTime date = new DateTime(Int32.Parse(datestr.Substring(4, 4)), Int32.Parse(datestr.Substring(2, 2)), Int32.Parse(datestr.Substring(0, 2)));
            foreach (ManagerReport repos in rep)
            {
                repos.ManagerLastName = managerName;
                repos.ReportDate = date;
            }

            return rep;
        }
    }
}
