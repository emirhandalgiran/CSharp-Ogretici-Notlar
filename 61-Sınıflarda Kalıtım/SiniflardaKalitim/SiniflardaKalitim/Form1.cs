using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiniflardaKalitim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ogretmen ogr = new ogretmen();
        muhendis muh = new muhendis();
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            if (cmMeslek.SelectedItem=="Öğretmen")
            {
                ogr.ad = txtAd.Text;
                ogr.soyad = txtSoyad.Text;
                ogr.brans = txtBrans.Text;
                listBox1.Items.Add(ogr.ad + " " + ogr.soyad + " " + ogr.brans);
            }
            else if (cmMeslek.SelectedItem=="Mühendis")
            {
                muh.ad = txtAd.Text;
                muh.soyad = txtSoyad.Text;
                muh.brans = txtBrans.Text;
                listBox1.Items.Add(muh.ad + " " + muh.soyad + " " + muh.brans)
;            }
           
        }
    }
}
