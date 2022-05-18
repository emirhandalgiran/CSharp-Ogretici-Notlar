
namespace stringmetotlari
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAradanKarakterAl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYazdirKarakter = new System.Windows.Forms.TextBox();
            this.txtSira = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKarakterYaz = new System.Windows.Forms.Button();
            this.txtKarakterSayisi = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSondanBoslukSil = new System.Windows.Forms.Button();
            this.btnBastanBoslukSil = new System.Windows.Forms.Button();
            this.btnBasdanSondanBoslukSil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUzunluk = new System.Windows.Forms.Button();
            this.btnKucukHarf = new System.Windows.Forms.Button();
            this.btnBuyukHarf = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(377, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(380, 303);
            this.listBox1.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.btnAradanKarakterAl);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtYazdirKarakter);
            this.groupBox4.Controls.Add(this.txtSira);
            this.groupBox4.Location = new System.Drawing.Point(13, 296);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(357, 77);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aradan Karakter Al";
            // 
            // btnAradanKarakterAl
            // 
            this.btnAradanKarakterAl.Location = new System.Drawing.Point(270, 35);
            this.btnAradanKarakterAl.Name = "btnAradanKarakterAl";
            this.btnAradanKarakterAl.Size = new System.Drawing.Size(75, 23);
            this.btnAradanKarakterAl.TabIndex = 2;
            this.btnAradanKarakterAl.Text = "Yazdır";
            this.btnAradanKarakterAl.UseVisualStyleBackColor = true;
            this.btnAradanKarakterAl.Click += new System.EventHandler(this.btnAradanKarakterAl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Silinecek Karakter:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sıra:";
            // 
            // txtYazdirKarakter
            // 
            this.txtYazdirKarakter.Location = new System.Drawing.Point(141, 37);
            this.txtYazdirKarakter.Name = "txtYazdirKarakter";
            this.txtYazdirKarakter.Size = new System.Drawing.Size(123, 20);
            this.txtYazdirKarakter.TabIndex = 0;
            this.txtYazdirKarakter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSira
            // 
            this.txtSira.Location = new System.Drawing.Point(8, 37);
            this.txtSira.Name = "txtSira";
            this.txtSira.Size = new System.Drawing.Size(100, 20);
            this.txtSira.TabIndex = 0;
            this.txtSira.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.btnKarakterYaz);
            this.groupBox3.Controls.Add(this.txtKarakterSayisi);
            this.groupBox3.Location = new System.Drawing.Point(13, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 60);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Belirtilen Sayı Kadar Karakteri Yaz";
            // 
            // btnKarakterYaz
            // 
            this.btnKarakterYaz.Location = new System.Drawing.Point(174, 20);
            this.btnKarakterYaz.Name = "btnKarakterYaz";
            this.btnKarakterYaz.Size = new System.Drawing.Size(173, 23);
            this.btnKarakterYaz.TabIndex = 1;
            this.btnKarakterYaz.Text = "Yaz";
            this.btnKarakterYaz.UseVisualStyleBackColor = true;
            this.btnKarakterYaz.Click += new System.EventHandler(this.btnKarakterYaz_Click);
            // 
            // txtKarakterSayisi
            // 
            this.txtKarakterSayisi.Location = new System.Drawing.Point(8, 20);
            this.txtKarakterSayisi.Name = "txtKarakterSayisi";
            this.txtKarakterSayisi.Size = new System.Drawing.Size(160, 20);
            this.txtKarakterSayisi.TabIndex = 0;
            this.txtKarakterSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.btnSondanBoslukSil);
            this.groupBox2.Controls.Add(this.btnBastanBoslukSil);
            this.groupBox2.Controls.Add(this.btnBasdanSondanBoslukSil);
            this.groupBox2.Location = new System.Drawing.Point(13, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 90);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Boşlıkları Temizle";
            // 
            // btnSondanBoslukSil
            // 
            this.btnSondanBoslukSil.Location = new System.Drawing.Point(237, 20);
            this.btnSondanBoslukSil.Name = "btnSondanBoslukSil";
            this.btnSondanBoslukSil.Size = new System.Drawing.Size(110, 57);
            this.btnSondanBoslukSil.TabIndex = 1;
            this.btnSondanBoslukSil.Text = "Sonundan Boşluk Sil";
            this.btnSondanBoslukSil.UseVisualStyleBackColor = true;
            this.btnSondanBoslukSil.Click += new System.EventHandler(this.btnSondanBoslukSil_Click);
            // 
            // btnBastanBoslukSil
            // 
            this.btnBastanBoslukSil.Location = new System.Drawing.Point(121, 20);
            this.btnBastanBoslukSil.Name = "btnBastanBoslukSil";
            this.btnBastanBoslukSil.Size = new System.Drawing.Size(110, 57);
            this.btnBastanBoslukSil.TabIndex = 1;
            this.btnBastanBoslukSil.Text = "Başından Boşluk Sil";
            this.btnBastanBoslukSil.UseVisualStyleBackColor = true;
            this.btnBastanBoslukSil.Click += new System.EventHandler(this.btnBastanBoslukSil_Click);
            // 
            // btnBasdanSondanBoslukSil
            // 
            this.btnBasdanSondanBoslukSil.Location = new System.Drawing.Point(6, 20);
            this.btnBasdanSondanBoslukSil.Name = "btnBasdanSondanBoslukSil";
            this.btnBasdanSondanBoslukSil.Size = new System.Drawing.Size(110, 57);
            this.btnBasdanSondanBoslukSil.TabIndex = 1;
            this.btnBasdanSondanBoslukSil.Text = "Başından ve Sonundan Boşluk Sil";
            this.btnBasdanSondanBoslukSil.UseVisualStyleBackColor = true;
            this.btnBasdanSondanBoslukSil.Click += new System.EventHandler(this.btnBasdanSondanBoslukSil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnUzunluk);
            this.groupBox1.Controls.Add(this.btnKucukHarf);
            this.groupBox1.Controls.Add(this.btnBuyukHarf);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 65);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metin";
            // 
            // btnUzunluk
            // 
            this.btnUzunluk.Location = new System.Drawing.Point(238, 20);
            this.btnUzunluk.Name = "btnUzunluk";
            this.btnUzunluk.Size = new System.Drawing.Size(110, 31);
            this.btnUzunluk.TabIndex = 1;
            this.btnUzunluk.Text = "Uzunluk";
            this.btnUzunluk.UseVisualStyleBackColor = true;
            this.btnUzunluk.Click += new System.EventHandler(this.btnUzunluk_Click);
            // 
            // btnKucukHarf
            // 
            this.btnKucukHarf.Location = new System.Drawing.Point(122, 20);
            this.btnKucukHarf.Name = "btnKucukHarf";
            this.btnKucukHarf.Size = new System.Drawing.Size(110, 31);
            this.btnKucukHarf.TabIndex = 1;
            this.btnKucukHarf.Text = "Küçük Harf Yaz";
            this.btnKucukHarf.UseVisualStyleBackColor = true;
            this.btnKucukHarf.Click += new System.EventHandler(this.btnKucukHarf_Click);
            // 
            // btnBuyukHarf
            // 
            this.btnBuyukHarf.Location = new System.Drawing.Point(6, 20);
            this.btnBuyukHarf.Name = "btnBuyukHarf";
            this.btnBuyukHarf.Size = new System.Drawing.Size(110, 31);
            this.btnBuyukHarf.TabIndex = 1;
            this.btnBuyukHarf.Text = "Büyük Harf Yaz";
            this.btnBuyukHarf.UseVisualStyleBackColor = true;
            this.btnBuyukHarf.Click += new System.EventHandler(this.btnBuyukHarf_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(766, 46);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 377);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "String Metotları";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAradanKarakterAl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYazdirKarakter;
        private System.Windows.Forms.TextBox txtSira;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnKarakterYaz;
        private System.Windows.Forms.TextBox txtKarakterSayisi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSondanBoslukSil;
        private System.Windows.Forms.Button btnBastanBoslukSil;
        private System.Windows.Forms.Button btnBasdanSondanBoslukSil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUzunluk;
        private System.Windows.Forms.Button btnKucukHarf;
        private System.Windows.Forms.Button btnBuyukHarf;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

