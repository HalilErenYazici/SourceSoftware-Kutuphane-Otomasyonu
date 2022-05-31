using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
namespace Kutuphane_Otomasyon_Taslak_winform
{
    public partial class MailGonderme : Form
    {
        public MailGonderme()
        {
            InitializeComponent();
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
        private void cikisButon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            MailMessage eposta = new MailMessage();
            eposta.From = new MailAddress("berkaygrcn34@gmail.com");
            eposta.To.Add(txtMail.Text);
            eposta.Subject = txtBaslik.Text.ToString();
            eposta.Body = txtMesajicerigi.Text.ToString();
            SmtpClient smtp = new SmtpClient();

            smtp.Credentials = new System.Net.NetworkCredential("berkaygrcn34@gmail.com", "123bjk456");
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Send(eposta);
            MessageBox.Show("Mail başarıyla gönderilmiştir");
            Emanet emanet = new Emanet();
            emanet.Show();
            this.Hide();
        }
    }
}
