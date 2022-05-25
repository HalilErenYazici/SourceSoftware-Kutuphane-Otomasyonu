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

        private void tabKitapDuzenle_Load(object sender, EventArgs e)
        {
            Listele();
        }

        public void Listele()
        {
            connection.Open();

           // MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Kitap, Kategori, Tur, Yazar, YayinEvi, Cevirmen", connection);
           // MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.*,Yazar.*, FROM Kitap RIGHT JOIN Yazar ON Yazar.yzrId=Kitap.yzrId AND RIGHT JOIN Kategori ON Kategori.ktgrId=Kitap.ktgrId AND RIGHT JOIN Tur ON Tur.turId=Kitap.turId AND RIGHT JOIN YayinEvi ON YayinEvi.yynevId=Kitap.yynevId AND RIGHT JOIN Cevirmen ON Cevirmen.cvrId=Kitap.cvrId", connection);
           MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId;", connection);
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
                connection.Open();
           


           
           
            MySqlCommand command = new MySqlCommand("update Kitap set kitapId=@kitapId,barkod=@barkod,ISBN=@ISBN,demirbasNo=@demirbasNo,kitapAd=@kitapAd,cilt=@cilt,konu=@konu,ozet=@ozet,sayfa=@sayfa,stok=@stok,anhtrK=@anhtrK,dil=@dil,ynSenesi=@ynSenesi,kkTarih=@kkTarih,basimNo=@basimNo,cikisYili=@cikisYili,dolapNo=@dolapNo,rafNo=@rafNo where kitapId=@kitapId", connection);
            MySqlCommand commandYayinEvi = new MySqlCommand("update YayinEvi set yynevAd=@yynevAd, yynevTel=@yynevTel", connection);
            MySqlCommand commandKategori = new MySqlCommand("update Kategori set ktgrAd=@ktgrAd", connection);
            MySqlCommand commandTur = new MySqlCommand("update Tur set turAd=@turAd", connection);
            MySqlCommand commandYazar = new MySqlCommand("update Yazar set yzrAd=@yzrAd, yzrSoyad=@yzrSoyad, yzrSayisi=@yzrSayisi", connection);
            MySqlCommand commandCevirmen = new MySqlCommand("update Cevirmen set cvrAd=@cvrAd, cvrSoyad=@cvrSoyad, cvrSayisi=@cvrSayisi", connection);

            command.Parameters.AddWithValue("@kitapId", txtkitapId.Text);

            command.Parameters.AddWithValue("@barkod", txtbarkod.Text);
            command.Parameters.AddWithValue("@ISBN", txtisbn.Text);
            command.Parameters.AddWithValue("@demirbasNo",txtdemirbas.Text);
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

            commandYayinEvi.Parameters.AddWithValue("@yynevAd", txtyayinevi.Text);
            commandYayinEvi.Parameters.AddWithValue("@yynevTel", msktel.Text);

            commandKategori.Parameters.AddWithValue("@ktgrAd", txtkategori.Text);


            commandTur.Parameters.AddWithValue("@turAd", txttur.Text);
        
            commandYazar.Parameters.AddWithValue("@yzrAd", txtyazar.Text);
            commandYazar.Parameters.AddWithValue("@yzrSoyad", txtyazarsoyad.Text);
            commandYazar.Parameters.AddWithValue("@yzrSayisi", txtyazarsayisi.Text);

            commandCevirmen.Parameters.AddWithValue("@cvrAd", txtcevirmen.Text);
            commandCevirmen.Parameters.AddWithValue("@cvrSoyad", txtcevirmensoyad.Text);
            commandCevirmen.Parameters.AddWithValue("@cvrSayisi", txtcevirmensayisi.Text);






            command.ExecuteNonQuery();
            commandYayinEvi.ExecuteNonQuery();
            commandKategori.ExecuteNonQuery();
            commandTur.ExecuteNonQuery();
            commandCevirmen.ExecuteNonQuery();

            ;

            connection.Close();

            Form form = new Kitap();
            form.Show();
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            DialogResult dialog;
            dialog = MessageBox.Show("Bu Kaydı Silmek İstiyor Musunuz?", "SİL!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            string sil = "delete from Kitap where kitapId=@kitapId";
            string silYayinEvi = "delete from YayinEvi where yynevId=@yynevId";
            string silKategori = "delete from Kategori where ktgrId=@ktgrId";
            string silTur = "delete from Tur where turId=@turId";
            string silYazar = "delete from Yazar where yzrId=@yzrId";
            string silCevirmen = "delete from Cevirmen where cvrId=@cvrId";

            MySqlCommand command = new MySqlCommand(sil, connection);
            MySqlCommand commandYayinEvi = new MySqlCommand(silYayinEvi, connection);
            MySqlCommand commandKategori = new MySqlCommand(silKategori, connection);
            MySqlCommand commandTur = new MySqlCommand(silTur, connection);
            MySqlCommand commandYazar = new MySqlCommand(silYazar, connection);
            MySqlCommand commandCevirmen = new MySqlCommand(silCevirmen, connection);

            command.Parameters.AddWithValue("@kitapId", dataGridView1.CurrentRow.Cells["kitapId"].Value.ToString());
            commandYayinEvi.Parameters.AddWithValue("@yynevId", dataGridView1.CurrentRow.Cells["yynevId"].Value.ToString());
            commandKategori.Parameters.AddWithValue("@ktgrId", dataGridView1.CurrentRow.Cells["ktgrId"].Value.ToString());
            commandTur.Parameters.AddWithValue("@turId", dataGridView1.CurrentRow.Cells["turId"].Value.ToString());
            commandYazar.Parameters.AddWithValue("@yzrId", dataGridView1.CurrentRow.Cells["yzrId"].Value.ToString());
            commandCevirmen.Parameters.AddWithValue("@cvrId", dataGridView1.CurrentRow.Cells["cvrId"].Value.ToString());

            command.ExecuteNonQuery();
            commandYayinEvi.ExecuteNonQuery();
            commandKategori.ExecuteNonQuery();
            commandTur.ExecuteNonQuery();
            commandYazar.ExecuteNonQuery();
            commandCevirmen.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Silme işlemi gerçekleşti.");


            Form form = new Kitap();
            form.Show();
            this.Close();
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

            txtyayinevi.Text = dataGridView1.CurrentRow.Cells["yynevAd"].Value.ToString();
            msktel.Text = dataGridView1.CurrentRow.Cells["yynevTel"].Value.ToString();

            txtkategori.Text = dataGridView1.CurrentRow.Cells["ktgrAd"].Value.ToString();

            txttur.Text = dataGridView1.CurrentRow.Cells["turAd"].Value.ToString();

            txtyazar.Text = dataGridView1.CurrentRow.Cells["yzrAd"].Value.ToString();
            txtyazarsoyad.Text = dataGridView1.CurrentRow.Cells["yzrSoyad"].Value.ToString();
            txtyazarsayisi.Text = dataGridView1.CurrentRow.Cells["yzrSayisi"].Value.ToString();

            txtcevirmen.Text = dataGridView1.CurrentRow.Cells["cvrAd"].Value.ToString();
            txtcevirmensoyad.Text = dataGridView1.CurrentRow.Cells["cvrSoyad"].Value.ToString();
            txtcevirmensayisi.Text = dataGridView1.CurrentRow.Cells["cvrSayisi"].Value.ToString();
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
    }
}
