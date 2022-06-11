using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;//dialog penceresi için ekledik
using System.Globalization;//ilk harf büyük yapmak için ekledik

namespace _55_Notepad_programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DialogResult tus = new DialogResult();
        ///////////////////////////////////////////////////////////////
        //ToolStrip Menü
        private void btnKes_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();//Kes
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();//Kopyala
        }

        private void btnYapistir_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();//Yapıştır
        }
        ////////////////////////////////////////////////////////////////
        //Sağ Tık Menü
        private void kesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();//Kes
        }

        private void kopyalaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();//Kopyala
        }

        private void yapıştırToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();//Yapıştır
        }
        
        /// /////////////////////////////////////////////////////////////////
        //MenuStrip
        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();//Kes
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();//Kopyala
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();//Yapıştır
        }
        
        /// ////////////////////////////////////////////////////////////////
        
        private void btnSolaHizala_Click(object sender, EventArgs e)
        {
            //Sola Hizala
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void btnOrtala_Click(object sender, EventArgs e)
        {
            //Ortaya Hizala
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnSagaHizala_Click(object sender, EventArgs e)
        {
            //Sağa Hizala
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
        ///////////////////////////////////////////////////////////////////
        private void btnRenk_Click(object sender, EventArgs e)
        {
            tus = colorDialog1.ShowDialog();
            if (tus==DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            tus = fontDialog1.ShowDialog();
            if (tus==DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }
        ///////////////////////////////////////////////////////////////////
        private void btnDosyaAc_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Metin belgesi seç";
            openFileDialog1.Filter = "Word belgesi 2007 öncesi|*.doc|Word belgesi 2007 sonrası|*docx|Metin Belgesi|*.txt";
           tus= openFileDialog1.ShowDialog();
           if (tus==DialogResult.OK)
           {
               string dosyaYolu = openFileDialog1.FileName;
               FileInfo SeciliDosya = new FileInfo(dosyaYolu);
               StreamReader dosyaicerik = SeciliDosya.OpenText();
               richTextBox1.Text = dosyaicerik.ReadToEnd();
           }
            
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Kaydet";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Metin Belgesi|*.txt|Word Belgesi|*.docx";
            tus = saveFileDialog1.ShowDialog();
            if (tus==DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void yeniBelgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //kendisinin bir kopyasını oluşturarak açacak

            System.Diagnostics.Process.Start(Application.ProductName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Console.NumberLock == true)
            {
                lblNum.Text = "Num Lock Açık";
                lblNum.ForeColor = Color.Green;
            }
            else
            {
                lblNum.Text = "Num Lock Kapalı";
                lblNum.ForeColor = Color.Red;
            }

            if (Console.CapsLock == true)
            {
                lblCaps.Text = "Caps Lock Açık";
                lblCaps.ForeColor = Color.Green;
            }
            else
            {
                lblCaps.Text = "Caps Lock Kapalı";
                lblCaps.ForeColor = Color.Red;
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {//Aktif olarakyazı yazarken kontrol sağlar
            if (Console.NumberLock == true)
            {
                lblNum.Text = "Num Lock Açık";
                lblNum.ForeColor = Color.Green;
            }
            else
            {
                lblNum.Text = "Num Lock Kapalı";
                lblNum.ForeColor = Color.Red;
            }

            if (Console.CapsLock == true)
            {
                lblCaps.Text = "Caps Lock Açık";
                lblCaps.ForeColor = Color.Green;
            }
            else
            {
                lblCaps.Text = "Caps Lock Kapalı";
                lblCaps.ForeColor = Color.Red;
            }
        }
        ///////////////////////////////////////////////////////////////////
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //Richtextbox her değiştiğinde çalışacak kodlar.
            //Yazı uzunluğunu alacağız.
            lblKarakter.Text = "Karakter uzunluğu:"+richTextBox1.TextLength.ToString();

        }
        ///////////////////////////////////////////////////////////////////
        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tus = MessageBox.Show("Programı Kapatmak İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (tus==DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Programı kapatma işlemi iptal edildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
        ///////////////////////////////////////////////////////////////////
        //Tümünü Seç
        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
        //Geri Al
        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }
        //Geri Alınan İşlemi İleri Al
        private void ileriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }
        //Yazı Alanını Temizle
        private void alanıTemizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void btnBuyuk_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.ToUpper();
        }

        private void btnKucuk_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.ToLower(); ;
        }

        private void btnBuyukKucuk_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(richTextBox1.Text);
        }

        private void çıkışYapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           DialogResult secim= MessageBox.Show("Çıkış yapmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim==DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("İşlem iptal edildi");
            }
        }

        private void lblCaps_Click(object sender, EventArgs e)
        {

        }
    }
}
