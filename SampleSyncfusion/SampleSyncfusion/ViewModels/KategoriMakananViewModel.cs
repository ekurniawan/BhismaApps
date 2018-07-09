using SampleSyncfusion.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SampleSyncfusion.ViewModels
{
    public class KategoriMakananViewModel : BindableObject
    {
        public List<CategoryItem> CategoryItems { get; set; }
        public KategoriMakananViewModel()
        {
            CategoryItems = new List<CategoryItem>();
            CategoryItems.Add(new CategoryItem
            {
                CategoryID = 1,
                CategoryName = "Makanan Hasil Laut",
                CategoryDescription = "Makanan Hasil Laut",
                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.makanan-hasil-laut.jpg"),
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
                        Harga=28000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.udang-goreng-tepung.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=14,
                        CategoryName = "Cumi Asam Manis",
                        CategoryDescription = "Cumi Asam Manis",
                        Harga=28000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.cumi-asam-manis.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=15,
                        CategoryName = "Udang Goreng Mentega",
                        CategoryDescription = "Udang Goreng Mentega",
                        Harga=28000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.udang-goreng-mentega.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=16,
                        CategoryName = "Cumi Goreng Tepung",
                        CategoryDescription = "Cumi Goreng Tepung",
                        Harga=25000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.cumi-goreng-tepung.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=17,
                        CategoryName = "Tumis Kerang Bumbu Pedas",
                        CategoryDescription = "Tumis Kerang Bumbu Pedas",
                        Harga=30000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.tumis-kerang-bumbu-pedas.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=18,
                        CategoryName = "Kerang Saus Tiram",
                        CategoryDescription = "Kerang Saus Tiram",
                        Harga=35000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.kerang-saus-tiram.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=19,
                        CategoryName = "Nasi Goreng Seafood",
                        CategoryDescription = "Nasi Goreng Seafood",
                        Harga=25000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.HasilLaut.nasi-goreng-seafood.jpg")
                    }
                }
            });
            CategoryItems.Add(new CategoryItem
            {
                CategoryID = 2,
                CategoryName = "Buah-buahan",
                CategoryDescription = "Buah-buahan",
                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.buah-buahan.jpg"),
                SubCategoryItems = new List<SubCategoryItem>()
                {
                    new SubCategoryItem
                    {
                        SubCategoryID=21,
                        CategoryName = "Pisang",
                        CategoryDescription = "Buah Pisang",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Buah.pisang.jpg"),

                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=22,
                        CategoryName = "Rambutan",
                        CategoryDescription = "Buah Rambutan",
                        Harga=14000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Buah.rambutan.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=23,
                        CategoryName = "Jambu",
                        CategoryDescription = "Buah Jambu",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Buah.jambu-biji.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=24,
                        CategoryName = "Durian",
                        CategoryDescription = "Buah Durian",
                        Harga=25000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Buah.durian.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=25,
                        CategoryName = "Pepaya",
                        CategoryDescription = "Buah Pepaya",
                        Harga=20000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Buah.pepaya.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=26,
                        CategoryName = "Manggis",
                        CategoryDescription = "Buah Manggis",
                        Harga=27500,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Buah.manggis.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=27,
                        CategoryName = "Sawo",
                        CategoryDescription = "Buah Sawo",
                        Harga=6000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Buah.sawo.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=28,
                        CategoryName = "Semangka",
                        CategoryDescription = "Buah Semangka",
                        Harga=12000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Buah.semangka.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=29,
                        CategoryName = "Jeruk",
                        CategoryDescription = "Buah Jeruk",
                        Harga=17000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Buah.jeruk.jpg")
                    }
                }
            });
            CategoryItems.Add(new CategoryItem
            {
                CategoryID = 3,
                CategoryName = "Sayur",
                CategoryDescription = "Sayur-sayuran",
                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.sayur-sayuran.jpg"),
                SubCategoryItems = new List<SubCategoryItem>()
                {
                    new SubCategoryItem
                    {
                        SubCategoryID=31,
                        CategoryName = "Ca Kangkung",
                        CategoryDescription = "Ca Kangkung",
                        Harga=10000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Sayur.ca-kangkung.jpg"),

                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=32,
                        CategoryName = "Capcay Goreng",
                        CategoryDescription = "Capcay Goreng",
                        Harga=12000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Sayur.capcay-goreng.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=33,
                        CategoryName = "Jangan Bening",
                        CategoryDescription = "Jangan Bening",
                        Harga=8000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Sayur.jangan-bening.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=34,
                        CategoryName = "Sayur Asem",
                        CategoryDescription = "Sayur Asem",
                        Harga=10000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Sayur.sayur-asem.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=35,
                        CategoryName = "Sayur Lodeh",
                        CategoryDescription = "Sayur Lodeh",
                        Harga=12000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Sayur.sayur-lodeh.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=36,
                        CategoryName = "Sayur Bayam",
                        CategoryDescription = "Sayur Bayam",
                        Harga=8000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Sayur.sayur-bayam.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=37,
                        CategoryName = "Gado-gado",
                        CategoryDescription = "Gado-gado",
                        Harga=10000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Sayur.gado-gado.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=38,
                        CategoryName = "Tumis Buncis",
                        CategoryDescription = "Tumis Buncis",
                        Harga=12000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Sayur.tumis-buncis.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=39,
                        CategoryName = "Acar Kuning",
                        CategoryDescription = "Acar Kuning",
                        Harga=10000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Sayur.acar-kuning.jpg")
                    }
                }
            });
            CategoryItems.Add(new CategoryItem
            {
                CategoryID = 4,
                CategoryName = "Makanan Olahan Ikan",
                CategoryDescription = "Makanan Olahan Ikan",
                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.makanan-olahan-ikan.jpg"),
                SubCategoryItems = new List<SubCategoryItem>()
                {
                    new SubCategoryItem
                    {
                        SubCategoryID=41,
                        CategoryName = "Wader Goreng",
                        CategoryDescription = "Wader Goreng",
                        Harga=12000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.OlahanIkan.wader-goreng.jpg"),
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=42,
                        CategoryName = "Nila Goreng",
                        CategoryDescription = "Nila Goreng",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.OlahanIkan.nila-goreng.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=43,
                        CategoryName = "Gurame Bakar",
                        CategoryDescription = "Gurame Bakar",
                        Harga=25000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.OlahanIkan.gurame-bakar.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=44,
                        CategoryName = "Mangut Lele",
                        CategoryDescription = "Mangut Lele",
                        Harga=12000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.OlahanIkan.mangut-lele.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=45,
                        CategoryName = "Pecel Lele",
                        CategoryDescription = "Pecel Lele",
                        Harga=12000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.OlahanIkan.pecel-lele.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=46,
                        CategoryName = "Bawal Asam Manis",
                        CategoryDescription = "Bawal Asam Manis",
                        Harga=17000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.OlahanIkan.bawal-asam-manis.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=47,
                        CategoryName = "Gabus Sambal Matah",
                        CategoryDescription = "Gabus Sambal Matah",
                        Harga=23000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.OlahanIkan.gabus-sambal-matah.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=48,
                        CategoryName = "Patin Masak Tauco",
                        CategoryDescription = "Patin Masak Tauco",
                        Harga=20000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.OlahanIkan.patin-masak-tauco.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=49,
                        CategoryName = "Bandeng Presto",
                        CategoryDescription = "Bandeng Presto",
                        Harga=20000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.OlahanIkan.bandeng-presto.jpg")
                    }
                }
            });
            CategoryItems.Add(new CategoryItem
            {
                CategoryID = 5,
                CategoryName = "Makanan Olahan Ayam",
                CategoryDescription = "Makanan Olahan Ayam",
                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.makanan-olahan-ayam.jpg"),
                SubCategoryItems = new List<SubCategoryItem>()
                {
                    new SubCategoryItem
                    {
                        SubCategoryID=51,
                        CategoryName = "Sate Ayam",
                        CategoryDescription = "Sate Ayam",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.OlahanAyam.sate-ayam.jpg"),
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=52,
                        CategoryName = "Ayam Goreng",
                        CategoryDescription = "Ayam Goreng",
                        Harga=13000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.OlahanAyam.ayam-goreng.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=53,
                        CategoryName = "Ayam Bakar",
                        CategoryDescription = "Ayam Bakar",
                        Harga=13000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.OlahanAyam.ayam-bakar.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=54,
                        CategoryName = "Ayam Nugget",
                        CategoryDescription = "Ayam Nugget",
                        Harga=10000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.OlahanAyam.ayam-nugget.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=55,
                        CategoryName = "Sosis Ayam",
                        CategoryDescription = "Sosis Ayam",
                        Harga=10000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.OlahanAyam.sosis-ayam.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=56,
                        CategoryName = "Gudeg Suwir",
                        CategoryDescription = "Gudeg Suwir",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.OlahanAyam.gudeg-suwir.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=57,
                        CategoryName = "Opor Ayam",
                        CategoryDescription = "Opor Ayam",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.OlahanAyam.opor-ayam.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=58,
                        CategoryName = "Ayam Taliwang",
                        CategoryDescription = "Ayam Taliwang",
                        Harga=65000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.OlahanAyam.ayam-taliwang.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=59,
                        CategoryName = "Ayam Betutu",
                        CategoryDescription = "Ayam Betutu",
                        Harga=80000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.OlahanAyam.ayam-betutu.jpg")
                    }
                }
            });
            CategoryItems.Add(new CategoryItem
            {
                CategoryID = 6,
                CategoryName = "Pencuci Mulut",
                CategoryDescription = "Pencuci Mulut",
                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.pencuci-mulut.jpg"),
                SubCategoryItems = new List<SubCategoryItem>()
                {
                    new SubCategoryItem
                    {
                        SubCategoryID=61,
                        CategoryName = "Puding Mangga",
                        CategoryDescription = "Puding Mangga",
                        Harga=5000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.PencuciMulut.puding-mangga.jpg"),
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=62,
                        CategoryName = "Es Krim",
                        CategoryDescription = "Es Krim",
                        Harga=10000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.PencuciMulut.es-krim.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=63,
                        CategoryName = "Black Forest",
                        CategoryDescription = "Black Forest",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.PencuciMulut.black-forest.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=64,
                        CategoryName = "Tiramisu",
                        CategoryDescription = "Tiramisu",
                        Harga=20000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.PencuciMulut.tiramisu.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=65,
                        CategoryName = "Cheese Cake",
                        CategoryDescription = "Cheese Cake",
                        Harga=12500,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.PencuciMulut.cheese-cake.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=66,
                        CategoryName = "Es Teler",
                        CategoryDescription = "Es Teler",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.PencuciMulut.es-teler.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=67,
                        CategoryName = "Gelato",
                        CategoryDescription = "Gelato",
                        Harga=20000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.PencuciMulut.gelato.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=68,
                        CategoryName = "Rujak Serut",
                        CategoryDescription = "Rujak Serut",
                        Harga=12000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.PencuciMulut.rujak-serut.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=69,
                        CategoryName = "Es Pisang Ijo",
                        CategoryDescription = "Es Pisang Ijo",
                        Harga=10000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.PencuciMulut.es-pisang-ijo.jpg")
                    }
                }
            });
            CategoryItems.Add(new CategoryItem
            {
                CategoryID = 7,
                CategoryName = "Minuman",
                CategoryDescription = "Minuman",
                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.minuman.jpg"),
                SubCategoryItems = new List<SubCategoryItem>()
                {
                    new SubCategoryItem
                    {
                        SubCategoryID=71,
                        CategoryName = "Minuman Kemasan",
                        CategoryDescription = "Minuman Kemasan",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.minuman-kemasan.jpg"),
                        SubCategoryItems = new List<SubCategoryItem>()
                        {
                            new SubCategoryItem
                            {
                                SubCategoryID=711,
                                CategoryName = "Teh Kotak",
                                CategoryDescription = "Teh Kotak",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Minuman.Kemasan.teh-kotak.jpg"),
                                Harga=3500
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=712,
                                CategoryName = "Susu Ultra",
                                CategoryDescription = "Susu Ultra",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Minuman.Kemasan.susu-ultra.jpg"),
                                Harga=5000
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=713,
                                CategoryName = "Coca Cola",
                                CategoryDescription = "Coca Cola",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Minuman.Kemasan.coca-cola.jpg"),
                                Harga=7500
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=714,
                                CategoryName = "Fruit Tea",
                                CategoryDescription = "Fruit Tea",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Minuman.Kemasan.fruit-tea.jpg"),
                                Harga=6000
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=715,
                                CategoryName = "Sprite",
                                CategoryDescription = "Sprite",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Minuman.Kemasan.sprite.jpg"),
                                Harga=7500
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=716,
                                CategoryName = "Minute Maid",
                                CategoryDescription = "Minute Maid",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Minuman.Kemasan.minute-maid.jpg"),
                                Harga=13000
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=717,
                                CategoryName = "Cimory",
                                CategoryDescription = "Cimory",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Minuman.Kemasan.cimory.jpg"),
                                Harga=8500
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=718,
                                CategoryName = "Pocary Sweat",
                                CategoryDescription = "Pocary Sweat",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Minuman.Kemasan.pocary-sweat.jpg"),
                                Harga=8000
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=719,
                                CategoryName = "Buavita",
                                CategoryDescription = "Buavita",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Minuman.Kemasan.buavita.jpg"),
                                Harga=8000
                            }
                        }
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=72,
                        CategoryName = "Minuman Tradisional",
                        CategoryDescription = "Minuman Tradisional",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.minuman-tradisional.jpg"),
                        SubCategoryItems = new List<SubCategoryItem>()
                        {
                            new SubCategoryItem
                            {
                                SubCategoryID=721,
                                CategoryName = "Wedang Uwuh",
                                CategoryDescription = "Wedang Uwuh",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Minuman.Tradisional.wedang-uwuh.jpg"),
                                Harga=5000
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=722,
                                CategoryName = "Wedang Ronde",
                                CategoryDescription = "Wedang Ronde",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Minuman.Tradisional.wedang-ronde.jpg"),
                                Harga=10000
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=723,
                                CategoryName = "STMJ",
                                CategoryDescription = "Susu Telur Madu Jahe",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Minuman.Tradisional.stmj.jpg"),
                                Harga=10000
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=724,
                                CategoryName = "Wedang Jahe",
                                CategoryDescription = "Wedang Jahe",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Minuman.Tradisional.wedang-jahe.jpg"),
                                Harga=6000
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=725,
                                CategoryName = "Es Degan",
                                CategoryDescription = "Es Degan",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Minuman.Tradisional.es-degan.jpg"),
                                Harga=4000
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=726,
                                CategoryName = "Es Dawet",
                                CategoryDescription = "Es Dawet",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Minuman.Tradisional.es-dawet.jpg"),
                                Harga=10000
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=727,
                                CategoryName = "Es Cendol",
                                CategoryDescription = "Es Cendol",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Minuman.Tradisional.es-cendol.jpg"),
                                Harga=10000
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=728,
                                CategoryName = "Sekoteng",
                                CategoryDescription = "Sekoteng",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Minuman.Tradisional.sekoteng.jpg"),
                                Harga=4000
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=729,
                                CategoryName = "Kunyit Asem",
                                CategoryDescription = "Kunyit Asem",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.Minuman.Tradisional.kunyit-asem.jpg"),
                                Harga=5000
                            }
                        }
                    }
                }
            });
            CategoryItems.Add(new CategoryItem
            {
                CategoryID = 8,
                CategoryName = "Makanan Ringan",
                CategoryDescription = "Makanan Ringan",
                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.makanan-ringan.jpg"),
                SubCategoryItems = new List<SubCategoryItem>()
                {
                    new SubCategoryItem
                    {
                        SubCategoryID=81,
                        CategoryName = "Risoles",
                        CategoryDescription = "Risoles",
                        Harga=4000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.MakananRingan.risoles.jpg"),
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=82,
                        CategoryName = "Lemper",
                        CategoryDescription = "Lemper",
                        Harga=3000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.MakananRingan.lemper.jpg"),
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=83,
                        CategoryName = "Tahu Goreng",
                        CategoryDescription = "Tahu Goreng",
                        Harga=3500,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.MakananRingan.tahu-goreng.jpg"),
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=84,
                        CategoryName = "Putu",
                        CategoryDescription = "Putu",
                        Harga=8000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.MakananRingan.putu-ngungg.jpg"),
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=85,
                        CategoryName = "Klepon",
                        CategoryDescription = "Klepon",
                        Harga=2500,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.MakananRingan.klepon.jpg"),
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=86,
                        CategoryName = "Cilok",
                        CategoryDescription = "Cilok",
                        Harga=4000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.MakananRingan.cilok.jpg"),
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=87,
                        CategoryName = "Bika Ambon",
                        CategoryDescription = "Bika Ambon",
                        Harga=10000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.MakananRingan.bika-ambon.jpg"),
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=88,
                        CategoryName = "Lapis Legit",
                        CategoryDescription = "Lapis Legit",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.MakananRingan.lapis-legit.jpg"),
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=89,
                        CategoryName = "Getuk Goreng",
                        CategoryDescription = "Getuk Goreng",
                        Harga=4000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.MakananRingan.getuk-goreng.jpg"),
                    }
                }
            });
            CategoryItems.Add(new CategoryItem
            {
                CategoryID = 9,
                CategoryName = "Makanan Olahan Sapi",
                CategoryDescription = "Makanan Olahan Sapi",
                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.makanan-olahan-sapi.jpg"),
                SubCategoryItems = new List<SubCategoryItem>()
                {
                    new SubCategoryItem
                    {
                        SubCategoryID=91,
                        CategoryName = "Bakso Sapi",
                        CategoryDescription = "Bakso Sapi",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.OlahanSapi.bakso-sapi.jpg"),
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=92,
                        CategoryName = "Sapi Lada Hitam",
                        CategoryDescription = "Sapi Lada Hitam",
                        Harga=30000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.OlahanSapi.sapi-lada-hitam.jpg"),
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=93,
                        CategoryName = "Rendang",
                        CategoryDescription = "Rendang",
                        Harga=20000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.OlahanSapi.rendang(2).jpg"),
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=94,
                        CategoryName = "Rawon",
                        CategoryDescription = "Rawon",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.OlahanSapi.rawon.jpg"),
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=95,
                        CategoryName = "Terik Daging",
                        CategoryDescription = "Terik Daging",
                        Harga=15000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.OlahanSapi.terik-daging.jpg"),
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=96,
                        CategoryName = "Dendeng Balado",
                        CategoryDescription = "Dendeng Balado",
                        Harga=30000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.OlahanSapi.dendeng-balado.jpg"),
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=97,
                        CategoryName = "Sop Buntut",
                        CategoryDescription = "Sop Buntut",
                        Harga=25000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.OlahanSapi.sop_buntut.jpg"),
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=98,
                        CategoryName = "Dendeng Balado",
                        CategoryDescription = "Dendeng Balado",
                        Harga=30000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.OlahanSapi.dendeng-balado.jpg"),
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=99,
                        CategoryName = "Empal Gentong",
                        CategoryDescription = "Empal Gentong",
                        Harga=25000,
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Makanan.OlahanSapi.empal-gentong(2).jpg"),
                    }
                }
            });
        }
    }
}
