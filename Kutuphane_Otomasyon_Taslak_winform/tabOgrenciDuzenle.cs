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
    public partial class tabOgrenciDuzenle : Form
    {
        public tabOgrenciDuzenle()
        {
            InitializeComponent();
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

        static string connection_strg = "Server = 172.21.54.3; uid=sourcesoftware; pwd=Software16344158.; database=sourcesoftware";
        MySqlConnection connection = new MySqlConnection(connection_strg);
        private void tabOgrenciDuzenle_Load(object sender, EventArgs e)
        {


            listele();
           // ogrenciListele();


           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtOgrenciAd.Text == "" || txtogrenciId.Text == "" || txtOgrenciSoyad.Text == "" || mskKartId.Text == "" || mskOgrenciPosta.Text == "" || mskOgrenciTelefon.Text == "" || mskOgrNo.Text == "" || cmbcinsiyet.Text == "" || cmbFakulte.Text == "" || cmbmyo.Text == "")
            {
                MessageBox.Show("Öğrenci seçmediniz öğrenci seçin!");
            }
            else
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("update Ogrenci set kartId=@kartId,ogrId=@ogrId,ogrNo=@ogrNo,ogrAd=@ogrAd,ogrSoyad=@ogrSoyad,cinsiyet=@cinsiyet,ogrTel=@ogrTel,ogrEposta=@ogrEposta,ogrFakulte=@ogrFakulte,ogrBolum=@ogrBolum where ogrId=@ogrId", connection);



                command.Parameters.AddWithValue("@kartId", mskKartId.Text);

                command.Parameters.AddWithValue("@ogrId", txtogrenciId.Text);
                command.Parameters.AddWithValue("@ogrNo", mskOgrNo.Text);

                command.Parameters.AddWithValue("@ogrAd", txtOgrenciAd.Text);
                command.Parameters.AddWithValue("@ogrSoyad", txtOgrenciSoyad.Text);
                command.Parameters.AddWithValue("@cinsiyet", cmbcinsiyet.Text);

                command.Parameters.AddWithValue("@ogrTel", mskOgrenciTelefon.Text);
                command.Parameters.AddWithValue("@ogrEposta", mskOgrenciPosta.Text);
                command.Parameters.AddWithValue("@ogrFakulte", cmbFakulte.Text);
                command.Parameters.AddWithValue("@ogrBolum", cmbmyo.Text);

                command.ExecuteNonQuery();
                connection.Close();

                Form form = new Ogrenci();
                form.Show();
                this.Close();

            }


        }

        private void mskOgrNo_TextChanged(object sender, EventArgs e)
        {
            /*connection.Open();
            string listele = "select * from Ogrenci where ogrNo like %'"+mskOgrNo.Text+"%'";
            MySqlCommand command = new MySqlCommand(listele, connection);
            MySqlDataReader read = command.ExecuteReader();
            command.ExecuteNonQuery();

            while (read.Read())
            {
                mskKartId.Text = read["kartId"].ToString();
                mskOgrNo.Text = read["ogrNo"].ToString();
                txtOgrenciAd.Text = read["ogrAd"].ToString();

                txtOgrenciSoyad.Text = read["ogrSoyad"].ToString();
                cmbcinsiyet.Text = read["cinsiyet"].ToString();
                mskOgrenciTelefon.Text = read["ogrTel"].ToString();
                mskOgrenciPosta.Text = read["ogrEposta"].ToString();
                cmbFakulte.Text = read["ogrFakulte"].ToString();
                cmbmyo.Text = read["ogrBolum"].ToString();


            }
            connection.Close();*/
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mskOgrNo.Text = dataGridView1.CurrentRow.Cells["ogrNo"].Value.ToString();
        }

        DataSet daset = new DataSet();
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from Ogrenci where ogrNo like'" + searchBox.Text + "%'", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtOgrenciAd.Text == "" || txtogrenciId.Text == "" || txtOgrenciSoyad.Text == "" || mskKartId.Text == "" || mskOgrenciPosta.Text == "" || mskOgrenciTelefon.Text == "" || mskOgrNo.Text == "" || cmbcinsiyet.Text == "" || cmbFakulte.Text == "" || cmbmyo.Text == "")
            {
                MessageBox.Show("Silinecek öğrenciyi seçmediniz öğrenci seçin!");
            }
            else
            {
                connection.Open();
                DialogResult dialog;
                dialog = MessageBox.Show("Bu Kaydı Silmek İstiyor Musunuz?", "SİL!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                string sil = "delete from Ogrenci where ogrNo=@ogrNo";
                MySqlCommand command = new MySqlCommand(sil, connection);
                command.Parameters.AddWithValue("@ogrNo", dataGridView1.CurrentRow.Cells["ogrNo"].Value.ToString());
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Silme işlemi gerçekleşti.");
                //daset.Tables["Ogrenci"].Clear();

                listele();
                foreach (Control item in Controls)
                {
                    if (item is TextBox & item is MaskedTextBox & item is ComboBox)
                    {
                        item.Text = null;
                    }
                }

            }




        }

        public void listele()
        {
            connection.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Ogrenci", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();

        }

        private void ogrenciListele()
        {
           /* connection.Open();
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Ogrenci", connection);
            adtr.Fill(daset, "Ogrenci");
            dataGridView1.DataSource = daset.Tables["Ogrenci"];
            connection.Close();
            daset.Tables["Ogrenci"].Clear();
            foreach (Control item in Controls)
            {
                if (item is TextBox & item is MaskedTextBox & item is ComboBox)
                {
                    item.Text = "";
                }
            }
           */
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
//mskOgrNo.Text = dataGridView1.CurrentRow.Cells["ogrNo"].Value.ToString();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mskKartId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtogrenciId.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            mskOgrNo.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtOgrenciAd.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtOgrenciSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbcinsiyet.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

            mskOgrenciTelefon.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            mskOgrenciPosta.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            cmbFakulte.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            cmbmyo.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();


        }

        private void cmbFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFakulte.Text == "İnegöl İşletme Fakültesi")
            {
                cmbmyo.Items.Clear();
                cmbmyo.Items.Add("Yönetim Bilişim Sistemleri");
                cmbmyo.Items.Add("Uluslararası Ticaret ve İşletmecilik");
                cmbmyo.Items.Add("İşletme");



                cmbmyo.Visible = true;
                label4.Visible = true;


            }

            else
            {
                cmbmyo.Items.Clear();
                cmbmyo.Items.Add("Çocuk Bakımı ve Gençlik Hizmetleri Bölümü");
                cmbmyo.Items.Add("Dış Ticaret Bölümü");
                cmbmyo.Items.Add("Elektrik ve Enerji Bölümü");
                cmbmyo.Items.Add("İnşaat Bölümü");
                cmbmyo.Items.Add("Makine ve Metal Teknolojileri Bölümü");
                cmbmyo.Items.Add("Malzeme ve Malzeme İşleme Teknolojileri Bölümü");
                cmbmyo.Items.Add("Pazarlama ve Reklamcılık Bölümü");
                cmbmyo.Items.Add("Tasarım Bölümü");
                cmbmyo.Items.Add("Tekstil, Giyim, Ayakkabı ve Deri Bölümü");
                cmbmyo.Items.Add("Tıbbi Hizmetler ve Teknikler Bölümü");
                cmbmyo.Items.Add("Yönetim ve Organizasyon Bölümü");
                cmbmyo.Items.Add("Sağlık Bakım Hizmetleri Bölümü");
                cmbmyo.Items.Add("Terapi ve Rehabilitasyon Bölümü");
                cmbmyo.Items.Add("Sosyal Hizmet ve Danışmanlık Bölümü");


                cmbmyo.Visible = true;
                label4.Visible = true;

            }
        }

        private void kitapBtn_Click(object sender, EventArgs e)
        {
            Form form = new Kitap();
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

        private void infoBtn_Click(object sender, EventArgs e)
        {
            Form form = new Info();
            form.Show();
            this.Close();
        }
    }
}
