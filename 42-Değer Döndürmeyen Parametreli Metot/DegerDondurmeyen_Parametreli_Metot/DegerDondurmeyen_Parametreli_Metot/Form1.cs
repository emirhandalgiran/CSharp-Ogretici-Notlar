using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DegerDondurmeyen_Parametreli_Metot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void mesajYaz(string baslik,string mesaj)
        {
            MessageBox.Show(mesaj, baslik, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnTextYazdir_Click(object sender, EventArgs e)
        {
            mesajYaz(txtBaslik.Text,txtMesaj.Text);
        }

        private void btnAdYazdir_Click(object sender, EventArgs e)
        {
            mesajYaz(txtAdSoyad.Text, "Doğum Tarihi:" + mtbDogumTarihi.Text);
        }
    }
}
