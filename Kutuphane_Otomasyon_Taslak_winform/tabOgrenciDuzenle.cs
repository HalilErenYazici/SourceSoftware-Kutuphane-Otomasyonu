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
    public partial class tabOgrenciDuzenle : Form
    {
        public tabOgrenciDuzenle()
        {
            InitializeComponent();
        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            searchBox.Clear();
        }
        static string connection_strg = "Server = 172.21.54.3; uid=sourcesoftware; pwd=Software16344158.; database=sourcesoftware";
        MySqlConnection connection = new MySqlConnection(connection_strg);
        private void tabOgrenciDuzenle_Load(object sender, EventArgs e)
        {
            ogrenciListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          connection.Open();
            string guncelle = "update Ogrenci set kartId=@kartId,ogrAd=@ogrAd,ogrSoyad=@ogrSoyad,ogrTel=@ogrTel,ogrEposta=@ogrEposta,ogrFakulte=@ogrFakulte where ogrNo=@ogrNo" + mskOgrNo.Text + "'";
             MySqlCommand command = new MySqlCommand(guncelle, connection);
            command.Parameters.AddWithValue("@ogrNo", mskOgrNo.Text);
            command.Parameters.AddWithValue("@kartId", mskKartId.Text);

            command.Parameters.AddWithValue("@ogrAd", mskKartId.Text);
            command.Parameters.AddWithValue("@ogrSoyad", mskKartId.Text);
            command.Parameters.AddWithValue("@ogrTel", mskKartId.Text);
            command.Parameters.AddWithValue("@ogrEposta", mskKartId.Text);
            command.Parameters.AddWithValue("@ogrFakulte", mskKartId.Text);
            command.ExecuteNonQuery();
            connection.Close();
           

        }

        private void mskOgrNo_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            string listele = "select * from Ogrenci where ogrNo like'"+mskOgrNo.Text+"'";
            MySqlCommand command = new MySqlCommand(listele, connection);
            MySqlDataReader read = command.ExecuteReader();
            command.ExecuteNonQuery();

            while (read.Read())
            {
                txtOgrenciAd.Text = read["ogrAd"].ToString();
                mskKartId.Text = read["kartId"].ToString();
                mskOgrNo.Text = read["ogrNo"].ToString();
                txtOgrenciSoyad.Text = read["ogrSoyad"].ToString();
                mskOgrenciTelefon.Text = read["ogrTel"].ToString();
                mskOgrenciPosta.Text = read["ogrEposta"].ToString();
                cmbFakulte.Text = read["ogrFakulte"].ToString();

            }
            connection.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mskOgrNo.Text = dataGridView1.CurrentRow.Cells["ogrNo"].Value.ToString();
        }

        DataSet daset = new DataSet();
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["uye"].Clear();
            connection.Open();
            string ara = "select * from Ogrenci where ogrNo like'%" + searchBox.Text + "%'";
            MySqlDataAdapter adtr = new MySqlDataAdapter(ara, connection);
            adtr.Fill(daset, "Ogrenci");
            dataGridView1.DataSource = daset.Tables["Ogrenci"];
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
          connection.Open();
            string sil = "delete from Ogrenci where ogrNo=@ogrNo";
            MySqlCommand command = new MySqlCommand(sil, connection);
            command.Parameters.AddWithValue("@ogrNo", dataGridView1.CurrentRow.Cells["ogrNo"].Value.ToString());
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("silme işlemi gerçekleşti");
            daset.Tables["Ogrenci"].Clear();
            ogrenciListele();
            foreach (Control item in Controls)
            {
                if(item is TextBox& item is MaskedTextBox& item is ComboBox)
                {
                    item.Text = "";
                }
            }

          
           
        }


        private void ogrenciListele()
        {
            connection.Open();
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Ogrenci", connection);
            adtr.Fill(daset, "Ogrenci");
            dataGridView1.DataSource = daset.Tables["Ogrenci"];
            connection.Close();
            daset.Tables["Ogrenci"].Clear();
            ogrenciListele();
            foreach (Control item in Controls)
            {
                if (item is TextBox & item is MaskedTextBox & item is ComboBox)
                {
                    item.Text = "";
                }
            }


            
        }



    }
}
