using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kutuphane_Otomasyon_Taslak_winform
{
    public partial class PersonelVeriGuncelleme : Form
    {
        public PersonelVeriGuncelleme()
        {
            InitializeComponent();
        }

        static string connection_strg = "Server = 172.21.54.3; uid=sourcesoftware; pwd=Software16344158.; database=sourcesoftware";
        MySqlConnection connection = new MySqlConnection(connection_strg);

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void PersonelVeriGuncelleme_Load(object sender, EventArgs e)
        {
            listele();
        }


        public void listele()
        {
            connection.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Personel", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand("update Personel set prsnKAd=@prsnKAd,prsnSifre=@prsnSifre,prsnAd=@prsnAd, prsnSoyad=@prsnSoyad", connection);

            command.Parameters.AddWithValue("@prsnKAd", textBox2.Text);
            command.Parameters.AddWithValue("@prsnSifre", textBox1.Text);
            command.Parameters.AddWithValue("@prsnAd", txtOgrenciAd.Text);
            command.Parameters.AddWithValue("@prsnSoyad", txtOgrenciSoyad.Text);

            command.ExecuteNonQuery();
            connection.Close();

            Form form = new AnaSayfa();
            form.Show();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox2.Text = dataGridView1.CurrentRow.Cells["prsnKAd"].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells["prsnSifre"].Value.ToString();
            txtOgrenciAd.Text = dataGridView1.CurrentRow.Cells["prsnAd"].Value.ToString();
            txtOgrenciSoyad.Text = dataGridView1.CurrentRow.Cells["prsnSoyad"].Value.ToString();
        }

        private void anasayfaBtn_Click(object sender, EventArgs e)
        {
            Form form = new AnaSayfa();
            form.Show();
            this.Close();
        }

        private void cikisButon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void emanetBtn_Click(object sender, EventArgs e)
        {
            Form form = new Emanet();
            form.Show();
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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
            Form form = new Info();
            form.Show();
            this.Close();
        }
    }
}
