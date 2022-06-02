using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon_Taslak_winform
{
    public partial class GorIstatistik : Form
    {
        public GorIstatistik()
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
            if (this.WindowState == System.Windows.Forms.FormWindowState.Normal)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == System.Windows.Forms.FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
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
            toplamOgrenciSayisi();
            toplamKitapSayisi();
            toplamAlinanKitapSayisi();
            enCokKayitOlanBolum();
            enAzKayitOlanBolum();
            encokokuyanogrenci();
            enazokuyanOgrenci();
            encokEmanetAlinanKitap();
            enazEmanetAlinanKitap();
            vakit();
            timer1.Start();
        }

        private void vakit()
        {
            tarih.Text = DateTime.Now.ToLongDateString();
            saat.Text = DateTime.Now.ToLongTimeString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            tarih.Text = DateTime.Now.ToLongDateString();
            saat.Text = DateTime.Now.ToLongTimeString();
        }

        private void encokOkunanKitap()
        {
                connection.Open();

           
            MySqlCommand komut = new MySqlCommand("select * from Kitap order by KacKezAlindi asc", connection);
            MySqlDataReader dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {
                lblencokOkunanKitap.Text = dr1["kitapAd"].ToString();
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
                lblEnAzOkunanKitap.Text = dr1["kitapAd"].ToString();
            }
            connection.Close();
        }
        private void encokOkuyanKitapOkuyanOgrenci()
        {
            connection.Open();

            MySqlCommand komut = new MySqlCommand("select * from Ogrenci order by okuduguKitapSayisi asc", connection);
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

            MySqlCommand komut = new MySqlCommand("select * from Ogrenci order by okuduguKitapSayisi desc", connection);
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

            MySqlCommand komut = new MySqlCommand("select * from Kitap order by dil asc", connection);
            MySqlDataReader dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {
                lblencokOkunankitapDili.Text = dr1["dil"].ToString();
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

            MySqlCommand komut = new MySqlCommand("select * from Ogrenci order by ogrBolum asc", connection);
            MySqlDataReader dr2 = komut.ExecuteReader();
            while (dr2.Read())
            {
                lblencokkayitolanbolum.Text = dr2["ogrBolum"].ToString();
            }
            connection.Close();

        }
        private void enAzKayitOlanBolum()
        {
            connection.Open();

            MySqlCommand komut = new MySqlCommand("select * from Ogrenci order by ogrBolum desc", connection);
            MySqlDataReader dr2 = komut.ExecuteReader();
            while (dr2.Read())
            {
                lblenAzKayitOlanBolum.Text = dr2["ogrBolum"].ToString();
            }
            connection.Close();

        }

        private void Grafikler_Load(object sender, EventArgs e)
        {
        }
        private void encokokuyanogrenci()
        {
            connection.Open();
            MySqlCommand komut = new MySqlCommand("Select ogrAd,ogrSoyad,okuduguKitapSayisi from Ogrenci order by okuduguKitapSayisi desc LIMIT 5", connection);
            MySqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                chartencokkitapokuyan.Series["En çok kitap okuyan öğrenci"].Points.AddXY(read["ogrAd"].ToString() + " " + read["ogrSoyad"].ToString(), read["okuduguKitapSayisi"]);



                // chart2.Series["En çok kitap okuyan öğrenci"].Points.AddXY(read["ogrAd"].ToString() + " " + read["ogrSoyad"].ToString(), read["okuduguKitapSayisi"]);



            }

            connection.Close();
            chartencokkitapokuyan.Series["En çok kitap okuyan öğrenci"].Color = Color.Orange;
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


        private void anasayfaBtn_Click(object sender, EventArgs e)
        {

            Form form = new AnaSayfa();
            form.Show();
            this.Close();
        }

        private void emanetBtn_Click(object sender, EventArgs e)
        {

            Form form = new GorEmanet();
            form.Show();
            this.Close();
        }

        private void ogrenciBtn_Click(object sender, EventArgs e)
        {

            Form form = new GorOgrenci();
            form.Show();
            this.Close();
        }

        private void kitapBtn_Click(object sender, EventArgs e)
        {

            Form form = new GorKitap();
            form.Show();
            this.Close();
        }

        private void istBtn_Click(object sender, EventArgs e)
        {
            Form form = new GorIstatistik();
            form.Show();
            this.Close();
        }

        private void btnOgrGtr_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel5.Visible = false;
            chartenazkitapokuyan.Visible = true;
            chartencokkitapokuyan.Visible = true;
            chrtEnAzEmanetAlinanKitap.Visible = false;
            chrtEnCokEmanetAlinanKitap.Visible = false;
        }

        private void btnKtpGtr_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel5.Visible = false;
            chartenazkitapokuyan.Visible = false;
            chartencokkitapokuyan.Visible = false;
            chrtEnAzEmanetAlinanKitap.Visible = true;
            chrtEnCokEmanetAlinanKitap.Visible = true;
        }
    }
}
