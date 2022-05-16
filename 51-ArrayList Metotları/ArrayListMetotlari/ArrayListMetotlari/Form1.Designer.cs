
namespace ArrayListMetotlari
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
            this.btnBul = new System.Windows.Forms.Button();
            this.btnElemanSil = new System.Windows.Forms.Button();
            this.btnUzunlukGoster = new System.Windows.Forms.Button();
            this.btnKapasiteGoster = new System.Windows.Forms.Button();
            this.btnTersCevir = new System.Windows.Forms.Button();
            this.btnSirala = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lstGoster = new System.Windows.Forms.ListBox();
            this.txtEleman = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(154, 242);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(156, 29);
            this.btnBul.TabIndex = 12;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnElemanSil
            // 
            this.btnElemanSil.Location = new System.Drawing.Point(154, 210);
            this.btnElemanSil.Name = "btnElemanSil";
            this.btnElemanSil.Size = new System.Drawing.Size(156, 29);
            this.btnElemanSil.TabIndex = 13;
            this.btnElemanSil.Text = "Diziden Eleman Sil";
            this.btnElemanSil.UseVisualStyleBackColor = true;
            this.btnElemanSil.Click += new System.EventHandler(this.btnElemanSil_Click);
            // 
            // btnUzunlukGoster
            // 
            this.btnUzunlukGoster.Location = new System.Drawing.Point(154, 178);
            this.btnUzunlukGoster.Name = "btnUzunlukGoster";
            this.btnUzunlukGoster.Size = new System.Drawing.Size(156, 29);
            this.btnUzunlukGoster.TabIndex = 14;
            this.btnUzunlukGoster.Text = "Dizi Uzunluğunu Göster";
            this.btnUzunlukGoster.UseVisualStyleBackColor = true;
            this.btnUzunlukGoster.Click += new System.EventHandler(this.btnUzunlukGoster_Click);
            // 
            // btnKapasiteGoster
            // 
            this.btnKapasiteGoster.Location = new System.Drawing.Point(154, 143);
            this.btnKapasiteGoster.Name = "btnKapasiteGoster";
            this.btnKapasiteGoster.Size = new System.Drawing.Size(156, 29);
            this.btnKapasiteGoster.TabIndex = 15;
            this.btnKapasiteGoster.Text = "Dizi Kapasitesini Göster";
            this.btnKapasiteGoster.UseVisualStyleBackColor = true;
            this.btnKapasiteGoster.Click += new System.EventHandler(this.btnKapasiteGoster_Click);
            // 
            // btnTersCevir
            // 
            this.btnTersCevir.Location = new System.Drawing.Point(235, 103);
            this.btnTersCevir.Name = "btnTersCevir";
            this.btnTersCevir.Size = new System.Drawing.Size(75, 34);
            this.btnTersCevir.TabIndex = 16;
            this.btnTersCevir.Text = "TERS ÇEVİR";
            this.btnTersCevir.UseVisualStyleBackColor = true;
            this.btnTersCevir.Click += new System.EventHandler(this.btnTersCevir_Click);
            // 
            // btnSirala
            // 
            this.btnSirala.Location = new System.Drawing.Point(154, 103);
            this.btnSirala.Name = "btnSirala";
            this.btnSirala.Size = new System.Drawing.Size(75, 34);
            this.btnSirala.TabIndex = 17;
            this.btnSirala.Text = "SIRALA";
            this.btnSirala.UseVisualStyleBackColor = true;
            this.btnSirala.Click += new System.EventHandler(this.btnSirala_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(235, 63);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 34);
            this.btnTemizle.TabIndex = 18;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(154, 63);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(75, 34);
            this.btnGoster.TabIndex = 19;
            this.btnGoster.Text = "GÖSTER";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(154, 27);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(156, 23);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "DİZİYE EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ara:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Eleman Gir:";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 251);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(126, 20);
            this.txtAra.TabIndex = 8;
            // 
            // lstGoster
            // 
            this.lstGoster.FormattingEnabled = true;
            this.lstGoster.Location = new System.Drawing.Point(12, 63);
            this.lstGoster.Name = "lstGoster";
            this.lstGoster.Size = new System.Drawing.Size(126, 160);
            this.lstGoster.TabIndex = 7;
            // 
            // txtEleman
            // 
            this.txtEleman.Location = new System.Drawing.Point(12, 27);
            this.txtEleman.Name = "txtEleman";
            this.txtEleman.Size = new System.Drawing.Size(126, 20);
            this.txtEleman.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 295);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnElemanSil);
            this.Controls.Add(this.btnUzunlukGoster);
            this.Controls.Add(this.btnKapasiteGoster);
            this.Controls.Add(this.btnTersCevir);
            this.Controls.Add(this.btnSirala);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lstGoster);
            this.Controls.Add(this.txtEleman);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Array List Metotları";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnElemanSil;
        private System.Windows.Forms.Button btnUzunlukGoster;
        private System.Windows.Forms.Button btnKapasiteGoster;
        private System.Windows.Forms.Button btnTersCevir;
        private System.Windows.Forms.Button btnSirala;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ListBox lstGoster;
        private System.Windows.Forms.TextBox txtEleman;
    }
}

