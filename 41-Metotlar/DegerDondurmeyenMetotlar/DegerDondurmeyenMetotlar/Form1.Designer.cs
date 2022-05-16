
namespace DegerDondurmeyenMetotlar
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
            this.btnSaat = new System.Windows.Forms.Button();
            this.btnTarih = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaat
            // 
            this.btnSaat.Location = new System.Drawing.Point(29, 95);
            this.btnSaat.Name = "btnSaat";
            this.btnSaat.Size = new System.Drawing.Size(75, 44);
            this.btnSaat.TabIndex = 0;
            this.btnSaat.Text = "Saati Yaz";
            this.btnSaat.UseVisualStyleBackColor = true;
            this.btnSaat.Click += new System.EventHandler(this.btnSaat_Click);
            // 
            // btnTarih
            // 
            this.btnTarih.Location = new System.Drawing.Point(162, 95);
            this.btnTarih.Name = "btnTarih";
            this.btnTarih.Size = new System.Drawing.Size(75, 44);
            this.btnTarih.TabIndex = 1;
            this.btnTarih.Text = "Tarihi Yaz";
            this.btnTarih.UseVisualStyleBackColor = true;
            this.btnTarih.Click += new System.EventHandler(this.btnTarih_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(94, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 181);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTarih);
            this.Controls.Add(this.btnSaat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaat;
        private System.Windows.Forms.Button btnTarih;
        private System.Windows.Forms.Label label1;
    }
}

