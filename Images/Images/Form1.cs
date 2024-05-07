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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Images
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String[] files;
        int temp = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            files = Directory.GetFiles("Images");
            for(int i = 0; i < files.Length; i++) listImages.Items.Add(files[i].Substring(7));
        }

        private void listImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            String fileName = "Images/";
            fileName += listImages.SelectedItem.ToString();
            Image img = Image.FromFile(fileName);
            pictureBox1.Image = img;
        }

        private void cbPlay_CheckedChanged(object sender, EventArgs e)
        {
            if(cbPlay.Checked)
            {
                if (listImages.SelectedItem != null)
                    temp = listImages.SelectedIndex + 1;
                else
                    temp = 0;
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled=false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (temp == files.Length) temp = 0;
            Image img = Image.FromFile(files[temp]);
            pictureBox1.Image = img;
            temp++;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image (*.jpg)|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                String nameNF = "./Images/";
                String temp = dlg.FileName.Substring(dlg.FileName.LastIndexOf('\\') + 1);
                nameNF += temp;
                File.Copy(dlg.FileName, nameNF);
                listImages.Items.Add(temp);
                files = Directory.GetFiles("Images");
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if(listImages.SelectedItem != null)
            {
                String fileName = "Images/";
                fileName += listImages.SelectedItem.ToString();
                FileInfo fi = new FileInfo(fileName);
                fi.Delete();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
