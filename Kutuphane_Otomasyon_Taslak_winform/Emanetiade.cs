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
    public partial class Emanetiade : Form
    {
        public Emanetiade()
        {
            InitializeComponent();
        }
        static string connection_strg = "Server = 172.21.54.3; uid=sourcesoftware; pwd=Software16344158.; database=sourcesoftware";
        MySqlConnection connection = new MySqlConnection(connection_strg);
        DataSet daset = new DataSet();
        
        private void Emanetiade_Load(object sender, EventArgs e)
        {
            emanetlistele();
        }

        public void emanetlistele() {

            connection.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Emanet", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewemanet.DataSource = dt;
            connection.Close();

        }
        private void searchBox_TextChanged(object sender, EventArgs e)
        {   connection.Open();
           
            if (cmbaramatip.Text== "Ogrenci Id")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where ogrId like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                if (searchBox.Text == "")
                {
                    emanetlistele();

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
                    emanetlistele();

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
                    emanetlistele();

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
                    emanetlistele();

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
                    emanetlistele();

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
                    emanetlistele();

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
                    emanetlistele();

                }
            }
            else if (cmbaramatip.Text == "Barkod")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where barkod like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                if (searchBox.Text == "")
                {
                    emanetlistele();

                }
            }
            else if (cmbaramatip.Text == "ISBN")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where ISBN like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                if (searchBox.Text == "")
                {
                    emanetlistele();

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
                    emanetlistele();

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
                    emanetlistele();

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
                    emanetlistele();

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
                    emanetlistele();

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
                    emanetlistele();

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
                    emanetlistele();

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
                    emanetlistele();

                }
            }

        }

        private void searchboxkitap_TextChanged(object sender, EventArgs e)
        {   
            connection.Open();
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where kitapAd like'%" + searchboxkitap.Text + "%'", connection);
            DataTable dt = new DataTable();
            adtr.Fill(dt);
            dataGridViewemanet.DataSource = dt;
            connection.Close();
            if (searchboxkitap.Text == "")
            {
                emanetlistele();

            }
        }

        private void btnemanetkaldir_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (dataGridViewemanet.CurrentRow == null)
            {
                MessageBox.Show("lütfen emanette silincek veriyi seçiniz");
                connection.Close();
            }
            else
            {
                DialogResult dialog;
                dialog = MessageBox.Show("Bu Kaydı Silmek İstiyor Musunuz?", "SİL!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                string sil = "delete from Emanet where ogrNo=@ogrNo and kitapAd=@kitapAd";
                MySqlCommand command = new MySqlCommand(sil, connection);
                command.Parameters.AddWithValue("@ogrNo", dataGridViewemanet.CurrentRow.Cells["ogrNo"].Value.ToString());
                command.Parameters.AddWithValue("@kitapAd", dataGridViewemanet.CurrentRow.Cells["kitapAd"].Value.ToString());

                command.ExecuteNonQuery();
                MessageBox.Show("Silme işlemi gerçekleşti.");
                MySqlCommand komut2 = new MySqlCommand("update Kitap set stok=stok+'" + dataGridViewemanet.CurrentRow.Cells["EmanetalinanKitapSayisi"].Value.ToString() + "' where kitapId=@kitapId", connection);
                komut2.Parameters.AddWithValue("@kitapId", dataGridViewemanet.CurrentRow.Cells["kitapId"].Value.ToString());
                komut2.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Kitap(lar) iade edildi!");

                emanetlistele();
            }
          

        }

        private void anasayfaBtn_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void emanetBtn_Click(object sender, EventArgs e)
        {
            Emanet emanet = new Emanet();
            emanet.Show();
            this.Hide();
        }

        private void ogrenciBtn_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Show();
            this.Hide();
        }

        private void kitapBtn_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.Show();
            this.Hide();
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
            this.Hide();
        }

        private void simgeButon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void kaplaButon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void cikisButon_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
