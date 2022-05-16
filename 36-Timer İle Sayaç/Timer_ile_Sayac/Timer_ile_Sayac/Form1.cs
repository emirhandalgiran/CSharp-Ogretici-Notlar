using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_ile_Sayac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 10;
        private void button1_Click(object sender, EventArgs e)
        {
            //zamanlayıcı çalıştır
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            label1.Text = sayac.ToString();
            if (sayac==0)
            {
                Application.Exit();
            }
        }
    }
}
