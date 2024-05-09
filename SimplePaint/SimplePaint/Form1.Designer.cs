namespace SimplePaint
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDrawMouse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDrawText = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDrawImg = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(730, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDrawMouse,
            this.menuDrawText,
            this.menuDrawImg,
            this.menuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuDrawMouse
            // 
            this.menuDrawMouse.Name = "menuDrawMouse";
            this.menuDrawMouse.Size = new System.Drawing.Size(156, 22);
            this.menuDrawMouse.Text = "Draw By Mouse";
            this.menuDrawMouse.Click += new System.EventHandler(this.menuDrawMouse_Click);
            // 
            // menuDrawText
            // 
            this.menuDrawText.Name = "menuDrawText";
            this.menuDrawText.Size = new System.Drawing.Size(156, 22);
            this.menuDrawText.Text = "Draw Text";
            this.menuDrawText.Click += new System.EventHandler(this.drawToolStripMenuItem_Click);
            // 
            // menuDrawImg
            // 
            this.menuDrawImg.Name = "menuDrawImg";
            this.menuDrawImg.Size = new System.Drawing.Size(156, 22);
            this.menuDrawImg.Text = "Draw Image";
            this.menuDrawImg.Click += new System.EventHandler(this.menuDrawImg_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(156, 22);
            this.menuExit.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 496);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Simple Paint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDrawMouse;
        private System.Windows.Forms.ToolStripMenuItem menuDrawText;
        private System.Windows.Forms.ToolStripMenuItem menuDrawImg;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
    }
}

