
namespace Kutuphane_Otomasyon_Taslak_winform
{
    partial class Emanet
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEmanet = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mskveris = new System.Windows.Forms.MaskedTextBox();
            this.mskalis = new System.Windows.Forms.MaskedTextBox();
            this.txtemanetakts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtkitapId = new System.Windows.Forms.TextBox();
            this.dataGridViewkitap = new System.Windows.Forms.DataGridView();
            this.dataGridViewogrenci = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kaplaButon = new System.Windows.Forms.Button();
            this.simgeButon = new System.Windows.Forms.Button();
            this.cikisButon = new System.Windows.Forms.Button();
            this.infoBtn = new System.Windows.Forms.Button();
            this.anasayfaBtn = new System.Windows.Forms.Button();
            this.kitapBtn = new System.Windows.Forms.Button();
            this.emanetBtn = new System.Windows.Forms.Button();
            this.ogrenciBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnemanetver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.txtogrNo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtogrID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewogrenci)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.Koyu_Otomasyon_BackgroundK1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnEmanet);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.dataGridViewkitap);
            this.panel1.Controls.Add(this.dataGridViewogrenci);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnemanetver);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 585);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnEmanet
            // 
            this.btnEmanet.Location = new System.Drawing.Point(873, 413);
            this.btnEmanet.Name = "btnEmanet";
            this.btnEmanet.Size = new System.Drawing.Size(75, 23);
            this.btnEmanet.TabIndex = 15;
            this.btnEmanet.Text = "Emanet Sayfasi";
            this.btnEmanet.UseVisualStyleBackColor = true;
            this.btnEmanet.Click += new System.EventHandler(this.btnEmanet_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SlateGray;
            this.panel4.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.Koyu_Otomasyon_BackgroundK2;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.mskveris);
            this.panel4.Controls.Add(this.mskalis);
            this.panel4.Controls.Add(this.txtemanetakts);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtKitapAd);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.txtkitapId);
            this.panel4.Location = new System.Drawing.Point(443, 74);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 226);
            this.panel4.TabIndex = 14;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // mskveris
            // 
            this.mskveris.Location = new System.Drawing.Point(239, 111);
            this.mskveris.Mask = "00/00/0000 90:00:00";
            this.mskveris.Name = "mskveris";
            this.mskveris.Size = new System.Drawing.Size(141, 20);
            this.mskveris.TabIndex = 18;
            this.mskveris.ValidatingType = typeof(System.DateTime);
            this.mskveris.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskveris_MaskInputRejected);
            // 
            // mskalis
            // 
            this.mskalis.Location = new System.Drawing.Point(238, 84);
            this.mskalis.Mask = "00/00/0000 90:00:00";
            this.mskalis.Name = "mskalis";
            this.mskalis.Size = new System.Drawing.Size(141, 20);
            this.mskalis.TabIndex = 17;
            this.mskalis.ValidatingType = typeof(System.DateTime);
            this.mskalis.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskalis_MaskInputRejected);
            // 
            // txtemanetakts
            // 
            this.txtemanetakts.Location = new System.Drawing.Point(238, 136);
            this.txtemanetakts.Margin = new System.Windows.Forms.Padding(2);
            this.txtemanetakts.Name = "txtemanetakts";
            this.txtemanetakts.Size = new System.Drawing.Size(142, 20);
            this.txtemanetakts.TabIndex = 16;
            this.txtemanetakts.TextChanged += new System.EventHandler(this.txtemanetakts_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Veriş Tarihi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Alış Tarihi ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Location = new System.Drawing.Point(238, 56);
            this.txtKitapAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(142, 20);
            this.txtKitapAd.TabIndex = 4;
            this.txtKitapAd.TextChanged += new System.EventHandler(this.txtKitapAd_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.userLine;
            this.pictureBox2.Location = new System.Drawing.Point(21, 28);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 162);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtkitapId
            // 
            this.txtkitapId.Location = new System.Drawing.Point(238, 34);
            this.txtkitapId.Margin = new System.Windows.Forms.Padding(2);
            this.txtkitapId.Name = "txtkitapId";
            this.txtkitapId.Size = new System.Drawing.Size(142, 20);
            this.txtkitapId.TabIndex = 1;
            this.txtkitapId.TextChanged += new System.EventHandler(this.txtkitapId_TextChanged);
            // 
            // dataGridViewkitap
            // 
            this.dataGridViewkitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewkitap.Location = new System.Drawing.Point(443, 344);
            this.dataGridViewkitap.Name = "dataGridViewkitap";
            this.dataGridViewkitap.Size = new System.Drawing.Size(397, 182);
            this.dataGridViewkitap.TabIndex = 13;
            this.dataGridViewkitap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewkitap_CellClick);
            this.dataGridViewkitap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewkitap_CellContentClick);
            // 
            // dataGridViewogrenci
            // 
            this.dataGridViewogrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewogrenci.Location = new System.Drawing.Point(18, 344);
            this.dataGridViewogrenci.Name = "dataGridViewogrenci";
            this.dataGridViewogrenci.Size = new System.Drawing.Size(397, 182);
            this.dataGridViewogrenci.TabIndex = 12;
            this.dataGridViewogrenci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewogrenci_CellClick);
            this.dataGridViewogrenci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewogrenci_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.kaplaButon);
            this.panel2.Controls.Add(this.simgeButon);
            this.panel2.Controls.Add(this.cikisButon);
            this.panel2.Controls.Add(this.infoBtn);
            this.panel2.Controls.Add(this.anasayfaBtn);
            this.panel2.Controls.Add(this.kitapBtn);
            this.panel2.Controls.Add(this.emanetBtn);
            this.panel2.Controls.Add(this.ogrenciBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 41);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // kaplaButon
            // 
            this.kaplaButon.BackColor = System.Drawing.Color.Transparent;
            this.kaplaButon.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.maximizeSyhKntr30;
            this.kaplaButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kaplaButon.Cursor = System.Windows.Forms.Cursors.Default;
            this.kaplaButon.FlatAppearance.BorderSize = 0;
            this.kaplaButon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.kaplaButon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.kaplaButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaplaButon.ForeColor = System.Drawing.Color.Transparent;
            this.kaplaButon.Location = new System.Drawing.Point(917, 2);
            this.kaplaButon.Margin = new System.Windows.Forms.Padding(2);
            this.kaplaButon.Name = "kaplaButon";
            this.kaplaButon.Size = new System.Drawing.Size(18, 20);
            this.kaplaButon.TabIndex = 13;
            this.kaplaButon.UseVisualStyleBackColor = true;
            this.kaplaButon.Click += new System.EventHandler(this.kaplaButon_Click);
            // 
            // simgeButon
            // 
            this.simgeButon.BackColor = System.Drawing.Color.Transparent;
            this.simgeButon.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.minus;
            this.simgeButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.simgeButon.Cursor = System.Windows.Forms.Cursors.Default;
            this.simgeButon.FlatAppearance.BorderSize = 0;
            this.simgeButon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.simgeButon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.simgeButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simgeButon.ForeColor = System.Drawing.Color.Transparent;
            this.simgeButon.Location = new System.Drawing.Point(895, 2);
            this.simgeButon.Margin = new System.Windows.Forms.Padding(2);
            this.simgeButon.Name = "simgeButon";
            this.simgeButon.Size = new System.Drawing.Size(18, 20);
            this.simgeButon.TabIndex = 12;
            this.simgeButon.UseVisualStyleBackColor = true;
            this.simgeButon.Click += new System.EventHandler(this.simgeButon_Click);
            // 
            // cikisButon
            // 
            this.cikisButon.BackColor = System.Drawing.Color.Transparent;
            this.cikisButon.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.remove;
            this.cikisButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cikisButon.Cursor = System.Windows.Forms.Cursors.Default;
            this.cikisButon.FlatAppearance.BorderSize = 0;
            this.cikisButon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.cikisButon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.cikisButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisButon.ForeColor = System.Drawing.Color.Transparent;
            this.cikisButon.Location = new System.Drawing.Point(940, 2);
            this.cikisButon.Margin = new System.Windows.Forms.Padding(2);
            this.cikisButon.Name = "cikisButon";
            this.cikisButon.Size = new System.Drawing.Size(18, 20);
            this.cikisButon.TabIndex = 11;
            this.cikisButon.UseVisualStyleBackColor = true;
            this.cikisButon.Click += new System.EventHandler(this.cikisButon_Click);
            // 
            // infoBtn
            // 
            this.infoBtn.BackColor = System.Drawing.Color.Transparent;
            this.infoBtn.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.info;
            this.infoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoBtn.FlatAppearance.BorderSize = 0;
            this.infoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.infoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.infoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.infoBtn.Location = new System.Drawing.Point(195, 3);
            this.infoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(32, 34);
            this.infoBtn.TabIndex = 9;
            this.infoBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.infoBtn.UseVisualStyleBackColor = false;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // anasayfaBtn
            // 
            this.anasayfaBtn.BackColor = System.Drawing.Color.Transparent;
            this.anasayfaBtn.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.home1;
            this.anasayfaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.anasayfaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anasayfaBtn.FlatAppearance.BorderSize = 0;
            this.anasayfaBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.anasayfaBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.anasayfaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anasayfaBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.anasayfaBtn.Location = new System.Drawing.Point(9, 3);
            this.anasayfaBtn.Margin = new System.Windows.Forms.Padding(2);
            this.anasayfaBtn.Name = "anasayfaBtn";
            this.anasayfaBtn.Size = new System.Drawing.Size(32, 34);
            this.anasayfaBtn.TabIndex = 2;
            this.anasayfaBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.anasayfaBtn.UseVisualStyleBackColor = false;
            this.anasayfaBtn.Click += new System.EventHandler(this.anasayfaBtn_Click);
            // 
            // kitapBtn
            // 
            this.kitapBtn.BackColor = System.Drawing.Color.Transparent;
            this.kitapBtn.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.bookSyh;
            this.kitapBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kitapBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitapBtn.FlatAppearance.BorderSize = 0;
            this.kitapBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.kitapBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.kitapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitapBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kitapBtn.Location = new System.Drawing.Point(148, 3);
            this.kitapBtn.Margin = new System.Windows.Forms.Padding(2);
            this.kitapBtn.Name = "kitapBtn";
            this.kitapBtn.Size = new System.Drawing.Size(32, 34);
            this.kitapBtn.TabIndex = 8;
            this.kitapBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kitapBtn.UseVisualStyleBackColor = false;
            this.kitapBtn.Click += new System.EventHandler(this.kitapBtn_Click);
            // 
            // emanetBtn
            // 
            this.emanetBtn.BackColor = System.Drawing.Color.DarkGray;
            this.emanetBtn.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.exchange;
            this.emanetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.emanetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emanetBtn.FlatAppearance.BorderSize = 0;
            this.emanetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.emanetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.emanetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emanetBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.emanetBtn.Location = new System.Drawing.Point(56, 3);
            this.emanetBtn.Margin = new System.Windows.Forms.Padding(2);
            this.emanetBtn.Name = "emanetBtn";
            this.emanetBtn.Size = new System.Drawing.Size(32, 34);
            this.emanetBtn.TabIndex = 6;
            this.emanetBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.emanetBtn.UseVisualStyleBackColor = false;
            this.emanetBtn.Click += new System.EventHandler(this.emanetBtn_Click);
            // 
            // ogrenciBtn
            // 
            this.ogrenciBtn.BackColor = System.Drawing.Color.Transparent;
            this.ogrenciBtn.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.male_student;
            this.ogrenciBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ogrenciBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ogrenciBtn.FlatAppearance.BorderSize = 0;
            this.ogrenciBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ogrenciBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ogrenciBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ogrenciBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ogrenciBtn.Location = new System.Drawing.Point(102, 3);
            this.ogrenciBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ogrenciBtn.Name = "ogrenciBtn";
            this.ogrenciBtn.Size = new System.Drawing.Size(32, 34);
            this.ogrenciBtn.TabIndex = 7;
            this.ogrenciBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ogrenciBtn.UseVisualStyleBackColor = false;
            this.ogrenciBtn.Click += new System.EventHandler(this.ogrenciBtn_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(867, 93);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 37);
            this.button3.TabIndex = 9;
            this.button3.Text = "Listeden Kitap Seç";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnemanetver
            // 
            this.btnemanetver.BackColor = System.Drawing.Color.Green;
            this.btnemanetver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnemanetver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnemanetver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnemanetver.Location = new System.Drawing.Point(867, 226);
            this.btnemanetver.Margin = new System.Windows.Forms.Padding(2);
            this.btnemanetver.Name = "btnemanetver";
            this.btnemanetver.Size = new System.Drawing.Size(68, 37);
            this.btnemanetver.TabIndex = 8;
            this.btnemanetver.Text = "Emanet Ver";
            this.btnemanetver.UseVisualStyleBackColor = false;
            this.btnemanetver.Click += new System.EventHandler(this.btnemanetver_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(867, 158);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Seçileni Çıkar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateGray;
            this.panel3.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.Koyu_Otomasyon_BackgroundK2;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.txtOgrSoyad);
            this.panel3.Controls.Add(this.txtOgrAd);
            this.panel3.Controls.Add(this.txtogrNo);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.txtogrID);
            this.panel3.Location = new System.Drawing.Point(18, 74);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 226);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.Location = new System.Drawing.Point(210, 100);
            this.txtOgrSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(142, 20);
            this.txtOgrSoyad.TabIndex = 6;
            this.txtOgrSoyad.TextChanged += new System.EventHandler(this.txtOgrSoyad_TextChanged);
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.Location = new System.Drawing.Point(210, 77);
            this.txtOgrAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(142, 20);
            this.txtOgrAd.TabIndex = 5;
            this.txtOgrAd.TextChanged += new System.EventHandler(this.txtOgrAd_TextChanged);
            // 
            // txtogrNo
            // 
            this.txtogrNo.Location = new System.Drawing.Point(210, 54);
            this.txtogrNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtogrNo.Name = "txtogrNo";
            this.txtogrNo.Size = new System.Drawing.Size(142, 20);
            this.txtogrNo.TabIndex = 4;
            this.txtogrNo.TextChanged += new System.EventHandler(this.txtogrNo_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.userLine;
            this.pictureBox1.Location = new System.Drawing.Point(21, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtogrID
            // 
            this.txtogrID.Location = new System.Drawing.Point(210, 32);
            this.txtogrID.Margin = new System.Windows.Forms.Padding(2);
            this.txtogrID.Name = "txtogrID";
            this.txtogrID.Size = new System.Drawing.Size(142, 20);
            this.txtogrID.TabIndex = 1;
            this.txtogrID.TextChanged += new System.EventHandler(this.txtogrID_TextChanged);
            // 
            // Emanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Emanet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet Sayfası";
            this.Load += new System.EventHandler(this.Emanet_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewogrenci)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnemanetver;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.TextBox txtogrNo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtogrID;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.Button anasayfaBtn;
        private System.Windows.Forms.Button kitapBtn;
        private System.Windows.Forms.Button emanetBtn;
        private System.Windows.Forms.Button ogrenciBtn;
        private System.Windows.Forms.Button kaplaButon;
        private System.Windows.Forms.Button simgeButon;
        private System.Windows.Forms.Button cikisButon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtkitapId;
        private System.Windows.Forms.DataGridView dataGridViewkitap;
        private System.Windows.Forms.DataGridView dataGridViewogrenci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemanetakts;
        private System.Windows.Forms.Button btnEmanet;
        private System.Windows.Forms.MaskedTextBox mskveris;
        private System.Windows.Forms.MaskedTextBox mskalis;
    }
}