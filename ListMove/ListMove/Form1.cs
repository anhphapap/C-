using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListMove
{
    public partial class Form1 : Form
    {
        String[] strings = { "White", "Red", "Blue", "Green", "Yellow", "Black", "Cyan" };
        public Form1()
        {
            InitializeComponent();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Trim(' ') != string.Empty)
            {
                listBox1.Items.Add(txtInput.Text);
                txtInput.Text = string.Empty;
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedItems.Count - 1; i>= 0; i-- )
                listBox1.Items.Remove(listBox1.SelectedItems[i]);
            for (int i = listBox2.SelectedItems.Count - 1; i >= 0; i--)
                listBox2.Items.Remove(listBox2.SelectedItems[i]);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMoveRight_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
            {
                listBox2.Items.Add(listBox1.SelectedItems[i]);
                listBox1.Items.Remove(listBox1.SelectedItems[i]);
            }
        }

        private void btMoveLeft_Click(object sender, EventArgs e)
        {
            for (int i = listBox2.SelectedItems.Count - 1; i >= 0; i--)
            {
                listBox1.Items.Add(listBox2.SelectedItems[i]);
                listBox2.Items.Remove(listBox2.SelectedItems[i]);
            }
        }

        private void pickColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = pickColor.SelectedIndex;
            listBox2.BackColor = Color.FromName(strings[x]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pickColor.Items.AddRange(strings);
            pickColor.SelectedIndex = 0;
        }
    }
}
