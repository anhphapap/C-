using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        int dx=10, dy=10;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ball.Left < 0 || ball.Left + ball.Width > ClientRectangle.Width) dx = -dx;
            if (ball.Top < 0 || ball.Top + ball.Height > ClientRectangle.Height) dy = -dy;
            ball.Left += dx;
            ball.Top += dy;
        }
    }
}
