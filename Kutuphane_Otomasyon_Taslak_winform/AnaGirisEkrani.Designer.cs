
namespace Kutuphane_Otomasyon_Taslak_winform
{
    partial class AnaGirisEkrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaGirisEkrani));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.usrPic = new System.Windows.Forms.PictureBox();
            this.cmbGorev = new System.Windows.Forms.ComboBox();
            this.cikisButon = new System.Windows.Forms.Button();
            this.girisButon = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userImg = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.bckgRv;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.usrPic);
            this.panel1.Controls.Add(this.cmbGorev);
            this.panel1.Controls.Add(this.cikisButon);
            this.panel1.Controls.Add(this.girisButon);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.userImg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPass.Location = new System.Drawing.Point(300, 271);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(200, 30);
            this.txtPass.TabIndex = 3;
            this.txtPass.Text = "abc";
            this.txtPass.WordWrap = false;
            this.txtPass.Enter += new System.EventHandler(this.textBox2_Enter);
            this.txtPass.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox2.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources._lock;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(270, 271);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // usrPic
            // 
            this.usrPic.BackColor = System.Drawing.Color.Gainsboro;
            this.usrPic.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.userLine;
            this.usrPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usrPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usrPic.Location = new System.Drawing.Point(270, 235);
            this.usrPic.Name = "usrPic";
            this.usrPic.Size = new System.Drawing.Size(30, 30);
            this.usrPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usrPic.TabIndex = 14;
            this.usrPic.TabStop = false;
            // 
            // cmbGorev
            // 
            this.cmbGorev.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbGorev.FormattingEnabled = true;
            this.cmbGorev.Items.AddRange(new object[] {
            "KutuphaneGorevlisi",
            "OgrenciIsleriGorevlisi",
            "GelistiriciEkibi"});
            this.cmbGorev.Location = new System.Drawing.Point(300, 307);
            this.cmbGorev.Name = "cmbGorev";
            this.cmbGorev.Size = new System.Drawing.Size(200, 33);
            this.cmbGorev.TabIndex = 4;
            this.cmbGorev.Text = "Görev Tipi Seçiniz...";
            // 
            // cikisButon
            // 
            this.cikisButon.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.remove;
            this.cikisButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cikisButon.Cursor = System.Windows.Forms.Cursors.Default;
            this.cikisButon.FlatAppearance.BorderSize = 0;
            this.cikisButon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cikisButon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cikisButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisButon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cikisButon.Location = new System.Drawing.Point(773, 2);
            this.cikisButon.Name = "cikisButon";
            this.cikisButon.Size = new System.Drawing.Size(24, 24);
            this.cikisButon.TabIndex = 5;
            this.cikisButon.UseVisualStyleBackColor = true;
            this.cikisButon.Click += new System.EventHandler(this.button2_Click);
            // 
            // girisButon
            // 
            this.girisButon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.girisButon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.girisButon.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisButon.Location = new System.Drawing.Point(300, 356);
            this.girisButon.Name = "girisButon";
            this.girisButon.Size = new System.Drawing.Size(200, 40);
            this.girisButon.TabIndex = 1;
            this.girisButon.Text = "Giriş";
            this.girisButon.UseVisualStyleBackColor = false;
            this.girisButon.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUser.Location = new System.Drawing.Point(300, 235);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(200, 30);
            this.txtUser.TabIndex = 2;
            this.txtUser.Text = "abc";
            this.txtUser.WordWrap = false;
            this.txtUser.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtUser.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(311, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Girişi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userImg
            // 
            this.userImg.BackColor = System.Drawing.Color.Transparent;
            this.userImg.Image = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.uu_logo;
            this.userImg.Location = new System.Drawing.Point(350, 90);
            this.userImg.Name = "userImg";
            this.userImg.Size = new System.Drawing.Size(100, 100);
            this.userImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImg.TabIndex = 0;
            this.userImg.TabStop = false;
            // 
            // AnaGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaGirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.GirisEkrani_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox userImg;
        private System.Windows.Forms.Button girisButon;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cikisButon;
        private System.Windows.Forms.ComboBox cmbGorev;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox usrPic;
    }
}

