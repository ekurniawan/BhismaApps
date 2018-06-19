using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleSyncfusion.Models
{
    public class Biodata
    {
        [PrimaryKey]
        public string BiodataID { get; set; }
        public string Nama { get; set; }
        public int Usia { get; set; }
        public string Gender { get; set; }
    }
}
