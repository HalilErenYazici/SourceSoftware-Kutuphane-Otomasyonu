using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon_Taslak_winform
{
    public partial class GorOgrenciIsleri : Form
    {
        public GorOgrenciIsleri()
        {
            InitializeComponent();
        }

        static string connection_strg = "Server = 172.21.54.3; uid=sourcesoftware; pwd=Software16344158.; database=sourcesoftware";
        MySqlConnection connection = new MySqlConnection(connection_strg);

        bool emptyBox;
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
        private void searchBox_Click(object sender, EventArgs e)
        {
            if(emptyBox)
            {
                Form form = new GorOgrenciIsleri();
                form.Show();
                this.Close();
            }
        }


        private void OgrenciIsleri_Load(object sender, EventArgs e)
        {
            emptyBox=false;
            listelemanet();
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
        public void listelemanet()
        {
            connection.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Emanet", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Form form = new AnaGirisEkrani();
            form.Show();
            this.Close();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Öğrenci No")
            {

                    MySqlDataAdapter da = new MySqlDataAdapter("select * from Emanet where ogrNo like'" + searchBox.Text + "%'", connection);



                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;


                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[16].Value.ToString() == "Teslim Alindi")
                    {
                        button1.Visible = true;
                        emptyBox = true;
                    }
                }



            }
            else if (comboBox1.Text == "Öğrenci Ad")
            {
                    MySqlDataAdapter da = new MySqlDataAdapter("select * from Emanet where ogrAd like'" + searchBox.Text + "%'", connection);



                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[16].Value.ToString() == "Teslim Alindi")
                    {
                        button1.Visible = true;
                        emptyBox = true;

                    }
                }

            }

            else if (comboBox1.Text == "Öğrenci Soyad")
            {

                    MySqlDataAdapter da = new MySqlDataAdapter("select * from Emanet where ogrSoyad like'" + searchBox.Text + "%'", connection);



                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[16].Value.ToString() == "Teslim Alindi")
                    {
                        button1.Visible = true;
                        emptyBox = true;

                    }
                }
            }
            if(searchBox.Text == "")
            {
                button1.Visible = false;
            }
            if(dataGridView1.Rows.Count==1)
            {
                button1.Visible = false;
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Belge Verildi! Almak İçin OK'a Basın.");
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/1CQuo5pUr1WReHRSAWFSIAWAGITs-HbbS/edit?usp=sharing&ouid=103281766253877385045&rtpof=true&sd=true");
            
                Form form = new GorOgrenciIsleri();
                form.Show();
                this.Close();
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Back)
            {
                searchBox.Text = "";
            }
        }

        private void mailBtn_Click(object sender, EventArgs e)
        {
            tabMailGonderme mail = new tabMailGonderme();
            mail.Show();
        }
    }
}
