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
    public partial class Kitap : Form
    {
        public Kitap()
        {
            InitializeComponent();
        }

        static string connection_strg = "Server = 172.21.54.3; uid=sourcesoftware; pwd=Software16344158.; database=sourcesoftware";
        MySqlConnection connection = new MySqlConnection(connection_strg);

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

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new tabKitapEkle();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new tabKitapDuzenle();
            form.Show();
            this.Close();
        }

        private void Kitap_Load(object sender, EventArgs e)
        {
            Listele();
        }
        public void Listele()
        {
            connection.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId;", connection);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
    }
}
