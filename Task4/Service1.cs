﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Task4.WatcherReportLogic;

namespace Task4
{
    public partial class Service1 : ServiceBase
    {
        //private Watcher watcer = new Watcher();
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
           Watcher watcer = new Watcher();
        }

        protected override void OnStop()
        {
            //watcer.Dispose();
        }
    }
}
