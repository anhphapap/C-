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
    public partial class FormImage : Form
    {
        public FormImage()
        {
            InitializeComponent();
        }

        private void FormImage_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rc1 = new Rectangle(0,0,ClientRectangle.Width / 2, ClientRectangle.Height / 2);
            Rectangle rc2 = new Rectangle(0, ClientRectangle.Height/2, ClientRectangle.Width / 2, ClientRectangle.Height / 2);
            Rectangle rc3 = new Rectangle(ClientRectangle.Width / 2, 0, ClientRectangle.Width / 2, ClientRectangle.Height);
            Graphics g = e.Graphics;
            DrawImg(g, rc1);
            DrawText(g, rc2);
            DrawPolygon(g, rc3);
            g.DrawRectangles(new Pen(Color.Blue,5), new Rectangle[] { rc1, rc2, rc3 });
        }

        private void DrawImg(Graphics g, Rectangle r)
        {
            Image img = Image.FromFile("DHMLOGO_Bmp.bmp");
            g.DrawImage(img, r);
            StringFormat fm = new StringFormat();
            fm.LineAlignment = StringAlignment.Far;
            g.DrawString("OU", new Font("Arial", 32, FontStyle.Bold), new SolidBrush(Color.FromArgb(100, 255, 255, 0)), r,fm);
        }

        private void DrawText(Graphics g, Rectangle r)
        {
            g.FillRectangle(new LinearGradientBrush(r,Color.Wheat,Color.Black,10),r);
            StringFormat fm = new StringFormat();
            fm.Alignment = StringAlignment.Center;
            fm.LineAlignment = StringAlignment.Center;
            g.DrawString("HELLO", new Font("Arial", 64, FontStyle.Bold), new SolidBrush(Color.Green), r, fm);
        }

        private void DrawPolygon(Graphics g, Rectangle r)
        {
            Point[] p = { new Point(ClientRectangle.Width / 4 * 3,0),
            new Point(ClientRectangle.Width/2, ClientRectangle.Height/4),
            new Point(ClientRectangle.Width / 4 * 3, ClientRectangle.Height),
            new Point(ClientRectangle.Width, ClientRectangle.Height/4)
            };
            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(p);
            PathGradientBrush br = new PathGradientBrush(path);
            br.CenterColor = Color.Wheat;
            br.SurroundColors = new Color[] { Color.Yellow, Color.Tomato, Color.SteelBlue, Color.SkyBlue };
            g.FillPolygon(br, p);
        }

        private void FormImage_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
