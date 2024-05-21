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

namespace OnGK4
{
    public partial class FormDraw : Form
    {
        public FormDraw()
        {
            InitializeComponent();
        }

        private void FormDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Image img = Image.FromFile("pic.jpg");
            g.DrawImage(img, new Rectangle(0, 0, ClientRectangle.Width / 2, ClientRectangle.Height / 2));
            img.RotateFlip(RotateFlipType.Rotate180FlipY);
            g.DrawImage(img, new Rectangle(ClientRectangle.Width / 2, 0, ClientRectangle.Width / 2, ClientRectangle.Height / 2));
            g.FillRectangle(new HatchBrush(HatchStyle.Cross, Color.Yellow, Color.Orange),new Rectangle(0,ClientRectangle.Height/2,ClientRectangle.Width, ClientRectangle.Height/2));
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            Color color = Color.FromArgb(100, Color.Blue);
            g.DrawString("2251052087", new Font("Arial", 60, FontStyle.Bold), new SolidBrush(color), new Rectangle(5, ClientRectangle.Height / 2+5, ClientRectangle.Width, ClientRectangle.Height / 2), format);
            g.DrawString("2251052087", new Font("Arial", 60, FontStyle.Bold), new SolidBrush(Color.Blue), new Rectangle(0, ClientRectangle.Height / 2, ClientRectangle.Width, ClientRectangle.Height / 2), format);
        }
    }
}
