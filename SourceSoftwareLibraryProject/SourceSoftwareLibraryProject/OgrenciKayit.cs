using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SourceSoftwareLibraryProject
{
    public partial class OgrenciKayit : Form
    {
        public OgrenciKayit()
        {
            InitializeComponent();
        }

        private void OgrenciKayit_Load(object sender, EventArgs e)
        {
      

        }

        private void mskTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (mskOgrNo.Text==""||txtAd.Text=="" || txtSoyad.Text == "" || mskTel.Text == "")
            {   if (mskOgrNo.Text.Length != 9)
                {
                    MessageBox.Show("Öğrenci Numarası 9 hanenin altında olamaz!");
                }
                if (txtAd.Text.Length < 2)
                {
                    MessageBox.Show("Adınızı Giriniz!");
                }
                   if (txtSoyad.Text.Length < 2)
                {
                    MessageBox.Show("Soyadınızı Giriniz!");
                }
 
                if (mskTel.Text.Length != 14)
                {
                    MessageBox.Show("Telefon numarası 11 hanenin altında olamaz!");
                }
                if (radioErkek.Checked)
                {

                    label1.Text = "Cinsiyet" + radioErkek.Text;
                    label1.Visible = true;

                }
                else if (radioKadın.Checked)
                {

                    label1.Text = "Cinsiyet" + radioKadın.Text;
                    label1.Visible = true;
                }
                else
                {
                    MessageBox.Show("Lüften cinsiyet seçiniz!");

                }

                if (msktxtposta.Text == "" || msktxtposta.Text.Length < 16)
                {
                    MessageBox.Show("Lütfen Geçerli Bir E-Posta Giriniz");
                }



                if (cmbBolum.Text == "")
                {
                    MessageBox.Show("Bölüm seçiniz");
                }
            }
        
           
            else
            {
                txtAd.Enabled = false;
                txtSoyad.Enabled = false;
                txtKartId.Enabled = false;
                msktxtposta.Enabled = false;
                mskOgrNo.Enabled = false;
                mskTel.Enabled = false;
                txtSoyad.Enabled = false;
                cmbBolum.Enabled = false;
                comboBoxmyo.Enabled = false;
                comboBoxisletmefakultesi.Enabled = false;
                MessageBox.Show("kayıt başarıyla gerçekleştirildi Anasayfaya yönlendiriliyorsunuz");
                AnaSayfa yeni = new AnaSayfa();
                yeni.Show();
                this.Hide();
            }
               
         

          

        }

        private void cmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBolum.Text == "İnegöl İşletme Fakültesi")
            {
                bolumres.Visible = true;
                lblbolum.Visible = true;
                comboBoxisletmefakultesi.Visible = true;
                comboBoxmyo.Visible = false;


            }

            else if (cmbBolum.Text == "İnegöl MYO")
            {
                bolumres.Visible = true;

                lblbolum.Visible = true;
                comboBoxmyo.Visible = true;
                comboBoxisletmefakultesi.Visible = false;

            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBoxisletmefakultesi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
