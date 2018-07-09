using SampleSyncfusion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleSyncfusion
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPageMakanan : ContentPage
    {
        public DetailPageMakanan()
        {
            InitializeComponent();
            btnBeli.Clicked += BtnBeli_Clicked;
        }

        private async void BtnBeli_Clicked(object sender, EventArgs e)
        {
            Global.Instance.myData.WaktuSelesai = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            Global.Instance.myData.Interval = Global.Instance.myData.WaktuSelesai -
                Global.Instance.myData.WaktuMulai;

            //menambahkan data kedalam database sqlite
            var newLogData = new LogData
            {

            };

            //App.DBUtils.InsertLogData(newLogData);

            string data = Global.Instance.myData.Interval.ToString() + " " + Global.Instance.myData.Nama + " " +
                Global.Instance.myData.KodeJenisSoal + " "+Global.Instance.myData.HistoriJawaban;

            await DisplayAlert("Keterangan", "Selamat proses transaksi berhasil - "+data, "OK");
            await Navigation.PopToRootAsync();
        }
    }
}