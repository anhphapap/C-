using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnGK5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x,y,w,h;

        private void lineColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK) lineColor.BackColor = colorDialog.Color;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i<=15; i++) lineSize.Items.Add(i.ToString());
            lineSize.SelectedIndex = 0;
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            foreach (var x in listView1.SelectedItems) listView1.Items.Remove((ListViewItem)x);
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) 
            {
                Graphics g = panel1.CreateGraphics();
                g.Clear(Color.White);
                x = int.Parse(listView1.SelectedItems[0].Text);
                y = int.Parse(listView1.SelectedItems[0].SubItems[1].Text);
                w = int.Parse(listView1.SelectedItems[0].SubItems[2].Text);
                h = int.Parse(listView1.SelectedItems[0].SubItems[3].Text);
                int ls = int.Parse(lineSize.Text);
                g.DrawRectangle(new Pen(new SolidBrush(lineColor.BackColor), ls), new Rectangle(x - ls/2, y - ls/2 ,w + ls/2 , h + ls/2)) ;
                g.FillEllipse(new SolidBrush((Color)backColor.BackColor), new RectangleF(x,y,w,h));
            }
        }

        void saveFile(string fn)
        {
            ListViewItem[] lv = new ListViewItem[listView1.Items.Count];
            listView1.Items.CopyTo(lv, 0);
            using(FileStream f = File.Create(fn))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(f,lv);
            }
        }

        void openFile(string fn)
        {
            ListViewItem[] lv = null;
            using(FileStream f = File.OpenRead(fn))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                lv = (ListViewItem[])binaryFormatter.Deserialize(f);
            }
            listView1.Items.Clear();
            listView1.Items.AddRange(lv);
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Rectangle File (*.rect)|*.rect";
            if(saveFileDialog.ShowDialog() == DialogResult.OK) saveFile(saveFileDialog.FileName);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Rectangle File (*.rect)|*.rect";
            if(openFileDialog.ShowDialog() == DialogResult.OK) openFile(openFileDialog.FileName);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Close application?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel) e.Cancel = true; 
        }

        private void backColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK) backColor.BackColor = colorDialog.Color;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                x = int.Parse(tbX.Text);
                y = int.Parse(tbY.Text);
                w = int.Parse(tbW.Text);
                h = int.Parse(tbH.Text);
                ListViewItem item = new ListViewItem(tbX.Text);
                item.SubItems.Add(tbY.Text);
                item.SubItems.Add(tbW.Text);
                item.SubItems.Add(tbH.Text);
                listView1.Items.Add(item);
                tbX.Text = ""; 
                tbY.Text = "";
                tbH.Text = ""; 
                tbW.Text = ""; 
                tbX.Select();
            }
            catch
            {

            }
        }
    }
}
