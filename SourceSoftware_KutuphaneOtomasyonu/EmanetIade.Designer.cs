
namespace SourceSoftware_KutuphaneOtomasyonu
{
    partial class EmanetIade
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmanetIade));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.istBtn = new System.Windows.Forms.Button();
            this.anasayfaBtn = new System.Windows.Forms.Button();
            this.kitapBtn = new System.Windows.Forms.Button();
            this.emanetBtn = new System.Windows.Forms.Button();
            this.ogrenciBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tire = new System.Windows.Forms.Label();
            this.saat = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.Label();
            this.pncrTxt = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.txtemanetId = new System.Windows.Forms.TextBox();
            this.btnemanetal = new System.Windows.Forms.Button();
            this.cmbaramatip = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dataGridViewemanet = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewemanet)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SourceSoftware_KutuphaneOtomasyonu.Properties.Resources.Koyu_Otomasyon_BackgroundK1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtemanetId);
            this.panel1.Controls.Add(this.btnemanetal);
            this.panel1.Controls.Add(this.cmbaramatip);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.dataGridViewemanet);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 720);
            this.panel1.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.SystemColors.Control;
            this.label20.Location = new System.Drawing.Point(260, 75);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 19);
            this.label20.TabIndex = 229;
            this.label20.Text = "Ara: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.istBtn);
            this.panel2.Controls.Add(this.anasayfaBtn);
            this.panel2.Controls.Add(this.kitapBtn);
            this.panel2.Controls.Add(this.emanetBtn);
            this.panel2.Controls.Add(this.ogrenciBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1278, 42);
            this.panel2.TabIndex = 10;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // istBtn
            // 
            this.istBtn.BackColor = System.Drawing.Color.Transparent;
            this.istBtn.BackgroundImage = global::SourceSoftware_KutuphaneOtomasyonu.Properties.Resources.bar_chart2Rgb;
            this.istBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.istBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.istBtn.FlatAppearance.BorderSize = 0;
            this.istBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.istBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.istBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.istBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.istBtn.Location = new System.Drawing.Point(260, 0);
            this.istBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.istBtn.Name = "istBtn";
            this.istBtn.Size = new System.Drawing.Size(43, 42);
            this.istBtn.TabIndex = 9;
            this.istBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.istBtn.UseVisualStyleBackColor = false;
            this.istBtn.Click += new System.EventHandler(this.istBtn_Click);
            // 
            // anasayfaBtn
            // 
            this.anasayfaBtn.BackColor = System.Drawing.Color.Transparent;
            this.anasayfaBtn.BackgroundImage = global::SourceSoftware_KutuphaneOtomasyonu.Properties.Resources.home1;
            this.anasayfaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.anasayfaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anasayfaBtn.FlatAppearance.BorderSize = 0;
            this.anasayfaBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.anasayfaBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.anasayfaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anasayfaBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.anasayfaBtn.Location = new System.Drawing.Point(12, 0);
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
            this.kitapBtn.BackgroundImage = global::SourceSoftware_KutuphaneOtomasyonu.Properties.Resources.bookSyh;
            this.kitapBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kitapBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitapBtn.FlatAppearance.BorderSize = 0;
            this.kitapBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.kitapBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.kitapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitapBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kitapBtn.Location = new System.Drawing.Point(197, 0);
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
            this.emanetBtn.BackColor = System.Drawing.Color.DarkGray;
            this.emanetBtn.BackgroundImage = global::SourceSoftware_KutuphaneOtomasyonu.Properties.Resources.exchange;
            this.emanetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.emanetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emanetBtn.FlatAppearance.BorderSize = 0;
            this.emanetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.emanetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.emanetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emanetBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.emanetBtn.Location = new System.Drawing.Point(75, 0);
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
            this.ogrenciBtn.BackColor = System.Drawing.Color.Transparent;
            this.ogrenciBtn.BackgroundImage = global::SourceSoftware_KutuphaneOtomasyonu.Properties.Resources.male_student;
            this.ogrenciBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ogrenciBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ogrenciBtn.FlatAppearance.BorderSize = 0;
            this.ogrenciBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ogrenciBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ogrenciBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ogrenciBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ogrenciBtn.Location = new System.Drawing.Point(136, 0);
            this.ogrenciBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ogrenciBtn.Name = "ogrenciBtn";
            this.ogrenciBtn.Size = new System.Drawing.Size(43, 42);
            this.ogrenciBtn.TabIndex = 7;
            this.ogrenciBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ogrenciBtn.UseVisualStyleBackColor = false;
            this.ogrenciBtn.Click += new System.EventHandler(this.ogrenciBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tire);
            this.panel3.Controls.Add(this.saat);
            this.panel3.Controls.Add(this.tarih);
            this.panel3.Controls.Add(this.pncrTxt);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.button11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1278, 25);
            this.panel3.TabIndex = 228;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // tire
            // 
            this.tire.AutoSize = true;
            this.tire.BackColor = System.Drawing.Color.Transparent;
            this.tire.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tire.ForeColor = System.Drawing.Color.Gainsboro;
            this.tire.Location = new System.Drawing.Point(215, -1);
            this.tire.Name = "tire";
            this.tire.Size = new System.Drawing.Size(17, 23);
            this.tire.TabIndex = 26;
            this.tire.Text = "-";
            this.tire.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saat
            // 
            this.saat.AutoSize = true;
            this.saat.BackColor = System.Drawing.Color.Transparent;
            this.saat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saat.ForeColor = System.Drawing.Color.Gainsboro;
            this.saat.Location = new System.Drawing.Point(238, -1);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(43, 23);
            this.saat.TabIndex = 25;
            this.saat.Text = "Saat";
            this.saat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tarih
            // 
            this.tarih.AutoSize = true;
            this.tarih.BackColor = System.Drawing.Color.Transparent;
            this.tarih.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarih.ForeColor = System.Drawing.Color.Gainsboro;
            this.tarih.Location = new System.Drawing.Point(2, -1);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(46, 23);
            this.tarih.TabIndex = 24;
            this.tarih.Text = "Tarih";
            this.tarih.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pncrTxt
            // 
            this.pncrTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pncrTxt.AutoSize = true;
            this.pncrTxt.BackColor = System.Drawing.Color.Transparent;
            this.pncrTxt.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pncrTxt.ForeColor = System.Drawing.SystemColors.Control;
            this.pncrTxt.Location = new System.Drawing.Point(580, 1);
            this.pncrTxt.Name = "pncrTxt";
            this.pncrTxt.Size = new System.Drawing.Size(108, 21);
            this.pncrTxt.TabIndex = 23;
            this.pncrTxt.Text = "EMANET İADE";
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImage = global::SourceSoftware_KutuphaneOtomasyonu.Properties.Resources.maximizeSyhKntr30;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Cursor = System.Windows.Forms.Cursors.Default;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.Transparent;
            this.button8.Location = new System.Drawing.Point(1224, 1);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(20, 20);
            this.button8.TabIndex = 21;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.kaplaButon_Click);
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.BackgroundImage = global::SourceSoftware_KutuphaneOtomasyonu.Properties.Resources.minus;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.Cursor = System.Windows.Forms.Cursors.Default;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.Color.Transparent;
            this.button10.Location = new System.Drawing.Point(1194, 1);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(20, 20);
            this.button10.TabIndex = 20;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.simgeButon_Click);
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.BackgroundImage = global::SourceSoftware_KutuphaneOtomasyonu.Properties.Resources.remove;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.Cursor = System.Windows.Forms.Cursors.Default;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.Color.Transparent;
            this.button11.Location = new System.Drawing.Point(1254, 1);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(20, 20);
            this.button11.TabIndex = 19;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.cikisButon_Click);
            // 
            // txtemanetId
            // 
            this.txtemanetId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtemanetId.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtemanetId.Location = new System.Drawing.Point(1134, 79);
            this.txtemanetId.Margin = new System.Windows.Forms.Padding(4);
            this.txtemanetId.Name = "txtemanetId";
            this.txtemanetId.Size = new System.Drawing.Size(132, 19);
            this.txtemanetId.TabIndex = 18;
            this.txtemanetId.Visible = false;
            // 
            // btnemanetal
            // 
            this.btnemanetal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnemanetal.BackColor = System.Drawing.Color.Green;
            this.btnemanetal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnemanetal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnemanetal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnemanetal.ForeColor = System.Drawing.SystemColors.Control;
            this.btnemanetal.Location = new System.Drawing.Point(1137, 663);
            this.btnemanetal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnemanetal.Name = "btnemanetal";
            this.btnemanetal.Size = new System.Drawing.Size(130, 45);
            this.btnemanetal.TabIndex = 17;
            this.btnemanetal.Text = "İade Al";
            this.btnemanetal.UseVisualStyleBackColor = false;
            this.btnemanetal.Click += new System.EventHandler(this.btnemanetal_Click);
            // 
            // cmbaramatip
            // 
            this.cmbaramatip.FormattingEnabled = true;
            this.cmbaramatip.Items.AddRange(new object[] {
            "Ogrenci Id",
            "Ogrenci No",
            "Ogrenci Ad",
            "Ogrenci Soyad",
            "Ogrenci Eposta",
            "Ogrenci Telefon",
            "Kitap Id",
            "Demirbaş No",
            "Kitap Ad",
            "Yazar Ad",
            "Yazar Soyad",
            "Yayınevi Ad",
            "Veriş Tarihi",
            "Alış Tarihi",
            "Emanet Alinan Kitap Sayisi"});
            this.cmbaramatip.Location = new System.Drawing.Point(12, 73);
            this.cmbaramatip.Margin = new System.Windows.Forms.Padding(4);
            this.cmbaramatip.Name = "cmbaramatip";
            this.cmbaramatip.Size = new System.Drawing.Size(200, 25);
            this.cmbaramatip.TabIndex = 14;
            this.cmbaramatip.Text = "Arama Filtresi Seçiniz...";
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Location = new System.Drawing.Point(303, 73);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(220, 25);
            this.searchBox.TabIndex = 13;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // dataGridViewemanet
            // 
            this.dataGridViewemanet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewemanet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewemanet.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewemanet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewemanet.Location = new System.Drawing.Point(12, 106);
            this.dataGridViewemanet.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewemanet.Name = "dataGridViewemanet";
            this.dataGridViewemanet.RowHeadersWidth = 51;
            this.dataGridViewemanet.Size = new System.Drawing.Size(1255, 338);
            this.dataGridViewemanet.TabIndex = 12;
            this.dataGridViewemanet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewemanet_CellClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(11, 663);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "İptal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmanetIade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmanetIade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet İade Sayfası";
            this.Load += new System.EventHandler(this.Emanetiade_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewemanet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbaramatip;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView dataGridViewemanet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button istBtn;
        private System.Windows.Forms.Button anasayfaBtn;
        private System.Windows.Forms.Button kitapBtn;
        private System.Windows.Forms.Button emanetBtn;
        private System.Windows.Forms.Button ogrenciBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnemanetal;
        private System.Windows.Forms.TextBox txtemanetId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label tire;
        private System.Windows.Forms.Label saat;
        private System.Windows.Forms.Label tarih;
        private System.Windows.Forms.Label pncrTxt;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label20;
    }
}