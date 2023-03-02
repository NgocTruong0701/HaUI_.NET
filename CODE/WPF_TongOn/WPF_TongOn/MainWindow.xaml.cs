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
using WPF_TongOn.Models;
using System.Text.RegularExpressions; // Dùng khi check dữ liệu
using System.Reflection; // Dùng khi chọn dòng


namespace WPF_TongOn
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

        // Tao 1 the hien cua lop context, hay 1 con tro tro den models
        QLBanHangContext db = new QLBanHangContext();

        // Ham load du lieu len DataGrid
        /*Hiển thị các SanPham trong DataGrid ngay khi hiển thị window. Thông tin gồm: mã sản
            phẩm, tên sản phẩm, mã loại sản phẩm, số lượng, đơn giá, thành tiền. Dữ liệu được sắp xếp theo đơn giá tăng dần.
         */
        private void HienThiDL()
        {
            // Truy van LINQ theo phuong thuc mo rong
            var query = db.SanPhams.Select(x => new { x.MaSp, x.TenSp, x.MaLoai, x.SoLuong, x.DonGia, ThanhTien = x.SoLuong * x.DonGia}).OrderBy(x=>x.DonGia);

            // Sau khi truy xuat database xong thi hien thi len DataGrid
            dgv_DanhSachSP.ItemsSource = query.ToList();
        }

        // Ham load du lieu tu database len ComboBox
        /*
         * Sử dụng combo box hiển thị tên loại hàng từ bảng LoaiSanPham nhưng khi chọn lấy mã loại để cập nhật dữ liệu.
         */
        private void HienThiCB()
        {
            // Dau tien la truy van du lieu tu database ra, vi combobox nay hien thi loai san pham nen truy van o loai san pham
            var query = db.LoaiSanPhams.Select(x => x);

            // Hien thi len combobox 
            cbo_LoaiSP.ItemsSource = query.ToList();// tuy nhien cbo chi hien thi 1 cot trong nhieu cot cua database

            // ta chon cot hien thi o combobox
            cbo_LoaiSP.DisplayMemberPath = "TenLoai";

            // Khi  chon lay ma loai de cap nhat du lieu
            cbo_LoaiSP.SelectedValuePath = "MaLoai";

            // Hien thi khi load lan dau la phan tu dau tien
            cbo_LoaiSP.SelectedIndex = 0;
        }

        // Hanh dong load cua form
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Hien thi du lieu dgv
            HienThiDL();
            // Hien thi du lieu len cbo
            HienThiCB();
        }

        private void dgv_DanhSachSP_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e) // Code dưới vẫn chạy đc .Bổ sung thêm là cần cái này để khi mà sửa dữ liệu thì có thể
        {                                                                                              // Cell là thhay đổi đc thành phần của dòng chọn ấy, còn sellectchage là chỉ có thể 
                                                                                                       // Hiển thị khi select tjay đổi thôi
            if (dgv_DanhSachSP.SelectedItem != null)
            {
                // Sử lý ngoại lệ nếu phát sinh lỗi gì
                try
                {
                    Type t = dgv_DanhSachSP.SelectedItem.GetType();
                    PropertyInfo[] p = t.GetProperties();
                    txt_MaSP.Text = p[0].GetValue(dgv_DanhSachSP.SelectedValue).ToString();
                    txt_TenSP.Text = p[1].GetValue(dgv_DanhSachSP.SelectedValue).ToString();
                    cbo_LoaiSP.SelectedValue = p[2].GetValue(dgv_DanhSachSP.SelectedValue).ToString();
                    txt_SoLuong.Text = p[3].GetValue(dgv_DanhSachSP.SelectedValue).ToString();
                    txt_DonGia.Text = p[4].GetValue(dgv_DanhSachSP.SelectedValue).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi chọn hàng " + ex.Message, "Thông báo");
                }
            }
        }

        /*
         * Khi chọn 1 dòng dữ liệu trên DataGrid thì dữ liệu đó sẽ được điền vào các ô điều khiển
         */
        private void dgv_DanhSachSP_SelectionChanged(object sender, SelectionChangedEventArgs e) // 2 cái như nhau, vẫn k thấy sự khác biệt gì :))À đã thấy sự khác biệt r :((
        {
            if (dgv_DanhSachSP.SelectedItem != null)
            {
                // Sử lý ngoại lệ nếu phát sinh lỗi gì
                try
                {
                    Type t = dgv_DanhSachSP.SelectedItem.GetType();
                    PropertyInfo[] p = t.GetProperties();
                    txt_MaSP.Text = p[0].GetValue(dgv_DanhSachSP.SelectedValue).ToString();
                    txt_TenSP.Text = p[1].GetValue(dgv_DanhSachSP.SelectedValue).ToString();
                    cbo_LoaiSP.SelectedValue = p[2].GetValue(dgv_DanhSachSP.SelectedValue).ToString();
                    txt_SoLuong.Text = p[3].GetValue(dgv_DanhSachSP.SelectedValue).ToString();
                    txt_DonGia.Text = p[4].GetValue(dgv_DanhSachSP.SelectedValue).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi chọn hàng " + ex.Message, "Thông báo");
                }
            }
        } // Ơ nhưng qq phải 2 cái mới chạy đc ý :)) khó hiểu mất 1 trong 2 thì lại k chạy đc
        // có nghĩa là 1 cái để lấy select 1 cái thì để thay đổi cái thành phần (cell) của cái sellect đấy

        /*
         * Thêm 1 bản ghi mới vào bảng SanPham khi nhấn nút Thêm, dữ liệu do người dùng nhập qua các điều khiển nhập liệu.
            - Kiểm tra không cho nhập trùng mã sản phẩm.
            - Hiển thị lại dữ liệu sau khi thêm trong DataGrid.
        */
        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            // Kiem tra khong trung ma sp
            var query = db.SanPhams.SingleOrDefault(x => x.MaSp.Equals(txt_MaSP.Text)); // Truy vấn database xem masp co trùng với masp vừa nhập k bằng dùng phương thức mở rộng
            if(query != null)// có nghĩa nếu tìm ra cái row nào có masp trùng
            {
                MessageBox.Show("Đã tồn tại mã sản phẩm này", "Thông báo");
                HienThiDL();
            }
            else
            {
                try
                {
                    if(CheckDL()) // Neu check du lieu hop le se la true
                    {
                        SanPham sp = new SanPham();// tạo 1 đối tượng sp để gán các thuộc tính vừa nhập vào

                        sp.MaSp = txt_MaSP.Text;
                        sp.TenSp = txt_TenSP.Text;
                        sp.DonGia = decimal.Parse(txt_DonGia.Text);
                        sp.SoLuong = int.Parse(txt_SoLuong.Text);

                        LoaiSanPham itemSelected = (LoaiSanPham)cbo_LoaiSP.SelectedItem;// này do MaLoai từ LoaiSP vì vậy cần tạo 1 đối tượng LoaiSP mà được chọn trong cbo_LoaiSP đã có MaLoai
                        sp.MaLoai = itemSelected.MaLoai;

                        db.SanPhams.Add(sp);// Thêm vào danh sách đối tượng SanPhams
                        db.SaveChanges(); // Lưu thay đổi vào CLSD
                        MessageBox.Show("Đã thêm thành công!", "Thông báo");
                        HienThiDL();// Hiển thị lại
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi thêm: " + ex.Message, "Thông báo");
                }
            }
        }

        /*
         * Sửa thông tin sản phẩm được chọn trong danh sách khi nhấn nút Sửa, dữ liệu do người dùng nhập qua các điều khiển nhập liệu, không sửa mã sản phẩm. Lưu thông tin đã sửa vào
            CSDL và hiển thị lại dữ liệu trong DataGrid.
         */
        private void btn_Change_Click(object sender, RoutedEventArgs e)
        {
            // Xác định xem có sản phẩm cần sửa theo mã sp k
            var spSua = db.SanPhams.SingleOrDefault(x => x.MaSp.Equals(txt_MaSP.Text));
            if(spSua != null)
            {
                try
                {
                    if(CheckDL())// Tuong tu nhu them du lieu
                    {
                        spSua.TenSp = txt_TenSP.Text;// Gán lại thôi

                        LoaiSanPham itemSelected = (LoaiSanPham)cbo_LoaiSP.SelectedItem; // chú ý cbo tại nó k giống mấy cái khác, dữ liệu nó từ LoaiSanPhams chứ k phải từ SanPhams
                        spSua.MaLoai = itemSelected.MaLoai;

                        spSua.DonGia = decimal.Parse(txt_DonGia.Text);
                        spSua.SoLuong = int.Parse(txt_SoLuong.Text);

                        db.SaveChanges(); // Chú ý lưu dữ liệu nha
                        MessageBox.Show("Đã sửa thành công!", "Thông báo");

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
                MessageBox.Show("Không tìm thấy sản phẩm muốn sửa!");
            }
        }

        /*
         * Xóa sản phẩm được chọn trong danh sách khi nhấn nút Xóa.
            - Hiển thị thông báo khi không thấy sản phẩm để xóa.
            - Hiển thị thông báo xác nhận trước khi xóa.
            - Hiển thị lại dữ liệu sau khi xóa trong DataGrid.
         */
        private void btn_Remove_Click(object sender, RoutedEventArgs e)
        {
            // Xác định 1 sản phẩm cần xóa theo Mã 
            var spXoa = db.SanPhams.SingleOrDefault(x => x.MaSp.Equals(txt_MaSP.Text));

            if (spXoa != null)
            {
                MessageBoxResult rs = MessageBox.Show("Bạn chắc chắn muốn xóa", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (rs == MessageBoxResult.Yes)
                {
                    db.SanPhams.Remove(spXoa);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                    HienThiDL();
                }
            }
            else
            {
                MessageBox.Show("Không có sản phẩm này để xóa!", "Thông báo");
                HienThiDL();
            }
        }

        /*
         * Chọn 1 loại sản phẩm trong ComboBox, sau đó nhấn nút Tìm: Hiển thị thông tin của các sản phẩm tìm đươc lên DataGridView, gồm các cột: mã sản phẩm, tên sản phẩm, mã loại sản phẩm, số lượng, đơn giá, thành tiền.
         */
        private void btn_Search_Click(object sender, RoutedEventArgs e)
        {
            // Lay ra ma loai san pham dc dung, do khi ta select o cbo_LoaiSP neu dung .Text chi ra TenLoai chu k phai MaLoai
            // Va khi tim trong database k the dung tenloai de tim vi no khong la duy nhat
            // De khac phuc dieu nay thi ta tao 1 doi tuong LoaiSP xong do gan no la doi tuong cua cbo_LoaiSP.SelectItem hay la loai sp dc chon trong cbo_LoaiSP
            // Sau do truy van LINQ so sanh MaLoai la duoc roi ne :))

            LoaiSanPham itemSelected = new LoaiSanPham();// Tao 1 doi tuong loai san pham
            itemSelected = (LoaiSanPham)cbo_LoaiSP.SelectedItem; // Gan doi tuong vua tao la doi tuong da chon trong cbo (Phai ep kieu ve doi tuong kia)
            var lsp = db.SanPhams.Where(x => x.MaLoai.Equals(itemSelected.MaLoai)).Select(x => new {x.MaSp, x.TenSp, x.MaLoai,x.SoLuong, x.DonGia, ThanhTien = x.SoLuong * x.DonGia}); //  truy van LINQ de tim cac ban ghi co thoa man dieu kien giong ma loai
            
            // Hien thi len DataGrid
            dgv_DanhSachSP.ItemsSource = lsp.ToList();            
        }

        private void btn_Reset_Click(object sender, RoutedEventArgs e)
        {
            HienThiDL();
        }

        private void btn_Statistical_Click(object sender, RoutedEventArgs e)
        {
            LoaiSanPham loaisp = new LoaiSanPham();
            loaisp = (LoaiSanPham)cbo_LoaiSP.SelectedItem;
            ThongKe myWindow = new ThongKe(loaisp.MaLoai);
            myWindow.Show();
        }

        /*
         * *Các yêu cầu khác:
            1.Xử lý ngoại lệ và kiểm tra dữ liệu người dùng nhập vào khi thêm hoặc sửa:
            - Dữ liệu phải nhập vào đầy đủ, không để trống.
            - Kiểm tra số lượng và đơn giá phải là số và > 0. 
         */
        // Tạo 1 hàm check dữ liệu để kiểm tra dữ liệu đầu vào
        private bool CheckDL()
        {
            string message = "";
            if (txt_MaSP.Text == "" || txt_TenSP.Text == "" || txt_DonGia.Text == "" || txt_SoLuong.Text == "") // Kiem tra xem co nhap het may cai textbox chua
                message += "Bạn cần nhập đầy đủ dữ liệu \n";

            if (!Regex.IsMatch(txt_DonGia.Text, @"\d+")) // Nếu đơn giá nhập không phải là số
                message += "Đơn giá nhập phải là số \n";
            else
            {
                decimal dg = decimal.Parse(txt_DonGia.Text);
                if (dg < 0) // xem xem no co be hon 0 khong
                    message += "Đơn giá phải là số dương \n";
            }

            if (!Regex.IsMatch(txt_SoLuong.Text, @"\d+")) // Nếu số lương nhập không phải số
                message += "Số lượng nhập phải là số";
            else
            {
                int sl = int.Parse(txt_SoLuong.Text);
                if (sl < 0) // tuong tu don gia
                    message += "Số lượng phải là số dương \n";
            }

            if (message != "") // Kiểm tra xem có lỗi nào không
            {
                MessageBox.Show(message, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error); // thong bao cac loi
                return false;
            }
            return true; // Sau do ta sua lai kiem tra du lieu co cac su kien co them du lieu nhu them va sua 
        }
    }
}
