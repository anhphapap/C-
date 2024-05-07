using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                cbDisk.Items.Add(drive.Name);
            }
        }

        private void cbDisk_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDisk.Text = cbDisk.Items[cbDisk.SelectedIndex].ToString();
            String[] arrFile = Directory.GetDirectories(lbDisk.Text);
            foreach (String file in arrFile)
            {
                listView1.Items.Add(file);
            }
        }
    }
}
