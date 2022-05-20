using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAktif_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
        }

        private void btnPasif_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnGizle_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnSolaHizala_Click(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Left;
        }

        private void btnSagaHizala_Click(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Right;
        }

       
    }
}
