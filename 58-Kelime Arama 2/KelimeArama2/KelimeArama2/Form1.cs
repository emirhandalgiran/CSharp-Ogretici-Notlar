using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeArama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.IndexOf(txtAra.Text) == 0)
            {
                listBox1.Items.Add("Aranacak değer belirtilmedi");
            }
            else if (richTextBox1.Text.IndexOf(txtAra.Text) == -1)
            {
                listBox1.Items.Add(txtAra.Text + " bulunamadı");
            }
            else
            {
                int sayac = 0;
                string[] kelimeler = richTextBox1.Text.Split(' ');
                foreach(var kelime in kelimeler)
                {
                    if (kelime == txtAra.Text)
                    {
                        sayac++;
                    }
                }
                listBox1.Items.Add(txtAra.Text + " kelimesi " + sayac + " tane bulundu.");



            }
        }
    }
}
