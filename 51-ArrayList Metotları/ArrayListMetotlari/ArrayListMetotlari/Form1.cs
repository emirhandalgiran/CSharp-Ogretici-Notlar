using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ArrayListMetotlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList elemanlar = new ArrayList();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            elemanlar.Add(txtEleman.Text);
            MessageBox.Show("Eleman Diziye Eklendi");
            txtEleman.Clear();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            foreach (var eleman in elemanlar)
            {
                lstGoster.Items.Add(eleman);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lstGoster.Items.Clear();
        }

        private void btnSirala_Click(object sender, EventArgs e)
        {
            elemanlar.Sort();//Dizi elemanlarını küçükten büyüğe ya da a dan z ye sıralar
        }

        private void btnTersCevir_Click(object sender, EventArgs e)
        {
            elemanlar.Reverse();//Dizi elemanlarını girme sırasına göre ters çevirir
        }

        private void btnKapasiteGoster_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dizinin kapasitesi: " + elemanlar.Capacity);
        }

        private void btnUzunlukGoster_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dizinin Eleman Sayısı:" + elemanlar.Count);
        }

        private void btnElemanSil_Click(object sender, EventArgs e)
        {
            string secilen = lstGoster.SelectedItem.ToString();
            //Listboxdan seçili elemanı diziden siler
            elemanlar.Remove(lstGoster.SelectedItem);
            MessageBox.Show(secilen + " elemanı diziden silindi");
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            bool ara;
            ara = elemanlar.Contains(txtAra.Text);//varsa true yoksa false döner
            if (ara==true)
            {
                MessageBox.Show(txtAra.Text + " elemanı dizi içinde bulundu");
            }

            else
            {
                MessageBox.Show(txtAra.Text+" elemanı dizi içinde bulunamadı");
            }
        }
    }
}
