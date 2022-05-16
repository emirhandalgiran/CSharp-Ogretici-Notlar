using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;//array list kütüphanesi

namespace DinamikDiziler_ArrayList_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //string[] elemanlar = new string[20];
        ArrayList elemanlar = new ArrayList();
        private void Form1_Load(object sender, EventArgs e)
        {
            elemanlar.Add("Dursun Dikilitaş");//string türünde
            elemanlar.Add(3.14);//double türünde
            elemanlar.Add(true);//boolean türünde
            elemanlar.Add(36);//int türünde
            elemanlar.Add('A');//char türünde
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            elemanlar.Add(textBox1.Text);
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            foreach(var eleman in elemanlar)
            {
                listBox1.Items.Add(eleman);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }


    }
}
