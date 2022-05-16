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
    public partial class yonlendir : Form
    {
        public yonlendir()
        {
            InitializeComponent();
        }

        private void yonlendir_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        KullaniciPaneli panel = new KullaniciPaneli();
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value<progressBar1.Maximum)
            {
                progressBar1.Value=progressBar1.Value+10;
            }
            else
            {
                panel.Show();
                this.Close();

            }
        }
    }
}
