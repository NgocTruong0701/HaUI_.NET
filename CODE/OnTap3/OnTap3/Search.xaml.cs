using System;
using System.Collections.Generic;
using System.Globalization;
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
using OnTap3.Models;

namespace OnTap3
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        public Search()
        {
            InitializeComponent();
        }

        QuanLySanPhamDBContext db = new QuanLySanPhamDBContext();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = db.SanPhams.Where(x => x.MaNhomHang.Equals(1)).Select(x => new { x.MaSp, x.TenSanPham, x.DonGia, x.SoLuongBan, x.MaNhomHang, TienBan = String.Format(new CultureInfo("vi-VN"), "{0:#,##0}", x.DonGia * x.SoLuongBan)});
            if(query.ToList().Count > 0)
            {
                MessageBox.Show("Tìm thành công các sản phẩm thuộc nhóm hàng 1", "Thông báo");
                dgv_DS.ItemsSource = query.ToList();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm thuộc nhóm hàng 1", "Thông báo");
                this.Close();
            }
        }
    }
}
