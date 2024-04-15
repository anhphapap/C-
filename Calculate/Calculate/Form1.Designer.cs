namespace Calculate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.title = new System.Windows.Forms.Label();
            this.num0 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ans = new System.Windows.Forms.Label();
            this.cal = new System.Windows.Forms.Button();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.rd4 = new System.Windows.Forms.RadioButton();
            this.rd5 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            resources.ApplyResources(this.title, "title");
            this.title.Name = "title";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // num0
            // 
            resources.ApplyResources(this.num0, "num0");
            this.num0.Name = "num0";
            // 
            // num1
            // 
            resources.ApplyResources(this.num1, "num1");
            this.num1.Name = "num1";
            // 
            // num2
            // 
            resources.ApplyResources(this.num2, "num2");
            this.num2.Name = "num2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // ans
            // 
            this.ans.BackColor = System.Drawing.SystemColors.Info;
            this.ans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.ans, "ans");
            this.ans.Name = "ans";
            this.ans.Click += new System.EventHandler(this.label3_Click);
            // 
            // cal
            // 
            resources.ApplyResources(this.cal, "cal");
            this.cal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cal.Name = "cal";
            this.cal.UseVisualStyleBackColor = true;
            this.cal.Click += new System.EventHandler(this.close_Click);
            // 
            // rd1
            // 
            resources.ApplyResources(this.rd1, "rd1");
            this.rd1.BackColor = System.Drawing.SystemColors.Info;
            this.rd1.Name = "rd1";
            this.rd1.TabStop = true;
            this.rd1.UseVisualStyleBackColor = false;
            // 
            // rd2
            // 
            resources.ApplyResources(this.rd2, "rd2");
            this.rd2.BackColor = System.Drawing.SystemColors.Info;
            this.rd2.Name = "rd2";
            this.rd2.TabStop = true;
            this.rd2.UseVisualStyleBackColor = false;
            // 
            // rd3
            // 
            resources.ApplyResources(this.rd3, "rd3");
            this.rd3.BackColor = System.Drawing.SystemColors.Info;
            this.rd3.Name = "rd3";
            this.rd3.TabStop = true;
            this.rd3.UseVisualStyleBackColor = false;
            // 
            // rd4
            // 
            resources.ApplyResources(this.rd4, "rd4");
            this.rd4.BackColor = System.Drawing.SystemColors.Info;
            this.rd4.Name = "rd4";
            this.rd4.TabStop = true;
            this.rd4.UseVisualStyleBackColor = false;
            // 
            // rd5
            // 
            resources.ApplyResources(this.rd5, "rd5");
            this.rd5.BackColor = System.Drawing.SystemColors.Info;
            this.rd5.Name = "rd5";
            this.rd5.TabStop = true;
            this.rd5.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Name = "label3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rd5);
            this.Controls.Add(this.rd4);
            this.Controls.Add(this.rd3);
            this.Controls.Add(this.rd2);
            this.Controls.Add(this.rd1);
            this.Controls.Add(this.cal);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label num0;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ans;
        private System.Windows.Forms.Button cal;
        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.RadioButton rd4;
        private System.Windows.Forms.RadioButton rd5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

