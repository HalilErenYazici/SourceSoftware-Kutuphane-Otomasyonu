using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceSoftwareLibraryProject
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void btnEmanetAlmaVerme_Click(object sender, EventArgs e)
        {
            EmanetAlmaVermeSayfasi yeni = new EmanetAlmaVermeSayfasi();
            yeni.Show();
            this.Hide();
        }

        private void btnEmanetGoruntuleme_Click(object sender, EventArgs e)
        {
            EmanetGoruntulemeSayfasi yeni = new EmanetGoruntulemeSayfasi();
            yeni.Show();
            this.Hide();
        }

        private void btnEmegiGecenler_Click(object sender, EventArgs e)
        {
            EmegiGecenler yeni = new EmegiGecenler();
            yeni.Show();
            this.Hide();
        }

        private void btnGirisSayfasi_Click(object sender, EventArgs e)
        {
            GirisSayfasi yeni = new GirisSayfasi();
            yeni.Show();
            this.Hide();
        }

        private void btnKitapDuzenleme_Click(object sender, EventArgs e)
        {
            KitapDuzenle yeni = new KitapDuzenle();
            yeni.Show();
            this.Hide();
        }

        private void btnKitapEkleme_Click(object sender, EventArgs e)
        {
            KitapEkle yeni = new KitapEkle();
            yeni.Show();
            this.Hide();
        }

        private void btnKitapGoruntuleme_Click(object sender, EventArgs e)
        {
            KitaplariGoruntule yeni = new KitaplariGoruntule();
            yeni.Show();
            this.Hide();
        }

        private void btnOgrenciDuzenleme_Click(object sender, EventArgs e)
        {
            OgrenciDuzenleme yeni = new OgrenciDuzenleme();
            yeni.Show();
            this.Hide();
        }

        private void btnOgrenciIsleri_Click(object sender, EventArgs e)
        {
            OgrenciIsleriSayfasi yeni = new OgrenciIsleriSayfasi();
            yeni.Show();
            this.Hide();
        }

        private void btnOgrenciKayit_Click(object sender, EventArgs e)
        {
            OgrenciKayit yeni = new OgrenciKayit();
            yeni.Show();
            this.Hide();
        }
    }
}
