using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringMetotlari2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBastanKarakterSil_Click(object sender, EventArgs e)
        {
            int karakter = Convert.ToInt32(txtSilinecekKarakter.Text);
            listBox1.Items.Add(richTextBox1.Text.Substring(karakter));
        }

        private void btnSoldanDoldur_Click(object sender, EventArgs e)
        {
            int toplamKarakter = Convert.ToInt32(txtToplamKarakter.Text);
            char karakter = Convert.ToChar(txtKarakter.Text);
            listBox1.Items.Add(richTextBox1.Text.PadLeft(toplamKarakter, karakter));
        }

        private void btnSagdanDoldur_Click(object sender, EventArgs e)
        {
            int toplamKarakter = Convert.ToInt32(txtToplamKarakter.Text);
            char karakter = Convert.ToChar(txtKarakter.Text);
            listBox1.Items.Add(richTextBox1.Text.PadRight(toplamKarakter, karakter));
        }

        private void btnKarakterEkle_Click(object sender, EventArgs e)
        {
            int sira = Convert.ToInt32(txtSira.Text);
            listBox1.Items.Add(richTextBox1.Text.Insert(sira, txtAraKarakter.Text));
        }

        private void btnKarakterDegistir_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(richTextBox1.Text.Replace(txtDegistirilecekKarakter.Text, txtDegisecekKarakter.Text));
        }
    }
}
