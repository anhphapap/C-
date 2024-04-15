using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 5;
        int y = 5;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ball.Left < 0 || ball.Left > (ClientRectangle.Width - ball.Width)) x = -x;
            if (ball.Top < 0 || ball.Top > (ClientRectangle.Height - ball.Height)) y = -y;
            ball.Left += x;
            ball.Top += y;
        }
    }
}
