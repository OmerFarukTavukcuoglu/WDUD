namespace WDUD
{
    partial class AlarmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmForm));
            this.SaatCombobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FarklıGünLabel = new System.Windows.Forms.Label();
            this.FarkliGünCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.BugünLabel = new System.Windows.Forms.Label();
            this.BugünCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.YapilacaklarButon = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AktivitelerButon = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label12 = new System.Windows.Forms.Label();
            this.DakikaComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SonucLabelText = new System.Windows.Forms.Label();
            this.AlarmKurButon = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.AlarmAdıTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.BildiriTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaatCombobox
            // 
            this.SaatCombobox.FormattingEnabled = true;
            this.SaatCombobox.Location = new System.Drawing.Point(315, 407);
            this.SaatCombobox.Name = "SaatCombobox";
            this.SaatCombobox.Size = new System.Drawing.Size(75, 21);
            this.SaatCombobox.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(253, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 28);
            this.label4.TabIndex = 41;
            this.label4.Text = "Saat";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(458, 360);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateTimePicker.TabIndex = 40;
            // 
            // FarklıGünLabel
            // 
            this.FarklıGünLabel.AutoSize = true;
            this.FarklıGünLabel.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FarklıGünLabel.ForeColor = System.Drawing.Color.White;
            this.FarklıGünLabel.Location = new System.Drawing.Point(452, 311);
            this.FarklıGünLabel.Name = "FarklıGünLabel";
            this.FarklıGünLabel.Size = new System.Drawing.Size(200, 28);
            this.FarklıGünLabel.TabIndex = 39;
            this.FarklıGünLabel.Text = "Farklı Bir Gün İçin";
            // 
            // FarkliGünCheckBox
            // 
            this.FarkliGünCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.FarkliGünCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.FarkliGünCheckBox.Checked = false;
            this.FarkliGünCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(174)))), ((int)(((byte)(88)))));
            this.FarkliGünCheckBox.ForeColor = System.Drawing.Color.White;
            this.FarkliGünCheckBox.Location = new System.Drawing.Point(658, 319);
            this.FarkliGünCheckBox.Name = "FarkliGünCheckBox";
            this.FarkliGünCheckBox.Size = new System.Drawing.Size(20, 20);
            this.FarkliGünCheckBox.TabIndex = 38;
            this.FarkliGünCheckBox.OnChange += new System.EventHandler(this.FarkliGünCheckBox_OnChange);
            // 
            // BugünLabel
            // 
            this.BugünLabel.AutoSize = true;
            this.BugünLabel.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BugünLabel.ForeColor = System.Drawing.Color.White;
            this.BugünLabel.Location = new System.Drawing.Point(247, 311);
            this.BugünLabel.Name = "BugünLabel";
            this.BugünLabel.Size = new System.Drawing.Size(122, 28);
            this.BugünLabel.TabIndex = 37;
            this.BugünLabel.Text = "Bugün İçin";
            // 
            // BugünCheckBox
            // 
            this.BugünCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.BugünCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.BugünCheckBox.Checked = false;
            this.BugünCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(174)))), ((int)(((byte)(88)))));
            this.BugünCheckBox.ForeColor = System.Drawing.Color.White;
            this.BugünCheckBox.Location = new System.Drawing.Point(384, 319);
            this.BugünCheckBox.Name = "BugünCheckBox";
            this.BugünCheckBox.Size = new System.Drawing.Size(20, 20);
            this.BugünCheckBox.TabIndex = 36;
            this.BugünCheckBox.OnChange += new System.EventHandler(this.BugünCheckBox_OnChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(262, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 28);
            this.label1.TabIndex = 35;
            this.label1.Text = "Alarm Kurmak İstediğiniz Türü Seçin";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(174)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.YapilacaklarButon);
            this.panel1.Controls.Add(this.AktivitelerButon);
            this.panel1.Location = new System.Drawing.Point(203, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 64);
            this.panel1.TabIndex = 34;
            // 
            // YapilacaklarButon
            // 
            this.YapilacaklarButon.ActiveBorderThickness = 2;
            this.YapilacaklarButon.ActiveCornerRadius = 20;
            this.YapilacaklarButon.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.YapilacaklarButon.ActiveForecolor = System.Drawing.Color.White;
            this.YapilacaklarButon.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.YapilacaklarButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(174)))), ((int)(((byte)(88)))));
            this.YapilacaklarButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("YapilacaklarButon.BackgroundImage")));
            this.YapilacaklarButon.ButtonText = "Yapılacaklar Listesi";
            this.YapilacaklarButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YapilacaklarButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YapilacaklarButon.ForeColor = System.Drawing.Color.SeaGreen;
            this.YapilacaklarButon.IdleBorderThickness = 4;
            this.YapilacaklarButon.IdleCornerRadius = 20;
            this.YapilacaklarButon.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.YapilacaklarButon.IdleForecolor = System.Drawing.Color.White;
            this.YapilacaklarButon.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.YapilacaklarButon.Location = new System.Drawing.Point(255, 9);
            this.YapilacaklarButon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.YapilacaklarButon.Name = "YapilacaklarButon";
            this.YapilacaklarButon.Size = new System.Drawing.Size(244, 48);
            this.YapilacaklarButon.TabIndex = 20;
            this.YapilacaklarButon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.YapilacaklarButon.Click += new System.EventHandler(this.YapilacaklarButon_Click);
            // 
            // AktivitelerButon
            // 
            this.AktivitelerButon.ActiveBorderThickness = 2;
            this.AktivitelerButon.ActiveCornerRadius = 20;
            this.AktivitelerButon.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.AktivitelerButon.ActiveForecolor = System.Drawing.Color.White;
            this.AktivitelerButon.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.AktivitelerButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(174)))), ((int)(((byte)(88)))));
            this.AktivitelerButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AktivitelerButon.BackgroundImage")));
            this.AktivitelerButon.ButtonText = "Günlük Aktiviteler";
            this.AktivitelerButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AktivitelerButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AktivitelerButon.ForeColor = System.Drawing.Color.SeaGreen;
            this.AktivitelerButon.IdleBorderThickness = 4;
            this.AktivitelerButon.IdleCornerRadius = 20;
            this.AktivitelerButon.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.AktivitelerButon.IdleForecolor = System.Drawing.Color.White;
            this.AktivitelerButon.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.AktivitelerButon.Location = new System.Drawing.Point(10, 9);
            this.AktivitelerButon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AktivitelerButon.Name = "AktivitelerButon";
            this.AktivitelerButon.Size = new System.Drawing.Size(244, 48);
            this.AktivitelerButon.TabIndex = 21;
            this.AktivitelerButon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AktivitelerButon.Click += new System.EventHandler(this.AktivitelerButon_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(423, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 38);
            this.label12.TabIndex = 33;
            this.label12.Text = "Alarm";
            // 
            // DakikaComboBox
            // 
            this.DakikaComboBox.FormattingEnabled = true;
            this.DakikaComboBox.Location = new System.Drawing.Point(539, 407);
            this.DakikaComboBox.Name = "DakikaComboBox";
            this.DakikaComboBox.Size = new System.Drawing.Size(75, 21);
            this.DakikaComboBox.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(448, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 28);
            this.label5.TabIndex = 44;
            this.label5.Text = "Dakika";
            // 
            // SonucLabelText
            // 
            this.SonucLabelText.AutoSize = true;
            this.SonucLabelText.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SonucLabelText.ForeColor = System.Drawing.Color.White;
            this.SonucLabelText.Location = new System.Drawing.Point(253, 546);
            this.SonucLabelText.Name = "SonucLabelText";
            this.SonucLabelText.Size = new System.Drawing.Size(76, 28);
            this.SonucLabelText.TabIndex = 46;
            this.SonucLabelText.Text = "Alarm";
            // 
            // AlarmKurButon
            // 
            this.AlarmKurButon.ActiveBorderThickness = 2;
            this.AlarmKurButon.ActiveCornerRadius = 20;
            this.AlarmKurButon.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.AlarmKurButon.ActiveForecolor = System.Drawing.Color.White;
            this.AlarmKurButon.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.AlarmKurButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.AlarmKurButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AlarmKurButon.BackgroundImage")));
            this.AlarmKurButon.ButtonText = "Alarm Kur";
            this.AlarmKurButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AlarmKurButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmKurButon.ForeColor = System.Drawing.Color.SeaGreen;
            this.AlarmKurButon.IdleBorderThickness = 4;
            this.AlarmKurButon.IdleCornerRadius = 20;
            this.AlarmKurButon.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.AlarmKurButon.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(174)))), ((int)(((byte)(88)))));
            this.AlarmKurButon.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(174)))), ((int)(((byte)(88)))));
            this.AlarmKurButon.Location = new System.Drawing.Point(458, 480);
            this.AlarmKurButon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AlarmKurButon.Name = "AlarmKurButon";
            this.AlarmKurButon.Size = new System.Drawing.Size(244, 48);
            this.AlarmKurButon.TabIndex = 22;
            this.AlarmKurButon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AlarmKurButon.Click += new System.EventHandler(this.AlarmKurButon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(174)))), ((int)(((byte)(88)))));
            this.label2.Location = new System.Drawing.Point(198, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 28);
            this.label2.TabIndex = 47;
            this.label2.Text = "Alarm Adı:";
            // 
            // AlarmAdıTextBox
            // 
            this.AlarmAdıTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AlarmAdıTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AlarmAdıTextBox.ForeColor = System.Drawing.Color.Black;
            this.AlarmAdıTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.AlarmAdıTextBox.HintText = "";
            this.AlarmAdıTextBox.isPassword = false;
            this.AlarmAdıTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(174)))), ((int)(((byte)(88)))));
            this.AlarmAdıTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(174)))), ((int)(((byte)(88)))));
            this.AlarmAdıTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(174)))), ((int)(((byte)(88)))));
            this.AlarmAdıTextBox.LineThickness = 3;
            this.AlarmAdıTextBox.Location = new System.Drawing.Point(345, 79);
            this.AlarmAdıTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AlarmAdıTextBox.Name = "AlarmAdıTextBox";
            this.AlarmAdıTextBox.Size = new System.Drawing.Size(361, 33);
            this.AlarmAdıTextBox.TabIndex = 48;
            this.AlarmAdıTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // BildiriTimer
            // 
            this.BildiriTimer.Tick += new System.EventHandler(this.BildiriTimer_Tick);
            // 
            // AlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(933, 594);
            this.Controls.Add(this.AlarmAdıTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AlarmKurButon);
            this.Controls.Add(this.SonucLabelText);
            this.Controls.Add(this.DakikaComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SaatCombobox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.FarklıGünLabel);
            this.Controls.Add(this.FarkliGünCheckBox);
            this.Controls.Add(this.BugünLabel);
            this.Controls.Add(this.BugünCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlarmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlarmForm";
            this.Load += new System.EventHandler(this.AlarmForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SaatCombobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label FarklıGünLabel;
        private Bunifu.Framework.UI.BunifuCheckbox FarkliGünCheckBox;
        private System.Windows.Forms.Label BugünLabel;
        private Bunifu.Framework.UI.BunifuCheckbox BugünCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 YapilacaklarButon;
        private Bunifu.Framework.UI.BunifuThinButton2 AktivitelerButon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox DakikaComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label SonucLabelText;
        private Bunifu.Framework.UI.BunifuThinButton2 AlarmKurButon;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AlarmAdıTextBox;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        public System.Windows.Forms.Timer BildiriTimer;
    }
}