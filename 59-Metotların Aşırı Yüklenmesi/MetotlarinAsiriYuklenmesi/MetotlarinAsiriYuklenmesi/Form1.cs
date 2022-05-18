using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetotlarinAsiriYuklenmesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sinav1, sinav2, performans;
            sinav1 = Convert.ToInt32(txtSinav1.Text);
            sinav2 = Convert.ToInt32(txtSinav2.Text);
            performans = Convert.ToInt32(txtPerformans.Text);
            islemler islem = new islemler();

            if (txtProje.Text=="")
            {
                MessageBox.Show("Ortalama:" + islem.hesapla(sinav1, sinav2, performans));
            }
            else
            {
                int proje = Convert.ToInt32(txtProje.Text);
                MessageBox.Show("Ortalama:" + islem.hesapla(sinav1, sinav2, performans, proje));
            }
        }
    }
}
