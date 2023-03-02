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
using CapNhatThuoc.Models;

namespace CapNhatThuoc
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
        string LoaiThuoc = "";
        QLTHUOCContext sp = new QLTHUOCContext();
        public Window1(string LoaiThuoc)
        {
            InitializeComponent();
            this.LoaiThuoc = LoaiThuoc;
        }

        private void thongke_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from id in sp.LoaiThuocs
                        join jd in sp.Thuocs
                        on id.MaLoai equals jd.MaLoai
                        where jd.MaLoai == LoaiThuoc
                        select new { jd.MaThuoc, jd.TenThuoc, id.TenLoai, jd.SoLuong, jd.DonGia, ThanhTien = jd.SoLuong * jd.DonGia };
            if(query != null)
            {
                MessageBox.Show("Thống kê thành công thuốc thuộc loại " + LoaiThuoc, "Thông báo");
                dtthuoc.ItemsSource = query.ToList();
            }
            else
            {
                MessageBox.Show("Không có thuốc thuộc loại " + LoaiThuoc, "Thông báo");
            }    
        }
    }
}
