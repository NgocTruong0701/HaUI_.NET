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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_QuanLyMonHoc.Models;
using System.Reflection; // Dung khi chon dong
using System.Text.RegularExpressions;
using System.Globalization;

namespace WPF_QuanLyMonHoc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        QLMonHocContext db = new QLMonHocContext();

        private void HienThiDL()
        {
            var query = db.MonHocs.OrderBy(x => x.MaMon).Select(x => new { x.MaMon, x.TenMon, x.MaKhoa, x.SoTin, DonGia = String.Format(new CultureInfo("vi-VN"), "{0:#,##0}", x.DonGia), ThanhTien = String.Format(new CultureInfo("vi-VN"), "{0:#,##0}", x.DonGia * x.SoTin) });
            dgv_DS.ItemsSource = query.ToList();
        }

        private void HienThiCB()
        {
            var query = db.Khoas.Select(x => x);

            cbo_DSKhoa.ItemsSource = query.ToList();
            cbo_DSKhoa.DisplayMemberPath = "TenKhoa";
            cbo_DSKhoa.SelectedValuePath = "MaKhoa";
            cbo_DSKhoa.SelectedIndex = 0;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HienThiCB();
            HienThiDL();
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            var query = db.MonHocs.SingleOrDefault(x => x.MaMon.Equals(txt_MaMon.Text));
            if(query != null)
            {
                MessageBox.Show("Đã tồn tại mã môn này", "Thông báo");
                HienThiDL();
            }
            else
            {
                MonHoc monNew = new MonHoc();
                monNew.MaMon = txt_MaMon.Text;
                monNew.TenMon = txt_TenMon.Text;

                Khoa itemS = (Khoa)cbo_DSKhoa.SelectedItem;
                monNew.MaKhoa = itemS.MaKhoa;

                monNew.SoTin = int.Parse(txt_SoTin.Text);
                monNew.DonGia = decimal.Parse(txt_DonGia.Text);

                db.MonHocs.Add(monNew);
                db.SaveChanges();
                MessageBox.Show("Thêm thành công", "Thông báo");
                HienThiDL();
            }
        }

        private void btn_Changer_Click(object sender, RoutedEventArgs e)
        {
            var query = db.MonHocs.SingleOrDefault(x => x.MaMon.Equals(txt_MaMon.Text));
            if (query != null)
            {
                query.TenMon = txt_TenMon.Text;
                query.SoTin = int.Parse(txt_SoTin.Text);
                query.DonGia = decimal.Parse(txt_DonGia.Text);

                Khoa itemS = (Khoa)cbo_DSKhoa.SelectedItem;
                query.MaKhoa = itemS.MaKhoa;

                db.SaveChanges();
                MessageBox.Show("Sửa thành công", "Thông báo");
                HienThiDL();
            }
            else
            {
                MessageBox.Show("Không tìm thấy", "Thông báo");
                HienThiDL();
            }
        }

        private void btn_Remove_Click(object sender, RoutedEventArgs e)
        {
            var query = db.MonHocs.SingleOrDefault(x => x.MaMon.Equals(txt_MaMon.Text));
            if (query != null)
            {
                MessageBoxResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (rs == MessageBoxResult.Yes)
                {
                    db.MonHocs.Remove(query);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    HienThiDL();
                }
            }
            else
                MessageBox.Show("Không tìm thấy", "Thông báo");
        }

        private void btn_Search_Click(object sender, RoutedEventArgs e)
        {
            Search window = new Search();
            window.Show();
        }

        private void dgv_DS_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgv_DS.SelectedItem != null)
            {
                try
                {
                    Type t = dgv_DS.SelectedItem.GetType();
                    PropertyInfo[] p = t.GetProperties();

                    txt_MaMon.Text = p[0].GetValue(dgv_DS.SelectedValue).ToString();
                    txt_TenMon.Text = p[1].GetValue(dgv_DS.SelectedValue).ToString();
                    cbo_DSKhoa.SelectedValue = p[2].GetValue(dgv_DS.SelectedValue).ToString();
                    txt_SoTin.Text = p[3].GetValue(dgv_DS.SelectedValue).ToString();
                    txt_DonGia.Text = p[4].GetValue(dgv_DS.SelectedValue).ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Có lỗi khi chọn dòng", "Thông báo");
                }
            }
        }
    }
}
