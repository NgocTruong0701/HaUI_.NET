using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_Hoten.Text) || String.IsNullOrEmpty(cbo_Phongban.Text) || (rdbtn_Nam.Checked == false 
                && rdbtn_Nu.Checked == false) || String.IsNullOrWhiteSpace(txt_Slb.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo");
            }
            else
            {
                ListViewItem item = new ListViewItem();
                item.Text = txt_Hoten.Text;
                lst_DSNV.Items.Add(item);

                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem();
                subItem.Text = cbo_Phongban.Text;
                item.SubItems.Add(subItem);

                ListViewItem.ListViewSubItem subItem1 = new ListViewItem.ListViewSubItem();
                subItem1.Text = dateNgayTD.Text;
                item.SubItems.Add(subItem1);

                ListViewItem.ListViewSubItem subItem2 = new ListViewItem.ListViewSubItem();
                if (rdbtn_Nam.Checked)
                    subItem2.Text = rdbtn_Nam.Text;
                else
                    subItem2.Text = rdbtn_Nu.Text;
                item.SubItems.Add(subItem2);

                int slb = int.Parse(txt_Slb.Text);
                if (slb < 0)
                    MessageBox.Show("Số lượng bán không hợp lệ", "Thông báo");
                else
                {
                    ListViewItem.ListViewSubItem subItem3 = new ListViewItem.ListViewSubItem();
                    subItem3.Text = txt_Slb.Text;
                    item.SubItems.Add(subItem3);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbo_Phongban.Items.Add("Nhân sự");
            cbo_Phongban.Items.Add("Marketing");
            cbo_Phongban.Items.Add("Digital");
            cbo_Phongban.Items.Add("Accountant");
            cbo_Phongban.Items.Add("Human resource");
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            lst_DSNV.Items.RemoveAt(lst_DSNV.Items.Count - 1);
        }

        private void btn_Form2_Click(object sender, EventArgs e)
        {
            Window_2 frm = new Window_2();
            frm.ShowDialog();
        }
    }
}
