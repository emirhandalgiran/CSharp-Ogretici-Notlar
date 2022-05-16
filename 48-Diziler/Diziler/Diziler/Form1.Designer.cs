
namespace Diziler
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
            this.btnYazdir = new System.Windows.Forms.Button();
            this.lstGoster = new System.Windows.Forms.ListBox();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnForeach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(12, 12);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(94, 42);
            this.btnYazdir.TabIndex = 0;
            this.btnYazdir.Text = "Dizi Elemanlarını Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // lstGoster
            // 
            this.lstGoster.FormattingEnabled = true;
            this.lstGoster.Location = new System.Drawing.Point(12, 70);
            this.lstGoster.Name = "lstGoster";
            this.lstGoster.Size = new System.Drawing.Size(288, 147);
            this.lstGoster.TabIndex = 1;
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(112, 11);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(94, 42);
            this.btnFor.TabIndex = 0;
            this.btnFor.Text = "For ile Yazdır";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnForeach
            // 
            this.btnForeach.Location = new System.Drawing.Point(212, 11);
            this.btnForeach.Name = "btnForeach";
            this.btnForeach.Size = new System.Drawing.Size(94, 42);
            this.btnForeach.TabIndex = 0;
            this.btnForeach.Text = "Foreach ile Yazdır";
            this.btnForeach.UseVisualStyleBackColor = true;
            this.btnForeach.Click += new System.EventHandler(this.btnForeach_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 237);
            this.Controls.Add(this.lstGoster);
            this.Controls.Add(this.btnForeach);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.btnYazdir);
            this.Name = "Form1";
            this.Text = "Diziler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.ListBox lstGoster;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnForeach;
    }
}

