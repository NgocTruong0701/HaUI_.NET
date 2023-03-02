using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD_listbox1
{
    public partial class Form_List_Box : Form
    {
        // Phương thức khởi tạo
        public Form_List_Box()
        {
            InitializeComponent();
        }

        // Phương thức load form
        private void Form_List_Box_Load(object sender, EventArgs e)
        {
            lst_DS.Items.Add("Nhập môn tin học");
            lst_DS.Items.Add("Tin văn phòng");
            lst_DS.Items.Add("Lập trình mạng");
            lst_DS.Items.Add("Lập trình trên Windows");
            lst_DS.Items.Add("Công nghệ thực tế ảo");
            lst_DS.Items.Add("Phân tích thiết kế hệ thống");
            lst_DS.Items.Add("Lập trình hướng đối tượng");
            lst_DS.Items.Add("Thiết kế web");
            lst_DS.Items.Add("Đảo bảo chất lượng phần mềm");
            lst_DS.Items.Add("Giải thuật di truyền và ứng dụng");
            lst_DS.Items.Add("Hệ chuyên gia");
            lst_DS.Items.Add("Lập trình căn bản");
            lst_DS.Items.Add("Một số phướng pháp tính toán mềm");
            lst_DS.Items.Add("Phân tích và thống kê số liệu");
            lst_DS.Items.Add("Thiết kế cơ sở dữ liệu");
        }

        // Sự kiện click btn chon1 
        private void btn_chon1_Click(object sender, EventArgs e)
        {
            if(lst_DS.Items.Count == 0)// nếu list sách được chọn là trống
                lst_SC.Items.Add(lst_DS.SelectedItem);
            else
            {
                int i = lst_SC.Items.IndexOf(lst_DS.SelectedItem);// kiểm tra xem sách muốn add đã tồn tại chưa
                if (i == -1)// kiểm tra đây
                    lst_SC.Items.Add(lst_DS.SelectedItem);
                else
                    MessageBox.Show("Da ton tai ten sach nay");
            }
        }


        // Sự kiện click vào btn chon het
        private void btn_chonn_Click(object sender, EventArgs e)
        { 
            if(lst_SC.Items.Count == 0)// nếu danh sach sach chon rỗng
                for (int i = 0; i < lst_DS.Items.Count; i++)// dùng hàm for để duyệt từ đầu tới cuối và add lần lượt 
                    lst_SC.Items.Add(lst_DS.Items[i]);
            else// nếu danh sách ấy không rỗng thì sao ?? thì sao thì sao 
            {
                foreach (var i in lst_SC.Items)// dùng 2 vòng duyệt 1 vòng của ds chọn 1 vòng của ds nguồn
                    foreach (var j in lst_DS.Items)// có cách nào tối ưu nữa không thì chưa nghĩ, có thể dùng indexof 
                        if (i == j)// nhưng mà hiện tại cứ dùng cachs này
                        {
                            MessageBox.Show("Đã tồn tại sách " + i.ToString()+ " hoặc một số sách khác nữa");//1 phương thức thông báo lỗi 
                            return;// thoát khỏi cái sự kiện này luôn
                        }
                for (int i = 0; i < lst_DS.Items.Count; i++)// nếu chưa có cái nào trùng thì add thôi 
                    lst_SC.Items.Add(lst_DS.Items[i]);
            }
        }

        // Sự kiện click btn chọn 1 số sách từ list nguồn
        private void button1_Click(object sender, EventArgs e)
        {
            if(lst_SC.Items.Count == 0)//vẫn kiểm tra xem list đích rỗng hay không
                foreach (var i in lst_DS.SelectedItems)
                    lst_SC.Items.Add(i);
            else
            {
                foreach (var i in lst_SC.Items)// vẫn kiểm tra sự tồn tại của sách cần thêm có ở trong list đích không
                    foreach (var j in lst_DS.SelectedItems)// khác ở hàm chọn hết là ở cái selecteditems nó sẽ đưa
                        if (i == j)// ra cái mình chọn thôi, không cần quét hết bảng như chọn thêm hết 
                        {
                            MessageBox.Show("Đã tồn tại sách " + i.ToString() + " hoặc một số sách khác nữa");
                            return;
                        }
                foreach (var i in lst_DS.SelectedItems)
                    lst_SC.Items.Add(i);
            }
        }

        // Sự kiện click btn xóa 1 
        private void btn_xoa1_Click(object sender, EventArgs e)
        {
            lst_SC.Items.Remove(lst_SC.SelectedItem);// dùng remove để xóa item được chọn
        }

        // Sự kiện click btn xóa 1 số 
        private void btn_xoan_Click(object sender, EventArgs e)
        {
            for (int i1 = 0; i1 < lst_SC.SelectedItems.Count; i1++)
            {
                object i = lst_SC.SelectedItems[i1];
                lst_SC.Items.Remove(i);
                i1--;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lst_SC.Items.Clear();
        }
    }
}
