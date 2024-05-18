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

namespace Bai6
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void FormWelcome_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void FormWelcome_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            drawBackground(g,ClientRectangle);
            drawText(g,ClientRectangle);
        }

        private void drawBackground(Graphics g, Rectangle r) {
            g.FillRectangle(new LinearGradientBrush(r, Color.AliceBlue, Color.Brown, 10), r);
        }

        private void drawText(Graphics g, Rectangle r)
        {
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            g.DrawString("2251052087-Phạm Anh Pha", new Font("Arial", 36, FontStyle.Italic), new HatchBrush(HatchStyle.Cross, Color.AntiqueWhite), r, sf);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = int.Parse(label1.Text);
            if (x > 0)
            {
                x--;
                label1.Text = x.ToString();
            }
            else
            {
                timer1.Enabled = false;
                this.Close();
            }
        }
    }
}
