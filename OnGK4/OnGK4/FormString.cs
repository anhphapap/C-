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
    public partial class FormString : Form
    {
        public FormString()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = tbInput.Text.Trim();
            if (s.Length != 0)
            {
                if(rdLast.Checked)
                    listBox1.Items.Add(s);
                else
                    listBox1.Items.Insert(0, s);
                tbInput.Text = "";
                tbInput.Focus();
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void btFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                lbFix.Font = fontDialog.Font;
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            lbFix.Text = (string) listBox1.SelectedItem;
        }

        private void btColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                lbFix.ForeColor = colorDialog.Color;
            }
        }

        private void btFix_Click(object sender, EventArgs e)
        {
            string s="";
            char[] s2 = { ' ' };
            string[] s1 = lbFix.Text.Split(s2,StringSplitOptions.RemoveEmptyEntries);
            foreach(string x in s1)
            {
                x.Trim();
                s += x.Substring(0, 1).ToUpper() + x.Substring(1) + " ";
            }
            lbFix.Text = s;
        }

        private void btReverse_Click(object sender, EventArgs e)
        {
            string s = "";
            char[] s2 = { ' ' };
            string[] s1 = lbFix.Text.Split(s2, StringSplitOptions.RemoveEmptyEntries);
            foreach (string x in s1)
            {
                x.Trim();
                s = x + " " + s;
            }
            lbFix.Text = s;
        }

        private void tbInput_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Enter: button1_Click(new object(), new EventArgs()); break;
            }
        }

        private void FormString_Load(object sender, EventArgs e)
        {
            tbInput.Select();
        }
    }
}
