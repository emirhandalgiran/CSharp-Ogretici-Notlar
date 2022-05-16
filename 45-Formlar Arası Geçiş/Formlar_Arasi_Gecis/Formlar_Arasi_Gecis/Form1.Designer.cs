
namespace Formlar_Arasi_Gecis
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
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnBol = new System.Windows.Forms.Button();
            this.btnCarp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTopla
            // 
            this.btnTopla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTopla.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTopla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnTopla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopla.Location = new System.Drawing.Point(25, 34);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(109, 75);
            this.btnTopla.TabIndex = 0;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = false;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // btnCikar
            // 
            this.btnCikar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCikar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCikar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnCikar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikar.Location = new System.Drawing.Point(155, 34);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(109, 75);
            this.btnCikar.TabIndex = 0;
            this.btnCikar.Text = "Çıkar";
            this.btnCikar.UseVisualStyleBackColor = false;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // btnBol
            // 
            this.btnBol.BackColor = System.Drawing.Color.Aqua;
            this.btnBol.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnBol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBol.Location = new System.Drawing.Point(155, 131);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(109, 75);
            this.btnBol.TabIndex = 0;
            this.btnBol.Text = "Böl";
            this.btnBol.UseVisualStyleBackColor = false;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            // 
            // btnCarp
            // 
            this.btnCarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCarp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCarp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnCarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarp.Location = new System.Drawing.Point(25, 131);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(109, 75);
            this.btnCarp.TabIndex = 0;
            this.btnCarp.Text = "Çarp";
            this.btnCarp.UseVisualStyleBackColor = false;
            this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 233);
            this.Controls.Add(this.btnCarp);
            this.Controls.Add(this.btnBol);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnTopla);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dört İşlem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.Button btnBol;
        private System.Windows.Forms.Button btnCarp;
    }
}

