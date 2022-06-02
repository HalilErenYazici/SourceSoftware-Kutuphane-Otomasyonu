using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon_Taslak_winform
{
    public partial class AnaGirisEkrani : Form
    {
        public AnaGirisEkrani()
        {
            InitializeComponent();
        }

        public static string ad, soyad;

        private void GirisEkrani_Load(object sender, EventArgs e)
        {
            //txtUser.Text = "Kullanıcı Adı";
            //txtUser.ForeColor = Color.Gray;

            //txtPass.Text = "Şifre";
            //txtPass.ForeColor = Color.Gray;

            //cmbGorev.Text = "Görev Tipi Seçiniz...";
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
                txtPass.PasswordChar = '*';
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Şifre";
                txtPass.ForeColor = Color.Gray;
                txtPass.PasswordChar = '\0';
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
                ad = dataRead[3].ToString();
                soyad = dataRead[4].ToString();
                if (cmbGorev.SelectedIndex == 1)
                {
                    GorOgrenciIsleri formOgr = new GorOgrenciIsleri();
                    formOgr.Show();
                    this.Visible = false;
                }
                else
                {

                    AnaSayfa form = new AnaSayfa();
                    form.Show();
                    this.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız! Lütfen Bilgilerinizi Kontrol Ediniz", "HATA");
            }
            connection.Close();
        }
    }
}