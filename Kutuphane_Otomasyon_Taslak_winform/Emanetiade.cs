using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon_Taslak_winform
{
    public partial class EmanetIade : Form
    {
        public EmanetIade()
        {
            InitializeComponent();
        }
        static string connection_strg = "Server = 172.21.54.3; uid=sourcesoftware; pwd=Software16344158.; database=sourcesoftware";
        MySqlConnection connection = new MySqlConnection(connection_strg);
        DataSet daset = new DataSet();
        String durum = "Teslim Alindi";

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

        private void Emanetiade_Load(object sender, EventArgs e)
        {
            emanetlistele();
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

        public void emanetlistele() {

            connection.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Emanet where Durum='Emanette'", connection);
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
            else if (cmbaramatip.Text == "Demirbaş No")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where demirbasNo like'%" + searchBox.Text + "%'", connection);
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

        private void anasayfaBtn_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void emanetBtn_Click(object sender, EventArgs e)
        {
            GorEmanet emanet = new GorEmanet();
            emanet.Show();
            this.Hide();
        }

        private void ogrenciBtn_Click(object sender, EventArgs e)
        {
            GorOgrenci ogrenci = new GorOgrenci();
            ogrenci.Show();
            this.Hide();
        }

        private void kitapBtn_Click(object sender, EventArgs e)
        {
            GorKitap kitap = new GorKitap();
            kitap.Show();
            this.Hide();
        }

        private void istBtn_Click(object sender, EventArgs e)
        {
            GorIstatistik ist = new GorIstatistik();
            ist.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GorEmanet form = new GorEmanet();
            form.Show();
            this.Close();
        }

        private void btnemanetal_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (dataGridViewemanet.CurrentRow == null)
            {
                MessageBox.Show("Lütfen iade alınacak veriyi seçiniz.");
                connection.Close();
            }
            else
            {

                /*
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
                 */
                DialogResult dialog;
                dialog = MessageBox.Show("Seçilenler iade alınsın mı?", "İADE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                string guncelle = "update Emanet set Durum=@Durum where emanetId=@emanetId";
                MySqlCommand command = new MySqlCommand(guncelle, connection);
                command.Parameters.AddWithValue("@emanetId", txtemanetId.Text);

                command.Parameters.AddWithValue("@Durum",durum);
                command.ExecuteNonQuery();
                MessageBox.Show("Emanet Alma işlemi gerçekleşti.");
                MySqlCommand komut2 = new MySqlCommand("update Kitap set stok=stok+'" + dataGridViewemanet.CurrentRow.Cells["EmanetalinanKitapSayisi"].Value.ToString() + "' where kitapId=@kitapId", connection);
                komut2.Parameters.AddWithValue("@kitapId", dataGridViewemanet.CurrentRow.Cells["kitapId"].Value.ToString());
                komut2.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Kitap(lar) iade alındı.");

                emanetlistele();
            }
        }

        private void dataGridViewemanet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtemanetId.Text = dataGridViewemanet.Rows[e.RowIndex].Cells[0].Value.ToString();

        }
    }
}
