using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faktoriytel_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi, faktoriyel = 1;
            sayi = Convert.ToInt32(txtSayi.Text);
            if (sayi<=0)
            {
                MessageBox.Show("Lütfen pozitif bir değer girin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //faktoriyel hesaplamak için sayı değerine kadar olan sayılar birbiriyle çarpılır
                for (int i = 1; i <= sayi; i++)
                {
                    faktoriyel = faktoriyel * i;
                }
                lblSonuc.Text = sayi + "!=" + faktoriyel;
            }
            txtSayi.Clear();
        }
    }
}
