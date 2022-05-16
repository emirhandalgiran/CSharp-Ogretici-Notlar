using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hata_denetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            try//Çalışmasını istediğimiz kodlar burda
            {
                int say1, say2,sonuc;
                say1 = Convert.ToInt32(txtSay1.Text);
                say2 = Convert.ToInt32(txtSay2.Text);
                sonuc = say1 + say2;
                lblGoster.Text = sonuc.ToString();

            }
            catch//hata durumunda devreye girer
            {
                MessageBox.Show("Bir hatayla karşılaşıldı. Lütfen sadece sayı girin","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally// buradaki kodlar her koşulda çalışır
            {
                txtSay1.Clear();
                txtSay2.Clear();
            }
        }
    }
}
