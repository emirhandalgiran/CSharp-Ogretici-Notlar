using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_ile_metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        islemler islem = new islemler();
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            mtbSay2.Enabled = true;
            int say1 = Convert.ToInt32(mtbSay1.Text);
            int say2 = Convert.ToInt32(mtbSay2.Text);
            if (rdbTopla.Checked)
            {
                lblSonuc.Text = islem.topla(say1, say2).ToString();
            }
            else if (rdbCikar.Checked)
            {
                lblSonuc.Text = islem.cikar(say1, say2).ToString();
            }
            else if(rdbCarp.Checked)
            {
                lblSonuc.Text = islem.carp(say1, say2).ToString();
            }
            else if (rdbBol.Checked)
            {
                lblSonuc.Text = islem.bol(say1, say2).ToString();
            }
            else if(rdbFaktoriyel.Checked)
            {
                
                lblSonuc.Text = islem.faktoriyel(say1).ToString();
            }

        }

        private void rdbFaktoriyel_CheckedChanged(object sender, EventArgs e)
        {
            mtbSay2.Enabled = false;
        }
    }
}
