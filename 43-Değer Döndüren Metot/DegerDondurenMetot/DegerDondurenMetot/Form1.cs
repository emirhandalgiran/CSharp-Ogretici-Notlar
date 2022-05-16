using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DegerDondurenMetot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       //Parametresiz değer döndüren metot
        int carp()
        {
            int a, b;
            a = 5;
            b = 8;
            return a * b;
        }

        //Parametreli değer döndüren metot
         int topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        string yazdir()
        {
            return "Merhaba 11A";
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            
            label1.Text = carp().ToString();
            label2.Text = "Toplam Sonuç=" + topla(109, 55);
            label3.Text = "Toplam Sonuç=" + topla(4, 9);
            label4.Text = yazdir();
        }
    }
}
