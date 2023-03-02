using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD_ComboBox
{
    public partial class Form_ComboBox : Form
    {
        public Form_ComboBox()
        {
            InitializeComponent();
        }

        private void Form_ComboBox_Load(object sender, EventArgs e)
        {
            // Thêm các giá trị cho các thuộc tính Items của các cboGioitinh và cboPhongban
            cboGioitinh.Items.Add("Nam");
            cboGioitinh.Items.Add("Nữ");

            cboPhongban.Items.Add("Phòng tài chính");
            cboPhongban.Items.Add("Phòng hành chính");
            cboPhongban.Items.Add("Phòng kinh doanh");
            cboPhongban.Items.Add("Phòng kỹ thuật");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string employee = txtHoten.Text + " | " + cboGioitinh.Text + " | " + cboPhongban.Text;
            lstDanhsach.Items.Add(employee);
            txtHoten.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
