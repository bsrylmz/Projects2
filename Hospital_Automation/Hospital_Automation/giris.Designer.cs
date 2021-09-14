namespace Hospital_Automation
{
    partial class giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HASTAKAYITtoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtGüncellemeSilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HASTAKAYITtoolStripMenuItem1});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(962, 62);
            this.MenuStrip1.TabIndex = 34;
            this.MenuStrip1.Text = "menuStrip1";
            // 
            // HASTAKAYITtoolStripMenuItem1
            // 
            this.HASTAKAYITtoolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.HASTAKAYITtoolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.HASTAKAYITtoolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKayıtToolStripMenuItem,
            this.kayıtGüncellemeSilmeToolStripMenuItem});
            this.HASTAKAYITtoolStripMenuItem1.Font = new System.Drawing.Font("Segoe Print", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.HASTAKAYITtoolStripMenuItem1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.HASTAKAYITtoolStripMenuItem1.Margin = new System.Windows.Forms.Padding(5);
            this.HASTAKAYITtoolStripMenuItem1.Name = "HASTAKAYITtoolStripMenuItem1";
            this.HASTAKAYITtoolStripMenuItem1.Size = new System.Drawing.Size(273, 48);
            this.HASTAKAYITtoolStripMenuItem1.Text = "HASTA İŞLEMLERİ";
            // 
            // yeniKayıtToolStripMenuItem
            // 
            this.yeniKayıtToolStripMenuItem.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold);
            this.yeniKayıtToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.yeniKayıtToolStripMenuItem.Name = "yeniKayıtToolStripMenuItem";
            this.yeniKayıtToolStripMenuItem.Size = new System.Drawing.Size(330, 38);
            this.yeniKayıtToolStripMenuItem.Text = "Yeni Kayıt";
            this.yeniKayıtToolStripMenuItem.Click += new System.EventHandler(this.YeniKayıtToolStripMenuItem_Click);
            // 
            // kayıtGüncellemeSilmeToolStripMenuItem
            // 
            this.kayıtGüncellemeSilmeToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold);
            this.kayıtGüncellemeSilmeToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.kayıtGüncellemeSilmeToolStripMenuItem.Name = "kayıtGüncellemeSilmeToolStripMenuItem";
            this.kayıtGüncellemeSilmeToolStripMenuItem.Size = new System.Drawing.Size(330, 38);
            this.kayıtGüncellemeSilmeToolStripMenuItem.Text = "Kayıt Güncelleme/Silme";
            this.kayıtGüncellemeSilmeToolStripMenuItem.Click += new System.EventHandler(this.KayıtGüncellemeToolStripMenuItem_Click);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(962, 585);
            this.Controls.Add(this.MenuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "giris";
            this.Load += new System.EventHandler(this.giris_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem HASTAKAYITtoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kayıtGüncellemeSilmeToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem yeniKayıtToolStripMenuItem;
    }
}

