using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Task4.DTO;
using DAL.Interfaces;
using DAL.Repositories;
using System.Configuration;

namespace Task4.WatcherReportLogic
{
    class Watcher
    {        
        private ServiceModule service;
        private FileSystemWatcher dirWatcher;
        private Task task;

        public Watcher()
        {              
            service = new ServiceModule();            
            dirWatcher = new FileSystemWatcher(@"D:\CSVFiles");            
            dirWatcher.Filter = "*.csv";
            dirWatcher.NotifyFilter = NotifyFilters.FileName;

            dirWatcher.Changed += new FileSystemEventHandler(GetTask);
            dirWatcher.Created += new FileSystemEventHandler(GetTask);
            dirWatcher.EnableRaisingEvents = true;
        }
     
        public void GetTask(object source, FileSystemEventArgs e)
        {            
            task = new Task(() => StartParsing(source, e));
            task.Start();
        }
        public void StartParsing(object source, FileSystemEventArgs e)
        {
            service.HandleReports(e.FullPath);          
        }
        public void Dispose()
        {
            dirWatcher.Dispose();
        }
    }
}
