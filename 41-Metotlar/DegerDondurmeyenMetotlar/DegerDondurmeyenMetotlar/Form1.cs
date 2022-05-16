using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DegerDondurmeyenMetotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void SaatGoster()
        {
            label1.Text = DateTime.Now.ToShortTimeString();
        }

        void TarihGoster()
        {
            label1.Text = DateTime.Now.ToShortDateString();
        }

        private void btnSaat_Click(object sender, EventArgs e)
        {
            SaatGoster();
        }

        private void btnTarih_Click(object sender, EventArgs e)
        {
            TarihGoster();
        }
    }
}
