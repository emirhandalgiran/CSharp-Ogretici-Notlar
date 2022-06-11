
namespace ColorFileDialog
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnLabel = new System.Windows.Forms.Button();
            this.btnTextbox = new System.Windows.Forms.Button();
            this.btnSolPanel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSagPanel = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSagPanel);
            this.splitContainer1.Panel1.Controls.Add(this.btnSolPanel);
            this.splitContainer1.Panel1.Controls.Add(this.btnTextbox);
            this.splitContainer1.Panel1.Controls.Add(this.btnLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(536, 315);
            this.splitContainer1.SplitterDistance = 178;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnLabel
            // 
            this.btnLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLabel.Location = new System.Drawing.Point(0, 0);
            this.btnLabel.Name = "btnLabel";
            this.btnLabel.Size = new System.Drawing.Size(178, 40);
            this.btnLabel.TabIndex = 0;
            this.btnLabel.Text = "Label Rengini Değiştir";
            this.btnLabel.UseVisualStyleBackColor = true;
            this.btnLabel.Click += new System.EventHandler(this.btnLabel_Click);
            // 
            // btnTextbox
            // 
            this.btnTextbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTextbox.Location = new System.Drawing.Point(0, 40);
            this.btnTextbox.Name = "btnTextbox";
            this.btnTextbox.Size = new System.Drawing.Size(178, 40);
            this.btnTextbox.TabIndex = 0;
            this.btnTextbox.Text = "Textbox\'ın Yazı Rengini Değiştir";
            this.btnTextbox.UseVisualStyleBackColor = true;
            this.btnTextbox.Click += new System.EventHandler(this.btnTextbox_Click);
            // 
            // btnSolPanel
            // 
            this.btnSolPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSolPanel.Location = new System.Drawing.Point(0, 80);
            this.btnSolPanel.Name = "btnSolPanel";
            this.btnSolPanel.Size = new System.Drawing.Size(178, 40);
            this.btnSolPanel.TabIndex = 0;
            this.btnSolPanel.Text = "Sol Panel Arkaplan Rengini Değiştir";
            this.btnSolPanel.UseVisualStyleBackColor = true;
            this.btnSolPanel.Click += new System.EventHandler(this.btnSolPanel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(75, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NESNE TABANLI PROGRAMLAMA";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(321, 221);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btnSagPanel
            // 
            this.btnSagPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSagPanel.Location = new System.Drawing.Point(0, 120);
            this.btnSagPanel.Name = "btnSagPanel";
            this.btnSagPanel.Size = new System.Drawing.Size(178, 40);
            this.btnSagPanel.TabIndex = 1;
            this.btnSagPanel.Text = "Sağ Panel Arkaplan Rengini Değiştir";
            this.btnSagPanel.UseVisualStyleBackColor = true;
            this.btnSagPanel.Click += new System.EventHandler(this.btnSagPanel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 315);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Color Dialog";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSolPanel;
        private System.Windows.Forms.Button btnTextbox;
        private System.Windows.Forms.Button btnLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSagPanel;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

