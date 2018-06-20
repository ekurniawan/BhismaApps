using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleSyncfusion.Models
{
    public class LogData
    {
        [PrimaryKey,AutoIncrement]
        public int LogID { get; set; }
        public DateTime TanggalPercobaan { get; set; }
        public string Nama { get; set; }
        public int Usia { get; set; }
        public string Gender { get; set; }
        public long WaktuMulai { get; set; }
        public long WaktuSelesai { get; set; }
        public long Interval { get; set; }
        public string JawabanAkhir { get; set; }
        public string HistoriJawaban { get; set; }
        public int JumlahLangkah { get; set; }
        public string KodeJenisSoal { get; set; }
        //public int CategoryID { get; set; }
    }
}
