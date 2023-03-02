using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolTip_HelpProvider__ErrorProvider
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_DN_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_TenDN.Text) || String.IsNullOrWhiteSpace(txt_MK.Text))
                MessageBox.Show("Vui lòng điền đủ thông tin.", "Thông báo");
            else
                MessageBox.Show("Đăng nhập thành công.", "Thông báo");
        }

        private void btn_Exist_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
                Application.Exit();
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            toolTip.SetToolTip(txt_TenDN, "Chỉ được nhập ký tự a-z và 0-9");
            toolTip.SetToolTip(txt_MK, "Chỉ được nhập ký tự 0-9");
            helpProvider1.HelpNamespace = "https://facebook.com";
        }

        private void txt_MK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void chk_ShowMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ShowMK.Checked == true)
                txt_MK.PasswordChar = (char)0;
            else
                txt_MK.PasswordChar = '*';
        }

    }
}      