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

namespace SimplePaint
{
    public partial class FormMouse : Form
    {
        public FormMouse()
        {
            InitializeComponent();
        }

        Point pOld;
        Color color;
        int pathWidth;
        Bitmap bmpTemp;

        private void FormMouse_MouseDown(object sender, MouseEventArgs e)
        {
            pOld = e.Location;
        }

        private void FormMouse_Load(object sender, EventArgs e)
        {
            color = Color.Red;
            pathWidth = 1;
            bmpTemp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        private void FormMouse_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(bmpTemp);
                Pen pen = new Pen(color,pathWidth);
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                g.DrawLine(pen, pOld, e.Location);
                pOld = e.Location;
                Invalidate();
            }
        }

        private void FormMouse_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmpTemp, 0, 0);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.R: color = Color.Red; break;
                case Keys.G: color = Color.Green; break;
                case Keys.B: color = Color.Blue; break;
                case Keys.Up: pathWidth += (pathWidth < 50) ? 1 : 0; break;
                case Keys.Down: pathWidth += (pathWidth > 1) ? -1 : 0; break;
            }
            return true;
        }
    }
}
