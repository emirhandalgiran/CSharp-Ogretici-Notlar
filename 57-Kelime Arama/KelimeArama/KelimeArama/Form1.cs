using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeArama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.IndexOf(txtAra.Text)==0)
            {
                listBox1.Items.Add("Aranacak metin girilmedi");
            }
            else if (richTextBox1.Text.IndexOf(txtAra.Text)==-1)
            {
                listBox1.Items.Add(txtAra.Text + " kelimesi bulunamadı");
            }
            else
            {
                listBox1.Items.Add(txtAra.Text + " kelimesi bulundu. Konumu=" + richTextBox1.Text.IndexOf(txtAra.Text));
            }
        }
    }
}
