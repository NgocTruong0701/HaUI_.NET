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
using WPF_QLBanHang.Models;
using System.Reflection; // Thu vien dung khi chon dong
using System.Text.RegularExpressions; // Thu vien dung khi check du lieu
using System.Globalization;

namespace WPF_QLBanHang
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

        // Tao 1 doi tuong tu lop Context cua model de ta co the thao tac tren du lieu thong qua do
        QLBanHangContext db = new QLBanHangContext();

        // Ham load data cua database len datagrid
        private void HienThiDL()
        {
            // Dung truy van LINQ
            var query = db.SanPhams.OrderBy(x => x.DonGia).Select(x => new { x.MaSp, x.TenSp, x.MaLoai, x.SoLuong, DonGia = String.Format(new CultureInfo("vi-VN"), "{0:#,##0}", x.DonGia), ThanhTien = String.Format(new CultureInfo("vi-VN"), "{0:###,###,##0}", x.DonGia * x.SoLuong) });
            // Hien thi len datagrid
            dgv_DS.ItemsSource = query.ToList();
        }

        // Ham load data cua bang loai san pham len combobox
        private void HienThiCB()
        {
            // Dung truy van LINQ
            var query = db.LoaiSanPhams.Select(x => x);

            // Dua du lieu vao cbo
            cbo_LoaiSP.ItemsSource = query.ToList();
            // Chi hien thi moi ten loai len cbo
            cbo_LoaiSP.DisplayMemberPath = "TenLoai";
            // Dung ma loai de cap nhat
            cbo_LoaiSP.SelectedValuePath = "MaLoai";
            // Hien item thu nhat
            cbo_LoaiSP.SelectedIndex = 0;
        }

        // Khi load window
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HienThiDL();
            HienThiCB();
        }

        // Even when press turn btn ADD
        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            var query = db.SanPhams.SingleOrDefault(x => x.MaSp.Equals(txt_MaSP.Text));
            if (query != null)
            {
                MessageBox.Show("Đã tồn tại mã sản phẩm này", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                HienThiDL();
            }
            else
            {
                try
                {
                    if (CheckDL())
                    {
                        SanPham sp = new SanPham();
                        sp.MaSp = txt_MaSP.Text;
                        sp.TenSp = txt_TenSP.Text;

                        LoaiSanPham itemSelected = (LoaiSanPham)cbo_LoaiSP.SelectedItem;
                        sp.MaLoai = itemSelected.MaLoai;

                        sp.SoLuong = int.Parse(txt_SoLuong.Text);
                        sp.DonGia = decimal.Parse(txt_DonGia.Text);

                        db.SanPhams.Add(sp);
                        // Luu su thay doi
                        db.SaveChanges();
                        // Message
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        // Hien thi lai datagrid
                        HienThiDL();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi thêm " + ex.Message, "Thông báo");
                }
            }
        }

        private void btn_Change_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(CheckDL())
                {
                    var spSua = db.SanPhams.SingleOrDefault(x => x.MaSp.Equals(txt_MaSP.Text));
                    if (spSua != null)
                    {
                        spSua.TenSp = txt_TenSP.Text;

                        LoaiSanPham itemSelected = (LoaiSanPham)cbo_LoaiSP.SelectedItem;
                        spSua.MaLoai = itemSelected.MaLoai;

                        spSua.SoLuong = int.Parse(txt_SoLuong.Text);
                        spSua.DonGia = decimal.Parse(txt_DonGia.Text);

                        // Luu su thay doi nay
                        db.SaveChanges();
                        // Thong baoi
                        MessageBox.Show("Sửa thành công", "Thông báo");
                        // Hien thi lai
                        HienThiDL();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm này đẻ sửa", "Thông báo");
                        HienThiDL();
                    }
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi khi sửa " + ex.Message, "Thông báo");
            }
        }

        private void btn_Remove_Click(object sender, RoutedEventArgs e)
        {
            var query = db.SanPhams.SingleOrDefault(x => x.MaSp.Equals(txt_MaSP.Text));
            if (query != null)
            {
                MessageBoxResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if(rs == MessageBoxResult.Yes)
                {
                    db.SanPhams.Remove(query);
                    // Luu su thay doi
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    HienThiDL();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm để xóa");
            }
        }

        private void btn_Search_Click(object sender, RoutedEventArgs e)
        {
            LoaiSanPham itemSelected = (LoaiSanPham)cbo_LoaiSP.SelectedItem;
            Search window = new Search(itemSelected.MaLoai);
            window.Show();
        }

        private void btn_Statistical_Click(object sender, RoutedEventArgs e)
        {
            Statistical window = new Statistical();
            window.Show();
        }

        // Ham check du lieu dau vao
        private bool CheckDL()
        {
            string tb = "";
            if (txt_MaSP.Text == "")
                tb += "Vui lòng nhập mã sản phẩm \n";
            if (txt_TenSP.Text == "")
                tb += "Vui lòng nhập tên sản phẩm \n";
            if (txt_SoLuong.Text == "")
                tb += "Vui lòng nhập số lượng \n";
            else
            {
                if (!Regex.IsMatch(txt_SoLuong.Text, @"\d+"))
                    tb += "Số lượng nhập phải là số \n";
                else
                {
                    if (int.Parse(txt_SoLuong.Text) < 0)
                        tb += "Số lượng nhập phải là số dương \n";
                }
            }

            if (txt_DonGia.Text == "")
                tb += "Vui lòng nhập đơn giá \n";
            else
            {
                if (!Regex.IsMatch(txt_DonGia.Text, @"\d+"))
                    tb += "Đơn giá nhập phải là số\n";
                else
                {
                    if (decimal.Parse(txt_DonGia.Text) < 0)
                        tb += "Đơn giá nhập phải là số dương \n";
                }
            }

            if(tb != "")
            {
                MessageBox.Show(tb, "Thông báo");
                return false;
            }
            return true;
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
                    cbo_LoaiSP.SelectedValue = p[2].GetValue(dgv_DS.SelectedValue).ToString();
                    txt_SoLuong.Text = p[3].GetValue(dgv_DS.SelectedValue).ToString();
                    txt_DonGia.Text = p[4].GetValue(dgv_DS.SelectedValue).ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Có lỗi khi chọn dòng " + ex.Message, "Thông báo");
                }
            }
        }
    }
}
