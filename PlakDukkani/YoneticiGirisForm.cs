using PlakDukkani;
using PlakDukkani.Siniflar;
using System.Security.Cryptography;
using System.Text;

namespace Album
{
    public partial class YoneticiGirisForm : Form
    {
        PlakDukkaniDbContext db = new PlakDukkaniDbContext();
        public YoneticiGirisForm()
        {
            InitializeComponent();
        }
        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(db.Yoneticiler.Where(x => x.KullaniciAdi == txtKullaniciAdi.Text.Trim() && x.Sifre == sha256_hash(txtSifre.Text.Trim())).Any())
            {
                MessageBox.Show("Giriþ Yapýldý");
                lblKullaniciAdi.Visible = false;
                lblSifre.Visible = false;
                txtSifre.Visible = false;
                txtKullaniciAdi.Visible = false;
                btnGiris.Visible = false;
                btnAnaBolum.Visible = true;
                btnYoneticiEkle.Visible = true;
            }
            else
            {
                MessageBox.Show("Geçersiz kullanýcý adý veya þifresi girdiniz.");
                return;
            }
        }

        private void btnAnaBolum_Click(object sender, EventArgs e)
        {
            var frm = new AnaBolumForm(db);
            DialogResult dr = frm.ShowDialog();
            this.Close();
        }

        private void btnYoneticiEkle_Click(object sender, EventArgs e)
        {
            var frm = new YoneticiEklemeForm(db);
            DialogResult dr = frm.ShowDialog();
            this.Close();
        }
    }
}