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
    public partial class Grafikler : Form
    {
        public Grafikler()
        {
            InitializeComponent();
        }
        static string connection_strg = "Server = 172.21.54.3; uid=sourcesoftware; pwd=Software16344158.; database=sourcesoftware";
        MySqlConnection connection = new MySqlConnection(connection_strg);
        private void Grafikler_Load(object sender, EventArgs e)
        {
            encokokuyanogrenci();
        }
        private void encokokuyanogrenci()
        {
            connection.Open();
            MySqlCommand komut = new MySqlCommand("Select ogrAd,ogrSoyad,okuduguKitapSayisi from Ogrenci", connection);
            MySqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                chart1.Series["En çok kitap okuyan öğrenci"].Points.AddXY(read["ogrAd"].ToString() + " " + read["ogrSoyad"].ToString(), read["okuduguKitapSayisi"]);



                // chart2.Series["En çok kitap okuyan öğrenci"].Points.AddXY(read["ogrAd"].ToString() + " " + read["ogrSoyad"].ToString(), read["okuduguKitapSayisi"]);



            }
            
            connection.Close();
            chart1.Series["En çok kitap okuyan öğrenci"].Color = Color.Orange;
        }
        private void cikisButon_Click(object sender, EventArgs e)
        {

        }
    }
}
