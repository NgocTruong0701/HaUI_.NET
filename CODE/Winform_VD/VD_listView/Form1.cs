using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD_listView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_Name.Text) || String.IsNullOrWhiteSpace(txt_Number.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
            else
            {
                ListViewItem item = new ListViewItem();
                item.Text = txt_Name.Text;
                lst_DS.Items.Add(item);

                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem();
                subItem.Text = txt_Number.Text;
                item.SubItems.Add(subItem);

                txt_Name.Clear();
                txt_Number.Clear();
                txt_Name.Focus();
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if(lst_DS.Items.Count > 0)
            {
                if(lst_DS.SelectedItems != null)
                {
                    lst_DS.Items[lst_DS.Items.Count - 1].Remove();
                }
                else
                    MessageBox.Show("Không có đối tượng lựa chọn này để xóa", "Thông báo");
            }
            else
                MessageBox.Show("Không có đối tượng nào để xóa", "Thông báo");
        }

        private void btn_RemoveAll_Click(object sender, EventArgs e)
        {
            lst_DS.Clear();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
                this.Close();
        }
    }
}
