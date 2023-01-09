using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlakDukkani.Migrations
{
    public partial class ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albumler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SanatciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CikisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IndirimOrani = table.Column<int>(type: "int", nullable: false),
                    SatisDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albumler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yoneticiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yoneticiler", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Albumler",
                columns: new[] { "Id", "AlbumAd", "CikisTarihi", "Fiyat", "IndirimOrani", "SanatciAdi", "SatisDurum" },
                values: new object[,]
                {
                    { 1, "Bir Başka Sevgiliyi Sevemem Sevemem", new DateTime(2023, 1, 9, 17, 55, 52, 146, DateTimeKind.Local).AddTicks(3896), 250m, 20, "Erol Büyükburç", true },
                    { 2, "Mavi", new DateTime(2023, 1, 9, 17, 55, 52, 146, DateTimeKind.Local).AddTicks(3910), 230m, 0, "Emel Sayın", false },
                    { 3, "Yazık Oldu Yarınlara", new DateTime(2023, 1, 9, 17, 55, 52, 146, DateTimeKind.Local).AddTicks(3912), 200m, 10, "İlhan İrem", false },
                    { 4, "O Ağacın Altı", new DateTime(2023, 1, 9, 17, 55, 52, 146, DateTimeKind.Local).AddTicks(3913), 280m, 0, "Zeki Müren", true },
                    { 5, "Nedir Benim Günahım", new DateTime(2023, 1, 9, 17, 55, 52, 146, DateTimeKind.Local).AddTicks(3914), 210m, 25, "Gönül Akkor", true },
                    { 6, "Aşk Başlarken", new DateTime(2023, 1, 9, 17, 55, 52, 146, DateTimeKind.Local).AddTicks(3915), 300m, 25, "Erol Evgin", false },
                    { 7, "Söz Verirsin Severek", new DateTime(2023, 1, 9, 17, 55, 52, 146, DateTimeKind.Local).AddTicks(3916), 300m, 0, "Zeki Müren", false },
                    { 8, "Gönül Dağı", new DateTime(2023, 1, 9, 17, 55, 52, 146, DateTimeKind.Local).AddTicks(3917), 250m, 0, "Neşet Ertaş", true },
                    { 9, "Frank Sinatra", new DateTime(2023, 1, 9, 17, 55, 52, 146, DateTimeKind.Local).AddTicks(3919), 250m, 10, "Frank Sinatra", false },
                    { 10, "Hoş Gör Sen", new DateTime(2023, 1, 9, 17, 55, 52, 146, DateTimeKind.Local).AddTicks(3920), 320m, 25, "Ajda Pekkan", true },
                    { 11, "Merhaba Gençler", new DateTime(2023, 1, 9, 17, 55, 52, 146, DateTimeKind.Local).AddTicks(3921), 210m, 10, "Cem Karaca", false }
                });

            migrationBuilder.InsertData(
                table: "Yoneticiler",
                columns: new[] { "Id", "KullaniciAdi", "Sifre" },
                values: new object[] { 1, "admin1", "!:ASdfg1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albumler");

            migrationBuilder.DropTable(
                name: "Yoneticiler");
        }
    }
}
