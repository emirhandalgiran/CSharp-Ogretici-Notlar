using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OpenFileDialogg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";//Aranacak dosya ismi 
            openFileDialog1.InitialDirectory = "D:\\";//Varsayılan olarak açılacak dosyayı belirtir
            openFileDialog1.Title = "Lütfen bir resim dosyası seçin ve Tamam a basın";
            openFileDialog1.Filter = "Resim Dosyaları(*.png;*.jpg)|*.png;*.jpg";
            openFileDialog1.ShowDialog();
            string yol = openFileDialog1.FileName;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(yol);
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";//Aranacak dosya ismi 
            openFileDialog1.InitialDirectory = "C:\\";//Varsayılan olarak açılacak dosyayı belirtir
            openFileDialog1.Title = "Lütfen bir metin dosyası seçin ve Tamam a basın";
            openFileDialog1.Filter = "Text dosyaları(*.txt)|*.txt";
            openFileDialog1.ShowDialog();
            string yol = openFileDialog1.FileName;
            FileInfo seciliDosya = new FileInfo(yol);
            StreamReader dosyaIcerik = seciliDosya.OpenText();
            textBox1.Text = dosyaIcerik.ReadToEnd();
        }
    }
}
