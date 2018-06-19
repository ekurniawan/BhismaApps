﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleSyncfusion
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuTest : ContentPage
    {
        public MenuTest()
        {
            InitializeComponent();
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            Global.Instance.myData.WaktuMulai = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
          
            
            Button btn = sender as Button;
            if(btn.Text == "List Makanan")
            {
                Global.Instance.myData.KodeJenisSoal = "M1";
                await Navigation.PushAsync(new ListViewMakanan());
            }
            else if(btn.Text== "Grid Makanan")
            {
                Global.Instance.myData.KodeJenisSoal = "M2";
                await Navigation.PushAsync(new GridViewMakanan());
            }
            else if(btn.Text == "Horisontal Makanan")
            {
                Global.Instance.myData.KodeJenisSoal = "M3";
                await Navigation.PushAsync(new HorizontalMakanan());
            }
        }
    }
}