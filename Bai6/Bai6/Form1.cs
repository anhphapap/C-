using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int move = 0;
        int d = 10;

        private void Form1_Load(object sender, EventArgs e)
        {
            FormWelcome f = new FormWelcome();
            f.ShowDialog();
        }

        private void changePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image (*.jpg)|*.jpg|" + "Png (*.png)|*.png";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pic.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit application?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.S:
                {
                    if (timer1.Enabled) timer1.Enabled = false;
                    else timer1.Enabled = true;
                }
                break;
                case Keys.Up: move = 1;break;
                case Keys.Down: move = 3;break;
                case Keys.Left: move = 0;break;
                case Keys.Right: move = 2; break;
            }
            return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(move) {
                case 0:
                {
                    if (pic.Left < -pic.Width)
                        pic.Left = ClientRectangle.Width;
                    else
                        pic.Left -= d;
                }
                break;
                case 2:
                {
                    if (pic.Left >= ClientRectangle.Width)
                        pic.Left = -pic.Width;
                    else
                        pic.Left += d;
                }
                break;
                case 1:
                {
                    if (pic.Top < -pic.Height)
                        pic.Top = ClientRectangle.Height;
                    else
                        pic.Top -= d;
                }
                break;
                case 3:
                {
                    if (pic.Top >= ClientRectangle.Height)
                        pic.Top = -pic.Height;
                    else
                        pic.Top += d;
                }
                break;
            }
        }
    }
}
