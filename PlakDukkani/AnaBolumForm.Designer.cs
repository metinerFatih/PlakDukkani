namespace PlakDukkani
{
    partial class AnaBolumForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstDurmus2 = new System.Windows.Forms.ListBox();
            this.lstDurmus = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.nudIndirim = new System.Windows.Forms.NumericUpDown();
            this.cmbSatisDurumu = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dtZaman = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstDevam = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lstSonOn2 = new System.Windows.Forms.ListBox();
            this.lstSonOn = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSanatcıAd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lstDevam2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstIndirim = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlbumAd = new System.Windows.Forms.TextBox();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lstIndirim2 = new System.Windows.Forms.ListBox();
            this.grbx = new System.Windows.Forms.GroupBox();
            this.dgvAlbumler = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIndirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lstDurmus2);
            this.groupBox1.Controls.Add(this.lstDurmus);
            this.groupBox1.Location = new System.Drawing.Point(23, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 277);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satışı Durmuş ";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(125, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Sanatçı";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Albüm Adı";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstDurmus2
            // 
            this.lstDurmus2.DisplayMember = "SanatciAdi";
            this.lstDurmus2.FormattingEnabled = true;
            this.lstDurmus2.HorizontalScrollbar = true;
            this.lstDurmus2.ItemHeight = 21;
            this.lstDurmus2.Location = new System.Drawing.Point(118, 55);
            this.lstDurmus2.Name = "lstDurmus2";
            this.lstDurmus2.ScrollAlwaysVisible = true;
            this.lstDurmus2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstDurmus2.Size = new System.Drawing.Size(127, 214);
            this.lstDurmus2.TabIndex = 6;
            // 
            // lstDurmus
            // 
            this.lstDurmus.DisplayMember = "AlbumAd";
            this.lstDurmus.FormattingEnabled = true;
            this.lstDurmus.HorizontalScrollbar = true;
            this.lstDurmus.ItemHeight = 21;
            this.lstDurmus.Location = new System.Drawing.Point(0, 55);
            this.lstDurmus.Name = "lstDurmus";
            this.lstDurmus.ScrollAlwaysVisible = true;
            this.lstDurmus.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstDurmus.Size = new System.Drawing.Size(119, 214);
            this.lstDurmus.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBox5);
            this.groupBox5.Location = new System.Drawing.Point(501, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(220, 250);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox4";
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 21;
            this.listBox5.Location = new System.Drawing.Point(6, 28);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(208, 214);
            this.listBox5.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(798, 217);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(170, 64);
            this.btnKaydet.TabIndex = 20;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Visible = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // nudIndirim
            // 
            this.nudIndirim.Location = new System.Drawing.Point(701, 217);
            this.nudIndirim.Margin = new System.Windows.Forms.Padding(4);
            this.nudIndirim.Name = "nudIndirim";
            this.nudIndirim.Size = new System.Drawing.Size(80, 29);
            this.nudIndirim.TabIndex = 19;
            this.nudIndirim.Visible = false;
            // 
            // cmbSatisDurumu
            // 
            this.cmbSatisDurumu.FormattingEnabled = true;
            this.cmbSatisDurumu.Items.AddRange(new object[] {
            "Devam Ediyor",
            "Durduruldu"});
            this.cmbSatisDurumu.Location = new System.Drawing.Point(701, 252);
            this.cmbSatisDurumu.Name = "cmbSatisDurumu";
            this.cmbSatisDurumu.Size = new System.Drawing.Size(80, 29);
            this.cmbSatisDurumu.TabIndex = 18;
            this.cmbSatisDurumu.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1158, 421);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(132, 29);
            this.numericUpDown1.TabIndex = 17;
            // 
            // dtZaman
            // 
            this.dtZaman.Location = new System.Drawing.Point(701, 146);
            this.dtZaman.Name = "dtZaman";
            this.dtZaman.Size = new System.Drawing.Size(267, 29);
            this.dtZaman.TabIndex = 16;
            this.dtZaman.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(590, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Satış Durumu:";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "İndirim Oranı (%):";
            this.label5.Visible = false;
            // 
            // lstDevam
            // 
            this.lstDevam.DisplayMember = "AlbumAd";
            this.lstDevam.FormattingEnabled = true;
            this.lstDevam.HorizontalScrollbar = true;
            this.lstDevam.ItemHeight = 21;
            this.lstDevam.Location = new System.Drawing.Point(6, 55);
            this.lstDevam.Name = "lstDevam";
            this.lstDevam.ScrollAlwaysVisible = true;
            this.lstDevam.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstDevam.Size = new System.Drawing.Size(114, 214);
            this.lstDevam.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lstSonOn2);
            this.groupBox3.Controls.Add(this.lstSonOn);
            this.groupBox3.Location = new System.Drawing.Point(516, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 277);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Son 10 Albüm";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(120, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 20);
            this.label13.TabIndex = 11;
            this.label13.Text = "Sanatçı";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 24);
            this.label10.TabIndex = 10;
            this.label10.Text = "Albüm Adı";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstSonOn2
            // 
            this.lstSonOn2.DisplayMember = "SanatciAdi";
            this.lstSonOn2.FormattingEnabled = true;
            this.lstSonOn2.HorizontalScrollbar = true;
            this.lstSonOn2.ItemHeight = 21;
            this.lstSonOn2.Location = new System.Drawing.Point(120, 55);
            this.lstSonOn2.Name = "lstSonOn2";
            this.lstSonOn2.ScrollAlwaysVisible = true;
            this.lstSonOn2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstSonOn2.Size = new System.Drawing.Size(125, 214);
            this.lstSonOn2.TabIndex = 4;
            // 
            // lstSonOn
            // 
            this.lstSonOn.DisplayMember = "AlbumAd";
            this.lstSonOn.FormattingEnabled = true;
            this.lstSonOn.HorizontalScrollbar = true;
            this.lstSonOn.ItemHeight = 21;
            this.lstSonOn.Location = new System.Drawing.Point(6, 55);
            this.lstSonOn.Name = "lstSonOn";
            this.lstSonOn.ScrollAlwaysVisible = true;
            this.lstSonOn.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstSonOn.Size = new System.Drawing.Size(117, 214);
            this.lstSonOn.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fiyat (₺):";
            this.label4.Visible = false;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(701, 179);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(267, 29);
            this.txtFiyat.TabIndex = 10;
            this.txtFiyat.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(611, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Çıkış Tarihi:";
            this.label3.Visible = false;
            // 
            // txtSanatcıAd
            // 
            this.txtSanatcıAd.Location = new System.Drawing.Point(701, 111);
            this.txtSanatcıAd.Name = "txtSanatcıAd";
            this.txtSanatcıAd.Size = new System.Drawing.Size(267, 29);
            this.txtSanatcıAd.TabIndex = 6;
            this.txtSanatcıAd.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lstDevam2);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.lstDevam);
            this.groupBox2.Location = new System.Drawing.Point(274, 341);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 277);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satışı Devam Eden";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(117, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Sanatçı";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(0, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Albüm Adı";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstDevam2
            // 
            this.lstDevam2.DisplayMember = "SanatciAdi";
            this.lstDevam2.FormattingEnabled = true;
            this.lstDevam2.HorizontalScrollbar = true;
            this.lstDevam2.ItemHeight = 21;
            this.lstDevam2.Location = new System.Drawing.Point(117, 55);
            this.lstDevam2.Name = "lstDevam2";
            this.lstDevam2.ScrollAlwaysVisible = true;
            this.lstDevam2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstDevam2.Size = new System.Drawing.Size(121, 214);
            this.lstDevam2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(634, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sanatçı:";
            this.label2.Visible = false;
            // 
            // lstIndirim
            // 
            this.lstIndirim.DisplayMember = "AlbumAd";
            this.lstIndirim.FormattingEnabled = true;
            this.lstIndirim.HorizontalScrollbar = true;
            this.lstIndirim.ItemHeight = 21;
            this.lstIndirim.Location = new System.Drawing.Point(6, 56);
            this.lstIndirim.Name = "lstIndirim";
            this.lstIndirim.ScrollAlwaysVisible = true;
            this.lstIndirim.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstIndirim.Size = new System.Drawing.Size(119, 214);
            this.lstIndirim.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(609, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Albüm Adı:";
            this.label1.Visible = false;
            // 
            // txtAlbumAd
            // 
            this.txtAlbumAd.Location = new System.Drawing.Point(701, 77);
            this.txtAlbumAd.Name = "txtAlbumAd";
            this.txtAlbumAd.Size = new System.Drawing.Size(267, 29);
            this.txtAlbumAd.TabIndex = 4;
            this.txtAlbumAd.Visible = false;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(853, 28);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(115, 33);
            this.btnDuzenle.TabIndex = 3;
            this.btnDuzenle.Text = "DÜZENLE";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(737, 28);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(110, 33);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(621, 28);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(110, 33);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.lstIndirim2);
            this.groupBox4.Controls.Add(this.lstIndirim);
            this.groupBox4.Location = new System.Drawing.Point(760, 341);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(245, 277);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İndirimdeki Albümler";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(121, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 20);
            this.label14.TabIndex = 12;
            this.label14.Text = "Sanatçı";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(0, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 24);
            this.label11.TabIndex = 11;
            this.label11.Text = "Albüm Adı";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstIndirim2
            // 
            this.lstIndirim2.DisplayMember = "SanatciAdi";
            this.lstIndirim2.FormattingEnabled = true;
            this.lstIndirim2.HorizontalScrollbar = true;
            this.lstIndirim2.ItemHeight = 21;
            this.lstIndirim2.Location = new System.Drawing.Point(121, 56);
            this.lstIndirim2.Name = "lstIndirim2";
            this.lstIndirim2.ScrollAlwaysVisible = true;
            this.lstIndirim2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstIndirim2.Size = new System.Drawing.Size(124, 214);
            this.lstIndirim2.TabIndex = 5;
            // 
            // grbx
            // 
            this.grbx.Controls.Add(this.btnKaydet);
            this.grbx.Controls.Add(this.nudIndirim);
            this.grbx.Controls.Add(this.cmbSatisDurumu);
            this.grbx.Controls.Add(this.numericUpDown1);
            this.grbx.Controls.Add(this.dtZaman);
            this.grbx.Controls.Add(this.label6);
            this.grbx.Controls.Add(this.label5);
            this.grbx.Controls.Add(this.label4);
            this.grbx.Controls.Add(this.txtFiyat);
            this.grbx.Controls.Add(this.label3);
            this.grbx.Controls.Add(this.label2);
            this.grbx.Controls.Add(this.txtSanatcıAd);
            this.grbx.Controls.Add(this.label1);
            this.grbx.Controls.Add(this.txtAlbumAd);
            this.grbx.Controls.Add(this.btnDuzenle);
            this.grbx.Controls.Add(this.btnSil);
            this.grbx.Controls.Add(this.btnEkle);
            this.grbx.Controls.Add(this.dgvAlbumler);
            this.grbx.Location = new System.Drawing.Point(23, 39);
            this.grbx.Name = "grbx";
            this.grbx.Size = new System.Drawing.Size(974, 296);
            this.grbx.TabIndex = 7;
            this.grbx.TabStop = false;
            this.grbx.Text = "ALBÜMLER";
            // 
            // dgvAlbumler
            // 
            this.dgvAlbumler.AllowUserToAddRows = false;
            this.dgvAlbumler.AllowUserToDeleteRows = false;
            this.dgvAlbumler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAlbumler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAlbumler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbumler.Location = new System.Drawing.Point(18, 26);
            this.dgvAlbumler.MultiSelect = false;
            this.dgvAlbumler.Name = "dgvAlbumler";
            this.dgvAlbumler.ReadOnly = true;
            this.dgvAlbumler.RowTemplate.Height = 25;
            this.dgvAlbumler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlbumler.Size = new System.Drawing.Size(540, 255);
            this.dgvAlbumler.TabIndex = 0;
            // 
            // AnaBolumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grbx);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnaBolumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaBolumForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudIndirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.grbx.ResumeLayout(false);
            this.grbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lstDurmus;
        private GroupBox groupBox5;
        private ListBox listBox5;
        private Button btnKaydet;
        private NumericUpDown nudIndirim;
        private ComboBox cmbSatisDurumu;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dtZaman;
        private Label label6;
        private Label label5;
        private ListBox lstDevam;
        private GroupBox groupBox3;
        private ListBox lstSonOn;
        private Label label4;
        private TextBox txtFiyat;
        private Label label3;
        private TextBox txtSanatcıAd;
        private GroupBox groupBox2;
        private Label label2;
        private ListBox lstIndirim;
        private Label label1;
        private TextBox txtAlbumAd;
        private Button btnDuzenle;
        private Button btnSil;
        private Button btnEkle;
        private GroupBox groupBox4;
        private GroupBox grbx;
        private DataGridView dgvAlbumler;
        private ListBox lstDurmus2;
        private ListBox lstSonOn2;
        private ListBox lstDevam2;
        private ListBox lstIndirim2;
        private Label label8;
        private Label label7;
        private Label label13;
        private Label label10;
        private Label label12;
        private Label label9;
        private Label label14;
        private Label label11;
    }
}