
namespace QLDeTai
{
    partial class QLDeTai
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qLChudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLDeTaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlContent = new System.Windows.Forms.Panel();
            this.hethongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hethongToolStripMenuItem,
            this.qLChudeToolStripMenuItem,
            this.qLDeTaiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // qLChudeToolStripMenuItem
            // 
            this.qLChudeToolStripMenuItem.Name = "qLChudeToolStripMenuItem";
            this.qLChudeToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.qLChudeToolStripMenuItem.Text = "QL Chủ Đề";
            this.qLChudeToolStripMenuItem.Click += new System.EventHandler(this.qLChudeToolStripMenuItem_Click);
            // 
            // qLDeTaiToolStripMenuItem
            // 
            this.qLDeTaiToolStripMenuItem.Name = "qLDeTaiToolStripMenuItem";
            this.qLDeTaiToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.qLDeTaiToolStripMenuItem.Text = "QL Đề Tài";
            this.qLDeTaiToolStripMenuItem.Click += new System.EventHandler(this.qLDeTaiToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pnlContent
            // 
            this.pnlContent.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pnlContent.Location = new System.Drawing.Point(0, 34);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(800, 516);
            this.pnlContent.TabIndex = 3;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint);
            // 
            // hethongToolStripMenuItem
            // 
            this.hethongToolStripMenuItem.Name = "hethongToolStripMenuItem";
            this.hethongToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.hethongToolStripMenuItem.Text = "Hệ Thống";
            this.hethongToolStripMenuItem.Click += new System.EventHandler(this.hethongToolStripMenuItem_Click);
            // 
            // QLDeTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(802, 553);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QLDeTai";
            this.Text = "QLDeTai";
            this.Load += new System.EventHandler(this.QLDeTai_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qLChudeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLDeTaiToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.ToolStripMenuItem hethongToolStripMenuItem;
    }
}