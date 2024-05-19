using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnGK2
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void FormWelcome_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            StringFormat fm = new StringFormat();
            fm.Alignment = StringAlignment.Center;
            fm.LineAlignment = StringAlignment.Center;
            g.FillRectangle(new LinearGradientBrush(ClientRectangle, Color.Red, Color.Yellow, 100),ClientRectangle);
            g.DrawString("Pham Anh Pha", new Font("Arial", 40, FontStyle.Bold | FontStyle.Italic), new HatchBrush(HatchStyle.DashedHorizontal, Color.Black, Color.White), ClientRectangle, fm);

        }
    }
}
