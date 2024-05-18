using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnGK1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random Random = new Random();
        int n1=6,n2=6,n3 = 6;
        int money = 1000;
        int pick1, pick2;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Đóng ứng dụng?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No) e.Cancel = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pic1.Visible = true;
                pic2.Visible = true;
                pic3.Visible = true;
            }
            else
            {
                pic1.Visible = false;
                pic2.Visible = false;
                pic3.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pick1 = int.Parse(comboBox1.SelectedItem.ToString());
            pick2 = int.Parse(comboBox2.SelectedItem.ToString());
            if(pick1 + pick2 > money)
            {
                MessageBox.Show("Tổng số tiền cược không được lớn hơn tổng số tiền còn lại!", "", MessageBoxButtons.OK);
            }
            else
            {
                n1 = Random.Next(1, 7);
                n2 = Random.Next(1, 7);
                n3 = Random.Next(1, 7);
                pic1.Image = Image.FromFile("Images/" + n1.ToString() + ".png");
                pic2.Image = Image.FromFile("Images/" + n2.ToString() + ".png");
                pic3.Image = Image.FromFile("Images/" + n3.ToString() + ".png");
                num1.Text = n1.ToString();
                num2.Text = n2.ToString();
                num3.Text = n3.ToString();
                int sum = n1 + n2 + n3;
                if ((sum % 2 == 0 && rdChan.Checked) || (sum % 2 != 0 && rdLe.Checked)) money += pick1;
                else money -= pick1;
                if((sum <11 && rdXiu.Checked) || (sum >10 && rdTai.Checked)) money += pick2;
                else money -= pick2;
                lbMoney.Text = money.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            pic1.Image = Image.FromFile("Images/6.png");
            pic2.Image = Image.FromFile("Images/6.png");
            pic3.Image = Image.FromFile("Images/6.png");
            num1.Text= n1.ToString();
            num2.Text= n2.ToString();
            num3.Text= n3.ToString();
        }
    }
}
