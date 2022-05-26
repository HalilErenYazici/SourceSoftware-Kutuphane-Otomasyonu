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
    public partial class tabKitapDuzenle : Form
    {
        public tabKitapDuzenle()
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

        private void tabKitapDuzenle_Load(object sender, EventArgs e)
        {
            Listele();
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
        public void Listele()
        {
            connection.Open();

            // MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Kitap, Kategori, Tur, Yazar, YayinEvi, Cevirmen", connection);
            // MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.*,Yazar.*, FROM Kitap RIGHT JOIN Yazar ON Yazar.yzrId=Kitap.yzrId AND RIGHT JOIN Kategori ON Kategori.ktgrId=Kitap.ktgrId AND RIGHT JOIN Tur ON Tur.turId=Kitap.turId AND RIGHT JOIN YayinEvi ON YayinEvi.yynevId=Kitap.yynevId AND RIGHT JOIN Cevirmen ON Cevirmen.cvrId=Kitap.cvrId", connection);
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where kitapId", connection);
            // MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId;", connection);



            /* SELECT kitaplar.kitap_isim, yazarlar.yazar_isim
            FROM kitaplar
            RIGHT JOIN yazarlar ON yazarlar.id = kitaplar.yazarid
          /*  SELECT customers.ContactName, orders.OrderID
            FROM orders
            RIGHT JOIN customers
            ON customers.CustomerID = orders.CustomerID;

            */
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
        private void kitapBtn_Click(object sender, EventArgs e)
        {
            Form form = new Kitap();
            form.Show();
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtanahtarkelime.Text==""||txtbarkod.Text==""||txtbasimnumara.Text==""||cmbcevirmenadi.Text==""||cmbcevirmensoyadi.Text==""||txtcikisyili.Text==""||txtcilt.Text==""||txtdemirbas.Text==""||txtdil.Text==""||txtdolapkonum.Text==""||txtisbn.Text==""||cmbkategori.Text==""||txtKitapAd.Text==""||txtkitapId.Text==""||txtkitapkonusu.Text==""||txtozet.Text==""||txtrafkonum.Text==""||txtstok.Text==""||cmbtur.Text==""||cmbyayinevi.Text==""||cmbyazarad.Text==""||cmbyazarsoyad.Text==""||mskkitapyayinyili.Text==""||mskkurumkayittarihi.Text==""||cmbyayinevitel.Text=="")
            {
                MessageBox.Show("Kitap seçiniz");
            }
            else
            {
                connection.Open();
    
                MySqlCommand command = new MySqlCommand("update Kitap set kitapId=@kitapId,ktgrId=@ktgrId,turId=@turId,yzrId=@yzrId,yynevId=@yynevId,cvrId=@cvrId,barkod=@barkod,ISBN=@ISBN,demirbasNo=@demirbasNo,kitapAd=@kitapAd,cilt=@cilt,konu=@konu,ozet=@ozet,sayfa=@sayfa,stok=@stok,anhtrK=@anhtrK,dil=@dil,ynSenesi=@ynSenesi,kkTarih=@kkTarih,basimNo=@basimNo,cikisYili=@cikisYili,dolapNo=@dolapNo,rafNo=@rafNo where kitapId=@kitapId", connection);
               /* MySqlCommand commandYayinEvi = new MySqlCommand("update YayinEvi set yynevAd=@yynevAd, yynevTel=@yynevTel", connection);
                MySqlCommand commandKategori = new MySqlCommand("update Kategori set ktgrAd=@ktgrAd", connection);
                MySqlCommand commandTur = new MySqlCommand("update Tur set turAd=@turAd", connection);
                MySqlCommand commandYazar = new MySqlCommand("update Yazar set yzrAd=@yzrAd, yzrSoyad=@yzrSoyad", connection);
                MySqlCommand commandCevirmen = new MySqlCommand("update Cevirmen set cvrAd=@cvrAd, cvrSoyad=@cvrSoyad", connection);
               */
                command.Parameters.AddWithValue("@kitapId", txtkitapId.Text);
                command.Parameters.AddWithValue("@ktgrId", lblkategori.Text);
                command.Parameters.AddWithValue("@turId", lbltur.Text);
                command.Parameters.AddWithValue("@yzrId", lblYazar.Text);
                command.Parameters.AddWithValue("@yynevId", lblyayinevi.Text);
                command.Parameters.AddWithValue("@cvrId", lblidcevirmenad.Text);
                command.Parameters.AddWithValue("@barkod", txtbarkod.Text);
                command.Parameters.AddWithValue("@ISBN", txtisbn.Text);
                command.Parameters.AddWithValue("@demirbasNo", txtdemirbas.Text);
                command.Parameters.AddWithValue("@kitapAd", txtKitapAd.Text);
                command.Parameters.AddWithValue("@cilt", txtcilt.Text);
                command.Parameters.AddWithValue("@konu", txtkitapkonusu.Text);
                command.Parameters.AddWithValue("@ozet", txtozet.Text);
                command.Parameters.AddWithValue("@sayfa", txtkitapsayfasayisi.Text);
                command.Parameters.AddWithValue("@stok", txtstok.Text);

                command.Parameters.AddWithValue("@anhtrK", txtanahtarkelime.Text);
                command.Parameters.AddWithValue("@dil", txtdil.Text);
                command.Parameters.AddWithValue("@ynSenesi", mskkitapyayinyili.Text);
                command.Parameters.AddWithValue("@kkTarih", mskkurumkayittarihi.Text);
                command.Parameters.AddWithValue("@basimNo", txtbasimnumara.Text);
                command.Parameters.AddWithValue("@cikisYili", txtcikisyili.Text);
                command.Parameters.AddWithValue("@dolapNo", txtdolapkonum.Text);
                command.Parameters.AddWithValue("@rafNo", txtrafkonum.Text);

                /*commandYayinEvi.Parameters.AddWithValue("@yynevAd", lblyayinevi.Text);
                commandYayinEvi.Parameters.AddWithValue("@yynevTel", lblyayinevitel.Text);

                commandKategori.Parameters.AddWithValue("@ktgrAd", lblkategori.Text);


                commandTur.Parameters.AddWithValue("@turAd", lbltur.Text);

                commandYazar.Parameters.AddWithValue("@yzrAd", lblYazar.Text);
                commandYazar.Parameters.AddWithValue("@yzrSoyad", lblyazarsoyadi.Text);

                commandCevirmen.Parameters.AddWithValue("@cvrAd", lblidcevirmenad.Text);
                commandCevirmen.Parameters.AddWithValue("@cvrSoyad", lblidcevirmensoyad.Text);

                */




                command.ExecuteNonQuery();
               /* commandYayinEvi.ExecuteNonQuery();
                commandKategori.ExecuteNonQuery();
                commandTur.ExecuteNonQuery();
                commandCevirmen.ExecuteNonQuery();*/

                

                connection.Close();

                Form form = new Kitap();
                form.Show();
                this.Close();
            }
              
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtanahtarkelime.Text == "" || txtbarkod.Text == "" || txtbasimnumara.Text == "" || txtcevirmen.Text == "" || txtcevirmensoyad.Text == "" || txtcikisyili.Text == "" || txtcilt.Text == "" || txtdemirbas.Text == "" || txtdil.Text == "" || txtdolapkonum.Text == "" || txtisbn.Text == "" || txtkategori.Text == "" || txtKitapAd.Text == "" || txtkitapId.Text == "" || txtkitapkonusu.Text == "" || txtkitapsayfasayisi.Text == "" || txtozet.Text == "" || txtrafkonum.Text == "" || txtstok.Text == "" || txttur.Text == "" || txtyayinevi.Text == "" || txtyazar.Text == "" || txtyazarsoyad.Text == "" || mskkitapyayinyili.Text == "" || mskkurumkayittarihi.Text == "" || msktel.Text == "")
            {
                MessageBox.Show("Silmek için önce kitap seçiniz");
            }
            else
            {
                connection.Open();
                DialogResult dialog;
                dialog = MessageBox.Show("Bu Kaydı Silmek İstiyor Musunuz?", "SİL!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                string sil = "delete from Kitap where kitapId=@kitapId";
                /*string silYayinEvi = "delete from YayinEvi where yynevId=@yynevId";
                string silKategori = "delete from Kategori where ktgrId=@ktgrId";
                string silTur = "delete from Tur where turId=@turId";
                string silYazar = "delete from Yazar where yzrId=@yzrId";
                string silCevirmen = "delete from Cevirmen where cvrId=@cvrId";
                */
                MySqlCommand command = new MySqlCommand(sil, connection);
              /*  MySqlCommand commandYayinEvi = new MySqlCommand(silYayinEvi, connection);
                MySqlCommand commandKategori = new MySqlCommand(silKategori, connection);
                MySqlCommand commandTur = new MySqlCommand(silTur, connection);
                MySqlCommand commandYazar = new MySqlCommand(silYazar, connection);
                MySqlCommand commandCevirmen = new MySqlCommand(silCevirmen, connection);*/

                command.Parameters.AddWithValue("@kitapId", dataGridView1.CurrentRow.Cells["kitapId"].Value.ToString());
               /* commandYayinEvi.Parameters.AddWithValue("@yynevId", dataGridView1.CurrentRow.Cells["yynevId"].Value.ToString());
                commandKategori.Parameters.AddWithValue("@ktgrId", dataGridView1.CurrentRow.Cells["ktgrId"].Value.ToString());
                commandTur.Parameters.AddWithValue("@turId", dataGridView1.CurrentRow.Cells["turId"].Value.ToString());
                commandYazar.Parameters.AddWithValue("@yzrId", dataGridView1.CurrentRow.Cells["yzrId"].Value.ToString());
                commandCevirmen.Parameters.AddWithValue("@cvrId", dataGridView1.CurrentRow.Cells["cvrId"].Value.ToString());
               */
                command.ExecuteNonQuery();
                /*commandYayinEvi.ExecuteNonQuery();
                commandKategori.ExecuteNonQuery();
                commandTur.ExecuteNonQuery();
                commandYazar.ExecuteNonQuery();
                commandCevirmen.ExecuteNonQuery();*/

                connection.Close();
                MessageBox.Show("Silme işlemi gerçekleşti.");


                Form form = new Kitap();
                form.Show();
                this.Close();
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtkitapId.Text = dataGridView1.CurrentRow.Cells["kitapId"].Value.ToString();

            txtcilt.Text = dataGridView1.CurrentRow.Cells["cilt"].Value.ToString();
            txtKitapAd.Text = dataGridView1.CurrentRow.Cells["kitapAd"].Value.ToString();
            txtbarkod.Text = dataGridView1.CurrentRow.Cells["barkod"].Value.ToString();
            txtisbn.Text = dataGridView1.CurrentRow.Cells["ISBN"].Value.ToString();
            txtdemirbas.Text = dataGridView1.CurrentRow.Cells["demirbasNo"].Value.ToString();
            txtkitapkonusu.Text = dataGridView1.CurrentRow.Cells["konu"].Value.ToString();
            txtozet.Text = dataGridView1.CurrentRow.Cells["ozet"].Value.ToString();
            txtkitapsayfasayisi.Text = dataGridView1.CurrentRow.Cells["sayfa"].Value.ToString();
            txtstok.Text = dataGridView1.CurrentRow.Cells["stok"].Value.ToString();

            txtanahtarkelime.Text = dataGridView1.CurrentRow.Cells["anhtrK"].Value.ToString();
            txtdil.Text = dataGridView1.CurrentRow.Cells["dil"].Value.ToString();
            mskkitapyayinyili.Text = dataGridView1.CurrentRow.Cells["ynSenesi"].Value.ToString();
            mskkurumkayittarihi.Text = dataGridView1.CurrentRow.Cells["kkTarih"].Value.ToString();
            txtbasimnumara.Text = dataGridView1.CurrentRow.Cells["basimNo"].Value.ToString();
            txtcikisyili.Text = dataGridView1.CurrentRow.Cells["cikisYili"].Value.ToString();
            txtdolapkonum.Text = dataGridView1.CurrentRow.Cells["dolapNo"].Value.ToString();
            txtrafkonum.Text = dataGridView1.CurrentRow.Cells["rafNo"].Value.ToString();

            cmbyayinevi.Text = dataGridView1.CurrentRow.Cells["yynevAd"].Value.ToString();
            cmbyayinevitel.Text = dataGridView1.CurrentRow.Cells["yynevTel"].Value.ToString();

            cmbkategori.Text = dataGridView1.CurrentRow.Cells["ktgrAd"].Value.ToString();

            cmbtur.Text = dataGridView1.CurrentRow.Cells["turAd"].Value.ToString();

            cmbyazarad.Text = dataGridView1.CurrentRow.Cells["yzrAd"].Value.ToString();
            cmbyazarsoyad.Text = dataGridView1.CurrentRow.Cells["yzrSoyad"].Value.ToString();

            cmbcevirmenadi.Text = dataGridView1.CurrentRow.Cells["cvrAd"].Value.ToString();
            cmbcevirmensoyadi.Text = dataGridView1.CurrentRow.Cells["cvrSoyad"].Value.ToString();
        }

        private void cikisButon_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tureklebtn_Click(object sender, EventArgs e)
        {
            if (txttur.Text == "")
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
            if (txtyayinevi.Text == "" || msktel.Text == "")
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
            if (txtcevirmen.Text == "" || txtcevirmensoyad.Text == "")
            {
                MessageBox.Show("Çevirmen bilgileri boş");
            }
            else
            {
                connection.Open();
                string lastInsertedIdStatement = "SELECT LAST_INSERT_ID();";
                var lastInsertedCmd = new MySqlCommand(lastInsertedIdStatement, connection);
                string cevirmenEkle = "insert into Cevirmen(cvrAd,cvrSoyad) values('" + txtcevirmen.Text + "','" + txtcevirmensoyad.Text + "');";
                MySqlCommand cevirmenKomut = new MySqlCommand(cevirmenEkle, connection);
                cevirmenKomut.ExecuteNonQuery();
                int cevirmenId = int.Parse(lastInsertedCmd.ExecuteScalar().ToString());
                MessageBox.Show("Çevirmen bilgileri eklendi");
                connection.Close();
                cevirmenadi();
                cevirmensoyadi();



            }
        }

        private void cmbyazarad_TextChanged(object sender, EventArgs e)
        {
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
            string query = "select * from Yazar where yzrAd='" + cekilenAd + "'";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            if (dt.Rows.Count >= 0)
            {

                lblYazar.Text = dt.Rows[0]["yzrId"].ToString();
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

                lblidcevirmenad.Text = dt.Rows[0]["cvrId"].ToString();
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

        private void cmbcevirmensoyadi_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                string yazarekle = "insert into Yazar(yzrAd,yzrSoyad) values('" + txtyazar.Text + "','" + txtyazarsoyad.Text + "');";
                MySqlCommand yazarkomut = new MySqlCommand(yazarekle, connection);
                yazarkomut.ExecuteNonQuery();
                int yazarId = int.Parse(lastInsertedCmd.ExecuteScalar().ToString());
                MessageBox.Show("Yazar bilgileri eklendi");
                connection.Close();
                yazarAd();
                yazarSoyad();



            }
        }
    }
}
