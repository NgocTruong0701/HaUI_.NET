using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD_ListView
{
    public partial class frm_VD_ListView : Form
    {
        public frm_VD_ListView()
        {
            InitializeComponent();
        }

        int row; // bien dung de lay ra so dong trong list view

        // them 1 nguoi thong qua hanh dong click
        private void btn_Them_Click(object sender, EventArgs e)
        {
            row = lstv_Danhsach.Items.Count;// nay se gan gia tri cho row. Khi do luon add vao dong sau dc
            // do index list view bat dau tu 0 khi list view co 0 count add len thi count = 1, khi add tiep thi se
            // add vao row = 1; cu the tang dan ma k can cong row len 1;
            lstv_Danhsach.Items.Add(txt_Hoten.Text);
            lstv_Danhsach.Items[row].SubItems.Add(dt_Ngaysinh.Text);
            lstv_Danhsach.Items[row].SubItems.Add(txt_Quequan.Text);
            foreach (var i in grp_Input_Information.Controls)
            {
                TextBox i1 = i as TextBox;
                if (i1 != null)
                    i1.Clear();
            }

            dt_Ngaysinh.Value = DateTime.Now;

        }
        
        // xoa di 1 dong trong list view
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (lstv_Danhsach.Items.Count > 0)
                lstv_Danhsach.Items.RemoveAt(lstv_Danhsach.Items.Count - 1); // cau lenh se xoa di dong co index = row
            else
                MessageBox.Show("Không thể xóa khi chưa có danh sách nào!","Thông báo");
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlr == DialogResult.Yes)
                Application.Exit();
        }

        private void lstv_Danhsach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstv_Danhsach_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            row = e.ItemIndex;
            txt_Hoten.Text = lstv_Danhsach.Items[row].SubItems[0].Text;
            dt_Ngaysinh.Text = lstv_Danhsach.Items[row].SubItems[1].Text;
            txt_Quequan.Text = lstv_Danhsach.Items[row].SubItems[2].Text;
        }
    }
}
