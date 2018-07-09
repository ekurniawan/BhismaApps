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
                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.fasilitas-transportasi.jpg"),
                SubCategoryItems = new List<SubCategoryItem>()
                {
                    new SubCategoryItem
                    {
                        SubCategoryID=11,
                        CategoryName = "Bandara Adi Sutjipto",
                        CategoryDescription = "Bandara Adi Sutjipto",
                        Alamat="Jl. Raya Solo KM.9, Maguwoharjo, Kec. Depok, Kabupaten Sleman, Daerah Istimewa Yogyakarta 55282",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Transportasi.bandara-adi-sutjipto.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=12,
                        CategoryName = "Stasiun Lempuyangan",
                        CategoryDescription = "Stasiun Lempuyangan",
                        Alamat="Bausasran, Danurejan, Kota Yogyakarta, Daerah Istimewa Yogyakarta",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Transportasi.stasiun-lempuyangan.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=13,
                        CategoryName = "Stasiun Tugu",
                        CategoryDescription = "Stasiun Tugu",
                        Alamat="Jl. Ps. Kembang, Sosromenduran, Gedong Tengen, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55271",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Transportasi.stasiun-tugu.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=14,
                        CategoryName = "Terminal Jombor",
                        CategoryDescription = "Terminal Jombor",
                        Alamat="Jl. Magelang, Jombor Lor, Sinduadi, Mlati, Kabupaten Sleman, Daerah Istimewa Yogyakarta 55285",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Transportasi.terminal-jombor.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=15,
                        CategoryName = "Terminal Condong Catur",
                        CategoryDescription = "Terminal Condong Catur",
                        Alamat="Jl. Anggajaya 1, Gejayan, Condongcatur, Kec. Depok, Kabupaten Sleman, Daerah Istimewa Yogyakarta 55283",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Transportasi.terminal-condongcatur.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=16,
                        CategoryName = "Terminal Giwangan",
                        CategoryDescription = "Terminal Giwangan",
                        Alamat="Jl. Ps. Giwangan Lor, Giwangan, Umbulharjo, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55163",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Transportasi.terminal-giwangan.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=17,
                        CategoryName = "Stasiun Maguwo",
                        CategoryDescription = "Stasiun Maguwo",
                        Alamat="Maguwoharjo, 55282 Sleman, Indonesia, Karangploso, Maguwoharjo, Depok Sub-District, Sleman Regency, Special Region of Yogyakarta",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Transportasi.stasiun-maguwo.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=18,
                        CategoryName = "Travel Day Trans",
                        CategoryDescription = "Travel Day Trans",
                        Alamat="Jl. MT. Haryono, Suryodiningratan, Mantrijeron, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55141",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Transportasi.travel-day-trans.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=19,
                        CategoryName = "Travel Rama Sakti",
                        CategoryDescription = "Travel Rama Sakti",
                        Alamat="Jl. Pangeran Diponegoro No.73, Gowongan, Jetis, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55233",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Transportasi.travel-rama-sakti.jpg")
                    }
                }
            });
            CategoryItems.Add(new CategoryItem
            {
                CategoryID = 2,
                CategoryName = "Fasilitas Rekreasi",
                CategoryDescription = "Fasilitas Rekreasi",
                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.fasilitas-rekreasi.jpg"),
                SubCategoryItems = new List<SubCategoryItem>()
                {
                    new SubCategoryItem
                    {
                        SubCategoryID=21,
                        CategoryName = "Taman Pelangi",
                        CategoryDescription = "Taman Pelangi",
                        Alamat="Jl. Amerta Raya, Waras, Sariharjo, Ngaglik, Kabupaten Sleman, Daerah Istimewa Yogyakarta 55284",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Rekreasi.taman-pelangi.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=22,
                        CategoryName = "Taman Pintar",
                        CategoryDescription = "Taman Pintar",
                        Alamat="Jalan Panembahan Senopati No. 1-3, Gondomanan, Ngupasan, Gondomanan, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55122",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Rekreasi.taman-pintar.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=23,
                        CategoryName = "Candi Prambanan",
                        CategoryDescription = "Candi Prambanan",
                        Alamat="Jl. Jogja-Solo Km. 16 Prambanan, Yogyakarta INDONESIA 55282",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Rekreasi.candi-prambanan.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=24,
                        CategoryName = "Kids Fun Park",
                        CategoryDescription = "Kids Fun Park",
                        Alamat="Jl. Wonosari, Madugondo, Tegaltirto, Berbah, Kabupaten Sleman, Daerah Istimewa Yogyakarta 55573",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Rekreasi.kids-fun-park.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=25,
                        CategoryName = "Tamansari",
                        CategoryDescription = "Tamansari",
                        Alamat="Komplek Wisata Taman Sari, Taman, Kraton, Patehan, Kraton, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55133",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Rekreasi.taman-sari.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=26,
                        CategoryName = "Keraton Yogyakarta",
                        CategoryDescription = "Keraton Yogyakarta",
                        Alamat="Jalan Rotowijayan Blok No. 1, Panembahan, Kraton, Kota Yogyakarta, Daerah Istimewa Yogyakarta",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Rekreasi.keraton-yogyakarta.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=27,
                        CategoryName = "Kebun Binatang Gembiraloka",
                        CategoryDescription = "Kebun Binatang Gembiraloka",
                        Alamat="Jl. Kebun Raya No.2, Rejowinangun, Kotagede, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55171",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Rekreasi.gembira-loka.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=28,
                        CategoryName = "Pantai Parangtritis",
                        CategoryDescription = "Pantai Parangtritis",
                        Alamat="Jl. Parangtritis Km. 28 Parangtritis Yogyakarta INDONESIA 55188",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Rekreasi.parangtritis.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=29,
                        CategoryName = "Museum Sonobudoyo",
                        CategoryDescription = "Museum Sonobudoyo",
                        Alamat="Jl. Pangurakan No.6, Ngupasan, Gondomanan, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55122",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Rekreasi.museum-sonobudoyo.jpg")
                    }
                }
            });
            CategoryItems.Add(new CategoryItem
            {
                CategoryID = 3,
                CategoryName = "Fasilitas Pendidikan",
                CategoryDescription = "Fasilitas Pendidikan",
                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.fasilitas-pendidikan.jpg"),
                SubCategoryItems = new List<SubCategoryItem>()
                {
                    new SubCategoryItem
                    {
                        SubCategoryID=31,
                        CategoryName = "Universitas Gajah Mada",
                        CategoryDescription = "Universitas Gajah Mada",
                        Alamat="JL. Bulaksumur, Blimbing Sari, Caturtunggal, Kec. Depok, Kabupaten Sleman, Daerah Istimewa Yogyakarta 55281",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Pendidikan.universitas-gajah-mada.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=32,
                        CategoryName = "Universitas Negeri Yogyakarta",
                        CategoryDescription = "Universitas Negeri Yogyakarta",
                        Alamat="Jl. Colombo No.1, Caturtunggal, Depok, Karang Malang, Caturtunggal, Kec. Depok, Kabupaten Sleman, Daerah Istimewa Yogyakarta 55281",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Pendidikan.universitas-negeri-yogyakarta.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=33,
                        CategoryName = "Universitas Islam Indonesia",
                        CategoryDescription = "Universitas Islam Indonesia",
                        Alamat="Jalan Kaliurang Km. 14,5, Yogyakarta, Krawitan, Umbulmartani, Ngemplak, Kabupaten Sleman, Daerah Istimewa Yogyakarta 55584",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Pendidikan.universitas-islam-indonesia.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=34,
                        CategoryName = "Universitas Sanata Dharma",
                        CategoryDescription = "Universitas Sanata Dharma",
                        Alamat="Jl. Mrican Baru, Mrican, Caturtunggal, Kec. Depok, Kabupaten Sleman, Daerah Istimewa Yogyakarta 55281",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Pendidikan.universitas-sanata-dharma.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=35,
                        CategoryName = "SMA Kolese De Britto",
                        CategoryDescription = "SMA Kolese De Britto",
                        Alamat="Jalan Laksda Adisucipto No.161, Caturtunggal, Kecamatan Depok, Demangan Baru, Caturtunggal, Kec. Depok, Kabupaten Sleman, Daerah Istimewa Yogyakarta 55281",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Pendidikan.sma-kolese-de-britto.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=36,
                        CategoryName = "SMA Stella Duce",
                        CategoryDescription = "SMA Stella Duce",
                        Alamat="Jl. Sabirin No.1, Kotabaru, Gondokusuman, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55224",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Pendidikan.sma-stella-duce.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=37,
                        CategoryName = "SMA Negeri 6",
                        CategoryDescription = "SMA Negeri 6",
                        Alamat="Jalan C Simanjuntak No. 2, Terban, Gondokusuman, Terban, Gondokusuman, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55223",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Pendidikan.sma-negeri-6.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=38,
                        CategoryName = "SMA Negeri 3 Padmanaba",
                        CategoryDescription = "SMA Negeri 3 Padmanaba",
                        Alamat="Jalan Yos Sudarso No.7, Kotabaru, Gondokusuman, Kotabaru, Gondokusuman, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55224",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Pendidikan.sma-negeri-3-padmanaba.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=39,
                        CategoryName = "SD Teruna Bangsa",
                        CategoryDescription = "SD Teruna Bangsa",
                        Alamat="Jl. Seturan Bl. D No.10, Kledokan, Caturtunggal, Kec. Depok, Kabupaten Sleman, Daerah Istimewa Yogyakarta 55281",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Pendidikan.sd-teruna-bangsa.jpg")
                    }
                }
            });
            CategoryItems.Add(new CategoryItem
            {
                CategoryID = 4,
                CategoryName = "Kantor Pemerintahan",
                CategoryDescription = "Kantor Pemerintahan",
                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.kantor-pemerintahan.jpg"),
                SubCategoryItems = new List<SubCategoryItem>()
                {
                    new SubCategoryItem
                    {
                        SubCategoryID=41,
                        CategoryName = "Dinas Pendidikan Pemuda dan Olahraga",
                        CategoryDescription = "Dinas Pendidikan Pemuda dan Olahraga",
                        Alamat="Jl. Cendana No.9, Semaki, Umbulharjo, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55166",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Pemerintahan.dinas-pendidikan-pemuda-olahraga.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=42,
                        CategoryName = "Dinas Kebudayaan",
                        CategoryDescription = "Dinas Kebudayaan",
                        Alamat="Jl. Kapas No.22, Semaki, Umbulharjo, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55166",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Pemerintahan.dinas-kebudayaan.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=43,
                        CategoryName = "Dinas Sosial",
                        CategoryDescription = "Dinas Sosial",
                        Alamat="Jalan Janti, Kecamatan Banguntapan, Modalan, Banguntapan, Bantul, Daerah Istimewa Yogyakarta 55198",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Pemerintahan.dinas-sosial.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=44,
                        CategoryName = "Dinas Kesehatan",
                        CategoryDescription = "Dinas Kesehatan",
                        Alamat="Jalan Tompeyan TR III/201, Tegalrejo, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55244",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Pemerintahan.dinas-kesehatan.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=45,
                        CategoryName = "Badan Perencanaan Pembangunan Daerah",
                        CategoryDescription = "Badan Perencanaan Pembangunan Daerah",
                        Alamat="Kompleks Kepatihan, Jalan Malioboro, Danurejan, Suryatmajan, Danurejan, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55271",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Pemerintahan.badan-perencanaan-pembangunan-daerah.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=46,
                        CategoryName = "Badan Kepegawaian Daerah",
                        CategoryDescription = "Badan Kepegawaian Daerah",
                        Alamat="Jl. Kyai Mojo No.56, Bener, Tegalrejo, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55243",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Pemerintahan.badan-kepegawaian-daerah.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=47,
                        CategoryName = "Kantor Walikota",
                        CategoryDescription = "Kantor Walikota",
                        Alamat="Muja Muju, Umbulharjo, Yogyakarta City, Special Region of Yogyakarta 55165",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Pemerintahan.kantor-walikota.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=48,
                        CategoryName = "Kantor Kecamatan Gondokusuman",
                        CategoryDescription = "Kantor Kecamatan Gondokusuman",
                        Alamat="Jl. Munggur No.32, Demangan, Gondokusuman, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55221",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Pemerintahan.kantor-kecamatan-gondokusuman.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=49,
                        CategoryName = "Kantor Kecamatan Wirobrajan",
                        CategoryDescription = "Kantor Kecamatan Wirobrajan",
                        Alamat="Jl. Dorodasih No.16, Patangpuluhan, Wirobrajan, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55251",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Pemerintahan.kantor-kecamatan-wirobrajan.jpg")
                    }
                }
            });
            CategoryItems.Add(new CategoryItem
            {
                CategoryID = 5,
                CategoryName = "Fasilitas Kesehatan",
                CategoryDescription = "Fasilitas Kesehatan",
                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.fasilitas-kesehatan.jpg"),
                SubCategoryItems = new List<SubCategoryItem>()
                {
                    new SubCategoryItem
                    {
                        SubCategoryID=51,
                        CategoryName = "RSU Dr. Sardjito",
                        CategoryDescription = "RSU Dr. Sardjito",
                        Alamat="Jalan Kesehatan No. 1, Sinduadi, Mlati, Senolowo, Sinduadi, Mlati, Kabupaten Sleman, Daerah Istimewa Yogyakarta 55281",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Kesehatan.rsu-dr-sarjito.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=52,
                        CategoryName = "RS. Panti Rapih",
                        CategoryDescription = "RS. Panti Rapih",
                        Alamat="Jl. Cik Di Tiro No.30, Terban, Gondokusuman, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55223",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Kesehatan.rs-panti-rapih.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=53,
                        CategoryName = "RS. Bethesda",
                        CategoryDescription = "RS. Bethesda",
                        Alamat="Jalan Jendral Sudirman No. 70, Kotabaru, Gondokusuman, Kotabaru, Gondokusuman, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55224",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Kesehatan.rs-bethesda.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=54,
                        CategoryName = "Puskesmas Jetis",
                        CategoryDescription = "Puskesmas Jetis",
                        Alamat="Jl. Pangeran Diponegoro No.91, 001, Bumijo, Jetis, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55231",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Kesehatan.puskesmas-jetis.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=55,
                        CategoryName = "Puskesmas Gondokusuman",
                        CategoryDescription = "Puskesmas Gondokusuman",
                        Alamat="Jl. Tunjung No.1, Baciro, Gondokusuman, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55225",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Kesehatan.puskesmas-gondokusuman.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=56,
                        CategoryName = "Klinik Laboratorium Prodia",
                        CategoryDescription = "Klinik Laboratorium Prodia",
                        Alamat="Jl. P. Mangkubumi No.50, Gowongan, Jetis, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55232",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Kesehatan.klinik-laboratorium-prodia.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=57,
                        CategoryName = "Klinik Laboratorium Pramita",
                        CategoryDescription = "Klinik Laboratorium Pramita",
                        Alamat="Jalan Teuku Cik Ditiro No.17, Terban, Gondokusuman, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55223",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Kesehatan.klinik-laboratorium-pramita.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=58,
                        CategoryName = "Apotik K-24",
                        CategoryDescription = "Apotik K-24",
                        Alamat="Jl. Magelang No.162, Kricak, Tegalrejo, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55241",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Kesehatan.apotik-k24.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=59,
                        CategoryName = "Apotik Kimia Farma",
                        CategoryDescription = "Apotik Kimia Farma",
                        Alamat="Jalan Malioboro No.123, Sosromenduran, Gedong Tengen, Sosromenduran, Gedong Tengen, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55271",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Kesehatan.apotik-kimia-farma.jpg")
                    }
                }
            });
            CategoryItems.Add(new CategoryItem
            {
                CategoryID = 6,
                CategoryName = "Fasilitas Olah Raga",
                CategoryDescription = "Fasilitas Olah Raga",
                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.fasilitas-olahraga.jpg"),
                SubCategoryItems = new List<SubCategoryItem>()
                {
                    new SubCategoryItem
                    {
                        SubCategoryID=61,
                        CategoryName = "Sasana Among Raga",
                        CategoryDescription = "Sasana Among Raga",
                        Alamat="Jl. Cendana No.15, Semaki, Umbulharjo, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55166",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.OlahRaga.sasana-among-raga.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=62,
                        CategoryName = "GOR UNY",
                        CategoryDescription = "GOR UNY",
                        Alamat="Jl. Colombo No.1, Caturtunggal, Depok, Caturtunggal, Kec. Depok, Kabupaten Sleman, Daerah Istimewa Yogyakarta 55281",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.OlahRaga.gor-uny.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=63,
                        CategoryName = "Stadion Mandala Krida",
                        CategoryDescription = "Stadion Mandala Krida",
                        Alamat="Jalan Kemuning, Semaki, Umbulharjo, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55166",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.OlahRaga.stadio-mandala-krida.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=64,
                        CategoryName = "Stadion Kridosono",
                        CategoryDescription = "Stadion Kridosono",
                        Alamat="Jl. Yos Sudarso No.9, 001, Kotabaru, Gondokusuman, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55224",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.OlahRaga.stadion-kridosono.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=65,
                        CategoryName = "Stadion Maguwoharjo",
                        CategoryDescription = "Stadion Maguwoharjo",
                        Alamat="Dusun Jenengan, Jl. Kepuhsari, Maguwoharjo, Kec. Depok, Kabupaten Sleman, Daerah Istimewa Yogyakarta 55584",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.OlahRaga.stadion-maguwaharjo.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=66,
                        CategoryName = "Kolam Renang Umbang Tirta",
                        CategoryDescription = "Kolam Renang Umbang Tirta",
                        Alamat="JL. Kom. L Yos Sudarso No.2, Kotabaru, Gondokusuman, Kotabaru, Gondokusuman, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55224",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.OlahRaga.kolam-renang-umbang-tirto.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=67,
                        CategoryName = "Kolam Renang Salsabila",
                        CategoryDescription = "Kolam Renang Salsabila",
                        Alamat="Jl. Seturan Raya No.15, Kledokan, Caturtunggal, Kec. Depok, Kabupaten Sleman, Daerah Istimewa Yogyakarta 55281",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.OlahRaga.kolam-renang-salsabila.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=68,
                        CategoryName = "Depok Sport Center",
                        CategoryDescription = "Depok Sport Center",
                        Alamat="Jl. Raya Seturan-Kledokan Kav. 4, Caturtunggal, Kecamatan Depok, Kledokan, Caturtunggal, Kec. Depok, Kabupaten Sleman, Daerah Istimewa Yogyakarta 55281",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.OlahRaga.depok-sport-center.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=69,
                        CategoryName = "Jogja Sport Center",
                        CategoryDescription = "Jogja Sport Center",
                        Alamat="-",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.OlahRaga.depok-sport-center.jpg")
                    }
                }
            });
            CategoryItems.Add(new CategoryItem
            {
                CategoryID = 7,
                CategoryName = "Fasilitas Ibadah",
                CategoryDescription = "Fasilitas Ibadah",
                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.fasilitas-ibadah.jpg"),
                SubCategoryItems = new List<SubCategoryItem>()
                {
                    new SubCategoryItem
                    {
                        SubCategoryID=71,
                        CategoryName = "Islam",
                        CategoryDescription = "Islam",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.fasilitas-ibadah-islam.jpg"),
                        SubCategoryItems = new List<SubCategoryItem>()
                        {
                            new SubCategoryItem
                            {
                                SubCategoryID=711,
                                CategoryName = "Masjid Gedhe Kauman",
                                CategoryDescription = "Masjid Gedhe Kauman",
                                Alamat="Alun-Alun Keraton, Jl. Kauman, Ngupasan, Gondomanan, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55132",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Ibadah.Islam.masjid-gedhe-kauman.jpg")
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=712,
                                CategoryName = "Masjid Agung Kraton Yogyakarta",
                                CategoryDescription = "Masjid Agung Kraton Yogyakarta",
                                Alamat="Ngupasan, Gondomanan, Kota Yogyakarta, Daerah Istimewa Yogyakarta",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Ibadah.Islam.masjid-agung-yogyakarta.jpg")
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=713,
                                CategoryName = "Masjid Syuhada",
                                CategoryDescription = "Masjid Syuhada",
                                Alamat="Jl. I Dewa Nyoman Oka No.13, Kotabaru, Gondokusuman, Kota Yogyakarta, Daerah Istimewa Yogyakarta",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Ibadah.Islam.masjid-syuhada.jpg")
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=714,
                                CategoryName = "Masjid Kota Gede",
                                CategoryDescription = "Masjid Kota Gede",
                                Alamat="Gg. P. Jolang III, Purbayan, Kotagede, Kota Yogyakarta, Daerah Istimewa Yogyakarta",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Ibadah.Islam.masjid-kotagede.jpg")
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=715,
                                CategoryName = "Masjid Pakualaman",
                                CategoryDescription = "Masjid Pakualaman",
                                Alamat="Jl. Masjid, Gunungketur, Pakualaman, Kota Yogyakarta, Daerah Istimewa Yogyakarta",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Ibadah.Islam.masjid-pakualaman.jpg")
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=716,
                                CategoryName = "Masjid Nurul Huda",
                                CategoryDescription = "Masjid Nurul Huda",
                                Alamat="Jl. Kemuning, Sanggrahan, Condongcatur, Kec. Depok, Kabupaten Sleman, Daerah Istimewa Yogyakarta",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Ibadah.Islam.masjid-nurul-huda.jpg")
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=717,
                                CategoryName = "Mushalla Al-Anhar",
                                CategoryDescription = "Mushalla Al-Anhar",
                                Alamat="Kidul MG I/1234, Keparakan, Mergangsan, Kota Yogyakarta, Daerah Istimewa Yogyakarta",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Ibadah.Islam.mushalla-al-anhar.jpg")
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=718,
                                CategoryName = "Mushalla Al-Barokah",
                                CategoryDescription = "Mushalla Al-Barokah",
                                Alamat="Jl. Paingan, Krodan, Maguwoharjo, Kec. Depok, Kabupaten Sleman, Daerah Istimewa Yogyakarta",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Ibadah.Islam.mushalla-al-barokah.jpg")
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=719,
                                CategoryName = "Mushalla As-Salam",
                                CategoryDescription = "Mushalla As-Salam",
                                Alamat="Sorogenan II, Purwomartani, Kalasan, Kabupaten Sleman, Daerah Istimewa Yogyakarta",
                                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Ibadah.Islam.mushalla-as-salam.jpg")
                            }
                        }
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=72,
                        CategoryName = "Kristen Katolik",
                        CategoryDescription = "Kristen Katolik",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.fasilitas-ibadah-kristen-katolik.jpg"),
                        SubCategoryItems = new List<SubCategoryItem>()
                        {
                            new SubCategoryItem
                            {
                                SubCategoryID=721,
                                CategoryName = "GKJ Gondokusuman",
                                CategoryDescription = "GKJ Gondokusuman",
                                Alamat="Jl. Dr. Wahidin Sudirohusodo No.40, Klitren, Gondokusuman, Kota Yogyakarta, Daerah Istimewa Yogyakarta",
                                CategoryImage = ImageSource.FromResource
                                ("SampleSyncfusion.Icons.Tempat.Ibadah.Kristen & Katolik.gkj-gondokusuman.jpg")
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=722,
                                CategoryName = "GKJ Mergangsan",
                                CategoryDescription = "GKJ Mergangsan",
                                Alamat="Jl. Taman Siswa No.166, Wirogunan, Mergangsan, Kota Yogyakarta, Daerah Istimewa Yogyakarta",
                                CategoryImage = ImageSource.FromResource
                                ("SampleSyncfusion.Icons.Tempat.Ibadah.Kristen & Katolik.gkj-mergangsan.jpg")
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=723,
                                CategoryName = "GKI Gejayan",
                                CategoryDescription = "GKI Gejayan",
                                Alamat="Jl. Jembatan Merah No. 84D, Depok, Condongcatur, Sleman, Kabupaten Sleman, Daerah Istimewa Yogyakarta",
                                CategoryImage = ImageSource.FromResource
                                ("SampleSyncfusion.Icons.Tempat.Ibadah.Kristen & Katolik.gki-gejayan.jpg")
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=724,
                                CategoryName = "GKI Wongsodirjan",
                                CategoryDescription = "GKI Wongsodirjan",
                                Alamat="Jl. Wongsodirjan No.2, Sosromenduran, Gedong Tengen, Kota Yogyakarta, Daerah Istimewa Yogyakarta ",
                                CategoryImage = ImageSource.FromResource
                                ("SampleSyncfusion.Icons.Tempat.Ibadah.Kristen & Katolik.gki-wongsodirjan.jpg")
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=725,
                                CategoryName = "GBI Keluarga Allah",
                                CategoryDescription = "GBI Keluarga Allah",
                                Alamat="Jalan C. Simanjuntak No.91, Gondokusuman, Terban, Gondokusuman, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55223",
                                CategoryImage = ImageSource.FromResource
                                ("SampleSyncfusion.Icons.Tempat.Ibadah.Kristen & Katolik.gbi-keluarga-allah.jpg")
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=726,
                                CategoryName = "GBI Aletheia",
                                CategoryDescription = "GBI Aletheia",
                                Alamat="Jalan Magelang No.141-143,, Sinduadi, Mlati, Kota Yogyakarta, Daerah Istimewa Yogyakarta",
                                CategoryImage = ImageSource.FromResource
                                ("SampleSyncfusion.Icons.Tempat.Ibadah.Kristen & Katolik.gbi-aletheia.jpg")
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=727,
                                CategoryName = "GPDI Hagios Sosrowijayan",
                                CategoryDescription = "GPDI Hagios Sosrowijayan",
                                Alamat="Jl. Sosrowijayan No.33, RW.001, Sosromenduran, Gedong Tengen, Kota Yogyakarta, Daerah Istimewa Yogyakarta",
                                CategoryImage = ImageSource.FromResource
                                ("SampleSyncfusion.Icons.Tempat.Ibadah.Kristen & Katolik.gpdi-hagios.jpg")
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=728,
                                CategoryName = "Gereja Katolik ST. Antonius Kota Baru",
                                CategoryDescription = "Gereja Katolik ST. Antonius Kota Baru",
                                Alamat="Jalan Abu Bakar Ali No.1, Kotabaru, Gondokusuman, Kotabaru, Gondokusuman, Kota Yogyakarta, Daerah Istimewa Yogyakarta",
                                CategoryImage = ImageSource.FromResource
                                ("SampleSyncfusion.Icons.Tempat.Ibadah.Kristen & Katolik.gereja-st-antonnius.jpg")
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=729,
                                CategoryName = "Gereja Katolik ST. Yusuf Bintaran",
                                CategoryDescription = "Gereja Katolik ST. Yusuf Bintaran",
                                Alamat="Jalan Bintaran Kidul No.5, Wirogunan, Mergangsan, Wirogunan, Mergangsan, Kota Yogyakarta, Daerah Istimewa Yogyakarta",
                                CategoryImage = ImageSource.FromResource
                                ("SampleSyncfusion.Icons.Tempat.Ibadah.Kristen & Katolik.gereja-st-yusuf.jpg")
                            }
                        }
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=73,
                        CategoryName = "Hindu",
                        CategoryDescription = "Hindu",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.fasilitas-ibadah-hindu.jpg"),
                        SubCategoryItems = new List<SubCategoryItem>()
                        {
                            new SubCategoryItem
                            {
                                SubCategoryID=731,
                                CategoryName = "Pura Jagatnatha",
                                CategoryDescription = "Pura Jagatnatha",
                                Alamat="Jl. Pura, Jomblangan, Banguntapan, Bantul, Daerah Istimewa Yogyakarta",
                                CategoryImage = ImageSource.FromResource
                                ("SampleSyncfusion.Icons.Tempat.Ibadah.Hindu.pura-jagatnatha.jpg")
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=732,
                                CategoryName = "Pura Vaikuntha Vyomantara",
                                CategoryDescription = "Pura Vaikuntha Vyomantara",
                                Alamat="Karang Janbe, Banguntapan, Bantul, Daerah Istimewa Yogyakarta",
                                CategoryImage = ImageSource.FromResource
                                ("SampleSyncfusion.Icons.Tempat.Ibadah.Hindu.pura-vaikuntha-vyomantara.jpg")
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=733,
                                CategoryName = "Pura Eka Dharma",
                                CategoryDescription = "Pura Eka Dharma",
                                Alamat="JL. Gonjen, Tamantirto, Kasihan, Bantul, Tamantirto, Kasihan, Bantul, Daerah Istimewa Yogyakarta",
                                CategoryImage = ImageSource.FromResource
                                ("SampleSyncfusion.Icons.Tempat.Ibadah.Hindu.pura-eka-dharma.jpg")
                            }
                        }
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=74,
                        CategoryName = "Budha",
                        CategoryDescription = "Budha",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.fasilitas-ibadah-budha.jpg"),
                        SubCategoryItems = new List<SubCategoryItem>()
                        {
                            new SubCategoryItem
                            {
                                SubCategoryID=741,
                                CategoryName = "Vihara Buddha Prabha",
                                CategoryDescription = "Vihara Buddha Prabha",
                                Alamat="Jl. Brigjen Katamso No.3, Prawirodirjan, Gondomanan, Kota Yogyakarta, Daerah Istimewa Yogyakarta",
                                CategoryImage = ImageSource.FromResource
                                ("SampleSyncfusion.Icons.Tempat.Ibadah.Budha.vihara-buddha-prabha.jpg")
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=742,
                                CategoryName = "Vihara Vidyaloka",
                                CategoryDescription = "Vihara Vidyaloka",
                                Alamat="Jalan Kenari, GG. Tanjung I No. 231, Muja Muju, Umbulharjo, Muja Muju, Umbulharjo, Kota Yogyakarta, Daerah Istimewa Yogyakarta",
                                CategoryImage = ImageSource.FromResource
                                ("SampleSyncfusion.Icons.Tempat.Ibadah.Budha.vihara-vidyaloka.jpg")
                            },
                            new SubCategoryItem
                            {
                                SubCategoryID=743,
                                CategoryName = "Vihara Bodhicitta Maitreya",
                                CategoryDescription = "Vihara Bodhicitta Maitreya",
                                Alamat="Jl. Kemetiran No.9, Pringgokusuman, Gedong Tengen, Kota Yogyakarta, Daerah Istimewa Yogyakarta",
                                CategoryImage = ImageSource.FromResource
                                ("SampleSyncfusion.Icons.Tempat.Ibadah.Budha.vihara-bodhicitta-maitreya.jpg")
                            }
                        }
                    }
                }
            });
            CategoryItems.Add(new CategoryItem
            {
                CategoryID = 8,
                CategoryName = "Fasilitas Perbelanjaan",
                CategoryDescription = "Fasilitas Perbelanjaan",
                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.fasilitas-perbelanjaan.jpg"),
                SubCategoryItems = new List<SubCategoryItem>()
                {
                    new SubCategoryItem
                    {
                        SubCategoryID=81,
                        CategoryName = "Pasar Kranggan",
                        CategoryDescription = "Pasar Kranggan",
                        Alamat="Jl. Pangeran Diponegoro, Gowongan, Jetis, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55233",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Perbelanjaan.pasar-kranggan.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=82,
                        CategoryName = "Pasar Bringharjo",
                        CategoryDescription = "Pasar Bringharjo",
                        Alamat="Jl. Margo Mulyo No.16, Ngupasan, Gondomanan, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55122",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Perbelanjaan.pasar-bringharjo.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=83,
                        CategoryName = "Pasar Kolombo",
                        CategoryDescription = "Pasar Kolombo",
                        Alamat="Jl. Kaliurang KM 7, Condongcatur, Depok, Kecamatan Depok, Condongcatur, Kec. Depok, Kabupaten Sleman, Daerah Istimewa Yogyakarta 55281",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Perbelanjaan.pasar-kolombo.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=84,
                        CategoryName = "Ambarukmo Plaza",
                        CategoryDescription = "Ambarukmo Plaza",
                        Alamat="Jl. Laksda Adisucipto No. 80, Caturtunggal, Depok, Kecamatan Depok, Yogyakarta, Daerah Istimewa Yogyakarta 55281",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Perbelanjaan.ambarukmo-plaza.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=85,
                        CategoryName = "Hartono Mall",
                        CategoryDescription = "Hartono Mall",
                        Alamat="Jalan Ir. Soekarno, Madegondo, Grogol, Kabupaten Sukoharjo, Jawa Tengah 57552",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Perbelanjaan.hartono-mall.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=86,
                        CategoryName = "Galeria Mall",
                        CategoryDescription = "Galeria Mall",
                        Alamat="Jl. Jendral Sudirman No. 99-101, Gondokusuman, Terban, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55223",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Perbelanjaan.galeria-mall.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=87,
                        CategoryName = "Gardena",
                        CategoryDescription = "Gardena",
                        Alamat="Jalan Urip Sumoharjo No.40, Klitren, Gondokusuman, Klitren, Gondokusuman, Kabupaten Sleman, Daerah Istimewa Yogyakarta 55222",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Perbelanjaan.gardena.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=88,
                        CategoryName = "Gramedia",
                        CategoryDescription = "Gramedia",
                        Alamat="Jl. Jend. Sudirman No.54-56, Kotabaru, Gondokusuman, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55224",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Perbelanjaan.gramedia.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=89,
                        CategoryName = "Mirota Batik",
                        CategoryDescription = "Mirota Batik",
                        Alamat="Jalan Margo Mulyo No.9, Ngupasan, Gondomanan, Ngupasan, Gondomanan, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55122",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Perbelanjaan.mirota-batik.jpg")
                    }
                }
            });
            CategoryItems.Add(new CategoryItem
            {
                CategoryID = 9,
                CategoryName = "Fasilitas Keuangan",
                CategoryDescription = "Fasilitas Keuangan",
                CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.fasilitas-keuangan.jpg"),
                SubCategoryItems = new List<SubCategoryItem>()
                {
                    new SubCategoryItem
                    {
                        SubCategoryID=91,
                        CategoryName = "Bank BRI",
                        CategoryDescription = "Bank BRI",
                        Alamat="Jl. Brigjen Katamso, Prawirodirjan, Gondomanan, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55121",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Keuangan.bank-bri.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=92,
                        CategoryName = "ATM Mandiri",
                        CategoryDescription = "ATM Mandiri",
                        Alamat="Malioboro Mall, Jl. Malioboro, Suryatmajan, Danurejan, Yogyakarta City, Special Region of Yogyakarta 55271",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Keuangan.atm-mandiri.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=93,
                        CategoryName = "KOPMA UGM",
                        CategoryDescription = "Koperasi Mahasiswa UGM",
                        Alamat="Senolowo, Caturtunggal, Depok Sub-District, Sleman Regency, Special Region of Yogyakarta 55281",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Keuangan.kopma-ugm.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=94,
                        CategoryName = "Bank BCA",
                        CategoryDescription = "Bank BCA",
                        Alamat="Jl. Jend. Sudirman No.49-51, Terban, Gondokusuman, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55223",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Keuangan.bank-bca.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=95,
                        CategoryName = "Bank BNI",
                        CategoryDescription = "Bank BNI",
                        Alamat="Jl. Jend. Sudirman No.61, Terban, Gondokusuman, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55223",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Keuangan.bank-bni.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=96,
                        CategoryName = "Bank BPD",
                        CategoryDescription = "Bank BPD",
                        Alamat="Jalan A. M. Sangaji, Cokrodiningratan, Jetis, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55233",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Keuangan.bank-bpd.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=97,
                        CategoryName = "ATM Danamon",
                        CategoryDescription = "ATM Danamon",
                        Alamat="Jalan Diponegoro No.97, Bumijo, Jetis, Bumijo, Jetis, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55231",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Keuangan.atm-danamon.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=98,
                        CategoryName = "Koperasi Sejahtera Bersama",
                        CategoryDescription = "Koperasi Sejahtera Bersama",
                        Alamat="Jl. Hayam Wuruk No.74 A, Bausasran, Danurejan, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55212",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Keuangan.koperasi-sejahtera-bersama.jpg")
                    },
                    new SubCategoryItem
                    {
                        SubCategoryID=99,
                        CategoryName = "BPR Yogyakarta",
                        CategoryDescription = "BPR Yogyakarta",
                        Alamat="Jalan Magelang KM. 18, Lumbungrejo, Tempel, Wonokerso, Lumbungrejo, Sleman, Kabupaten Sleman, Daerah Istimewa Yogyakarta 55552",
                        CategoryImage = ImageSource.FromResource("SampleSyncfusion.Icons.Tempat.Keuangan.bpr-yogyakarta.jpg")
                    }
                }
            });
        }
    }
}