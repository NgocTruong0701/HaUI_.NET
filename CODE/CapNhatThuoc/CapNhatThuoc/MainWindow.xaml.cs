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
using CapNhatThuoc.Models;
using System.Reflection;
using System.Text.RegularExpressions;

namespace CapNhatThuoc
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

        QLTHUOCContext sp = new QLTHUOCContext();

        private void HienThiDuLieu()
        {
            var query = from db in sp.Thuocs
                        orderby db.DonGia
                        select new
                        {
                            db.MaThuoc,
                            db.TenThuoc,
                            db.MaLoai,
                            db.DonGia,
                            db.SoLuong,
                            ThanhTien = db.DonGia * db.SoLuong
                        };
            dt1.ItemsSource = query.ToList();

        }
        private void HienThiCB()
        {
            var query = from lthuoc in sp.LoaiThuocs
                        select lthuoc;
            cbxloai.ItemsSource = query.ToList();
            cbxloai.SelectedIndex = 0;
            cbxloai.SelectedValuePath = "MaLoai";
            cbxloai.DisplayMemberPath = "TenLoai";
        }

        private void capnhatthuoc_Loaded(object sender, RoutedEventArgs e)
        {
            HienThiDuLieu();
            HienThiCB();
        }

        private void butthem_Click(object sender, RoutedEventArgs e)
        {
            var query = sp.Thuocs.SingleOrDefault(x => x.MaThuoc.Equals(txtma.Text));
            if(query != null)
            {
                MessageBox.Show("Đã tồn tại thuốc này!", "Thông báo");
                HienThiDuLieu();
            }
            else
            {
                Thuoc thuocNew = new Thuoc();
                thuocNew.MaThuoc = txtma.Text;
                thuocNew.TenThuoc = txtten.Text;
                thuocNew.DonGia = double.Parse(txtgia.Text);
                thuocNew.SoLuong = int.Parse(txtsl.Text);
                LoaiThuoc loai = new LoaiThuoc();
                loai = (LoaiThuoc)cbxloai.SelectedItem;
                thuocNew.MaLoai = loai.MaLoai;
                sp.Thuocs.Add(thuocNew);
                sp.SaveChanges();
                MessageBox.Show("Thêm thành công!", "Thông báo");
                HienThiDuLieu();
            }    
        }

        private void butsua_Click(object sender, RoutedEventArgs e)
        {
            var thuocSua = sp.Thuocs.SingleOrDefault(x => x.MaThuoc.Equals(txtma.Text));
            if(thuocSua != null)
            {
                thuocSua.MaThuoc = txtma.Text;
                thuocSua.TenThuoc = txtten.Text;
                thuocSua.DonGia = double.Parse(txtgia.Text);
                thuocSua.SoLuong = int.Parse(txtsl.Text);
                LoaiThuoc loai = new LoaiThuoc();
                loai = (LoaiThuoc)cbxloai.SelectedItem;
                thuocSua.MaLoai = loai.MaLoai;
                sp.SaveChanges();
                MessageBox.Show("Sửa thành công!", "Thông báo");
                HienThiDuLieu();
            }
            else
            {
                MessageBox.Show("Không có thuôc này!", "Thông báo");
            }    
        }

        private void dt1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(dt1.SelectedItem != null)
            {
                Type t = dt1.SelectedItem.GetType();
                PropertyInfo[] p = t.GetProperties();
                txtma.Text = p[0].GetValue(dt1.SelectedValue).ToString();
                txtten.Text = p[1].GetValue(dt1.SelectedValue).ToString();
                cbxloai.SelectedValue = p[2].GetValue(dt1.SelectedValue).ToString();
                txtgia.Text = p[3].GetValue(dt1.SelectedValue).ToString();
                txtsl.Text = p[4].GetValue(dt1.SelectedValue).ToString();
            }    
        }

        private void butxoa_Click(object sender, RoutedEventArgs e)
        {
            var tXoa = sp.Thuocs.SingleOrDefault(t => t.MaThuoc.Equals(txtma.Text));
            if(tXoa != null)
            {
                MessageBoxResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButton.YesNo);
                if (rs == MessageBoxResult.Yes)
                {
                    sp.Thuocs.Remove(tXoa);
                    sp.SaveChanges();
                    HienThiDuLieu();
                }
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào để xóa!", "Thong báo");
            }    
                
        }

        private void buttim_Click(object sender, RoutedEventArgs e)
        {
            //Tạo một đối tượng loaithuoc để lấy dữ liệu từ đó:
            LoaiThuoc lt = new LoaiThuoc();
            lt = (LoaiThuoc)cbxloai.SelectedItem;

            //truy vấn linq trong database để đưa ra:
            var query = sp.Thuocs.Where(x => x.MaLoai.Equals(lt.MaLoai)).Select(x => new { x.MaThuoc, x.TenThuoc, x.MaLoai, x.DonGia, x.SoLuong});
            if(query != null)
            {
                MessageBox.Show("Tìm thành công thuốc thuộc loại " + lt.TenLoai.ToString(), "Thông báo");
                dt1.ItemsSource = query.ToList();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thuốc thuộc loại " + lt.TenLoai.ToString(), "Thông báo");
            }    
        }

        private void butthongke_Click(object sender, RoutedEventArgs e)
        {
            LoaiThuoc lt = (LoaiThuoc)cbxloai.SelectedItem;
            Window1 windown = new Window1(lt.MaLoai);
            windown.Show();
        }
    }

}
