using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class FormMain : Form
    {
        bool bClose;
        bool outNow=false;
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin fLog =   new FormLogin();
            fLog.ShowDialog();
            showName.Text = fLog.username;
            bClose = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "") return;
            ListViewItem l = new ListViewItem(txtName.Text);
            l.SubItems.Add(txtBday.Text);
            l.SubItems.Add(rdNam.Checked ? "Nam" : "Nữ");
            l.ImageIndex = rdNam.Checked? 0 : 1;
            listView1.Items.Add(l);
            txtName.Text = "";
            txtName.Focus();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem l in listView1.SelectedItems) l.Remove();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.07;
            if(this.Opacity <= 0)
            {
                bClose = true;
                Application.Exit();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!bClose)
            {
                e.Cancel = true;
                timer1.Enabled = true;
            }
        }
    }
}
