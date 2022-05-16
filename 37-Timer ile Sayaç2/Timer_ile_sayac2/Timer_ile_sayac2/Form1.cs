using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_ile_sayac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pbBaslat, "Başlat");
            toolTip1.SetToolTip(pbDurdur, "Durdur");
            toolTip1.SetToolTip(pbSifirla, "Sıfırla");
            toolTip1.ToolTipTitle = "Sayaç Programı";
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            timer1.Interval = 1000;//zamanlayıcıyı 1 saniyede çalıştırır
            timer1.Enabled = false;//zamanlayıcı çalışmıyor
        }
        private void pbBaslat_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void pbDurdur_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void pbSifirla_Click(object sender, EventArgs e)
        {
            sayac = 0;
            lblSayac.Text = sayac.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            lblSayac.Text = sayac.ToString();
        }


    }
}
