using PlakDukkani.Siniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlakDukkani
{
    public partial class YoneticiEklemeForm : Form
    {
        private readonly PlakDukkaniDbContext _db;
        public YoneticiEklemeForm(PlakDukkaniDbContext db)
        {
            _db = db;

            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Yonetici yonetici = new Yonetici();

            if(txtKullaniciAdi.Text.Trim() == "")
            {
                MessageBox.Show("Kullanıcı adı bölümü boş bırakılamaz.");
                return;
            }

            if (_db.Yoneticiler.Where(x => x.KullaniciAdi == txtKullaniciAdi.Text.Trim()).Any())
            {
                MessageBox.Show("Lütfen başka bir kullanıcı adı giriniz.");
                txtSifre.Text = "";
                txtSifreTekrar.Text = "";
                return;
            }

            int kucuk = 0;
            int buyuk = 0;
            int ozel = 0;
            foreach (char c in txtSifre.Text.Trim())
            {
                if (char.IsUpper(c))
                    buyuk++;

                if (char.IsLower(c))
                    kucuk++;

                if (c == '!' || c == ':' || c == '+' || c == '*')
                    ozel++;
            }

            if (txtSifre.Text.Trim().Count() < 7 || buyuk < 2 || kucuk < 3 || ozel < 2)
            {
                MessageBox.Show("Şifreniz oluşturulamadı tekrar deneyiniz.\nŞifre kuralları:\r\n• En az 8 karakter uzunluğunda olmalıdır.\r\n• En az 2 büyük harf içermelidir.\r\n• En az 3 küçük harf içermelidir.\r\n• ! (ünlem), : (iki nokta üst üste), +(artı), *(yıldız) karakterlerinden en az 2 tanesini içermelidir. (Aynı karakterden birden fazla olabilir)");

                txtSifre.Text = "";
                txtSifreTekrar.Text = "";
                return;
            }

            if (txtSifre.Text.Trim() != txtSifreTekrar.Text.Trim())
            {
                MessageBox.Show("Uyumsuz şifre tekrarı");
                return;
            }

            yonetici.KullaniciAdi = txtKullaniciAdi.Text.Trim();

            yonetici.Sifre = sha256_hash(txtSifre.Text.Trim());

            _db.Yoneticiler.Add(yonetici);
            _db.SaveChanges();
            MessageBox.Show("Yeni yönetici oluşturulmuştur.");

        }
        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }
    }
}
