using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stringmetotlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuyukHarf_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(richTextBox1.Text.ToUpper());
        }

        private void btnKucukHarf_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(richTextBox1.Text.ToLower());
        }

        private void btnUzunluk_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(richTextBox1.Text.Length);
        }

        private void btnBasdanSondanBoslukSil_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(richTextBox1.Text.Trim());
        }

        private void btnBastanBoslukSil_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add( richTextBox1.Text.TrimStart());
        }

        private void btnSondanBoslukSil_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(richTextBox1.Text.TrimEnd());
        }

        private void btnKarakterYaz_Click(object sender, EventArgs e)
        {
            int karakterSayisi = Convert.ToInt32(txtKarakterSayisi.Text);
            listBox1.Items.Add(richTextBox1.Text.Remove(karakterSayisi));
        }

        private void btnAradanKarakterAl_Click(object sender, EventArgs e)
        {
            int sira = Convert.ToInt32(txtSira.Text);
            int karakter = Convert.ToInt32(txtYazdirKarakter.Text);
            listBox1.Items.Add(richTextBox1.Text.Remove(sira, karakter));
        }
    }
}
