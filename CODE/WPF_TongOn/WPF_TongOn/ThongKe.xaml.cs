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
using WPF_TongOn.Models;

namespace WPF_TongOn
{
    /// <summary>
    /// Interaction logic for ThongKe.xaml
    /// </summary>
    public partial class ThongKe : Window
    {
        string MaLoai = "";
        public ThongKe()
        {
            InitializeComponent();
        }

        public ThongKe(string MaLoai)
        {
            InitializeComponent();
            this.MaLoai = MaLoai;
        }


        // Tao doi tuong dai dien cua database (lop context thuoc models)
        QLBanHangContext db = new QLBanHangContext();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from i in db.SanPhams
                        join k in db.LoaiSanPhams
                        on i.MaLoai equals k.MaLoai
                        where k.MaLoai == MaLoai
                        select new { i.MaSp, i.TenSp, k.TenLoai, i.SoLuong, i.DonGia, ThanhTien = i.DonGia * i.SoLuong };
            dgv_ThongKe.ItemsSource = query.ToList();
        }

        private void btn_Return_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult rs = MessageBox.Show("Bạn có thật sự muốn thoát", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (rs == MessageBoxResult.Yes)
                this.Close();
        }
    }
}
