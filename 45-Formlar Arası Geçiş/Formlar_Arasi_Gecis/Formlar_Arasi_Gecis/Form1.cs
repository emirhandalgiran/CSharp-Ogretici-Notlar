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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        topla toplaFormu = new topla();
        cikar cikarFormu = new cikar();
        carp carpFormu = new carp();
        bol bolFormu = new bol();
        private void btnTopla_Click(object sender, EventArgs e)
        {
            toplaFormu.ShowDialog();
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            cikarFormu.ShowDialog();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            carpFormu.ShowDialog();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            bolFormu.ShowDialog();
        }
    }
}
