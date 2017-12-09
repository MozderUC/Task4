using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;
using Task4.CustomDataClass;

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

            return rep;
        }
    }
}
