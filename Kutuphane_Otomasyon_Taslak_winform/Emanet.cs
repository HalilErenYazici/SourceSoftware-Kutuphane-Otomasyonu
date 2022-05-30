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
    public partial class Emanet : Form
    {
        public Emanet()
        {
            InitializeComponent();
        }
        static string connection_strg = "Server = 172.21.54.3; uid=sourcesoftware; pwd=Software16344158.; database=sourcesoftware";
        MySqlConnection connection = new MySqlConnection(connection_strg);
        private void cikisButon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

        private void dataGridViewogrenci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void listeleOgrenci()
        {
           /* connection.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Ogrenci", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewogrenci.DataSource = dt;
            connection.Close();*/

        }
        public void listelemanet()
        {
           connection.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Emanet", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewemanet.DataSource = dt;
            connection.Close();

        }

        private void dataGridViewogrenci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          /*  txtogrID.Text = dataGridViewogrenci.CurrentRow.Cells["ogrId"].Value.ToString();
            txtogrNo.Text = dataGridViewogrenci.CurrentRow.Cells["ogrNo"].Value.ToString();
            txtOgrAd.Text = dataGridViewogrenci.CurrentRow.Cells["ogrAd"].Value.ToString();
            txtOgrSoyad.Text = dataGridViewogrenci.CurrentRow.Cells["ogrSoyad"].Value.ToString();
            txtogrID.Enabled = false;
            txtOgrAd.Enabled = false;
            txtogrNo.Enabled = false;
            txtOgrSoyad.Enabled = false;*/
        }

        //DateTime Dtn = new DateTime();

        private void Emanet_Load(object sender, EventArgs e)
        {
            listelemanet();
          /*  listeleOgrenci();
            listeleKitap();
            Dtn = DateTime.Now;
            mskalis.Text = Dtn.ToString("dd.MM.yyyy" + "HH:mm:ss");*/
        }

        private void dataGridViewkitap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataGridViewkitap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        /*    txtkitapId.Text = dataGridViewkitap.CurrentRow.Cells["kitapId"].Value.ToString();
            txtKitapAd.Text = dataGridViewkitap.CurrentRow.Cells["kitapAd"].Value.ToString();
           
            txtkitapId.Enabled = false;
            txtKitapAd.Enabled = false;*/
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            DialogResult dialog;
            dialog = MessageBox.Show("Bu Kaydı Silmek İstiyor Musunuz?", "SİL!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            string sil = "delete from Emanet where emanetId=@emanetId";
            MySqlCommand command = new MySqlCommand(sil, connection);
            command.Parameters.AddWithValue("@emanetId", dataGridViewemanet.CurrentRow.Cells["emanetId"].Value.ToString());
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Silme işlemi gerçekleşti.");
            listelemanet();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtOgrSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOgrAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtogrNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtogrID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnemanet_Click_1(object sender, EventArgs e)
        {
            EmanetTeslim EmanetVer = new EmanetTeslim();
            EmanetVer.Show();
            this.Hide();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            connection.Open();

            if (cmbaramatip.Text == "Ogrenci Id")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where ogrId like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                if (searchBox.Text == "")
                {
                    listelemanet();

                }
            }
            else if (cmbaramatip.Text == "Ogrenci No")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where ogrNo like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                if (searchBox.Text == "")
                {
                    listelemanet();

                }
            }
            else if (cmbaramatip.Text == "Ogrenci Ad")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where ogrAd like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                if (searchBox.Text == "")
                {
                    listelemanet();

                }
            }
            else if (cmbaramatip.Text == "Ogrenci Soyad")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where ogrSoyad like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                if (searchBox.Text == "")
                {
                    listelemanet();

                }
            }
            else if (cmbaramatip.Text == "Ogrenci Eposta")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where ogrEposta like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                if (searchBox.Text == "")
                {
                    listelemanet();

                }
            }
            else if (cmbaramatip.Text == "Ogrenci Telefon")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where ogrTel like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                if (searchBox.Text == "")
                {
                    listelemanet();

                }
            }
            else if (cmbaramatip.Text == "Kitap Id")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where kitapId like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                if (searchBox.Text == "")
                {
                    listelemanet();

                }
            }
            else if (cmbaramatip.Text == "Demirbaş No")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where demirbasNo like'" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                if (searchBox.Text == "")
                {
                    listelemanet();

                }
            }

            else if (cmbaramatip.Text == "Kitap Ad")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where kitapAd like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                if (searchBox.Text == "")
                {
                    listelemanet();

                }
            }
            else if (cmbaramatip.Text == "Yazar Ad")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where yzrAd like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                if (searchBox.Text == "")
                {
                    listelemanet();

                }
            }
            else if (cmbaramatip.Text == "Yazar Soyad")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where yzrSoyad like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                if (searchBox.Text == "")
                {
                    listelemanet();

                }
            }
            else if (cmbaramatip.Text == "Yayınevi Ad")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where yynevAd like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                if (searchBox.Text == "")
                {
                    listelemanet();

                }
            }
            else if (cmbaramatip.Text == "Veriş Tarihi")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where veristarihi like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                if (searchBox.Text == "")
                {
                    listelemanet();

                }
            }
            else if (cmbaramatip.Text == "Alış Tarihi")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where yynevAd like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                if (searchBox.Text == "")
                {
                    listelemanet();

                }
            }
            else
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where EmanetalinanKitapSayisi like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                if (searchBox.Text == "")
                {
                    listelemanet();

                }
            }

        }


    

    private void button2_Click(object sender, EventArgs e)
        {
            Emanetiade emanetiade = new Emanetiade();
            emanetiade.Show();
            this.Hide();
        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            searchBox.Clear();
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            MailGonderme mail = new MailGonderme();
            mail.Show();
            this.Hide();
        }

        private void cmbaramatip_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewemanet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
