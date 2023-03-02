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
using OnTap2.Models;
using System.Reflection; // Dung khi chon dong 
using System.Text.RegularExpressions; // Dung khi check du lieu

namespace OnTap2
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

        // Tao 1 doi tuong thuoc lop Contex de ta co the thao tac 
        QLNhanvienContext db = new QLNhanvienContext();

        // Tao 1 ham hien thi du lieu len DataGrid
        private void HienThiDL()
        {
            // Truy van LINQ vao DataBase
            var query = db.Nhanviens.Where(x => x.Luong > 5000).OrderBy(x => x.Luong).Select(x => new { x.MaPhong, x.MaNv, x.Hoten, x.Luong, x.Thuong, TongTien = x.Luong + x.Thuong });
            // Hien thi len DataGrid
            dgv_DS.ItemsSource = query.ToList();
        }

        // Tao 1 ham hien thi du lieu len ComboBox
        private void HienThiCB()
        {
            // Truy van LINQ vao database bang PhongBan
            var query = db.PhongBans.Select(x => x);
            // Hien thi len ComboBox
            cbo_RomId.ItemsSource = query.ToList();
            // Hien thi chi ten phong
            cbo_RomId.DisplayMemberPath = "TenPhong";
            // Chon gia tri la ma phong
            cbo_RomId.SelectedValuePath = "MaPhong";
            // Hien thi gia tri dau
            cbo_RomId.SelectedIndex = 0;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HienThiDL();
            HienThiCB();
        }

        // Tao 1 ham check du lieu dau vao
        private bool CheckDL()
        {
            string tb = "";
            if (txt_EmpId.Text == "")
                tb += "Vui lòng nhập mã nhân viên \n";
            if (txt_Name.Text == "")
                tb += "Vui lòng nhập tên nhân viên \n";

            if (txt_Salary.Text == "")
                tb += "Vui lòng nhập lương \n";
            else
            {
                if (!Regex.IsMatch(txt_Salary.Text, @"\d+"))
                {
                    tb += "Lương nhập vào phải là số \n";
                }
                else
                {
                    if (int.Parse(txt_Salary.Text) < 3000 || int.Parse(txt_Salary.Text) > 9000)
                        tb += "Tiền lương phải trong khu vực từ 3000 đến 9000 \n";
                }
            }

            if (txt_Reward.Text == "")
                tb += "Vui lòng nhập tiền thường \n";
            else
            {
                if (!Regex.IsMatch(txt_Reward.Text, @"\d+")) // neu du lieu vao k phai la so
                {
                    tb += "Thưởng nhập vào phải là số \n";
                }
                else
                {
                    int reward = int.Parse(txt_Reward.Text);
                    if (reward < 100 || reward > 900)
                        tb += "Tiền thưởng phải trong khu vực từ 100 đến 900 \n";
                }
            }
            
            if(tb != "")
            {
                MessageBox.Show(tb, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Stop);
                return false;
            }
            return true;
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            // Kiem tra xem ton tai ma nhan vien do chua
            var query = db.Nhanviens.SingleOrDefault(x => x.MaNv.Equals(txt_EmpId.Text));
            if (query != null)
            {
                MessageBox.Show("Đã tồn tại nhân viên này", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Stop);
                HienThiDL();
            }
            else
            {
               try
               {
                    if(CheckDL())
                    {
                        // Tao 1 doi tuong nhân vien va gán du lieu vao 
                        Nhanvien nvN = new Nhanvien();
                        nvN.MaNv = txt_EmpId.Text;
                        nvN.Hoten = txt_Name.Text;
                        nvN.Luong = int.Parse(txt_Salary.Text);
                        nvN.Thuong = int.Parse(txt_Reward.Text);
                        PhongBan itemSelected = (PhongBan)cbo_RomId.SelectedItem;
                        nvN.MaPhong = itemSelected.MaPhong;
                        // Theo vao database
                        db.Nhanviens.Add(nvN);
                        // Luu su thay doi
                        db.SaveChanges();
                        // Thong bao them thanh cong
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        // Hien thi lai du lieu o datagrid
                        HienThiDL();
                    }
               }
               catch(Exception ex)
               {
                    MessageBox.Show("Có lỗi khi thêm " + ex.Message, "Thông báo");
               }
            }
        }

        private void btn_Change_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CheckDL())
                {
                    var query = db.Nhanviens.SingleOrDefault(x => x.MaNv.Equals(txt_EmpId.Text));
                    if (query != null)
                    {
                        PhongBan itemSelected = (PhongBan)cbo_RomId.SelectedItem;
                        query.MaPhong = itemSelected.MaPhong;
                        query.Hoten = txt_Name.Text;
                        query.Luong = int.Parse(txt_Salary.Text);
                        query.Thuong = int.Parse(txt_Reward.Text);

                        // Luu su thay doi
                        db.SaveChanges();
                        // Thong bao sua thanh cong
                        MessageBox.Show("Sửa thành công", "Thông báo",MessageBoxButton.OK,MessageBoxImage.Information);
                        // Hien thi lai du lieu o datagrid
                        HienThiDL();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên này", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Hand);
                        HienThiDL();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi khi sửa " + ex.Message, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_Remove_Click(object sender, RoutedEventArgs e)
        {
            if (dgv_DS.SelectedItem != null)
            {
                MessageBoxResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if(rs == MessageBoxResult.Yes)
                {
                    Type t = dgv_DS.SelectedItem.GetType(); // lay type cua item duoc select
                    PropertyInfo[] p = t.GetProperties(); // tao 1 mang thong tin 

                    string empid = p[1].GetValue(dgv_DS.SelectedValue).ToString(); // lay ma nhan vien thong qua mang thong tin va value cua itemselected

                    var empRemove = db.Nhanviens.Single(x => x.MaNv.Equals(empid)); // buoc nay la dua ra doi tuong co ma nhan vien do trong database vi neu k lam nhu nay k the xoa do o C# no kieu object chu k phai kieu nhan vien
                    db.Nhanviens.Remove(empRemove); // xoa nhan vien co ma nay trong database
                    // Luu su thay doi
                    db.SaveChanges();
                    MessageBox.Show("Xoá thành công", "Thông báo");
                    // hien thi lai database tren grid
                    HienThiDL();
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn nhân viên muốn xóa trước", "Thông báo");
            }
        }

        private void btn_Search_Click(object sender, RoutedEventArgs e)
        {
            PhongBan itemSelected = (PhongBan)cbo_RomId.SelectedItem;
            Search window = new Search(itemSelected.MaPhong);
            window.Show();
        }

        private void btn_Statistical_Click(object sender, RoutedEventArgs e)
        {
            ThongKe window = new ThongKe();
            window.Show();
        }
    }
}
