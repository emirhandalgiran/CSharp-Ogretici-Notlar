
namespace Araba_Yarisi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.pbMotor = new System.Windows.Forms.PictureBox();
            this.pbAraba = new System.Windows.Forms.PictureBox();
            this.lblMotorHizi = new System.Windows.Forms.Label();
            this.lblArabaHizi = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAraba)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "----------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(271, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 76);
            this.label2.TabIndex = 1;
            this.label2.Text = "----------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(507, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 76);
            this.label3.TabIndex = 2;
            this.label3.Text = "----------";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 306);
            this.button1.TabIndex = 3;
            this.button1.Text = "BİTİŞ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(713, 45);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(75, 73);
            this.btnBaslat.TabIndex = 4;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.Location = new System.Drawing.Point(713, 190);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(75, 73);
            this.btnSifirla.TabIndex = 4;
            this.btnSifirla.Text = "Sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = true;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // pbMotor
            // 
            this.pbMotor.BackColor = System.Drawing.Color.Transparent;
            this.pbMotor.Image = global::Araba_Yarisi.Properties.Resources.Motorcycle_icon;
            this.pbMotor.Location = new System.Drawing.Point(594, 71);
            this.pbMotor.Name = "pbMotor";
            this.pbMotor.Size = new System.Drawing.Size(100, 73);
            this.pbMotor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMotor.TabIndex = 5;
            this.pbMotor.TabStop = false;
            // 
            // pbAraba
            // 
            this.pbAraba.BackColor = System.Drawing.Color.Transparent;
            this.pbAraba.Image = global::Araba_Yarisi.Properties.Resources.Sportscar_car_icon;
            this.pbAraba.Location = new System.Drawing.Point(594, 171);
            this.pbAraba.Name = "pbAraba";
            this.pbAraba.Size = new System.Drawing.Size(100, 73);
            this.pbAraba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAraba.TabIndex = 5;
            this.pbAraba.TabStop = false;
            // 
            // lblMotorHizi
            // 
            this.lblMotorHizi.AutoSize = true;
            this.lblMotorHizi.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMotorHizi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMotorHizi.Location = new System.Drawing.Point(281, 9);
            this.lblMotorHizi.Name = "lblMotorHizi";
            this.lblMotorHizi.Size = new System.Drawing.Size(217, 46);
            this.lblMotorHizi.TabIndex = 6;
            this.lblMotorHizi.Text = "Hız: 0 km/s";
            // 
            // lblArabaHizi
            // 
            this.lblArabaHizi.AutoSize = true;
            this.lblArabaHizi.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblArabaHizi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblArabaHizi.Location = new System.Drawing.Point(281, 251);
            this.lblArabaHizi.Name = "lblArabaHizi";
            this.lblArabaHizi.Size = new System.Drawing.Size(217, 46);
            this.lblArabaHizi.TabIndex = 6;
            this.lblArabaHizi.Text = "Hız: 0 km/s";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 306);
            this.Controls.Add(this.lblArabaHizi);
            this.Controls.Add(this.lblMotorHizi);
            this.Controls.Add(this.pbAraba);
            this.Controls.Add(this.pbMotor);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yarış Oyunu";
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAraba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.PictureBox pbMotor;
        private System.Windows.Forms.PictureBox pbAraba;
        private System.Windows.Forms.Label lblMotorHizi;
        private System.Windows.Forms.Label lblArabaHizi;
        private System.Windows.Forms.Timer timer1;
    }
}

