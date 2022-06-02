using System;
using System.Net.Mail;
using System.Windows.Forms;
namespace Kutuphane_Otomasyon_Taslak_winform
{
    public partial class tabMailGonderme : Form
    {
        public tabMailGonderme()
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
            MessageBox.Show("Mail başarıyla gönderilmiştir.");
            GorEmanet emanet = new GorEmanet();
            emanet.Show();
            this.Hide();
        }
    }
}
