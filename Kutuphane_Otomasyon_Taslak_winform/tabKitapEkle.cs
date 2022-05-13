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

namespace Kutuphane_Otomasyon_Taslak_winform
{
    public partial class tabKitapEkle : Form
    {
        public tabKitapEkle()
        {
            InitializeComponent();
        }
         static string connection_strg = "Server = 172.21.54.3; uid=sourcesoftware; pwd=Software16344158.; database=sourcesoftware";
       MySqlConnection connection = new MySqlConnection(connection_strg);


        private void tabKitapEkle_Load(object sender, EventArgs e)
        {
             connection.Open();
        }



        private void cikisButon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void kitapBtn_Click(object sender, EventArgs e)
        {
            Form form = new Kitap();
            form.Show();
            this.Close();
        }

        private void anasayfaBtn_Click(object sender, EventArgs e)
        {
            Form form = new AnaSayfa();
            form.Show();
            this.Close();
        }

        private void emanetBtn_Click(object sender, EventArgs e)
        {
            Form form = new Emanet();
            form.Show();
            this.Close();
        }

        private void ogrenciBtn_Click(object sender, EventArgs e)
        {
            Form form = new Ogrenci();
            form.Show();
            this.Close();
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            Form form = new Info();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtanahtarkelime.Text == "" || txtbarkod.Text==""||txtbasimnumara.Text==""||txtcevirmen.Text==""||mskcikisyili.Text==""||txtcilt.Text==""||txtdemirbas.Text==""||txtdil.Text==""||txtisbn.Text==""||txtkategori.Text==""||txtKitapAd.Text==""||txttur.Text==""||txtkitapkonusu.Text==""||mskkurumkayittarihi.Text==""||txtozet.Text==""||txtdolapkonum.Text==""||txtkitapsayfasayisi.Text==""||txtstok.Text==""||txtyayinevi.Text==""||mskkitapyayinyili.Text==""||txtyazar.Text=="")
           {
               MessageBox.Show("lütfen alanları boş geçmeyiniz");
           }
           else
           {
               string ekle = "insert into Kitap (barkod,ISBN,demirbasNo,kitapAd,cilt,konu,ozet,sayfa,anhtrK,dil,ynSenesi,kkTarih,basimNo,cikisYili,dolapNo,rafNo) values('" + txtbarkod.Text + "','" + txtisbn.Text + "', '" + txtdemirbas.Text + "','" + txtKitapAd.Text + "','" +txtcilt.Text  + "','" + txtkitapkonusu.Text + "','" + txtozet.Text + "','" + txtkitapsayfasayisi.Text + "','" +txtanahtarkelime.Text  + "','"+txtdil.Text + "','" + mskkitapyayinyili.Text + "','" + mskkurumkayittarihi.Text + "','" + txtbasimnumara.Text + "','"+mskcikisyili.Text + "','" + txtdolapkonum.Text + "','" + txtrafkonum.Text + "','"+ "');";
               MySqlCommand komut = new MySqlCommand(ekle, connection);
               komut.ExecuteNonQuery();                
               connection.Close();
               MessageBox.Show("kayıt başarıyla gerçekleştirildi Anasayfaya yönlendiriliyorsunuz");

               Ogrenci ogrenci = new Ogrenci();
               ogrenci.Show();
               this.Hide();


           }
       
        }
    }
}
