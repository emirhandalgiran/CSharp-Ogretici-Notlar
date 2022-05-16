
namespace class_ile_metotlar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbSay1 = new System.Windows.Forms.MaskedTextBox();
            this.mtbSay2 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTopla = new System.Windows.Forms.RadioButton();
            this.rdbCikar = new System.Windows.Forms.RadioButton();
            this.rdbCarp = new System.Windows.Forms.RadioButton();
            this.rdbBol = new System.Windows.Forms.RadioButton();
            this.rdbFaktoriyel = new System.Windows.Forms.RadioButton();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.Sayı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2.Sayı:";
            // 
            // mtbSay1
            // 
            this.mtbSay1.Location = new System.Drawing.Point(84, 18);
            this.mtbSay1.Mask = "000";
            this.mtbSay1.Name = "mtbSay1";
            this.mtbSay1.PromptChar = ' ';
            this.mtbSay1.Size = new System.Drawing.Size(100, 20);
            this.mtbSay1.TabIndex = 1;
            this.mtbSay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbSay1.ValidatingType = typeof(int);
            // 
            // mtbSay2
            // 
            this.mtbSay2.Location = new System.Drawing.Point(84, 50);
            this.mtbSay2.Mask = "000";
            this.mtbSay2.Name = "mtbSay2";
            this.mtbSay2.PromptChar = ' ';
            this.mtbSay2.Size = new System.Drawing.Size(100, 20);
            this.mtbSay2.TabIndex = 2;
            this.mtbSay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbSay2.ValidatingType = typeof(int);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbFaktoriyel);
            this.groupBox1.Controls.Add(this.rdbBol);
            this.groupBox1.Controls.Add(this.rdbCarp);
            this.groupBox1.Controls.Add(this.rdbCikar);
            this.groupBox1.Controls.Add(this.rdbTopla);
            this.groupBox1.Location = new System.Drawing.Point(216, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 182);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // rdbTopla
            // 
            this.rdbTopla.AutoSize = true;
            this.rdbTopla.Location = new System.Drawing.Point(20, 20);
            this.rdbTopla.Name = "rdbTopla";
            this.rdbTopla.Size = new System.Drawing.Size(52, 17);
            this.rdbTopla.TabIndex = 3;
            this.rdbTopla.TabStop = true;
            this.rdbTopla.Text = "Topla";
            this.rdbTopla.UseVisualStyleBackColor = true;
            // 
            // rdbCikar
            // 
            this.rdbCikar.AutoSize = true;
            this.rdbCikar.Location = new System.Drawing.Point(20, 50);
            this.rdbCikar.Name = "rdbCikar";
            this.rdbCikar.Size = new System.Drawing.Size(49, 17);
            this.rdbCikar.TabIndex = 4;
            this.rdbCikar.TabStop = true;
            this.rdbCikar.Text = "Çıkar";
            this.rdbCikar.UseVisualStyleBackColor = true;
            // 
            // rdbCarp
            // 
            this.rdbCarp.AutoSize = true;
            this.rdbCarp.Location = new System.Drawing.Point(20, 80);
            this.rdbCarp.Name = "rdbCarp";
            this.rdbCarp.Size = new System.Drawing.Size(47, 17);
            this.rdbCarp.TabIndex = 5;
            this.rdbCarp.TabStop = true;
            this.rdbCarp.Text = "Çarp";
            this.rdbCarp.UseVisualStyleBackColor = true;
            // 
            // rdbBol
            // 
            this.rdbBol.AutoSize = true;
            this.rdbBol.Location = new System.Drawing.Point(20, 110);
            this.rdbBol.Name = "rdbBol";
            this.rdbBol.Size = new System.Drawing.Size(40, 17);
            this.rdbBol.TabIndex = 6;
            this.rdbBol.TabStop = true;
            this.rdbBol.Text = "Böl";
            this.rdbBol.UseVisualStyleBackColor = true;
            // 
            // rdbFaktoriyel
            // 
            this.rdbFaktoriyel.AutoSize = true;
            this.rdbFaktoriyel.Location = new System.Drawing.Point(20, 140);
            this.rdbFaktoriyel.Name = "rdbFaktoriyel";
            this.rdbFaktoriyel.Size = new System.Drawing.Size(112, 17);
            this.rdbFaktoriyel.TabIndex = 7;
            this.rdbFaktoriyel.TabStop = true;
            this.rdbFaktoriyel.Text = "Faktoriyel Hesapla";
            this.rdbFaktoriyel.UseVisualStyleBackColor = true;
            this.rdbFaktoriyel.CheckedChanged += new System.EventHandler(this.rdbFaktoriyel_CheckedChanged);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(29, 92);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(155, 47);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(63, 172);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(38, 13);
            this.lblSonuc.TabIndex = 5;
            this.lblSonuc.Text = "Sonuç";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 219);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mtbSay2);
            this.Controls.Add(this.mtbSay1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metot İle İşlemler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbSay1;
        private System.Windows.Forms.MaskedTextBox mtbSay2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbFaktoriyel;
        private System.Windows.Forms.RadioButton rdbBol;
        private System.Windows.Forms.RadioButton rdbCarp;
        private System.Windows.Forms.RadioButton rdbCikar;
        private System.Windows.Forms.RadioButton rdbTopla;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblSonuc;
    }
}

