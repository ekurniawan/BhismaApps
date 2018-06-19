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
    public partial class SubListViewGridMakanan : ContentPage
    {
        public SubListViewGridMakanan()
        {
            InitializeComponent();
            subListView.ItemTapped += SubListView_ItemTapped;
        }

        private void SubListView_ItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            var item = (SubCategoryItem)e.ItemData;
            Global.Instance.myData.HistoriJawaban += item.SubCategoryID.ToString() + ",";
            if (item.SubCategoryItems == null)
            {
                var detailPage = new DetailPageMakanan();
                detailPage.BindingContext = item;
                Navigation.PushAsync(detailPage);
            }
            else
            {
                var subPage = new SubListViewGridMakanan();
                subPage.BindingContext = item;
                Navigation.PushAsync(subPage);
            }
            
        }
    }
}