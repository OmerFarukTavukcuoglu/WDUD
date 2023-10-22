namespace WDUD
{
    partial class KelimelerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KelimelerForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.GösterButon = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EkleButon = new Bunifu.Framework.UI.BunifuThinButton2();
            this.KelimeAnlamiTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ÖgrenilenKelimeTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.wDUDatabaseDataSet = new WDUD.WDUDatabaseDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.wDUDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(933, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "Kelime Kayıtları";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.GösterButon.Location = new System.Drawing.Point(626, 128);
            this.GösterButon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GösterButon.Name = "GösterButon";
            this.GösterButon.Size = new System.Drawing.Size(244, 48);
            this.GösterButon.TabIndex = 24;
            this.GösterButon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GösterButon.Click += new System.EventHandler(this.GösterButon_Click);
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
            this.EkleButon.Location = new System.Drawing.Point(626, 197);
            this.EkleButon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EkleButon.Name = "EkleButon";
            this.EkleButon.Size = new System.Drawing.Size(244, 48);
            this.EkleButon.TabIndex = 23;
            this.EkleButon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EkleButon.Click += new System.EventHandler(this.EkleButon_Click);
            // 
            // KelimeAnlamiTextBox
            // 
            this.KelimeAnlamiTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KelimeAnlamiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.KelimeAnlamiTextBox.ForeColor = System.Drawing.Color.Black;
            this.KelimeAnlamiTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.KelimeAnlamiTextBox.HintText = "";
            this.KelimeAnlamiTextBox.isPassword = false;
            this.KelimeAnlamiTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.KelimeAnlamiTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.KelimeAnlamiTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.KelimeAnlamiTextBox.LineThickness = 4;
            this.KelimeAnlamiTextBox.Location = new System.Drawing.Point(311, 197);
            this.KelimeAnlamiTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.KelimeAnlamiTextBox.Name = "KelimeAnlamiTextBox";
            this.KelimeAnlamiTextBox.Size = new System.Drawing.Size(283, 41);
            this.KelimeAnlamiTextBox.TabIndex = 22;
            this.KelimeAnlamiTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ÖgrenilenKelimeTextBox
            // 
            this.ÖgrenilenKelimeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ÖgrenilenKelimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ÖgrenilenKelimeTextBox.ForeColor = System.Drawing.Color.Black;
            this.ÖgrenilenKelimeTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.ÖgrenilenKelimeTextBox.HintText = "";
            this.ÖgrenilenKelimeTextBox.isPassword = false;
            this.ÖgrenilenKelimeTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.ÖgrenilenKelimeTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ÖgrenilenKelimeTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.ÖgrenilenKelimeTextBox.LineThickness = 4;
            this.ÖgrenilenKelimeTextBox.Location = new System.Drawing.Point(311, 128);
            this.ÖgrenilenKelimeTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.ÖgrenilenKelimeTextBox.Name = "ÖgrenilenKelimeTextBox";
            this.ÖgrenilenKelimeTextBox.Size = new System.Drawing.Size(283, 41);
            this.ÖgrenilenKelimeTextBox.TabIndex = 21;
            this.ÖgrenilenKelimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(69, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(182, 32);
            this.label13.TabIndex = 20;
            this.label13.Text = "Kelime Anlamı";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(69, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(213, 32);
            this.label14.TabIndex = 19;
            this.label14.Text = "Öğrenilen Kelime";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(314, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(324, 38);
            this.label12.TabIndex = 18;
            this.label12.Text = "Öğrenilen Kelimeler";
            // 
            // wDUDatabaseDataSet
            // 
            this.wDUDatabaseDataSet.DataSetName = "WDUDatabaseDataSet";
            this.wDUDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.dataGridView1.Location = new System.Drawing.Point(228, 311);
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
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(493, 301);
            this.dataGridView1.TabIndex = 34;
            // 
            // KelimelerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(933, 594);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GösterButon);
            this.Controls.Add(this.EkleButon);
            this.Controls.Add(this.KelimeAnlamiTextBox);
            this.Controls.Add(this.ÖgrenilenKelimeTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KelimelerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.KelimelerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wDUDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 GösterButon;
        private Bunifu.Framework.UI.BunifuMaterialTextbox KelimeAnlamiTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ÖgrenilenKelimeTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        public Bunifu.Framework.UI.BunifuThinButton2 EkleButon;
        private WDUDatabaseDataSet wDUDatabaseDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}