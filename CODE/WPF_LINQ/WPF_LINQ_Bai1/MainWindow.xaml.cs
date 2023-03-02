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
using WPF_LINQ_Bai1.Models;

namespace WPF_LINQ_Bai1
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

        // Tao 1 the hien cua lop Context
        QLSinhVienContext db = new QLSinhVienContext();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*
             * Select danh sach SV
            // Cach 1: Truy xuat LINQ theo bieu thuc 
            var sv = from s in db.SinhViens select s;
            // hien thi len datagrid
            GrList.ItemsSource = sp.ToList();
            
            */
            //Cach 2: Truy xuat LINQ theo phuong thuc mo rong
            var sv = db.SinhViens.Select(s => s);
            // Hien thi len DataGrid
            GrList.ItemsSource = sv.ToList();
            
        }

        private void btn_sl_choice_Click(object sender, RoutedEventArgs e)
        {
            /*
            // Cach 1: Truy van LINQ theo bieu thuc
            var sv = from s in db.SinhViens select new { s.HoTen, s.GioiTinh };
            GrList.ItemsSource = sv.ToList();
            */

            // Cach 2: Truy van LINQ theo phuong thuc mo rong
            var sv = db.SinhViens.Select(s => new { s.HoTen, s.GioiTinh });
            GrList.ItemsSource = sv.ToList();
        }

        private void btn_sl_take_skip_Click(object sender, RoutedEventArgs e)
        {
            // Lay mau tin dau tin trong bang 
            // Cach 1: Truy van LINQ theo bieu thuc
            /*var sv = (from s in db.SinhViens select s).Take(1);
            GrList.ItemsSource = sv.ToList();*/

            // Cach 2: Truy van LINQ theo phuong thuc mo rong
            var sv = db.SinhViens.Select(s => s).Take(1);
            GrList.ItemsSource = sv.ToList();

            
        }

        private void btn_sl_skip_Click(object sender, RoutedEventArgs e)
        {
            // Bo qua mau tin thu 1 2 3, lay 3 mau tin tiep theo trong bang
            // Cach 1: Truy van LINQ theo bieu thuc
            /*var sv = from p in db.SinhViens.Skip(3).Take(3) select p;
            GrList.ItemsSource = sv.ToList();*/

            // Cach 2: Truy van LINQ theo phuong thuc mo rong
            var sv = db.SinhViens.Skip(3).Take(3).Select(s=>s);
            GrList.ItemsSource = sv.ToList();
        }

        private void btn_sl_take_orderby(object sender, RoutedEventArgs e)
        {
            // Lay mau tin cuoi cung trong bang

            /*// Cach 1: Truy van LINQ theo bieu thuc
            var sv = from s in db.SinhViens.Take(1) orderby s.MaSv descending select s;
            // Hien thi len DataGrid
            GrList.ItemsSource = sv.ToList();*/

            // Cach 2: Truy van LINQ theo phuong thuc mo rong
            var sv = db.SinhViens.OrderByDescending(s => s.MaSv).Take(1).Select(s => s);
            // Hien thi len DataGrid
            GrList.ItemsSource = sv.ToList();
        }

        private void btn_orderby(object sender, RoutedEventArgs e)
        {
            // Sap xep giam dan theo masv (ma dinh orderby la tang dan)
            // Cach 1: Truy van LINQ theo bieu thuc
            /*var sv = from s in db.SinhViens orderby s.MaSv descending select s;
            GrList.ItemsSource= sv.ToList();*/

            // Cach 2: Truy van LINQ theo phuong thuc mo rong
            var sv = db.SinhViens.OrderByDescending(s => s.MaSv).Select(s => new { s.MaSv, s.HoTen });
            GrList.ItemsSource = sv.ToList();
        }

        private void btn_distinct(object sender, RoutedEventArgs e)
        {
            // Cach 1: Truy van LINQ theo bieu thuc
            var sv = db.SinhViens.Distinct().Select(s => new { s.MaSv, s.HoTen, s.GioiTinh });
            GrList.ItemsSource = sv.ToList();
        }

        private void btn_Where(object sender, RoutedEventArgs e)
        {
            // Lay dieu kien theo ma sinh vien
            // Cach 1: Truy van LINQ theo bieu thuc
            /*var sv = from a in db.SinhViens where a.MaLop == "LP001" select new { a.MaLop, a.HoTen, a.GioiTinh };
            GrList.ItemsSource = sv.ToList();*/

            // Cach 2: Truy van LINQ theo phuong thuc mo rong
            var sv = db.SinhViens.Where(a => a.MaLop == "LP001").Select(a => new {a.MaLop, a.HoTen,a.GioiTinh});
            GrList.ItemsSource = sv.ToList();
        }

        private void btn_Join(object sender, RoutedEventArgs e)
        {
            // Cach 1: Truy van LINQ bang bieu thuc
            var sv = from a in db.SinhViens join b in db.Lops on a.MaLop equals b.MaLop select new { a.MaLop, b.TenLop, a.HoTen, a.GioiTinh };
            GrList.ItemsSource = sv.ToList();
        }

        private void btn_GroupBy(object sender, RoutedEventArgs e)
        {
            var sv = from a in db.SinhViens
                     group a by a.MaLop into gr
                     select new
                     {
                         MaLop = gr.Key,
                         SoLuong = gr.Count()
                     };

            GrList.ItemsSource = sv.ToList();
        }

        private void btn_Gr_Jn(object sender, RoutedEventArgs e)
        {
            var query1 = from sv in db.SinhViens
                         group sv by sv.MaLop into gr
                         select new
                         {
                             MaLop = gr.Key,
                             TongSV = gr.Count()
                         };

            var query2 = from sv1 in query1
                         join lop in db.Lops on sv1.MaLop equals lop.MaLop
                         select new
                         {
                             sv1.MaLop,
                             lop.TenLop,
                             sv1.TongSV
                         };


            GrList.ItemsSource = query2.ToList();
        }
    }
}
