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
            adTxt.Text = GirisEkrani.ad + " " + GirisEkrani.soyad;
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
            this.Close();
            AnaSayfa a = new AnaSayfa();
            a.ShowDialog();
        }
        private void emanetBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Emanet b = new Emanet();
            b.ShowDialog();
        }
        private void ogrenciBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Ogrenci c = new Ogrenci();
            c.ShowDialog();
        }
        private void kitapBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Kitap d = new Kitap();
            d.ShowDialog();
        }
        private void ayrBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Ayarlar f = new Ayarlar();
            f.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            EmanetTeslim EmanetVer = new EmanetTeslim();
            EmanetVer.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Emanetiade Emanetiade = new Emanetiade();
            Emanetiade.Show();
            this.Hide();

        }
        private void button6_Click(object sender, EventArgs e)
        {
            Form form = new tabOgrenciEkle();
            form.Show();
            this.Hide();

        }
        private void button7_Click(object sender, EventArgs e)
        {
            Form form = new tabOgrenciDuzenle();
            form.Show();
            this.Hide();

        }
        private void button9_Click(object sender, EventArgs e)
        {
            Form form = new tabKitapEkle();
            form.Show();
            this.Hide();

        }
        private void button10_Click(object sender, EventArgs e)
        {
            Form form = new tabKitapDuzenle();
            form.Show();
            this.Hide();

        }
        private void button11_Click(object sender, EventArgs e)
        {
            Form form = new Istatistik();
            form.Show();
            this.Close();

        }
        private void kitapBtn_Click_1(object sender, EventArgs e)
        {
            Form form = new Kitap();
            form.Show();
            this.Close();
        }
        private void istBtn_Click_1(object sender, EventArgs e)
        {

            Form form = new Istatistik();
            form.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}