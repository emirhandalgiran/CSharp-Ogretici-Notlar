
namespace Matematiksel_Fonksiyonlar
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
            this.txtSay1 = new System.Windows.Forms.TextBox();
            this.txtSay2 = new System.Windows.Forms.TextBox();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.btnMutlakDeger = new System.Windows.Forms.Button();
            this.btnUsteYuvarla = new System.Windows.Forms.Button();
            this.btnAltaYuvarla = new System.Windows.Forms.Button();
            this.btnCosinus = new System.Windows.Forms.Button();
            this.btnSinus = new System.Windows.Forms.Button();
            this.btnETabanLogaritma = new System.Windows.Forms.Button();
            this.btnEnYakinTamSayi = new System.Windows.Forms.Button();
            this.btnEnBuyukSayi = new System.Windows.Forms.Button();
            this.btnEnKucukSayi = new System.Windows.Forms.Button();
            this.btnKareKok = new System.Windows.Forms.Button();
            this.btn10TabanLogaritma = new System.Windows.Forms.Button();
            this.btnXTabanLogaritma = new System.Windows.Forms.Button();
            this.btnUstAl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSay1
            // 
            this.txtSay1.Location = new System.Drawing.Point(43, 49);
            this.txtSay1.Name = "txtSay1";
            this.txtSay1.Size = new System.Drawing.Size(100, 20);
            this.txtSay1.TabIndex = 0;
            // 
            // txtSay2
            // 
            this.txtSay2.Location = new System.Drawing.Point(159, 49);
            this.txtSay2.Name = "txtSay2";
            this.txtSay2.Size = new System.Drawing.Size(100, 20);
            this.txtSay2.TabIndex = 1;
            // 
            // txtSonuc
            // 
            this.txtSonuc.Enabled = false;
            this.txtSonuc.Location = new System.Drawing.Point(330, 49);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(341, 20);
            this.txtSonuc.TabIndex = 0;
            // 
            // btnMutlakDeger
            // 
            this.btnMutlakDeger.Location = new System.Drawing.Point(36, 94);
            this.btnMutlakDeger.Name = "btnMutlakDeger";
            this.btnMutlakDeger.Size = new System.Drawing.Size(75, 57);
            this.btnMutlakDeger.TabIndex = 2;
            this.btnMutlakDeger.Text = "Mutlak Değer";
            this.btnMutlakDeger.UseVisualStyleBackColor = true;
            this.btnMutlakDeger.Click += new System.EventHandler(this.btnMutlakDeger_Click);
            // 
            // btnUsteYuvarla
            // 
            this.btnUsteYuvarla.Location = new System.Drawing.Point(149, 94);
            this.btnUsteYuvarla.Name = "btnUsteYuvarla";
            this.btnUsteYuvarla.Size = new System.Drawing.Size(75, 57);
            this.btnUsteYuvarla.TabIndex = 3;
            this.btnUsteYuvarla.Text = "Üste Yuvarla";
            this.btnUsteYuvarla.UseVisualStyleBackColor = true;
            this.btnUsteYuvarla.Click += new System.EventHandler(this.btnUsteYuvarla_Click);
            // 
            // btnAltaYuvarla
            // 
            this.btnAltaYuvarla.Location = new System.Drawing.Point(265, 94);
            this.btnAltaYuvarla.Name = "btnAltaYuvarla";
            this.btnAltaYuvarla.Size = new System.Drawing.Size(75, 57);
            this.btnAltaYuvarla.TabIndex = 4;
            this.btnAltaYuvarla.Text = "Alta Yuvarla";
            this.btnAltaYuvarla.UseVisualStyleBackColor = true;
            this.btnAltaYuvarla.Click += new System.EventHandler(this.btnAltaYuvarla_Click);
            // 
            // btnCosinus
            // 
            this.btnCosinus.Location = new System.Drawing.Point(381, 94);
            this.btnCosinus.Name = "btnCosinus";
            this.btnCosinus.Size = new System.Drawing.Size(75, 57);
            this.btnCosinus.TabIndex = 5;
            this.btnCosinus.Text = "Cosinüs";
            this.btnCosinus.UseVisualStyleBackColor = true;
            this.btnCosinus.Click += new System.EventHandler(this.btnCosinus_Click);
            // 
            // btnSinus
            // 
            this.btnSinus.Location = new System.Drawing.Point(489, 94);
            this.btnSinus.Name = "btnSinus";
            this.btnSinus.Size = new System.Drawing.Size(75, 57);
            this.btnSinus.TabIndex = 6;
            this.btnSinus.Text = "Sinüs";
            this.btnSinus.UseVisualStyleBackColor = true;
            this.btnSinus.Click += new System.EventHandler(this.btnSinus_Click);
            // 
            // btnETabanLogaritma
            // 
            this.btnETabanLogaritma.Location = new System.Drawing.Point(596, 94);
            this.btnETabanLogaritma.Name = "btnETabanLogaritma";
            this.btnETabanLogaritma.Size = new System.Drawing.Size(75, 57);
            this.btnETabanLogaritma.TabIndex = 7;
            this.btnETabanLogaritma.Text = "e Taban Logaritma";
            this.btnETabanLogaritma.UseVisualStyleBackColor = true;
            this.btnETabanLogaritma.Click += new System.EventHandler(this.btnETabanLogaritma_Click);
            // 
            // btnEnYakinTamSayi
            // 
            this.btnEnYakinTamSayi.Location = new System.Drawing.Point(33, 176);
            this.btnEnYakinTamSayi.Name = "btnEnYakinTamSayi";
            this.btnEnYakinTamSayi.Size = new System.Drawing.Size(75, 61);
            this.btnEnYakinTamSayi.TabIndex = 8;
            this.btnEnYakinTamSayi.Text = "En Yakın Tam Sayı";
            this.btnEnYakinTamSayi.UseVisualStyleBackColor = true;
            this.btnEnYakinTamSayi.Click += new System.EventHandler(this.btnEnYakinTamSayi_Click);
            // 
            // btnEnBuyukSayi
            // 
            this.btnEnBuyukSayi.Location = new System.Drawing.Point(149, 176);
            this.btnEnBuyukSayi.Name = "btnEnBuyukSayi";
            this.btnEnBuyukSayi.Size = new System.Drawing.Size(75, 61);
            this.btnEnBuyukSayi.TabIndex = 9;
            this.btnEnBuyukSayi.Text = "En Büyük Sayı";
            this.btnEnBuyukSayi.UseVisualStyleBackColor = true;
            this.btnEnBuyukSayi.Click += new System.EventHandler(this.btnEnBuyukSayi_Click);
            // 
            // btnEnKucukSayi
            // 
            this.btnEnKucukSayi.Location = new System.Drawing.Point(265, 176);
            this.btnEnKucukSayi.Name = "btnEnKucukSayi";
            this.btnEnKucukSayi.Size = new System.Drawing.Size(75, 61);
            this.btnEnKucukSayi.TabIndex = 10;
            this.btnEnKucukSayi.Text = "En Küçük  Sayı";
            this.btnEnKucukSayi.UseVisualStyleBackColor = true;
            this.btnEnKucukSayi.Click += new System.EventHandler(this.btnEnKucukSayi_Click);
            // 
            // btnKareKok
            // 
            this.btnKareKok.Location = new System.Drawing.Point(33, 257);
            this.btnKareKok.Name = "btnKareKok";
            this.btnKareKok.Size = new System.Drawing.Size(75, 66);
            this.btnKareKok.TabIndex = 13;
            this.btnKareKok.Text = "Karekök";
            this.btnKareKok.UseVisualStyleBackColor = true;
            this.btnKareKok.Click += new System.EventHandler(this.btnKareKok_Click);
            // 
            // btn10TabanLogaritma
            // 
            this.btn10TabanLogaritma.Location = new System.Drawing.Point(489, 176);
            this.btn10TabanLogaritma.Name = "btn10TabanLogaritma";
            this.btn10TabanLogaritma.Size = new System.Drawing.Size(75, 61);
            this.btn10TabanLogaritma.TabIndex = 11;
            this.btn10TabanLogaritma.Text = "10 Tabanında Logaritma";
            this.btn10TabanLogaritma.UseVisualStyleBackColor = true;
            this.btn10TabanLogaritma.Click += new System.EventHandler(this.btn10TabanLogaritma_Click);
            // 
            // btnXTabanLogaritma
            // 
            this.btnXTabanLogaritma.Location = new System.Drawing.Point(596, 176);
            this.btnXTabanLogaritma.Name = "btnXTabanLogaritma";
            this.btnXTabanLogaritma.Size = new System.Drawing.Size(75, 61);
            this.btnXTabanLogaritma.TabIndex = 12;
            this.btnXTabanLogaritma.Text = "x Tabanlı Logaritma";
            this.btnXTabanLogaritma.UseVisualStyleBackColor = true;
            this.btnXTabanLogaritma.Click += new System.EventHandler(this.btnXTabanLogaritma_Click);
            // 
            // btnUstAl
            // 
            this.btnUstAl.Location = new System.Drawing.Point(149, 257);
            this.btnUstAl.Name = "btnUstAl";
            this.btnUstAl.Size = new System.Drawing.Size(75, 66);
            this.btnUstAl.TabIndex = 14;
            this.btnUstAl.Text = "Üs Alma";
            this.btnUstAl.UseVisualStyleBackColor = true;
            this.btnUstAl.Click += new System.EventHandler(this.btnUstAl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "1.Sayı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "2.Sayı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sonuç:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(701, 347);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXTabanLogaritma);
            this.Controls.Add(this.btn10TabanLogaritma);
            this.Controls.Add(this.btnUstAl);
            this.Controls.Add(this.btnKareKok);
            this.Controls.Add(this.btnEnKucukSayi);
            this.Controls.Add(this.btnEnBuyukSayi);
            this.Controls.Add(this.btnEnYakinTamSayi);
            this.Controls.Add(this.btnETabanLogaritma);
            this.Controls.Add(this.btnSinus);
            this.Controls.Add(this.btnCosinus);
            this.Controls.Add(this.btnAltaYuvarla);
            this.Controls.Add(this.btnUsteYuvarla);
            this.Controls.Add(this.btnMutlakDeger);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.txtSay2);
            this.Controls.Add(this.txtSay1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matematiksel Metotlar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSay1;
        private System.Windows.Forms.TextBox txtSay2;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Button btnMutlakDeger;
        private System.Windows.Forms.Button btnUsteYuvarla;
        private System.Windows.Forms.Button btnAltaYuvarla;
        private System.Windows.Forms.Button btnCosinus;
        private System.Windows.Forms.Button btnSinus;
        private System.Windows.Forms.Button btnETabanLogaritma;
        private System.Windows.Forms.Button btnEnYakinTamSayi;
        private System.Windows.Forms.Button btnEnBuyukSayi;
        private System.Windows.Forms.Button btnEnKucukSayi;
        private System.Windows.Forms.Button btnKareKok;
        private System.Windows.Forms.Button btn10TabanLogaritma;
        private System.Windows.Forms.Button btnXTabanLogaritma;
        private System.Windows.Forms.Button btnUstAl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

