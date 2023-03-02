using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using OnTap2.Models;

namespace OnTap2
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        // 1 bien chua du lieu ma phong de ta co the truy van
        string romId = "";
        // 1 bien thuoc lop context cua model de ta co the truy van du lieu
        QLNhanvienContext db = new QLNhanvienContext();
        public Search()
        {
            InitializeComponent();
        }

        // Phuong thuc khoi tao 1 doi so
        public Search(string romid)
        {
            this.romId = romid;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // LINQ de lay du lieu thoi
            var query = db.Nhanviens.Where(x => x.MaPhong.Equals(romId)).Select(x => new { x.MaPhong, x.MaNv, x.Hoten, x.Luong, x.Thuong, TongTien = x.Luong + x.Thuong });

            // Thong bao tim 
            if(query.ToList().Count > 0)
            {
                MessageBox.Show("Tìm thành công các nhân viên thuộc phòng ban có mã phòng " + romId, "Thông báo");
                dgv_DS.ItemsSource = query.ToList();
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên nào thuộc phòng ban có mã phòng " + romId, "Thông báo");
                this.Close();
            }
        }
    }
}
