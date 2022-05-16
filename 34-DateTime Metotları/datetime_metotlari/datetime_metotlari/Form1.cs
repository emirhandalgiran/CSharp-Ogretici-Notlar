using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datetime_metotlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSimdiGoster_Click(object sender, EventArgs e)
        {
            lstGoster.Items.Add("Şuanın Tarih ve Saati: "+DateTime.Now);
        }

        private void btnUzunTarih_Click(object sender, EventArgs e)
        {
            lstGoster.Items.Add("Uzun Tarih Formatı: "+ DateTime.Now.ToLongDateString());
        }

        private void btnKisaTarih_Click(object sender, EventArgs e)
        {
            lstGoster.Items.Add("Kısa Tarih Formatı: " + DateTime.Now.ToShortDateString());
        }

        private void btnUzunZaman_Click(object sender, EventArgs e)
        {
            lstGoster.Items.Add("Uzun Zaman Formatı: " + DateTime.Now.ToLongTimeString());
        }

        private void btnKısaZaman_Click(object sender, EventArgs e)
        {
            lstGoster.Items.Add("Kısa Zaman Formatı: " + DateTime.Now.ToShortTimeString());
        }

        private void btnYilinGunu_Click(object sender, EventArgs e)
        {
            lstGoster.Items.Add("Yılın Kaçıncı Günü: " + DateTime.Now.DayOfYear);
        }

        private void btnDakika_Click(object sender, EventArgs e)
        {
            lstGoster.Items.Add("Şuanın Dakikası: " + DateTime.Now.Minute);
        }

        private void btnSaat_Click(object sender, EventArgs e)
        {
            lstGoster.Items.Add("Şuanın Saati: " + DateTime.Now.Hour);
        }

        private void btnSaniye_Click(object sender, EventArgs e)
        {
            lstGoster.Items.Add("Şuanın Saniyesi: " + DateTime.Now.Second);
        }

        private void btnhaftaninGunu_Click(object sender, EventArgs e)
        {
            lstGoster.Items.Add("Haftanın Günü: " + DateTime.Now.DayOfWeek);
        }

        private void btnyil_Click(object sender, EventArgs e)
        {
            lstGoster.Items.Add("Yıl : " + DateTime.Now.Year);
        }

        private void btnGun_Click(object sender, EventArgs e)
        {
            lstGoster.Items.Add("Gün: " + DateTime.Now.Day);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int yil = Convert.ToInt32(txtYil.Text);
            lstGoster.Items.Add("Şuanki yıla " + yil + " eklendi: " + DateTime.Now.AddYears(yil));
        }
    }
}
