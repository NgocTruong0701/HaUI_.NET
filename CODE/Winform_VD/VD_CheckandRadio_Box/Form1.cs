using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD_CheckandRadio_Box
{
    public partial class frm_check_radio : Form
    {
        public frm_check_radio()
        {
            InitializeComponent();
        }

        private void btn_favorite_action_Click(object sender, EventArgs e)
        {
            string result = "";
            foreach(var chk in grp_favorite_action.Controls)
            {
                CheckBox chk1 = chk as CheckBox;
                if (chk1.Checked == true)
                    result += chk1.Text + "\n";
            }

            MessageBox.Show("Sở thích của bạn là: \n" + result);
        }

        private void btn_favorite_color_Click(object sender, EventArgs e)
        {
            foreach(var rdo in grp_favorite_color.Controls)
            {
                RadioButton rdo1 = rdo as RadioButton;
                if (rdo1.Checked == true)
                {
                    MessageBox.Show("Màu yêu thích của bạn là: \n" + rdo1.Text);
                    return;
                }
            }    
        }
    }
}
