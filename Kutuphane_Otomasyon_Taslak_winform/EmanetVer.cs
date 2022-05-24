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
                /* foreach (Control item in kitapPanel.Controls)
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
            MySqlCommand komut2 = new MySqlCommand("select sum(EmanetalinanKitapSayisi)from Emanet where ogrNo='"+txtogrNo.Text+"'", connection);
            lblkayitli.Text = komut2.ExecuteScalar().ToString();
            connection.Close();


            if (txtogrNo.Text == "")
            {
                foreach (Control item in kitapPanel.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }


                }
                lblkayitli.Text = "";


            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            connection.Open();
            DialogResult dialog;
            dialog = MessageBox.Show("Bu Sepeti Boşaltmak İstiyor Musunuz?", "SİL!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        private void txtogrencinoara_TextChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from Ogrenci where ogrNo like'" + txtogrenciarama.Text + "%'", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void txtkitapadara_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtogrenciarama_TextChanged(object sender, EventArgs e)
        {
            connection.Open();

            if (cmbaramatip.Text == "Kart Id")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from Ogrenci where kartId like'" + txtogrenciarama.Text + "%'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewogrenci.DataSource = dt;


            }
            else if (cmbaramatip.Text == "Ögrenci Id")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from Ogrenci where ogrId like'" + txtogrenciarama.Text + "%'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewogrenci.DataSource = dt;


            }
            else if (cmbaramatip.Text == "Ögrenci No")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from Ogrenci where ogrNo like'" + txtogrenciarama.Text + "%'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewogrenci.DataSource = dt;


            }
            else if (cmbaramatip.Text == "Ögrenci Ad")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from Ogrenci where ogrAd like'" + txtogrenciarama.Text + "%'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewogrenci.DataSource = dt;


            }
            else if (cmbaramatip.Text == "Ögrenci Soyad")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from Ogrenci where ogrSoyad like'" + txtogrenciarama.Text + "%'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewogrenci.DataSource = dt;


            }
            else if (cmbaramatip.Text == "Cinsiyet")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from Ogrenci where cinsiyet like'" + txtogrenciarama.Text + "%'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewogrenci.DataSource = dt;


            }
            else if (cmbaramatip.Text == "Ögrenci Tel")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from Ogrenci where ogrTel like'" + txtogrenciarama.Text + "%'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewogrenci.DataSource = dt;


            }
            else if (cmbaramatip.Text == "Ögrenci Eposta")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from Ogrenci where ogrEposta like'" + txtogrenciarama.Text + "%'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewogrenci.DataSource = dt;


            }
            else if (cmbaramatip.Text == "Ögrenci Fakülte")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from Ogrenci where ogrFakulte like '" + txtogrenciarama.Text + "%'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewogrenci.DataSource = dt;


            }
            else if (cmbaramatip.Text == "Ögrenci Bölüm")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from Ogrenci where ogrBolum like '" + txtogrenciarama.Text + "%'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewogrenci.DataSource = dt;


            }
            connection.Close();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            if (cmbaramakitap.Text == "kitapId")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where kitapId like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewkitap.DataSource = dt;


            }
            else if (cmbaramakitap.Text == "ktgrId")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where ktgrId like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewkitap.DataSource = dt;


            }
            
            
            else if (cmbaramakitap.Text == "barkod")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where barkod like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewkitap.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "ISBN")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where ISBN like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewkitap.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "demirbasNo")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where demirbasNo like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewkitap.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "KitapAd")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where kitapAd like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewkitap.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "cilt")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where cilt like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewkitap.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "konu")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where konu like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewkitap.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "ozet")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where ozet like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewkitap.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "sayfa")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where sayfa like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewkitap.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "anhtrK")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where anhtrK like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewkitap.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "dil")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where dil like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewkitap.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "ynSenesi")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where ynSenesi like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewkitap.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "kkTarih")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where kktarih like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewkitap.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "basimNo")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where basimNo like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewkitap.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "cikisyili")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where cikisyili like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewkitap.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "dolapNo")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where dolapNo like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewkitap.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "rafNo")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where rafNo like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewkitap.DataSource = dt;
            }
           
            else if (cmbaramakitap.Text == "KtgrAd")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where ktgrAd like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewkitap.DataSource = dt;
            }
           
            else if (cmbaramakitap.Text == "turAd")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where turAd like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewkitap.DataSource = dt;
            }
            
            else if (cmbaramakitap.Text == "yzrAd")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where yzrAd like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewkitap.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "yzrSoyad")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where yzrSoyad like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewkitap.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "yzrSayisi")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where yzrSayisi like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewkitap.DataSource = dt;
            }
            
            else if (cmbaramakitap.Text == "yynevAd")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where yynevAd like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewkitap.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "yynevTel")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where yynevtel like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewkitap.DataSource = dt;
            }
            
            else if (cmbaramakitap.Text == "cvrAd")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where cvrAd like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewkitap.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "cvrSoyad")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where cvrSoyad like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewkitap.DataSource = dt;
            }
            else if (cmbaramakitap.Text == "cvrSayisi")
            {

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.*,Kategori.*,Tur.*,Yazar.*,YayinEvi.*,Cevirmen.* FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where cvrSayisi like '" + searchBox.Text + "%'", connection);


                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewkitap.DataSource = dt;
            }

            connection.Close();
        }

        private void cikisButon_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void simgeButon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void kaplaButon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }
        
        private void anasayfaBtn_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void emanetBtn_Click(object sender, EventArgs e)
        {
            Emanet emanet = new Emanet();
            emanet.Show();
            this.Hide();
        }

        private void ogrenciBtn_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Show();
            this.Hide();
        }

        private void kitapBtn_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.Show();
            this.Hide();
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
            this.Hide();
        }
    }
}
