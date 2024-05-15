using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallGame1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int move = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (move)
            {
                case 0:
                    {
                        ball.Left -= 10;
                        if (ball.Left < -80)
                            ball.Left = ClientRectangle.Width;
                    }
                    break;
                case 1:
                    {
                        ball.Top -= 10;
                        if (ball.Top < -80)
                            ball.Top = ClientRectangle.Height;
                    }
                    break;
                case 2:
                    {
                        ball.Left += 10;
                        if (ball.Left >= ClientRectangle.Width)
                            ball.Left = -80;
                    }
                    break;
                case 3:
                    {
                        ball.Top += 10;
                        if (ball.Top >= ClientRectangle.Height)
                            ball.Top = -80;
                    }
                    break;
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.S:
                    {
                        if (!timer1.Enabled) 
                            timer1.Enabled = true; 
                        else
                            timer1.Enabled = false;
                    }
                    break;
                case Keys.Up: move = 1; break;
                case Keys.Down: move = 3; break;
                case Keys.Left: move = 0; break;
                case Keys.Right: move = 2; break;
                case Keys.U: timer1.Interval -= (timer1.Interval > 10) ? 10 : 0; break;
                case Keys.D: timer1.Interval += (timer1.Interval < 200) ? 10 : 0; break;
            }
            return true;
        }

        private void changeImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image (*.jpg)|*.jpg";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackgroundImage = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void changeBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackgroundImage = null;
                this.BackColor = colorDialog.Color;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Đóng ứng dụng?","Cảnh báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
        }
    }
}
