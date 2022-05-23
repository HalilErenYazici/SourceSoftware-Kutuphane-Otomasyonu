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
            Form form = new Info();
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

        DateTime Dtn = new DateTime();

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

        private void btnemanetver_Click(object sender, EventArgs e)
        {

           // connection.Open();
         //   MySqlCommand komut = new MySqlCommand("select * from Emanet where ogrId=" + txtogrID.Text + "and kitapId=" + txtkitapId.Text+"and aTarih="+mskalis.Text + "and vTarih=" + mskveris.Text + "and emanetATKS=" + txtemanetakts.Text, connection);
          //  MySqlDataReader okuyucu = komut.ExecuteReader();
            /*if (okuyucu.Read())
            {
                MessageBox.Show("ürün Emanette zaten mevcut");
                AnaSayfa anasayfa = new AnaSayfa();
                this.Close();
                anasayfa.Show();


            }
            else
            {*/
               /* MySqlCommand komut2 = new MySqlCommand("insert into Emanet(ogrId,kitapId,aTarih,vTarih,emanetATKS) values(@ogrId,@kitapId,aTarih,vTarih,emanetATKS)", connection);
                komut2.Parameters.AddWithValue("@ogrId", txtogrID.Text);

                komut2.Parameters.AddWithValue("@kitapId", txtkitapId.Text);
                komut2.Parameters.AddWithValue("@aTarih",  Convert.ToDateTime( mskalis.Text));
                komut2.Parameters.AddWithValue("@vTarih", Convert.ToDateTime(mskveris.Text));
                komut2.Parameters.AddWithValue("@emanetATKS", txtemanetakts.Text);

            komut2.ExecuteNonQuery();
                MessageBox.Show("Emanet sistemine eklenmistir");
                EmanetGoruntule EmanetGoruntule = new EmanetGoruntule();
                this.Close();
                EmanetGoruntule.Show();
            //}
            connection.Close();*/


        }

        private void btnEmanet_Click(object sender, EventArgs e)
        {
            EmanetVer EmanetVer = new EmanetVer();
            this.Close();
            EmanetVer.Show();
        }

        private void mskalis_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mskveris_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtemanetakts_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtKitapAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtkitapId_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
