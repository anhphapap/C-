using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnGK3
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Left + pictureBox1.Width >= pictureBox2.Left)
            {
                timer1.Enabled = false;
                this.Close();
            }
            pictureBox1.Left += 8;
            pictureBox2.Left -= 8;
        }
    }
}
