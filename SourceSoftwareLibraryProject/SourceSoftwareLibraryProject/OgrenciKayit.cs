using MySql.Data.MySqlClient;
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
    public partial class OgrenciKayit : Form
    {
        string cinsiyet;
        public OgrenciKayit()
        {
            InitializeComponent();
        }
       // static string connection_strg = "Server = 172.21.54.3; uid=sourcesoftware; pwd=Software16344158.; database=sourcesoftware";
        //MySqlConnection connection = new MySqlConnection(connection_strg);
      
        private void OgrenciKayit_Load(object sender, EventArgs e)
        {
           /* connection.Open();*/
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
                //string ekleme = "insert into Ogrenci (kartId,ogrId,ogrNo,ogrAd,ogrSoyad,ogrTel,ogrEposta,ogrBolum) values('" + txtKartId.Text + "','" + mskOgrNo.Text + "', '" + txtSoyad.Text + "','" + txtSoyad.Text + "','" + mskTel.Text + "','" + msktxtposta.Text + "','" + cmbBolum.Text + "');";
                /*MySqlCommand command = new MySqlCommand(ekleme, connection);
                command.ExecuteNonQuery();
                connection.Close();*/
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioErkek_CheckedChanged(object sender, EventArgs e)
        {
            if (radioErkek.Checked==true)
            {
                pictureboxerkek.Visible = true;
                pictureboxkadin.Visible = false;
                this.BackColor = Color.LightSeaGreen;
                cinsiyet = "erkek";
            }
        }

        private void radioKadın_CheckedChanged(object sender, EventArgs e)
        {
            if (radioKadın.Checked == true)
            {
                pictureboxkadin.Visible = true;
                pictureboxerkek.Visible = false;
                this.BackColor = Color.LightPink;
                cinsiyet = "kadın";
            }
        }

        private void msktxtposta_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            msktxtposta.Text = "___________@ogr.uludag.edu.tr";
        }
    }
}
