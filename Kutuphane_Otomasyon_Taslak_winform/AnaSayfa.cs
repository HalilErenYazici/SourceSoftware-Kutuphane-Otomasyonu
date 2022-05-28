﻿using System;
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
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }

        private void simgeButon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        //AnaSayfa a = new AnaSayfa();
        //private void anasayfaBtn_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    a.ShowDialog();
        //}


        private void emanetBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Emanet b = new Emanet();
            b.ShowDialog();
        }

        
        private void ogrenciBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ogrenci c = new Ogrenci();
            c.ShowDialog();
        }

        
        private void kitapBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kitap d = new Kitap();
            d.ShowDialog();
        }

        
        private void infoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ayarlar f = new Ayarlar();
            f.ShowDialog();
        }

        private void kitapBtn_Click_1(object sender, EventArgs e)
        {
            Form form = new Kitap();
            form.Show();
            this.Close();
        }

        private void infoBtn_Click_1(object sender, EventArgs e)
        {
            Form form = new Ayarlar();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new PersonelVeriGuncelleme();
            form.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmanetTeslim EmanetVer = new EmanetTeslim();
            EmanetVer.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmanetTeslim EmanetVer = new EmanetTeslim();
            EmanetVer.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form = new tabOgrenciEkle();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form form = new tabOgrenciDuzenle();
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form form = new tabKitapEkle();
            form.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form form = new tabKitapDuzenle();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Emanet form = new Emanet();
            form.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ogrenci form = new Ogrenci();
            form.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form form = new Kitap();
            form.Show();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form form = new Istatistik();
            form.Show();
            this.Close();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            listelemanet();
        }

        public void listelemanet()
        {
            connection.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Emanet", connection);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewemanet.DataSource = dt;

           /* for (int i = 1; i < dataGridViewemanet.Rows.Count; i++)
            {
            label6.Text = dataGridViewemanet.CurrentRow.Cells["alistarihi"].Value.ToString();
                
                DateTime date = new DateTime();
                date = DateTime.Now;

                label6.Text = (date.ToString("dd.MM.yyyy"));

                if (label6.Text == (date.ToString("dd.MM.yyyy")))
                {
                    MessageBox.Show("Teslim Tarihi Gelen Kitap/lar Var");
                }

            }
           */
            connection.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Grafikler grafik = new Grafikler();
            grafik.Show();
            this.Close();
        }
    }
}