using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formlar_Arasi_Gecis
{
    public partial class bol : Form
    {
        public bol()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double say1 = Convert.ToDouble(txtSay1.Text);
            double say2 = Convert.ToDouble(txtSay2.Text);
            MessageBox.Show("Sonuç=" + (say1 / say2));
        }
    }
}
