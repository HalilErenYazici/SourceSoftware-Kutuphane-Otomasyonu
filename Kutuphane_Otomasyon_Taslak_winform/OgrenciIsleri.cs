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
    public partial class OgrenciIsleri : Form
    {
        public OgrenciIsleri()
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
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }

        private void simgeButon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            searchBox.Clear();
            button1.Visible = false;
        }


        private void OgrenciIsleri_Load(object sender, EventArgs e)
        {
            listelemanet();
        }

        public void listelemanet()
        {
            connection.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Emanet", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Form form = new GirisEkrani();
            form.Show();
            this.Close();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Öğrenci No")
            {

                    MySqlDataAdapter da = new MySqlDataAdapter("select * from Emanet where ogrNo like'" + searchBox.Text + "%'", connection);



                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                if(dt.Rows.Count == 0)
                {
                    MessageBox.Show("Sonuç Bulunamadı");

                    button1.Visible = true;
                }



            }
            else if (comboBox1.Text == "Öğrenci Ad")
            {
                    MySqlDataAdapter da = new MySqlDataAdapter("select * from Emanet where ogrAd like'" + searchBox.Text + "%'", connection);



                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;


                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Sonuç Bulunamadı");

                    button1.Visible = true;
                }

            }

            else if (comboBox1.Text == "Öğrenci Soyad")
            {

                    MySqlDataAdapter da = new MySqlDataAdapter("select * from Emanet where ogrSoyad like'" + searchBox.Text + "%'", connection);



                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Sonuç Bulunamadı");

                    button1.Visible = true;
                }
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Belge Verildi! Almak İçin OK'a Basın.");
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/1CQuo5pUr1WReHRSAWFSIAWAGITs-HbbS/edit?usp=sharing&ouid=103281766253877385045&rtpof=true&sd=true");
            button1.Visible = false;
            searchBox.Text = "";
        }
    }
}
