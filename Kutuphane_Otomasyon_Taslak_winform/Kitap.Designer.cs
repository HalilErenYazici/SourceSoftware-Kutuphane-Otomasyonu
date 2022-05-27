
namespace Kutuphane_Otomasyon_Taslak_winform
{
    partial class Kitap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbaramakitap = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kaplaButon = new System.Windows.Forms.Button();
            this.simgeButon = new System.Windows.Forms.Button();
            this.cikisButon = new System.Windows.Forms.Button();
            this.infoBtn = new System.Windows.Forms.Button();
            this.anasayfaBtn = new System.Windows.Forms.Button();
            this.kitapBtn = new System.Windows.Forms.Button();
            this.emanetBtn = new System.Windows.Forms.Button();
            this.ogrenciBtn = new System.Windows.Forms.Button();
            this.kitaplarıListele = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.Koyu_Otomasyon_BackgroundK1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.cmbaramakitap);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.kitaplarıListele);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 720);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmbaramakitap
            // 
            this.cmbaramakitap.FormattingEnabled = true;
            this.cmbaramakitap.Items.AddRange(new object[] {
            "kitapId",
            "barkod",
            "ISBN",
            "demirbasNo",
            "KitapAd",
            "cilt",
            "konu",
            "ozet",
            "sayfa",
            "anhtrK",
            "dil",
            "ynSenesi",
            "kkTarih",
            "basimNo",
            "cikisYili",
            "dolapNo",
            "rafNo",
            "KtgrAd",
            "turAd",
            "yzrAd",
            "yzrSoyad",
            "yynevAd",
            "yynevTel",
            "cvrAd",
            "cvrSoyad"});
            this.cmbaramakitap.Location = new System.Drawing.Point(19, 74);
            this.cmbaramakitap.Margin = new System.Windows.Forms.Padding(4);
            this.cmbaramakitap.Name = "cmbaramakitap";
            this.cmbaramakitap.Size = new System.Drawing.Size(177, 24);
            this.cmbaramakitap.TabIndex = 69;
            this.cmbaramakitap.Text = "Arama Filtresi Seçiniz...";
            this.cmbaramakitap.SelectedIndexChanged += new System.EventHandler(this.cmbaramakitap_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 129);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1256, 580);
            this.dataGridView1.TabIndex = 66;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1177, 64);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 46);
            this.button2.TabIndex = 13;
            this.button2.Text = "Kitap Düzenle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(1080, 64);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "Kitap Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(227, 74);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(228, 22);
            this.searchBox.TabIndex = 11;
            this.searchBox.Text = "Kitap Ara";
            this.searchBox.Click += new System.EventHandler(this.searchBox_Click);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged_1);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 42);
            this.panel2.TabIndex = 8;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
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
            this.kaplaButon.Location = new System.Drawing.Point(1227, 2);
            this.kaplaButon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kaplaButon.Name = "kaplaButon";
            this.kaplaButon.Size = new System.Drawing.Size(20, 20);
            this.kaplaButon.TabIndex = 16;
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
            this.simgeButon.Location = new System.Drawing.Point(1197, 2);
            this.simgeButon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simgeButon.Name = "simgeButon";
            this.simgeButon.Size = new System.Drawing.Size(20, 20);
            this.simgeButon.TabIndex = 15;
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
            this.cikisButon.Location = new System.Drawing.Point(1257, 2);
            this.cikisButon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cikisButon.Name = "cikisButon";
            this.cikisButon.Size = new System.Drawing.Size(20, 20);
            this.cikisButon.TabIndex = 14;
            this.cikisButon.UseVisualStyleBackColor = true;
            this.cikisButon.Click += new System.EventHandler(this.cikisButon_Click);
            // 
            // infoBtn
            // 
            this.infoBtn.BackColor = System.Drawing.Color.Transparent;
            this.infoBtn.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.settings;
            this.infoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoBtn.FlatAppearance.BorderSize = 0;
            this.infoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.infoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.infoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.infoBtn.Location = new System.Drawing.Point(260, 0);
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
            this.kitapBtn.BackColor = System.Drawing.Color.DarkGray;
            this.kitapBtn.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.bookSyh;
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
            this.emanetBtn.BackColor = System.Drawing.Color.Transparent;
            this.emanetBtn.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.exchange;
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
            this.ogrenciBtn.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.male_student;
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
            // kitaplarıListele
            // 
            this.kitaplarıListele.FormattingEnabled = true;
            this.kitaplarıListele.ItemHeight = 16;
            this.kitaplarıListele.Location = new System.Drawing.Point(12, 129);
            this.kitaplarıListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kitaplarıListele.Name = "kitaplarıListele";
            this.kitaplarıListele.Size = new System.Drawing.Size(1256, 580);
            this.kitaplarıListele.TabIndex = 1;
            // 
            // Kitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Kitap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Sayfası";
            this.Load += new System.EventHandler(this.Kitap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox kitaplarıListele;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.Button anasayfaBtn;
        private System.Windows.Forms.Button kitapBtn;
        private System.Windows.Forms.Button emanetBtn;
        private System.Windows.Forms.Button ogrenciBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button kaplaButon;
        private System.Windows.Forms.Button simgeButon;
        private System.Windows.Forms.Button cikisButon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbaramakitap;
    }
}