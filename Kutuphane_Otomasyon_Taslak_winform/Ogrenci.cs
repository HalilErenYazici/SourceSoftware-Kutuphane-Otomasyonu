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
    public partial class Ogrenci : Form
    {
        public Ogrenci()
        {
            InitializeComponent();
        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            searchBox.Clear();
        }

        private void cikisButon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
