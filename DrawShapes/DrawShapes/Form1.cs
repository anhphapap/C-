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

namespace DrawShapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOption formOption = new FormOption();
            formOption.ShowDialog();
        }
        bool mouseDown;
        Point clickPos;
        Rectangle rect;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Invalidate(rect);
                if (e.Location.X > clickPos.X && e.Location.Y > clickPos.Y)
                {
                    rect = new Rectangle(clickPos.X, clickPos.Y, e.Location.X - clickPos.X, e.Location.Y - clickPos.Y);
                }
                else if (e.Location.X > clickPos.X && e.Location.Y < clickPos.Y)
                {
                    rect = new Rectangle(clickPos.X, e.Location.Y, e.Location.X - clickPos.X, clickPos.Y - e.Location.Y);
                }
                else if (e.Location.X < clickPos.X && e.Location.Y < clickPos.Y)
                {
                    rect = new Rectangle(e.Location.X, e.Location.Y, clickPos.X - e.Location.X, clickPos.Y - e.Location.Y);
                }
                else if (e.Location.X < clickPos.X && e.Location.Y > clickPos.Y)
                {
                    rect = new Rectangle(e.Location.X, clickPos.Y, clickPos.X - e.Location.X, e.Location.Y - clickPos.Y);
                }

                this.Invalidate(rect);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            clickPos = e.Location;
            rect = new Rectangle(clickPos, new Size(0, 0));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(FormOption.c), rect);
        }
    }
}
