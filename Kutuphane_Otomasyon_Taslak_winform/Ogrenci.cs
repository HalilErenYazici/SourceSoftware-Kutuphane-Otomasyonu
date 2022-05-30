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
    public partial class Ogrenci : Form
    {
        public Ogrenci()
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

        private void searchBox_Click(object sender, EventArgs e)
        {
            searchBox.Clear();
        }

        private void cikisButon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kaplaButon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void simgeButon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new tabOgrenciEkle();
            form.Show();
            this.Close();
        }

        private void duzenleButon_Click(object sender, EventArgs e)
        {
            Form form = new tabOgrenciDuzenle();
            form.Show();
            this.Close();

        }

        public void listele()
        {
            connection.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from Ogrenci", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();

        }

        private void Ogrenci_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            connection.Open();

            if(cmbaramatip.Text== "Kart Id")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from Ogrenci where kartId like'" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;


            }
            else if(cmbaramatip.Text == "Ögrenci Id")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from Ogrenci where ogrId like'" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;


            }
            else if (cmbaramatip.Text == "Ögrenci No")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from Ogrenci where ogrNo like'" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;


            }
            else if (cmbaramatip.Text == "Ögrenci Ad")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from Ogrenci where ogrAd like'" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;


            }
            else if (cmbaramatip.Text == "Ögrenci Soyad")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from Ogrenci where ogrSoyad like'" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;


            }
            else if (cmbaramatip.Text == "Cinsiyet")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from Ogrenci where cinsiyet like'" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;


            }
            else if (cmbaramatip.Text == "Ögrenci Tel")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from Ogrenci where ogrTel like'" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;


            }
            else if (cmbaramatip.Text == "Ögrenci Eposta")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from Ogrenci where ogrEposta like'" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;


            }
            else if (cmbaramatip.Text == "Ögrenci Fakülte")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from Ogrenci where ogrFakulte like '" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;


            }
            else if (cmbaramatip.Text == "Ögrenci Bölüm")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from Ogrenci where ogrBolum like '" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;


            }





            /*MySqlDataAdapter da = new MySqlDataAdapter("select * from Ogrenci where ogrNo like'" + searchBox.Text + "%'",connection);
            DataTable dt = new DataTable();
            da.Fill(dt);*/

            // dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void cmbaramatip_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
