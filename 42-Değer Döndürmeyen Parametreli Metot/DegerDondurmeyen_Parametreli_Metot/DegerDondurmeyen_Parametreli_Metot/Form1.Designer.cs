
namespace DegerDondurmeyen_Parametreli_Metot
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.btnTextYazdir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.mtbDogumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.btnAdYazdir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTextYazdir);
            this.groupBox1.Controls.Add(this.txtMesaj);
            this.groupBox1.Controls.Add(this.txtBaslik);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text Mesajı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdYazdir);
            this.groupBox2.Controls.Add(this.mtbDogumTarihi);
            this.groupBox2.Controls.Add(this.txtAdSoyad);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(215, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 155);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ad Mesajı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlık:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mesaj:";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(63, 22);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(100, 20);
            this.txtBaslik.TabIndex = 2;
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(63, 48);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(100, 71);
            this.txtMesaj.TabIndex = 2;
            // 
            // btnTextYazdir
            // 
            this.btnTextYazdir.Location = new System.Drawing.Point(63, 126);
            this.btnTextYazdir.Name = "btnTextYazdir";
            this.btnTextYazdir.Size = new System.Drawing.Size(100, 23);
            this.btnTextYazdir.TabIndex = 3;
            this.btnTextYazdir.Text = "Yazdır";
            this.btnTextYazdir.UseVisualStyleBackColor = true;
            this.btnTextYazdir.Click += new System.EventHandler(this.btnTextYazdir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ad Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(86, 25);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // mtbDogumTarihi
            // 
            this.mtbDogumTarihi.Location = new System.Drawing.Point(86, 48);
            this.mtbDogumTarihi.Mask = "00/00/0000";
            this.mtbDogumTarihi.Name = "mtbDogumTarihi";
            this.mtbDogumTarihi.Size = new System.Drawing.Size(100, 20);
            this.mtbDogumTarihi.TabIndex = 2;
            this.mtbDogumTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // btnAdYazdir
            // 
            this.btnAdYazdir.Location = new System.Drawing.Point(86, 126);
            this.btnAdYazdir.Name = "btnAdYazdir";
            this.btnAdYazdir.Size = new System.Drawing.Size(100, 23);
            this.btnAdYazdir.TabIndex = 3;
            this.btnAdYazdir.Text = "Yazdır";
            this.btnAdYazdir.UseVisualStyleBackColor = true;
            this.btnAdYazdir.Click += new System.EventHandler(this.btnAdYazdir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 211);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTextYazdir;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdYazdir;
        private System.Windows.Forms.MaskedTextBox mtbDogumTarihi;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

