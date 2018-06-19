using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SampleSyncfusion.Models
{
    public class CategoryItem
    {
        public int CategoryID { get; set; }
        public ImageSource CategoryImage { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public List<SubCategoryItem> SubCategoryItems { get; set; }
    }
}
