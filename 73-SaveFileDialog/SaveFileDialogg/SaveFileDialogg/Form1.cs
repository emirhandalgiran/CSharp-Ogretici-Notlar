using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveFileDialogg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Metin Dosyası Kaydet";
            saveFileDialog1.FileName = "isimsiz";
            saveFileDialog1.Filter = "txt dosyası(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("Dosya kaydedildi");
            }
            else
            {
                MessageBox.Show("Kayıt işlemi iptal edildi");
            }
        }
    }
}
