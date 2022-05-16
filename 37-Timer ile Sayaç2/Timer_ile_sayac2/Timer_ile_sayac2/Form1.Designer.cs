
namespace Timer_ile_sayac2
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
            this.components = new System.ComponentModel.Container();
            this.lblSayac = new System.Windows.Forms.Label();
            this.pbBaslat = new System.Windows.Forms.PictureBox();
            this.pbDurdur = new System.Windows.Forms.PictureBox();
            this.pbSifirla = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbBaslat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDurdur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSifirla)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayac.Location = new System.Drawing.Point(75, 18);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(42, 46);
            this.lblSayac.TabIndex = 0;
            this.lblSayac.Text = "0";
            // 
            // pbBaslat
            // 
            this.pbBaslat.Image = global::Timer_ile_sayac2.Properties.Resources.Start_icon;
            this.pbBaslat.Location = new System.Drawing.Point(11, 74);
            this.pbBaslat.Name = "pbBaslat";
            this.pbBaslat.Size = new System.Drawing.Size(50, 50);
            this.pbBaslat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBaslat.TabIndex = 4;
            this.pbBaslat.TabStop = false;
            this.pbBaslat.Tag = "";
            this.pbBaslat.Click += new System.EventHandler(this.pbBaslat_Click);
            // 
            // pbDurdur
            // 
            this.pbDurdur.Image = global::Timer_ile_sayac2.Properties.Resources.Pause_Normal_Red_icon;
            this.pbDurdur.Location = new System.Drawing.Point(66, 74);
            this.pbDurdur.Name = "pbDurdur";
            this.pbDurdur.Size = new System.Drawing.Size(50, 50);
            this.pbDurdur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDurdur.TabIndex = 5;
            this.pbDurdur.TabStop = false;
            this.pbDurdur.Click += new System.EventHandler(this.pbDurdur_Click);
            // 
            // pbSifirla
            // 
            this.pbSifirla.Image = global::Timer_ile_sayac2.Properties.Resources.arrow_refresh_2_icon;
            this.pbSifirla.Location = new System.Drawing.Point(124, 74);
            this.pbSifirla.Name = "pbSifirla";
            this.pbSifirla.Size = new System.Drawing.Size(50, 50);
            this.pbSifirla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSifirla.TabIndex = 6;
            this.pbSifirla.TabStop = false;
            this.pbSifirla.Click += new System.EventHandler(this.pbSifirla_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 147);
            this.Controls.Add(this.pbSifirla);
            this.Controls.Add(this.pbDurdur);
            this.Controls.Add(this.pbBaslat);
            this.Controls.Add(this.lblSayac);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sayaç";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBaslat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDurdur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSifirla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayac;
        private System.Windows.Forms.PictureBox pbBaslat;
        private System.Windows.Forms.PictureBox pbDurdur;
        private System.Windows.Forms.PictureBox pbSifirla;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

