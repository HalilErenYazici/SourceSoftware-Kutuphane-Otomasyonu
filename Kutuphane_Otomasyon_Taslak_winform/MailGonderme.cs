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

        private void btnMail_Click(object sender, EventArgs e)
        {
            /* MailMessage ePosta = new MailMessage();
              ePosta.From = new MailAddress("berkaygrcn34@gmail.com");
              ePosta.To.Add(txtMail.Text);
              ePosta.Subject = txtBaslik.Text;
              ePosta.Body = txtMesajicerigi.Text;
              SmtpClient smtp = new SmtpClient();
              smtp.Credentials = new System.Net.NetworkCredential("berkaygrcn34@gmail.com", "123bjk456");
              smtp.Port = 587;
              smtp.Host = "smtp.gmail.com";
              smtp.EnableSsl = false;
              smtp.Send(ePosta);
              MessageBox.Show("Mail başarıyla gönderilmiştir.!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

         /*  MailMessage eposta = new MailMessage();
           SmtpClient istemci = new SmtpClient();
           istemci.Credentials = new System.Net.NetworkCredential("berkaygrcn34@gmail.com", "123bjk456");
           istemci.Port = 587;
           istemci.Host = "smtp.gmail.com";
           istemci.EnableSsl = false;
           eposta.To.Add(txtMail.Text);
           eposta.From = new MailAddress("berkaygrcn34@gmail.com");
           eposta.Subject = txtBaslik.Text;
           eposta.Body = txtMesajicerigi.Text;
           istemci.Send(eposta);
           MessageBox.Show("Mail başarıyla gönderilmiştir.!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); 
         */
            /* 
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("mail@gmail.com");
            ePosta.To.Add("alan@gmail.com");
            ePosta.Attachments.Add(new Attachment(@"D:\ek.txt"));
            ePosta.Subject = "konu";
            ePosta.Body = "içerik";
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("mail@gmail.com", "password");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = false;
            smtp.Send(ePosta);
            MessageBox.Show("Mail başarıyla gönderilmiştir.!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Soru ve görüşleriniz için burak@karadasburak.com adresine mail atabilirsiniz. 

             */
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
