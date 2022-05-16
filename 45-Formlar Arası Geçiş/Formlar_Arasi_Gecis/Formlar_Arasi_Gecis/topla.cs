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
    public partial class topla : Form
    {
        public topla()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int say1 = Convert.ToInt32(txtSay1.Text);
            int say2 = Convert.ToInt32(txtSay2.Text);
            MessageBox.Show("Toplam=" + (say1 + say2));
        }

       
    }
}
