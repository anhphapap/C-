using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace OnGK2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        FormWelcome formWelcome = new FormWelcome();

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Visible = false;   
            formWelcome.Show();
            timer1.Enabled = true;
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormImage image = new OnGK2.FormImage();
            image.MdiParent = this;
            image.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Đóng ứng dụng?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) e.Cancel  = true;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormList list = new OnGK2.FormList();
            list.MdiParent = this;
            list.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Visible = true;
            formWelcome.Close();
        }
    }
}
