using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnGK4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void đóngỨngDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Đóng ứng dụng?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No) e.Cancel = true;
        }

        private void xửLýChuỗiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormString formString = new OnGK4.FormString();
            formString.MdiParent = this;
            formString.Show();
        }

        private void vẽToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDraw fd = new FormDraw();
            fd.MdiParent = this;
            fd.Show();
        }
    }
}
