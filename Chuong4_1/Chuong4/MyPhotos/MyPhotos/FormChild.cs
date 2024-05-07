using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhotos
{
    public partial class FormChild : Form
    {
        Image img;
        public FormChild()
        {
            InitializeComponent();
        }

        private void mLoad_Click(object sender, EventArgs e)
        {
            setImage("wall.JPG");
        }

        private void setImage(string s)
        {
            img = Image.FromFile(s);
            pic.Image = img;
        }

        private void FormChild_Load(object sender, EventArgs e)
        {
            setImage("wall.JPG");
        }

        private void mOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image file(*.jpg,*.png,*.bmp,...)|*.jpg;*.png;*.bmp;*.gif|" +
                "jpeg file(*.jpg)|*.jpg|" + 
                "png file(*.png)|*.png|" +
                "gif file(*.gif)|*.gif|" + 
                "bitmap file(*.bmp)|*.bmp";
            if(of.ShowDialog() == DialogResult.OK)
            {
                setImage((string)of.FileName);
            }
        }

        private void mClear_Click(object sender, EventArgs e)
        {
            pic.Image = null;
        }

        private void mSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Image file(*.jpg,*.png,*.bmp,...)|*.jpg;*.png;*.bmp;*.gif|" +
                "jpeg file(*.jpg)|*.jpg|" +
                "png file(*.png)|*.png|" +
                "gif file(*.gif)|*.gif|" +
                "bitmap file(*.bmp)|*.bmp";
            if(sf.ShowDialog() == DialogResult.OK)
            {
                if (sf.FileName.ToLower().EndsWith(".jpg"))
                    img.Save(sf.FileName,ImageFormat.Jpeg);
                else if (sf.FileName.ToLower().EndsWith(".png"))
                    img.Save(sf.FileName, ImageFormat.Png);
                else if(sf.FileName.ToLower().EndsWith(".bmp"))
                    img.Save(sf.FileName, ImageFormat.Bmp);
                else if (sf.FileName.ToLower().EndsWith(".gif"))
                    img.Save(sf.FileName, ImageFormat.Gif);
            }
        }
    }
}
