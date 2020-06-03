using Microsoft.EntityFrameworkCore.Migrations;

namespace JWTAPI.Migrations.Data
{
    public partial class kategori : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Kitap" },
                    { 2, "E-Kitap" },
                    { 3, "Elektronik" },
                    { 4, "Hobi & Oyuncak" },
                    { 5, "Kırtasiye" },
                    { 6, "Oyun & Konsol" },
                    { 7, "Müzik" },
                    { 8, "Dergi" },
                    { 9, "Hediyelik Eşyalar" },
                    { 10, "Spor & Outdoor" },
                    { 11, "Çok Satanlar" },
                    { 12, "Yeni Çıkan Kitaplar" },
                    { 13, "Yazarlar" },
                    { 14, "Yayınevleri" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 14);
        }
    }
}
