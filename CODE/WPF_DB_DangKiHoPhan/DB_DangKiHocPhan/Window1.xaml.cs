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
using DB_DangKiHocPhan.Models;

namespace DB_DangKiHocPhan
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        // Tao 1 doi tuong dai dien cho lop model 
        QLMonHocContext db = new QLMonHocContext();
        string MaKhoa = String.Empty;

        public Window1(string makhoa)
        {
            InitializeComponent();
            this.MaKhoa = makhoa;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Truy van LINQ cac row co ma khoa trung voi MaKhoa, nho join de lay ra ten khoa
            var query = from id in db.MonHocs
                        join jd in db.Khoas on id.MaKhoa equals jd.MaKhoa
                        where jd.MaKhoa == MaKhoa
                        select new
                        {
                            id.MaMon,
                            id.TenMon,
                            jd.TenKhoa,
                            id.SoTin,
                            id.DonGia,
                            TongTien = id.SoTin * id.DonGia
                        };

           if (query != null)
           {
                MessageBox.Show("Danh sách thống kê các môn thuộc khoa " + MaKhoa, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                // Hien thi len dgv
                dgv_ThongKe.ItemsSource = query.ToList();
           }
        }
    }
}
