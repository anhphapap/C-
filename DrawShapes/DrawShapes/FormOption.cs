using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawShapes
{
    public partial class FormOption : Form
    {
        public FormOption()
        {
            InitializeComponent();
        }
        public static Color c = Color.Red;
        public static bool ok = false;
        public static int select = 1;
        private void btColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if(dlg.ShowDialog() == DialogResult.OK) c = dlg.Color;
            btColor.BackColor = c;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            ok = true;
            if (rd1.Checked) select = 1;
            else if (rd2.Checked) select = 2;
            else select = 3;
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
