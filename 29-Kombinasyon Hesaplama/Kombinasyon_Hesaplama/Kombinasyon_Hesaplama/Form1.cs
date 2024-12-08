using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kombinasyon_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int r, n, faktoriyelN=1,faktoriyelR=1,faktoriyelNR=1,sonuc;
            n = Convert.ToInt32(txtN.Text);
            r = Convert.ToInt32(txtR.Text);

            //n değeri r değerinden küçük olamayacağı için kontolünü sağlamamız gerekiyor
            if (n<r)
            {
                MessageBox.Show("n değeri r değerinden küçük olamaz");
            }

            else
            {
                //n! değerini hesaplıyoruz.
                for (int i = 1; i <= n; i++)
                {
                    faktoriyelN = faktoriyelN * i;
                }

                //(n-r)! değerini hesaplıyoruz
                for (int i = 1; i <= (n - r); i++)
                {
                    faktoriyelNR = faktoriyelNR * i;
                }

                //r! değerini hesaplıyoruz
                for (int i = 1; i <= r; i++)
                {
                    faktoriyelR = faktoriyelR * i;
                }
                sonuc = faktoriyelN / (faktoriyelNR * faktoriyelR);
                lblSonuc.Text = n + "-" + r + " kombinasyon sonucu=" + sonuc;
            }

            //textboxları temizliyoruz
            txtN.Clear();
            txtR.Clear();
        }
    }
}
