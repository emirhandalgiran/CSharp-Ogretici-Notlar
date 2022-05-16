using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] siniflar = { 9, 10, 11, 12 };
        char[] subeler = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
        private void btnFor_Click(object sender, EventArgs e)
        {
            for(int i=0;i<siniflar.Length; i++)
            {
                listBox1.Items.Add("----------" + siniflar[i] + ".Sınıflar----------");
                for(int j=0;j<subeler.Length;j++)
                {
                    listBox1.Items.Add(siniflar[i] + "/" + subeler[j]);
                }
            }
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            foreach(int sinif in siniflar)
            {
                listBox1.Items.Add("----------" + sinif + ".Sınıflar----------");
                foreach(char sube in subeler)
                {
                    listBox1.Items.Add(sinif+"/"+sube);
                }
            }
        }
    }
}
