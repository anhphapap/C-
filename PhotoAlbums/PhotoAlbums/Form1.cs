using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PhotoAlbums
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addTree();
        }

        void addTree()
        {
            String[] listDrive = Directory.GetLogicalDrives();
            TreeNode node;
            foreach (string f in listDrive)
            {
                node = new TreeNode(f);
                node.ImageIndex = 2;
                node.Nodes.Add("tmp");
                node.SelectedImageIndex = 2;
                treeView.Nodes.Add(node);
            }
        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode curNode = e.Node;
            curNode.Nodes.Clear();
            string path = curNode.FullPath;
            string[] arrFiles = Directory.GetDirectories(path);
            TreeNode node;
            foreach (string f in arrFiles)
            {
                node = new TreeNode(Path.GetFileName(f));
                node.ImageIndex = 0;
                node.Nodes.Add("tmp");
                curNode.Nodes.Add(node);
            }
        }

        private void treeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level > 0)
            {
                e.Node.ImageIndex = 1;
                e.Node.SelectedImageIndex = 1;
            }
        }

        private void treeView_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level > 0)
            {
                e.Node.ImageIndex = 0;
                e.Node.SelectedImageIndex = 0;
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                pbThum.Controls.Clear();
                string[] arrFiles = Directory.GetFiles(e.Node.FullPath);
                foreach (string f in arrFiles)
                {
                    if (f.ToLower().EndsWith(".jpg") || f.ToLower().EndsWith(".png") || f.ToLower().EndsWith(".gif") || f.ToLower().EndsWith(".bmp"))
                    {
                        PictureBox p = new PictureBox();
                        p.Image = Image.FromFile(f);
                        p.Width = p.Height = pbThum.Height - 10;
                        p.SizeMode = PictureBoxSizeMode.StretchImage;
                        p.Click += P_Click;
                        pbThum.Controls.Add(p);
                    }
                }
            }
            catch { }
        }

        private void P_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pShow.Image = p.Image;
        }
    }
}
