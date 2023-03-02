using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD_CheckandGroupBox
{
    public partial class frms_Check_Group_Box : Form
    {
        public frms_Check_Group_Box()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // lay gioi tinh thong qua radiobutton. Thuoc tinh checked
            string sex = "Giới tính: ";
            if (rdo_Nam.Checked == true)
                sex += "Nam";
            if (rdo_Nu.Checked == true)
                sex += "Nữ";

            // lay tinh trang hon nhan o groupbox_TTHN. tu thuoc tinh checked cua radiobutton
            string TTHN = "Tình trạng hôn nhân: ";
            if (rdo_chua.Checked == true)
                TTHN += "chưa kết hôn";
            if (rdo_da.Checked == true)
                TTHN += "đã kết hôn";

            // lay cac so thich tu check box, dung thuoc tinh checked de kiem tra so thich ay co duoc chon k
            string like = "Sở thích: ";
            List<string> sothich = new List<string>();
            if (chk_bongda.Checked == true)
                sothich.Add("Bóng đá");
            if (chk_amnhac.Checked == true)
                sothich.Add("Âm nhạc");
            if (chk_boiloi.Checked)
                sothich.Add("Bơi lội");
            if (chk_leonui.Checked == true)
                sothich.Add("Leo núi");

            if (sothich.Count > 1)// kiem tra xem so thich co may, neu lon hon 1 thi phai them dau phay tru phan tu cuoi
            {
                for (int i = 0; i < sothich.Count - 1; i++)// doan them dau phai tu dau den tru phan tu cuoi
                    like += sothich[i] + " ,";
                like += sothich[sothich.Count - 1];// them phan tu cuoi khong co dau phay
            }
            else
            {
                like += sothich[0];// neu chi co 1 thi them luon
            }

            // Them cac values vao list danh sach
            lst_danhsach.Items.Add("Họ tên: " + txtHoTen.Text);
            lst_danhsach.Items.Add(sex);
            lst_danhsach.Items.Add(TTHN);
            lst_danhsach.Items.Add(like);
            lst_danhsach.Items.Add("-------------------------------------------------------");

            // Format lai cac gia tri 
            txtHoTen.Clear();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
