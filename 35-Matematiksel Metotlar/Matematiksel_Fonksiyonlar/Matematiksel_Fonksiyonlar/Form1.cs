using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematiksel_Fonksiyonlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double say1, say2, sonuc;

        private void btnAltaYuvarla_Click(object sender, EventArgs e)
        {
            say1 = Convert.ToDouble(txtSay1.Text);
            sonuc = Math.Floor(say1);
            txtSonuc.Text = sonuc.ToString();
        }

        private void btnCosinus_Click(object sender, EventArgs e)
        {
            say1 = Convert.ToDouble(txtSay1.Text);
            sonuc = Math.Cos(say1);
            txtSonuc.Text = sonuc.ToString();
        }

        private void btnSinus_Click(object sender, EventArgs e)
        {
            say1 = Convert.ToDouble(txtSay1.Text);
            sonuc = Math.Sin(say1);
            txtSonuc.Text = sonuc.ToString();
        }

        private void btnETabanLogaritma_Click(object sender, EventArgs e)
        {
            say1 = Convert.ToDouble(txtSay1.Text);
            sonuc = Math.Log(say1);
            txtSonuc.Text = sonuc.ToString();
        }

        private void btn10TabanLogaritma_Click(object sender, EventArgs e)
        {
            say1 = Convert.ToDouble(txtSay1.Text);
            sonuc = Math.Log10(say1);
            txtSonuc.Text = sonuc.ToString();
        }

        private void btnXTabanLogaritma_Click(object sender, EventArgs e)
        {
            say1 = Convert.ToDouble(txtSay1.Text);
            say2 = Convert.ToDouble(txtSay2.Text);
            sonuc = Math.Log(say1, say2);
            txtSonuc.Text = sonuc.ToString();
        }

        private void btnEnYakinTamSayi_Click(object sender, EventArgs e)
        {
            say1 = Convert.ToDouble(txtSay1.Text);
            sonuc = Math.Round(say1);
            txtSonuc.Text = sonuc.ToString();
        }

        private void btnEnBuyukSayi_Click(object sender, EventArgs e)
        {
            say1 = Convert.ToDouble(txtSay1.Text);
            say2 = Convert.ToDouble(txtSay2.Text);
            sonuc = Math.Max(say1, say2);
            txtSonuc.Text = sonuc.ToString();
        }

        private void btnEnKucukSayi_Click(object sender, EventArgs e)
        {
            say1 = Convert.ToDouble(txtSay1.Text);
            say2 = Convert.ToDouble(txtSay2.Text);
            sonuc = Math.Min(say1, say2);
            txtSonuc.Text = sonuc.ToString();
        }

        private void btnKareKok_Click(object sender, EventArgs e)
        {
            say1 = Convert.ToDouble(txtSay1.Text);
            say2 = Convert.ToDouble(txtSay2.Text);
            sonuc = Math.Sqrt(say1);
            txtSonuc.Text = sonuc.ToString();
        }

        private void btnUstAl_Click(object sender, EventArgs e)
        {
            say1 = Convert.ToDouble(txtSay1.Text);
            say2 = Convert.ToDouble(txtSay2.Text);
            sonuc = Math.Pow(say1, say2);
            txtSonuc.Text = sonuc.ToString();
        }

        private void btnUsteYuvarla_Click(object sender, EventArgs e)
        {
            say1 = Convert.ToDouble(txtSay1.Text);
            sonuc = Math.Ceiling(say1);
            txtSonuc.Text = sonuc.ToString();
        }

        private void btnMutlakDeger_Click(object sender, EventArgs e)
        {
            say1 = Convert.ToDouble(txtSay1.Text);
            sonuc = Math.Abs(say1);
            txtSonuc.Text = sonuc.ToString();
        }
    }
}
