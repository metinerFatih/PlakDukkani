using PlakDukkani.Siniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlakDukkani
{
    public partial class AnaBolumForm : Form
    {
        private readonly PlakDukkaniDbContext _db;
        int id = 0;
        public AnaBolumForm(PlakDukkaniDbContext db)
        {
            _db = db;

            InitializeComponent();
            Guncelle();
        }
        private void Guncelle()
        {
            dgvAlbumler.DataSource = _db.Albumler.ToList();

            lstDevam.DataSource = _db.Albumler.Where(x => x.SatisDurum == true).ToList();
            lstDevam2.DataSource = _db.Albumler.Where(x => x.SatisDurum == true).ToList();

            lstDurmus.DataSource = _db.Albumler.Where(x => x.SatisDurum == false).ToList();
            lstDurmus2.DataSource = _db.Albumler.Where(x => x.SatisDurum == false).ToList();

            lstIndirim.DataSource = _db.Albumler.Where(x => x.IndirimOrani > 0).OrderBy(x => x.IndirimOrani).ToList();
            lstIndirim2.DataSource = _db.Albumler.Where(x => x.IndirimOrani > 0).OrderBy(x => x.IndirimOrani).ToList();

            lstSonOn.DataSource = _db.Albumler.OrderByDescending(x => x.Id).Take(10).ToList();
            lstSonOn2.DataSource = _db.Albumler.OrderByDescending(x => x.Id).Take(10).ToList();
        }
        private void GorunurYap()
        {
            txtAlbumAd.Visible = true;
            txtFiyat.Visible = true;
            txtSanatcıAd.Visible = true;
            cmbSatisDurumu.Visible = true;
            dtZaman.Visible = true;
            nudIndirim.Visible = true;
            btnKaydet.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
        }

        private void GorunmezYap()
        {
            txtAlbumAd.Visible = false;
            txtFiyat.Visible = false;
            txtSanatcıAd.Visible = false;
            cmbSatisDurumu.Visible = false;
            dtZaman.Visible = false;
            nudIndirim.Visible = false;
            btnKaydet.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            GorunurYap();

            txtAlbumAd.Text = "";
            txtFiyat.Text = "";
            txtSanatcıAd.Text = "";
            cmbSatisDurumu.SelectedIndex = 0;
            dtZaman.Value = DateTime.Now;
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            GorunurYap();

            Siniflar.Album album = (Siniflar.Album)dgvAlbumler.SelectedRows[0].DataBoundItem;

            id = album.Id;
            txtAlbumAd.Text = album.AlbumAd;
            txtFiyat.Text = album.Fiyat.ToString("n2");
            txtSanatcıAd.Text = album.SanatciAdi;
            if(album.SatisDurum)
                cmbSatisDurumu.SelectedIndex = 0;
            else
                cmbSatisDurumu.SelectedIndex = 1;
            dtZaman.Value = album.CikisTarihi;
            nudIndirim.Value = album.IndirimOrani;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(_db.Albumler.Where(x => x.Id == id).Any())
            {
                Siniflar.Album album = (Siniflar.Album)dgvAlbumler.SelectedRows[0].DataBoundItem;
                album.AlbumAd = txtAlbumAd.Text;
                album.Fiyat = Convert.ToDecimal(txtFiyat.Text);
                album.SanatciAdi = txtSanatcıAd.Text;
                if (cmbSatisDurumu.SelectedIndex == 0)
                    album.SatisDurum = true;
                else
                    album.SatisDurum = false;

                album.CikisTarihi = dtZaman.Value;
                album.IndirimOrani = (int)nudIndirim.Value;

                _db.SaveChanges();
                id = 0;
                GorunmezYap();
                Guncelle();
            }
            else
            {
                Siniflar.Album yeniAlbum = new Siniflar.Album();
                yeniAlbum.AlbumAd = txtAlbumAd.Text;
                if (cmbSatisDurumu.SelectedIndex == 0)
                    yeniAlbum.SatisDurum = true;
                else
                    yeniAlbum.SatisDurum = false;
                yeniAlbum.CikisTarihi = dtZaman.Value;
                yeniAlbum.Fiyat = Convert.ToDecimal(txtFiyat.Text);
                yeniAlbum.IndirimOrani = (int)nudIndirim.Value;
                yeniAlbum.SanatciAdi = txtSanatcıAd.Text;

                _db.Albumler.Add(yeniAlbum);
                _db.SaveChanges();
                GorunmezYap();
                Guncelle();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Siniflar.Album album = (Siniflar.Album)dgvAlbumler.SelectedRows[0].DataBoundItem;
            _db.Albumler.Remove(album);
            _db.SaveChanges();
            Guncelle();
        }
    }
}
