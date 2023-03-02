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
    /// Interaction logic for Statistical.xaml
    /// </summary>
    public partial class Statistical : Window
    {
        public Statistical()
        {
            InitializeComponent();
        }

        // 1 doi tuong lop context 
        QLBanHangContext db = new QLBanHangContext();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query1 = from id in db.SanPhams
                         group id by id.MaLoai into grLoai
                         select new
                         {
                             MaLoai = grLoai.Key,
                             SoLuongSP = grLoai.Count(),
                             TongTien = grLoai.Sum(x => x.SoLuong * x.DonGia)
                         };

            var query2 = from id in query1
                         join jd in db.LoaiSanPhams on id.MaLoai equals jd.MaLoai
                         select new
                         {
                             jd.MaLoai,
                             jd.TenLoai,
                             id.SoLuongSP,
                             TongTien = String.Format(new CultureInfo("vi-VN"), "{0:#,##0}", id.TongTien)
                         };

            dgv_DS.ItemsSource = query2.ToList();
        }
    }
}
