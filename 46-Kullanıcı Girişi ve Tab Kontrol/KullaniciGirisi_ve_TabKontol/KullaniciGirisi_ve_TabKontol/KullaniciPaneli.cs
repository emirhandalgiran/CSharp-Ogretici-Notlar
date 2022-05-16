using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciGirisi_ve_TabKontol
{
    public partial class KullaniciPaneli : Form
    {
        public KullaniciPaneli()
        {
            InitializeComponent();
        }

        private void KullaniciPaneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnOgrYazdir_Click(object sender, EventArgs e)
        {
            lstOgrGoster.Items.Add(txtOgrAd.Text + " " + txtOgrSoyad.Text + ":" + txtOkulNo.Text + " " + cmbSinif.SelectedItem + mtbOgrDt.Text);
        }

        private void btnZiyaretciYazdir_Click(object sender, EventArgs e)
        {
            lstZiyaretciGoster.Items.Add(txtZiyaretciAd.Text + " " + txtZiyaretciSoyad.Text + ":" + cmbZiyaretciCinsiyet.SelectedItem + " " + mtbZiyaretciDT.Text);
        }

        private void btnPersonelYazdir_Click(object sender, EventArgs e)
        {
            string[] personel = { "Dursun Dikilitaş", "Güray Şen", "Ali Metin", "Sabri Çalışkan", "Ertuğrul Kömürcü" };
            foreach (string p in personel)
            {
                lstPersonelGoster.Items.Add(p);
            }
        }
    }
}
