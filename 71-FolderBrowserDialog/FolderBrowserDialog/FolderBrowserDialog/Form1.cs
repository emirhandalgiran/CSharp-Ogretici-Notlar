using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//projeye DirectoryInfo için ekledik

namespace FolderBrowserDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnKlasorSec_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Listelencek Klasörü Seçin";//Açıklama yazdık
            folderBrowserDialog1.SelectedPath = "C:\\";//Varsayılan yolu belirttik
            if (folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                string seciliKlasor = folderBrowserDialog1.SelectedPath;//seçtiğimiz klasörün bağlantısını değişkene kopyaladık.
                DirectoryInfo klasorBilgisi = new DirectoryInfo(seciliKlasor);//Seçili klasörün bilgisi
                FileInfo[] dosyalar = klasorBilgisi.GetFiles();//Seçili klasör içerisindeki dosyalar
                foreach (FileInfo dosya in dosyalar)
                {
                    listBox1.Items.Add(dosya);
                }

            }

        }
    }
}
