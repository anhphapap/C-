using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(num1.Text);
                int b = int.Parse(num2.Text);
                if (rd1.Checked)
                {
                    ans.Text = String.Format("{0}", a + b);
                } else if (rd2.Checked)
                {
                    ans.Text = String.Format("{0}", a - b);
                }
                else if (rd3.Checked)
                {
                    ans.Text = String.Format("{0}", a * b);
                }
                else if (rd4.Checked)
                {
                    if (b == 0) ans.Text = "Số chia phải khác 0!";
                    ans.Text = String.Format("{0}", (double)a / b);
                }
                else if (rd5.Checked)
                {
                    ans.Text = String.Format("{0}", a % b);
                }
                else
                    ans.Text = "Chọn phép đê";
            }
            catch (FormatException)
            {
                ans.Text = "Bạn phải nhập 2 số";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
