using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkani.Siniflar
{
    public class PlakDukkaniDbContext : DbContext
    {
        public DbSet<Album> Albumler { get; set; }
        public DbSet<Yonetici> Yoneticiler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MONSTER\\MSSQLSERVER2022; database=PlakDukkaniDb; Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Yonetici>().HasData(new Yonetici
            {
                Id = 1,
                KullaniciAdi = "admin1",
                Sifre = "!:ASdfg1"
            });

            modelBuilder.Entity<Album>().HasData(
            new Album() { Id = 1, AlbumAd = "Bir Başka Sevgiliyi Sevemem Sevemem", SanatciAdi = "Erol Büyükburç", CikisTarihi = DateTime.Now, Fiyat = 250, IndirimOrani = 20, SatisDurum = true },
            new Album() { Id = 2, AlbumAd = "Mavi", SanatciAdi = "Emel Sayın", CikisTarihi = DateTime.Now, Fiyat = 230, IndirimOrani = 0, SatisDurum = false },
            new Album() { Id = 3, AlbumAd = "Yazık Oldu Yarınlara", SanatciAdi = "İlhan İrem", CikisTarihi = DateTime.Now, Fiyat = 200, IndirimOrani = 10, SatisDurum = false },
            new Album() { Id = 4, AlbumAd = "O Ağacın Altı", SanatciAdi = "Zeki Müren", CikisTarihi = DateTime.Now, Fiyat = 280, IndirimOrani = 0, SatisDurum = true },
            new Album() { Id = 5, AlbumAd = "Nedir Benim Günahım", SanatciAdi = "Gönül Akkor", CikisTarihi = DateTime.Now, Fiyat = 210, IndirimOrani = 25, SatisDurum = true },
            new Album() { Id = 6, AlbumAd = "Aşk Başlarken", SanatciAdi = "Erol Evgin", CikisTarihi = DateTime.Now, Fiyat = 300, IndirimOrani = 25, SatisDurum = false },
            new Album() { Id = 7, AlbumAd = "Söz Verirsin Severek", SanatciAdi = "Zeki Müren", CikisTarihi = DateTime.Now, Fiyat = 300, IndirimOrani = 0, SatisDurum = false },
            new Album() { Id = 8, AlbumAd = "Gönül Dağı", SanatciAdi = "Neşet Ertaş", CikisTarihi = DateTime.Now, Fiyat = 250, IndirimOrani = 0, SatisDurum = true },
            new Album() { Id = 9, AlbumAd = "Frank Sinatra", SanatciAdi = "Frank Sinatra", CikisTarihi = DateTime.Now, Fiyat = 250, IndirimOrani = 10, SatisDurum = false },
            new Album() { Id = 10, AlbumAd = "Hoş Gör Sen", SanatciAdi = "Ajda Pekkan", CikisTarihi = DateTime.Now, Fiyat = 320, IndirimOrani = 25, SatisDurum = true },
            new Album() { Id = 11, AlbumAd = "Merhaba Gençler", SanatciAdi = "Cem Karaca", CikisTarihi = DateTime.Now, Fiyat = 210, IndirimOrani = 10, SatisDurum = false }
            );
        }
    }
}
