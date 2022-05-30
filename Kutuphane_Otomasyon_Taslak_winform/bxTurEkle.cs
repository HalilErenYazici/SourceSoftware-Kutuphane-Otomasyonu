using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon_Taslak_winform
{
    public partial class bxTurEkle : Form
    {
        public bxTurEkle()
        {
            InitializeComponent();
        }

        static string connection_strg = "Server = 172.21.54.3; uid=sourcesoftware; pwd=Software16344158.; database=sourcesoftware";
        MySqlConnection connection = new MySqlConnection(connection_strg);

        tabKitapEkle form = new tabKitapEkle();
        public void turEkle()
        {
            form.cmbtur.Items.Clear();
            MySqlDataReader oku;
            connection.Open();
            MySqlCommand komut = new MySqlCommand();
            komut.Connection = connection;
            komut.CommandText = "Select * from Tur";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                form.cmbtur.Items.Add(oku[1].ToString());
            }
            connection.Close();
        }

        public void tureklebtn_Click(object sender, EventArgs e)
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

    }
}