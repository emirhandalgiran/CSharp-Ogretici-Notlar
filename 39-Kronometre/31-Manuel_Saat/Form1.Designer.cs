namespace _31_Manuel_Saat
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblSaat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDakika = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.pbBaslat = new System.Windows.Forms.PictureBox();
            this.pbDurdur = new System.Windows.Forms.PictureBox();
            this.pbSifirla = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSalise = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbBaslat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDurdur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSifirla)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSaat.Location = new System.Drawing.Point(28, 26);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(66, 46);
            this.lblSaat.TabIndex = 0;
            this.lblSaat.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(84, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            // 
            // lblDakika
            // 
            this.lblDakika.AutoSize = true;
            this.lblDakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDakika.ForeColor = System.Drawing.Color.Lime;
            this.lblDakika.Location = new System.Drawing.Point(109, 26);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(66, 46);
            this.lblDakika.TabIndex = 2;
            this.lblDakika.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(161, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = ":";
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaniye.ForeColor = System.Drawing.Color.Cyan;
            this.lblSaniye.Location = new System.Drawing.Point(187, 26);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(66, 46);
            this.lblSaniye.TabIndex = 4;
            this.lblSaniye.Text = "00";
            // 
            // pbBaslat
            // 
            this.pbBaslat.Image = global::_31_Manuel_Saat.Properties.Resources.Start_icon;
            this.pbBaslat.Location = new System.Drawing.Point(36, 75);
            this.pbBaslat.Name = "pbBaslat";
            this.pbBaslat.Size = new System.Drawing.Size(40, 40);
            this.pbBaslat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBaslat.TabIndex = 5;
            this.pbBaslat.TabStop = false;
            this.pbBaslat.Click += new System.EventHandler(this.pbBaslat_Click);
            // 
            // pbDurdur
            // 
            this.pbDurdur.Image = global::_31_Manuel_Saat.Properties.Resources.Pause_Normal_Red_icon;
            this.pbDurdur.Location = new System.Drawing.Point(117, 75);
            this.pbDurdur.Name = "pbDurdur";
            this.pbDurdur.Size = new System.Drawing.Size(40, 40);
            this.pbDurdur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDurdur.TabIndex = 5;
            this.pbDurdur.TabStop = false;
            this.pbDurdur.Click += new System.EventHandler(this.pbDurdur_Click);
            // 
            // pbSifirla
            // 
            this.pbSifirla.Image = global::_31_Manuel_Saat.Properties.Resources.arrow_refresh_2_icon;
            this.pbSifirla.Location = new System.Drawing.Point(195, 75);
            this.pbSifirla.Name = "pbSifirla";
            this.pbSifirla.Size = new System.Drawing.Size(40, 40);
            this.pbSifirla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSifirla.TabIndex = 5;
            this.pbSifirla.TabStop = false;
            this.pbSifirla.Click += new System.EventHandler(this.pbSifirla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(242, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = ".";
            // 
            // lblSalise
            // 
            this.lblSalise.AutoSize = true;
            this.lblSalise.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalise.ForeColor = System.Drawing.Color.Cyan;
            this.lblSalise.Location = new System.Drawing.Point(248, 50);
            this.lblSalise.Name = "lblSalise";
            this.lblSalise.Size = new System.Drawing.Size(21, 13);
            this.lblSalise.TabIndex = 4;
            this.lblSalise.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 127);
            this.Controls.Add(this.pbSifirla);
            this.Controls.Add(this.pbDurdur);
            this.Controls.Add(this.pbBaslat);
            this.Controls.Add(this.lblSalise);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDakika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSaat);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kronometre";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBaslat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDurdur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSifirla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDakika;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.PictureBox pbBaslat;
        private System.Windows.Forms.PictureBox pbDurdur;
        private System.Windows.Forms.PictureBox pbSifirla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSalise;
        private System.Windows.Forms.Timer timer1;
    }
}

