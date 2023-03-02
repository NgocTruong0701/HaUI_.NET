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
using WPF_QuanLyMonHoc.Models;

namespace WPF_QuanLyMonHoc
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

        QLMonHocContext db = new QLMonHocContext();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = db.MonHocs.Where(x => x.MaKhoa.Equals("K002")).Select(x => new { x.MaMon, x.TenMon, x.MaKhoa, x.SoTin, DonGia = String.Format(new CultureInfo("vi-VN"), "{0:#,##0}", x.DonGia), ThanhTien = String.Format(new CultureInfo("vi-VN"), "{0:#,##0}", x.DonGia * x.SoTin) });
            dgv_DS.ItemsSource = query.ToList();
        }
    }
}
