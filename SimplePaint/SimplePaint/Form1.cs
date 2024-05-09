using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDrawText f = new FormDrawText();
            f.MdiParent = this;
            f.Show();
        }

        private void menuDrawMouse_Click(object sender, EventArgs e)
        {
            FormMouse f = new FormMouse();
            f.MdiParent = this;
            f.Show();
        }

        private void menuDrawImg_Click(object sender, EventArgs e)
        {
            FormImage f = new FormImage();
            f.MdiParent = this;
            f.Show();
        }
    }
}
