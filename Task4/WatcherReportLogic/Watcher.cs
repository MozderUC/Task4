using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Task4.CustomDataClass;

namespace Task4.WatcherReportLogic
{
    class Watcher
    {
        //private RecordsHandler recordsHandler;
        private ReportParser parser;
        private FileSystemWatcher dirWatcher;
        private Task task;

        public Watcher()
        {
            parser = new ReportParser();

            //_recordsHandler = new RecordsHandler();
            dirWatcher = new FileSystemWatcher(@"D:\CSVFiles");
            //_fileWatcher.Path = ConfigurationManager.AppSettings[@"D:\CSVFiles"];
            dirWatcher.Filter = "*.csv";
            dirWatcher.NotifyFilter = NotifyFilters.FileName;

            dirWatcher.Changed += new FileSystemEventHandler(OnChanged);
            dirWatcher.Created += new FileSystemEventHandler(OnChanged);
            dirWatcher.EnableRaisingEvents = true;
        }

        public void run()
        {

        }
        public void OnChanged(object source, FileSystemEventArgs e)
        {
            task = new Task(() => CallParse(source, e));
            task.Start();
        }
        public void CallParse(object source, FileSystemEventArgs e)
        {            
            List<ManagerReport> rep = parser.getReportList(e.FullPath);


            //_recordsHandler.SaveRecords(path);
        }
        public void Dispose()
        {
            dirWatcher.Dispose();
        }
    }
}
