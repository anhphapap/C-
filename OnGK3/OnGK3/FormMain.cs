using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnGK3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormWelcome formWelcome = new FormWelcome();
            formWelcome.ShowDialog();
        }

        Random random = new Random();
        int money = 1000;
        private void button1_Click(object sender, EventArgs e)
        {
            try{
                bool win = false;
                int x = int.Parse(tbCost.Text);
                if(x<=money)
                {
                    int select = -1;
                    int[] r = { 0, 0, 0 };
                    r[0] = random.Next(1, 7);
                    r[1] = random.Next(1, 7);
                    r[2] = random.Next(1, 7);
                    res1.Image = Image.FromFile("../../Resources/bc" + r[0].ToString() + ".jpg");
                    res2.Image = Image.FromFile("../../Resources/bc" + r[1].ToString() + ".jpg");
                    res3.Image = Image.FromFile("../../Resources/bc" + r[2].ToString() + ".jpg");
                    switch (cbSelect.Text)
                    {
                        case "Nai": select = 1; break;
                        case "Bầu": select = 2; break;
                        case "Gà": select = 3; break;
                        case "Cá": select = 4; break;
                        case "Cua": select = 5; break;
                        case "Tôm": select = 6; break;
                    }
                    foreach (int i in r)
                    {
                        if (i == select)
                        {
                            money += x;
                            win = true;
                        }
                    }
                    if (win == false) money -= x;
                    if (money <= 0) button1.Enabled = false;
                    lbMoney.Text = money.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn muốn đóng chương trình?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) e.Cancel = true;
        }
    }
}
