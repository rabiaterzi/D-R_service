using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JWTAPI.Migrations.Data
{
    public partial class InitialMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AAlt_Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    SubC_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AAlt_Kategoriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kitaplar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Category_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaplar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sepettekiler",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Photo = table.Column<string>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sepettekiler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Photo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UKitapAyrıntıları",
                columns: table => new
                {
                    UrunId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Explanation = table.Column<string>(nullable: true),
                    DoughType = table.Column<int>(nullable: false),
                    PageNumber = table.Column<int>(nullable: false),
                    Dimensions = table.Column<double>(nullable: false),
                    FirstYear = table.Column<int>(nullable: false),
                    PrintNumber = table.Column<int>(nullable: false),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UKitapAyrıntıları", x => x.UrunId);
                });

            migrationBuilder.CreateTable(
                name: "Ürün_Diğerleri",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Photo = table.Column<string>(nullable: true),
                    Point = table.Column<double>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    P_Type = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Discount = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ürün_Diğerleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ürün_Kitaplar",
                columns: table => new
                {
                    SubC_Id = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Photo = table.Column<string>(nullable: true),
                    Point = table.Column<double>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    CoverType = table.Column<string>(nullable: true),
                    Publisher = table.Column<string>(nullable: true),
                    Discount = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ürün_Kitaplar", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AAlt_Kategoriler");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropTable(
                name: "Kitaplar");

            migrationBuilder.DropTable(
                name: "Sepettekiler");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "UKitapAyrıntıları");

            migrationBuilder.DropTable(
                name: "Ürün_Diğerleri");

            migrationBuilder.DropTable(
                name: "Ürün_Kitaplar");
        }
    }
}
