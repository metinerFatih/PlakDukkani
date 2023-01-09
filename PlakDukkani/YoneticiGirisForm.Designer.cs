namespace Album
{
    partial class YoneticiGirisForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiGirisForm));
            this.label1 = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnAnaBolum = new System.Windows.Forms.Button();
            this.btnYoneticiEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(97, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 451);
            this.label1.TabIndex = 0;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.Black;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.Salmon;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(152, 96);
            this.lblKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(127, 25);
            this.lblKullaniciAdi.TabIndex = 1;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.Black;
            this.lblSifre.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSifre.ForeColor = System.Drawing.Color.Salmon;
            this.lblSifre.Location = new System.Drawing.Point(152, 193);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(58, 25);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "Şifre:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.SystemColors.Menu;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKullaniciAdi.Location = new System.Drawing.Point(152, 131);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(274, 29);
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSifre.Location = new System.Drawing.Point(152, 240);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(274, 29);
            this.txtSifre.TabIndex = 2;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGiris.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGiris.Location = new System.Drawing.Point(152, 369);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(275, 78);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnAnaBolum
            // 
            this.btnAnaBolum.Location = new System.Drawing.Point(121, 79);
            this.btnAnaBolum.Name = "btnAnaBolum";
            this.btnAnaBolum.Size = new System.Drawing.Size(330, 98);
            this.btnAnaBolum.TabIndex = 5;
            this.btnAnaBolum.Text = "ANA BÖLÜM";
            this.btnAnaBolum.UseVisualStyleBackColor = true;
            this.btnAnaBolum.Visible = false;
            this.btnAnaBolum.Click += new System.EventHandler(this.btnAnaBolum_Click);
            // 
            // btnYoneticiEkle
            // 
            this.btnYoneticiEkle.Location = new System.Drawing.Point(121, 308);
            this.btnYoneticiEkle.Name = "btnYoneticiEkle";
            this.btnYoneticiEkle.Size = new System.Drawing.Size(330, 96);
            this.btnYoneticiEkle.TabIndex = 6;
            this.btnYoneticiEkle.Text = "YÖNETİCİ EKLE";
            this.btnYoneticiEkle.UseVisualStyleBackColor = true;
            this.btnYoneticiEkle.Visible = false;
            this.btnYoneticiEkle.Click += new System.EventHandler(this.btnYoneticiEkle_Click);
            // 
            // YoneticiGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 549);
            this.Controls.Add(this.btnYoneticiEkle);
            this.Controls.Add(this.btnAnaBolum);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "YoneticiGirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblKullaniciAdi;
        private Label lblSifre;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button btnGiris;
        private Button btnAnaBolum;
        private Button btnYoneticiEkle;
    }
}