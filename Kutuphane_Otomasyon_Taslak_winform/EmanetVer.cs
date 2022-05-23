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
    public partial class EmanetVer : Form
    {
        public EmanetVer()
        {
            InitializeComponent();
        }

        static string connection_strg = "Server = 172.21.54.3; uid=sourcesoftware; pwd=Software16344158.; database=sourcesoftware";
        MySqlConnection connection = new MySqlConnection(connection_strg);
        DataSet daset = new DataSet();

        private void kitapsayisi()
        {
            connection.Open();
            MySqlCommand komut = new MySqlCommand("select sum(EmanetalinanKitapSayisi) from sepet", connection);
            lblkitapsayisi.Text = komut.ExecuteScalar().ToString();
            connection.Close();
        }

        private void EmanetVer_Load(object sender, EventArgs e)
        {
            sepetlistele();
            listeleOgrenci();
            listeleKitap();
            kitapsayisi();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }


        public void sepetlistele()
        {
            connection.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM sepet", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();

        }
        public void listeleOgrenci()
        {
            connection.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Ogrenci", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewogrenci.DataSource = dt;
            connection.Close();

        }
        public void listeleKitap()
        {
            connection.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId;", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewkitap.DataSource = dt;
            connection.Close();

        }

        private void SepeteEkle_Click(object sender, EventArgs e)
        {
            if (txtkitapIsbn.Text==""||txtkitapAd.Text==""|| txtKitapBarkod.Text=="" || txtkitapId.Text == "" || txtEmanetAkts.Text == "" || txtyazar.Text == "" || txtyazarsoyad.Text == "" || txtyayinevi.Text == "" || dateTimePickerveris.Text == "" || dateTimePickeralis.Text == "")
            {
                MessageBox.Show("Kitap seçiniz");
            }
            else
            {
                connection.Open();
                MySqlCommand komut = new MySqlCommand("insert into sepet(kitapId,barkod,ISBN,kitapAd,yzrAd,yzrSoyad,yynevAd,veristarihi,alistarihi,EmanetalinanKitapSayisi) values(@kitapId,@barkod,@ISBN,@kitapAd,@yzrAd,@yzrSoyad,@yynevAd,@veristarihi,@alistarihi,@EmanetalinanKitapSayisi)", connection);
                komut.Parameters.AddWithValue("@kitapId", txtkitapId.Text);
                komut.Parameters.AddWithValue("@barkod", txtKitapBarkod.Text);
                komut.Parameters.AddWithValue("@ISBN", txtkitapIsbn.Text);
                komut.Parameters.AddWithValue("@kitapAd", txtkitapAd.Text);
                komut.Parameters.AddWithValue("@yzrAd", txtyazar.Text);
                komut.Parameters.AddWithValue("@yzrSoyad", txtyazarsoyad.Text);
                komut.Parameters.AddWithValue("@yynevAd", txtyayinevi.Text);
                komut.Parameters.AddWithValue("@veristarihi", dateTimePickerveris.Text);
                komut.Parameters.AddWithValue("@alistarihi", dateTimePickeralis.Text);
                komut.Parameters.AddWithValue("@EmanetalinanKitapSayisi", int.Parse(txtEmanetAkts.Text));
                komut.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Kitap(lar) sepete eklendi", "Ekleme İşlemi");
                sepetlistele();
                lblkitapsayisi.Text = "";
                kitapsayisi();
                /* foreach (Control item in kitapgroup.Controls)
                 {
                     if(item is TextBox)
                     {
                         item.Text = "";
                     }


                 }*/
            }



        }

        private void dataGridViewkitap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtkitapId.Text = dataGridViewkitap.CurrentRow.Cells["kitapId"].Value.ToString();
            txtKitapBarkod.Text = dataGridViewkitap.CurrentRow.Cells["barkod"].Value.ToString();
            txtkitapIsbn.Text = dataGridViewkitap.CurrentRow.Cells["ISBN"].Value.ToString();
            txtkitapAd.Text = dataGridViewkitap.CurrentRow.Cells["kitapAd"].Value.ToString();
            txtyazar.Text = dataGridViewkitap.CurrentRow.Cells["yzrAd"].Value.ToString();
            txtyazarsoyad.Text = dataGridViewkitap.CurrentRow.Cells["yzrSoyad"].Value.ToString();
            txtyayinevi.Text = dataGridViewkitap.CurrentRow.Cells["yynevAd"].Value.ToString();



        }

        private void dataGridViewogrenci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtogrID.Text = dataGridViewogrenci.CurrentRow.Cells["ogrId"].Value.ToString();
            txtogrNo.Text = dataGridViewogrenci.CurrentRow.Cells["ogrNo"].Value.ToString();
            txtOgrAd.Text = dataGridViewogrenci.CurrentRow.Cells["ogrAd"].Value.ToString();
            txtOgrSoyad.Text = dataGridViewogrenci.CurrentRow.Cells["ogrSoyad"].Value.ToString();
            mskOgrenciPosta.Text = dataGridViewogrenci.CurrentRow.Cells["ogrEposta"].Value.ToString();
            mskOgrenciTelefon.Text = dataGridViewogrenci.CurrentRow.Cells["ogrTel"].Value.ToString();


            txtogrID.Enabled = false;
            txtOgrAd.Enabled = false;
            txtogrNo.Enabled = false;
            txtOgrSoyad.Enabled = false;
        }

        private void txtogrNo_TextChanged(object sender, EventArgs e)
        {

            connection.Open();
            MySqlCommand komut2 = new MySqlCommand("select sum(EmanetalinanKitapSayisi)from Emanet", connection);
            lblkayitli.Text = komut2.ExecuteScalar().ToString();
            connection.Close();


            if (txtogrNo.Text == "")
            {
                foreach (Control item in kitapgroup.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                        lblkayitli.Text = "";
                    }


                }

            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sil = "delete from sepet where kitapId='"+dataGridView1.CurrentRow.Cells["kitapId"].Value.ToString()+"'";
            MySqlCommand command = new MySqlCommand(sil, connection);
          
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Silme işlemi gerçekleşti.");
          //  daset.Tables["sepet"].Clear();
            sepetlistele();
            lblkitapsayisi.Text = "";
            kitapsayisi();

        }

        private void btnemanetver_Click(object sender, EventArgs e)
        {
            if (lblkitapsayisi.Text != "")
            {

                if (lblkayitli.Text==""&&int.Parse(lblkitapsayisi.Text)<=3||lblkayitli.Text!=""&&int.Parse(lblkayitli.Text)+int.Parse(lblkitapsayisi.Text)<=3)
                {
                    if (txtogrID.Text != "" && txtogrNo.Text!=""&&txtOgrAd.Text != "" &&txtOgrSoyad.Text!=""&&mskOgrenciPosta.Text!=""&&mskOgrenciTelefon.Text!="")
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                        {
                            connection.Open();
                            MySqlCommand komut = new MySqlCommand("insert into Emanet(ogrId,ogrNo,ogrAd,ogrSoyad,ogrEposta,ogrTel,kitapId,barkod,ISBN,kitapAd,yzrAd,yzrSoyad,yynevAd,veristarihi,alistarihi,EmanetalinanKitapSayisi) values(@ogrId,@ogrNo,@ogrAd,@ogrSoyad,@ogrEposta,@ogrTel,@kitapId,@barkod,@ISBN,@kitapAd,@yzrAd,@yzrSoyad,@yynevAd,@veristarihi,@alistarihi,@EmanetalinanKitapSayisi)", connection);
                            komut.Parameters.AddWithValue("@ogrId", txtogrID.Text);
                            komut.Parameters.AddWithValue("@ogrNo", txtogrNo.Text);
                            komut.Parameters.AddWithValue("@ogrAd", txtOgrAd.Text);
                            komut.Parameters.AddWithValue("@ogrSoyad", txtOgrSoyad.Text);
                            komut.Parameters.AddWithValue("@ogrEposta", mskOgrenciPosta.Text);
                            komut.Parameters.AddWithValue("@ogrTel", mskOgrenciTelefon.Text);
                            komut.Parameters.AddWithValue("@kitapId", dataGridView1.Rows[i].Cells["kitapId"].Value.ToString());
                            komut.Parameters.AddWithValue("@barkod", dataGridView1.Rows[i].Cells["barkod"].Value.ToString());
                            komut.Parameters.AddWithValue("@ISBN", dataGridView1.Rows[i].Cells["ISBN"].Value.ToString());
                            komut.Parameters.AddWithValue("@kitapAd", dataGridView1.Rows[i].Cells["kitapAd"].Value.ToString());
                            komut.Parameters.AddWithValue("@yzrAd", dataGridView1.Rows[i].Cells["yzrAd"].Value.ToString());
                            komut.Parameters.AddWithValue("@yzrSoyad", dataGridView1.Rows[i].Cells["yzrSoyad"].Value.ToString());
                            komut.Parameters.AddWithValue("@yynevAd", dataGridView1.Rows[i].Cells["yynevAd"].Value.ToString());
                            komut.Parameters.AddWithValue("@veristarihi", dataGridView1.Rows[i].Cells["veristarihi"].Value.ToString());
                            komut.Parameters.AddWithValue("@alistarihi", dataGridView1.Rows[i].Cells["alistarihi"].Value.ToString());
                            komut.Parameters.AddWithValue("@EmanetalinanKitapSayisi", int.Parse(dataGridView1.Rows[i].Cells["EmanetalinanKitapSayisi"].Value.ToString()));
                            komut.ExecuteNonQuery();
                            MySqlCommand komut2 = new MySqlCommand("update Ogrenci set okuduguKitapSayisi=okuduguKitapSayisi+'"+int.Parse(dataGridView1.Rows[i].Cells["EmanetalinanKitapSayisi"].Value.ToString())+ "' where ogrId='" + txtogrID.Text+"'", connection);
                            komut2.ExecuteNonQuery();
                            MySqlCommand komut3 = new MySqlCommand("update Kitap set stok=stok-'" + int.Parse(dataGridView1.Rows[i].Cells["EmanetalinanKitapSayisi"].Value.ToString()) + "' where kitapId='" + dataGridView1.Rows[i].Cells["kitapId"].Value.ToString() + "'", connection);
                            komut3.ExecuteNonQuery();
                            connection.Close();
                
                          





                        }
                        connection.Open();
                        MySqlCommand komut4 = new MySqlCommand("delete from sepet", connection);
                        komut4.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("kitap(lar) emanet edildi");
                        sepetlistele();
                        txtogrID.Text = "";
                        txtkitapId.Text = "";
                        lblkayitli.Text = "";
                        lblkitapsayisi.Text = "";
                        kitapsayisi();
                    }
                    else
                    {
                        MessageBox.Show("Önce üye ismi seçmeniz gerekir!!!", "Uyarı");
                    }

                   
                }
                else
                {
                    MessageBox.Show("Emanet kkitap sayısı 3 ten fazla olamaz!!!","Uyarı");
                }



               
            }
            else
            {
                MessageBox.Show("Önce sepete kitap eklenmelidir", "Uyarı");

            }



           
        }



    }
}
