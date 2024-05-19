using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnGK2
{
    public partial class FormImage : Form
    {
        public FormImage()
        {
            InitializeComponent();
        }

        private void FormImage_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Jpeg file (*.jpg)|*.jpg|" + "Gif file (*.gif)|*.gif|" +"Png file (*png)|*.png|" + "Bitmap file (*.bmp)|*.bmp";
            if(ofd.ShowDialog() == DialogResult.OK) pictureBox1.Image = Image.FromFile(ofd.FileName);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Left < - pictureBox1.Width) {
                pictureBox1.Left = ClientRectangle.Width;
            }
            pictureBox1.Left -= 10;

        }
    }
}
