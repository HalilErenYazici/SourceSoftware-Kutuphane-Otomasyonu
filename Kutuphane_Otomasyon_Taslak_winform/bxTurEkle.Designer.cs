
namespace Kutuphane_Otomasyon_Taslak_winform
{
    partial class bxTurEkle
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
            this.txttur = new System.Windows.Forms.TextBox();
            this.tureklebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txttur
            // 
            this.txttur.Location = new System.Drawing.Point(25, 67);
            this.txttur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttur.Name = "txttur";
            this.txttur.Size = new System.Drawing.Size(207, 22);
            this.txttur.TabIndex = 86;
            // 
            // tureklebtn
            // 
            this.tureklebtn.Location = new System.Drawing.Point(239, 62);
            this.tureklebtn.Margin = new System.Windows.Forms.Padding(4);
            this.tureklebtn.Name = "tureklebtn";
            this.tureklebtn.Size = new System.Drawing.Size(77, 30);
            this.tureklebtn.TabIndex = 87;
            this.tureklebtn.Text = "Tür Ekle";
            this.tureklebtn.UseVisualStyleBackColor = true;
            this.tureklebtn.Click += new System.EventHandler(this.tureklebtn_Click);
            // 
            // bxTurEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 193);
            this.Controls.Add(this.txttur);
            this.Controls.Add(this.tureklebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "bxTurEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bxTurEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttur;
        private System.Windows.Forms.Button tureklebtn;
    }
}