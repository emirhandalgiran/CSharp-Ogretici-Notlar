﻿
namespace Formlar_Arasi_Gecis
{
    partial class topla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSay1 = new System.Windows.Forms.TextBox();
            this.txtSay2 = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.Sayı:";
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2.Sayı:";
            
            // 
            // txtSay1
            // 
            this.txtSay1.Location = new System.Drawing.Point(92, 38);
            this.txtSay1.Name = "txtSay1";
            this.txtSay1.Size = new System.Drawing.Size(100, 20);
            this.txtSay1.TabIndex = 2;
            
            // 
            // txtSay2
            // 
            this.txtSay2.Location = new System.Drawing.Point(92, 66);
            this.txtSay2.Name = "txtSay2";
            this.txtSay2.Size = new System.Drawing.Size(100, 20);
            this.txtSay2.TabIndex = 2;
            
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(213, 38);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 48);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // topla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(336, 121);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtSay2);
            this.Controls.Add(this.txtSay1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "topla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "topla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSay1;
        private System.Windows.Forms.TextBox txtSay2;
        private System.Windows.Forms.Button btnHesapla;
    }
}