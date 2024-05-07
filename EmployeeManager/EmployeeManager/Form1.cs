using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void reset()
        {
            txtName.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtName.Select();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Trim().Length == 0 || txtAge.Text.Trim().Length == 0 || txtAddress.Text.Trim().Length == 0) {
                 MessageBox.Show("Vui lòng nhập đầy đủ thông tin","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                ListViewItem list = new ListViewItem(txtName.Text);
                list.SubItems.Add(txtAge.Text);
                list.SubItems.Add(txtAddress.Text);
                listView.Items.Add(list);
                reset();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reset();
        }


        void saveBinaryFile(String fileName)
        {
            try
            {
                ListViewItem[] items = new ListViewItem[listView.Items.Count];
                listView.Items.CopyTo(items, 0);
                using(FileStream f = File.Create(fileName))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(f, items);
                }
            }
            catch { 
                
            }
        }

        void loadBinaryFile(String fileName)
        {
            try
            {
                ListViewItem[] items = null;
                using (FileStream f = File.OpenRead(fileName)) { 
                    BinaryFormatter bf = new BinaryFormatter();
                    items = (ListViewItem[])bf.Deserialize(f);
                }
                listView.Items.Clear();
                listView.Items.AddRange(items);
            }
            catch
            {

            }
        }

        private void saveItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Empl File (*.empl)|*.empl";
            if(dlg.ShowDialog()==DialogResult.OK) {
                saveBinaryFile(dlg.FileName);
            }
        }
        private void openItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Empl File (*.empl)|*.empl";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                loadBinaryFile(dlg.FileName);
                tabControl1.SelectedTab = tabControl1.TabPages[1];
            }
        }
    }
}
