using Microsoft.EntityFrameworkCore.Migrations;

namespace JWTAPI.Migrations.Data
{
    public partial class kitaplar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AAlt_Kategoriler",
                columns: new[] { "Id", "Name", "SubC_Id" },
                values: new object[,]
                {
                    { 1, "Roman", 1 },
                    { 20, "Almanak", 1 },
                    { 19, "Halk Ozanları", 1 },
                    { 18, "Antoloji", 1 },
                    { 17, "Röportaj", 1 },
                    { 16, "Dünya Mektup", 1 },
                    { 15, "Destan", 1 },
                    { 13, "Türk Mektup", 1 },
                    { 12, "Söyleşi", 1 },
                    { 11, "Dünya Günlük Anı", 1 },
                    { 14, "Edebiyatçılar", 1 },
                    { 9, "Anlatı", 1 },
                    { 8, "Aylık Dergi", 1 },
                    { 7, "Türk Günlük Anı", 1 },
                    { 6, "Biyografi & Oto Biyografi", 1 },
                    { 5, "Edebiyat İnceleme", 1 },
                    { 4, "Türk Öykü", 1 },
                    { 3, "Deneme/Yazın", 1 },
                    { 2, "Şiir", 1 },
                    { 10, "Dünya Öykü", 1 }
                });

            migrationBuilder.InsertData(
                table: "Kitaplar",
                columns: new[] { "Id", "Category_Id", "Name" },
                values: new object[,]
                {
                    { 10, 1, "Çizgi Roman" },
                    { 16, 1, "Sesli Kitaplar" },
                    { 15, 1, "Mitoloji Efsane" },
                    { 14, 1, "Prestij Kitapları" },
                    { 13, 1, "Mizah" },
                    { 11, 1, "Hobi" },
                    { 9, 1, "Felsefe" },
                    { 12, 1, "Bilim" },
                    { 7, 1, "Ders/Sınav Kitapları" },
                    { 6, 1, "Foreign Languages" },
                    { 5, 1, "Din Tasavvuf" },
                    { 4, 1, "Araştırma - Tarih" },
                    { 3, 1, "Eğitim Başvuru" },
                    { 2, 1, "Çocuk ve Gençlik" },
                    { 1, 1, "Edebiyat" },
                    { 8, 1, "Sanat - Tasarım" }
                });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "Photo" },
                values: new object[,]
                {
                    { 15, "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/taksit-sevenekleri-yeni.jpg" },
                    { 14, "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/dergi_851x373_mayis.png" },
                    { 13, "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/bd-films-homepage.jpg" },
                    { 12, "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/851x373_PeriliKosk.png" },
                    { 11, "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/19dca320-5fa9-0138-c9d9-22000a0cc917-1586777858-379915.jpg" },
                    { 9, "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/tum-kitap-kampanyalari-homepage1.jpg" },
                    { 8, "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/0320_d_u_x_851x373_haftanin_firsati_salon.jpg" },
                    { 10, "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/0420_d_u_2_851x373_twin_il_evde_ogrenmek_rev.jpg" },
                    { 6, "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/0420_d_u_x_851x373_ayin_yayinevi_tudem.jpg" },
                    { 5, "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/0420_d_u_15_851x373_mayis_oyuncak_lp.jpg" },
                    { 4, "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/0420_d_u_x_851x373_lego_cocukluk_hayalim.jpg" },
                    { 3, "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/ramazan-ana-sayfa.jpg" },
                    { 2, "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/0420_d_t_40_851x373_cep_telefonu.jpg" },
                    { 1, "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/0420_d_u_x_851x373_anneler_gunu_lp.jpg" },
                    { 7, "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/0420_d_u_14_851x373_mayis_teknoloji_lp.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Ürün_Kitaplar",
                columns: new[] { "Id", "Author", "CoverType", "Discount", "Name", "Photo", "Point", "Price", "Publisher", "SubC_Id" },
                values: new object[,]
                {
                    { 10, "Hayati Sır", "İnce Kapak", 42, "İlahi Aşk Seti-10 Kitap Takım", "https://i.dr.com.tr/cache/154x170-0/originals/0001869472001-1.jpg", 0.0, 107.28, "Hayykitap", 1 },
                    { 9, "M.Rise", "Ciltli", 37, "Sesini Duyur", "https://i.dr.com.tr/cache/154x170-0/originals/0001868717001-1.jpg", 5.0, 26.46, "Ephesus Yayınları", 1 },
                    { 8, "Soren Kierkegaard", "İnce Kapak", 30, "Ya-Ya Da", "https://i.dr.com.tr/cache/154x170-0/originals/0001868366001-1.jpg", 0.0, 48.3, "Alfa Yayıncılık", 1 },
                    { 7, "Alex Hirsch", "Ciltli", 35, "Disney Esrarengiz Kasaba-Günlük 3", "https://i.dr.com.tr/cache/154x170-0/originals/0001849287001-1.jpg", 3.5, 58.18, "Beta Kids", 1 },
                    { 6, "Katsuhiro Otomo", "İnce Kapak", 25, "Akira 1.Cilt", "https://i.dr.com.tr/cache/154x170-0/originals/0001870778001-1.jpg", 0.0, 51.0, "Gerekli Şeyler", 1 },
                    { 3, "Kemal Sayar", "İnce Kapak", 30, "Kaygı Çağı-Salgın Zamanında Ruh Sağlığı", "https://i.dr.com.tr/cache/154x170-0/originals/0001870287001-1.jpg", 0.0, 20.3, "Kapı Yayınları", 1 },
                    { 4, "Greer Hendricks", "Ciltli", 35, "İsimsiz Kız", "https://i.dr.com.tr/cache/154x170-0/originals/0001863427001-1.jpg", 0.0, 27.3, "Ephesus Yayınları", 1 },
                    { 2, "Vianna Stibal", "İnce Kapak", 25, "Theta Healing-Derin İnançları Bulun", "https://i.dr.com.tr/cache/154x170-0/originals/0001870519001-1.jpg", 0.0, 17.25, "Kitap", 1 },
                    { 1, "Nilgün Bodur", "İnce Kapak", 37, "Akıllandım Artık Şimdi Daha Deliyim", "https://i.dr.com.tr/cache/154x170-0/originals/0001869654001-1.jpg", 2.0, 16.38, "Destek Yayınları", 1 },
                    { 11, "Tuğçe Işınsu", "İnce Kapak", 30, "Tuğçe Işınsu Çok Satan Kitaplar Seti-2 Kitap Takım", "https://i.dr.com.tr/cache/154x170-0/originals/0001868573001-1.jpg", 2.0, 43.4, "Feniks Kitap", 1 },
                    { 5, "Zülfü Livaneli", "İnce Kapak", 30, "Konstantiniyye Oteli", "https://i.dr.com.tr/cache/154x170-0/originals/0001870779001-1.jpg", 0.0, 24.5, "İnkılap Kitabevi", 1 },
                    { 12, "Sine Boran Art", "İnce Kapak", 30, "Çerkes Kızından Tarifler", "https://i.dr.com.tr/cache/154x170-0/originals/0001690945002-1.jpg", 2.5, 45.5, "İş Bankası", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AAlt_Kategoriler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AAlt_Kategoriler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AAlt_Kategoriler",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AAlt_Kategoriler",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AAlt_Kategoriler",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AAlt_Kategoriler",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AAlt_Kategoriler",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AAlt_Kategoriler",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AAlt_Kategoriler",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AAlt_Kategoriler",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AAlt_Kategoriler",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AAlt_Kategoriler",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AAlt_Kategoriler",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AAlt_Kategoriler",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AAlt_Kategoriler",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AAlt_Kategoriler",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AAlt_Kategoriler",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AAlt_Kategoriler",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AAlt_Kategoriler",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AAlt_Kategoriler",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Kitaplar",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ürün_Kitaplar",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ürün_Kitaplar",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ürün_Kitaplar",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ürün_Kitaplar",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ürün_Kitaplar",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ürün_Kitaplar",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ürün_Kitaplar",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ürün_Kitaplar",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ürün_Kitaplar",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ürün_Kitaplar",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ürün_Kitaplar",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ürün_Kitaplar",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
