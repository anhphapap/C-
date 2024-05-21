namespace OnGK4
{
    partial class FormString
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btDel = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.rdFirst = new System.Windows.Forms.RadioButton();
            this.rdLast = new System.Windows.Forms.RadioButton();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btReverse = new System.Windows.Forms.Button();
            this.btFix = new System.Windows.Forms.Button();
            this.btColor = new System.Windows.Forms.Button();
            this.btFont = new System.Windows.Forms.Button();
            this.lbFix = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.btDel);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.rdFirst);
            this.groupBox1.Controls.Add(this.rdLast);
            this.groupBox1.Controls.Add(this.tbInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 447);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(10, 184);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(364, 251);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(305, 132);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(70, 23);
            this.btDel.TabIndex = 2;
            this.btDel.Text = "Xóa";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(305, 103);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(70, 23);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdFirst
            // 
            this.rdFirst.AutoSize = true;
            this.rdFirst.Location = new System.Drawing.Point(15, 138);
            this.rdFirst.Name = "rdFirst";
            this.rdFirst.Size = new System.Drawing.Size(146, 17);
            this.rdFirst.TabIndex = 2;
            this.rdFirst.Text = "Chèn vào đầu danh sách";
            this.rdFirst.UseVisualStyleBackColor = true;
            // 
            // rdLast
            // 
            this.rdLast.AutoSize = true;
            this.rdLast.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdLast.Checked = true;
            this.rdLast.Location = new System.Drawing.Point(15, 103);
            this.rdLast.Name = "rdLast";
            this.rdLast.Size = new System.Drawing.Size(147, 17);
            this.rdLast.TabIndex = 2;
            this.rdLast.TabStop = true;
            this.rdLast.Text = "Chèn vào cuối danh sách";
            this.rdLast.UseVisualStyleBackColor = true;
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(9, 55);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(366, 20);
            this.tbInput.TabIndex = 0;
            this.tbInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbInput_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập chuỗi:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btReverse);
            this.groupBox2.Controls.Add(this.btFix);
            this.groupBox2.Controls.Add(this.btColor);
            this.groupBox2.Controls.Add(this.btFont);
            this.groupBox2.Controls.Add(this.lbFix);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(409, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 447);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đinh dạng";
            // 
            // btReverse
            // 
            this.btReverse.Location = new System.Drawing.Point(50, 380);
            this.btReverse.Name = "btReverse";
            this.btReverse.Size = new System.Drawing.Size(131, 25);
            this.btReverse.TabIndex = 2;
            this.btReverse.Text = "Đảo chuỗi";
            this.btReverse.UseVisualStyleBackColor = true;
            this.btReverse.Click += new System.EventHandler(this.btReverse_Click);
            // 
            // btFix
            // 
            this.btFix.Location = new System.Drawing.Point(225, 380);
            this.btFix.Name = "btFix";
            this.btFix.Size = new System.Drawing.Size(131, 25);
            this.btFix.TabIndex = 3;
            this.btFix.Text = "Chuẩn hóa";
            this.btFix.UseVisualStyleBackColor = true;
            this.btFix.Click += new System.EventHandler(this.btFix_Click);
            // 
            // btColor
            // 
            this.btColor.Location = new System.Drawing.Point(225, 329);
            this.btColor.Name = "btColor";
            this.btColor.Size = new System.Drawing.Size(131, 25);
            this.btColor.TabIndex = 1;
            this.btColor.Text = "Định dạng màu";
            this.btColor.UseVisualStyleBackColor = true;
            this.btColor.Click += new System.EventHandler(this.btColor_Click);
            // 
            // btFont
            // 
            this.btFont.Location = new System.Drawing.Point(50, 329);
            this.btFont.Name = "btFont";
            this.btFont.Size = new System.Drawing.Size(131, 25);
            this.btFont.TabIndex = 0;
            this.btFont.Text = "Định dạng font";
            this.btFont.UseVisualStyleBackColor = true;
            this.btFont.Click += new System.EventHandler(this.btFont_Click);
            // 
            // lbFix
            // 
            this.lbFix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFix.Location = new System.Drawing.Point(18, 55);
            this.lbFix.Name = "lbFix";
            this.lbFix.Size = new System.Drawing.Size(361, 231);
            this.lbFix.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chuỗi dịnh dạng:";
            // 
            // FormString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormString";
            this.Text = "Xử lý chuỗi";
            this.Load += new System.EventHandler(this.FormString_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdLast;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.RadioButton rdFirst;
        private System.Windows.Forms.Button btReverse;
        private System.Windows.Forms.Button btFix;
        private System.Windows.Forms.Button btColor;
        private System.Windows.Forms.Button btFont;
        private System.Windows.Forms.Label lbFix;
        private System.Windows.Forms.Label label3;
    }
}