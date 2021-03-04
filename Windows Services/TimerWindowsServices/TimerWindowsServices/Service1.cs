﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimerWindowsServices
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }
        Timer timer = new Timer();
        protected override void OnStart(string[] args)
        {
            WriteToFile($"Current Service starts at {DateTime.Now}");
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 10000;
            timer.Enabled = true;
        }

        protected override void OnStop()
        {
            WriteToFile($"Current Service ends at {DateTime.Now}");
        }
        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            WriteToFile($"Current Service recalls at {DateTime.Now}");
        }
        private void WriteToFile(string msg)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\ServiceLog_" + DateTime.Now.ToShortDateString().Replace('/', '_') + ".txt";
            if (!File.Exists(filepath))
            {
                using (StreamWriter writer = File.CreateText(filepath))
                {
                    writer.WriteLine(msg);
                }
            }
            else
            {
                using (StreamWriter writer = File.AppendText(filepath))
                {
                    writer.WriteLine(msg);
                }
            }
        }
    }
}