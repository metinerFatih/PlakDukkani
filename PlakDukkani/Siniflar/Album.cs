using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkani.Siniflar
{
    public class Album
    {
        public int Id { get; set; }
        public string AlbumAd { get; set; }
        public string SanatciAdi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public decimal Fiyat { get; set; }
        public int IndirimOrani { get; set; }
        public bool SatisDurum { get; set; }
    }
}
