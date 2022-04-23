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
            if (mskTel.Text.Length !=14)
            {
                MessageBox.Show("Telefon numarası 11 hanenin altında olamaz!");
            }

            if(mskOgrNo.Text.Length != 9)
            {
                MessageBox.Show("Öğrenci Numarası 9 hanenin altında olamaz!");
            }
             
            if(txtAd.Text.Length < 2)
            {
                MessageBox.Show("Adınızı Giriniz!");
            }

            if(txtSoyad.Text.Length < 2)
            {
                MessageBox.Show("Soyadınızı Giriniz!");
            }


            if (radioErkek.Checked)
            {

                label1.Text = "Cinsiyet" + radioErkek.Text;
            }
            else if (radioKadın.Checked)
            {
                
                label1.Text = "Cinsiyet" + radioKadın.Text;
            }
            else
            {
                MessageBox.Show("Lüften cinsiyet seçiniz!");

            }

            if (txtEposta.Text == "" || txtEposta.Text.Length < 4)
            {
                MessageBox.Show("Lütfen Geçerli Bir E-Posta Giriniz");
            }



            if (cmbBolum.Text == "")
            {
                MessageBox.Show("Boş Geçilemez");
            }


        }
    }
}
