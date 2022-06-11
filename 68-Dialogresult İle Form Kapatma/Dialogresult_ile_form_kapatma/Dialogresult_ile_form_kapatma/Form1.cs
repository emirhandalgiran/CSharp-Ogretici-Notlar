using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialogresult_ile_form_kapatma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           DialogResult secim = MessageBox.Show("Formu Kapatmak İstiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim==DialogResult.Yes)
            {
                e.Cancel = false;
                //Application.Exit();
            }
            else
            {
                MessageBox.Show("Çıkış işlemi iptal edildi");
                e.Cancel = true;
            }
        }
    }
}
