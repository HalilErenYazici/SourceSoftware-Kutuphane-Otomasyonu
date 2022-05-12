
namespace Kutuphane_Otomasyon_Taslak_winform
{
    partial class tabOgrenciEkle
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
            this.cmbmyo = new System.Windows.Forms.ComboBox();
            this.cmbisletme = new System.Windows.Forms.ComboBox();
            this.cmbFakulte = new System.Windows.Forms.ComboBox();
            this.mskOgrenciPosta = new System.Windows.Forms.MaskedTextBox();
            this.mskOgrenciTelefon = new System.Windows.Forms.MaskedTextBox();
            this.radioKadin = new System.Windows.Forms.RadioButton();
            this.radioErkek = new System.Windows.Forms.RadioButton();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cikisButon = new System.Windows.Forms.Button();
            this.infoBtn = new System.Windows.Forms.Button();
            this.anasayfaBtn = new System.Windows.Forms.Button();
            this.kitapBtn = new System.Windows.Forms.Button();
            this.emanetBtn = new System.Windows.Forms.Button();
            this.ogrenciBtn = new System.Windows.Forms.Button();
            this.txtOgrenciAd = new System.Windows.Forms.TextBox();
            this.txtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.mskOgrNo = new System.Windows.Forms.MaskedTextBox();
            this.mskKartId = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.Koyu_Otomasyon_BackgroundK1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.mskKartId);
            this.panel1.Controls.Add(this.mskOgrNo);
            this.panel1.Controls.Add(this.cmbmyo);
            this.panel1.Controls.Add(this.cmbisletme);
            this.panel1.Controls.Add(this.cmbFakulte);
            this.panel1.Controls.Add(this.mskOgrenciPosta);
            this.panel1.Controls.Add(this.mskOgrenciTelefon);
            this.panel1.Controls.Add(this.radioKadin);
            this.panel1.Controls.Add(this.radioErkek);
            this.panel1.Controls.Add(this.lblCinsiyet);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtOgrenciAd);
            this.panel1.Controls.Add(this.txtOgrenciSoyad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.ForeColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 720);
            this.panel1.TabIndex = 3;
            // 
            // cmbmyo
            // 
            this.cmbmyo.FormattingEnabled = true;
            this.cmbmyo.Items.AddRange(new object[] {
            "Çocuk Bakımı ve Gençlik Hizmetleri Bölümü",
            "Dış Ticaret Bölümü",
            "Elektrik ve Enerji Bölümü",
            "İnşaat Bölümü",
            "Makine ve Metal Teknolojileri Bölümü",
            "Malzeme ve Malzeme İşleme Teknolojileri Bölümü",
            "Pazarlama ve Reklamcılık Bölümü",
            "Tasarım Bölümü",
            "Tekstil, Giyim, Ayakkabı ve Deri Bölümü",
            "Tıbbi Hizmetler ve Teknikler Bölümü",
            "Yönetim ve Organizasyon Bölümü",
            "Sağlık Bakım Hizmetleri Bölümü",
            "Terapi ve Rehabilitasyon Bölümü",
            "Sosyal Hizmet ve Danışmanlık Bölümü"});
            this.cmbmyo.Location = new System.Drawing.Point(365, 422);
            this.cmbmyo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbmyo.Name = "cmbmyo";
            this.cmbmyo.Size = new System.Drawing.Size(272, 28);
            this.cmbmyo.TabIndex = 28;
            this.cmbmyo.Visible = false;
            // 
            // cmbisletme
            // 
            this.cmbisletme.FormattingEnabled = true;
            this.cmbisletme.Items.AddRange(new object[] {
            "Yönetim Bilişim Sistemleri",
            "İşletme",
            "Uluslararası Ticaret ve İşletmecilik"});
            this.cmbisletme.Location = new System.Drawing.Point(365, 422);
            this.cmbisletme.Margin = new System.Windows.Forms.Padding(4);
            this.cmbisletme.Name = "cmbisletme";
            this.cmbisletme.Size = new System.Drawing.Size(272, 28);
            this.cmbisletme.TabIndex = 27;
            this.cmbisletme.Visible = false;
            // 
            // cmbFakulte
            // 
            this.cmbFakulte.FormattingEnabled = true;
            this.cmbFakulte.Items.AddRange(new object[] {
            "İnegöl İşletme Fakültesi",
            "İnegöl MYO"});
            this.cmbFakulte.Location = new System.Drawing.Point(365, 384);
            this.cmbFakulte.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFakulte.Name = "cmbFakulte";
            this.cmbFakulte.Size = new System.Drawing.Size(272, 28);
            this.cmbFakulte.TabIndex = 25;
            this.cmbFakulte.SelectedIndexChanged += new System.EventHandler(this.cmbFakulte_SelectedIndexChanged);
            // 
            // mskOgrenciPosta
            // 
            this.mskOgrenciPosta.Location = new System.Drawing.Point(855, 418);
            this.mskOgrenciPosta.Margin = new System.Windows.Forms.Padding(4);
            this.mskOgrenciPosta.Mask = "000000000@ogr,uludag,edu,tr";
            this.mskOgrenciPosta.Name = "mskOgrenciPosta";
            this.mskOgrenciPosta.Size = new System.Drawing.Size(272, 26);
            this.mskOgrenciPosta.TabIndex = 24;
            // 
            // mskOgrenciTelefon
            // 
            this.mskOgrenciTelefon.Location = new System.Drawing.Point(855, 385);
            this.mskOgrenciTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.mskOgrenciTelefon.Mask = "(999) 000-0000";
            this.mskOgrenciTelefon.Name = "mskOgrenciTelefon";
            this.mskOgrenciTelefon.Size = new System.Drawing.Size(272, 26);
            this.mskOgrenciTelefon.TabIndex = 23;
            // 
            // radioKadin
            // 
            this.radioKadin.AutoSize = true;
            this.radioKadin.Location = new System.Drawing.Point(573, 326);
            this.radioKadin.Margin = new System.Windows.Forms.Padding(4);
            this.radioKadin.Name = "radioKadin";
            this.radioKadin.Size = new System.Drawing.Size(72, 24);
            this.radioKadin.TabIndex = 22;
            this.radioKadin.TabStop = true;
            this.radioKadin.Text = "Kadın";
            this.radioKadin.UseVisualStyleBackColor = true;
            this.radioKadin.CheckedChanged += new System.EventHandler(this.radioKadin_CheckedChanged);
            // 
            // radioErkek
            // 
            this.radioErkek.AutoSize = true;
            this.radioErkek.Location = new System.Drawing.Point(573, 300);
            this.radioErkek.Margin = new System.Windows.Forms.Padding(4);
            this.radioErkek.Name = "radioErkek";
            this.radioErkek.Size = new System.Drawing.Size(72, 24);
            this.radioErkek.TabIndex = 21;
            this.radioErkek.TabStop = true;
            this.radioErkek.Text = "Erkek";
            this.radioErkek.UseVisualStyleBackColor = true;
            this.radioErkek.CheckedChanged += new System.EventHandler(this.radioErkek_CheckedChanged);
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(485, 314);
            this.lblCinsiyet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(79, 20);
            this.lblCinsiyet.TabIndex = 20;
            this.lblCinsiyet.Text = "Cinsiyet :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(699, 422);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Öğrenci E-Posta :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(701, 389);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Öğrenci Telefon :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(428, 267);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Öğrenci Soyad :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(459, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Öğrenci Ad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(221, 422);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Öğrenci Bölüm :";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(457, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Öğrenci No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(213, 389);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Öğrenci Fakülte :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(496, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kart ID :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(561, 528);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "Öğrenci Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.cikisButon);
            this.panel2.Controls.Add(this.infoBtn);
            this.panel2.Controls.Add(this.anasayfaBtn);
            this.panel2.Controls.Add(this.kitapBtn);
            this.panel2.Controls.Add(this.emanetBtn);
            this.panel2.Controls.Add(this.ogrenciBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 50);
            this.panel2.TabIndex = 0;
            // 
            // cikisButon
            // 
            this.cikisButon.BackColor = System.Drawing.Color.Transparent;
            this.cikisButon.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.close;
            this.cikisButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cikisButon.Cursor = System.Windows.Forms.Cursors.Default;
            this.cikisButon.FlatAppearance.BorderSize = 0;
            this.cikisButon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.cikisButon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.cikisButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisButon.ForeColor = System.Drawing.Color.Transparent;
            this.cikisButon.Location = new System.Drawing.Point(1253, 2);
            this.cikisButon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cikisButon.Name = "cikisButon";
            this.cikisButon.Size = new System.Drawing.Size(24, 25);
            this.cikisButon.TabIndex = 10;
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
            this.infoBtn.Location = new System.Drawing.Point(260, 4);
            this.infoBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(43, 42);
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
            this.anasayfaBtn.Location = new System.Drawing.Point(12, 4);
            this.anasayfaBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.anasayfaBtn.Name = "anasayfaBtn";
            this.anasayfaBtn.Size = new System.Drawing.Size(43, 42);
            this.anasayfaBtn.TabIndex = 2;
            this.anasayfaBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.anasayfaBtn.UseVisualStyleBackColor = false;
            this.anasayfaBtn.Click += new System.EventHandler(this.anasayfaBtn_Click);
            // 
            // kitapBtn
            // 
            this.kitapBtn.BackColor = System.Drawing.Color.Transparent;
            this.kitapBtn.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.book;
            this.kitapBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kitapBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitapBtn.FlatAppearance.BorderSize = 0;
            this.kitapBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.kitapBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.kitapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitapBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kitapBtn.Location = new System.Drawing.Point(197, 4);
            this.kitapBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kitapBtn.Name = "kitapBtn";
            this.kitapBtn.Size = new System.Drawing.Size(43, 42);
            this.kitapBtn.TabIndex = 8;
            this.kitapBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kitapBtn.UseVisualStyleBackColor = false;
            this.kitapBtn.Click += new System.EventHandler(this.kitapBtn_Click);
            // 
            // emanetBtn
            // 
            this.emanetBtn.BackColor = System.Drawing.Color.Transparent;
            this.emanetBtn.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.exchange;
            this.emanetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.emanetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emanetBtn.FlatAppearance.BorderSize = 0;
            this.emanetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.emanetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.emanetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emanetBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.emanetBtn.Location = new System.Drawing.Point(75, 4);
            this.emanetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emanetBtn.Name = "emanetBtn";
            this.emanetBtn.Size = new System.Drawing.Size(43, 42);
            this.emanetBtn.TabIndex = 6;
            this.emanetBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.emanetBtn.UseVisualStyleBackColor = false;
            this.emanetBtn.Click += new System.EventHandler(this.emanetBtn_Click);
            // 
            // ogrenciBtn
            // 
            this.ogrenciBtn.BackColor = System.Drawing.Color.DarkGray;
            this.ogrenciBtn.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.male_student;
            this.ogrenciBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ogrenciBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ogrenciBtn.FlatAppearance.BorderSize = 0;
            this.ogrenciBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ogrenciBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ogrenciBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ogrenciBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ogrenciBtn.Location = new System.Drawing.Point(136, 4);
            this.ogrenciBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ogrenciBtn.Name = "ogrenciBtn";
            this.ogrenciBtn.Size = new System.Drawing.Size(43, 42);
            this.ogrenciBtn.TabIndex = 7;
            this.ogrenciBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ogrenciBtn.UseVisualStyleBackColor = false;
            this.ogrenciBtn.Click += new System.EventHandler(this.ogrenciBtn_Click);
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciAd.Location = new System.Drawing.Point(573, 230);
            this.txtOgrenciAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new System.Drawing.Size(272, 26);
            this.txtOgrenciAd.TabIndex = 6;
            // 
            // txtOgrenciSoyad
            // 
            this.txtOgrenciSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciSoyad.Location = new System.Drawing.Point(573, 263);
            this.txtOgrenciSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            this.txtOgrenciSoyad.Size = new System.Drawing.Size(272, 26);
            this.txtOgrenciSoyad.TabIndex = 7;
            // 
            // mskOgrNo
            // 
            this.mskOgrNo.Location = new System.Drawing.Point(573, 198);
            this.mskOgrNo.Mask = "000000000";
            this.mskOgrNo.Name = "mskOgrNo";
            this.mskOgrNo.Size = new System.Drawing.Size(272, 26);
            this.mskOgrNo.TabIndex = 29;
            // 
            // mskKartId
            // 
            this.mskKartId.Location = new System.Drawing.Point(573, 167);
            this.mskKartId.Mask = "00000000000";
            this.mskKartId.Name = "mskKartId";
            this.mskKartId.Size = new System.Drawing.Size(272, 26);
            this.mskKartId.TabIndex = 30;
            // 
            // tabOgrenciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "tabOgrenciEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tabOgrenciEkle";
            this.Load += new System.EventHandler(this.tabOgrenciEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtOgrenciSoyad;
        private System.Windows.Forms.TextBox txtOgrenciAd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cikisButon;
        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.Button anasayfaBtn;
        private System.Windows.Forms.Button kitapBtn;
        private System.Windows.Forms.Button emanetBtn;
        private System.Windows.Forms.Button ogrenciBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioKadin;
        private System.Windows.Forms.RadioButton radioErkek;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.ComboBox cmbisletme;
        private System.Windows.Forms.ComboBox cmbFakulte;
        private System.Windows.Forms.MaskedTextBox mskOgrenciPosta;
        private System.Windows.Forms.MaskedTextBox mskOgrenciTelefon;
        private System.Windows.Forms.ComboBox cmbmyo;
        private System.Windows.Forms.MaskedTextBox mskOgrNo;
        private System.Windows.Forms.MaskedTextBox mskKartId;
    }
}