using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SourceSoftware_KutuphaneOtomasyonu
{
    public partial class GorOgrenci : Form
    {
        public GorOgrenci()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new EkleOgrenci();
            form.Show();
            this.Close();
        }

        private void duzenleButon_Click(object sender, EventArgs e)
        {
            Form form = new DuzenleOgrenci();
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
    }
}
