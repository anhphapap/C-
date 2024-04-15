namespace DemoStruct
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
            this.tHour = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tSec = new System.Windows.Forms.TextBox();
            this.bShow = new System.Windows.Forms.Button();
            this.ans = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tHour
            // 
            this.tHour.Location = new System.Drawing.Point(353, 61);
            this.tHour.Name = "tHour";
            this.tHour.Size = new System.Drawing.Size(118, 20);
            this.tHour.TabIndex = 0;
            this.tHour.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập giờ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập phút:";
            // 
            // tMin
            // 
            this.tMin.Location = new System.Drawing.Point(353, 105);
            this.tMin.Name = "tMin";
            this.tMin.Size = new System.Drawing.Size(118, 20);
            this.tMin.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập giây:";
            // 
            // tSec
            // 
            this.tSec.Location = new System.Drawing.Point(353, 151);
            this.tSec.Name = "tSec";
            this.tSec.Size = new System.Drawing.Size(118, 20);
            this.tSec.TabIndex = 4;
            // 
            // bShow
            // 
            this.bShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bShow.Location = new System.Drawing.Point(208, 207);
            this.bShow.Name = "bShow";
            this.bShow.Size = new System.Drawing.Size(105, 36);
            this.bShow.TabIndex = 6;
            this.bShow.Text = "Hiển thị";
            this.bShow.UseVisualStyleBackColor = true;
            this.bShow.Click += new System.EventHandler(this.bShow_Click);
            // 
            // ans
            // 
            this.ans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans.Location = new System.Drawing.Point(353, 209);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(169, 34);
            this.ans.TabIndex = 7;
            this.ans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ans.Click += new System.EventHandler(this.ans_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.bShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tHour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tSec;
        private System.Windows.Forms.Button bShow;
        private System.Windows.Forms.Label ans;
    }
}

