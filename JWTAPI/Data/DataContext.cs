using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace JWTAPI.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}
		public DbSet<Kategori> Kategoriler { get; set; }
		public DbSet<Alt_Kategori> Kitaplar { get; set; }
		public DbSet<Ürün_Kitap> Ürün_Kitaplar { get; set; }
		public DbSet<Ürün_Diğer> Ürün_Diğerleri { get; set; }
		public DbSet<Sepet> Sepettekiler { get; set; }
		public DbSet<AAlt_Kategori> AAlt_Kategoriler { get; set; }
		public DbSet<UrunKitapAyrıntı> UKitapAyrıntıları { get; set; }
		public DbSet<Slider> Sliders { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Kategori>().HasData(
				 new Kategori { Id=1,Name="Kitap"},
				 new Kategori { Id = 2, Name = "E-Kitap" },
				 new Kategori { Id = 3, Name = "Elektronik" },
				 new Kategori { Id = 4, Name = "Hobi & Oyuncak" },
				 new Kategori { Id = 5, Name = "Kırtasiye" },
				 new Kategori { Id = 6, Name = "Oyun & Konsol" },
				 new Kategori { Id = 7, Name = "Müzik" },
				 new Kategori { Id = 8, Name = "Dergi" },
				 new Kategori { Id = 9, Name = "Hediyelik Eşyalar" },
				 new Kategori { Id = 10, Name = "Spor & Outdoor" },
				 new Kategori { Id = 11, Name = "Çok Satanlar" },
				 new Kategori { Id = 12, Name = "Yeni Çıkan Kitaplar" },
				 new Kategori { Id = 13, Name = "Yazarlar" },
				 new Kategori { Id = 14, Name = "Yayınevleri" }
				);
			modelBuilder.Entity<Alt_Kategori>().HasData(
				new Alt_Kategori { Id=1, Category_Id=1 , Name="Edebiyat"},
				new Alt_Kategori { Id = 2, Category_Id = 1, Name = "Çocuk ve Gençlik"},
				new Alt_Kategori { Id = 3, Category_Id = 1, Name = "Eğitim Başvuru" },
				new Alt_Kategori { Id = 4, Category_Id = 1, Name = "Araştırma - Tarih" },
				new Alt_Kategori { Id = 5, Category_Id = 1, Name = "Din Tasavvuf" },
				new Alt_Kategori { Id = 6, Category_Id = 1, Name = "Foreign Languages" },
				new Alt_Kategori { Id = 7, Category_Id = 1, Name = "Ders/Sınav Kitapları" },
				new Alt_Kategori { Id = 8, Category_Id = 1, Name = "Sanat - Tasarım" },
				new Alt_Kategori { Id = 9, Category_Id = 1, Name = "Felsefe" },
				new Alt_Kategori { Id = 10, Category_Id = 1, Name = "Çizgi Roman" },
				new Alt_Kategori { Id = 11, Category_Id = 1, Name = "Hobi" },
				new Alt_Kategori { Id = 12, Category_Id = 1, Name = "Bilim" },
				new Alt_Kategori { Id = 13, Category_Id = 1, Name = "Mizah" },
				new Alt_Kategori { Id = 14, Category_Id = 1, Name = "Prestij Kitapları" },
				new Alt_Kategori { Id = 15, Category_Id = 1, Name = "Mitoloji Efsane" },
				new Alt_Kategori { Id = 16, Category_Id = 1, Name = "Sesli Kitaplar" }
				);
			modelBuilder.Entity<AAlt_Kategori>().HasData(
				new AAlt_Kategori { Id =1,SubC_Id=1,Name="Roman"},
				new AAlt_Kategori { Id = 2, SubC_Id = 1, Name = "Şiir" },
				new AAlt_Kategori { Id = 3, SubC_Id = 1, Name = "Deneme/Yazın" },
				new AAlt_Kategori { Id = 4, SubC_Id = 1, Name = "Türk Öykü" },
				new AAlt_Kategori { Id = 5, SubC_Id = 1, Name = "Edebiyat İnceleme" },
				new AAlt_Kategori { Id = 6, SubC_Id = 1, Name = "Biyografi & Oto Biyografi" },
				new AAlt_Kategori { Id = 7, SubC_Id = 1, Name = "Türk Günlük Anı" },
				new AAlt_Kategori { Id = 8, SubC_Id = 1, Name = "Aylık Dergi" },
				new AAlt_Kategori { Id = 9, SubC_Id = 1, Name = "Anlatı" },
				new AAlt_Kategori { Id = 10, SubC_Id = 1, Name = "Dünya Öykü" },
				new AAlt_Kategori { Id = 11, SubC_Id = 1, Name = "Dünya Günlük Anı" },
				new AAlt_Kategori { Id = 12, SubC_Id = 1, Name = "Söyleşi" },
				new AAlt_Kategori { Id = 13, SubC_Id = 1, Name = "Türk Mektup" },
				new AAlt_Kategori { Id = 14, SubC_Id = 1, Name = "Edebiyatçılar" },
				new AAlt_Kategori { Id = 15, SubC_Id = 1, Name = "Destan" },
				new AAlt_Kategori { Id = 16, SubC_Id = 1, Name = "Dünya Mektup" },
				new AAlt_Kategori { Id = 17, SubC_Id = 1, Name = "Röportaj" },
				new AAlt_Kategori { Id = 18, SubC_Id = 1, Name = "Antoloji" },
				new AAlt_Kategori { Id = 19, SubC_Id = 1, Name = "Halk Ozanları" },
				new AAlt_Kategori { Id = 20, SubC_Id = 1, Name = "Almanak" }
				);
			modelBuilder.Entity<Slider>().HasData(
				new Slider { Id=1,Photo= "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/0420_d_u_x_851x373_anneler_gunu_lp.jpg" },
				new Slider { Id = 2, Photo = "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/0420_d_t_40_851x373_cep_telefonu.jpg" },
				new Slider { Id = 3, Photo = "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/ramazan-ana-sayfa.jpg" },
				new Slider { Id = 4, Photo = "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/0420_d_u_x_851x373_lego_cocukluk_hayalim.jpg" },
				new Slider { Id = 5, Photo = "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/0420_d_u_15_851x373_mayis_oyuncak_lp.jpg" },
				new Slider { Id = 6, Photo = "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/0420_d_u_x_851x373_ayin_yayinevi_tudem.jpg" },
				new Slider { Id = 7, Photo = "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/0420_d_u_14_851x373_mayis_teknoloji_lp.jpg" },
				new Slider { Id = 8, Photo = "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/0320_d_u_x_851x373_haftanin_firsati_salon.jpg" },
				new Slider { Id = 9, Photo = "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/tum-kitap-kampanyalari-homepage1.jpg" },
				new Slider { Id = 10, Photo = "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/0420_d_u_2_851x373_twin_il_evde_ogrenmek_rev.jpg" },
				new Slider { Id = 11, Photo = "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/19dca320-5fa9-0138-c9d9-22000a0cc917-1586777858-379915.jpg" },
				new Slider { Id = 12, Photo = "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/851x373_PeriliKosk.png" },
				new Slider { Id = 13, Photo = "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/bd-films-homepage.jpg" },
				new Slider { Id = 14, Photo = "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/dergi_851x373_mayis.png" },
				new Slider { Id = 15, Photo = "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/taksit-sevenekleri-yeni.jpg" }
				);
			modelBuilder.Entity<Ürün_Kitap>().HasData(
				new Ürün_Kitap { Id=1,SubC_Id=1,Photo= "https://i.dr.com.tr/cache/154x170-0/originals/0001869654001-1.jpg", Point=2,Name="Akıllandım Artık Şimdi Daha Deliyim",Author="Nilgün Bodur",CoverType="İnce Kapak",Publisher="Destek Yayınları",Discount=37,Price=16.38 },
				new Ürün_Kitap { Id = 2, SubC_Id = 1, Photo = "https://i.dr.com.tr/cache/154x170-0/originals/0001870519001-1.jpg", Point=0, Name = "Theta Healing-Derin İnançları Bulun", Author = "Vianna Stibal", CoverType = "İnce Kapak", Publisher = "Kitap", Discount = 25, Price = 17.25 },
				new Ürün_Kitap { Id = 3, SubC_Id = 1, Photo = "https://i.dr.com.tr/cache/154x170-0/originals/0001870287001-1.jpg", Point = 0, Name = "Kaygı Çağı-Salgın Zamanında Ruh Sağlığı", Author = "Kemal Sayar", CoverType = "İnce Kapak", Publisher = "Kapı Yayınları", Discount = 30, Price = 20.30 },
				new Ürün_Kitap { Id = 4, SubC_Id = 1, Photo = "https://i.dr.com.tr/cache/154x170-0/originals/0001863427001-1.jpg", Point = 0, Name = "İsimsiz Kız", Author = "Greer Hendricks", CoverType = "Ciltli", Publisher = "Ephesus Yayınları", Discount = 35, Price = 27.30 },
				new Ürün_Kitap { Id = 5, SubC_Id = 1, Photo = "https://i.dr.com.tr/cache/154x170-0/originals/0001870779001-1.jpg", Point = 0, Name = "Konstantiniyye Oteli", Author = "Zülfü Livaneli", CoverType = "İnce Kapak", Publisher = "İnkılap Kitabevi", Discount = 30, Price = 24.50 },
				new Ürün_Kitap { Id = 6, SubC_Id = 1, Photo = "https://i.dr.com.tr/cache/154x170-0/originals/0001870778001-1.jpg", Point = 0, Name = "Akira 1.Cilt", Author = "Katsuhiro Otomo", CoverType = "İnce Kapak", Publisher = "Gerekli Şeyler", Discount = 25, Price = 51.00 },
				new Ürün_Kitap { Id = 7, SubC_Id = 1, Photo = "https://i.dr.com.tr/cache/154x170-0/originals/0001849287001-1.jpg", Point = 3.5, Name = "Disney Esrarengiz Kasaba-Günlük 3", Author = "Alex Hirsch", CoverType = "Ciltli", Publisher = "Beta Kids", Discount = 35, Price = 58.18 },
				new Ürün_Kitap { Id = 8, SubC_Id = 1, Photo = "https://i.dr.com.tr/cache/154x170-0/originals/0001868366001-1.jpg", Point = 0, Name = "Ya-Ya Da", Author = "Soren Kierkegaard", CoverType = "İnce Kapak", Publisher = "Alfa Yayıncılık", Discount = 30, Price = 48.30 },
				new Ürün_Kitap { Id = 9, SubC_Id = 1, Photo = "https://i.dr.com.tr/cache/154x170-0/originals/0001868717001-1.jpg", Point = 5, Name = "Sesini Duyur", Author = "M.Rise", CoverType = "Ciltli", Publisher = "Ephesus Yayınları", Discount = 37, Price = 26.46 },
				new Ürün_Kitap { Id = 10, SubC_Id = 1, Photo = "https://i.dr.com.tr/cache/154x170-0/originals/0001869472001-1.jpg", Point = 0, Name = "İlahi Aşk Seti-10 Kitap Takım", Author = "Hayati Sır", CoverType = "İnce Kapak", Publisher = "Hayykitap", Discount = 42, Price = 107.28 },
				new Ürün_Kitap { Id = 11, SubC_Id = 1, Photo = "https://i.dr.com.tr/cache/154x170-0/originals/0001868573001-1.jpg", Point = 2, Name = "Tuğçe Işınsu Çok Satan Kitaplar Seti-2 Kitap Takım", Author = "Tuğçe Işınsu", CoverType = "İnce Kapak", Publisher = "Feniks Kitap", Discount = 30, Price = 43.40},
				new Ürün_Kitap { Id = 12, SubC_Id = 1, Photo = "https://i.dr.com.tr/cache/154x170-0/originals/0001690945002-1.jpg", Point = 2.5, Name = "Çerkes Kızından Tarifler", Author = "Sine Boran Art", CoverType = "İnce Kapak", Publisher = "İş Bankası", Discount = 30, Price = 45.50 }
				);
			modelBuilder.Entity<Ürün_Diğer>().HasData(
				new Ürün_Diğer { Id=1,Photo= "https://i.dr.com.tr/cache/154x170-0/originals/0001865501001-1.jpg", Point=3, Name="Kodak A4 Fotokopi Kağıdı",P_Type="Kırtasiye",Brand="Kodak",Discount=10,Price=15.21},
				new Ürün_Diğer { Id = 2, Photo = "https://i.dr.com.tr/cache/154x170-0/originals/0000000274754-1.jpg", Point = 3, Name = "Scrikss 108 Chrome Tükenmez", P_Type = "Kırtasiye", Brand = "Scrikss", Discount = 30, Price = 10.85 },
				new Ürün_Diğer { Id = 3, Photo = "https://i.dr.com.tr/cache/154x170-0/originals/0000000098198-1.jpg", Point = 2.5, Name = "Fbar-Castell Karton Kutu Boya Kalemi", P_Type = "Kırtasiye", Brand = "Faber-Castell", Discount = 30, Price = 34.90 },
				new Ürün_Diğer { Id = 4, Photo = "https://i.dr.com.tr/cache/154x170-0/originals/0000000457175-1.jpg", Point = 2.5, Name = "Bic Silinebilir Pastel 24'lü Kutu", P_Type = "Kırtasiye", Brand = "Bic", Discount = 25, Price = 20.18 },
				new Ürün_Diğer { Id = 5, Photo = "https://i.dr.com.tr/cache/154x170-0/originals/0001797607001-1.jpg", Point=0, Name = "Faber-Castell Jumbo Keçeli Kalem 12'li", P_Type = "Kırtasiye", Brand = "Faber-Castell", Discount = 30, Price = 34.93 },
				new Ürün_Diğer { Id = 6, Photo = "https://i.dr.com.tr/cache/154x170-0/originals/0001793632001-1.jpg", Point=0, Name = "Crayola Silly Scents Çevirilebilen Pastel Boya Kalemi 12'li", P_Type = "Kırtasiye", Brand = "Crayola", Discount = 33, Price = 39.90 },
				new Ürün_Diğer { Id = 7, Photo = "https://i.dr.com.tr/cache/154x170-0/originals/0001753296001-1.jpg", Point = 3.5, Name = "Kobo Clara HD E-kitap Okuma Cihazı", P_Type = "Elektronik", Brand = "Kobo",Discount=0, Price = 1228.88},
				new Ürün_Diğer { Id = 8, Photo = "https://i.dr.com.tr/cache/154x170-0/originals/0001745792001-1.jpg", Point = 3, Name = "Lenco TT-10 Pikap", P_Type = "Elektronik", Brand = "Kodak", Discount = 8, Price = 549 },
				new Ürün_Diğer { Id = 9, Photo = "https://i.dr.com.tr/cache/154x170-0/originals/0001830237001-1.jpg", Point = 2.5, Name = "Xiaomi Yüksek Emişli Akıllı Robot Süpürge", P_Type = "Elektronik", Brand = "Xiaomi", Discount = 16, Price = 3349.00 },
				new Ürün_Diğer { Id = 10, Photo = "https://i.dr.com.tr/cache/154x170-0/originals/0001856330001-1.jpg", Point = 5, Name = "Xiaomi Redmi Powerbank", P_Type = "Elektronik", Brand = "Xiaomi", Discount = 23, Price = 99.90 },
				new Ürün_Diğer { Id = 11, Photo = "https://i.dr.com.tr/cache/154x170-0/originals/0001802919001-1.jpg", Point = 3.5, Name = "Sennheiser Momentum True Wireless Earphone Kulaklık", P_Type = "Elektronik", Brand = "Sennheiser", Discount = 0, Price = 1999.00 },
				new Ürün_Diğer { Id = 12, Photo = "https://i.dr.com.tr/cache/154x170-0/originals/0001870491001-1.jpg", Point = 0, Name = "Braun Mgk 3242 Erkek Bakım Kiti ", P_Type = "Elektronik", Brand = "Braun", Discount = 0, Price = 299.00 }
				);
		}
		//protected override void OnConfiguring(DbContextOptionsBuilder options)
		// => options.UseSqlServer("Data Source=DR");
	}
}
