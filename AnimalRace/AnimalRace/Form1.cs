using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalRace
{
    public partial class Form1 : Form
    {
        public static Random rand = new Random();
        public static double time;
        public static int stop;
        Player[] player;
        Label[] labels = new Label[3];

        public Form1()
        {
            InitializeComponent();
        }
        double[] t = new double[3];

        private void btPrepare_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                t[i] = 0;
                player[i].prepare();
            }
            timep3.Text = timep2.Text = timep1.Text = "0";
            lbWinner.Text = "";
            btRun.Enabled = true;  
            btPrepare.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player = new Player[3];
            player[0] = new Player(player1, panel1," Fox ");
            player[1] = new Player(player2, panel2, " Crab ");
            player[2] = new Player(player3, panel3, " Hourse ");
            labels[0] = timep3;
            labels[1] = timep2;
            labels[2] = timep1;
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            btPrepare.Enabled = true;
            btRun.Enabled = false;
            time = -1;
            stop = 0;
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0;i < 3; i++)
            {
                t[i] = player[i].run();
                if (t[i] != -1 && t[i] != -2)
                {
                    labels[i].Text = String.Format("{0:0.0}", t[i]);
                }
                else if (t[i] == -1)
                {
                    lbWinner.Text += player[i].showName();
                    stop++;
                }else if (t[i] == -2)
                {
                    stop++;
                }
            }
            if (stop == 3) timer1.Enabled = false;
        }
    }
}
