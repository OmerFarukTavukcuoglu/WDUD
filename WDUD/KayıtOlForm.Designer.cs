namespace WDUD
{
    partial class KayıtOlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayıtOlForm));
            this.label1 = new System.Windows.Forms.Label();
            this.GirisButon = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SifreTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.KullaniciAdTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MailAdresTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.CaptchaTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SifreTekrarTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.KayıtBasariliTimer = new System.Windows.Forms.Timer(this.components);
            this.KayıtBasariliLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.BallGifPictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.KapatLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BallGifPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(105, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Kayıt Ol";
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
            this.GirisButon.ButtonText = "Kaydol";
            this.GirisButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GirisButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GirisButon.ForeColor = System.Drawing.Color.SeaGreen;
            this.GirisButon.IdleBorderThickness = 4;
            this.GirisButon.IdleCornerRadius = 20;
            this.GirisButon.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.GirisButon.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.GirisButon.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.GirisButon.Location = new System.Drawing.Point(108, 482);
            this.GirisButon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GirisButon.Name = "GirisButon";
            this.GirisButon.Size = new System.Drawing.Size(284, 49);
            this.GirisButon.TabIndex = 5;
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
            this.SifreTextBox.Location = new System.Drawing.Point(108, 168);
            this.SifreTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.SifreTextBox.Name = "SifreTextBox";
            this.SifreTextBox.Size = new System.Drawing.Size(283, 41);
            this.SifreTextBox.TabIndex = 1;
            this.SifreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SifreTextBox.Leave += new System.EventHandler(this.SifreTextBox_Leave);
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
            this.KullaniciAdTextBox.Location = new System.Drawing.Point(108, 92);
            this.KullaniciAdTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.KullaniciAdTextBox.Name = "KullaniciAdTextBox";
            this.KullaniciAdTextBox.Size = new System.Drawing.Size(283, 41);
            this.KullaniciAdTextBox.TabIndex = 0;
            this.KullaniciAdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.KullaniciAdTextBox.Leave += new System.EventHandler(this.KullaniciAdTextBox_Leave);
            // 
            // MailAdresTextBox
            // 
            this.MailAdresTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MailAdresTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MailAdresTextBox.ForeColor = System.Drawing.Color.Black;
            this.MailAdresTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.MailAdresTextBox.HintText = "Mail Adresi";
            this.MailAdresTextBox.isPassword = false;
            this.MailAdresTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.MailAdresTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.MailAdresTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.MailAdresTextBox.LineThickness = 4;
            this.MailAdresTextBox.Location = new System.Drawing.Point(109, 298);
            this.MailAdresTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.MailAdresTextBox.Name = "MailAdresTextBox";
            this.MailAdresTextBox.Size = new System.Drawing.Size(283, 41);
            this.MailAdresTextBox.TabIndex = 3;
            this.MailAdresTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MailAdresTextBox.Leave += new System.EventHandler(this.MailAdresTextBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(104, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Captcha Kodu:";
            // 
            // CaptchaTextBox
            // 
            this.CaptchaTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CaptchaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CaptchaTextBox.ForeColor = System.Drawing.Color.Black;
            this.CaptchaTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.CaptchaTextBox.HintText = "";
            this.CaptchaTextBox.isPassword = false;
            this.CaptchaTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.CaptchaTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.CaptchaTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.CaptchaTextBox.LineThickness = 4;
            this.CaptchaTextBox.Location = new System.Drawing.Point(109, 416);
            this.CaptchaTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CaptchaTextBox.Name = "CaptchaTextBox";
            this.CaptchaTextBox.Size = new System.Drawing.Size(283, 41);
            this.CaptchaTextBox.TabIndex = 4;
            this.CaptchaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptchaTextBox.Leave += new System.EventHandler(this.CaptchaTextBox_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(228, 360);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 32);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // SifreTekrarTextBox
            // 
            this.SifreTekrarTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SifreTekrarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SifreTekrarTextBox.ForeColor = System.Drawing.Color.Black;
            this.SifreTekrarTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.SifreTekrarTextBox.HintText = "Şifre";
            this.SifreTekrarTextBox.isPassword = true;
            this.SifreTekrarTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.SifreTekrarTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.SifreTekrarTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.SifreTekrarTextBox.LineThickness = 4;
            this.SifreTekrarTextBox.Location = new System.Drawing.Point(110, 236);
            this.SifreTekrarTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.SifreTekrarTextBox.Name = "SifreTekrarTextBox";
            this.SifreTekrarTextBox.Size = new System.Drawing.Size(283, 41);
            this.SifreTekrarTextBox.TabIndex = 2;
            this.SifreTekrarTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SifreTekrarTextBox.Leave += new System.EventHandler(this.SifreTekrarTextBox_Leave);
            // 
            // KayıtBasariliTimer
            // 
            this.KayıtBasariliTimer.Tick += new System.EventHandler(this.KayıtBasariliTimer_Tick);
            // 
            // KayıtBasariliLabel
            // 
            this.KayıtBasariliLabel.AutoSize = true;
            this.KayıtBasariliLabel.BackColor = System.Drawing.Color.Transparent;
            this.KayıtBasariliLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayıtBasariliLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KayıtBasariliLabel.Location = new System.Drawing.Point(75, 576);
            this.KayıtBasariliLabel.Name = "KayıtBasariliLabel";
            this.KayıtBasariliLabel.Size = new System.Drawing.Size(0, 30);
            this.KayıtBasariliLabel.TabIndex = 23;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // BallGifPictureBox
            // 
            this.BallGifPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("BallGifPictureBox.Image")));
            this.BallGifPictureBox.Location = new System.Drawing.Point(202, 552);
            this.BallGifPictureBox.Name = "BallGifPictureBox";
            this.BallGifPictureBox.Size = new System.Drawing.Size(113, 100);
            this.BallGifPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BallGifPictureBox.TabIndex = 25;
            this.BallGifPictureBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label4.Location = new System.Drawing.Point(434, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 25);
            this.label4.TabIndex = 27;
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
            this.KapatLabel.TabIndex = 26;
            this.KapatLabel.Text = "X";
            // 
            // KayıtOlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(499, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KapatLabel);
            this.Controls.Add(this.BallGifPictureBox);
            this.Controls.Add(this.KayıtBasariliLabel);
            this.Controls.Add(this.SifreTekrarTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CaptchaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MailAdresTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GirisButon);
            this.Controls.Add(this.SifreTextBox);
            this.Controls.Add(this.KullaniciAdTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KayıtOlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayıtOlForm";
            this.Load += new System.EventHandler(this.KayıtOlForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KayıtOlForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BallGifPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuThinButton2 GirisButon;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SifreTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox KullaniciAdTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MailAdresTextBox;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CaptchaTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SifreTekrarTextBox;
        private System.Windows.Forms.Timer KayıtBasariliTimer;
        private System.Windows.Forms.Label KayıtBasariliLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox BallGifPictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label KapatLabel;
    }
}