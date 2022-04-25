using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceSoftwareLibraryProject
{
    public partial class GirisSayfasi : Form
    {
        public GirisSayfasi()
        {
            InitializeComponent();
        }

        private void GirisYapBtn_Click(object sender, EventArgs e)
        {
            if(KAdTxt.Text.Length < 3 || SifreTxt.Text.Length < 6 || grvTipiCmb.Text== "Görev Tipi Seçiniz...")
            {
                MessageBox.Show(" Lütfen Gerekli Bilgileri Eksiksiz Bir Şekilde Doldurun. \n (Kullanıcı Adı En Az 3 Karakter) \n (Şifre En Az 6 Karakter)");
                KAdTxt.Text = "";
                SifreTxt.Text = "";
                grvTipiCmb.Text = "Görev Tipi Seçiniz...";
            }

            if(KAdTxt.Text == "sourcesoftware" && SifreTxt.Text == "Software16344158." && grvTipiCmb.Text == "Geliştirici Ekibi")
            {
               OgrenciKayit form = new OgrenciKayit();
               form.Show();
                
            }
        }
    }
}
