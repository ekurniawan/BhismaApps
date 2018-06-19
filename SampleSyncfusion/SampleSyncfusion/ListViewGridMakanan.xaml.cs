using SampleSyncfusion.Models;
using SampleSyncfusion.ViewModels;
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
    public partial class ListViewMakanan : ContentPage
    {
        public ListViewMakanan()
        {
            InitializeComponent();
            this.BindingContext = new KategoriMakananViewModel();
            lvMakanan.ItemTapped += LvMakanan_ItemTapped;
        }

        private void LvMakanan_ItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            var item = (CategoryItem)e.ItemData;
            Global.Instance.myData.HistoriJawaban += item.CategoryID.ToString()+",";
            var subPage = new SubListViewGridMakanan();
            subPage.BindingContext = item;
            Navigation.PushAsync(subPage);
        }
    }
}