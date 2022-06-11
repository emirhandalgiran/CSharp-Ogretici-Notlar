
namespace FontDialog
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnYaziFont = new System.Windows.Forms.Button();
            this.btnYaziRengi = new System.Windows.Forms.Button();
            this.btnFormYazi = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnYaziFont);
            this.flowLayoutPanel1.Controls.Add(this.btnYaziRengi);
            this.flowLayoutPanel1.Controls.Add(this.btnFormYazi);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(426, 55);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnYaziFont
            // 
            this.btnYaziFont.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnYaziFont.Location = new System.Drawing.Point(3, 3);
            this.btnYaziFont.Name = "btnYaziFont";
            this.btnYaziFont.Size = new System.Drawing.Size(135, 48);
            this.btnYaziFont.TabIndex = 0;
            this.btnYaziFont.Text = "Yazı Fontunu Değiştir";
            this.btnYaziFont.UseVisualStyleBackColor = true;
            this.btnYaziFont.Click += new System.EventHandler(this.btnYaziFont_Click);
            // 
            // btnYaziRengi
            // 
            this.btnYaziRengi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnYaziRengi.Location = new System.Drawing.Point(144, 3);
            this.btnYaziRengi.Name = "btnYaziRengi";
            this.btnYaziRengi.Size = new System.Drawing.Size(135, 48);
            this.btnYaziRengi.TabIndex = 1;
            this.btnYaziRengi.Text = "Yazı Rengini Değiştir";
            this.btnYaziRengi.UseVisualStyleBackColor = true;
            this.btnYaziRengi.Click += new System.EventHandler(this.btnYaziRengi_Click);
            // 
            // btnFormYazi
            // 
            this.btnFormYazi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFormYazi.Location = new System.Drawing.Point(285, 3);
            this.btnFormYazi.Name = "btnFormYazi";
            this.btnFormYazi.Size = new System.Drawing.Size(135, 48);
            this.btnFormYazi.TabIndex = 2;
            this.btnFormYazi.Text = "Form Yazı Fontunu Değiştir";
            this.btnFormYazi.UseVisualStyleBackColor = true;
            this.btnFormYazi.Click += new System.EventHandler(this.btnFormYazi_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 74);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(425, 188);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 274);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Font Dialog";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnYaziFont;
        private System.Windows.Forms.Button btnYaziRengi;
        private System.Windows.Forms.Button btnFormYazi;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

