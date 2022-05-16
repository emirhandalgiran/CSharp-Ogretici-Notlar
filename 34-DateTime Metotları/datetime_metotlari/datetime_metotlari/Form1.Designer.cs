
namespace datetime_metotlari
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
            this.btnSimdiGoster = new System.Windows.Forms.Button();
            this.btnUzunTarih = new System.Windows.Forms.Button();
            this.btnKisaTarih = new System.Windows.Forms.Button();
            this.btnUzunZaman = new System.Windows.Forms.Button();
            this.btnKısaZaman = new System.Windows.Forms.Button();
            this.btnYilinGunu = new System.Windows.Forms.Button();
            this.btnDakika = new System.Windows.Forms.Button();
            this.btnSaat = new System.Windows.Forms.Button();
            this.btnSaniye = new System.Windows.Forms.Button();
            this.btnhaftaninGunu = new System.Windows.Forms.Button();
            this.btnyil = new System.Windows.Forms.Button();
            this.btnGun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstGoster = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSimdiGoster
            // 
            this.btnSimdiGoster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnSimdiGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimdiGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSimdiGoster.Location = new System.Drawing.Point(24, 23);
            this.btnSimdiGoster.Name = "btnSimdiGoster";
            this.btnSimdiGoster.Size = new System.Drawing.Size(90, 49);
            this.btnSimdiGoster.TabIndex = 0;
            this.btnSimdiGoster.Text = "Şimdiyi Göster";
            this.btnSimdiGoster.UseVisualStyleBackColor = true;
            this.btnSimdiGoster.Click += new System.EventHandler(this.btnSimdiGoster_Click);
            // 
            // btnUzunTarih
            // 
            this.btnUzunTarih.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnUzunTarih.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUzunTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUzunTarih.Location = new System.Drawing.Point(120, 23);
            this.btnUzunTarih.Name = "btnUzunTarih";
            this.btnUzunTarih.Size = new System.Drawing.Size(90, 49);
            this.btnUzunTarih.TabIndex = 0;
            this.btnUzunTarih.Text = "Uzun Tarih";
            this.btnUzunTarih.UseVisualStyleBackColor = true;
            this.btnUzunTarih.Click += new System.EventHandler(this.btnUzunTarih_Click);
            // 
            // btnKisaTarih
            // 
            this.btnKisaTarih.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnKisaTarih.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKisaTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKisaTarih.Location = new System.Drawing.Point(216, 23);
            this.btnKisaTarih.Name = "btnKisaTarih";
            this.btnKisaTarih.Size = new System.Drawing.Size(90, 49);
            this.btnKisaTarih.TabIndex = 0;
            this.btnKisaTarih.Text = "Kısa Tarih";
            this.btnKisaTarih.UseVisualStyleBackColor = true;
            this.btnKisaTarih.Click += new System.EventHandler(this.btnKisaTarih_Click);
            // 
            // btnUzunZaman
            // 
            this.btnUzunZaman.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnUzunZaman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUzunZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUzunZaman.Location = new System.Drawing.Point(24, 80);
            this.btnUzunZaman.Name = "btnUzunZaman";
            this.btnUzunZaman.Size = new System.Drawing.Size(90, 46);
            this.btnUzunZaman.TabIndex = 0;
            this.btnUzunZaman.Text = "Uzun Zaman";
            this.btnUzunZaman.UseVisualStyleBackColor = true;
            this.btnUzunZaman.Click += new System.EventHandler(this.btnUzunZaman_Click);
            // 
            // btnKısaZaman
            // 
            this.btnKısaZaman.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnKısaZaman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKısaZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKısaZaman.Location = new System.Drawing.Point(120, 80);
            this.btnKısaZaman.Name = "btnKısaZaman";
            this.btnKısaZaman.Size = new System.Drawing.Size(90, 46);
            this.btnKısaZaman.TabIndex = 0;
            this.btnKısaZaman.Text = "Kısa Zaman";
            this.btnKısaZaman.UseVisualStyleBackColor = true;
            this.btnKısaZaman.Click += new System.EventHandler(this.btnKısaZaman_Click);
            // 
            // btnYilinGunu
            // 
            this.btnYilinGunu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnYilinGunu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYilinGunu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYilinGunu.Location = new System.Drawing.Point(216, 80);
            this.btnYilinGunu.Name = "btnYilinGunu";
            this.btnYilinGunu.Size = new System.Drawing.Size(90, 46);
            this.btnYilinGunu.TabIndex = 0;
            this.btnYilinGunu.Text = "Yılın Kaçıncı Günü";
            this.btnYilinGunu.UseVisualStyleBackColor = true;
            this.btnYilinGunu.Click += new System.EventHandler(this.btnYilinGunu_Click);
            // 
            // btnDakika
            // 
            this.btnDakika.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnDakika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDakika.Location = new System.Drawing.Point(24, 132);
            this.btnDakika.Name = "btnDakika";
            this.btnDakika.Size = new System.Drawing.Size(90, 49);
            this.btnDakika.TabIndex = 0;
            this.btnDakika.Text = "Şuanın Dakikası";
            this.btnDakika.UseVisualStyleBackColor = true;
            this.btnDakika.Click += new System.EventHandler(this.btnDakika_Click);
            // 
            // btnSaat
            // 
            this.btnSaat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnSaat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaat.Location = new System.Drawing.Point(120, 132);
            this.btnSaat.Name = "btnSaat";
            this.btnSaat.Size = new System.Drawing.Size(90, 49);
            this.btnSaat.TabIndex = 0;
            this.btnSaat.Text = "Şuanın Saati";
            this.btnSaat.UseVisualStyleBackColor = true;
            this.btnSaat.Click += new System.EventHandler(this.btnSaat_Click);
            // 
            // btnSaniye
            // 
            this.btnSaniye.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnSaniye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaniye.Location = new System.Drawing.Point(216, 132);
            this.btnSaniye.Name = "btnSaniye";
            this.btnSaniye.Size = new System.Drawing.Size(90, 49);
            this.btnSaniye.TabIndex = 0;
            this.btnSaniye.Text = "Şuanın Saniyesi";
            this.btnSaniye.UseVisualStyleBackColor = true;
            this.btnSaniye.Click += new System.EventHandler(this.btnSaniye_Click);
            // 
            // btnhaftaninGunu
            // 
            this.btnhaftaninGunu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnhaftaninGunu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhaftaninGunu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhaftaninGunu.Location = new System.Drawing.Point(24, 187);
            this.btnhaftaninGunu.Name = "btnhaftaninGunu";
            this.btnhaftaninGunu.Size = new System.Drawing.Size(90, 49);
            this.btnhaftaninGunu.TabIndex = 0;
            this.btnhaftaninGunu.Text = "Haftanın Günü";
            this.btnhaftaninGunu.UseVisualStyleBackColor = true;
            this.btnhaftaninGunu.Click += new System.EventHandler(this.btnhaftaninGunu_Click);
            // 
            // btnyil
            // 
            this.btnyil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnyil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyil.Location = new System.Drawing.Point(120, 187);
            this.btnyil.Name = "btnyil";
            this.btnyil.Size = new System.Drawing.Size(90, 49);
            this.btnyil.TabIndex = 0;
            this.btnyil.Text = "Yıl";
            this.btnyil.UseVisualStyleBackColor = true;
            this.btnyil.Click += new System.EventHandler(this.btnyil_Click);
            // 
            // btnGun
            // 
            this.btnGun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnGun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGun.Location = new System.Drawing.Point(216, 187);
            this.btnGun.Name = "btnGun";
            this.btnGun.Size = new System.Drawing.Size(90, 49);
            this.btnGun.TabIndex = 0;
            this.btnGun.Text = "Gün";
            this.btnGun.UseVisualStyleBackColor = true;
            this.btnGun.Click += new System.EventHandler(this.btnGun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eklenecek Yıl:";
            // 
            // txtYil
            // 
            this.txtYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYil.Location = new System.Drawing.Point(138, 255);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(100, 21);
            this.txtYil.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(252, 253);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(54, 26);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstGoster
            // 
            this.lstGoster.BackColor = System.Drawing.Color.PapayaWhip;
            this.lstGoster.FormattingEnabled = true;
            this.lstGoster.ItemHeight = 20;
            this.lstGoster.Location = new System.Drawing.Point(324, 23);
            this.lstGoster.Name = "lstGoster";
            this.lstGoster.Size = new System.Drawing.Size(319, 284);
            this.lstGoster.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 313);
            this.Controls.Add(this.lstGoster);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGun);
            this.Controls.Add(this.btnyil);
            this.Controls.Add(this.btnhaftaninGunu);
            this.Controls.Add(this.btnSaniye);
            this.Controls.Add(this.btnSaat);
            this.Controls.Add(this.btnDakika);
            this.Controls.Add(this.btnYilinGunu);
            this.Controls.Add(this.btnKısaZaman);
            this.Controls.Add(this.btnUzunZaman);
            this.Controls.Add(this.btnKisaTarih);
            this.Controls.Add(this.btnUzunTarih);
            this.Controls.Add(this.btnSimdiGoster);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Date Time Metotları";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimdiGoster;
        private System.Windows.Forms.Button btnUzunTarih;
        private System.Windows.Forms.Button btnKisaTarih;
        private System.Windows.Forms.Button btnUzunZaman;
        private System.Windows.Forms.Button btnKısaZaman;
        private System.Windows.Forms.Button btnYilinGunu;
        private System.Windows.Forms.Button btnDakika;
        private System.Windows.Forms.Button btnSaat;
        private System.Windows.Forms.Button btnSaniye;
        private System.Windows.Forms.Button btnhaftaninGunu;
        private System.Windows.Forms.Button btnyil;
        private System.Windows.Forms.Button btnGun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstGoster;
    }
}

