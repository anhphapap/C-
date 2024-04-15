namespace MathGame
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
            this.lbNum1 = new System.Windows.Forms.Label();
            this.lbNum2 = new System.Windows.Forms.Label();
            this.lbMid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.btCheck = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbRes = new System.Windows.Forms.Label();
            this.btNext = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNum1
            // 
            this.lbNum1.BackColor = System.Drawing.SystemColors.Info;
            this.lbNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNum1.Location = new System.Drawing.Point(130, 38);
            this.lbNum1.Name = "lbNum1";
            this.lbNum1.Size = new System.Drawing.Size(139, 83);
            this.lbNum1.TabIndex = 0;
            this.lbNum1.Text = "0";
            this.lbNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNum2
            // 
            this.lbNum2.BackColor = System.Drawing.SystemColors.Info;
            this.lbNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNum2.Location = new System.Drawing.Point(534, 38);
            this.lbNum2.Name = "lbNum2";
            this.lbNum2.Size = new System.Drawing.Size(139, 83);
            this.lbNum2.TabIndex = 0;
            this.lbNum2.Text = "0";
            this.lbNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMid
            // 
            this.lbMid.BackColor = System.Drawing.SystemColors.Info;
            this.lbMid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMid.Location = new System.Drawing.Point(359, 38);
            this.lbMid.Name = "lbMid";
            this.lbMid.Size = new System.Drawing.Size(85, 83);
            this.lbMid.TabIndex = 1;
            this.lbMid.Text = "+";
            this.lbMid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Answer:";
            // 
            // txtAns
            // 
            this.txtAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAns.Location = new System.Drawing.Point(251, 164);
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(272, 49);
            this.txtAns.TabIndex = 3;
            this.txtAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btCheck
            // 
            this.btCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheck.Location = new System.Drawing.Point(572, 167);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(101, 43);
            this.btCheck.TabIndex = 4;
            this.btCheck.Text = "Show";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Result:";
            // 
            // lbRes
            // 
            this.lbRes.BackColor = System.Drawing.SystemColors.Info;
            this.lbRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRes.ForeColor = System.Drawing.Color.Red;
            this.lbRes.Location = new System.Drawing.Point(252, 257);
            this.lbRes.Name = "lbRes";
            this.lbRes.Size = new System.Drawing.Size(271, 48);
            this.lbRes.TabIndex = 5;
            this.lbRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btNext
            // 
            this.btNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNext.Location = new System.Drawing.Point(572, 260);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(101, 43);
            this.btNext.TabIndex = 4;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // bt0
            // 
            this.bt0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt0.Location = new System.Drawing.Point(120, 333);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(65, 56);
            this.bt0.TabIndex = 6;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = false;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(219, 333);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(65, 56);
            this.bt1.TabIndex = 6;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt0_Click);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(320, 333);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(65, 56);
            this.bt2.TabIndex = 6;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.bt0_Click);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Location = new System.Drawing.Point(426, 333);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(65, 56);
            this.bt3.TabIndex = 6;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.bt0_Click);
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.Location = new System.Drawing.Point(522, 333);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(65, 56);
            this.bt4.TabIndex = 6;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.bt0_Click);
            // 
            // btMinus
            // 
            this.btMinus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinus.Location = new System.Drawing.Point(619, 333);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(65, 56);
            this.btMinus.TabIndex = 6;
            this.btMinus.Text = "-";
            this.btMinus.UseVisualStyleBackColor = false;
            this.btMinus.Click += new System.EventHandler(this.btMinus_Click);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.Location = new System.Drawing.Point(120, 408);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(65, 56);
            this.bt5.TabIndex = 6;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.bt0_Click);
            // 
            // bt6
            // 
            this.bt6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.Location = new System.Drawing.Point(219, 408);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(65, 56);
            this.bt6.TabIndex = 6;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = false;
            this.bt6.Click += new System.EventHandler(this.bt0_Click);
            // 
            // bt7
            // 
            this.bt7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.Location = new System.Drawing.Point(320, 408);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(65, 56);
            this.bt7.TabIndex = 6;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = false;
            this.bt7.Click += new System.EventHandler(this.bt0_Click);
            // 
            // bt8
            // 
            this.bt8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.Location = new System.Drawing.Point(426, 408);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(65, 56);
            this.bt8.TabIndex = 6;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = false;
            this.bt8.Click += new System.EventHandler(this.bt0_Click);
            // 
            // bt9
            // 
            this.bt9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.Location = new System.Drawing.Point(522, 408);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(65, 56);
            this.bt9.TabIndex = 6;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = false;
            this.bt9.Click += new System.EventHandler(this.bt0_Click);
            // 
            // btDel
            // 
            this.btDel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel.Location = new System.Drawing.Point(619, 408);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(65, 56);
            this.btDel.TabIndex = 6;
            this.btDel.Text = "Del";
            this.btDel.UseVisualStyleBackColor = false;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btMinus);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.lbRes);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbMid);
            this.Controls.Add(this.lbNum2);
            this.Controls.Add(this.lbNum1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MathGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNum1;
        private System.Windows.Forms.Label lbNum2;
        private System.Windows.Forms.Label lbMid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAns;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbRes;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btDel;
    }
}

