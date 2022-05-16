using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DizidenRastgeleElemanCekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler;
        int elemanSayisi,indis=0;
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            elemanSayisi = Convert.ToInt32(numericUpDown1.Value);
            isimler = new string[elemanSayisi];
            MessageBox.Show(elemanSayisi + " elemanlı dizi oluşturuldu");
        }
        Random rastgele = new Random();
        int kura;
        private void btnKuraCek_Click(object sender, EventArgs e)
        {
            kura = rastgele.Next(elemanSayisi);
            lstGoster.Items.Add(isimler[kura]);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lstGoster.Items.Clear();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            if (indis==elemanSayisi)
            {
                MessageBox.Show(elemanSayisi + " tane eleman eklediniz.\nLütfen kura işlemine geçiniz");
            }
            else
            {
                isimler[indis] = txtisim.Text;
                indis++;
            }
        }
    }
}
