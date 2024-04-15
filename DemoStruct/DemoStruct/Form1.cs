using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

struct Time
{
    int hour, min, sec;
    public Time(int h,int m, int s)
    {
        hour = h;
        min = m;
        sec = s;
    }

    public int Hour
    {
        get { return  hour; }
        set { hour = value; }
    }

    public int Min
    {
        get => min;
        set { min = value; }
    }

    public int Sec
    {
        get { return sec; }
        set { sec = value; }    
    }

    public string ShowTime()
    {
        FixTime();
        return String.Format("{0:0} : {1:00} : {2:00}", hour, min, sec); ;
    }

    public void FixTime()
    {
        int t = sec / 60;
        sec = sec % 60;
        min += t;
        t = min / 60;
        min = min % 60;
        hour += t;
        hour %= 24;
    }
}

namespace DemoStruct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bShow_Click(object sender, EventArgs e)
        {
            Time time = new Time(int.Parse(tHour.Text), int.Parse(tMin.Text), int.Parse(tSec.Text));
            time.FixTime();
            ans.Text = time.ShowTime();
        }

        private void ans_Click(object sender, EventArgs e)
        {

        }
    }
}
