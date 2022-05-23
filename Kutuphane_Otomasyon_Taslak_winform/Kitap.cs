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
    public partial class Kitap : Form
    {
        public Kitap()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new tabKitapEkle();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new tabKitapDuzenle();
            form.Show();
            this.Close();
        }

        private void Kitap_Load(object sender, EventArgs e)
        {
            Listele();
        }
        public void Listele()
        {
            connection.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId;", connection);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            if (cmbaramakitap.Text == "kitapId")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId;" + searchBox.Text, connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;


            }
            else if (cmbaramakitap.Text == "ktgrId")
            {


            }


            connection.Close();
        }




/*
        connection.Open();
            if (cmbaramakitap.Text == "kitapId")
            {
            //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId;" + searchBox.Text, connection);


        DataTable dt = new DataTable();
        da.Fill(dt);

                dataGridView1.DataSource = dt;


            }
            else if(cmbaramakitap.Text=="ktgrId")
            {


            }


connection.Close();
*/



private void panel1_Paint(object sender, PaintEventArgs e)
       {

       }

        private void searchBox_TextChanged_1(object sender, EventArgs e)
        {
            connection.Open();
            if (cmbaramakitap.Text == "kitapId")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where kitapId like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;


            }
             else if (cmbaramakitap.Text == "ktgrId")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where ktgrId like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;


            }
            /*else if (cmbaramakitap.Text == "turId")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where turId like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }*/
            /*else if (cmbaramakitap.Text == "yzrId")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where yzrId like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }*/
     /*       else if (cmbaramakitap.Text == "turId")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where turId like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }*/
          /*  else if (cmbaramakitap.Text == "yzrId")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where yzrId like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }*/
           /* else if (cmbaramakitap.Text == "yynevId")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where yynevId like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }*/
           /* else if (cmbaramakitap.Text == "cvrId")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where cvrId like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }*/
            else if (cmbaramakitap.Text == "barkod")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where barkod like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "ISBN")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where ISBN like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "demirbasNo")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where demirbasNo like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "KitapAd")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where kitapAd like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "cilt")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where cilt like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "konu")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where konu like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "ozet")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where ozet like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "sayfa")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where sayfa like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "anhtrK")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where anhtrK like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "dil")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where dil like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "ynSenesi")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where ynSenesi like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "kkTarih")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where kktarih like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "basimNo")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where basimNo like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "cikisyili")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where cikisyili like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "dolapNo")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where dolapNo like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "rafNo")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where rafNo like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
           /* else if (cmbaramakitap.Text == "ktgrId1")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where ktgrId1 like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }*/
            else if (cmbaramakitap.Text == "KtgrAd")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where ktgrAd like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
          /*  else if (cmbaramakitap.Text == "turId1")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where turId like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }*/
            else if (cmbaramakitap.Text == "turAd")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where turAd like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            /*else if (cmbaramakitap.Text == "yzrId1")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where yzrId1 like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }*/
            else if (cmbaramakitap.Text == "yzrAd")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where yzrAd like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "yzrSoyad")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where yzrSoyad like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "yzrSayisi")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where yzrSayisi like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
           /*else if (cmbaramakitap.Text == "yynevId1")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where yynevId1 like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }*/
            else if (cmbaramakitap.Text == "yynevAd")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where yynevAd like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "yynevTel")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where yynevtel like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
          /*  else if (cmbaramakitap.Text == "cvrId1")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where cvrId1 like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }*/
            else if (cmbaramakitap.Text == "cvrAd")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where cvrAd like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "cvrSoyad")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where cvrSoyad like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "cvrSayisi")
            {
                //    MySqlDataAdapter da = new MySqlDataAdapter("select * from Kitap where kitapId like'" + searchBox.Text + "%'", connection);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where cvrSayisi like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }

            connection.Close();
        }
    }
}
