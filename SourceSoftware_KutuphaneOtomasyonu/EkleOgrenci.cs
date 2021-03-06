using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SourceSoftware_KutuphaneOtomasyonu
{
    public partial class EkleOgrenci : Form
    {
        int okuduguKitapSayisi = 0;
        //string  bolum;
        public EkleOgrenci()
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

        private void tabOgrenciEkle_Load(object sender, EventArgs e)
        {
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
            Form form = new Gor_DuzenleOgrenci();
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

        private void txtOgrenciBolum_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFakulte.Text == "İnegöl İşletme Fakültesi")
            {
                cmbisletme.Items.Clear();
                cmbisletme.Items.Add("Yönetim Bilişim Sistemleri");
                cmbisletme.Items.Add("Uluslararası Ticaret ve İşletmecilik");
                cmbisletme.Items.Add("İşletme");


                cmbisletme.Visible = true;
                label4.Visible = true;
            }

            else
            {
                cmbisletme.Items.Clear();
                cmbisletme.Items.Add("Çocuk Bakımı ve Gençlik Hizmetleri Bölümü");
                cmbisletme.Items.Add("Dış Ticaret Bölümü");
                cmbisletme.Items.Add("Elektrik ve Enerji Bölümü");
                cmbisletme.Items.Add("İnşaat Bölümü");
                cmbisletme.Items.Add("Makine ve Metal Teknolojileri Bölümü");
                cmbisletme.Items.Add("Malzeme ve Malzeme İşleme Teknolojileri Bölümü");
                cmbisletme.Items.Add("Pazarlama ve Reklamcılık Bölümü");
                cmbisletme.Items.Add("Tasarım Bölümü");
                cmbisletme.Items.Add("Tekstil, Giyim, Ayakkabı ve Deri Bölümü");
                cmbisletme.Items.Add("Tıbbi Hizmetler ve Teknikler Bölümü");
                cmbisletme.Items.Add("Yönetim ve Organizasyon Bölümü");
                cmbisletme.Items.Add("Sağlık Bakım Hizmetleri Bölümü");
                cmbisletme.Items.Add("Terapi ve Rehabilitasyon Bölümü");
                cmbisletme.Items.Add("Sosyal Hizmet ve Danışmanlık Bölümü");


                cmbisletme.Visible = true;
                label4.Visible = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (mskOgrNo.Text == "" ||txtOgrenciAd.Text == "" || txtOgrenciSoyad.Text == "" || mskOgrenciTelefon.Text == "")
            {
                
                
                if (mskOgrNo.Text.Length != 9)
                {
                    MessageBox.Show("Öğrenci numarası 9 hanenin altında olamaz!");
                }
                 if (txtOgrenciAd.Text.Length < 2)
                {
                    MessageBox.Show("Öğrenci adını giriniz!");
                }
                 if (txtOgrenciSoyad.Text.Length < 2)
                {
                    MessageBox.Show("Öğrenci soyadını giriniz!");
                }

                 if (mskOgrenciTelefon.Text.Length != 14)
                {
                    MessageBox.Show("Telefon numarası 11 hanenin altında olamaz!");
                }
                 if (mskOgrenciPosta.Text == "")
                {
                    MessageBox.Show("Lütfen geçerli bir E-Posta adresi giriniz!");
                }



                 if (cmbFakulte.Text == "")
                {
                    MessageBox.Show("Lütfen bölüm seçiniz.");
                }
                if (cmbcinsiyet.Text == "")
                {
                    MessageBox.Show("Lütfen cinsiyet seçiniz.");
                }
            
             
            }
                else
            {
     
                if (lblkartid.Text== "Yazılabilir"&&lblogrencino.Text== "Yazılabilir"&& lbleposta.Text== "Yazılabilir") {
                    string ekleme = "insert into Ogrenci (kartId,ogrNo,ogrAd,ogrSoyad,cinsiyet,ogrTel,ogrEposta,ogrFakulte,ogrBolum,okuduguKitapSayisi) values('" + mskKartId.Text + "','" + mskOgrNo.Text + "', '" + txtOgrenciAd.Text + "','" + txtOgrenciSoyad.Text + "','" + cmbcinsiyet.Text + "','" + mskOgrenciTelefon.Text + "','" + mskOgrenciPosta.Text + "','" + cmbFakulte.Text + "','" + cmbisletme.Text + "','" + okuduguKitapSayisi + "');";
                    MySqlCommand command = new MySqlCommand(ekleme, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Kayıt başarıyla gerçekleştirildi. Kitap sayfasına yönlendiriliyorsunuz.");

                    Gor_DuzenleOgrenci yeni = new Gor_DuzenleOgrenci();
                    yeni.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Öğrenci No veya Kart Id veritabanında başka birisine ait.");
                    connection.Close();
                }
                /*string ekleme = "insert into Ogrenci (kartId,ogrNo,ogrAd,ogrSoyad,cinsiyet,ogrTel,ogrEposta,ogrFakulte,ogrBolum,okuduguKitapSayisi) values('" + mskKartId.Text + "','" + mskOgrNo.Text + "', '" + txtOgrenciAd.Text + "','" + txtOgrenciSoyad.Text + "','" + cmbcinsiyet.Text +"','" + mskOgrenciTelefon.Text + "','" + mskOgrenciPosta.Text + "','" + cmbFakulte.Text + "','" + cmbisletme.Text +"','"+ okuduguKitapSayisi + "');";
                MySqlCommand command = new MySqlCommand(ekleme, connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("kayıt başarıyla gerçekleştirildi Anasayfaya yönlendiriliyorsunuz");

                AnaSayfa yeni = new AnaSayfa();
                yeni.Show();
                this.Hide();*/
            }
        }

        private void cmbcinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbcinsiyet.SelectedIndex == 0)
            {
                this.panel1.BackgroundImage = Properties.Resources.Bck_Mv;
            }

            if (cmbcinsiyet.SelectedIndex == 1)
            {
                this.panel1.BackgroundImage = Properties.Resources.Bck_Pmb3_5;
            }
        }

        private void mskKartId_TextChanged(object sender, EventArgs e)
        {
           
            connection.Open();
            MySqlDataAdapter adp = new MySqlDataAdapter("select kartId from Ogrenci where kartId='" + mskKartId.Text + "'", connection);
            DataSet ds = new DataSet();
            adp.Fill(ds, "Ogrenci");
            if (ds.Tables["Ogrenci"].Rows.Count > 0)
            {
                lblkartid.Text = "Veri tabanında bu kartId var";
                lblkartid.Visible = true;
            }
            else
            {
                lblkartid.Text = "Yazılabilir";
                lblkartid.Visible = true;

            }
            connection.Close();
        }

        private void mskOgrNo_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            MySqlDataAdapter adp = new MySqlDataAdapter("select ogrNo from Ogrenci where ogrNo='" + mskOgrNo.Text + "'", connection);
            DataSet ds = new DataSet();
            adp.Fill(ds, "Ogrenci");
            if (ds.Tables["Ogrenci"].Rows.Count > 0)
            {
                lblogrencino.Text = "Veri tabanında bu ogrenci no var";
                lblogrencino.Visible = true;
            }
            else
            {
                lblogrencino.Text = "Yazılabilir";
                lblogrencino.Visible = true;

            }
            connection.Close();
        }

        private void mskOgrenciPosta_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            MySqlDataAdapter adp = new MySqlDataAdapter("select ogrEposta from Ogrenci where ogrEposta='" + mskOgrenciPosta.Text + "'", connection);
            DataSet ds = new DataSet();
            adp.Fill(ds, "Ogrenci");
            if (ds.Tables["Ogrenci"].Rows.Count > 0)
            {
                lbleposta.Text = "Veri tabanında bu ogrposta var";
                lbleposta.Visible = true;
            }
            else
            {
                lbleposta.Text = "Yazılabilir";
                lbleposta.Visible = true;

            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaSayfa form = new AnaSayfa();
            form.Show();
            this.Close();
        }
    }
}
