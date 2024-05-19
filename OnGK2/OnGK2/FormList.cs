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
    public partial class FormList : Form
    {
        public FormList()
        {
            InitializeComponent();
        }

        private void FormList_Load(object sender, EventArgs e)
        {
            string[] ts = { "Truyện Kiều", "Ngọc trong đá", "Yêu như là sống", "Tôi thấy hoa vàng trên cỏ xanh" };
            string[] tg = { "Nguyễn Du", "Nguyễn Đông Thúc", "Nguyễn Mạnh Tuấn", "Nguyễn Nhật Ánh" };
            for(int i = 0; i<ts.Length; i++)
            {
                ListViewItem listItem = new ListViewItem(ts[i]);
                listItem.SubItems.Add(tg[i]);
                listItem.ImageIndex = 0;
                listView1.Items.Add(listItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t1 = tbTenSach.Text.Trim();
            string t2 = tbTenTG.Text.Trim();
            if (t1 != "" && t2 != "")
            {
                ListViewItem listItem = new ListViewItem(t1);
                listItem.SubItems.Add(t2);
                listItem.ImageIndex = 0;
                listView1.Items.Add(listItem);
                tbTenSach.Text = "";
                tbTenTG.Text = "";
                tbTenSach.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var x in listView1.SelectedItems) listView1.Items.Remove((ListViewItem)x);
        }
    }
}
