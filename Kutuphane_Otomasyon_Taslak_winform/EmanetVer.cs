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


        private void EmanetVer_Load(object sender, EventArgs e)
        {
            sepetlistele();
            listeleOgrenci();
            listeleKitap();

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
           /* foreach (Control item in kitapgroup.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }


            }*/


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
            string sil = "delete from sepet where kitapId=@kitapId";
            MySqlCommand command = new MySqlCommand(sil, connection);
            command.Parameters.AddWithValue("@kitapId", dataGridView1.CurrentRow.Cells["kitapId"].Value.ToString());
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Silme işlemi gerçekleşti.");
            daset.Tables["sepet"].Clear();
            sepetlistele();
        }
    }
}
