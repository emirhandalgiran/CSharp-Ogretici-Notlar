using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sayi_Tahmin_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //randomm nesnesi oluşturulması gerekir
        Random rastgele = new Random();
        int sayi,tahmin,sayac=3;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            //1-10 arasında rastgele sayı üreteceğiz
            sayi = rastgele.Next(1, 11);
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            tahmin=Convert.ToInt32(txtSayi.Text);
            if (sayac==0)
            {
                MessageBox.Show("Hakkınız bitti\n sayı değeri="+sayi);
                sayi = rastgele.Next(1, 11);
                sayac = 3;
                lblHak.Text = "Hak=" + sayac;
            }
            else
            {
                if (sayi == tahmin)
                {
                    MessageBox.Show("Tebrikler bildin");
                    sayi = rastgele.Next(1, 11);
                    sayac = 3;
                    lblHak.Text = "Hak=" + sayac;
                    
                }
                else
                {
                    sayac--;
                    lblHak.Text = "Hak=" + sayac;
                    MessageBox.Show("Üzgünüm bilemedin");
                }
            }
            
        }
    }
}
