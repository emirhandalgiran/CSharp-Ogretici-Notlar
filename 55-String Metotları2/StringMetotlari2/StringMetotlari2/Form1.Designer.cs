
namespace StringMetotlari2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtToplamKarakter = new System.Windows.Forms.TextBox();
            this.txtKarakter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSoldanDoldur = new System.Windows.Forms.Button();
            this.btnSagdanDoldur = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKarakterEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAraKarakter = new System.Windows.Forms.TextBox();
            this.txtSira = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKarakterDegistir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDegisecekKarakter = new System.Windows.Forms.TextBox();
            this.txtDegistirilecekKarakter = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBastanKarakterSil = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSilinecekKarakter = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(415, 63);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Moccasin;
            this.groupBox1.Controls.Add(this.btnSagdanDoldur);
            this.groupBox1.Controls.Add(this.btnSoldanDoldur);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKarakter);
            this.groupBox1.Controls.Add(this.txtToplamKarakter);
            this.groupBox1.Location = new System.Drawing.Point(12, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İstenilen Karakter Sayısına Tamamla";
            // 
            // txtToplamKarakter
            // 
            this.txtToplamKarakter.Location = new System.Drawing.Point(6, 44);
            this.txtToplamKarakter.Name = "txtToplamKarakter";
            this.txtToplamKarakter.Size = new System.Drawing.Size(133, 21);
            this.txtToplamKarakter.TabIndex = 0;
            this.txtToplamKarakter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKarakter
            // 
            this.txtKarakter.Location = new System.Drawing.Point(149, 43);
            this.txtKarakter.Name = "txtKarakter";
            this.txtKarakter.Size = new System.Drawing.Size(114, 21);
            this.txtKarakter.TabIndex = 1;
            this.txtKarakter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Toplam Karakter Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Karakter:";
            // 
            // btnSoldanDoldur
            // 
            this.btnSoldanDoldur.Location = new System.Drawing.Point(265, 32);
            this.btnSoldanDoldur.Name = "btnSoldanDoldur";
            this.btnSoldanDoldur.Size = new System.Drawing.Size(72, 39);
            this.btnSoldanDoldur.TabIndex = 4;
            this.btnSoldanDoldur.Text = "Soldan Doldur";
            this.btnSoldanDoldur.UseVisualStyleBackColor = true;
            this.btnSoldanDoldur.Click += new System.EventHandler(this.btnSoldanDoldur_Click);
            // 
            // btnSagdanDoldur
            // 
            this.btnSagdanDoldur.Location = new System.Drawing.Point(339, 32);
            this.btnSagdanDoldur.Name = "btnSagdanDoldur";
            this.btnSagdanDoldur.Size = new System.Drawing.Size(72, 39);
            this.btnSagdanDoldur.TabIndex = 4;
            this.btnSagdanDoldur.Text = "Sağdan Doldur";
            this.btnSagdanDoldur.UseVisualStyleBackColor = true;
            this.btnSagdanDoldur.Click += new System.EventHandler(this.btnSagdanDoldur_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.OldLace;
            this.groupBox2.Controls.Add(this.btnKarakterEkle);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtAraKarakter);
            this.groupBox2.Controls.Add(this.txtSira);
            this.groupBox2.Location = new System.Drawing.Point(12, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 77);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araya Karakter Ekle";
            // 
            // btnKarakterEkle
            // 
            this.btnKarakterEkle.Location = new System.Drawing.Point(265, 25);
            this.btnKarakterEkle.Name = "btnKarakterEkle";
            this.btnKarakterEkle.Size = new System.Drawing.Size(142, 39);
            this.btnKarakterEkle.TabIndex = 4;
            this.btnKarakterEkle.Text = "Karakteri Ekle";
            this.btnKarakterEkle.UseVisualStyleBackColor = true;
            this.btnKarakterEkle.Click += new System.EventHandler(this.btnKarakterEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Karakter:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sıra:";
            // 
            // txtAraKarakter
            // 
            this.txtAraKarakter.Location = new System.Drawing.Point(149, 43);
            this.txtAraKarakter.Name = "txtAraKarakter";
            this.txtAraKarakter.Size = new System.Drawing.Size(114, 21);
            this.txtAraKarakter.TabIndex = 1;
            this.txtAraKarakter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSira
            // 
            this.txtSira.Location = new System.Drawing.Point(6, 44);
            this.txtSira.Name = "txtSira";
            this.txtSira.Size = new System.Drawing.Size(133, 21);
            this.txtSira.TabIndex = 0;
            this.txtSira.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Beige;
            this.groupBox3.Controls.Add(this.btnKarakterDegistir);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtDegisecekKarakter);
            this.groupBox3.Controls.Add(this.txtDegistirilecekKarakter);
            this.groupBox3.Location = new System.Drawing.Point(12, 316);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(415, 77);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Karakter Değiştir";
            // 
            // btnKarakterDegistir
            // 
            this.btnKarakterDegistir.Location = new System.Drawing.Point(269, 25);
            this.btnKarakterDegistir.Name = "btnKarakterDegistir";
            this.btnKarakterDegistir.Size = new System.Drawing.Size(140, 39);
            this.btnKarakterDegistir.TabIndex = 4;
            this.btnKarakterDegistir.Text = "Karakteri Değiştir";
            this.btnKarakterDegistir.UseVisualStyleBackColor = true;
            this.btnKarakterDegistir.Click += new System.EventHandler(this.btnKarakterDegistir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Değişecek Karakter:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Değiştirilecek Karakter:";
            // 
            // txtDegisecekKarakter
            // 
            this.txtDegisecekKarakter.Location = new System.Drawing.Point(149, 43);
            this.txtDegisecekKarakter.Name = "txtDegisecekKarakter";
            this.txtDegisecekKarakter.Size = new System.Drawing.Size(114, 21);
            this.txtDegisecekKarakter.TabIndex = 1;
            this.txtDegisecekKarakter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDegistirilecekKarakter
            // 
            this.txtDegistirilecekKarakter.Location = new System.Drawing.Point(6, 44);
            this.txtDegistirilecekKarakter.Name = "txtDegistirilecekKarakter";
            this.txtDegistirilecekKarakter.Size = new System.Drawing.Size(133, 21);
            this.txtDegistirilecekKarakter.TabIndex = 0;
            this.txtDegistirilecekKarakter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(433, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(351, 394);
            this.listBox1.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox4.Controls.Add(this.btnBastanKarakterSil);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtSilinecekKarakter);
            this.groupBox4.Location = new System.Drawing.Point(12, 65);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(415, 79);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Baştan Karakter Sil";
            // 
            // btnBastanKarakterSil
            // 
            this.btnBastanKarakterSil.Location = new System.Drawing.Point(149, 25);
            this.btnBastanKarakterSil.Name = "btnBastanKarakterSil";
            this.btnBastanKarakterSil.Size = new System.Drawing.Size(262, 40);
            this.btnBastanKarakterSil.TabIndex = 4;
            this.btnBastanKarakterSil.Text = "Baştan Karakter Sil";
            this.btnBastanKarakterSil.UseVisualStyleBackColor = true;
            this.btnBastanKarakterSil.Click += new System.EventHandler(this.btnBastanKarakterSil_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Silinecek Karakter Sayısı:";
            // 
            // txtSilinecekKarakter
            // 
            this.txtSilinecekKarakter.Location = new System.Drawing.Point(6, 44);
            this.txtSilinecekKarakter.Name = "txtSilinecekKarakter";
            this.txtSilinecekKarakter.Size = new System.Drawing.Size(133, 21);
            this.txtSilinecekKarakter.TabIndex = 0;
            this.txtSilinecekKarakter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 403);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "String Metotları 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSagdanDoldur;
        private System.Windows.Forms.Button btnSoldanDoldur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKarakter;
        private System.Windows.Forms.TextBox txtToplamKarakter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKarakterEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAraKarakter;
        private System.Windows.Forms.TextBox txtSira;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnKarakterDegistir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDegisecekKarakter;
        private System.Windows.Forms.TextBox txtDegistirilecekKarakter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBastanKarakterSil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSilinecekKarakter;
    }
}

