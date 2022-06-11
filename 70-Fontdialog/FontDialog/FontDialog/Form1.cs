using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DialogResult secim;
        private void btnYaziFont_Click(object sender, EventArgs e)
        {
            secim = fontDialog1.ShowDialog();
            if (secim==DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void btnYaziRengi_Click(object sender, EventArgs e)
        {
            secim = colorDialog1.ShowDialog();
            if (secim==DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void btnFormYazi_Click(object sender, EventArgs e)
        {
            secim = fontDialog1.ShowDialog();
            if (secim==DialogResult.OK)
            {
                this.Font = fontDialog1.Font;
            }
        }
    }
}
