using SampleSyncfusion.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleSyncfusion
{
    public class Global
    {
        public Global()
        {
            myData = new LogData();
        }

        private static Global _instance;
        public static Global Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Global();
                }
                return _instance;
            }
        }
        public LogData myData { get; set; }
    }
}
