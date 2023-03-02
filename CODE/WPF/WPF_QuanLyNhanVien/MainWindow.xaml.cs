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

namespace WPF_QuanLyNhanVien
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

        public List<Employee> dsnv = new List<Employee>();

        public class Employee
        {
            public string Name { get; set; }
            public string GT { get; set; }
            public string PB { get; set; }

            public Employee(string name, string gT, string pB)
            {
                Name = name;
                GT = gT;
                PB = pB;
            }
        }
        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            string Name = txt_HoTen.Text;
            string GT = cbo_Gioitinh.Text;
            string PB = cbo_PhongBan.Text;
            Employee emp = new Employee(Name, GT, PB);
            dsnv.Add(emp);
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void btn_Show_Click(object sender, RoutedEventArgs e)
        {
            lstv_DanhSach.ItemsSource = dsnv;
        }
    }
}
