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
    public partial class FormDrawText : Form
    {
        public FormDrawText()
        {
            InitializeComponent();
        }

        private void FormDrawText_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font("Arial", 64, FontStyle.Bold);
            SolidBrush sb = new SolidBrush(Color.Green);
            StringFormat fm = new StringFormat();
            fm.Alignment = StringAlignment.Far;
            e.Graphics.DrawString("Hello", font, sb, ClientRectangle, fm);

            Image img = Image.FromFile("DHMLOGO_Bmp.bmp");
            TextureBrush tb = new TextureBrush(img);
            fm.Alignment = StringAlignment.Near;
            fm.LineAlignment = StringAlignment.Far;
            e.Graphics.DrawString("Hello", font, tb, ClientRectangle, fm);

            HatchBrush hb = new HatchBrush(HatchStyle.Cross, Color.AntiqueWhite, Color.Chartreuse);
            fm.LineAlignment = StringAlignment.Near;
            fm.FormatFlags = StringFormatFlags.DirectionVertical;
            e.Graphics.DrawString("Hello", font, hb, ClientRectangle, fm);

            LinearGradientBrush lb = new LinearGradientBrush(new Point(0, 0), new Point(100,100), Color.Beige, Color.Blue);
            fm.LineAlignment = StringAlignment.Far;
            fm.Alignment = StringAlignment.Far;
            e.Graphics.DrawString("Hello", font, lb, ClientRectangle, fm);

        }

        private void FormDrawText_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
