namespace DrawShapes
{
    partial class FormOption
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
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.btColor = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd3);
            this.groupBox1.Controls.Add(this.rd2);
            this.groupBox1.Controls.Add(this.rd1);
            this.groupBox1.Location = new System.Drawing.Point(27, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // rd3
            // 
            this.rd3.AutoSize = true;
            this.rd3.Location = new System.Drawing.Point(36, 105);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(63, 17);
            this.rd3.TabIndex = 0;
            this.rd3.TabStop = true;
            this.rd3.Text = "Triangle";
            this.rd3.UseVisualStyleBackColor = true;
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.Location = new System.Drawing.Point(36, 67);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(55, 17);
            this.rd2.TabIndex = 0;
            this.rd2.TabStop = true;
            this.rd2.Text = "Ellipse";
            this.rd2.UseVisualStyleBackColor = true;
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Checked = true;
            this.rd1.Location = new System.Drawing.Point(36, 29);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(74, 17);
            this.rd1.TabIndex = 0;
            this.rd1.TabStop = true;
            this.rd1.Text = "Rectangle";
            this.rd1.UseVisualStyleBackColor = true;
            // 
            // btColor
            // 
            this.btColor.BackColor = System.Drawing.Color.Red;
            this.btColor.Location = new System.Drawing.Point(27, 184);
            this.btColor.Name = "btColor";
            this.btColor.Size = new System.Drawing.Size(256, 32);
            this.btColor.TabIndex = 1;
            this.btColor.UseVisualStyleBackColor = false;
            this.btColor.Click += new System.EventHandler(this.btColor_Click);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(59, 236);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(86, 26);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(163, 236);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(86, 26);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // FormOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 282);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btColor);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormOption";
            this.Text = "FormOption";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.Button btColor;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
    }
}