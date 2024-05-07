using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int point = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!rd1.Checked && !rd2.Checked && !rd3.Checked && !rd4.Checked)
                MessageBox.Show("Bạn chưa chọn đáp án!", "Chú ý!!!", MessageBoxButtons.OK);
            else
            {
                button1.Enabled = false;
                num1.Text = random.Next(10).ToString();
                button2.Enabled = true;
                rd1.Enabled = false;
                rd2.Enabled = false;
                rd3.Enabled = false;
                rd4.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            num2.Text = random.Next(10).ToString();
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            num3.Text = random.Next(10).ToString();
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button1.Enabled = true;
            rd1.Enabled = true;
            rd2.Enabled = true;
            rd3.Enabled = true;
            rd4.Enabled = true;
            if(rd1.Checked)
            {
                if(num1.Text == num2.Text && num2.Text == num3.Text)
                {
                    point += 10;
                    lbPoint.Text = point.ToString();
                }
                else
                {
                    point -= 10;
                    lbPoint.Text = point.ToString();
                }
            }
            else if(rd2.Checked)
            {
                if(num1.Text != num2.Text && num2.Text != num3.Text && num3.Text != num1.Text)
                {
                    point += 10;
                    lbPoint.Text = point.ToString();
                }
                else
                {
                    point -= 10;
                    lbPoint.Text = point.ToString();
                }
            }
            else if (rd3.Checked)
            {
                if (num1.Text != num2.Text && num1.Text == num3.Text)
                {
                    point += 10;
                    lbPoint.Text = point.ToString();
                }
                else
                {
                    point -= 10;
                    lbPoint.Text = point.ToString();
                }
            }
            else
            {
                if((num1.Text == num2.Text && num2.Text == num3.Text)||(num1.Text != num2.Text && num2.Text != num3.Text && num3.Text != num1.Text)||(num1.Text != num2.Text && num1.Text == num3.Text))
                {
                    point -= 10;
                    lbPoint.Text = point.ToString();
                }
                else
                {
                    point += 10;
                    lbPoint.Text = point.ToString();
                }
            }
            num1.Text = "0";
            num2.Text = "0";
            num3.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }
    }
}

