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

namespace ThuVienSach
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
        private void btn_Add1_Click(object sender, RoutedEventArgs e)
        {
            if (lst_DanhSachSource.SelectedItems.Count > 1)
                MessageBox.Show("Không thể thực hiện thêm nhiều sách ở hành động này", "Thông báo");
            else
            {
                if (lst_DanhSachChon.Items.Count > 0)
                {
                    int check = 0;
                    foreach (var i in lst_DanhSachChon.Items)
                        if (i == lst_DanhSachSource.SelectedItem)
                            check++;
                    if (check > 0)
                        MessageBox.Show("Đã tồn tại sách này", "Đã tồn tại sách này");
                    else
                        lst_DanhSachChon.Items.Add(lst_DanhSachSource.Items[lst_DanhSachSource.SelectedIndex]);
                }
                else
                    lst_DanhSachChon.Items.Add(lst_DanhSachSource.SelectedItem);
            }
        }

        private void btn_AddN_Click(object sender, RoutedEventArgs e)
        {
            if (lst_DanhSachChon.Items.Count > 0)
            {
                int check = 0;
                foreach (var i in lst_DanhSachChon.Items)
                    foreach (var j in lst_DanhSachSource.SelectedItems)
                    {
                        if (i == j)
                            check++;
                    }

                if (check > 0)
                {
                    lst_DanhSachChon.Items.Clear();
                    foreach (var i in lst_DanhSachSource.SelectedItems)
                        lst_DanhSachChon.Items.Add(i);
                }
                else
                {
                    foreach (var i in lst_DanhSachSource.SelectedItems)
                        lst_DanhSachChon.Items.Add(i);
                }

            }
            else
            {
                foreach(var i in lst_DanhSachSource.SelectedItems)
                    lst_DanhSachChon.Items.Add(i);
            }
        }

        private void btn_AddAll_Click(object sender, RoutedEventArgs e)
        {
            lst_DanhSachChon.Items.Clear();

            foreach (var i in lst_DanhSachSource.Items)
                    lst_DanhSachChon.Items.Add(i);
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lst_DanhSachSource.Items.Add("Công nghệ thực tế ảo");
            lst_DanhSachSource.Items.Add("Đảm bảo chất lượng phần mềm");
            lst_DanhSachSource.Items.Add("Giải thuật di truyền và ứng dụng");
            lst_DanhSachSource.Items.Add("Hệ chuyên gia");
            lst_DanhSachSource.Items.Add("Lập trình căn bản");
            lst_DanhSachSource.Items.Add("Lập trình hướng đối tượng");
            lst_DanhSachSource.Items.Add("Lập trình mạng");
            lst_DanhSachSource.Items.Add("Lập trình trên Windows");
            lst_DanhSachSource.Items.Add("Một số phương pháp tính toán phần mềm");
            lst_DanhSachSource.Items.Add("Nhập môn tin học");
            lst_DanhSachSource.Items.Add("Phân tích thiết kế hệ thống");
            lst_DanhSachSource.Items.Add("Phân tích và thống kê số liệu");
            lst_DanhSachSource.Items.Add("Thiết kế cơ sở dữ liệu");
            lst_DanhSachSource.Items.Add("Thiết kế website");
            lst_DanhSachSource.Items.Add("Tin văn phòng");
        }

        private void bnt_Remove1_Click(object sender, RoutedEventArgs e)
        {
            if (lst_DanhSachChon.Items.Count > 0)
                lst_DanhSachChon.Items.RemoveAt(lst_DanhSachChon.SelectedIndex);
            else
                MessageBox.Show("Còn gì đâu mà xóa :))");
        }

        private void btn_RemoveN_Click(object sender, RoutedEventArgs e)
        {
            if(lst_DanhSachChon.Items.Count > 0)
            {
                for (int i1 = 0; i1 < lst_DanhSachChon.SelectedItems.Count; i1++)
                {
                    //object i = lst_DanhSachChon.SelectedItems[i1];
                    lst_DanhSachChon.Items.Remove(lst_DanhSachChon.SelectedItems[i1]);
                    i1--;
                }
            }
            else
                MessageBox.Show("Còn gì đâu mà xóa :))");
        }

        private void btn_RemoveAll_Click(object sender, RoutedEventArgs e)
        {
           
            if (lst_DanhSachChon.Items.Count > 0)
            {
                lst_DanhSachChon.Items.Clear();
            }
            else
                MessageBox.Show("Còn gì đâu mà xóa :))");
        }
    }
}
