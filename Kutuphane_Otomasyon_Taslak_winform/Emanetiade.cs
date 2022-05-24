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
    public partial class Emanetiade : Form
    {
        public Emanetiade()
        {
            InitializeComponent();
        }
        static string connection_strg = "Server = 172.21.54.3; uid=sourcesoftware; pwd=Software16344158.; database=sourcesoftware";
        MySqlConnection connection = new MySqlConnection(connection_strg);
        DataSet daset = new DataSet();
        
        private void Emanetiade_Load(object sender, EventArgs e)
        {
            emanetlistele();
        }

        public void emanetlistele() {

            connection.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Emanet", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewemanet.DataSource = dt;
            connection.Close();

        }
        private void searchBox_TextChanged(object sender, EventArgs e)
        { connection.Open();
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where ogrNo like'%" + searchBox.Text + "%'", connection);
            DataTable dt = new DataTable();
            adtr.Fill(dt);
            dataGridViewemanet.DataSource = dt;
            connection.Close();
            if (searchBox.Text=="")
            {
                daset.Tables["Emanet"].Clear();
                emanetlistele();
                
            }



        }

        private void searchboxkitap_TextChanged(object sender, EventArgs e)
        {   
            connection.Open();
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Emanet where kitapAd like'%" + searchboxkitap.Text + "%'", connection);
            DataTable dt = new DataTable();
            adtr.Fill(dt);
            dataGridViewemanet.DataSource = dt;
            connection.Close();
            if (searchboxkitap.Text == "")
            {
                daset.Tables["Emanet"].Clear();
                emanetlistele();

            }
        }

        private void btnemanetkaldir_Click(object sender, EventArgs e)
        {
            connection.Open();
            

            DialogResult dialog;
            dialog = MessageBox.Show("Bu Kaydı Silmek İstiyor Musunuz?", "SİL!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            string sil = "delete from Emanet where ogrNo=@ogrNo and kitapAd=@kitapAd";
            MySqlCommand command = new MySqlCommand(sil, connection);
            command.Parameters.AddWithValue("@ogrNo", dataGridViewemanet.CurrentRow.Cells["ogrNo"].Value.ToString());
            command.Parameters.AddWithValue("@kitapAd", dataGridViewemanet.CurrentRow.Cells["kitapAd"].Value.ToString());

            command.ExecuteNonQuery();
            MessageBox.Show("Silme işlemi gerçekleşti.");
            MySqlCommand komut2 = new MySqlCommand("update Kitap set stok=stok+'" + dataGridViewemanet.CurrentRow.Cells["EmanetalinanKitapSayisi"].Value.ToString() + "' where kitapId=@kitapId", connection);
            komut2.Parameters.AddWithValue("@kitapId", dataGridViewemanet.CurrentRow.Cells["kitapId"].Value.ToString());
            komut2.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Kitap(lar) iade edildi!");

            daset.Tables["Emanet"].Clear();
            emanetlistele();

        }
    }
}
