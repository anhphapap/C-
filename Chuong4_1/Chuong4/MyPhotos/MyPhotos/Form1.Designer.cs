namespace MyPhotos
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
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.mCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.mTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.mTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuWindows});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mNew,
            this.toolStripSeparator1,
            this.mCloseAll,
            this.mExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // mNew
            // 
            this.mNew.MergeIndex = 0;
            this.mNew.Name = "mNew";
            this.mNew.Size = new System.Drawing.Size(180, 22);
            this.mNew.Text = "New           Ctrl+N";
            this.mNew.Click += new System.EventHandler(this.mNew_Click);
            // 
            // mCloseAll
            // 
            this.mCloseAll.MergeIndex = 6;
            this.mCloseAll.Name = "mCloseAll";
            this.mCloseAll.Size = new System.Drawing.Size(180, 22);
            this.mCloseAll.Text = "Close All";
            this.mCloseAll.Click += new System.EventHandler(this.mCloseAll_Click);
            // 
            // mExit
            // 
            this.mExit.MergeIndex = 7;
            this.mExit.Name = "mExit";
            this.mExit.Size = new System.Drawing.Size(180, 22);
            this.mExit.Text = "Exit";
            this.mExit.Click += new System.EventHandler(this.mExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.MergeIndex = 5;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuWindows
            // 
            this.menuWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCascade,
            this.mTileHorizontal,
            this.mTileVertical});
            this.menuWindows.Name = "menuWindows";
            this.menuWindows.Size = new System.Drawing.Size(68, 20);
            this.menuWindows.Text = "Windows";
            // 
            // mCascade
            // 
            this.mCascade.Name = "mCascade";
            this.mCascade.Size = new System.Drawing.Size(180, 22);
            this.mCascade.Text = "Cascade";
            this.mCascade.Click += new System.EventHandler(this.mCascade_Click);
            // 
            // mTileHorizontal
            // 
            this.mTileHorizontal.Name = "mTileHorizontal";
            this.mTileHorizontal.Size = new System.Drawing.Size(180, 22);
            this.mTileHorizontal.Text = "Tile Horizontal";
            this.mTileHorizontal.Click += new System.EventHandler(this.mTileHorizontal_Click);
            // 
            // mTileVertical
            // 
            this.mTileVertical.Name = "mTileVertical";
            this.mTileVertical.Size = new System.Drawing.Size(180, 22);
            this.mTileVertical.Text = "Tile Vertical";
            this.mTileVertical.Click += new System.EventHandler(this.mTileVertical_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "My Photos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem mNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mCloseAll;
        private System.Windows.Forms.ToolStripMenuItem mExit;
        private System.Windows.Forms.ToolStripMenuItem menuWindows;
        private System.Windows.Forms.ToolStripMenuItem mCascade;
        private System.Windows.Forms.ToolStripMenuItem mTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem mTileVertical;
    }
}

