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
using DB_DangKiHocPhan.Models;// de su dung tep models
using System.Text.RegularExpressions; // dung de kiem tra du lieu
using System.Reflection; // Dung khi chon dong 

namespace DB_DangKiHocPhan
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

        // Tao 1 doi tuong dai dien cho lop QLMonHocContext de ta co the truy nhap vao cac lop con cua no
        QLMonHocContext db = new QLMonHocContext();

        // Tao 1 ham hien thi du lieu len dgv_DSDK 
        private void HienThiDL()
        {
            // su dung truy van LINQ de lay ra duoc du lieu tu database sap xep theo so tin
            var query = db.MonHocs.OrderBy(x => x.SoTin).Select(x => new { x.MaMon, x.TenMon, x.MaKhoa, x.SoTin, x.DonGia, TongTien = x.SoTin * x.DonGia });
            // Hien thi len dgv
            dgv_DSDK.ItemsSource = query.ToList();
        }

        // Tao 1 ham hien thi du lieu len cbo_Khoa do du lieu do dbo can co du lieu de truyen vao, hien thi thi ten khoa con gia tri select la ma khoa
        private void HienThiCB()
        {
            // van su dung truy van LINQ o class Khoas de lay du lieu tu database
            var query = db.Khoas.Select(x => x);

            // Dua du lieu vao cbo
            cbo_DsKhoa.ItemsSource = query.ToList();
            // Chon thuoc tinh hien thi len cbo la ten khoa
            cbo_DsKhoa.DisplayMemberPath = "TenKhoa";
            // Gia tri khi ta chon that su chon vao / hay ta that su thao tac voi thuoc tinh nao
            cbo_DsKhoa.SelectedValuePath = "MaKhoa";
            // Gia tri hien thi o cbo ban dau khi load window 
            cbo_DsKhoa.SelectedIndex = 0;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Hien thi du lieu vao dgv khi load window
            HienThiDL();

            // Hien thi du lieu vao cbo khi load window
            HienThiCB();
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            // Kiem tra xem MaMon da ton tai chua
            var MonNew = db.MonHocs.SingleOrDefault(x => x.MaMon.Equals(txt_MaMon.Text));
            if (MonNew != null) // Ton tai MaMon ay trong database r
            {
                MessageBox.Show("Đã tồn tại mã môn này rồi, không thể thêm", "Thông báo");
                HienThiDL();
            }
            else
            {
               try
                {
                    if(CheckDL()) // neu du lieu nhap hop le
                    {
                        // Tao 1 doi tuong MonHoc de co the dua du lieu tu cac textbox vao sau do add vao database, nho luu lai su thay doi nay
                        MonHoc Mon = new MonHoc();
                        Mon.MaMon = txt_MaMon.Text;
                        Mon.TenMon = txt_TenMon.Text;

                        // Rieng khoa o 1 cbo voi du lieu khac nen ta phai tao 1 doi tuong de lay duoc du lieu select o cbo. Vi o cbo k chi ma khoa ma con co ten khoa va dia chi, cai ta can chi la ma khoa
                        Khoa KhoaSelected = new Khoa();
                        KhoaSelected = (Khoa)cbo_DsKhoa.SelectedItem; // Nho ep kieu cho no
                        Mon.MaKhoa = KhoaSelected.MaKhoa;

                        // Tiep tuc nhu MaMon va TenMon, Tuy nhien so tin o trong database lai la kieu nguyen va don gia la money => decimal. Can ep du lieu
                        Mon.SoTin = int.Parse(txt_SoTC.Text);
                        Mon.DonGia = decimal.Parse(txt_DonGia.Text);

                        // Theo du lieu vao database
                        db.MonHocs.Add(Mon);
                        // Luu su thay doi
                        db.SaveChanges();
                        //Thong bao them thanh cong
                        MessageBox.Show("Đã thêm thành công", "Thông báo");
                        // Hien thi lai du lieu
                        HienThiDL();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Có lỗi khi thêm:" + ex.Message, "Thông báo");
                }
            }
        }

        private void dgv_DSDK_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Kiem tra xem co select k    
            if (dgv_DSDK.SelectedItem != null)
            {
                try
                {
                    // Lay type cua row day
                    Type t = dgv_DSDK.SelectedItem.GetType();
                    PropertyInfo[] p = t.GetProperties(); // Tao 1 mang chua tung columns(thuoc tinh) cua t
                    // sau do tin gan gia tri cho tung textbox va combobox lan luot (Bat dau tu 0 va dung getvalue, Dung ToString de chuyen ra text)
                    txt_MaMon.Text = p[0].GetValue(dgv_DSDK.SelectedValue).ToString();
                    txt_TenMon.Text = p[1].GetValue(dgv_DSDK.SelectedValue).ToString();

                    // cbo thi k dung text ma la selectvalue
                    cbo_DsKhoa.SelectedValue = p[2].GetValue(dgv_DSDK.SelectedValue).ToString();

                    // Tiep tuc
                    txt_SoTC.Text = p[3].GetValue(dgv_DSDK.SelectedValue).ToString();
                    txt_DonGia.Text = p[4].GetValue(dgv_DSDK.SelectedValue).ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Có lỗi khi chọn dòng: " + ex.Message, "Thông báo");
                }
            }

        }

        private void btn_Change_Click(object sender, RoutedEventArgs e)
        {
            // kiem tra xem MaMon co ton tai k
            var MonSua = db.MonHocs.SingleOrDefault(x => x.MaMon.Equals(txt_MaMon.Text));
            if(MonSua != null)
            {
                try
                {
                    if(CheckDL()) // Neu du lieu nhap hop le
                    {
                        MonSua.TenMon = txt_TenMon.Text;

                        // Tao 1 doi tuong Khoa de lay du lieu selectedItem o cboKhoa
                        Khoa itemSelected = new Khoa();
                        itemSelected = (Khoa)cbo_DsKhoa.SelectedItem; // Nho ep kieu no ve khoa
                        MonSua.MaKhoa = itemSelected.MaKhoa;

                        MonSua.SoTin = int.Parse(txt_SoTC.Text);
                        MonSua.DonGia = decimal.Parse(txt_DonGia.Text);

                        // luu su thay doi nay o database
                        db.SaveChanges();
                        // Thong bao sua thanh cong
                        MessageBox.Show("Sửa thành công", "Thông báo");
                        // Hien thi lai du lieu
                        HienThiDL();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Có lỗi khi sửa: " + ex.Message, "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại mã môn này", "Thông báo");
                HienThiDL();
            }
        }

        private void btn_Search_Click(object sender, RoutedEventArgs e)
        {
            // lay itemSelected o cbo, dung de truy van LINQ cac row co mon thuoc Khoa do
            Khoa itemSelected = (Khoa)cbo_DsKhoa.SelectedItem;
            // Truy van LINQ voi dieu kien MaKhoa
            var query = db.MonHocs.Where(x => x.MaKhoa.Equals(itemSelected.MaKhoa)).Select(x => x);
            if (query != null)
            {
                MessageBox.Show("Tìm thành công các môn thuộc khoa " + itemSelected.TenKhoa.ToString(), "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                dgv_DSDK.ItemsSource = query.ToList();
            }
            else
                MessageBox.Show("Không tìm thấy môn thuộc khoa " + itemSelected.TenKhoa.ToList(), "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void btn_Statistical_Click(object sender, RoutedEventArgs e)
        {
            // lay ra itemSelected o cbo
            Khoa itemSelected = (Khoa)cbo_DsKhoa.SelectedItem;

            Window1 window1 = new Window1(itemSelected.MaKhoa);
            window1.Show();
        }

        private void btn_Reset_Click(object sender, RoutedEventArgs e)
        {
            HienThiDL();
        }

        // Tao ham check du lieu de kiem tra du lieu dau vao co thoa mam k (kieu du lieu ra la bool)
        private bool CheckDL()
        {
            string mess = ""; // tao 1 bien de chua dung thong bao loi

            if (txt_MaMon.Text == "")// Kiem tra xem TextBox MaMon co trong k
                mess += "Vui lòng điền mã môn \n";

            if (txt_TenMon.Text == "")// Kiem tra xem TextBox TenMon co trong k
                mess += "Vui lòng điền tên môn \n";

            if (txt_SoTC.Text == "") // Kiem tra textbox so tin co trong k
                mess += "Vui lòng điền số tín \n";
            else
            {
                if (!Regex.IsMatch(txt_SoTC.Text, @"\d+")) // Kiem tra xem so tin nhap vao co phai so k
                    mess += "Vui lòng điền số tín là số \n";
                else
                {
                    int st = int.Parse(txt_SoTC.Text);
                    if (st < 0) // Kiem tra xem so tin nhap vao co phai so duong k
                        mess += "Vui lòng điền số tín là số dương \n";
                }
            }

            // Tuong tu nhu so tin
            if (txt_DonGia.Text == "")
                mess += "Vui lòng điền đơn giá \n";
            else
            {
                if (!Regex.IsMatch(txt_DonGia.Text, @"\d+"))
                    mess += "Vui lòng điền đơn giá là số \n";
                else
                {
                    decimal dg = decimal.Parse(txt_DonGia.Text);
                    if (dg < 0)
                        mess += "Vui lòng điền đơn giá là số dương \n";
                }
            }


            if(mess != "")
            {
                MessageBox.Show(mess, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Stop);
                return false;
            }

            return true; // Them ham check du lieu o cac su kien them, va sua vi co su thay doi, nhap du lieu dau vao o text box
        }

        private void btn_Xoa_Click(object sender, RoutedEventArgs e)
        {
            // Truy van tim MaMon co ton tai k
            var remove = db.MonHocs.SingleOrDefault(x => x.MaMon.Equals(txt_MaMon.Text));
            if(remove != null)// neu ton tai
            {
                MessageBoxResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa!", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Question); // Hoi ng dung
                if(rs == MessageBoxResult.Yes)
                {
                    db.MonHocs.Remove(remove); // Xoa
                    MessageBox.Show("Xoá thành công", "Thông báo"); // Thong bao
                    db.SaveChanges(); // Luu database
                    HienThiDL(); // Hien thi lai
                }    
            }
        }
    }
}
