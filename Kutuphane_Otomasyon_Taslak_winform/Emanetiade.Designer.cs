
namespace Kutuphane_Otomasyon_Taslak_winform
{
    partial class Emanetiade
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
            this.btnemanetkaldir = new System.Windows.Forms.Button();
            this.searchboxkitap = new System.Windows.Forms.TextBox();
            this.cmbaramatip = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dataGridViewemanet = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kaplaButon = new System.Windows.Forms.Button();
            this.simgeButon = new System.Windows.Forms.Button();
            this.cikisButon = new System.Windows.Forms.Button();
            this.infoBtn = new System.Windows.Forms.Button();
            this.anasayfaBtn = new System.Windows.Forms.Button();
            this.kitapBtn = new System.Windows.Forms.Button();
            this.emanetBtn = new System.Windows.Forms.Button();
            this.ogrenciBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewemanet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.Koyu_Otomasyon_BackgroundK1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnemanetkaldir);
            this.panel1.Controls.Add(this.searchboxkitap);
            this.panel1.Controls.Add(this.cmbaramatip);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.dataGridViewemanet);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 608);
            this.panel1.TabIndex = 2;
            // 
            // btnemanetkaldir
            // 
            this.btnemanetkaldir.BackColor = System.Drawing.Color.LimeGreen;
            this.btnemanetkaldir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnemanetkaldir.ForeColor = System.Drawing.Color.White;
            this.btnemanetkaldir.Location = new System.Drawing.Point(709, 506);
            this.btnemanetkaldir.Margin = new System.Windows.Forms.Padding(2);
            this.btnemanetkaldir.Name = "btnemanetkaldir";
            this.btnemanetkaldir.Size = new System.Drawing.Size(106, 48);
            this.btnemanetkaldir.TabIndex = 16;
            this.btnemanetkaldir.Text = "Emanet Kaldır";
            this.btnemanetkaldir.UseVisualStyleBackColor = false;
            this.btnemanetkaldir.Click += new System.EventHandler(this.btnemanetkaldir_Click);
            // 
            // searchboxkitap
            // 
            this.searchboxkitap.Location = new System.Drawing.Point(621, 56);
            this.searchboxkitap.Margin = new System.Windows.Forms.Padding(2);
            this.searchboxkitap.Name = "searchboxkitap";
            this.searchboxkitap.Size = new System.Drawing.Size(166, 20);
            this.searchboxkitap.TabIndex = 15;
            this.searchboxkitap.Text = "Kitap Ara...";
            this.searchboxkitap.TextChanged += new System.EventHandler(this.searchboxkitap_TextChanged);
            // 
            // cmbaramatip
            // 
            this.cmbaramatip.FormattingEnabled = true;
            this.cmbaramatip.Items.AddRange(new object[] {
            "Ogrenci Id",
            "Ogrenci Id",
            "Ogrenci No",
            "Ogrenci Ad",
            "Ogrenci Soyad",
            "Ogrenci Eposta",
            "Ogrenci Telefon",
            "Kitap Id",
            "Barkod",
            "ISBN",
            "Kitap Ad",
            "Yazar Ad",
            "Yazar Soyad",
            "Yayınevi Ad",
            "Veriş Tarihi",
            "Alış Tarihi",
            "Emanet Alinan Kitap Sayisi"});
            this.cmbaramatip.Location = new System.Drawing.Point(14, 55);
            this.cmbaramatip.Name = "cmbaramatip";
            this.cmbaramatip.Size = new System.Drawing.Size(128, 21);
            this.cmbaramatip.TabIndex = 14;
            this.cmbaramatip.Text = "Arama Filtresi Seçiniz...";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(173, 55);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(166, 20);
            this.searchBox.TabIndex = 13;
            this.searchBox.Text = "Öğrenci Ara...";
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // dataGridViewemanet
            // 
            this.dataGridViewemanet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewemanet.Location = new System.Drawing.Point(9, 94);
            this.dataGridViewemanet.Name = "dataGridViewemanet";
            this.dataGridViewemanet.RowHeadersWidth = 51;
            this.dataGridViewemanet.Size = new System.Drawing.Size(941, 275);
            this.dataGridViewemanet.TabIndex = 12;
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
            this.panel2.Size = new System.Drawing.Size(947, 41);
            this.panel2.TabIndex = 10;
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
            this.kaplaButon.Location = new System.Drawing.Point(901, 3);
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
            this.simgeButon.Location = new System.Drawing.Point(879, 3);
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
            this.cikisButon.Location = new System.Drawing.Point(924, 3);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(830, 506);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "İptal";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Emanetiade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 608);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Emanetiade";
            this.Text = "Emanetiade";
            this.Load += new System.EventHandler(this.Emanetiade_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewemanet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbaramatip;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView dataGridViewemanet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button kaplaButon;
        private System.Windows.Forms.Button simgeButon;
        private System.Windows.Forms.Button cikisButon;
        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.Button anasayfaBtn;
        private System.Windows.Forms.Button kitapBtn;
        private System.Windows.Forms.Button emanetBtn;
        private System.Windows.Forms.Button ogrenciBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchboxkitap;
        private System.Windows.Forms.Button btnemanetkaldir;
    }
}