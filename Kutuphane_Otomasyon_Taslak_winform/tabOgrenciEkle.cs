﻿using System;
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
    public partial class tabOgrenciEkle : Form
    {
        public tabOgrenciEkle()
        {
            InitializeComponent();
        }

        private void anasayfaBtn_Click(object sender, EventArgs e)
        {
            Form form = new AnaSayfa();
            form.Show();
            this.Close();
        }

        private void emanetBtn_Click(object sender, EventArgs e)
        {
            Form form = new Emanet();
            form.Show();
            this.Close();
        }

        private void ogrenciBtn_Click(object sender, EventArgs e)
        {
            Form form = new Ogrenci();
            form.Show();
            this.Close();
        }

        private void kitapBtn_Click(object sender, EventArgs e)
        {
            Form form = new Kitap();
            form.Show();
            this.Close();
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            Form form = new Info();
            form.Show();
            this.Close();
        }

        private void cikisButon_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void txtOgrenciBolum_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFakulte.Text == "İnegöl İşletme Fakültesi")
            {
              
                cmbisletme.Visible = true;
                cmbmyo.Visible = false;
                label4.Visible = true;


            }

            else if (cmbFakulte.Text == "İnegöl MYO")
            {

                cmbmyo.Visible = true;
                cmbisletme.Visible = false;
                label4.Visible = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtOgrenciNo.Text == "" ||txtOgrenciAd.Text == "" || txtOgrenciSoyad.Text == "" || mskOgrenciTelefon.Text == "")
            {
                
                
                if (txtOgrenciNo.Text.Length != 9)
                {
                    MessageBox.Show("Öğrenci numarası 9 hanenin altında olamaz!");
                }
                 if (txtOgrenciAd.Text.Length < 2)
                {
                    MessageBox.Show("Adınızı giriniz!");
                }
                 if (txtOgrenciSoyad.Text.Length < 2)
                {
                    MessageBox.Show("Soyadınızı giriniz!");
                }

                 if (mskOgrenciTelefon.Text.Length != 14)
                {
                    MessageBox.Show("Telefon numarası 11 hanenin altında olamaz!");
                }
                 if (mskOgrenciPosta.Text == "")
                {
                    MessageBox.Show("Lütfen geçerli bir E-Posta giriniz");
                }



                 if (cmbFakulte.Text == "")
                {
                    MessageBox.Show("Bölüm seçiniz");
                }
                if (radioErkek.Checked)
                {

                    label1.Text = "Cinsiyet" + radioErkek.Text;
                    label1.Visible = true;

                }
                else if (radioKadin.Checked)
                {

                    label1.Text = "Cinsiyet" + radioKadin.Text;
                    label1.Visible = true;
                }
                else
                {
                    MessageBox.Show("Lüften cinsiyet seçiniz!");

                }

             
            }
                else
            {
               
                MessageBox.Show("Kayıt başarıyla gerçekleştirildi, anasayfaya yönlendiriliyorsunuz");

                AnaSayfa yeni = new AnaSayfa();
                yeni.Show();
                this.Hide();
            }
        }
    }
}