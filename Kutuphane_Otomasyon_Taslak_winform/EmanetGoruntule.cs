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
    public partial class EmanetGoruntule : Form
    {
        public EmanetGoruntule()
        {
            InitializeComponent();
        }

        static string connection_strg = "Server = 172.21.54.3; uid=sourcesoftware; pwd=Software16344158.; database=sourcesoftware";
        MySqlConnection connection = new MySqlConnection(connection_strg);

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void EmanetGoruntule_Load(object sender, EventArgs e)
        {
            Listele();
        }



        public void Listele()
        {
            connection.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT Emanet.*,Ogrenci.*,Kitap.* FROM Emanet RIGHT JOIN Ogrenci ON Ogrenci.ogrId = Emanet.ogrId RIGHT JOIN Kitap ON Kitap.kitapId = Emanet.kitapId;", connection);
            DataTable dt = new DataTable();
             da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
    }
}
