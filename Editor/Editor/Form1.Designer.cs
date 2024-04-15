namespace Editor
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.input = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fontSize = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.hRed = new System.Windows.Forms.HScrollBar();
            this.hGreen = new System.Windows.Forms.HScrollBar();
            this.hBlue = new System.Windows.Forms.HScrollBar();
            this.color = new System.Windows.Forms.Label();
            this.lr = new System.Windows.Forms.Label();
            this.lg = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Font List";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(48, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(353, 420);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(442, 72);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(352, 420);
            this.input.TabIndex = 3;
            this.input.Text = "";
            this.input.SelectionChanged += new System.EventHandler(this.input_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 541);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Size:";
            // 
            // fontSize
            // 
            this.fontSize.FormattingEnabled = true;
            this.fontSize.Location = new System.Drawing.Point(90, 537);
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(78, 21);
            this.fontSize.TabIndex = 4;
            this.fontSize.SelectedIndexChanged += new System.EventHandler(this.fontSize_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "B";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 533);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "/";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(359, 533);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "U";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // hRed
            // 
            this.hRed.Location = new System.Drawing.Point(478, 513);
            this.hRed.Maximum = 255;
            this.hRed.Name = "hRed";
            this.hRed.Size = new System.Drawing.Size(254, 20);
            this.hRed.TabIndex = 6;
            this.hRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hRed_Scroll);
            // 
            // hGreen
            // 
            this.hGreen.Location = new System.Drawing.Point(478, 533);
            this.hGreen.Maximum = 255;
            this.hGreen.Name = "hGreen";
            this.hGreen.Size = new System.Drawing.Size(254, 20);
            this.hGreen.TabIndex = 6;
            this.hGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hGreen_Scroll);
            // 
            // hBlue
            // 
            this.hBlue.Location = new System.Drawing.Point(478, 553);
            this.hBlue.Maximum = 255;
            this.hBlue.Name = "hBlue";
            this.hBlue.Size = new System.Drawing.Size(254, 20);
            this.hBlue.TabIndex = 6;
            this.hBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hBlue_Scroll);
            // 
            // color
            // 
            this.color.BackColor = System.Drawing.Color.Red;
            this.color.Location = new System.Drawing.Point(754, 513);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(59, 55);
            this.color.TabIndex = 7;
            // 
            // lr
            // 
            this.lr.BackColor = System.Drawing.Color.Red;
            this.lr.Location = new System.Drawing.Point(439, 513);
            this.lr.Name = "lr";
            this.lr.Size = new System.Drawing.Size(16, 15);
            this.lr.TabIndex = 7;
            // 
            // lg
            // 
            this.lg.BackColor = System.Drawing.Color.Green;
            this.lg.Location = new System.Drawing.Point(439, 535);
            this.lg.Name = "lg";
            this.lg.Size = new System.Drawing.Size(16, 15);
            this.lg.TabIndex = 7;
            // 
            // lb
            // 
            this.lb.BackColor = System.Drawing.Color.Blue;
            this.lb.Location = new System.Drawing.Point(439, 557);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(16, 15);
            this.lb.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 601);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.lg);
            this.Controls.Add(this.lr);
            this.Controls.Add(this.color);
            this.Controls.Add(this.hBlue);
            this.Controls.Add(this.hGreen);
            this.Controls.Add(this.hRed);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fontSize);
            this.Controls.Add(this.input);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fontSize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.HScrollBar hRed;
        private System.Windows.Forms.HScrollBar hGreen;
        private System.Windows.Forms.HScrollBar hBlue;
        private System.Windows.Forms.Label color;
        private System.Windows.Forms.Label lr;
        private System.Windows.Forms.Label lg;
        private System.Windows.Forms.Label lb;
    }
}

