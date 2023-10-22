namespace WDUD
{
    partial class KitaplarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitaplarForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OkunanKitapButon = new Bunifu.Framework.UI.BunifuThinButton2();
            this.OkunacakKitapButon = new Bunifu.Framework.UI.BunifuThinButton2();
            this.KitapTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.KitapLabel = new System.Windows.Forms.Label();
            this.MainGroupBox = new System.Windows.Forms.GroupBox();
            this.SayfaSayisiTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SayfaSayisiLabel = new System.Windows.Forms.Label();
            this.KitapYazariTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.KitapYazariLabel = new System.Windows.Forms.Label();
            this.EkleButon = new Bunifu.Framework.UI.BunifuThinButton2();
            this.GösterButon = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DataGridViewGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.MainGroupBox.SuspendLayout();
            this.DataGridViewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(338, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(302, 38);
            this.label12.TabIndex = 11;
            this.label12.Text = "Okunacak Kitaplar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(174)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.OkunanKitapButon);
            this.panel1.Controls.Add(this.OkunacakKitapButon);
            this.panel1.Location = new System.Drawing.Point(214, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 64);
            this.panel1.TabIndex = 23;
            // 
            // OkunanKitapButon
            // 
            this.OkunanKitapButon.ActiveBorderThickness = 2;
            this.OkunanKitapButon.ActiveCornerRadius = 20;
            this.OkunanKitapButon.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.OkunanKitapButon.ActiveForecolor = System.Drawing.Color.White;
            this.OkunanKitapButon.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.OkunanKitapButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(174)))), ((int)(((byte)(88)))));
            this.OkunanKitapButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OkunanKitapButon.BackgroundImage")));
            this.OkunanKitapButon.ButtonText = "Okunan Kitap";
            this.OkunanKitapButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkunanKitapButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkunanKitapButon.ForeColor = System.Drawing.Color.SeaGreen;
            this.OkunanKitapButon.IdleBorderThickness = 4;
            this.OkunanKitapButon.IdleCornerRadius = 20;
            this.OkunanKitapButon.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.OkunanKitapButon.IdleForecolor = System.Drawing.Color.White;
            this.OkunanKitapButon.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.OkunanKitapButon.Location = new System.Drawing.Point(255, 9);
            this.OkunanKitapButon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OkunanKitapButon.Name = "OkunanKitapButon";
            this.OkunanKitapButon.Size = new System.Drawing.Size(244, 48);
            this.OkunanKitapButon.TabIndex = 20;
            this.OkunanKitapButon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OkunanKitapButon.Click += new System.EventHandler(this.OkunanKitapButon_Click);
            // 
            // OkunacakKitapButon
            // 
            this.OkunacakKitapButon.ActiveBorderThickness = 2;
            this.OkunacakKitapButon.ActiveCornerRadius = 20;
            this.OkunacakKitapButon.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.OkunacakKitapButon.ActiveForecolor = System.Drawing.Color.White;
            this.OkunacakKitapButon.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.OkunacakKitapButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(174)))), ((int)(((byte)(88)))));
            this.OkunacakKitapButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OkunacakKitapButon.BackgroundImage")));
            this.OkunacakKitapButon.ButtonText = "Okunacak Kitap";
            this.OkunacakKitapButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkunacakKitapButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkunacakKitapButon.ForeColor = System.Drawing.Color.SeaGreen;
            this.OkunacakKitapButon.IdleBorderThickness = 4;
            this.OkunacakKitapButon.IdleCornerRadius = 20;
            this.OkunacakKitapButon.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.OkunacakKitapButon.IdleForecolor = System.Drawing.Color.White;
            this.OkunacakKitapButon.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.OkunacakKitapButon.Location = new System.Drawing.Point(10, 9);
            this.OkunacakKitapButon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OkunacakKitapButon.Name = "OkunacakKitapButon";
            this.OkunacakKitapButon.Size = new System.Drawing.Size(244, 48);
            this.OkunacakKitapButon.TabIndex = 21;
            this.OkunacakKitapButon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OkunacakKitapButon.Click += new System.EventHandler(this.OkunacakKitapButon_Click);
            // 
            // KitapTextBox
            // 
            this.KitapTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KitapTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.KitapTextBox.ForeColor = System.Drawing.Color.Black;
            this.KitapTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.KitapTextBox.HintText = "";
            this.KitapTextBox.isPassword = false;
            this.KitapTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.KitapTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.KitapTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.KitapTextBox.LineThickness = 3;
            this.KitapTextBox.Location = new System.Drawing.Point(195, 61);
            this.KitapTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.KitapTextBox.Name = "KitapTextBox";
            this.KitapTextBox.Size = new System.Drawing.Size(222, 33);
            this.KitapTextBox.TabIndex = 28;
            this.KitapTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // KitapLabel
            // 
            this.KitapLabel.AutoSize = true;
            this.KitapLabel.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KitapLabel.ForeColor = System.Drawing.Color.White;
            this.KitapLabel.Location = new System.Drawing.Point(6, 66);
            this.KitapLabel.Name = "KitapLabel";
            this.KitapLabel.Size = new System.Drawing.Size(175, 28);
            this.KitapLabel.TabIndex = 27;
            this.KitapLabel.Text = "Okunacak Kitap";
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Controls.Add(this.SayfaSayisiTextBox);
            this.MainGroupBox.Controls.Add(this.SayfaSayisiLabel);
            this.MainGroupBox.Controls.Add(this.KitapYazariTextBox);
            this.MainGroupBox.Controls.Add(this.KitapTextBox);
            this.MainGroupBox.Controls.Add(this.KitapYazariLabel);
            this.MainGroupBox.Controls.Add(this.KitapLabel);
            this.MainGroupBox.Location = new System.Drawing.Point(214, 167);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Size = new System.Drawing.Size(505, 278);
            this.MainGroupBox.TabIndex = 29;
            this.MainGroupBox.TabStop = false;
            // 
            // SayfaSayisiTextBox
            // 
            this.SayfaSayisiTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SayfaSayisiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SayfaSayisiTextBox.ForeColor = System.Drawing.Color.Black;
            this.SayfaSayisiTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.SayfaSayisiTextBox.HintText = "";
            this.SayfaSayisiTextBox.isPassword = false;
            this.SayfaSayisiTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.SayfaSayisiTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.SayfaSayisiTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.SayfaSayisiTextBox.LineThickness = 3;
            this.SayfaSayisiTextBox.Location = new System.Drawing.Point(195, 120);
            this.SayfaSayisiTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SayfaSayisiTextBox.Name = "SayfaSayisiTextBox";
            this.SayfaSayisiTextBox.Size = new System.Drawing.Size(226, 33);
            this.SayfaSayisiTextBox.TabIndex = 28;
            this.SayfaSayisiTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // SayfaSayisiLabel
            // 
            this.SayfaSayisiLabel.AutoSize = true;
            this.SayfaSayisiLabel.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SayfaSayisiLabel.ForeColor = System.Drawing.Color.White;
            this.SayfaSayisiLabel.Location = new System.Drawing.Point(27, 125);
            this.SayfaSayisiLabel.Name = "SayfaSayisiLabel";
            this.SayfaSayisiLabel.Size = new System.Drawing.Size(132, 28);
            this.SayfaSayisiLabel.TabIndex = 27;
            this.SayfaSayisiLabel.Text = "Sayfa Sayısı";
            // 
            // KitapYazariTextBox
            // 
            this.KitapYazariTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KitapYazariTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.KitapYazariTextBox.ForeColor = System.Drawing.Color.Black;
            this.KitapYazariTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.KitapYazariTextBox.HintText = "";
            this.KitapYazariTextBox.isPassword = false;
            this.KitapYazariTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.KitapYazariTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.KitapYazariTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.KitapYazariTextBox.LineThickness = 3;
            this.KitapYazariTextBox.Location = new System.Drawing.Point(195, 186);
            this.KitapYazariTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.KitapYazariTextBox.Name = "KitapYazariTextBox";
            this.KitapYazariTextBox.Size = new System.Drawing.Size(226, 33);
            this.KitapYazariTextBox.TabIndex = 26;
            this.KitapYazariTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // KitapYazariLabel
            // 
            this.KitapYazariLabel.AutoSize = true;
            this.KitapYazariLabel.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KitapYazariLabel.ForeColor = System.Drawing.Color.White;
            this.KitapYazariLabel.Location = new System.Drawing.Point(27, 191);
            this.KitapYazariLabel.Name = "KitapYazariLabel";
            this.KitapYazariLabel.Size = new System.Drawing.Size(136, 28);
            this.KitapYazariLabel.TabIndex = 25;
            this.KitapYazariLabel.Text = "Kitap Yazarı";
            // 
            // EkleButon
            // 
            this.EkleButon.ActiveBorderThickness = 2;
            this.EkleButon.ActiveCornerRadius = 20;
            this.EkleButon.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.EkleButon.ActiveForecolor = System.Drawing.Color.White;
            this.EkleButon.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.EkleButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.EkleButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EkleButon.BackgroundImage")));
            this.EkleButon.ButtonText = "Ekle";
            this.EkleButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EkleButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EkleButon.ForeColor = System.Drawing.Color.SeaGreen;
            this.EkleButon.IdleBorderThickness = 4;
            this.EkleButon.IdleCornerRadius = 20;
            this.EkleButon.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.EkleButon.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.EkleButon.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.EkleButon.Location = new System.Drawing.Point(214, 470);
            this.EkleButon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EkleButon.Name = "EkleButon";
            this.EkleButon.Size = new System.Drawing.Size(244, 48);
            this.EkleButon.TabIndex = 30;
            this.EkleButon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EkleButon.Click += new System.EventHandler(this.EkleButon_Click);
            // 
            // GösterButon
            // 
            this.GösterButon.ActiveBorderThickness = 2;
            this.GösterButon.ActiveCornerRadius = 20;
            this.GösterButon.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.GösterButon.ActiveForecolor = System.Drawing.Color.White;
            this.GösterButon.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.GösterButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.GösterButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GösterButon.BackgroundImage")));
            this.GösterButon.ButtonText = "Göster";
            this.GösterButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GösterButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GösterButon.ForeColor = System.Drawing.Color.SeaGreen;
            this.GösterButon.IdleBorderThickness = 4;
            this.GösterButon.IdleCornerRadius = 20;
            this.GösterButon.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.GösterButon.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.GösterButon.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.GösterButon.Location = new System.Drawing.Point(475, 470);
            this.GösterButon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GösterButon.Name = "GösterButon";
            this.GösterButon.Size = new System.Drawing.Size(244, 48);
            this.GösterButon.TabIndex = 31;
            this.GösterButon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GösterButon.Click += new System.EventHandler(this.GösterButon_Click);
            // 
            // DataGridViewGroupBox
            // 
            this.DataGridViewGroupBox.Controls.Add(this.dataGridView1);
            this.DataGridViewGroupBox.Location = new System.Drawing.Point(53, 167);
            this.DataGridViewGroupBox.Name = "DataGridViewGroupBox";
            this.DataGridViewGroupBox.Size = new System.Drawing.Size(825, 278);
            this.DataGridViewGroupBox.TabIndex = 33;
            this.DataGridViewGroupBox.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(112)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(25, 19);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(778, 237);
            this.dataGridView1.TabIndex = 34;
            // 
            // KitaplarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(933, 594);
            this.Controls.Add(this.DataGridViewGroupBox);
            this.Controls.Add(this.GösterButon);
            this.Controls.Add(this.EkleButon);
            this.Controls.Add(this.MainGroupBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KitaplarForm";
            this.Text = "KitaplarForm";
            this.Load += new System.EventHandler(this.KitaplarForm_Load);
            this.panel1.ResumeLayout(false);
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.DataGridViewGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 OkunanKitapButon;
        private Bunifu.Framework.UI.BunifuThinButton2 OkunacakKitapButon;
        private Bunifu.Framework.UI.BunifuMaterialTextbox KitapTextBox;
        private System.Windows.Forms.Label KitapLabel;
        private System.Windows.Forms.GroupBox MainGroupBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SayfaSayisiTextBox;
        private System.Windows.Forms.Label SayfaSayisiLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox KitapYazariTextBox;
        private System.Windows.Forms.Label KitapYazariLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 EkleButon;
        private Bunifu.Framework.UI.BunifuThinButton2 GösterButon;
        private System.Windows.Forms.GroupBox DataGridViewGroupBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}