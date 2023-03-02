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
using WPF_DB_QLKETQUA.Models;
using System.Text.RegularExpressions; // Thu vien check du lieu
using System.Reflection; // Thu vien khi chon dong se su dung


namespace WPF_DB_QLKETQUA
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

        // Tao 1 doi tuong thuoc class Context de thao tac tren do
        QuanLySVContext db = new QuanLySVContext();
        
        // Tao 1 ham hien thi du lieu len DataGrid 
        private void HienThiDL()
        {
            // Truy van LINQ database
            var query = db.Kqs.OrderBy(x => x.Diem).Select(x => x);

            // Hien thi len DataGrid
            dgv_KQ.ItemsSource = query.ToList();
        }

        // Tao 1 ham hien thi du lieu len ComboBox
        private void HienThiCB()
        {
            // Truy van LINQ database
            var query = db.Mons.Select(x => x);

            // Hien thi len Cbo
            cbo_Mon.ItemsSource = query.ToList();
            // Hien thi ben ngoai la ten mon
            cbo_Mon.DisplayMemberPath = "TenMh";
            // Gia tri lua chon thuc te la MaMh
            cbo_Mon.SelectedValuePath = "MaMh";
            // Gia tri chua lua chon hien thi la gia tri dau tien
            cbo_Mon.SelectedIndex = 0;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HienThiDL();
            HienThiCB();
        }

        private void dgv_KQ_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(dgv_KQ.SelectedItem != null)
            {
                try
                {
                    Type t = dgv_KQ.SelectedItem.GetType();
                    PropertyInfo[] p = t.GetProperties();

                    txt_MaSV.Text = p[0].GetValue(dgv_KQ.SelectedValue).ToString();
                    cbo_Mon.SelectedValue = p[1].GetValue(dgv_KQ.SelectedValue).ToString();
                    txt_Diem.Text = p[2].GetValue(dgv_KQ.SelectedValue).ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Co loi khi chon donng " + ex.Message, "Thong bao");
                }
            }
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            // Xem xem MaMh co ton tai k 
            Mon mon = (Mon)cbo_Mon.SelectedItem;
            var query1 = db.Mons.SingleOrDefault(x => x.MaMh.Equals(mon.MaMh));
            // Xem xem MaSv co ton tai k
            var query2 = db.Svs.SingleOrDefault(x => x.MaSv.Equals(txt_MaSV.Text));
            // Xem xem cap MaSv va MaMh co ton tai trong Bang KQ k
            var query3 = from i in db.Kqs where i.MaSv.Equals(txt_MaSV.Text) where i.MaMh.Equals(mon.MaMh) select i;
            if (query1 != null && query2 != null && query3 == null)
            {
                Kq newRow = new Kq();
                newRow.MaSv = txt_MaSV.Text;
                newRow.MaMh = mon.MaMh;
                newRow.Diem = decimal.Parse(txt_Diem.Text);

                // Luu lai su thay doii
                db.SaveChanges();
                // Thong bao da them thanh cong
                MessageBox.Show("Them thanh cong", "Thong bao");
                // Hien thi lai
                HienThiDL();
            }
            else
                MessageBox.Show("Da dien ket qua cho sinh vien thuoc mon nay", "Thong bao");
        }

        private void btn_Change_Click(object sender, RoutedEventArgs e)
        {
            // kiem tra xem ton tai k
            var query = db.Kqs.SingleOrDefault(x => x.MaSv.Equals(txt_MaSV));
        }
    }
}
