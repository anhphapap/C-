namespace LuckyNumber
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.btReset = new System.Windows.Forms.Button();
            this.btRand = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbLose = new System.Windows.Forms.Label();
            this.lbWin = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pic);
            this.groupBox1.Controls.Add(this.bt6);
            this.groupBox1.Controls.Add(this.bt3);
            this.groupBox1.Controls.Add(this.bt5);
            this.groupBox1.Controls.Add(this.bt2);
            this.groupBox1.Controls.Add(this.bt4);
            this.groupBox1.Controls.Add(this.bt1);
            this.groupBox1.Location = new System.Drawing.Point(30, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đoán số";
            // 
            // pic
            // 
            this.pic.Image = global::LuckyNumber.Properties.Resources._1;
            this.pic.Location = new System.Drawing.Point(124, 42);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(70, 70);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(253, 99);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(41, 31);
            this.bt6.TabIndex = 0;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(24, 99);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(41, 31);
            this.bt3.TabIndex = 0;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(253, 62);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(41, 31);
            this.bt5.TabIndex = 0;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(24, 62);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(41, 31);
            this.bt2.TabIndex = 0;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(253, 25);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(41, 31);
            this.bt4.TabIndex = 0;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(24, 25);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(41, 31);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pic2);
            this.groupBox2.Controls.Add(this.btReset);
            this.groupBox2.Controls.Add(this.btRand);
            this.groupBox2.Location = new System.Drawing.Point(30, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 159);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quay số (Sinh ngẫu nhiên)";
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(124, 30);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(70, 70);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 2;
            this.pic2.TabStop = false;
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(183, 122);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(111, 31);
            this.btReset.TabIndex = 0;
            this.btReset.Text = "Reset (ESC)";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btRand
            // 
            this.btRand.Location = new System.Drawing.Point(24, 122);
            this.btRand.Name = "btRand";
            this.btRand.Size = new System.Drawing.Size(132, 31);
            this.btRand.TabIndex = 0;
            this.btRand.Text = "Quay số (Enter)";
            this.btRand.UseVisualStyleBackColor = true;
            this.btRand.Click += new System.EventHandler(this.btRand_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbLose);
            this.groupBox3.Controls.Add(this.lbWin);
            this.groupBox3.Controls.Add(this.lbCount);
            this.groupBox3.Location = new System.Drawing.Point(30, 335);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 102);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thống kê";
            // 
            // lbLose
            // 
            this.lbLose.AutoSize = true;
            this.lbLose.Location = new System.Drawing.Point(30, 73);
            this.lbLose.Name = "lbLose";
            this.lbLose.Size = new System.Drawing.Size(0, 13);
            this.lbLose.TabIndex = 0;
            // 
            // lbWin
            // 
            this.lbWin.AutoSize = true;
            this.lbWin.Location = new System.Drawing.Point(30, 48);
            this.lbWin.Name = "lbWin";
            this.lbWin.Size = new System.Drawing.Size(0, 13);
            this.lbWin.TabIndex = 0;
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(30, 23);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(0, 13);
            this.lbCount.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(382, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(337, 407);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 449);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Lucky Number";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button btRand;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Label lbLose;
        private System.Windows.Forms.Label lbWin;
        private System.Windows.Forms.Label lbCount;
    }
}

