using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kelimeayirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAyir_Click(object sender, EventArgs e)
        { int sayac = 0;
            string[] kelimeler = richTextBox1.Text.Split(' ');
            foreach(string kelime in kelimeler)
            {
                sayac++;
                listBox1.Items.Add(sayac + "-" + kelime);
            }
        }
    }
}
