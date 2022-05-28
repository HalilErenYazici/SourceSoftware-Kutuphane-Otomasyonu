
namespace Kutuphane_Otomasyon_Taslak_winform
{
    partial class OgrenciIsleri
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.kaplaButon = new System.Windows.Forms.Button();
            this.simgeButon = new System.Windows.Forms.Button();
            this.cikisButon = new System.Windows.Forms.Button();
            this.ayrBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.Koyu_Otomasyon_BackgroundK1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 720);
            this.panel1.TabIndex = 4;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(270, 100);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(179, 22);
            this.searchBox.TabIndex = 5;
            this.searchBox.Text = "Öğrenci Ara...";
            this.searchBox.Click += new System.EventHandler(this.searchBox_Click);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Öğrenci No",
            "Öğrenci Ad",
            "Öğrenci Soyad"});
            this.comboBox1.Location = new System.Drawing.Point(12, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Arama Fİltresi Seçiniz...";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1256, 262);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.logOutBtn);
            this.panel2.Controls.Add(this.kaplaButon);
            this.panel2.Controls.Add(this.simgeButon);
            this.panel2.Controls.Add(this.cikisButon);
            this.panel2.Controls.Add(this.ayrBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 42);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logOutBtn.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.logout512;
            this.logOutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutBtn.FlatAppearance.BorderSize = 0;
            this.logOutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.logOutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logOutBtn.Location = new System.Drawing.Point(75, 0);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(43, 42);
            this.logOutBtn.TabIndex = 14;
            this.logOutBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
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
            this.simgeButon.Location = new System.Drawing.Point(1197, 2);
            this.simgeButon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simgeButon.Name = "simgeButon";
            this.simgeButon.Size = new System.Drawing.Size(20, 20);
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
            this.cikisButon.Location = new System.Drawing.Point(1257, 2);
            this.cikisButon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cikisButon.Name = "cikisButon";
            this.cikisButon.Size = new System.Drawing.Size(20, 20);
            this.cikisButon.TabIndex = 11;
            this.cikisButon.UseVisualStyleBackColor = true;
            this.cikisButon.Click += new System.EventHandler(this.cikisButon_Click);
            // 
            // ayrBtn
            // 
            this.ayrBtn.BackColor = System.Drawing.Color.Transparent;
            this.ayrBtn.BackgroundImage = global::Kutuphane_Otomasyon_Taslak_winform.Properties.Resources.settings;
            this.ayrBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ayrBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ayrBtn.FlatAppearance.BorderSize = 0;
            this.ayrBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ayrBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ayrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ayrBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ayrBtn.Location = new System.Drawing.Point(12, 0);
            this.ayrBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ayrBtn.Name = "ayrBtn";
            this.ayrBtn.Size = new System.Drawing.Size(43, 42);
            this.ayrBtn.TabIndex = 9;
            this.ayrBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ayrBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(12, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Belge Ver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // OgrenciIsleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OgrenciIsleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgrenciIsleri";
            this.Load += new System.EventHandler(this.OgrenciIsleri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button kaplaButon;
        private System.Windows.Forms.Button simgeButon;
        private System.Windows.Forms.Button cikisButon;
        private System.Windows.Forms.Button ayrBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button button1;
    }
}