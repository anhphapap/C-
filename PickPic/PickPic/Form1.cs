using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickPic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int[] a = new int[8];
        int[] b = new int[16];
        int c = -1;
        int[] check=new int[2];
        int count = 0;
        bool stop=false;

        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < a.Length; i++) a[i] = 0;
            Random random = new Random();
            p1.Image = imageList1.Images[0];
            p1.Image = null;
            while (count<16)
            {
                int temp = random.Next(8);
                while (a[temp] == 2)
                {
                    temp = random.Next(8);
                }
                a[temp]++;
                b[count] = temp;
                count++;
            }
        }
        private void p1_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            if (stop || p.Image != null) return;
            PictureBox[] pic = { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16 };
            c++;
            String x = p.Name.Substring(1);
            int z = int.Parse(x);
            check[c] = z-1;
            p.Image = imageList1.Images[b[z-1]];
            if (c == 1)
            {
                c = -1;
                if (b[check[0]] != b[check[1]])
                {
                    if (!stop) {
                        timer1.Enabled = true;
                        stop = true;
                    }
                }else
                    count -= 2;
                if(count == 0)
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn đóng chương trình?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PictureBox[] pic = { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16 };
            pic[check[0]].Image = null;
            pic[check[1]].Image = null;
            timer1.Enabled = false;
            stop = false;
        }
    }
}
