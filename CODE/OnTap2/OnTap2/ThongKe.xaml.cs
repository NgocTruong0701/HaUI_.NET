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
    /// Interaction logic for ThongKe.xaml
    /// </summary>
    public partial class ThongKe : Window
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        // Tao 1 doi tuong thuoc lop context o Models de ta co the thao tac voi du lieu thong qua doi tuong do
        QLNhanvienContext db = new QLNhanvienContext();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // 1 bien chua list danh sach so luong nhan vien va tong luong tung phong, dung LINQ de group by into 
            var query1 = from emp in db.Nhanviens
                         group emp by emp.MaPhong into Rom
                         select new
                         {
                             MaPhong = Rom.Key,
                             CountEmp = Rom.Count(),
                             SumSalary = Rom.Sum(t => t.Luong + t.Thuong)
                         };
            // 1 bien chua ket noi cua phong ban va bang vua group vua roi
            var query2 = from emp in query1
                         join rom in db.PhongBans on emp.MaPhong equals rom.MaPhong
                         select new
                         {
                             rom.MaPhong,
                             rom.TenPhong,
                             emp.CountEmp,
                             emp.SumSalary
                         };

            // Hien thi len datarid
            MessageBox.Show("Thống kê thành công", "Thông báo",MessageBoxButton.OK,MessageBoxImage.Information);

            dgv_DS.ItemsSource = query2.ToList();
        }
    }
}
