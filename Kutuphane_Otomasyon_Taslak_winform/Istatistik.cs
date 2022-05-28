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
    public partial class Istatistik : Form
    {
        public Istatistik()
        {
            InitializeComponent();
        }

        static string connection_strg = "Server = 172.21.54.3; uid=sourcesoftware; pwd=Software16344158.; database=sourcesoftware";
        MySqlConnection connection = new MySqlConnection(connection_strg);

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
            Application.Exit();
        }

        private void kaplaButon_Click(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }

        private void simgeButon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*  #en çok hangi ülkeden müşteri var sorgusu
SELECT COUNT(CustomerID), country 
FROM customers
GROUP BY country
ORDER BY COUNT(CustomerID) DESC
LIMIT 1; */


        private void Istatistik_Load(object sender, EventArgs e)
        {
            encokOkunanKitap();
            enAzOkunanKitap();
            encokOkuyanKitapOkuyanOgrenci();
            enazOkuyanKitapOkuyanOgrenci();
            encokokunanKitapDili();
            enazokunanKitapDili();
            toplamOgrenciSayisi();
            toplamKitapSayisi();
            toplamAlinanKitapSayisi();
            enCokKayitOlanBolum();
            enAzKayitOlanBolum();
            }

        private void encokOkunanKitap()
        {
                connection.Open();

           
            MySqlCommand komut = new MySqlCommand("select * from Kitap order by KacKezAlindi asc", connection);
            MySqlDataReader dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {
                lblEnAzOkunanKitap.Text = dr1["kitapAd"].ToString();
            }
            connection.Close();

           
            
        }
        private void enAzOkunanKitap()
        {
            connection.Open();


            MySqlCommand komut = new MySqlCommand("select * from Kitap order by KacKezAlindi desc", connection);
            MySqlDataReader dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {
                lblencokOkunanKitap.Text = dr1["kitapAd"].ToString();
            }
            connection.Close();
        }
        private void encokOkuyanKitapOkuyanOgrenci()
        {
            connection.Open();

            MySqlCommand komut = new MySqlCommand("select * from Ogrenci order by okuduguKitapSayisi desc", connection);
            MySqlDataReader dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {
                lblencokOkuyanOgrenci.Text = dr1["ogrAd"].ToString()+" "+ dr1["ogrSoyad"].ToString();
            }
            connection.Close();

        }

        private void enazOkuyanKitapOkuyanOgrenci()
        {
            connection.Open();

            MySqlCommand komut = new MySqlCommand("select * from Ogrenci order by okuduguKitapSayisi asc", connection);
            MySqlDataReader dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {
                lblenAzOkuyanOgrenci.Text = dr1["ogrAd"].ToString() + " " + dr1["ogrSoyad"].ToString();
            }
            connection.Close();

        }

        private void encokokunanKitapDili()
        {
            connection.Open();

            MySqlCommand komut = new MySqlCommand("select * from Kitap order by dil desc", connection);
            MySqlDataReader dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {
                lblencokOkunanKitapDili.Text = dr1["dil"].ToString();
            }
            connection.Close();

        }
        private void enazokunanKitapDili()
        {
            connection.Open();

            MySqlCommand komut = new MySqlCommand("select * from Kitap order by dil asc", connection);
            MySqlDataReader dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {
                lblenazokunankitapdili.Text = dr1["dil"].ToString();
            }
            connection.Close();

        }
        private void toplamOgrenciSayisi()
        {
            connection.Open();

            MySqlCommand komut = new MySqlCommand("select count(ogrId) from Ogrenci", connection);
            MySqlDataReader dr2 = komut.ExecuteReader();
            while (dr2.Read())
            {
                lbltoplamOgrenciSayisi.Text = dr2[0].ToString();
            }
            connection.Close();

        }
        private void toplamKitapSayisi()
        {
            connection.Open();

            MySqlCommand komut = new MySqlCommand("select count(kitapId) from Kitap", connection);
            MySqlDataReader dr2 = komut.ExecuteReader();
            while (dr2.Read())
            {
                lbltoplamkitapsayisi.Text = dr2[0].ToString();
            }
            connection.Close();

        }
        private void toplamAlinanKitapSayisi()
        {
            connection.Open();

            MySqlCommand komut = new MySqlCommand("select Sum(KacKezAlindi) from Kitap", connection);
            MySqlDataReader dr2 = komut.ExecuteReader();
            while (dr2.Read())
            {
                lbltoplamAlinanKitapSayisi.Text = dr2[0].ToString();
            }
            connection.Close();

        }
        private void enCokKayitOlanBolum()
        {
            connection.Open();

            MySqlCommand komut = new MySqlCommand("select * from Ogrenci order by ogrBolum desc", connection);
            MySqlDataReader dr2 = komut.ExecuteReader();
            while (dr2.Read())
            {
                lblencokkayitolanbolum.Text = dr2["ogrBolum"].ToString();
            }
            connection.Close();

        }
        private void enAzKayitOlanBolum()
        {
          /*  connection.Open();
            /*SELECT COUNT(CustomerID), country 
FROM customers
GROUP BY country
ORDER BY COUNT(CustomerID) DESC
LIMIT 1;*/
           /* MySqlCommand komut = new MySqlCommand("select count(ogrId) from Ogrenci order by ogrBolum desc", connection);
            MySqlDataReader dr2 = komut.ExecuteReader();
            while (dr2.Read())
            {
                lblenAzKayitOlanBolum.Text = dr2["ogrBolum"].ToString();
            }
            connection.Close();*/

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
    }
}
