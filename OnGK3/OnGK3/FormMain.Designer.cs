namespace OnGK3
{
    partial class FormMain
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMoney = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.res1 = new System.Windows.Forms.PictureBox();
            this.res2 = new System.Windows.Forms.PictureBox();
            this.res3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.res1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.res2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.res3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbMoney);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbCost);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbSelect);
            this.groupBox1.Location = new System.Drawing.Point(642, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 422);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.res3);
            this.groupBox2.Controls.Add(this.res2);
            this.groupBox2.Controls.Add(this.res1);
            this.groupBox2.Location = new System.Drawing.Point(25, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 180);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả :";
            // 
            // cbSelect
            // 
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Items.AddRange(new object[] {
            "Bầu ",
            "Cá ",
            "Cua",
            "Gà",
            "Nai",
            "Tôm"});
            this.cbSelect.Location = new System.Drawing.Point(23, 38);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(101, 21);
            this.cbSelect.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiền cược:";
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(24, 197);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(100, 20);
            this.tbCost.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Quay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiền còn lại";
            // 
            // lbMoney
            // 
            this.lbMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoney.Location = new System.Drawing.Point(22, 340);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(101, 53);
            this.lbMoney.TabIndex = 4;
            this.lbMoney.Text = "1000";
            this.lbMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::OnGK3.Properties.Resources.bc6;
            this.pictureBox6.Location = new System.Drawing.Point(369, 117);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 100);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::OnGK3.Properties.Resources.bc3;
            this.pictureBox3.Location = new System.Drawing.Point(369, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::OnGK3.Properties.Resources.bc5;
            this.pictureBox5.Location = new System.Drawing.Point(263, 118);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 100);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OnGK3.Properties.Resources.bc2;
            this.pictureBox2.Location = new System.Drawing.Point(263, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::OnGK3.Properties.Resources.bc4;
            this.pictureBox4.Location = new System.Drawing.Point(157, 118);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OnGK3.Properties.Resources.bc1;
            this.pictureBox1.Location = new System.Drawing.Point(157, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // res1
            // 
            this.res1.Location = new System.Drawing.Point(49, 35);
            this.res1.Name = "res1";
            this.res1.Size = new System.Drawing.Size(120, 120);
            this.res1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.res1.TabIndex = 0;
            this.res1.TabStop = false;
            // 
            // res2
            // 
            this.res2.Location = new System.Drawing.Point(238, 35);
            this.res2.Name = "res2";
            this.res2.Size = new System.Drawing.Size(120, 120);
            this.res2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.res2.TabIndex = 0;
            this.res2.TabStop = false;
            // 
            // res3
            // 
            this.res3.Location = new System.Drawing.Point(424, 35);
            this.res3.Name = "res3";
            this.res3.Size = new System.Drawing.Size(120, 120);
            this.res3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.res3.TabIndex = 0;
            this.res3.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2251052087 - Phạm Anh Pha";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.res1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.res2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.res3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox res1;
        private System.Windows.Forms.PictureBox res3;
        private System.Windows.Forms.PictureBox res2;
    }
}

