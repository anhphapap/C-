namespace RandomImage
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btRand = new System.Windows.Forms.Button();
            this.btRestart = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.listGift = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRÒ CHƠI QUAY SỐ TRÚNG THƯỞNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.SystemColors.Info;
            this.pbImage.Location = new System.Drawing.Point(7, 60);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(201, 193);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            // 
            // btRand
            // 
            this.btRand.Location = new System.Drawing.Point(7, 268);
            this.btRand.Name = "btRand";
            this.btRand.Size = new System.Drawing.Size(199, 44);
            this.btRand.TabIndex = 0;
            this.btRand.Text = "Quay số";
            this.btRand.UseVisualStyleBackColor = true;
            this.btRand.Click += new System.EventHandler(this.btRand_Click);
            // 
            // btRestart
            // 
            this.btRestart.Location = new System.Drawing.Point(7, 331);
            this.btRestart.Name = "btRestart";
            this.btRestart.Size = new System.Drawing.Size(199, 44);
            this.btRestart.TabIndex = 1;
            this.btRestart.Text = "Chơi lại";
            this.btRestart.UseVisualStyleBackColor = true;
            this.btRestart.Click += new System.EventHandler(this.btRestart_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(7, 394);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(199, 44);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "Đóng";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // listGift
            // 
            this.listGift.AutoScroll = true;
            this.listGift.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listGift.Location = new System.Drawing.Point(223, 102);
            this.listGift.Name = "listGift";
            this.listGift.Size = new System.Drawing.Size(562, 335);
            this.listGift.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(223, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(561, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giỏ quà của bạn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listGift);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btRestart);
            this.Controls.Add(this.btRand);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Gift";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btRand;
        private System.Windows.Forms.Button btRestart;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.FlowLayoutPanel listGift;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

