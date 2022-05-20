
namespace Panel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAktif = new System.Windows.Forms.Button();
            this.btnPasif = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            this.btnGizle = new System.Windows.Forms.Button();
            this.btnSolaHizala = new System.Windows.Forms.Button();
            this.btnSagaHizala = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 278);
            this.panel1.TabIndex = 0;
            
            
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(0, 220);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 55);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 165);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 55);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 55);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAktif
            // 
            this.btnAktif.Location = new System.Drawing.Point(223, 142);
            this.btnAktif.Name = "btnAktif";
            this.btnAktif.Size = new System.Drawing.Size(92, 46);
            this.btnAktif.TabIndex = 1;
            this.btnAktif.Text = "Paneli Aktif Yap";
            this.btnAktif.UseVisualStyleBackColor = true;
            this.btnAktif.Click += new System.EventHandler(this.btnAktif_Click);
            // 
            // btnPasif
            // 
            this.btnPasif.Location = new System.Drawing.Point(321, 142);
            this.btnPasif.Name = "btnPasif";
            this.btnPasif.Size = new System.Drawing.Size(85, 46);
            this.btnPasif.TabIndex = 2;
            this.btnPasif.Text = "Paneli Pasif Yap";
            this.btnPasif.UseVisualStyleBackColor = true;
            this.btnPasif.Click += new System.EventHandler(this.btnPasif_Click);
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(223, 194);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(92, 46);
            this.btnGoster.TabIndex = 3;
            this.btnGoster.Text = "Paneli Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // btnGizle
            // 
            this.btnGizle.Location = new System.Drawing.Point(321, 192);
            this.btnGizle.Name = "btnGizle";
            this.btnGizle.Size = new System.Drawing.Size(85, 46);
            this.btnGizle.TabIndex = 4;
            this.btnGizle.Text = "Paneli Gizle";
            this.btnGizle.UseVisualStyleBackColor = true;
            this.btnGizle.Click += new System.EventHandler(this.btnGizle_Click);
            // 
            // btnSolaHizala
            // 
            this.btnSolaHizala.Location = new System.Drawing.Point(223, 244);
            this.btnSolaHizala.Name = "btnSolaHizala";
            this.btnSolaHizala.Size = new System.Drawing.Size(92, 46);
            this.btnSolaHizala.TabIndex = 5;
            this.btnSolaHizala.Text = "Paneli Sola Hizala";
            this.btnSolaHizala.UseVisualStyleBackColor = true;
            this.btnSolaHizala.Click += new System.EventHandler(this.btnSolaHizala_Click);
            // 
            // btnSagaHizala
            // 
            this.btnSagaHizala.Location = new System.Drawing.Point(321, 244);
            this.btnSagaHizala.Name = "btnSagaHizala";
            this.btnSagaHizala.Size = new System.Drawing.Size(85, 46);
            this.btnSagaHizala.TabIndex = 6;
            this.btnSagaHizala.Text = "Paneli Sağa Hizala";
            this.btnSagaHizala.UseVisualStyleBackColor = true;
            this.btnSagaHizala.Click += new System.EventHandler(this.btnSagaHizala_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 300);
            this.Controls.Add(this.btnSagaHizala);
            this.Controls.Add(this.btnSolaHizala);
            this.Controls.Add(this.btnGizle);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.btnPasif);
            this.Controls.Add(this.btnAktif);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
           
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAktif;
        private System.Windows.Forms.Button btnPasif;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Button btnGizle;
        private System.Windows.Forms.Button btnSolaHizala;
        private System.Windows.Forms.Button btnSagaHizala;
    }
}

