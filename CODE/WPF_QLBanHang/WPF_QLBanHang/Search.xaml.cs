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
using WPF_QLBanHang.Models;

namespace WPF_QLBanHang
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        string MaLoai = "";
        QLBanHangContext db = new QLBanHangContext();
        public Search()
        {
            InitializeComponent();
        }
        public Search(string maloai)
        {
            this.MaLoai = maloai;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = db.SanPhams.Where(x => x.MaLoai.Equals(MaLoai)).Select(x => new { x.MaSp, x.TenSp, x.MaLoai, x.SoLuong, DonGia = String.Format(new CultureInfo("vi-VN"), "{0:#,##0}", x.DonGia), ThanhTien = String.Format(new CultureInfo("vi-VN"), "{0:#,##0}", x.DonGia * x.SoLuong)});
            if(query.ToList().Count > 0)
            {
                MessageBox.Show("Tìm thành công các sản phẩm thuộc loại " + MaLoai, "Thông báo");
                dgv_DS.ItemsSource = query.ToList();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm thuộc loại " + MaLoai, "Thông báo");
                this.Close();
            }
        }
    }
}
