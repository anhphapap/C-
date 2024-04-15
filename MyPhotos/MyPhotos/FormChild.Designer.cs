namespace MyPhotos
{
    partial class FormChild
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
            this.mLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.mOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mClear = new System.Windows.Forms.ToolStripMenuItem();
            this.mSave = new System.Windows.Forms.ToolStripMenuItem();
            this.pic = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mLoad,
            this.mOpen,
            this.mClear,
            this.mSave});
            this.menuFile.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // mLoad
            // 
            this.mLoad.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mLoad.MergeIndex = 1;
            this.mLoad.Name = "mLoad";
            this.mLoad.Size = new System.Drawing.Size(180, 22);
            this.mLoad.Text = "Load";
            this.mLoad.Click += new System.EventHandler(this.mLoad_Click);
            // 
            // mOpen
            // 
            this.mOpen.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mOpen.MergeIndex = 2;
            this.mOpen.Name = "mOpen";
            this.mOpen.Size = new System.Drawing.Size(180, 22);
            this.mOpen.Text = "Open";
            this.mOpen.Click += new System.EventHandler(this.mOpen_Click);
            // 
            // mClear
            // 
            this.mClear.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mClear.MergeIndex = 3;
            this.mClear.Name = "mClear";
            this.mClear.Size = new System.Drawing.Size(180, 22);
            this.mClear.Text = "Clear";
            this.mClear.Click += new System.EventHandler(this.mClear_Click);
            // 
            // mSave
            // 
            this.mSave.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mSave.MergeIndex = 4;
            this.mSave.Name = "mSave";
            this.mSave.Size = new System.Drawing.Size(180, 22);
            this.mSave.Text = "Save";
            this.mSave.Click += new System.EventHandler(this.mSave_Click);
            // 
            // pic
            // 
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 24);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(800, 426);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            // 
            // FormChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormChild";
            this.Text = "Image";
            this.Load += new System.EventHandler(this.FormChild_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem mLoad;
        private System.Windows.Forms.ToolStripMenuItem mOpen;
        private System.Windows.Forms.ToolStripMenuItem mClear;
        private System.Windows.Forms.ToolStripMenuItem mSave;
        private System.Windows.Forms.PictureBox pic;
    }
}