using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exception_Ornegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte say1, say2;//byte 0-255 aralığında değer alır
        int sonuc;
        private void btnBol_Click(object sender, EventArgs e)
        {
            try 
            {

                say1 = Convert.ToByte(txtSay1.Text);
                say2 = Convert.ToByte(txtSay2.Text);
                sonuc = say1 / say2;
                lblSonuc.Text = sonuc.ToString();

            }
            catch(FormatException)//sayı girilmesi gerekirken harf girerse
            {
               MessageBox.Show("Lütfen sayı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("Hiçbir sayı 0 a bölünemez.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(OverflowException)
            {
                MessageBox.Show("Bir taşma oluştu.\n Lütfen 0-255 arasında bir değer girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtSay1.Clear();
                txtSay2.Clear();
            }
        }
    }
}
