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

namespace Kutuphane_Otomasyon_Taslak
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        //public static MySqlConnection baglanti = new MySqlConnection("Server=http://172.21.54.3; Database=sourcesoftware; Uid=root; Pwd=Sql-1.;");

        //public static void veritabani_baglantisi() // Veritabanı bağlantısını açmak için ayrı bir metot oluşturdum
        //{
        //    try // Bağlantıda sorun oluşması durumunda hatanın ne olduğunu öğrenebilmek için try-catch kullandım
        //    {
        //        baglanti.Open();
        //    }
        //    catch (Exception err)
        //    {
        //        MessageBox.Show(err.Message); //Bağlantıyı açarken hata oluşursa, ayrıntılı bir şekilde bunu görebileyim
        //    }
        //}

        //bool giris_dogrulama(string kAdi, string sifre) //Girişi doğrulamak için ayrı bir metot oluşturdum, geriye bool tipi değer döndürecek
        //{
        //    veritabani_baglantisi(); //veritabani_baglantisi metotunu çağırarak veritabanına bağlantıyı açtım
        //    MySqlCommand cmd = new MySqlCommand(); //Veritabanına göndereceğim sorguyu tutabilmesi için nesne oluşturdum
        //    //NOT: MySqlCommand veritabanı üzerinde sorgulama, ekleme, güncelleme, silme işlemlerini yapmak için kullanılır
        //    cmd.CommandText = "SELECT * FROM Personel WHERE prsnKAd=@kAdi AND prsnSifre=@sifre"; //Nesnenin içine sorgumu yazdım
        //    cmd.Parameters.AddWithValue("@kAdi", kAdi); //textboxlara girilen değerleri, parametrelere aktardım
        //    cmd.Parameters.AddWithValue("@sifre", sifre); //Not: Parametre kullanarak injection'a karşı önlem alıyorum
        //    cmd.Connection = baglanti; //Komutu veritabanına yolladım
        //    MySqlDataReader login = cmd.ExecuteReader(); //MySqlDataReader'ı, yolladığım komuttan dönen değerleri satır satır okuması için kullandım
        //    if (login.Read()) //Read metodu geriye bool türünde değer döndürür
        //    {
        //        baglanti.Close();
        //        return true; //Okunacak satır var ise true değer döndürür
        //    }
        //    else
        //    {
        //        baglanti.Close();
        //        return false; // Okunacak değer yoksa da false değeri döndürür
        //    }
        //}

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void bunifuGradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        Anasayfa a = new Anasayfa();
        private void bunifuThinButton1_Click(object sender, EventArgs e)
        {
            //{
            //    string kAdi = txtUser.Text; //textboxtaki değerleri string değişkenlere atadım
            //    string sifre = txtPass.Text;
            //    if (kAdi == "" || sifre == "") //Eğer textboxlardan biri boşsa beni uyarsın ve işlem yapmasın
            //    {
            //        MessageBox.Show("Lütfen tüm alanları doldurun");
            //        return;
            //    }
            //    bool a = giris_dogrulama(kAdi, sifre); //giris_dogrulama metotuna giriş bilgilerini yolladım ve bool tipinde bir değer elde ettim
            //    if (a) //Dönen değer true ise yani bilgiler veritabanındaki kayıtlarda mevcutsa if kod bloğu çalışsın
            //    {
            //        MessageBox.Show("Giriş Doğrulandı.");
            //        //Not: Bu if bloğuna giriş doğrulandığında gerçekleşmisini istediğiniz kodları yazabilirsiniz
            //    }
            //    else //Dönen değer true değilse yani false ise bu kod bloğu çalışsın
            //        MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!");
            //}


            if (txtUser.Text == "" || txtPass.Text == "" || txtUser.Text == String.Empty || txtPass.Text == String.Empty
)
            {
                MessageBox.Show("Kullanıcı Adı ve Parola boş bırakılamaz.", "Boş Alan Hatası!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                this.Hide();
                a.ShowDialog();
            }
        }
    }
}
