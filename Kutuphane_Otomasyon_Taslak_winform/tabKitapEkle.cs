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
    public partial class tabKitapEkle : Form
    {
        public tabKitapEkle()
        {
            InitializeComponent();
        }
        
         static string connection_strg = "Server = 172.21.54.3; uid=sourcesoftware; pwd=Software16344158.; database=sourcesoftware";
       MySqlConnection connection = new MySqlConnection(connection_strg);

        bool move;
        int mouse_x;
        int mouse_y;
        int KacKezEmanetAlindi = 0;

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

        public void tabKitapEkle_Load(object sender, EventArgs e)
        {
            lblYazar.Text = "";
            kategoriEkle();
            turEkle();
            yazarAd();
            yazarSoyad();
            yayinevekle();
            YayinEvtel();
            cevirmenadi();
            cevirmensoyadi();
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
            komut.CommandText = "Select * from Yazar ";
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
            komut.CommandText = "Select * from Yazar ";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbyazarsoyad.Items.Add(oku[2].ToString());
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
        private void yayinevekle()
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
        private void YayinEvtel()
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
            cmbyayinevi.DisplayMember = "yynevTel";
            cmbyayinevi.ValueMember = "yynevId";
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
            cmbyayinevi.DisplayMember = "cvrAd";
            cmbyayinevi.ValueMember = "cvrId";
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
            cmbyayinevi.DisplayMember = "cvrSoyad";
            cmbyayinevi.ValueMember = "cvrId";
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

        private void istBtn_Click(object sender, EventArgs e)
        {
            Form form = new Istatistik();
            form.Show();
            this.Close();
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
                yayinevekle();
                YayinEvtel();
                


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
            if (txtcevirmen.Text == ""||txtcevirmensoyad.Text=="")
            {
                MessageBox.Show("Çevirmen bilgileri boş");
            }
            else
            {
                connection.Open();
                string lastInsertedIdStatement = "SELECT LAST_INSERT_ID();";
                var lastInsertedCmd = new MySqlCommand(lastInsertedIdStatement, connection);
                string cevirmenEkle = "insert into Cevirmen(cvrAd,cvrSoyad) values('" + txtcevirmen.Text + "','" + txtcevirmensoyad.Text +  "');";
                MySqlCommand cevirmenKomut = new MySqlCommand(cevirmenEkle, connection);
                cevirmenKomut.ExecuteNonQuery();
                int cevirmenId = int.Parse(lastInsertedCmd.ExecuteScalar().ToString());
                MessageBox.Show("Çevirmen bilgileri eklendi");
                connection.Close();
                cevirmenadi();
                cevirmensoyadi();



            }
        }

        private void btnyazar_Click(object sender, EventArgs e)
        {
            if (txtyazar.Text == "" || txtyazarsoyad.Text == "")
            {
                MessageBox.Show("Yazar bilgileri boş");
            }
            else
            {
                connection.Open();
                string lastInsertedIdStatement = "SELECT LAST_INSERT_ID();";
                var lastInsertedCmd = new MySqlCommand(lastInsertedIdStatement, connection);
                string yazarekle = "insert into Yazar(yzrAd,yzrSoyad) values('" + txtyazar.Text + "','" + txtyazarsoyad.Text +  "');";
                MySqlCommand yazarkomut = new MySqlCommand(yazarekle, connection);
                yazarkomut.ExecuteNonQuery();
                int yazarId = int.Parse(lastInsertedCmd.ExecuteScalar().ToString());
                MessageBox.Show("Yazar bilgileri eklendi");
                connection.Close();
                yazarAd();
                yazarSoyad();



            }

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

        private void cmbyazarad_TextChanged(object sender, EventArgs e)
        {
            //
            //   int id;
            string cekilenAd = cmbyazarad.Text;

            //select id YAZAR WHERE yazarAdi=cekilenAd
           /*  MySqlDataAdapter adapter = new MySqlDataAdapter("select yzrId from Yazar where yzrId='" + cekilenAd + "'", connection);
            lblYazar.Text = cekilenAd;
            lblYazar.Visible = true;
            //lbl.yazar=
            connection.Close();
           */
           

            //MySqlDataReader oku;
            connection.Open();
            //MySqlCommand komut = new MySqlCommand();
            //komut.Connection = connection;
            //komut.CommandText = "select * from Yazar where yzrAd='" + cekilenAd + "'";
            //oku = komut.ExecuteReader();
            string query ="select * from Yazar where yzrAd='" + cekilenAd + "'";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            if (dt.Rows.Count>=0)
            {

                lblYazar.Text = dt.Rows[0]["yzrId"].ToString();
                lblYazar.Visible = true;
            }
            //while (oku.Read())
            //{
            //    //label1.Text = dr["stokyeri_id"].ToString();
            
            //   // lblkategori.Text = oku[0].ToString();
            //}
            connection.Close();

        }

        private void cmbyazarsoyad_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            //
             string cekilensoyad = cmbyazarsoyad.Text;
            /* //select id YAZAR WHERE yazarAdi=cekilenAd
             MySqlDataAdapter adapter = new MySqlDataAdapter("select yzrId from Yazar where yzrId='" + cekilensoyad + "'", connection);
             lblyazarsoyadi.Text = cekilensoyad;
             lblyazarsoyadi.Visible = true;

             //lbl.yazar=
             connection.Close();*/
          
            //MySqlCommand komut = new MySqlCommand();
            //komut.Connection = connection;
            //komut.CommandText = "select * from Yazar where yzrAd='" + cekilenAd + "'";
            //oku = komut.ExecuteReader();
            string query = "select yzrId from Yazar where yzrSoyad='" + cekilensoyad + "'";
                                                                                                                                                                                                                                                                                                                                  
            MySqlCommand cmd = new MySqlCommand(query, connection);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            if (dt.Rows.Count >= 0)
            {

                lblyazarsoyadi.Text = dt.Rows[0]["yzrId"].ToString();
            }

            //while (oku.Read())
            //{
            //    //label1.Text = dr["stokyeri_id"].ToString();

            //   // lblkategori.Text = oku[0].ToString();
            //}
            connection.Close();




        }

        private void cmbtur_TextChanged(object sender, EventArgs e)
        {
            connection.Open();

            //
             string cekilentur = cmbtur.Text;
            /* //select id YAZAR WHERE yazarAdi=cekilenAd
             MySqlDataAdapter adapter = new MySqlDataAdapter("select turId from Tur where turId='" + cekilentur + "'", connection);
             lbltur.Text = cekilentur;
             lbltur.Visible = true;

             //lbl.yazar=
             connection.Close();*/
        
            //MySqlCommand komut = new MySqlCommand();
            //komut.Connection = connection;
            //komut.CommandText = "select * from Yazar where yzrAd='" + cekilenAd + "'";
            //oku = komut.ExecuteReader();
            string query = "select turId from Tur where turAd='" + cekilentur + "'";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            if (dt.Rows.Count >= 0)
            {

                lbltur.Text = dt.Rows[0]["turId"].ToString();
            }

            //while (oku.Read())
            //{
            //    //label1.Text = dr["stokyeri_id"].ToString();

            //   // lblkategori.Text = oku[0].ToString();
            //}
            connection.Close();




        }

        private void cmbyayinevi_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            //
            string cekilenyayinevi = cmbyayinevi.Text;
            /*//select id YAZAR WHERE yazarAdi=cekilenAd
            MySqlDataAdapter adapter = new MySqlDataAdapter("select yynevId from YayinEvi where yynevAd='" + cekilenyayinevi + "'", connection);
            
            lblyayinevi.Text = cekilenyayinevi;
            //lbl.yazar=
            lblyayinevi.Visible = true;

            connection.Close();
            */
            
            //MySqlCommand komut = new MySqlCommand();
            //komut.Connection = connection;
            //komut.CommandText = "select * from Yazar where yzrAd='" + cekilenAd + "'";
            //oku = komut.ExecuteReader();
            string query = "select yynevId from YayinEvi where yynevAd='" + cekilenyayinevi + "'";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            if (dt.Rows.Count >= 0)
            {

                lblyayinevi.Text = dt.Rows[0]["yynevId"].ToString();
            }

            //while (oku.Read())
            //{
            //    //label1.Text = dr["stokyeri_id"].ToString();

            //   // lblkategori.Text = oku[0].ToString();
            //}
            connection.Close();


        }

        private void cmbyayinevitel_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            //
            string cekilenyayinevitel = cmbyayinevitel.Text;
            /* //select id YAZAR WHERE yazarAdi=cekilenAd
             MySqlDataAdapter adapter = new MySqlDataAdapter("select yynevId from YayinEvi where yynevId='" + cekilenyayinevitel + "'", connection);
             lblyayinevitel.Text = cekilenyayinevitel;
             //lbl.yazar=
             lblyayinevitel.Visible = true;*/
            //MySqlCommand komut = new MySqlCommand();
            //komut.Connection = connection;
            //komut.CommandText = "select * from Yazar where yzrAd='" + cekilenAd + "'";
            //oku = komut.ExecuteReader();
            string query = "select yynevId from YayinEvi where yynevTel='" + cekilenyayinevitel + "'";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            if (dt.Rows.Count >= 0)
            {

                lblyayinevitel.Text = dt.Rows[0]["yynevId"].ToString();
            }

            //while (oku.Read())
            //{
            //    //label1.Text = dr["stokyeri_id"].ToString();

            //   // lblkategori.Text = oku[0].ToString();
            //}
            connection.Close();

        }

        private void cmbkategori_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            //
            string cekilenkategori = cmbkategori.Text;
            /* //select id YAZAR WHERE yazarAdi=cekilenAd
             MySqlDataAdapter adapter = new MySqlDataAdapter("select ktgrId from Kategori where ktgrId='" + cekilenkategori + "'", connection);
             lblkategori.Text = cekilenkategori;
             //lbl.yazar=
             lblkategori.Visible = true;*/
            //MySqlCommand komut = new MySqlCommand();
            //komut.Connection = connection;
            //komut.CommandText = "select * from Yazar where yzrAd='" + cekilenAd + "'";
            //oku = komut.ExecuteReader();
            string query = "select ktgrId from Kategori where ktgrAd='" + cekilenkategori + "'";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            if (dt.Rows.Count >= 0)
            {

                lblkategori.Text = dt.Rows[0]["ktgrId"].ToString();
            }

            //while (oku.Read())
            //{
            //    //label1.Text = dr["stokyeri_id"].ToString();

            //   // lblkategori.Text = oku[0].ToString();
            //}
            connection.Close();

           
        }

        private void cmbcevirmenadi_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            //
            string cekilencevirmenad = cmbcevirmenadi.Text;
            /* //select id YAZAR WHERE yazarAdi=cekilenAd
             MySqlDataAdapter adapter = new MySqlDataAdapter("select cvrId from Cevirmen where cekilencevirmenad='" + cekilencevirmenad + "'", connection);
             lblcevirmenad.Text = cekilencevirmenad;

             lblidcevirmenad.Text = cekilencevirmenad;
             //lbl.yazar=
             lblidcevirmenad.Visible = true;*/
            string query = "select cvrId from Cevirmen where cvrAd='" + cekilencevirmenad + "'";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            if (dt.Rows.Count >= 0)
            {

                lblidcevirmensoyad.Text = dt.Rows[0]["cvrId"].ToString();
            }
          

            //while (oku.Read())
            //{
            //    //label1.Text = dr["stokyeri_id"].ToString();

            //   // lblkategori.Text = oku[0].ToString();
            //}
            connection.Close();
            

        }

        private void cmbcevirmensoyadi_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            //
            string cekilencevirmensoyad = cmbcevirmensoyadi.Text;
            /*//select id YAZAR WHERE yazarAdi=cekilenAd
            MySqlDataAdapter adapter = new MySqlDataAdapter("select cvrId from Cevirmen where cvrId='" + cekilencevirmensoyad + "'", connection);
            lblidcevirmensoyad.Text = "cvrId";
            //lbl.yazar=
            lblidcevirmensoyad.Visible = true;*/
            string query = "select cvrId from Cevirmen where cvrSoyad='" + cekilencevirmensoyad + "'";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            if (dt.Rows.Count >= 0)
            {

                lblidcevirmensoyad.Text = dt.Rows[0]["cvrId"].ToString();
            }

            connection.Close();
        }

        //private void ClearAll(Control ctl)
        //{
        //    foreach (Control c in ctl.Controls)
        //    {
        //        if (c is TextBox)
        //        {
        //            ((TextBox)c).Clear();
        //        }
        //        if (c.Controls.Count > 0)
        //        {
        //            ClearAll(c);
        //        }
        //    }
        //}

        //private void ClearAllCombo(Control ctl)
        //{
        //    foreach (Control c in ctl.Controls)
        //    {
        //        if (c is ComboBox)
        //        {
        //            ((ComboBox)c).ResetText();
        //        }
        //        if (c.Controls.Count > 0)
        //        {
        //            ClearAllCombo(c);
        //        }
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
          /*  string lastInsertedIdStatement = "SELECT LAST_INSERT_ID();";
            var lastInsertedCmd = new MySqlCommand(lastInsertedIdStatement, connection);*/

            if (txtKitapAd.Text==""||txtdemirbas.Text==""||cmbtur.Text=="" &&txtanahtarkelime.Text==""||txtbarkod.Text==""||txtbasimnumara.Text==""||txtcikisyili.Text==""||txtcilt.Text==""||txtdemirbas.Text==""||txtdil.Text==""||txtdolapkonum.Text==""||txtisbn.Text==""||txtKitapAd.Text==""||txtkitapkonusu.Text==""||txtkitapsayfasayisi.Text==""||txtozet.Text==""||txtrafkonum.Text==""||txtstok.Text==""||cmbkategori.Text==""||cmbtur.Text==""||cmbyayinevi.Text==""||cmbyayinevitel.Text==""||cmbyazarad.Text==""||cmbyazarsoyad.Text=="")
            {

                 MessageBox.Show("Lütfen alanları boş geçmeyiniz.");
            }
            else
            {
                

                connection.Open();

                if (lblisbn.Text == "Yazılabilir" && lbldemirbasno.Text == "Yazılabilir" &&lblbarkod.Text == "Yazılabilir") {

                  /*  if (cmbyazarad.Text=="")
                    {
                        string ekle2 = "insert into Kitap (ktgrId,turId,yzrId,yynevId,cvrId,barkod,ISBN,demirbasNo,kitapAd,cilt,konu,ozet,sayfa,stok,anhtrK,dil,ynSenesi,kkTarih,basimNo,cikisYili,dolapNo,rafNo,KacKezAlindi) values(@ktgrId,@turId,@yzrId,@yynevId,@cvrId,@barkod,@ISBN,@demirbasNo,@kitapAd,@cilt,@konu,@ozet,@sayfa,@stok,@anhtrK,@dil,@ynSenesi,@kkTarih,@basimNo,@cikisYili,@dolapNo,@rafNo,@KacKezAlindi)";
                        MySqlCommand eklekomut2 = new MySqlCommand(ekle2, connection);

                        eklekomut2.Parameters.AddWithValue("@ktgrId", null);

                        eklekomut2.Parameters.AddWithValue("@turId", lbltur.Text);

                        eklekomut2.Parameters.AddWithValue("@yzrId", null);
                        eklekomut2.Parameters.AddWithValue("@yynevId", null);

                        eklekomut2.Parameters.AddWithValue("@cvrId", null);
                        eklekomut2.Parameters.AddWithValue("@barkod", null);
                        eklekomut2.Parameters.AddWithValue("@ISBN", null);
                        eklekomut2.Parameters.AddWithValue("@demirbasNo", txtdemirbas.Text);
                        eklekomut2.Parameters.AddWithValue("@kitapAd", txtKitapAd.Text);
                        eklekomut2.Parameters.AddWithValue("@cilt", null);
                        eklekomut2.Parameters.AddWithValue("@konu", null);
                        eklekomut2.Parameters.AddWithValue("@ozet", null);
                        eklekomut2.Parameters.AddWithValue("@sayfa", null);
                        eklekomut2.Parameters.AddWithValue("@stok", null);

                        eklekomut2.Parameters.AddWithValue("@anhtrK", null);
                        eklekomut2.Parameters.AddWithValue("@dil", null);
                        eklekomut2.Parameters.AddWithValue("@ynSenesi", null);
                        eklekomut2.Parameters.AddWithValue("@kkTarih", null);
                        eklekomut2.Parameters.AddWithValue("@basimNo", null);
                        eklekomut2.Parameters.AddWithValue("@cikisYili", null);
                        eklekomut2.Parameters.AddWithValue("@dolapNo", null);
                        eklekomut2.Parameters.AddWithValue("@rafNo", null);
                        eklekomut2.Parameters.AddWithValue("@KacKezAlindi", KacKezEmanetAlindi);



                        eklekomut2.ExecuteNonQuery();






                        connection.Close();
                        MessageBox.Show("Kayıt başarıyla gerçekleştirildi.");
                        //Kitap kitap = new Kitap();
                        //kitap.Show();
                        //this.Close();
                    }*/
                 
                        string ekle = "insert into Kitap (ktgrId,barkod,ISBN,demirbasNo,kitapAd,cilt,konu,ozet,sayfa,stok,anhtrK,dil,ynSenesi,kkTarih,basimNo,cikisYili,dolapNo,rafNo,KacKezAlindi,turId,yzrId,yynevId,cvrId) values(@ktgrId,@barkod,@ISBN,@demirbasNo,@kitapAd,@cilt,@konu,@ozet,@sayfa,@stok,@anhtrK,@dil,@ynSenesi,@kkTarih,@basimNo,@cikisYili,@dolapNo,@rafNo,@KacKezAlindi,@turId,@yzrId,@yynevId,@cvrId)";
                        MySqlCommand eklekomut = new MySqlCommand(ekle, connection);

                        
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
                        eklekomut.Parameters.AddWithValue("@KacKezAlindi", KacKezEmanetAlindi);
                        eklekomut.Parameters.AddWithValue("@ktgrId", lblkategori.Text);

                        eklekomut.Parameters.AddWithValue("@turId", lbltur.Text);

                        eklekomut.Parameters.AddWithValue("@yzrId", lblYazar.Text);
                        eklekomut.Parameters.AddWithValue("@yynevId", lblyayinevi.Text);

                        eklekomut.Parameters.AddWithValue("@cvrId", lblidcevirmensoyad.Text);



                        eklekomut.ExecuteNonQuery();






                        connection.Close();
                        MessageBox.Show("Kayıt başarıyla gerçekleştirildi.");


                    Kitap form = new Kitap();
                    form.Show();
                    this.Hide();



                }
                else
                {

                    MessageBox.Show("ISBN ,Barkod ve Demirbaş no veritabanında başka kitaba ait");
                    connection.Close();
                }
                //this.Controls.Clear();
                //this.InitializeComponent();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label25.Visible = true;
            txtyayinevi.Visible = true;
            yayinevibtn.Visible = true;
            label29.Visible = true;
            msktel.Visible = true;
            label24.Visible = false;
            txttur.Visible = false;
            tureklebtn.Visible = false;
            label30.Visible = false;
            txtkategori.Visible = false;
            btnkategori.Visible = false;
            label36.Visible = false;
            label35.Visible = false;
            txtyazar.Visible = false;
            txtyazarsoyad.Visible = false;
            btnyazar.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            txtcevirmen.Visible = false;
            txtcevirmensoyad.Visible = false;
            button6.Visible = false;
            button3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label25.Visible = false;
            txtyayinevi.Visible = false;
            yayinevibtn.Visible = false;
            label29.Visible = false;
            msktel.Visible = false;
            label24.Visible = true;
            txttur.Visible = true;
            tureklebtn.Visible = true;
            label30.Visible = false;
            txtkategori.Visible = false;
            btnkategori.Visible = false;
            label36.Visible = false;
            label35.Visible = false;
            txtyazar.Visible = false;
            txtyazarsoyad.Visible = false;
            btnyazar.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            txtcevirmen.Visible = false;
            txtcevirmensoyad.Visible = false;
            button6.Visible = false;
            button3.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label25.Visible = false;
            txtyayinevi.Visible = false;
            yayinevibtn.Visible = false;
            label29.Visible = false;
            msktel.Visible = false;
            label24.Visible = false;
            txttur.Visible = false;
            tureklebtn.Visible = false;
            label30.Visible = true;
            txtkategori.Visible = true;
            btnkategori.Visible = true;
            label36.Visible = false;
            label35.Visible = false;
            txtyazar.Visible = false;
            txtyazarsoyad.Visible = false;
            btnyazar.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            txtcevirmen.Visible = false;
            txtcevirmensoyad.Visible = false;
            button6.Visible = false;
            button3.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label25.Visible = false;
            txtyayinevi.Visible = false;
            yayinevibtn.Visible = false;
            label29.Visible = false;
            msktel.Visible = false;
            label24.Visible = false;
            txttur.Visible = false;
            tureklebtn.Visible = false;
            label30.Visible = false;
            txtkategori.Visible = false;
            btnkategori.Visible = false;
            label36.Visible = true;
            label35.Visible = true;
            txtyazar.Visible = true;
            txtyazarsoyad.Visible = true;
            btnyazar.Visible = true;
            label31.Visible = false;
            label32.Visible = false;
            txtcevirmen.Visible = false;
            txtcevirmensoyad.Visible = false;
            button6.Visible = false;
            button3.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label25.Visible = false;
            txtyayinevi.Visible = false;
            yayinevibtn.Visible = false;
            label29.Visible = false;
            msktel.Visible = false;
            label24.Visible = false;
            txttur.Visible = false;
            tureklebtn.Visible = false;
            label30.Visible = false;
            txtkategori.Visible = false;
            btnkategori.Visible = false;
            label36.Visible = false;
            label35.Visible = false;
            txtyazar.Visible = false;
            txtyazarsoyad.Visible = false;
            btnyazar.Visible = false;
            label31.Visible = true;
            label32.Visible = true;
            txtcevirmen.Visible = true;
            txtcevirmensoyad.Visible = true;
            button6.Visible = true;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label25.Visible = false;
            txtyayinevi.Visible = false;
            yayinevibtn.Visible = false;
            label29.Visible = false;
            msktel.Visible = false;
            label24.Visible = false;
            txttur.Visible = false;
            tureklebtn.Visible = false;
            label30.Visible = false;
            txtkategori.Visible = false;
            btnkategori.Visible = false;
            label36.Visible = false;
            label35.Visible = false;
            txtyazar.Visible = false;
            txtyazarsoyad.Visible = false;
            btnyazar.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            txtcevirmen.Visible = false;
            txtcevirmensoyad.Visible = false;
            button6.Visible = false;
            button3.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AnaSayfa form = new AnaSayfa();
            form.Show();
            this.Close();
        }
    }
}
