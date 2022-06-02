using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon_Taslak_winform
{
    public partial class GorEmanet : Form
    {
        public GorEmanet()
        {
            InitializeComponent();
        }
        public static string alisTarih;
        static string connection_strg = "Server = 172.21.54.3; uid=sourcesoftware; pwd=Software16344158.; database=sourcesoftware";
        MySqlConnection connection = new MySqlConnection(connection_strg);
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
        public void renk()
        {
            connection.Open();

            /*  MySqlDataAdapter da = new MySqlDataAdapter("select * from Emanet where Durum='Teslim Alındı'", connection);
              dataGridViewemanet.RowsDefaultCellStyle.BackColor = Color.Yellow;
              dataGridViewemanet.CurrentRow.Cells["EmanetalinanKitapSayisi"].

              */

            for (int i = 0; i < dataGridViewemanet.Rows.Count - 1; i++)
            {
                Application.DoEvents();
                // Math.DivRem(i, 2, out sayi);
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (dataGridViewemanet.Rows[i].Cells[16].Value.ToString() == "Teslim Alindi")
                {
                    dataGridViewemanet.Rows[i].Cells[16].Style.BackColor = System.Drawing.Color.Red;

                 //   dataGridViewemanet.DefaultCellStyle.BackColor = Color.Green;

                }
                else if(dataGridViewemanet.Rows[i].Cells[16].Value.ToString() == "Emanette")
                {
                    dataGridViewemanet.Rows[i].Cells[16].Style.BackColor = System.Drawing.Color.Green;


                    //dataGridViewemanet.Rows[i].Cells["Durum"].Style.BackColor = System.Drawing.Color.Red;
                    //dataGridViewemanet.Columns[i].DefaultCellStyle.BackColor = Color.Red;

                }
             

                dataGridViewemanet.Rows[i].DefaultCellStyle = renk;
            }
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

       
       

        private void Emanet_Load(object sender, EventArgs e)
        {
            //DateTime dt = DateTime.Now;
            listelemanet();
            renk();
            /*  listeleOgrenci();
              listeleKitap();
              Dtn = DateTime.Now;
              mskalis.Text = Dtn.ToString("dd.MM.yyyy" + "HH:mm:ss");*/

            vakit();
            timer1.Start();
            mevcut.Checked = true;
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
            renk();


        }

        private void btnemanet_Click_1(object sender, EventArgs e)
        {
            EmanetTeslim EmanetVer = new EmanetTeslim();
            EmanetVer.Show();
            this.Hide();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

            if (cmbaramatip.Text == "Ogrenci Id")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where ogrId like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                renk();

                if (searchBox.Text == "")
                {
                    listelemanet();
                    renk();



                }
            }
            else if (cmbaramatip.Text == "Ogrenci No")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where ogrNo like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                renk();

                if (searchBox.Text == "")
                {
                    listelemanet();
                    renk();



                }
            }
            else if (cmbaramatip.Text == "Ogrenci Ad")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where ogrAd like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                renk();

                if (searchBox.Text == "")
                {
                    listelemanet();
                    renk();



                }
            }
            else if (cmbaramatip.Text == "Ogrenci Soyad")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where ogrSoyad like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                renk();

                if (searchBox.Text == "")
                {
                    listelemanet();
                    renk();



                }
            }
            else if (cmbaramatip.Text == "Ogrenci Eposta")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where ogrEposta like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                renk();

                if (searchBox.Text == "")
                {
                    listelemanet();
                    renk();



                }
            }
            else if (cmbaramatip.Text == "Ogrenci Telefon")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where ogrTel like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                renk();

                if (searchBox.Text == "")
                {
                    listelemanet();
                    renk();



                }
            }
            else if (cmbaramatip.Text == "Kitap Id")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where kitapId like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                renk();

                if (searchBox.Text == "")
                {
                    listelemanet();
                    renk();



                }
            }
            else if (cmbaramatip.Text == "Demirbaş No")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where demirbasNo like'" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                renk();

                if (searchBox.Text == "")
                {
                    listelemanet();
                    renk();



                }
            }

            else if (cmbaramatip.Text == "Kitap Ad")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where kitapAd like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                renk();

                if (searchBox.Text == "")
                {
                    listelemanet();
                    renk();



                }
            }
            else if (cmbaramatip.Text == "Yazar Ad")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where yzrAd like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                renk();

                if (searchBox.Text == "")
                {
                    listelemanet();
                    renk();



                }
            }
            else if (cmbaramatip.Text == "Yazar Soyad")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where yzrSoyad like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                renk();

                if (searchBox.Text == "")
                {
                    listelemanet();
                    renk();



                }
            }
            else if (cmbaramatip.Text == "Yayınevi Ad")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where yynevAd like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                renk();

                if (searchBox.Text == "")
                {
                    listelemanet();
                    renk();



                }
            }
            else if (cmbaramatip.Text == "Veriş Tarihi")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where veristarihi like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                renk();

                if (searchBox.Text == "")
                {
                    listelemanet();
                    renk();



                }
            }
            else if (cmbaramatip.Text == "Alış Tarihi")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where yynevAd like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                renk();

                if (searchBox.Text == "")
                {
                    listelemanet();
                    renk();



                }
            }
            else if (cmbaramatip.Text == "Durum")
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where Durum like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                renk();

                if (searchBox.Text == "")
                {
                    listelemanet();
                    renk();



                }
            }
            else
            {
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where EmanetalinanKitapSayisi like'%" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridViewemanet.DataSource = dt;
                connection.Close();
                renk();

                if (searchBox.Text == "")
                {
                    listelemanet();
                    renk();



                }
            }

        }

    private void button2_Click(object sender, EventArgs e)
        {
            EmanetIade emanetiade = new EmanetIade();
            emanetiade.Show();
            this.Hide();
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            tabMailGonderme mail = new tabMailGonderme();
            mail.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mevcut.Visible = false;
            gecmis.Visible = false;
            tumEmanetler.Visible = false;
            label20.Visible = false;
            btnemanet.Visible = false;
            button2.Visible = false;
            cmbaramatip.Visible = false;
            searchBox.Visible = false;
            button1.Visible = false;
            kapatBtn.Visible = true;
            string tarih;
            DateTime dateTime = DateTime.Now;
            tarih = dateTime.ToString("dd.MM.yyyy");
            searchBoxEmanet.Text = tarih;
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where alistarihi like'%" + searchBoxEmanet.Text + "%'", connection);
            DataTable dt = new DataTable();
            adtr.Fill(dt);
            dataGridViewemanet.DataSource = dt;
            connection.Close();
            if(dataGridViewemanet.Rows.Count==1)
            {
                MessageBox.Show("Teslim Tarihi Gelen Kitap Bulunmamaktadır.");
            }
            if(dataGridViewemanet.Rows.Count > 1)
            {
                int kitapSayi = dataGridViewemanet.Rows.Count - 1;
                MessageBox.Show("Teslim Tarihi Gelen " + kitapSayi + " Kitap Vardır");
            }
        }

        private void kapatBtn_Click(object sender, EventArgs e)
        {
            Form form = new GorEmanet();
            form.Show();
            this.Close();
        }

        private void mevcut_CheckedChanged(object sender, EventArgs e)
        {
            searchBoxEmanet.Text = "";
            string durum = "Emanette";
            searchBoxEmanet.Text = durum;
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where Durum like'%" + searchBoxEmanet.Text + "%'", connection);
            DataTable dt = new DataTable();
            adtr.Fill(dt);
            dataGridViewemanet.DataSource = dt;
            renk();
            connection.Close();

        }

        private void gecmis_CheckedChanged(object sender, EventArgs e)
        {
            searchBoxEmanet.Text = "";
            string durum = "Teslim Alindi";
            searchBoxEmanet.Text = durum;
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where Durum like'%" + searchBoxEmanet.Text + "%'", connection);
            DataTable dt = new DataTable();
            adtr.Fill(dt);
            dataGridViewemanet.DataSource = dt;
            renk();
            connection.Close();
        }

        private void tumEmanetler_CheckedChanged(object sender, EventArgs e)
        {
            listelemanet();
            renk();
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
