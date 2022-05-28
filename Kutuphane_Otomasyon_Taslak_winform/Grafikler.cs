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
    public partial class Grafikler : Form
    {
        public Grafikler()
        {
            InitializeComponent();
        }
        static string connection_strg = "Server = 172.21.54.3; uid=sourcesoftware; pwd=Software16344158.; database=sourcesoftware";
        MySqlConnection connection = new MySqlConnection(connection_strg);
        private void Grafikler_Load(object sender, EventArgs e)
        {
            encokokuyanogrenci();
            enazokuyanOgrenci();
            encokEmanetAlinanKitap();
            enazEmanetAlinanKitap();
        }
        private void encokokuyanogrenci()
        {
            connection.Open();
            MySqlCommand komut = new MySqlCommand("Select ogrAd,ogrSoyad,okuduguKitapSayisi from Ogrenci order by okuduguKitapSayisi desc LIMIT 5", connection);
            MySqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                chart1.Series["En çok kitap okuyan öğrenci"].Points.AddXY(read["ogrAd"].ToString() + " " + read["ogrSoyad"].ToString(), read["okuduguKitapSayisi"]);



                // chart2.Series["En çok kitap okuyan öğrenci"].Points.AddXY(read["ogrAd"].ToString() + " " + read["ogrSoyad"].ToString(), read["okuduguKitapSayisi"]);



            }
            
            connection.Close();
            chart1.Series["En çok kitap okuyan öğrenci"].Color = Color.Orange;
        }
        private void enazokuyanOgrenci()
        {
            connection.Open();
            MySqlCommand komut = new MySqlCommand("Select ogrAd,ogrSoyad,okuduguKitapSayisi from Ogrenci order by okuduguKitapSayisi ASC LIMIT 5", connection);
            MySqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                chartenazkitapokuyan.Series["En az kitap okuyan öğrenci"].Points.AddXY(read["ogrAd"].ToString() + " " + read["ogrSoyad"].ToString(), read["okuduguKitapSayisi"]);



                // chart2.Series["En çok kitap okuyan öğrenci"].Points.AddXY(read["ogrAd"].ToString() + " " + read["ogrSoyad"].ToString(), read["okuduguKitapSayisi"]);



            }
            connection.Close();
            chartenazkitapokuyan.Series["En az kitap okuyan öğrenci"].Color = Color.LightGreen;

        }
        private void encokEmanetAlinanKitap()
        {
            connection.Open();
            MySqlCommand komut = new MySqlCommand("Select kitapAd,KacKezAlindi from Kitap order by KacKezAlindi desc LIMIT 5", connection);
            MySqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                chrtEnCokEmanetAlinanKitap.Series["En çok emanet alınan kitap"].Points.AddXY(read["kitapAd"].ToString(), read["KacKezAlindi"]);



                // chart2.Series["En çok kitap okuyan öğrenci"].Points.AddXY(read["ogrAd"].ToString() + " " + read["ogrSoyad"].ToString(), read["okuduguKitapSayisi"]);



            }
            connection.Close();
            chrtEnCokEmanetAlinanKitap.Series["En çok emanet alınan kitap"].Color = Color.Purple;

        }
        private void enazEmanetAlinanKitap()
        {
            connection.Open();
            MySqlCommand komut = new MySqlCommand("Select kitapAd,KacKezAlindi from Kitap order by KacKezAlindi asc LIMIT 5", connection);
            MySqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                chrtEnAzEmanetAlinanKitap.Series["En az emanet alınan kitap"].Points.AddXY(read["kitapAd"].ToString(), read["KacKezAlindi"]);



                // chart2.Series["En çok kitap okuyan öğrenci"].Points.AddXY(read["ogrAd"].ToString() + " " + read["ogrSoyad"].ToString(), read["okuduguKitapSayisi"]);



            }
            connection.Close();
            chrtEnCokEmanetAlinanKitap.Series["En çok emanet alınan kitap"].Color = Color.Purple;

        }

        private void cikisButon_Click(object sender, EventArgs e)
        {

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

        private void kitapBtn_Click(object sender, EventArgs e)
        {

            Form form = new Kitap();
            form.Show();
            this.Close();
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {

            Form form = new Ayarlar();
            form.Show();
            this.Close();
        }

        private void simgeButon_Click(object sender, EventArgs e)
        {

        }

        private void kaplaButon_Click(object sender, EventArgs e)
        {

        }
    }
}
