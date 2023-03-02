using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_2_Label_Button_TextBox
{
    public partial class Label_Button_TextBox : Form
    {
        public Label_Button_TextBox()
        {
            InitializeComponent();
        }

        // tuong tu o textbox thu 2


        private void btn_cong_Click_1(object sender, EventArgs e)
        {
            int one = int.Parse(txt_so1.Text);
            int two = int.Parse(txt_so2.Text);
            txt_kq.Text = (one + two).ToString();
        }

        private void txt_so1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;// khong cho phep ghi vao text
        }

        private void txt_so2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (/*chu y dau !*/!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            // neu nguoi dung an cac so k phai la
            // so hoac dau cach thi khong su ly
            {
                e.Handled = true;//true để bỏ qua việc xử lý mặc định của điều khiển;
                                 //nếu không, false để chuyển sự kiện cùng với trình xử lý điều khiển mặc định.
            }
            /*Thuộc tính .Handled được sử dụng để thông báo cho các lớp cơ sở rằng sự kiện đã được xử lý hay chưa
             * hoặc liệu chúng có cần giải quyết nó hay không. Nó không thông báo rằng một lần nhấn phím đã 
             * được xử lý giữa việc nhấn phím xuống / nhấn phím và nhấn phím. Nó cũng hoạt động với các biểu 
             * mẫu có bật KeyPreview, nhưng chỉ từ ngữ cảnh của các sự kiện Form.KeyPress. 
             * Nếu bạn có sự kiện Form.KeyPress đặt .Handled, sự kiện của điều khiển sẽ bị bỏ qua. 
             * Sự cho đi ở đó là các sự kiện KeyDown giao dịch với KeyEventArgs trong đó các sự kiện KeyPress 
             * giao dịch với KeyPressEventArgs.

            .SuppressKeyPress có lẽ đã được thêm vào chỉ vì lý do này, 
            vì vậy các sự kiện KeyDown có thể ghi đè các sự kiện KeyPress.
            e.SuppressKeyPress = !(e.KeyValue >= 48 && e.KeyValue <= 57);
            */
        }

        private void btn_tru_Click(object sender, EventArgs e)
        {
            int one = int.Parse(txt_so1.Text);
            int two = int.Parse(txt_so2.Text);
            txt_kq.Text = (one - two).ToString();
        }

        private void btn_nhan_Click(object sender, EventArgs e)
        {
            int one = int.Parse(txt_so1.Text);
            int two = int.Parse(txt_so2.Text);
            txt_kq.Text = (one * two).ToString();
        }

        private void btn_chia_Click(object sender, EventArgs e)
        {
            try
            {
                int one = int.Parse(txt_so1.Text);
                int two = int.Parse(txt_so2.Text);
                double result = (double)one / two;
                txt_kq.Text = result.ToString();
            }
            catch(DivideByZeroException loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            foreach(var i in grp_Maytinh.Controls)
            {
                TextBox i1 = i as TextBox;
                if (i1 != null)
                    i1.Clear();
            }

        }
    }
}
