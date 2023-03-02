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
using WPF_OnTap1.Models;// Dung thu vien models
using System.Reflection; // Dung khi chon dong
using System.Text.RegularExpressions; // Dung khi check du lieu vao

namespace WPF_OnTap1
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

        // Tao 1 doi tuong Context thuoc models de ta co the thao tac tu do
        QuanLyBenhNhanDBContext db = new QuanLyBenhNhanDBContext();

        // Tao 1 ham hien thi du lieu len DataGrid khi load form
        private void HienThiDL()
        {
            // Dung LINQ de truy van Database
            var query = db.BenhNhans.OrderByDescending(x => x.SoNgayNamVien).Select(x => new { x.MaBn, x.HoTen, x.MaKhoa, x.SoNgayNamVien, VienPhi = x.SoNgayNamVien * 200000 });
            // Hien thi len DataGrid
            dgv_DS.ItemsSource = query.ToList();
        }

        // Tao 1 ham hien thi du lieu len ComboBox khi load Form
        private void HienThiCB()
        {
            // Dung LINQ truy van Database o bang khoa kham
            var query = db.Khoas.Select(x => x);

            // Hien thi du lieu len combobox
            cbo_Khoa.ItemsSource = query.ToList();
            // Chi hien thi ma khoa (co su nham lan ten bien nhung k anh huong)
            cbo_Khoa.DisplayMemberPath = "BenhNhan";
            // Gia tri chon la Ma khoa
            cbo_Khoa.SelectedValuePath = "MaKhoa";
            // Hien thi gia tri dau tien khi load
            cbo_Khoa.SelectedIndex = 0;
        }

        // Su kien load form, ta goi 2 function tren de dua du lieu ra man hinh khi chay chuong trinh
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HienThiDL();
            HienThiCB();
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CheckDL())
                {
                    // Dung LINQ truy van database xem ton tai ma benh nhan do chua
                    var query = db.BenhNhans.SingleOrDefault(x => x.MaBn.Equals(int.Parse(txt_MaBN.Text)));
                    // Neu ton tai thi thong bao : them
                    if (query != null)
                    {
                        MessageBox.Show("Đã tồn tại mã bệnh nhân này, không thêm thêm", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        HienThiDL();
                    }
                    else
                    {
                        // Kiem tra so ngay nam vien hop le ?
                        if (int.Parse(txt_SoNgayNV.Text) >= 1)
                        {
                            BenhNhan bnNew = new BenhNhan();
                            bnNew.MaBn = int.Parse(txt_MaBN.Text);
                            bnNew.HoTen = txt_HoTen.Text;
                            bnNew.SoNgayNamVien = int.Parse(txt_SoNgayNV.Text);

                            // Do cbo chua du lieu cua ca 1 doi tuong thuoc lop Khoa vi vay muon chi lay ra MaKhoa thi phai lay doi tuong do ra roi lay Ma Khoa
                            Khoa itemSelected = (Khoa)cbo_Khoa.SelectedItem;
                            bnNew.MaKhoa = itemSelected.MaKhoa;

                            // Them vao 
                            db.BenhNhans.Add(bnNew);
                            // Luu su thay doi
                            db.SaveChanges();
                            // Thong bao
                            MessageBox.Show("Thêm thành công bệnh nhân", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                            // Hien thi lai du lieu
                            HienThiDL();
                        }
                        else
                        {
                            MessageBox.Show("Số ngày nằm viện phải lớn hơn hoặc bằng 1", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Hand);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi khi thêm: " + ex.Message, "Thông báo");
            }
        }

        // Event khi chon 1 dong trong datagrid
        private void dgv_DS_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgv_DS.SelectedItem != null)
            {
                try
                {
                    Type t = dgv_DS.SelectedItem.GetType();
                    PropertyInfo[] p = t.GetProperties();

                    txt_MaBN.Text = p[0].GetValue(dgv_DS.SelectedValue).ToString();
                    txt_HoTen.Text = p[1].GetValue(dgv_DS.SelectedValue).ToString();
                    cbo_Khoa.SelectedValue = p[2].GetValue(dgv_DS.SelectedValue).ToString();
                    txt_SoNgayNV.Text = p[3].GetValue(dgv_DS.SelectedValue).ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi khi chọn dòng: " + ex.Message, "Thông báo");
                }
            }
        }

        private void btn_Search_Click(object sender, RoutedEventArgs e)
        {
            Khoa itemSelected = (Khoa)cbo_Khoa.SelectedItem;
            Search window = new Search(itemSelected.MaKhoa);
            window.Show();
        }

        // Tao 1 ham check du lieu de bo sung cho y them
        private bool CheckDL()
        {
            string mess = "";
            if (txt_MaBN.Text == "")
            {
                mess += "Vui lòng nhập mã bệnh nhân \n";
            }
            else
            {
                if (!Regex.IsMatch(txt_MaBN.Text, @"\d+"))
                    mess += "Mã bệnh nhân phải là số \n";
                else
                {
                    if (int.Parse(txt_MaBN.Text) < 0)
                        mess += "Mã bệnh nhân không hợp lệ \n";
                }
            }
            
                
            if (txt_HoTen.Text == "")
                mess += "Vui lòng nhập họ tên \n";

            if (txt_SoNgayNV.Text == "")
                mess += "Vui lòng nhập số ngày nằm viện \n";
            else
            {
                if (!Regex.IsMatch(txt_SoNgayNV.Text, @"\d+"))
                    mess += "Số ngày nhập viện phải là số \n";
            }

            if(mess != "")
            {
                MessageBox.Show(mess, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
            return true;
        }
    }
}
