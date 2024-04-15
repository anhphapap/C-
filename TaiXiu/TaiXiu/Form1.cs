using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaiXiu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int a = r.Next(1, 7);
            int b = r.Next(1, 7);
            int c = r.Next(1, 7);

            label1.Text = String.Format("{0}", a);
            label2.Text = String.Format("{0}", b);
            label3.Text = String.Format("{0}", c);
            if (a + b + c > 10)
            {
                ans.Text = "Cook";
            }
            else
            {
                ans.Text = "Bú bú";
            }

        }

        private void xiu_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int a = r.Next(1, 7);
            int b = r.Next(1, 7);
            int c = r.Next(1, 7);

            label1.Text = String.Format("{0}", a);
            label2.Text = String.Format("{0}", b);
            label3.Text = String.Format("{0}", c);
            if (a + b + c < 11)
            {
                ans.Text = "Cook";
            }
            else
            {
                ans.Text = "Bú bú";
            }

        }
    }
}
