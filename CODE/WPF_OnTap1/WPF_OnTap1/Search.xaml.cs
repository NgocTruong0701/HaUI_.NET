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
using WPF_OnTap1.Models;

namespace WPF_OnTap1
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        int MaKhoa = 0;
        QuanLyBenhNhanDBContext db = new QuanLyBenhNhanDBContext();
        public Search()
        {
            InitializeComponent();
        }
        public Search(int makhoa)
        {
            this.MaKhoa = makhoa;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = db.BenhNhans.Where(x => x.MaKhoa.Equals(MaKhoa)).Select(x => new { x.MaBn, x.HoTen, x.MaKhoa, x.SoNgayNamVien, VienPhi = x.SoNgayNamVien * 200000 });
            if(query.ToList().Count > 0)
            {
                MessageBox.Show("Tìm thành công các bệnh nhân thuộc khoa " + MaKhoa, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                dgv_DS.ItemsSource = query.ToList();
            }
            else
            {
                MessageBox.Show("Không tìm thấy bệnh nhân nào thuộc khoa " + MaKhoa, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                this.Close();
            }
        }
    }
}
