using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Kutuphane_Otomasyon_Taslak_winform
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Kullanıcı Adı")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Kullanıcı Adı";
                txtUser.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Şifre")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Şifre";
                txtPass.ForeColor = Color.Gray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand command;
            MySqlDataReader dataRead;
            string connection_strg = "Server = 172.21.54.3; uid=sourcesoftware; pwd=Software16344158.; database=sourcesoftware";
            MySqlConnection connection = new MySqlConnection(connection_strg);
            command = new MySqlCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "Select * From Personel where prsnKAd='" + txtUser.Text +
                "' And prsnSifre='" + txtPass.Text + "' And grvTipi='" + cmbGorev.Text + "'";
            dataRead = command.ExecuteReader();

            if (dataRead.Read())
            {
                AnaSayfa a = new AnaSayfa();
                AnaSayfa form = new AnaSayfa();
                form.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show(" Hatalı Giriş Yaptınız \n Lütfen Bilgilerinizi \n Kontrol Ediniz");
            }
            connection.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userImg_Click(object sender, EventArgs e)
        {

        }
    }
}