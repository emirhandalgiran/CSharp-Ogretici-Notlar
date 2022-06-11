using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DialogResult secim = new DialogResult();
        private void btnLabel_Click(object sender, EventArgs e)
        {
            secim = colorDialog1.ShowDialog();
            if (secim==DialogResult.OK)
            {
                label1.ForeColor = colorDialog1.Color;
            }
        }

        private void btnTextbox_Click(object sender, EventArgs e)
        {
            secim = colorDialog1.ShowDialog();
            if (secim==DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void btnSolPanel_Click(object sender, EventArgs e)
        {
            secim = colorDialog1.ShowDialog();
            if (secim==DialogResult.OK)
            {
                splitContainer1.Panel1.BackColor = colorDialog1.Color;
            }
        }

        private void btnSagPanel_Click(object sender, EventArgs e)
        {
            secim = colorDialog1.ShowDialog();
            if (secim==DialogResult.OK)
            {
                splitContainer1.Panel2.BackColor = colorDialog1.Color;
            }
        }
    }
}
