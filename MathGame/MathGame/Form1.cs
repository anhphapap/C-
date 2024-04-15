using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            try
            {
                int ans = int.Parse(txtAns.Text);
                int num1 = int.Parse(lbNum1.Text);
                int num2 = int.Parse(lbNum2.Text);
                char mid = lbMid.Text[0];
                int res;
                if (mid == '+') res = num1 + num2;
                else if (mid == '-') res = num1 - num2;
                else if (mid == '*') res = num2 * num1;
                else res = num1 / num2;
                if (res == ans) lbRes.Text = "Correct!";
                else lbRes.Text = "Wrong! Ans = " + res;
            }
            catch(FormatException)
            {
                lbRes.Text = "Enter number!!!";
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            txtAns.Text = "";
            lbRes.Text = "";
            Random random = new Random();
            String m = "+-*/";
            int a, b, c;
            do
            {
                a = random.Next(0, 10);
                b = random.Next(0, 10);
                c = random.Next(0, 4);
            } while (b == 0 && c == 3);
            lbNum1.Text = a.ToString();
            lbNum2.Text = b.ToString();
            lbMid.Text = m[c].ToString();
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            txtAns.Text += btn.Text;
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            if (txtAns.Text == "") txtAns.Text = "-";
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if(txtAns.Text != "") txtAns.Text = txtAns.Text.Substring(0, txtAns.Text.Length - 1);
        }
    }
}
