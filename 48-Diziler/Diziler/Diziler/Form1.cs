using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = {"Arda","Rıdvan","Yunus Emre","Tuana","Gazi Can","Cebo","Furkan" };
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            lstGoster.Items.Add(isimler[0]);
            lstGoster.Items.Add(isimler[1]);
            lstGoster.Items.Add(isimler[2]);
            lstGoster.Items.Add(isimler[3]);
            lstGoster.Items.Add(isimler[4]);
            lstGoster.Items.Add(isimler[5]);
            lstGoster.Items.Add(isimler[6]);

        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            for(int indis = 0; indis < isimler.Length; indis++)
            {
                lstGoster.Items.Add(isimler[indis]);
            }
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            foreach(string isim in isimler)
            {
                lstGoster.Items.Add(isim);
            }
        }
    }
}
