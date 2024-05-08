using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RandomImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] files;
        int time = 100;
        Random random = new Random();

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btRand_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            files = Directory.GetFiles("Gift");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int idx = random.Next(files.Length);
            pbImage.Image = Image.FromFile(files[idx]);
            if (time > 400)
            {
                if(idx == 1)
                {
                    btRand.Enabled = false;
                }else if(idx == 0) {

                }
                else
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Height = pictureBox.Width = 150;
                    pictureBox.BackColor = Color.Beige;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Image = Image.FromFile(files[idx]);
                    listGift.Controls.Add(pictureBox);
                }
                time = 1;
                timer1.Enabled=false;
            }
            else
            { 
                time += 50;
                timer1.Interval = time;
            }
        }

        private void btRestart_Click(object sender, EventArgs e)
        {
            listGift.Controls.Clear();
            pbImage.Image = null;
            btRand.Enabled = true;
        }
    }
}
