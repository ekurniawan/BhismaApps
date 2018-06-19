using SampleSyncfusion.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SampleSyncfusion.ViewModels
{
    public class KategoriTempatViewModel : BindableObject
    {
        public List<CategoryItem> CategoryItems { get; set; }
        public KategoriTempatViewModel()
        {
            CategoryItems = new List<CategoryItem>();
            CategoryItems.Add(new CategoryItem
            {
                CategoryID = 1,
                CategoryName = "Fasilitas Transportasi",
                CategoryDescription = "Fasilitas Transportasi",
                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.gambar1.jpg"),
                SubCategoryItems = new List<SubCategoryItem>()
                {
                    new SubCategoryItem
                    {
                        SubCategoryID=11,
                        CategoryName = "Kepiting Lada Hitam",
                        CategoryDescription = "Kepiting Lada Hitam",
                        Harga=140000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kepiting-lada-hitam.jpg"),

                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=12,
                        CategoryName = "Kerang Rebus",
                        CategoryDescription = "Kerang Rebus",
                        Harga=35000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=13,
                        CategoryName = "Udang Goreng Tepung",
                        CategoryDescription = "Udang Goreng Tepung",
                        Harga=45000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.udang-goreng-tepung.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=14,
                        CategoryName = "Cumi Asam Manis",
                        CategoryDescription = "Cumi Asam Manis",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=15,
                        CategoryName = "Udang Goreng Mentega",
                        CategoryDescription = "Udang Goreng Mentega",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=16,
                        CategoryName = "Cumi Goreng Tepung",
                        CategoryDescription = "Cumi Goreng Tepung",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=17,
                        CategoryName = "Tumis Kerang Bumbu Pedas",
                        CategoryDescription = "Tumis Kerang Bumbu Pedas",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=18,
                        CategoryName = "Kerang Saus Tiram",
                        CategoryDescription = "Kerang Saus Tiram",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=19,
                        CategoryName = "Nasi Goreng Seafood",
                        CategoryDescription = "Nasi Goreng Seafood",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    }
                }
            });
            CategoryItems.Add(new CategoryItem
            {
                CategoryID = 2,
                CategoryName = "Fasilitas Rekreasi",
                CategoryDescription = "Fasilitas Rekreasi",
                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.gambar2.jpg"),
                SubCategoryItems = new List<SubCategoryItem>()
                {
                    new SubCategoryItem
                    {
                        SubCategoryID=21,
                        CategoryName = "Pisang",
                        CategoryDescription = "Buah Pisang",
                        Harga=140000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kepiting-lada-hitam.jpg"),

                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=22,
                        CategoryName = "Rambutan",
                        CategoryDescription = "Rambutan",
                        Harga=35000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=23,
                        CategoryName = "Jambu",
                        CategoryDescription = "Jambu",
                        Harga=45000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.udang-goreng-tepung.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=24,
                        CategoryName = "Durian",
                        CategoryDescription = "Durian",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=25,
                        CategoryName = "Pepaya",
                        CategoryDescription = "Pepaya",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=26,
                        CategoryName = "Manggis",
                        CategoryDescription = "Manggis",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=27,
                        CategoryName = "Sawo",
                        CategoryDescription = "Sawo",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=28,
                        CategoryName = "Semangka",
                        CategoryDescription = "Semangka",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=29,
                        CategoryName = "Jeruk",
                        CategoryDescription = "Jeruk",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    }
                }
            });
            CategoryItems.Add(new CategoryItem
            {
                CategoryID = 3,
                CategoryName = "Fasilitas Pendidikan",
                CategoryDescription = "Fasilitas Pendidikan",
                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.gambar3.jpg"),
                SubCategoryItems = new List<SubCategoryItem>()
                {
                    new SubCategoryItem
                    {
                        SubCategoryID=31,
                        CategoryName = "Ca Kangkung",
                        CategoryDescription = "Ca Kangkung",
                        Harga=140000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kepiting-lada-hitam.jpg"),

                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=32,
                        CategoryName = "Capjay Goreng",
                        CategoryDescription = "Capcay Goreng",
                        Harga=35000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=33,
                        CategoryName = "Jangan Bening",
                        CategoryDescription = "Jangan Bening",
                        Harga=45000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.udang-goreng-tepung.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=34,
                        CategoryName = "Sayur Asem",
                        CategoryDescription = "Sayur Asem",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=35,
                        CategoryName = "Sayur Lodeh",
                        CategoryDescription = "Sayur Lodeh",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=36,
                        CategoryName = "Sayur Bayam",
                        CategoryDescription = "Sayur Bayam",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=37,
                        CategoryName = "Gado-gado",
                        CategoryDescription = "Gado-gado",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=38,
                        CategoryName = "Tumis Buncis",
                        CategoryDescription = "Tumis Buncis",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=39,
                        CategoryName = "Acar Kuning",
                        CategoryDescription = "Acar Kuning",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    }
                }
            });
            CategoryItems.Add(new CategoryItem
            {
                CategoryID = 4,
                CategoryName = "Kantor Pemerintahan",
                CategoryDescription = "Kantor Pemerintahan",
                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.gambar3.jpg"),
                SubCategoryItems = new List<SubCategoryItem>()
                {
                    new SubCategoryItem
                    {
                        SubCategoryID=41,
                        CategoryName = "Wader Goreng",
                        CategoryDescription = "Wader Goreng",
                        Harga=140000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kepiting-lada-hitam.jpg"),
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=42,
                        CategoryName = "Nila Goreng",
                        CategoryDescription = "Nila Goreng",
                        Harga=35000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=43,
                        CategoryName = "Gurame Bakar",
                        CategoryDescription = "Gurame Bakar",
                        Harga=45000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.udang-goreng-tepung.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=44,
                        CategoryName = "Mangut Lele",
                        CategoryDescription = "Mangut Lele",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=45,
                        CategoryName = "Pecel Lele",
                        CategoryDescription = "Pecel Lele",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=46,
                        CategoryName = "Bawal Asam Manis",
                        CategoryDescription = "Bawal Asam Manis",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=47,
                        CategoryName = "Gabus Sambal Matah",
                        CategoryDescription = "Gabus Sambal Matah",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=48,
                        CategoryName = "Patin Masak Tauco",
                        CategoryDescription = "Patin Masak Tauco",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=49,
                        CategoryName = "Bandeng Presto",
                        CategoryDescription = "Bandeng Presto",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    }
                }
            });
            CategoryItems.Add(new CategoryItem
            {
                CategoryID = 5,
                CategoryName = "Fasilitas Kesehatan",
                CategoryDescription = "Makanan Olahan Ayam",
                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.gambar3.jpg"),
                SubCategoryItems = new List<SubCategoryItem>()
                {
                    new SubCategoryItem
                    {
                        SubCategoryID=51,
                        CategoryName = "Sate Ayam",
                        CategoryDescription = "Sate Ayam",
                        Harga=140000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kepiting-lada-hitam.jpg"),
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=52,
                        CategoryName = "Ayam Goreng",
                        CategoryDescription = "Ayam Goreng",
                        Harga=35000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=53,
                        CategoryName = "Ayam Bakar",
                        CategoryDescription = "Ayam Bakar",
                        Harga=45000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.udang-goreng-tepung.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=54,
                        CategoryName = "Ayam Nugget",
                        CategoryDescription = "Ayam Nugget",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=55,
                        CategoryName = "Sosis Ayam",
                        CategoryDescription = "Sosis Ayam",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=56,
                        CategoryName = "Gudeg Suwir",
                        CategoryDescription = "Gudeg Suwir",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=57,
                        CategoryName = "Opor Ayam",
                        CategoryDescription = "Opor Ayam",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=58,
                        CategoryName = "Ayam Taliwang",
                        CategoryDescription = "Ayam Taliwang",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=59,
                        CategoryName = "Ayam Betutu",
                        CategoryDescription = "Ayam Betutu",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                    }
                }
            });
            CategoryItems.Add(new CategoryItem
            {
                CategoryID = 6,
                CategoryName = "Fasilitas Olah Raga",
                CategoryDescription = "Pencuci Mulut",
                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.gambar3.jpg")
            });
            CategoryItems.Add(new CategoryItem
            {
                CategoryID = 7,
                CategoryName = "Fasilitas Ibadah",
                CategoryDescription = "Minuman",
                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.gambar3.jpg"),
                SubCategoryItems = new List<SubCategoryItem>()
                {
                    new SubCategoryItem
                    {
                        SubCategoryID=71,
                        CategoryName = "Islam",
                        CategoryDescription = "Minuman Kemasan",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kepiting-lada-hitam.jpg"),
                        SubCategoryItems = new List<SubCategoryItem>()
                        {
                            new SubCategoryItem
                            {
                                SubCategoryID=711,
                                CategoryName = "Teh Kotak",
                                CategoryDescription = "Teh Kotak",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kepiting-lada-hitam.jpg"),
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=712,
                                CategoryName = "Susu Ultra",
                                CategoryDescription = "Susu Ultra",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                            }
                        }
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=72,
                        CategoryName = "Kristen Katolik",
                        CategoryDescription = "Minuman Tradisional",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg"),
                        SubCategoryItems = new List<SubCategoryItem>()
                        {
                            new SubCategoryItem
                            {
                                SubCategoryID=721,
                                CategoryName = "Wedang Uwuh",
                                CategoryDescription = "Wedang Uwuh",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kepiting-lada-hitam.jpg"),
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=722,
                                CategoryName = "Wedang Ronde",
                                CategoryDescription = "Wedang Ronde",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-rebus.jpg")
                            }
                        }
                    }
                }
            });
            CategoryItems.Add(new CategoryItem
            {
                CategoryID = 8,
                CategoryName = "Fasilitas Perbelanjaan",
                CategoryDescription = "Makanan Ringan",
                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.gambar3.jpg")
            });
            CategoryItems.Add(new CategoryItem
            {
                CategoryID = 9,
                CategoryName = "Fasilitas Keuangan",
                CategoryDescription = "Makanan Olahan Sapi",
                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.gambar3.jpg")
            });

        }
    }
}
