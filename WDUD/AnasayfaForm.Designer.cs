namespace WDUD
{
    partial class AnasayfaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnasayfaForm));
            this.UstBarPanel = new System.Windows.Forms.Panel();
            this.AltaAlLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.KapatLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KullaniciResim = new System.Windows.Forms.PictureBox();
            this.CubukLabel = new System.Windows.Forms.Label();
            this.DikIconCubuguLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.YapilacaklarButon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KelimelerButon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.KullaniciAdiLabel = new System.Windows.Forms.Label();
            this.ProfilButon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.AlarmButon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.GünlükAktivitelerButon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.KitaplarButon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.PanelCubukPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.İcerikPanel = new System.Windows.Forms.Panel();
            this.PanelAcKapaTimer = new System.Windows.Forms.Timer(this.components);
            this.PanelAcTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.UstBarPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciResim)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelCubukPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // UstBarPanel
            // 
            this.UstBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(174)))), ((int)(((byte)(88)))));
            this.UstBarPanel.Controls.Add(this.AltaAlLabel);
            this.UstBarPanel.Controls.Add(this.label9);
            this.UstBarPanel.Controls.Add(this.KapatLabel);
            this.UstBarPanel.Location = new System.Drawing.Point(186, 0);
            this.UstBarPanel.Name = "UstBarPanel";
            this.UstBarPanel.Size = new System.Drawing.Size(1060, 32);
            this.UstBarPanel.TabIndex = 9;
            this.UstBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UstBarPanel_MouseMove);
            // 
            // AltaAlLabel
            // 
            this.AltaAlLabel.AutoSize = true;
            this.AltaAlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AltaAlLabel.ForeColor = System.Drawing.Color.Black;
            this.AltaAlLabel.Location = new System.Drawing.Point(869, 5);
            this.AltaAlLabel.Name = "AltaAlLabel";
            this.AltaAlLabel.Size = new System.Drawing.Size(26, 25);
            this.AltaAlLabel.TabIndex = 9;
            this.AltaAlLabel.Text = "--";
            this.AltaAlLabel.Click += new System.EventHandler(this.AltaAlLabel_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.label9.Location = new System.Drawing.Point(-3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1062, 5);
            this.label9.TabIndex = 12;
            // 
            // KapatLabel
            // 
            this.KapatLabel.AutoSize = true;
            this.KapatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KapatLabel.ForeColor = System.Drawing.Color.Black;
            this.KapatLabel.Location = new System.Drawing.Point(902, 5);
            this.KapatLabel.Name = "KapatLabel";
            this.KapatLabel.Size = new System.Drawing.Size(26, 25);
            this.KapatLabel.TabIndex = 8;
            this.KapatLabel.Text = "X";
            this.KapatLabel.Click += new System.EventHandler(this.KapatLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.KullaniciResim);
            this.panel1.Controls.Add(this.CubukLabel);
            this.panel1.Controls.Add(this.DikIconCubuguLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.YapilacaklarButon);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.KelimelerButon);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.KullaniciAdiLabel);
            this.panel1.Controls.Add(this.ProfilButon);
            this.panel1.Controls.Add(this.AlarmButon);
            this.panel1.Controls.Add(this.GünlükAktivitelerButon);
            this.panel1.Controls.Add(this.KitaplarButon);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 631);
            this.panel1.TabIndex = 13;
            // 
            // KullaniciResim
            // 
            this.KullaniciResim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(174)))), ((int)(((byte)(88)))));
            this.KullaniciResim.Image = ((System.Drawing.Image)(resources.GetObject("KullaniciResim.Image")));
            this.KullaniciResim.Location = new System.Drawing.Point(33, 122);
            this.KullaniciResim.Name = "KullaniciResim";
            this.KullaniciResim.Size = new System.Drawing.Size(124, 115);
            this.KullaniciResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.KullaniciResim.TabIndex = 0;
            this.KullaniciResim.TabStop = false;
            this.KullaniciResim.Click += new System.EventHandler(this.KullaniciResim_Click);
            // 
            // CubukLabel
            // 
            this.CubukLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(174)))), ((int)(((byte)(88)))));
            this.CubukLabel.Location = new System.Drawing.Point(184, 35);
            this.CubukLabel.Name = "CubukLabel";
            this.CubukLabel.Size = new System.Drawing.Size(2, 595);
            this.CubukLabel.TabIndex = 12;
            // 
            // DikIconCubuguLabel
            // 
            this.DikIconCubuguLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(174)))), ((int)(((byte)(88)))));
            this.DikIconCubuguLabel.Location = new System.Drawing.Point(59, 35);
            this.DikIconCubuguLabel.Name = "DikIconCubuguLabel";
            this.DikIconCubuguLabel.Size = new System.Drawing.Size(3, 595);
            this.DikIconCubuguLabel.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label5.Location = new System.Drawing.Point(0, 468);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 3);
            this.label5.TabIndex = 10;
            // 
            // YapilacaklarButon
            // 
            this.YapilacaklarButon.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.YapilacaklarButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.YapilacaklarButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.YapilacaklarButon.BorderRadius = 0;
            this.YapilacaklarButon.ButtonText = "     Yapılacaklar";
            this.YapilacaklarButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YapilacaklarButon.DisabledColor = System.Drawing.Color.Gray;
            this.YapilacaklarButon.Iconcolor = System.Drawing.Color.Transparent;
            this.YapilacaklarButon.Iconimage = ((System.Drawing.Image)(resources.GetObject("YapilacaklarButon.Iconimage")));
            this.YapilacaklarButon.Iconimage_right = null;
            this.YapilacaklarButon.Iconimage_right_Selected = null;
            this.YapilacaklarButon.Iconimage_Selected = null;
            this.YapilacaklarButon.IconMarginLeft = 0;
            this.YapilacaklarButon.IconMarginRight = 0;
            this.YapilacaklarButon.IconRightVisible = true;
            this.YapilacaklarButon.IconRightZoom = 0D;
            this.YapilacaklarButon.IconVisible = true;
            this.YapilacaklarButon.IconZoom = 90D;
            this.YapilacaklarButon.IsTab = false;
            this.YapilacaklarButon.Location = new System.Drawing.Point(0, 470);
            this.YapilacaklarButon.Name = "YapilacaklarButon";
            this.YapilacaklarButon.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.YapilacaklarButon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.YapilacaklarButon.OnHoverTextColor = System.Drawing.Color.White;
            this.YapilacaklarButon.selected = false;
            this.YapilacaklarButon.Size = new System.Drawing.Size(187, 52);
            this.YapilacaklarButon.TabIndex = 2;
            this.YapilacaklarButon.Text = "     Yapılacaklar";
            this.YapilacaklarButon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.YapilacaklarButon.Textcolor = System.Drawing.Color.White;
            this.YapilacaklarButon.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YapilacaklarButon.Click += new System.EventHandler(this.butonEvent);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label7.Location = new System.Drawing.Point(0, 573);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 3);
            this.label7.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label6.Location = new System.Drawing.Point(0, 521);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 3);
            this.label6.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label4.Location = new System.Drawing.Point(0, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 3);
            this.label4.TabIndex = 9;
            // 
            // KelimelerButon
            // 
            this.KelimelerButon.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.KelimelerButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.KelimelerButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KelimelerButon.BorderRadius = 0;
            this.KelimelerButon.ButtonText = "     Kelimeler";
            this.KelimelerButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KelimelerButon.DisabledColor = System.Drawing.Color.Gray;
            this.KelimelerButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KelimelerButon.Iconcolor = System.Drawing.Color.Transparent;
            this.KelimelerButon.Iconimage = ((System.Drawing.Image)(resources.GetObject("KelimelerButon.Iconimage")));
            this.KelimelerButon.Iconimage_right = null;
            this.KelimelerButon.Iconimage_right_Selected = null;
            this.KelimelerButon.Iconimage_Selected = null;
            this.KelimelerButon.IconMarginLeft = 0;
            this.KelimelerButon.IconMarginRight = 0;
            this.KelimelerButon.IconRightVisible = true;
            this.KelimelerButon.IconRightZoom = 0D;
            this.KelimelerButon.IconVisible = true;
            this.KelimelerButon.IconZoom = 90D;
            this.KelimelerButon.IsTab = false;
            this.KelimelerButon.Location = new System.Drawing.Point(1, 315);
            this.KelimelerButon.Margin = new System.Windows.Forms.Padding(5);
            this.KelimelerButon.Name = "KelimelerButon";
            this.KelimelerButon.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.KelimelerButon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.KelimelerButon.OnHoverTextColor = System.Drawing.Color.White;
            this.KelimelerButon.selected = false;
            this.KelimelerButon.Size = new System.Drawing.Size(187, 52);
            this.KelimelerButon.TabIndex = 1;
            this.KelimelerButon.Text = "     Kelimeler";
            this.KelimelerButon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KelimelerButon.Textcolor = System.Drawing.Color.White;
            this.KelimelerButon.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KelimelerButon.Click += new System.EventHandler(this.butonEvent);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label3.Location = new System.Drawing.Point(-2, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 3);
            this.label3.TabIndex = 8;
            // 
            // KullaniciAdiLabel
            // 
            this.KullaniciAdiLabel.AutoSize = true;
            this.KullaniciAdiLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciAdiLabel.ForeColor = System.Drawing.Color.Transparent;
            this.KullaniciAdiLabel.Location = new System.Drawing.Point(59, 254);
            this.KullaniciAdiLabel.Name = "KullaniciAdiLabel";
            this.KullaniciAdiLabel.Size = new System.Drawing.Size(66, 27);
            this.KullaniciAdiLabel.TabIndex = 7;
            this.KullaniciAdiLabel.Text = "Omar";
            // 
            // ProfilButon
            // 
            this.ProfilButon.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.ProfilButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.ProfilButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfilButon.BorderRadius = 0;
            this.ProfilButon.ButtonText = "     Profil";
            this.ProfilButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfilButon.DisabledColor = System.Drawing.Color.Gray;
            this.ProfilButon.Iconcolor = System.Drawing.Color.Transparent;
            this.ProfilButon.Iconimage = ((System.Drawing.Image)(resources.GetObject("ProfilButon.Iconimage")));
            this.ProfilButon.Iconimage_right = null;
            this.ProfilButon.Iconimage_right_Selected = null;
            this.ProfilButon.Iconimage_Selected = null;
            this.ProfilButon.IconMarginLeft = 0;
            this.ProfilButon.IconMarginRight = 0;
            this.ProfilButon.IconRightVisible = true;
            this.ProfilButon.IconRightZoom = 0D;
            this.ProfilButon.IconVisible = true;
            this.ProfilButon.IconZoom = 90D;
            this.ProfilButon.IsTab = false;
            this.ProfilButon.Location = new System.Drawing.Point(0, 574);
            this.ProfilButon.Name = "ProfilButon";
            this.ProfilButon.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.ProfilButon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.ProfilButon.OnHoverTextColor = System.Drawing.Color.White;
            this.ProfilButon.selected = false;
            this.ProfilButon.Size = new System.Drawing.Size(187, 52);
            this.ProfilButon.TabIndex = 5;
            this.ProfilButon.Text = "     Profil";
            this.ProfilButon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfilButon.Textcolor = System.Drawing.Color.White;
            this.ProfilButon.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfilButon.Click += new System.EventHandler(this.butonEvent);
            // 
            // AlarmButon
            // 
            this.AlarmButon.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.AlarmButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.AlarmButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AlarmButon.BorderRadius = 0;
            this.AlarmButon.ButtonText = "     Alarm";
            this.AlarmButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AlarmButon.DisabledColor = System.Drawing.Color.Gray;
            this.AlarmButon.Iconcolor = System.Drawing.Color.Transparent;
            this.AlarmButon.Iconimage = ((System.Drawing.Image)(resources.GetObject("AlarmButon.Iconimage")));
            this.AlarmButon.Iconimage_right = null;
            this.AlarmButon.Iconimage_right_Selected = null;
            this.AlarmButon.Iconimage_Selected = null;
            this.AlarmButon.IconMarginLeft = 0;
            this.AlarmButon.IconMarginRight = 0;
            this.AlarmButon.IconRightVisible = true;
            this.AlarmButon.IconRightZoom = 0D;
            this.AlarmButon.IconVisible = true;
            this.AlarmButon.IconZoom = 90D;
            this.AlarmButon.IsTab = false;
            this.AlarmButon.Location = new System.Drawing.Point(0, 523);
            this.AlarmButon.Name = "AlarmButon";
            this.AlarmButon.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.AlarmButon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.AlarmButon.OnHoverTextColor = System.Drawing.Color.White;
            this.AlarmButon.selected = false;
            this.AlarmButon.Size = new System.Drawing.Size(187, 52);
            this.AlarmButon.TabIndex = 6;
            this.AlarmButon.Text = "     Alarm";
            this.AlarmButon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AlarmButon.Textcolor = System.Drawing.Color.White;
            this.AlarmButon.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmButon.Click += new System.EventHandler(this.butonEvent);
            // 
            // GünlükAktivitelerButon
            // 
            this.GünlükAktivitelerButon.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.GünlükAktivitelerButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.GünlükAktivitelerButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GünlükAktivitelerButon.BorderRadius = 0;
            this.GünlükAktivitelerButon.ButtonText = "     Günlük Aktiviteler";
            this.GünlükAktivitelerButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GünlükAktivitelerButon.DisabledColor = System.Drawing.Color.Gray;
            this.GünlükAktivitelerButon.Iconcolor = System.Drawing.Color.Transparent;
            this.GünlükAktivitelerButon.Iconimage = ((System.Drawing.Image)(resources.GetObject("GünlükAktivitelerButon.Iconimage")));
            this.GünlükAktivitelerButon.Iconimage_right = null;
            this.GünlükAktivitelerButon.Iconimage_right_Selected = null;
            this.GünlükAktivitelerButon.Iconimage_Selected = null;
            this.GünlükAktivitelerButon.IconMarginLeft = 0;
            this.GünlükAktivitelerButon.IconMarginRight = 0;
            this.GünlükAktivitelerButon.IconRightVisible = true;
            this.GünlükAktivitelerButon.IconRightZoom = 0D;
            this.GünlükAktivitelerButon.IconVisible = true;
            this.GünlükAktivitelerButon.IconZoom = 90D;
            this.GünlükAktivitelerButon.IsTab = false;
            this.GünlükAktivitelerButon.Location = new System.Drawing.Point(0, 418);
            this.GünlükAktivitelerButon.Name = "GünlükAktivitelerButon";
            this.GünlükAktivitelerButon.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.GünlükAktivitelerButon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.GünlükAktivitelerButon.OnHoverTextColor = System.Drawing.Color.White;
            this.GünlükAktivitelerButon.selected = false;
            this.GünlükAktivitelerButon.Size = new System.Drawing.Size(187, 52);
            this.GünlükAktivitelerButon.TabIndex = 4;
            this.GünlükAktivitelerButon.Text = "     Günlük Aktiviteler";
            this.GünlükAktivitelerButon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GünlükAktivitelerButon.Textcolor = System.Drawing.Color.White;
            this.GünlükAktivitelerButon.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GünlükAktivitelerButon.Click += new System.EventHandler(this.butonEvent);
            // 
            // KitaplarButon
            // 
            this.KitaplarButon.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.KitaplarButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.KitaplarButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KitaplarButon.BorderRadius = 0;
            this.KitaplarButon.ButtonText = "     Kitaplar";
            this.KitaplarButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KitaplarButon.DisabledColor = System.Drawing.Color.Gray;
            this.KitaplarButon.Iconcolor = System.Drawing.Color.Transparent;
            this.KitaplarButon.Iconimage = ((System.Drawing.Image)(resources.GetObject("KitaplarButon.Iconimage")));
            this.KitaplarButon.Iconimage_right = null;
            this.KitaplarButon.Iconimage_right_Selected = null;
            this.KitaplarButon.Iconimage_Selected = null;
            this.KitaplarButon.IconMarginLeft = 0;
            this.KitaplarButon.IconMarginRight = 0;
            this.KitaplarButon.IconRightVisible = true;
            this.KitaplarButon.IconRightZoom = 0D;
            this.KitaplarButon.IconVisible = true;
            this.KitaplarButon.IconZoom = 90D;
            this.KitaplarButon.IsTab = false;
            this.KitaplarButon.Location = new System.Drawing.Point(0, 365);
            this.KitaplarButon.Name = "KitaplarButon";
            this.KitaplarButon.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.KitaplarButon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.KitaplarButon.OnHoverTextColor = System.Drawing.Color.White;
            this.KitaplarButon.selected = false;
            this.KitaplarButon.Size = new System.Drawing.Size(187, 52);
            this.KitaplarButon.TabIndex = 3;
            this.KitaplarButon.Text = "     Kitaplar";
            this.KitaplarButon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KitaplarButon.Textcolor = System.Drawing.Color.White;
            this.KitaplarButon.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KitaplarButon.Click += new System.EventHandler(this.butonEvent);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(174)))), ((int)(((byte)(88)))));
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.PanelCubukPictureBox);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.pictureBox6);
            this.panel4.Controls.Add(this.label12);
            this.panel4.ForeColor = System.Drawing.Color.Cornsilk;
            this.panel4.Location = new System.Drawing.Point(1, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(186, 114);
            this.panel4.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(174)))), ((int)(((byte)(88)))));
            this.label11.Location = new System.Drawing.Point(-2, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 1);
            this.label11.TabIndex = 12;
            // 
            // PanelCubukPictureBox
            // 
            this.PanelCubukPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.PanelCubukPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PanelCubukPictureBox.Image")));
            this.PanelCubukPictureBox.Location = new System.Drawing.Point(150, 1);
            this.PanelCubukPictureBox.Name = "PanelCubukPictureBox";
            this.PanelCubukPictureBox.Size = new System.Drawing.Size(32, 32);
            this.PanelCubukPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PanelCubukPictureBox.TabIndex = 1;
            this.PanelCubukPictureBox.TabStop = false;
            this.PanelCubukPictureBox.Click += new System.EventHandler(this.PanelCubukPictureBox_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.pictureBox4.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(188, 33);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(4, 39);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(63, 51);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(11, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 53);
            this.label12.TabIndex = 6;
            this.label12.Text = "WDUD";
            // 
            // İcerikPanel
            // 
            this.İcerikPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.İcerikPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.İcerikPanel.Location = new System.Drawing.Point(186, 32);
            this.İcerikPanel.Name = "İcerikPanel";
            this.İcerikPanel.Size = new System.Drawing.Size(933, 594);
            this.İcerikPanel.TabIndex = 14;
            // 
            // PanelAcKapaTimer
            // 
            this.PanelAcKapaTimer.Interval = 10;
            this.PanelAcKapaTimer.Tick += new System.EventHandler(this.PanelAcKapaTimer_Tick);
            // 
            // PanelAcTimer
            // 
            this.PanelAcTimer.Interval = 10;
            this.PanelAcTimer.Tick += new System.EventHandler(this.PanelAcTimer_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // AnasayfaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 626);
            this.Controls.Add(this.İcerikPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UstBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnasayfaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YapılacaklarForm";
            this.Load += new System.EventHandler(this.AnasayfaForm_Load);
            this.UstBarPanel.ResumeLayout(false);
            this.UstBarPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciResim)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelCubukPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UstBarPanel;
        private System.Windows.Forms.Label AltaAlLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CubukLabel;
        private System.Windows.Forms.Label DikIconCubuguLabel;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton YapilacaklarButon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton KelimelerButon;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton ProfilButon;
        private Bunifu.Framework.UI.BunifuFlatButton AlarmButon;
        private Bunifu.Framework.UI.BunifuFlatButton GünlükAktivitelerButon;
        private Bunifu.Framework.UI.BunifuFlatButton KitaplarButon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox PanelCubukPictureBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel İcerikPanel;
        private System.Windows.Forms.Timer PanelAcKapaTimer;
        private System.Windows.Forms.Timer PanelAcTimer;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label KapatLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        public System.Windows.Forms.Label KullaniciAdiLabel;
        private System.Windows.Forms.PictureBox KullaniciResim;
    }
}