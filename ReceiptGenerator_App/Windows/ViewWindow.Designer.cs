namespace ReceiptGenerator_App
{
    partial class ViewWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewWindow));
            this.iPanel = new System.Windows.Forms.Panel();
            this.iBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.iPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iPanel
            // 
            this.iPanel.AutoScroll = true;
            this.iPanel.AutoSize = true;
            this.iPanel.Controls.Add(this.iBox);
            this.iPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iPanel.Location = new System.Drawing.Point(0, 24);
            this.iPanel.Name = "iPanel";
            this.iPanel.Size = new System.Drawing.Size(1009, 696);
            this.iPanel.TabIndex = 1;
            // 
            // iBox
            // 
            this.iBox.Location = new System.Drawing.Point(0, 0);
            this.iBox.Margin = new System.Windows.Forms.Padding(8);
            this.iBox.Name = "iBox";
            this.iBox.Size = new System.Drawing.Size(992, 1403);
            this.iBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iBox.TabIndex = 1;
            this.iBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1009, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnFile
            // 
            this.mnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSaveAs,
            this.mnPrint});
            this.mnFile.Name = "mnFile";
            this.mnFile.Size = new System.Drawing.Size(43, 20);
            this.mnFile.Text = "파일";
            // 
            // mnSaveAs
            // 
            this.mnSaveAs.Name = "mnSaveAs";
            this.mnSaveAs.Size = new System.Drawing.Size(178, 22);
            this.mnSaveAs.Text = "다른 이름으로 저장";
            this.mnSaveAs.Click += new System.EventHandler(this.mnSaveAs_Click);
            // 
            // mnPrint
            // 
            this.mnPrint.Name = "mnPrint";
            this.mnPrint.Size = new System.Drawing.Size(178, 22);
            this.mnPrint.Text = "인쇄";
            this.mnPrint.Click += new System.EventHandler(this.mnPrint_Click);
            // 
            // ViewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1009, 720);
            this.Controls.Add(this.iPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1025, 214748);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1025, 39);
            this.Name = "ViewWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SWMaestro - 기부금 영수증 Preview";
            this.iPanel.ResumeLayout(false);
            this.iPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel iPanel;
        private System.Windows.Forms.PictureBox iBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnFile;
        private System.Windows.Forms.ToolStripMenuItem mnSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnPrint;
    }
}