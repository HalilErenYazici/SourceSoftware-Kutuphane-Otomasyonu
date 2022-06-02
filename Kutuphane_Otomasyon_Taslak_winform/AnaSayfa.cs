using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon_Taslak_winform
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        static string connection_strg = "Server = 172.21.54.3; uid=sourcesoftware; pwd=Software16344158.; database=sourcesoftware";
        MySqlConnection connection = new MySqlConnection(connection_strg);
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            adTxt.Text = AnaGirisEkrani.ad + " " + AnaGirisEkrani.soyad;
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
        private void AnaSayfa_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
        private void AnaSayfa_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        private void AnaSayfa_MouseDown(object sender, MouseEventArgs e)
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
        private void anasayfaBtn_Click(object sender, EventArgs e)
        {
            AnaSayfa a = new AnaSayfa();
            a.ShowDialog();
            this.Close();
        }
        private void emanetBtn_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
        }
        private void ogrenciBtn_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;

        }
        private void kitapBtn_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;

        }
        private void istBtn_Click(object sender, EventArgs e)
        {
            Form form = new GorIstatistik();
            form.Show();
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            EmanetTeslim EmanetVer = new EmanetTeslim();
            EmanetVer.Show();
            this.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            EmanetIade Emanetiade = new EmanetIade();
            Emanetiade.Show();
            this.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Form form = new EkleOgrenci();
            form.Show();
            this.Close();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Form form = new DuzenleOgrenci();
            form.Show();
            this.Close();

        }
        private void button9_Click(object sender, EventArgs e)
        {
            Form form = new EkleKitap();
            form.Show();
            this.Close();

        }
        private void button10_Click(object sender, EventArgs e)
        {
            Form form = new DuzenleKitap();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GorEmanet b = new GorEmanet();
            b.Show();
            this.Close();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            GorOgrenci c = new GorOgrenci();
            c.Show();
            this.Close();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            GorKitap d = new GorKitap();
            d.Show();
            this.Close();

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Çıkış Yapmak İstediğinizden Emin Misiniz?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogresult == DialogResult.Yes)
            {
                Form form = new AnaGirisEkrani();
                form.Show();
                this.Close();
            }
            else
            {

            }
        }

        private void mailBtn_Click(object sender, EventArgs e)
        {
            tabMailGonderme mail = new tabMailGonderme();
            mail.Show();
        }
    }
}