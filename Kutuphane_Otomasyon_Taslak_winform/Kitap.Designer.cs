
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cikisButon = new System.Windows.Forms.Button();
            this.infoBtn = new System.Windows.Forms.Button();
            this.anasayfaBtn = new System.Windows.Forms.Button();
            this.kitapBtn = new System.Windows.Forms.Button();
            this.emanetBtn = new System.Windows.Forms.Button();
            this.ogrenciBtn = new System.Windows.Forms.Button();
            this.kitaplarıListele = new System.Windows.Forms.ListBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.Koyu_Otomasyon_BackgroundK1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.kitaplarıListele);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 720);
            this.panel1.TabIndex = 2;
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
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 50);
            this.panel2.TabIndex = 8;
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
            this.cikisButon.Location = new System.Drawing.Point(1253, 3);
            this.cikisButon.Name = "cikisButon";
            this.cikisButon.Size = new System.Drawing.Size(24, 24);
            this.cikisButon.TabIndex = 10;
            this.cikisButon.UseVisualStyleBackColor = true;
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
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(42, 42);
            this.infoBtn.TabIndex = 9;
            this.infoBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.infoBtn.UseVisualStyleBackColor = false;
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
            this.anasayfaBtn.Name = "anasayfaBtn";
            this.anasayfaBtn.Size = new System.Drawing.Size(42, 42);
            this.anasayfaBtn.TabIndex = 2;
            this.anasayfaBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.anasayfaBtn.UseVisualStyleBackColor = false;
            // 
            // kitapBtn
            // 
            this.kitapBtn.BackColor = System.Drawing.Color.DarkGray;
            this.kitapBtn.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.book;
            this.kitapBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kitapBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitapBtn.FlatAppearance.BorderSize = 0;
            this.kitapBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.kitapBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.kitapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitapBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kitapBtn.Location = new System.Drawing.Point(198, 4);
            this.kitapBtn.Name = "kitapBtn";
            this.kitapBtn.Size = new System.Drawing.Size(42, 42);
            this.kitapBtn.TabIndex = 8;
            this.kitapBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kitapBtn.UseVisualStyleBackColor = false;
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
            this.emanetBtn.Location = new System.Drawing.Point(74, 4);
            this.emanetBtn.Name = "emanetBtn";
            this.emanetBtn.Size = new System.Drawing.Size(42, 42);
            this.emanetBtn.TabIndex = 6;
            this.emanetBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.emanetBtn.UseVisualStyleBackColor = false;
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
            this.ogrenciBtn.Location = new System.Drawing.Point(136, 4);
            this.ogrenciBtn.Name = "ogrenciBtn";
            this.ogrenciBtn.Size = new System.Drawing.Size(42, 42);
            this.ogrenciBtn.TabIndex = 7;
            this.ogrenciBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ogrenciBtn.UseVisualStyleBackColor = false;
            // 
            // kitaplarıListele
            // 
            this.kitaplarıListele.FormattingEnabled = true;
            this.kitaplarıListele.ItemHeight = 16;
            this.kitaplarıListele.Location = new System.Drawing.Point(12, 120);
            this.kitaplarıListele.Name = "kitaplarıListele";
            this.kitaplarıListele.Size = new System.Drawing.Size(1256, 580);
            this.kitaplarıListele.TabIndex = 1;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(12, 75);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(228, 22);
            this.searchBox.TabIndex = 11;
            this.searchBox.Text = "Kitap Ara";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(1178, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Kitap Ekle";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1071, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 45);
            this.button2.TabIndex = 13;
            this.button2.Text = "Kitap Düzenle";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Kitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kitap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Sayfası";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox kitaplarıListele;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cikisButon;
        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.Button anasayfaBtn;
        private System.Windows.Forms.Button kitapBtn;
        private System.Windows.Forms.Button emanetBtn;
        private System.Windows.Forms.Button ogrenciBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}