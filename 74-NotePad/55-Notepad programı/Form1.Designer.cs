namespace _55_Notepad_programı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SagTikMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tümünüSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ileriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alanıTemizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCaps = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblKarakter = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SagTikCikis = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metinBelgesiAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyayıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniBelgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnKes = new System.Windows.Forms.ToolStripButton();
            this.btnKopyala = new System.Windows.Forms.ToolStripButton();
            this.btnYapistir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSolaHizala = new System.Windows.Forms.ToolStripButton();
            this.btnOrtala = new System.Windows.Forms.ToolStripButton();
            this.btnSagaHizala = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRenk = new System.Windows.Forms.ToolStripButton();
            this.btnFont = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDosyaAc = new System.Windows.Forms.ToolStripButton();
            this.BtnKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBuyuk = new System.Windows.Forms.ToolStripButton();
            this.btnKucuk = new System.Windows.Forms.ToolStripButton();
            this.btnBuyukKucuk = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SagTikMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SagTikCikis.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.ContextMenuStrip = this.SagTikMenu;
            this.richTextBox1.Location = new System.Drawing.Point(3, 62);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(880, 411);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // SagTikMenu
            // 
            this.SagTikMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SagTikMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesToolStripMenuItem1,
            this.kopyalaToolStripMenuItem1,
            this.yapıştırToolStripMenuItem1,
            this.tümünüSeçToolStripMenuItem,
            this.geriAlToolStripMenuItem,
            this.ileriAlToolStripMenuItem,
            this.alanıTemizleToolStripMenuItem});
            this.SagTikMenu.Name = "SagTikMenu";
            this.SagTikMenu.Size = new System.Drawing.Size(172, 186);
            // 
            // kesToolStripMenuItem1
            // 
            this.kesToolStripMenuItem1.Image = global::_55_Notepad_programı.Properties.Resources.kes;
            this.kesToolStripMenuItem1.Name = "kesToolStripMenuItem1";
            this.kesToolStripMenuItem1.Size = new System.Drawing.Size(171, 26);
            this.kesToolStripMenuItem1.Text = "Kes";
            this.kesToolStripMenuItem1.Click += new System.EventHandler(this.kesToolStripMenuItem1_Click);
            // 
            // kopyalaToolStripMenuItem1
            // 
            this.kopyalaToolStripMenuItem1.Image = global::_55_Notepad_programı.Properties.Resources.kopyala;
            this.kopyalaToolStripMenuItem1.Name = "kopyalaToolStripMenuItem1";
            this.kopyalaToolStripMenuItem1.Size = new System.Drawing.Size(171, 26);
            this.kopyalaToolStripMenuItem1.Text = "Kopyala";
            this.kopyalaToolStripMenuItem1.Click += new System.EventHandler(this.kopyalaToolStripMenuItem1_Click);
            // 
            // yapıştırToolStripMenuItem1
            // 
            this.yapıştırToolStripMenuItem1.Image = global::_55_Notepad_programı.Properties.Resources.yapıştır;
            this.yapıştırToolStripMenuItem1.Name = "yapıştırToolStripMenuItem1";
            this.yapıştırToolStripMenuItem1.Size = new System.Drawing.Size(171, 26);
            this.yapıştırToolStripMenuItem1.Text = "Yapıştır";
            this.yapıştırToolStripMenuItem1.Click += new System.EventHandler(this.yapıştırToolStripMenuItem1_Click);
            // 
            // tümünüSeçToolStripMenuItem
            // 
            this.tümünüSeçToolStripMenuItem.Image = global::_55_Notepad_programı.Properties.Resources.select_all;
            this.tümünüSeçToolStripMenuItem.Name = "tümünüSeçToolStripMenuItem";
            this.tümünüSeçToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.tümünüSeçToolStripMenuItem.Text = "Tümünü Seç";
            this.tümünüSeçToolStripMenuItem.Click += new System.EventHandler(this.tümünüSeçToolStripMenuItem_Click);
            // 
            // geriAlToolStripMenuItem
            // 
            this.geriAlToolStripMenuItem.Image = global::_55_Notepad_programı.Properties.Resources.gerial;
            this.geriAlToolStripMenuItem.Name = "geriAlToolStripMenuItem";
            this.geriAlToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.geriAlToolStripMenuItem.Text = "Geri Al";
            this.geriAlToolStripMenuItem.Click += new System.EventHandler(this.geriAlToolStripMenuItem_Click);
            // 
            // ileriAlToolStripMenuItem
            // 
            this.ileriAlToolStripMenuItem.Image = global::_55_Notepad_programı.Properties.Resources.ilerial;
            this.ileriAlToolStripMenuItem.Name = "ileriAlToolStripMenuItem";
            this.ileriAlToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.ileriAlToolStripMenuItem.Text = "İleri Al";
            this.ileriAlToolStripMenuItem.Click += new System.EventHandler(this.ileriAlToolStripMenuItem_Click);
            // 
            // alanıTemizleToolStripMenuItem
            // 
            this.alanıTemizleToolStripMenuItem.Image = global::_55_Notepad_programı.Properties.Resources.temizle;
            this.alanıTemizleToolStripMenuItem.Name = "alanıTemizleToolStripMenuItem";
            this.alanıTemizleToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.alanıTemizleToolStripMenuItem.Text = "Alanı Temizle";
            this.alanıTemizleToolStripMenuItem.Click += new System.EventHandler(this.alanıTemizleToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNum,
            this.lblCaps,
            this.lblKarakter});
            this.statusStrip1.Location = new System.Drawing.Point(0, 479);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(900, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblNum
            // 
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(75, 20);
            this.lblNum.Text = "Num Lock";
            // 
            // lblCaps
            // 
            this.lblCaps.Name = "lblCaps";
            this.lblCaps.Size = new System.Drawing.Size(75, 20);
            this.lblCaps.Text = "Caps Lock";
            this.lblCaps.Click += new System.EventHandler(this.lblCaps_Click);
            // 
            // lblKarakter
            // 
            this.lblKarakter.ForeColor = System.Drawing.Color.Sienna;
            this.lblKarakter.Name = "lblKarakter";
            this.lblKarakter.Size = new System.Drawing.Size(141, 20);
            this.lblKarakter.Text = "Karakter Uzunluğu:0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ContextMenuStrip = this.SagTikCikis;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenToolStripMenuItem,
            this.yardımToolStripMenuItem,
            this.çıkışYapToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SagTikCikis
            // 
            this.SagTikCikis.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SagTikCikis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışYapToolStripMenuItem});
            this.SagTikCikis.Name = "SagTikCikis";
            this.SagTikCikis.Size = new System.Drawing.Size(141, 30);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Image = global::_55_Notepad_programı.Properties.Resources.CikisYap;
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metinBelgesiAçToolStripMenuItem,
            this.dosyayıKaydetToolStripMenuItem,
            this.yeniBelgeToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // metinBelgesiAçToolStripMenuItem
            // 
            this.metinBelgesiAçToolStripMenuItem.Image = global::_55_Notepad_programı.Properties.Resources.DosyaAc;
            this.metinBelgesiAçToolStripMenuItem.Name = "metinBelgesiAçToolStripMenuItem";
            this.metinBelgesiAçToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.metinBelgesiAçToolStripMenuItem.Text = "Metin Belgesi Aç";
            // 
            // dosyayıKaydetToolStripMenuItem
            // 
            this.dosyayıKaydetToolStripMenuItem.Image = global::_55_Notepad_programı.Properties.Resources.kaydet;
            this.dosyayıKaydetToolStripMenuItem.Name = "dosyayıKaydetToolStripMenuItem";
            this.dosyayıKaydetToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.dosyayıKaydetToolStripMenuItem.Text = "Dosyayı Kaydet";
            // 
            // yeniBelgeToolStripMenuItem
            // 
            this.yeniBelgeToolStripMenuItem.Image = global::_55_Notepad_programı.Properties.Resources.yeni;
            this.yeniBelgeToolStripMenuItem.Name = "yeniBelgeToolStripMenuItem";
            this.yeniBelgeToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.yeniBelgeToolStripMenuItem.Text = "Yeni Belge";
            this.yeniBelgeToolStripMenuItem.Click += new System.EventHandler(this.yeniBelgeToolStripMenuItem_Click);
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.düzenToolStripMenuItem.Text = "Düzen";
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Image = global::_55_Notepad_programı.Properties.Resources.kes;
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.kesToolStripMenuItem.Text = "Kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click);
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Image = global::_55_Notepad_programı.Properties.Resources.kopyala;
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Image = global::_55_Notepad_programı.Properties.Resources.yapıştır;
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            this.yapıştırToolStripMenuItem.Click += new System.EventHandler(this.yapıştırToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Image = global::_55_Notepad_programı.Properties.Resources.yardim;
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // çıkışYapToolStripMenuItem1
            // 
            this.çıkışYapToolStripMenuItem1.Image = global::_55_Notepad_programı.Properties.Resources.CikisYap;
            this.çıkışYapToolStripMenuItem1.Name = "çıkışYapToolStripMenuItem1";
            this.çıkışYapToolStripMenuItem1.Size = new System.Drawing.Size(101, 24);
            this.çıkışYapToolStripMenuItem1.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem1.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnKes,
            this.btnKopyala,
            this.btnYapistir,
            this.toolStripSeparator1,
            this.btnSolaHizala,
            this.btnOrtala,
            this.btnSagaHizala,
            this.toolStripSeparator2,
            this.btnRenk,
            this.btnFont,
            this.toolStripSeparator3,
            this.btnDosyaAc,
            this.BtnKaydet,
            this.toolStripSeparator4,
            this.btnBuyuk,
            this.btnKucuk,
            this.btnBuyukKucuk,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(900, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnKes
            // 
            this.btnKes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKes.Image = global::_55_Notepad_programı.Properties.Resources.kes;
            this.btnKes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKes.Name = "btnKes";
            this.btnKes.Size = new System.Drawing.Size(29, 24);
            this.btnKes.Text = "Kes";
            this.btnKes.ToolTipText = "Kes";
            this.btnKes.Click += new System.EventHandler(this.btnKes_Click);
            // 
            // btnKopyala
            // 
            this.btnKopyala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKopyala.Image = global::_55_Notepad_programı.Properties.Resources.kopyala;
            this.btnKopyala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(29, 24);
            this.btnKopyala.Text = "toolStripButton2";
            this.btnKopyala.ToolTipText = "Kopyala";
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // btnYapistir
            // 
            this.btnYapistir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYapistir.Image = global::_55_Notepad_programı.Properties.Resources.yapıştır;
            this.btnYapistir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYapistir.Name = "btnYapistir";
            this.btnYapistir.Size = new System.Drawing.Size(29, 24);
            this.btnYapistir.Text = "toolStripButton3";
            this.btnYapistir.ToolTipText = "Yapıştır";
            this.btnYapistir.Click += new System.EventHandler(this.btnYapistir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnSolaHizala
            // 
            this.btnSolaHizala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSolaHizala.Image = global::_55_Notepad_programı.Properties.Resources.SolaHizala;
            this.btnSolaHizala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSolaHizala.Name = "btnSolaHizala";
            this.btnSolaHizala.Size = new System.Drawing.Size(29, 24);
            this.btnSolaHizala.Text = "toolStripButton4";
            this.btnSolaHizala.ToolTipText = "Sola Hizala";
            this.btnSolaHizala.Click += new System.EventHandler(this.btnSolaHizala_Click);
            // 
            // btnOrtala
            // 
            this.btnOrtala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOrtala.Image = global::_55_Notepad_programı.Properties.Resources.Ortala;
            this.btnOrtala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOrtala.Name = "btnOrtala";
            this.btnOrtala.Size = new System.Drawing.Size(29, 24);
            this.btnOrtala.Text = "toolStripButton5";
            this.btnOrtala.ToolTipText = "Ortala";
            this.btnOrtala.Click += new System.EventHandler(this.btnOrtala_Click);
            // 
            // btnSagaHizala
            // 
            this.btnSagaHizala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSagaHizala.Image = global::_55_Notepad_programı.Properties.Resources.SagaHizala;
            this.btnSagaHizala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSagaHizala.Name = "btnSagaHizala";
            this.btnSagaHizala.Size = new System.Drawing.Size(29, 24);
            this.btnSagaHizala.Text = "toolStripButton6";
            this.btnSagaHizala.ToolTipText = "Sağa Hizala";
            this.btnSagaHizala.Click += new System.EventHandler(this.btnSagaHizala_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnRenk
            // 
            this.btnRenk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRenk.Image = global::_55_Notepad_programı.Properties.Resources.Color;
            this.btnRenk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(29, 24);
            this.btnRenk.Text = "toolStripButton7";
            this.btnRenk.ToolTipText = "Renk Değiştir";
            this.btnRenk.Click += new System.EventHandler(this.btnRenk_Click);
            // 
            // btnFont
            // 
            this.btnFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFont.Image = global::_55_Notepad_programı.Properties.Resources.Font;
            this.btnFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(29, 24);
            this.btnFont.Text = "toolStripButton8";
            this.btnFont.ToolTipText = "Yazı Fontu";
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // btnDosyaAc
            // 
            this.btnDosyaAc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDosyaAc.Image = global::_55_Notepad_programı.Properties.Resources.DosyaAc;
            this.btnDosyaAc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDosyaAc.Name = "btnDosyaAc";
            this.btnDosyaAc.Size = new System.Drawing.Size(29, 24);
            this.btnDosyaAc.Text = "toolStripButton9";
            this.btnDosyaAc.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnDosyaAc.ToolTipText = "Dosya Aç";
            this.btnDosyaAc.Click += new System.EventHandler(this.btnDosyaAc_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnKaydet.Image = global::_55_Notepad_programı.Properties.Resources.kaydet;
            this.BtnKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(29, 24);
            this.BtnKaydet.Text = "toolStripButton10";
            this.BtnKaydet.ToolTipText = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // btnBuyuk
            // 
            this.btnBuyuk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuyuk.Image = global::_55_Notepad_programı.Properties.Resources.buyukharf;
            this.btnBuyuk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuyuk.Name = "btnBuyuk";
            this.btnBuyuk.Size = new System.Drawing.Size(29, 24);
            this.btnBuyuk.Text = "toolStripButton1";
            this.btnBuyuk.ToolTipText = "Büyük Harfe Dönüştür";
            this.btnBuyuk.Click += new System.EventHandler(this.btnBuyuk_Click);
            // 
            // btnKucuk
            // 
            this.btnKucuk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKucuk.Image = global::_55_Notepad_programı.Properties.Resources.kucukharf;
            this.btnKucuk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKucuk.Name = "btnKucuk";
            this.btnKucuk.Size = new System.Drawing.Size(29, 24);
            this.btnKucuk.Text = "toolStripButton3";
            this.btnKucuk.ToolTipText = "Küçük Harfe Dönüştür";
            this.btnKucuk.Click += new System.EventHandler(this.btnKucuk_Click);
            // 
            // btnBuyukKucuk
            // 
            this.btnBuyukKucuk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuyukKucuk.Image = global::_55_Notepad_programı.Properties.Resources.buyukkucukharf;
            this.btnBuyukKucuk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuyukKucuk.Name = "btnBuyukKucuk";
            this.btnBuyukKucuk.Size = new System.Drawing.Size(29, 24);
            this.btnBuyukKucuk.Text = "toolStripButton2";
            this.btnBuyukKucuk.ToolTipText = "İlk Harfi Büyük Yap";
            this.btnBuyukKucuk.Click += new System.EventHandler(this.btnBuyukKucuk_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.SagTikCikis;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "NotePad v1.0";
            this.notifyIcon1.Visible = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 505);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "NotePad Programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SagTikMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SagTikCikis.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblNum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metinBelgesiAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyayıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnKes;
        private System.Windows.Forms.ToolStripButton btnKopyala;
        private System.Windows.Forms.ToolStripButton btnYapistir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSolaHizala;
        private System.Windows.Forms.ToolStripButton btnOrtala;
        private System.Windows.Forms.ToolStripButton btnSagaHizala;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnRenk;
        private System.Windows.Forms.ToolStripButton btnFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnDosyaAc;
        private System.Windows.Forms.ToolStripButton BtnKaydet;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip SagTikMenu;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip SagTikCikis;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem yeniBelgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblCaps;
        private System.Windows.Forms.ToolStripStatusLabel lblKarakter;
        private System.Windows.Forms.ToolStripMenuItem tümünüSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ileriAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alanıTemizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnBuyuk;
        private System.Windows.Forms.ToolStripButton btnKucuk;
        private System.Windows.Forms.ToolStripButton btnBuyukKucuk;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem1;
    }
}

