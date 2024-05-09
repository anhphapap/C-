namespace SimplePaint
{
    partial class FormMouse
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
            this.SuspendLayout();
            // 
            // FormMouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 493);
            this.DoubleBuffered = true;
            this.Name = "FormMouse";
            this.Text = "FormMouse";
            this.Load += new System.EventHandler(this.FormMouse_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMouse_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMouse_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMouse_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
    }
}