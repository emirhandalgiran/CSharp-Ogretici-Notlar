using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciGirisi_ve_TabKontol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
            txtKullaniciAdi.TabIndex = 0;
            txtSifre.TabIndex = 1;
            checkBox1.TabIndex = 2;
            btnGiris.TabIndex = 3;
            
        }
        yonlendir yonlen = new yonlendir();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text=="admin" && txtSifre.Text=="1234")
            {
                MessageBox.Show("Giriş başarılı");
                yonlen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı adı veya şifre girdiniz.", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKullaniciAdi.Clear();
                txtSifre.Clear();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }
    }
}
