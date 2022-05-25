﻿using MySql.Data.MySqlClient;
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
    public partial class tabKitapEkle : Form
    {
        public tabKitapEkle()
        {
            InitializeComponent();
        }
        int cevirmensayi = 0;
        int cvrid = 0;
        string cevirmenad, cevirmensoyad = "yok";
         static string connection_strg = "Server = 172.21.54.3; uid=sourcesoftware; pwd=Software16344158.; database=sourcesoftware";
       MySqlConnection connection = new MySqlConnection(connection_strg);


        private void tabKitapEkle_Load(object sender, EventArgs e)
        {
            kategoriEkle();
            turEkle();
            yazarAd();
            yazarSayisi();
            yazarSoyad();
            YayinEviekle();
            YayinEvitel();
            cevirmenadi();
            cevirmensoyadi();
            cevirmensayisi();

        }
        private void kategoriEkle()
        {
            cmbkategori.Items.Clear();
            MySqlDataReader oku;
            connection.Open();
            MySqlCommand komut = new MySqlCommand();
            komut.Connection = connection;
            komut.CommandText = "Select * from Kategori";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbkategori.Items.Add(oku[1].ToString());
            }
            connection.Close();

        }
      
       

        private void yazarAd()
        {
            cmbyazarad.Items.Clear();
            MySqlDataReader oku;
            connection.Open();
            MySqlCommand komut = new MySqlCommand();
            komut.Connection = connection;
            komut.CommandText = "Select * from Yazar where yzrId";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbyazarad.Items.Add(oku[1].ToString());
            }
            connection.Close();

        }
        private void yazarSoyad()
        {
            cmbyazarsoyad.Items.Clear();
            MySqlDataReader oku;
            connection.Open();
            MySqlCommand komut = new MySqlCommand();
            komut.Connection = connection;
            komut.CommandText = "Select * from Yazar where yzrId";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbyazarsoyad.Items.Add(oku[2].ToString());
            }
            connection.Close();

        }
        private void yazarSayisi()
        {
            cmbyazarsayisi.Items.Clear();
            MySqlDataReader oku;
            connection.Open();
            MySqlCommand komut = new MySqlCommand();
            komut.Connection = connection;
            komut.CommandText = "Select * from Yazar";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbyazarsayisi.Items.Add(oku[3].ToString());
            }
            connection.Close();

        }
        private void turEkle()
        {
            cmbtur.Items.Clear();
            MySqlDataReader oku;
            connection.Open();
            MySqlCommand komut = new MySqlCommand();
            komut.Connection = connection;
            komut.CommandText = "Select * from Tur";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbtur.Items.Add(oku[1].ToString());
            }
            connection.Close();

        }
        private void YayinEviekle()
        {
            cmbyayinevi.Items.Clear();
            MySqlDataReader oku;
            connection.Open();
            MySqlCommand komut = new MySqlCommand();
            komut.Connection = connection;
            komut.CommandText = "Select * from YayinEvi";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbyayinevi.Items.Add(oku[1].ToString());
            }
            connection.Close();

        }
        private void YayinEvitel()
        {
            cmbyayinevitel.Items.Clear();
            MySqlDataReader oku;
            connection.Open();
            MySqlCommand komut = new MySqlCommand();
            komut.Connection = connection;
            komut.CommandText = "Select * from YayinEvi";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbyayinevitel.Items.Add(oku[2].ToString());
            }
            connection.Close();

        }
        private void cevirmenadi()
        {
            cmbcevirmenadi.Items.Clear();
            MySqlDataReader oku;
            connection.Open();
            MySqlCommand komut = new MySqlCommand();
            komut.Connection = connection;
            komut.CommandText = "Select * from Cevirmen";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbcevirmenadi.Items.Add(oku[1].ToString());
            }
            connection.Close();

        }
        private void cevirmensoyadi()
        {
            cmbcevirmensoyadi.Items.Clear();
            MySqlDataReader oku;
            connection.Open();
            MySqlCommand komut = new MySqlCommand();
            komut.Connection = connection;
            komut.CommandText = "Select * from Cevirmen";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbcevirmensoyadi.Items.Add(oku[2].ToString());
            }
            connection.Close();

        }
        private void cevirmensayisi()
        {
            cmbcevirmensayisi.Items.Clear();
            MySqlDataReader oku;
            connection.Open();
            MySqlCommand komut = new MySqlCommand();
            komut.Connection = connection;
            komut.CommandText = "Select * from Cevirmen";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbcevirmensayisi.Items.Add(oku[3].ToString());
            }
            connection.Close();

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if (comboBox1.Text== "Çevirmen Var")
            {
                lblcevirmenad.Visible = true;
                lblcevirmensayisi.Visible = true;
                lblcevirmensoyad.Visible = true;
                cmbcevirmenadi.Visible = true;
                cmbcevirmensoyadi.Visible = true;
                cmbcevirmensayisi.Visible = true;

            }
            else
            {
                lblcevirmenad.Visible = false;
                lblcevirmensayisi.Visible = false;
                lblcevirmensoyad.Visible = false;
                txtcevirmen.Visible = false;
                txtcevirmensoyad.Visible = false;
                txtcevirmensayisi.Visible = false;
                cmbcevirmenadi.Text = "yok";
                cmbcevirmensoyadi.Text = "yok";
                cmbcevirmensayisi.Text = "0";
            }*/
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
   



        }

        private void tureklebtn_Click(object sender, EventArgs e)
        {
            if (txttur.Text=="")
            {
                MessageBox.Show("tür verisi boş");
            }
            else
            {
                connection.Open();
                string lastInsertedIdStatement = "SELECT LAST_INSERT_ID();";
                var lastInsertedCmd = new MySqlCommand(lastInsertedIdStatement, connection);
                string turekle = "insert into Tur(turAd) values('" + txttur.Text + "');";
                MySqlCommand turkomut = new MySqlCommand(turekle, connection);
                turkomut.ExecuteNonQuery();
                int turId = int.Parse(lastInsertedCmd.ExecuteScalar().ToString());
                MessageBox.Show("tur eklendi");
                connection.Close();
                turEkle();

            }

        }

        private void yayinevibtn_Click(object sender, EventArgs e)
        {
            if (txtyayinevi.Text == ""||msktel.Text=="")
            {
                MessageBox.Show("Yayın evi adı ve yayın evi telefon verisi boş");
            }
            else
            {
                connection.Open();
                string lastInsertedIdStatement = "SELECT LAST_INSERT_ID();";
                var lastInsertedCmd = new MySqlCommand(lastInsertedIdStatement, connection);
                string yayinEviEkle = "insert into YayinEvi(yynevAd,yynevTel) values('" + txtyayinevi.Text + "','" + msktel.Text + "');";
                MySqlCommand yayinEviKomut = new MySqlCommand(yayinEviEkle, connection);
                yayinEviKomut.ExecuteNonQuery();
                int yayinEviId = int.Parse(lastInsertedCmd.ExecuteScalar().ToString());
                MessageBox.Show("Yayın evi adı ve telefonu eklendi");
                connection.Close();
                YayinEviekle();
                YayinEvitel();
                


            }
        }

       

        private void btnkategori_Click(object sender, EventArgs e)
        {
            if (txtkategori.Text == "")
            {
                MessageBox.Show("Kategori adı verisi boş");
            }
            else
            {
                connection.Open();
                string lastInsertedIdStatement = "SELECT LAST_INSERT_ID();";
                var lastInsertedCmd = new MySqlCommand(lastInsertedIdStatement, connection);
                string kategoriekle = "insert into Kategori(ktgrAd) values('" + txtkategori.Text + "');";
                MySqlCommand kategorikomut = new MySqlCommand(kategoriekle, connection);
                kategorikomut.ExecuteNonQuery();
                int kategoriId = int.Parse(lastInsertedCmd.ExecuteScalar().ToString());
                MessageBox.Show("Kategori adı eklendi");
                connection.Close();
                kategoriEkle();



            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtcevirmen.Text == ""||txtcevirmensayisi.Text==""||txtcevirmensoyad.Text=="")
            {
                MessageBox.Show("Çevirmen bilgileri boş");
            }
            else
            {
                connection.Open();
                string lastInsertedIdStatement = "SELECT LAST_INSERT_ID();";
                var lastInsertedCmd = new MySqlCommand(lastInsertedIdStatement, connection);
                string cevirmenEkle = "insert into Cevirmen(cvrAd,cvrSoyad,cvrSayisi) values('" + txtcevirmen.Text + "','" + txtcevirmensoyad.Text + "','" + txtcevirmensayisi.Text + "');";
                MySqlCommand cevirmenKomut = new MySqlCommand(cevirmenEkle, connection);
                cevirmenKomut.ExecuteNonQuery();
                int cevirmenId = int.Parse(lastInsertedCmd.ExecuteScalar().ToString());
                MessageBox.Show("Çevirmen bilgileri eklendi");
                connection.Close();
                cevirmenadi();
                cevirmensayisi();
                cevirmensoyadi();



            }
        }

        private void btnyazar_Click(object sender, EventArgs e)
        {
            if (txtyazar.Text == "" || txtyazarsoyad.Text == "" || txtyazarsayisi.Text == "")
            {
                MessageBox.Show("Yazar bilgileri boş");
            }
            else
            {
                connection.Open();
                string lastInsertedIdStatement = "SELECT LAST_INSERT_ID();";
                var lastInsertedCmd = new MySqlCommand(lastInsertedIdStatement, connection);
                string yazarekle = "insert into Yazar(yzrAd,yzrSoyad,yzrSayisi) values('" + txtyazar.Text + "','" + txtyazarsoyad.Text + "','" + txtyazarsayisi.Text + "');";
                MySqlCommand yazarkomut = new MySqlCommand(yazarekle, connection);
                yazarkomut.ExecuteNonQuery();
                int yazarId = int.Parse(lastInsertedCmd.ExecuteScalar().ToString());
                MessageBox.Show("Yazar bilgileri eklendi");
                connection.Close();
                yazarAd();
                yazarSoyad();
                yazarSayisi();



            }

        }

        private void txtcilt_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtbarkod_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            MySqlDataAdapter adp = new MySqlDataAdapter("select barkod from Kitap where barkod='" + txtbarkod.Text + "'", connection);
            DataSet ds = new DataSet();
            adp.Fill(ds, "Ogrenci");
            if (ds.Tables["Ogrenci"].Rows.Count > 0)
            {
                lblbarkod.Text = "Veri tabanında bu barkod var";
                lblbarkod.Visible = true;
            }
            else
            {
                lblbarkod.Text = "Yazılabilir";
                lblbarkod.Visible = true;

            }
            connection.Close();
        }

        private void txtdemirbas_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            MySqlDataAdapter adp = new MySqlDataAdapter("select demirbasNo from Kitap where demirbasNo='" + txtdemirbas.Text + "'", connection);
            DataSet ds = new DataSet();
            adp.Fill(ds, "Ogrenci");
            if (ds.Tables["Ogrenci"].Rows.Count > 0)
            {
                lbldemirbasno.Text = "Veri tabanında bu demirbaş numarası var";
                lbldemirbasno.Visible = true;
            }
            else
            {
                lbldemirbasno.Text = "Yazılabilir";
                lbldemirbasno.Visible = true;

            }
            connection.Close();
        }

        private void txtisbn_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            MySqlDataAdapter adp = new MySqlDataAdapter("select ISBN from Kitap where ISBN='" + txtisbn.Text + "'", connection);
            DataSet ds = new DataSet();
            adp.Fill(ds, "Ogrenci");
            if (ds.Tables["Ogrenci"].Rows.Count > 0)
            {
                lblisbn.Text = "Veri tabanında bu isbn numarası var";
                lblisbn.Visible = true;
            }
            else
            {
                lblisbn.Text = "Yazılabilir";
                lblisbn.Visible = true;

            }
            connection.Close();
        }

        private void cmbcevirmensayisi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lastInsertedIdStatement = "SELECT LAST_INSERT_ID();";
            var lastInsertedCmd = new MySqlCommand(lastInsertedIdStatement, connection);

            if (txtanahtarkelime.Text==""||txtbarkod.Text==""||txtbasimnumara.Text==""||txtcikisyili.Text==""||txtcilt.Text==""||txtdemirbas.Text==""||txtdil.Text==""||txtdolapkonum.Text==""||txtisbn.Text==""||txtKitapAd.Text==""||txtkitapkonusu.Text==""||txtkitapsayfasayisi.Text==""||txtozet.Text==""||txtrafkonum.Text==""||txtstok.Text==""||cmbkategori.Text==""||cmbtur.Text==""||cmbyayinevi.Text==""||cmbyayinevitel.Text==""||cmbyazarad.Text==""||cmbyazarsayisi.Text==""||cmbyazarsoyad.Text=="")
             {
                 MessageBox.Show("lütfen alanları boş geçmeyiniz");
             }
            else
             {
                /* if ()
                 {
                     string turEkle = "insert into Tur(turAd) values('" + txttur.Text + "');";
                     MySqlCommand turKomut = new MySqlCommand(turEkle, connection);
                     turKomut.ExecuteNonQuery();


                 }*/

                //string ekle = "insert into Kitap (barkod,ISBN,demirbasNo,kitapAd,cilt,konu,ozet,sayfa,anhtrK,dil,ynSenesi,kkTarih,basimNo,cikisYili,dolapNo,rafNo) values('" + txtbarkod.Text + "','" + txtisbn.Text + "', '" + txtdemirbas.Text + "','" + txtKitapAd.Text + "','" +txtcilt.Text  + "','" + txtkitapkonusu.Text + "','" + txtozet.Text + "','" + txtkitapsayfasayisi.Text + "','" +txtanahtarkelime.Text  + "','"+txtdil.Text + "','" + mskkitapyayinyili.Text + "','" + mskkurumkayittarihi.Text + "','" + txtbasimnumara.Text + "','"+mskcikisyili.Text + "','" + txtdolapkonum.Text + "','" + txtrafkonum.Text + "','"+ "');";
                //  string turgoster = "Select * from Tur(turId,turAd) values('" + txttur.Text + "');";
                // MySqlCommand komut = new MySqlCommand(ekle, connection);
                //MySqlCommand turKomut = new MySqlCommand(turgoster, connection);

                // string sorgu = "Select COUNT(tc) from ogrenci WHERE tc='" + txttur.Text + "'";

                connection.Open();

                if (lblisbn.Text == "Yazılabilir" && lbldemirbasno.Text == "Yazılabilir" && lblbarkod.Text == "Yazılabilir") {
                   string kategoriekle = "insert into Kategori(ktgrAd) values('" + cmbkategori.Text + "');";
                    MySqlCommand kategorikomut = new MySqlCommand(kategoriekle, connection);
                    kategorikomut.ExecuteNonQuery();
                    int kategoriId = int.Parse(lastInsertedCmd.ExecuteScalar().ToString());

                    string turekle = "insert into Tur(turAd) values('" + txttur.Text + "');";
                    MySqlCommand turkomut = new MySqlCommand(turekle, connection);
                    turkomut.ExecuteNonQuery();
                    int turId = int.Parse(lastInsertedCmd.ExecuteScalar().ToString());

                    string yazarekle = "insert into Yazar(yzrAd,yzrSoyad,yzrSayisi) values('" + cmbyazarad.Text + "','" + cmbyazarsoyad.Text + "','" + cmbyazarsayisi.Text + "');";
                    MySqlCommand yazarkomut = new MySqlCommand(yazarekle, connection);
                    yazarkomut.ExecuteNonQuery();
                    int yazarId = int.Parse(lastInsertedCmd.ExecuteScalar().ToString());

                    string yayinEviEkle = "insert into YayinEvi(yynevAd,yynevTel) values('" + cmbyayinevi.Text + "','" + cmbyayinevitel.Text + "');";
                    MySqlCommand yayinEviKomut = new MySqlCommand(yayinEviEkle, connection);
                    yayinEviKomut.ExecuteNonQuery();
                    int yayinEviId = int.Parse(lastInsertedCmd.ExecuteScalar().ToString());

                    string cevirmenEkle = "insert into Cevirmen(cvrAd,cvrSoyad,cvrSayisi) values('" + cmbcevirmenadi.Text + "','" + cmbcevirmensoyadi.Text + "','" + cmbcevirmensayisi.Text + "');";
                    MySqlCommand cevirmenKomut = new MySqlCommand(cevirmenEkle, connection);
                    cevirmenKomut.ExecuteNonQuery();
                    int cevirmenId = int.Parse(lastInsertedCmd.ExecuteScalar().ToString());
                   
                    string ekle = "insert into Kitap (ktgrId,turId,yzrId,yynevId,cvrId,barkod,ISBN,demirbasNo,kitapAd,cilt,konu,ozet,sayfa,stok,anhtrK,dil,ynSenesi,kkTarih,basimNo,cikisYili,dolapNo,rafNo) values(@ktgrId,@turId,@yzrId,@yynevId,@cvrId,@barkod,@ISBN,@demirbasNo,@kitapAd,@cilt,@konu,@ozet,@sayfa,@stok,@anhtrK,@dil,@ynSenesi,@kkTarih,@basimNo,@cikisYili,@dolapNo,@rafNo)";
                    MySqlCommand eklekomut = new MySqlCommand(ekle, connection);

                    eklekomut.Parameters.AddWithValue("@ktgrId", kategoriId);

                    eklekomut.Parameters.AddWithValue("@turId", turId);

                    eklekomut.Parameters.AddWithValue("@yzrId", yazarId);
                    eklekomut.Parameters.AddWithValue("@yynevId", yayinEviId);

                    eklekomut.Parameters.AddWithValue("@cvrId", cevirmenId);
                    eklekomut.Parameters.AddWithValue("@barkod", txtbarkod.Text);
                    eklekomut.Parameters.AddWithValue("@ISBN", txtisbn.Text);
                    eklekomut.Parameters.AddWithValue("@demirbasNo", txtdemirbas.Text);
                    eklekomut.Parameters.AddWithValue("@kitapAd", txtKitapAd.Text);
                    eklekomut.Parameters.AddWithValue("@cilt", txtcilt.Text);
                    eklekomut.Parameters.AddWithValue("@konu", txtkitapkonusu.Text);
                    eklekomut.Parameters.AddWithValue("@ozet", txtozet.Text);
                    eklekomut.Parameters.AddWithValue("@sayfa", txtkitapsayfasayisi.Text);
                    eklekomut.Parameters.AddWithValue("@stok", txtstok.Text);

                    eklekomut.Parameters.AddWithValue("@anhtrK", txtanahtarkelime.Text);
                    eklekomut.Parameters.AddWithValue("@dil", txtdil.Text);
                    eklekomut.Parameters.AddWithValue("@ynSenesi", mskkitapyayinyili.Text);
                    eklekomut.Parameters.AddWithValue("@kkTarih", mskkurumkayittarihi.Text);
                    eklekomut.Parameters.AddWithValue("@basimNo", txtbasimnumara.Text);
                    eklekomut.Parameters.AddWithValue("@cikisYili", txtcikisyili.Text);
                    eklekomut.Parameters.AddWithValue("@dolapNo", txtdolapkonum.Text);
                    eklekomut.Parameters.AddWithValue("@rafNo", txtrafkonum.Text);
                    eklekomut.ExecuteNonQuery();




                 

                    connection.Close();
                    MessageBox.Show("kayıt başarıyla gerçekleştirildi Anasayfaya yönlendiriliyorsunuz");

                    AnaSayfa AnaSayfa = new AnaSayfa();
                    AnaSayfa.Show();
                    this.Hide();

                }
                else
                {

                    MessageBox.Show("ISBN ,Barkod ve Demirbaş no veritabanında başka kitaba ait");
                    connection.Close();
                }
         
                    
                   

                
              //  string turEkle = "insert into Tur(turAd) values('" + txttur.Text + "');";
             // MySqlCommand komut = new MySqlCommand(ekle, connection);
             //  MySqlCommand turKomut = new MySqlCommand(turEkle, connection);
          //     komut.ExecuteNonQuery();                
                //turKomut.ExecuteNonQuery();
            /*    connection.Close();
               MessageBox.Show("kayıt başarıyla gerçekleştirildi Anasayfaya yönlendiriliyorsunuz");

               Ogrenci ogrenci = new Ogrenci();
               ogrenci.Show();
               this.Hide();
            */

           }
       
        }

       
    }
}
