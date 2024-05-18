namespace OnGK1
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
            this.rdChan = new System.Windows.Forms.RadioButton();
            this.rdLe = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdTai = new System.Windows.Forms.RadioButton();
            this.rdXiu = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMoney = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.num3 = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdLe);
            this.groupBox1.Controls.Add(this.rdChan);
            this.groupBox1.Location = new System.Drawing.Point(56, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn chẵn lẻ";
            // 
            // rdChan
            // 
            this.rdChan.AutoSize = true;
            this.rdChan.Checked = true;
            this.rdChan.Location = new System.Drawing.Point(22, 32);
            this.rdChan.Name = "rdChan";
            this.rdChan.Size = new System.Drawing.Size(50, 17);
            this.rdChan.TabIndex = 0;
            this.rdChan.TabStop = true;
            this.rdChan.Text = "Chẵn";
            this.rdChan.UseVisualStyleBackColor = true;
            // 
            // rdLe
            // 
            this.rdLe.AutoSize = true;
            this.rdLe.Location = new System.Drawing.Point(146, 32);
            this.rdLe.Name = "rdLe";
            this.rdLe.Size = new System.Drawing.Size(37, 17);
            this.rdLe.TabIndex = 0;
            this.rdLe.Text = "Lẻ";
            this.rdLe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số tiền cược:";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "1";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500"});
            this.comboBox1.Location = new System.Drawing.Point(95, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rdTai);
            this.groupBox2.Controls.Add(this.rdXiu);
            this.groupBox2.Location = new System.Drawing.Point(478, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 108);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn tổng số";
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "1";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500"});
            this.comboBox2.Location = new System.Drawing.Point(95, 74);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tiền cược:";
            // 
            // rdTai
            // 
            this.rdTai.AutoSize = true;
            this.rdTai.Location = new System.Drawing.Point(146, 32);
            this.rdTai.Name = "rdTai";
            this.rdTai.Size = new System.Drawing.Size(52, 17);
            this.rdTai.TabIndex = 0;
            this.rdTai.Text = "11-18";
            this.rdTai.UseVisualStyleBackColor = true;
            // 
            // rdXiu
            // 
            this.rdXiu.AutoSize = true;
            this.rdXiu.Checked = true;
            this.rdXiu.Location = new System.Drawing.Point(22, 32);
            this.rdXiu.Name = "rdXiu";
            this.rdXiu.Size = new System.Drawing.Size(46, 17);
            this.rdXiu.TabIndex = 0;
            this.rdXiu.TabStop = true;
            this.rdXiu.Text = "3-10";
            this.rdXiu.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(56, 358);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Giao diện hình";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Quay Số";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tiền còn lại:";
            // 
            // lbMoney
            // 
            this.lbMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoney.Location = new System.Drawing.Point(575, 362);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(135, 67);
            this.lbMoney.TabIndex = 5;
            this.lbMoney.Text = "1000";
            this.lbMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num1
            // 
            this.num1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(58, 32);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(129, 120);
            this.num1.TabIndex = 6;
            this.num1.Text = "1";
            this.num1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num2
            // 
            this.num2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(316, 32);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(129, 120);
            this.num2.TabIndex = 6;
            this.num2.Text = "1";
            this.num2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num3
            // 
            this.num3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(573, 32);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(129, 120);
            this.num3.TabIndex = 6;
            this.num3.Text = "1";
            this.num3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(56, 32);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(129, 120);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 7;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(316, 32);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(129, 120);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 7;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Location = new System.Drawing.Point(573, 32);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(129, 120);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic3.TabIndex = 7;
            this.pic3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.lbMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2251052087 - Phạm Anh Pha";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdChan;
        private System.Windows.Forms.RadioButton rdLe;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdTai;
        private System.Windows.Forms.RadioButton rdXiu;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label num3;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
    }
}

