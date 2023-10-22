namespace WDUD
{
    partial class AlarmBildiri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmBildiri));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.KapatLabel = new System.Windows.Forms.Label();
            this.AlarmUyarıLabel = new System.Windows.Forms.Label();
            this.timeout = new System.Windows.Forms.Timer(this.components);
            this.open = new System.Windows.Forms.Timer(this.components);
            this.close = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // KapatLabel
            // 
            this.KapatLabel.AutoSize = true;
            this.KapatLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KapatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KapatLabel.Location = new System.Drawing.Point(441, 3);
            this.KapatLabel.Name = "KapatLabel";
            this.KapatLabel.Size = new System.Drawing.Size(31, 29);
            this.KapatLabel.TabIndex = 1;
            this.KapatLabel.Text = "X";
            this.KapatLabel.Click += new System.EventHandler(this.KapatLabel_Click);
            // 
            // AlarmUyarıLabel
            // 
            this.AlarmUyarıLabel.AutoSize = true;
            this.AlarmUyarıLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AlarmUyarıLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AlarmUyarıLabel.ForeColor = System.Drawing.Color.White;
            this.AlarmUyarıLabel.Location = new System.Drawing.Point(110, 24);
            this.AlarmUyarıLabel.Name = "AlarmUyarıLabel";
            this.AlarmUyarıLabel.Size = new System.Drawing.Size(187, 22);
            this.AlarmUyarıLabel.TabIndex = 2;
            this.AlarmUyarıLabel.Text = "Bu bir uyarı sayfasıdır!";
            // 
            // timeout
            // 
            this.timeout.Interval = 500;
            this.timeout.Tick += new System.EventHandler(this.timeout_Tick);
            // 
            // open
            // 
            this.open.Interval = 1000;
            this.open.Tick += new System.EventHandler(this.open_Tick);
            // 
            // close
            // 
            this.close.Tick += new System.EventHandler(this.close_Tick);
            // 
            // AlarmBildiri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(476, 108);
            this.Controls.Add(this.AlarmUyarıLabel);
            this.Controls.Add(this.KapatLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlarmBildiri";
            this.Opacity = 0.9D;
            this.Text = "AlarmBildiri";
            this.Load += new System.EventHandler(this.AlarmBildiri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label KapatLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timeout;
        private System.Windows.Forms.Timer open;
        private System.Windows.Forms.Timer close;
        public System.Windows.Forms.Label AlarmUyarıLabel;
    }
}