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
using OnTap3.Models;
using System.Reflection; // Thu vien dung khi chon dong
using System.Text.RegularExpressions; // Thu vien dung khi check du lieu
using System.Globalization;

namespace OnTap3
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

        // Tao 1 doi tuong thuoc lop Context cua model de ta co the thao tao qua do
        QuanLySanPhamDBContext db = new QuanLySanPhamDBContext();

        // 1 ham de hien thi du lieu o database len datagrid
        private void HienThiDL()
        {
            // Dung LINQ truy van database
            var query = db.SanPhams.OrderByDescending(x => x.SoLuongBan).Select(x => new { x.MaSp, x.TenSanPham, x.DonGia, x.SoLuongBan, x.MaNhomHang, TienBan = String.Format(new CultureInfo("vi-VN"), "{0:#,##0}", x.SoLuongBan * x.DonGia) });
            // Hien thi len datagrid
            dgv_DS.ItemsSource = query.ToList();
        }

        // 1 ham de hien thi du lieu o database nhom hang len ComboBox
        private void HienThiCB()
        {
            var query = db.NhomHangs.Select(x => x);
            // Hien thi len cbo
            cbo_NhomSP.ItemsSource = query.ToList();
            // Chi hien thi ten nhom hang
            cbo_NhomSP.DisplayMemberPath = "TenNhomHang";
            // Gia tri lua chon la ma nhom hang
            cbo_NhomSP.SelectedValuePath = "MaNhomHang";
            // Chon item dau tien
            cbo_NhomSP.SelectedIndex = 0;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HienThiDL();
            HienThiCB();
        }

        // 1 ham check du lieu
        private bool CheckDL()
        {
            string tb = "";
            if (txt_MaSP.Text == "")
                tb += "Vui lòng nhập mã sản phẩm\n";
            else
            {
                if (!Regex.IsMatch(txt_MaSP.Text, @"\d+"))
                    tb += "Vui lòng nhập đúng kiểu dữ liệu là số\n";
            }

            if (txt_TenSP.Text == "")
                tb += "Vui lòng nhập tên sản phẩm \n";

            if (txt_DonGia.Text == "")
                tb += "Vui lòng nhập đơn giá \n";
            else
            {
                if (!Regex.IsMatch(txt_DonGia.Text, @"\d+"))
                    tb += "Đơn giá nhập phải là số \n";
            }

            if (txt_SoLuong.Text == "")
                tb += "Vui lòng nhập số lượng sản phẩm \n";
            else
            {
                if (!Regex.IsMatch(txt_SoLuong.Text, @"\d+"))
                    tb += "Số lượng nhập phải là số \n";
                else
                {
                    double sl = double.Parse(txt_SoLuong.Text);
                    if (sl < 1)
                        tb += "Số lượng phải lớn hơn hoặc bằng 1";
                }
            }

            if(tb != "")
            {
                MessageBox.Show(tb, "Thông báo");
                return false;
            }

            return true;
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(CheckDL())
                {
                    var query = db.SanPhams.SingleOrDefault(x => x.MaSp.Equals(int.Parse(txt_MaSP.Text)));
                    if (query != null)
                    {
                        MessageBox.Show("Đã tồn tại mã sản phẩm này", "Thông báo");
                        HienThiDL();
                    }
                    else
                    {
                        SanPham spNew = new SanPham();
                        spNew.MaSp = int.Parse(txt_MaSP.Text);
                        spNew.TenSanPham = txt_TenSP.Text;
                        spNew.DonGia = double.Parse(txt_DonGia.Text);
                        spNew.SoLuongBan = double.Parse(txt_SoLuong.Text);

                        NhomHang itemSelected = (NhomHang)cbo_NhomSP.SelectedItem;
                        spNew.MaNhomHang = itemSelected.MaNhomHang;

                        // Add vao database
                        db.SanPhams.Add(spNew);
                        // Save Changes
                        db.SaveChanges();
                        // Message complate Add
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                        // Show on DataGrid
                        HienThiDL();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi khi thêm " + ex.Message, "Thông báo");
                HienThiDL();
            }
        }

        private void dgv_DS_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(dgv_DS.SelectedItem != null)
            {
                try
                {
                    Type t = dgv_DS.SelectedItem.GetType();
                    PropertyInfo[] p = t.GetProperties();

                    txt_MaSP.Text = p[0].GetValue(dgv_DS.SelectedValue).ToString();
                    txt_TenSP.Text = p[1].GetValue(dgv_DS.SelectedValue).ToString();
                    txt_DonGia.Text = p[2].GetValue(dgv_DS.SelectedValue).ToString();
                    txt_SoLuong.Text = p[3].GetValue(dgv_DS.SelectedValue).ToString();
                    cbo_NhomSP.SelectedValue = p[4].GetValue(dgv_DS.SelectedValue).ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Có lỗi khi chọn dòng " + ex.Message, "Thông báo");
                }
            }
        }

        private void btn_Search_Click(object sender, RoutedEventArgs e)
        {
            Search window = new Search();
            window.Show();
        }
    }
}
