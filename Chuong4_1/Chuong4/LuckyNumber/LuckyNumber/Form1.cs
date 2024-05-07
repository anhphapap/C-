using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count=0, win=0;
        String choose = "1";
        private void bt1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            String s = "./Images/" + b.Text + ".png";
            pic.Image = Image.FromFile(s);
            choose = b.Text;
        }

        private void update()
        {
            double x = (double) win / count * 100;
            lbCount.Text = "Lần đoán: " + count.ToString();
            lbWin.Text = "Lần thắng: " + win.ToString()+ " (" + String.Format("{0:0.00}%)", x);
            lbLose.Text = "Lần thua: " + (count - win).ToString()+ " (" + String.Format("{0:0.00}%)", 100-x);
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            count = 0;
            win = 0;
            choose = "1";
            pic.Image = Image.FromFile("./Images/1.png");
            lbCount.Text = "";
            lbWin.Text = "";
            lbLose.Text = "";
            pic2.Image = null;
            listBox1.Items.Clear();    
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btRand_Click(sender, e); break;
                case Keys.Escape:
                    btReset_Click(sender, e); break ;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btRand_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            String x = r.Next(1,7).ToString();
            String s = "./Images/" + x + ".png";
            String add;
            pic2.Image = Image.FromFile(s);
            if(x == choose)
            {
                count++;
                win++;
                add = count.ToString()+". Thắng (Đoán "+choose+" ra "+x+")";
                update();
                listBox1.Items.Add(add);
            }
            else
            {
                count++;
                add = count.ToString() + ". Thua (Đoán " + choose + " ra " + x + ")";
                update();
                listBox1.Items.Add(add);
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter: btRand_Click(new object(), new EventArgs());break;
                case Keys.Escape: btReset_Click(new object(), new EventArgs()); break;
            }
            return true;
        }
    }
}
