namespace WDUD
{
    partial class KullaniciGirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGirisForm));
            this.label4 = new System.Windows.Forms.Label();
            this.KapatLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GirisButon = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SifreTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.KullaniciAdTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.HesapOlusturLabel = new System.Windows.Forms.Label();
            this.GirisLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label4.Location = new System.Drawing.Point(434, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "--";
            // 
            // KapatLabel
            // 
            this.KapatLabel.AutoSize = true;
            this.KapatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KapatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.KapatLabel.Location = new System.Drawing.Point(467, 9);
            this.KapatLabel.Name = "KapatLabel";
            this.KapatLabel.Size = new System.Drawing.Size(26, 25);
            this.KapatLabel.TabIndex = 14;
            this.KapatLabel.Text = "X";
            this.KapatLabel.Click += new System.EventHandler(this.KapatLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(157, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(171, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 53);
            this.label2.TabIndex = 12;
            this.label2.Text = "WDUD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(120, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Oturum Aç";
            // 
            // GirisButon
            // 
            this.GirisButon.ActiveBorderThickness = 2;
            this.GirisButon.ActiveCornerRadius = 20;
            this.GirisButon.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.GirisButon.ActiveForecolor = System.Drawing.Color.White;
            this.GirisButon.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.GirisButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.GirisButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GirisButon.BackgroundImage")));
            this.GirisButon.ButtonText = "Giriş";
            this.GirisButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GirisButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GirisButon.ForeColor = System.Drawing.Color.SeaGreen;
            this.GirisButon.IdleBorderThickness = 4;
            this.GirisButon.IdleCornerRadius = 20;
            this.GirisButon.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.GirisButon.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.GirisButon.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.GirisButon.Location = new System.Drawing.Point(112, 443);
            this.GirisButon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GirisButon.Name = "GirisButon";
            this.GirisButon.Size = new System.Drawing.Size(283, 49);
            this.GirisButon.TabIndex = 10;
            this.GirisButon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GirisButon.Click += new System.EventHandler(this.GirisButon_Click);
            // 
            // SifreTextBox
            // 
            this.SifreTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SifreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SifreTextBox.ForeColor = System.Drawing.Color.Black;
            this.SifreTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.SifreTextBox.HintText = "Şifre";
            this.SifreTextBox.isPassword = true;
            this.SifreTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.SifreTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.SifreTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.SifreTextBox.LineThickness = 4;
            this.SifreTextBox.Location = new System.Drawing.Point(112, 320);
            this.SifreTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.SifreTextBox.Name = "SifreTextBox";
            this.SifreTextBox.Size = new System.Drawing.Size(283, 41);
            this.SifreTextBox.TabIndex = 9;
            this.SifreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SifreTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SifreTextBox_KeyDown);
            // 
            // KullaniciAdTextBox
            // 
            this.KullaniciAdTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KullaniciAdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.KullaniciAdTextBox.ForeColor = System.Drawing.Color.Black;
            this.KullaniciAdTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.KullaniciAdTextBox.HintText = "Kullanıcı Adı";
            this.KullaniciAdTextBox.isPassword = false;
            this.KullaniciAdTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.KullaniciAdTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.KullaniciAdTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.KullaniciAdTextBox.LineThickness = 4;
            this.KullaniciAdTextBox.Location = new System.Drawing.Point(112, 254);
            this.KullaniciAdTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.KullaniciAdTextBox.Name = "KullaniciAdTextBox";
            this.KullaniciAdTextBox.Size = new System.Drawing.Size(283, 41);
            this.KullaniciAdTextBox.TabIndex = 8;
            this.KullaniciAdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.KullaniciAdTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KullaniciAdTextBox_KeyDown);
            // 
            // HesapOlusturLabel
            // 
            this.HesapOlusturLabel.AutoSize = true;
            this.HesapOlusturLabel.BackColor = System.Drawing.Color.Transparent;
            this.HesapOlusturLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HesapOlusturLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HesapOlusturLabel.Location = new System.Drawing.Point(108, 388);
            this.HesapOlusturLabel.Name = "HesapOlusturLabel";
            this.HesapOlusturLabel.Size = new System.Drawing.Size(109, 19);
            this.HesapOlusturLabel.TabIndex = 16;
            this.HesapOlusturLabel.Text = "Hesap Oluştur";
            this.HesapOlusturLabel.Click += new System.EventHandler(this.HesapOlusturLabel_Click);
            // 
            // GirisLabel
            // 
            this.GirisLabel.AutoSize = true;
            this.GirisLabel.BackColor = System.Drawing.Color.Transparent;
            this.GirisLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GirisLabel.Location = new System.Drawing.Point(121, 507);
            this.GirisLabel.Name = "GirisLabel";
            this.GirisLabel.Size = new System.Drawing.Size(18, 23);
            this.GirisLabel.TabIndex = 17;
            this.GirisLabel.Text = "-";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // KullaniciGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(499, 567);
            this.Controls.Add(this.GirisLabel);
            this.Controls.Add(this.HesapOlusturLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KapatLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GirisButon);
            this.Controls.Add(this.SifreTextBox);
            this.Controls.Add(this.KullaniciAdTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KullaniciGirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciGirisForm";
            this.Load += new System.EventHandler(this.KullaniciGirisForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KullaniciGirisForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label KapatLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SifreTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox KullaniciAdTextBox;
        public Bunifu.Framework.UI.BunifuThinButton2 GirisButon;
        private System.Windows.Forms.Label HesapOlusturLabel;
        private System.Windows.Forms.Label GirisLabel;
        private System.Windows.Forms.Timer timer;
    }
}