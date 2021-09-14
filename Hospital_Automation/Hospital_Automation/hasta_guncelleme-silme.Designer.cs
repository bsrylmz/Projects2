namespace Hospital_Automation
{
    partial class hasta_guncelleme_silme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hasta_guncelleme_silme));
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_tc = new System.Windows.Forms.TextBox();
            this.bt_ara = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tb_yetkilikodu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_kisilistele = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kisilistele)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.Label1.Location = new System.Drawing.Point(123, 145);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 30);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "TC :";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(328, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(556, 55);
            this.label2.TabIndex = 4;
            this.label2.Text = "HASTA KAYIT GÜNCELLEME - SİLME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_tc
            // 
            this.tb_tc.Location = new System.Drawing.Point(214, 145);
            this.tb_tc.Margin = new System.Windows.Forms.Padding(4);
            this.tb_tc.Name = "tb_tc";
            this.tb_tc.Size = new System.Drawing.Size(175, 22);
            this.tb_tc.TabIndex = 5;
            // 
            // bt_ara
            // 
            this.bt_ara.ImageKey = "Icon_15-512.png";
            this.bt_ara.ImageList = this.ımageList1;
            this.bt_ara.Location = new System.Drawing.Point(472, 144);
            this.bt_ara.Name = "bt_ara";
            this.bt_ara.Size = new System.Drawing.Size(68, 69);
            this.bt_ara.TabIndex = 6;
            this.bt_ara.UseVisualStyleBackColor = true;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Icon_15-512.png");
            // 
            // tb_yetkilikodu
            // 
            this.tb_yetkilikodu.Location = new System.Drawing.Point(214, 191);
            this.tb_yetkilikodu.Name = "tb_yetkilikodu";
            this.tb_yetkilikodu.Size = new System.Drawing.Size(106, 22);
            this.tb_yetkilikodu.TabIndex = 7;
            this.tb_yetkilikodu.TextChanged += new System.EventHandler(this.tb_yetkilikodu_TextChanged);
            this.tb_yetkilikodu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_yetkilikodu_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(42, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yetkili Kodu :";
            // 
            // dgv_kisilistele
            // 
            this.dgv_kisilistele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kisilistele.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_kisilistele.Location = new System.Drawing.Point(149, 243);
            this.dgv_kisilistele.Name = "dgv_kisilistele";
            this.dgv_kisilistele.RowTemplate.Height = 24;
            this.dgv_kisilistele.Size = new System.Drawing.Size(949, 388);
            this.dgv_kisilistele.TabIndex = 9;
            this.dgv_kisilistele.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_kisilistele_CellMouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yenileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 28);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.yenileToolStripMenuItem.Text = "Sil";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // hasta_guncelleme_silme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1220, 730);
            this.Controls.Add(this.dgv_kisilistele);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_yetkilikodu);
            this.Controls.Add(this.bt_ara);
            this.Controls.Add(this.tb_tc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Name = "hasta_guncelleme_silme";
            this.Text = "hasta_guncelleme_silme";
            this.Load += new System.EventHandler(this.hasta_guncelleme_silme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kisilistele)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_tc;
        private System.Windows.Forms.Button bt_ara;
        private System.Windows.Forms.TextBox tb_yetkilikodu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        public System.Windows.Forms.DataGridView dgv_kisilistele;
        private System.Windows.Forms.ImageList ımageList1;
    }
}