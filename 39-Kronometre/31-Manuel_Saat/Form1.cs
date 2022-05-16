using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _31_Manuel_Saat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10;
        }
        byte saat=0, saniye=0, dakika=0, salise=0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //değerleri labellara yazdır
            if (salise < 10) lblSalise.Text = "0" + salise;
            else lblSalise.Text = salise.ToString();

            if (saniye < 10) lblSaniye.Text = "0" + saniye;
            else lblSaniye.Text = saniye.ToString();

            if (dakika < 10) lblDakika.Text = "0" + dakika;
            else lblDakika.Text = dakika.ToString();

            if (saat < 10) lblSaat.Text = "0" + saat;
            else lblSaat.Text = saat.ToString();

            //kontrolleri yap
            salise++;
            if (salise>59)
            {
                saniye++;
                salise = 0;
                if (saniye>59)
                {
                    dakika++;
                    saniye = 0;
                    if (dakika>59)
                    {
                        saat++;
                        dakika = 0;
                    }
                }
            }
        }

        private void pbSifirla_Click(object sender, EventArgs e)
        {
            saat = 0;
            dakika = 0;
            saniye = 0;
            salise = 0;
        }



        private void pbDurdur_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void pbBaslat_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }


    }
}
