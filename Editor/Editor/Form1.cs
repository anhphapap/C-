using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class Form1 : Form
    {
        int red = 0;
        int green = 0;
        int blue = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var flist = FontFamily.Families;
            foreach (var f in flist) listBox1.Items.Add(f.Name);
            for (int i = 7; i <= 72; i++) fontSize.Items.Add(i);
            hRed.Maximum = 255 + hRed.LargeChange - 1;
            hGreen.Maximum = 255 + hRed.LargeChange - 1;
            hBlue.Maximum = 255 + hRed.LargeChange - 1;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font fnt = new Font(listBox1.SelectedItem.ToString(), input.SelectionFont.Size, input.SelectionFont.Style);
            input.SelectionFont = fnt;
        }

        private void fontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font fnt = new Font(input.SelectionFont.FontFamily, float.Parse(fontSize.SelectedItem.ToString()),input.SelectionFont.Style);
            input.SelectionFont = fnt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontStyle fs;
            if ((input.SelectionFont.Style & ~ FontStyle.Bold) == input.SelectionFont.Style)
                 fs = input.SelectionFont.Style | FontStyle.Bold;
            else
                fs = input.SelectionFont.Style & ~FontStyle.Bold;
            Font fnt = new Font(input.SelectionFont.FontFamily, input.SelectionFont.Size, fs);
            input.SelectionFont = fnt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FontStyle fs;
            if ((input.SelectionFont.Style & ~FontStyle.Italic) == input.SelectionFont.Style)
                fs = input.SelectionFont.Style | FontStyle.Italic;
            else
                fs = input.SelectionFont.Style & ~FontStyle.Italic;
            Font fnt = new Font(input.SelectionFont.FontFamily, input.SelectionFont.Size, fs);
            input.SelectionFont = fnt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FontStyle fs;
            if ((input.SelectionFont.Style & ~FontStyle.Underline) == input.SelectionFont.Style)
                fs = input.SelectionFont.Style | FontStyle.Underline;
            else
                fs = input.SelectionFont.Style & ~FontStyle.Underline;
            Font fnt = new Font(input.SelectionFont.FontFamily, input.SelectionFont.Size, fs);
            input.SelectionFont = fnt;
        }

        private void hRed_Scroll(object sender, ScrollEventArgs e)
        {
            red = hRed.Value;
            color.BackColor = input.SelectionColor = Color.FromArgb(red, green, blue);
        }

        private void hGreen_Scroll(object sender, ScrollEventArgs e)
        {
            green = hGreen.Value;
            color.BackColor = input.SelectionColor = Color.FromArgb(red, green, blue);
        }

        private void hBlue_Scroll(object sender, ScrollEventArgs e)
        {
            blue = hBlue.Value;
            color.BackColor = input.SelectionColor = Color.FromArgb(red, green, blue);
        }

        private void input_SelectionChanged(object sender, EventArgs e)
        {
            Color c = input.SelectionColor;
            color.BackColor = c;
        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
