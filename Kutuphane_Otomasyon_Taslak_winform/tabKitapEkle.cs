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


        private void tabKitapEkle_Load(object sender, EventArgs e)
        {
             connection.Open();
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
       
        private void button1_Click(object sender, EventArgs e)
        {
            string lastInsertedIdStatement = "SELECT LAST_INSERT_ID();";
            var lastInsertedCmd = new MySqlCommand(lastInsertedIdStatement, connection);

            if (txtanahtarkelime.Text == "" || txtbarkod.Text==""||txtbasimnumara.Text==""||txtcevirmen.Text==""||txtcikisyili.Text==""||txtcilt.Text==""||txtdemirbas.Text==""||txtdil.Text==""||txtisbn.Text==""||txtkategori.Text==""||txtKitapAd.Text==""||txttur.Text==""||txtkitapkonusu.Text==""||mskkurumkayittarihi.Text==""||txtozet.Text==""||txtdolapkonum.Text==""||txtkitapsayfasayisi.Text==""||txtstok.Text==""||txtyayinevi.Text==""||mskkitapyayinyili.Text==""||txtyazar.Text=="")
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

              


                string kategoriekle  = "insert into Kategori(ktgrAd) values('" + txtkategori.Text + "');";
                MySqlCommand kategorikomut = new MySqlCommand(kategoriekle, connection);
                kategorikomut.ExecuteNonQuery();
                int kategoriId = int.Parse(lastInsertedCmd.ExecuteScalar().ToString());

                string turekle = "insert into Tur(turAd) values('" + txttur.Text + "');";
                MySqlCommand turkomut = new MySqlCommand(turekle, connection);
                turkomut.ExecuteNonQuery();
                int turId = int.Parse(lastInsertedCmd.ExecuteScalar().ToString());

                string yazarekle = "insert into Yazar(yzrAd,yzrSoyad,yzrSayisi) values('"+txtyazar.Text+ "','" + txtyazarsoyad.Text+ "','" + txtyazarsayisi.Text+"');";
                MySqlCommand yazarkomut = new MySqlCommand(yazarekle, connection);
                yazarkomut.ExecuteNonQuery();
                int yazarId = int.Parse(lastInsertedCmd.ExecuteScalar().ToString());

                string yayinEviEkle = "insert into YayinEvi(yynevAd,yynevTel) values('" + txtyayinevi.Text+ "','" + msktel.Text + "');";
                MySqlCommand yayinEviKomut = new MySqlCommand(yayinEviEkle, connection);
                yayinEviKomut.ExecuteNonQuery();
                int yayinEviId = int.Parse(lastInsertedCmd.ExecuteScalar().ToString());

                string cevirmenEkle = "insert into Cevirmen(cvrAd,cvrSoyad,cvrSayisi) values('" + txtcevirmen.Text+ "','"+ txtcevirmensoyad.Text+ "','" + txtcevirmensayisi.Text + "');";
                MySqlCommand cevirmenKomut = new MySqlCommand(cevirmenEkle, connection);
                cevirmenKomut.ExecuteNonQuery();
                int cevirmenId = int.Parse(lastInsertedCmd.ExecuteScalar().ToString());

                string ekle = "insert into Kitap (ktgrId,turId,yzrId,yynevId,cvrId,barkod,ISBN,demirbasNo,kitapAd,cilt,konu,ozet,sayfa,anhtrK,dil,ynSenesi,kkTarih,basimNo,cikisYili,dolapNo,rafNo) values(@ktgrId,@turId,@yzrId,@yynevId,@cvrId,@barkod,@ISBN,@demirbasNo,@kitapAd,@cilt,@konu,@ozet,@sayfa,@anhtrK,@dil,@ynSenesi,@kkTarih,@basimNo,@cikisYili,@dolapNo,@rafNo)";
                MySqlCommand eklekomut = new MySqlCommand(ekle, connection);

                eklekomut.Parameters.AddWithValue("@ktgrId",kategoriId);

                eklekomut.Parameters.AddWithValue("@turId", turId);

                eklekomut.Parameters.AddWithValue("@yzrId", yazarId);
                eklekomut.Parameters.AddWithValue("@yynevId", yayinEviId);

                eklekomut.Parameters.AddWithValue("@cvrId", cevirmenId);
                eklekomut.Parameters.AddWithValue("@barkod", txtbarkod.Text);
                eklekomut.Parameters.AddWithValue("@ISBN",txtisbn.Text);
                eklekomut.Parameters.AddWithValue("@demirbasNo", txtdemirbas.Text);
                eklekomut.Parameters.AddWithValue("@kitapAd", txtKitapAd.Text);
                eklekomut.Parameters.AddWithValue("@cilt", txtcilt.Text);
                eklekomut.Parameters.AddWithValue("@konu", txtkitapkonusu.Text);
                eklekomut.Parameters.AddWithValue("@ozet", txtozet.Text);
                eklekomut.Parameters.AddWithValue("@sayfa", txtkitapsayfasayisi.Text);
                eklekomut.Parameters.AddWithValue("@anhtrK", txtanahtarkelime.Text);
                eklekomut.Parameters.AddWithValue("@dil", txtdil.Text);
                eklekomut.Parameters.AddWithValue("@ynSenesi", mskkitapyayinyili.Text);
                eklekomut.Parameters.AddWithValue("@kkTarih", mskkurumkayittarihi.Text);
                eklekomut.Parameters.AddWithValue("@basimNo", txtbasimnumara.Text);
                eklekomut.Parameters.AddWithValue("@cikisYili", txtcikisyili.Text);
                eklekomut.Parameters.AddWithValue("@dolapNo", txtdolapkonum.Text);
                eklekomut.Parameters.AddWithValue("@rafNo", txtrafkonum.Text);
                eklekomut.ExecuteNonQuery();


                if(txtcevirmen.Text.Length==0)
                {
                    txtcevirmen.Text = "yok";
                }

                connection.Close();
                    MessageBox.Show("kayıt başarıyla gerçekleştirildi Anasayfaya yönlendiriliyorsunuz");

                    AnaSayfa AnaSayfa = new AnaSayfa();
                   AnaSayfa.Show();
                    this.Hide();

                
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
