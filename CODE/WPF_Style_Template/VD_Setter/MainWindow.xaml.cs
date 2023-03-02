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

namespace VD_Setter
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private class Person
        {
            public string Ten { get; set; }
            public string CongViec { get; set; }
            public string DiaChi { get; set; }

            public Person()
            {
                this.Ten = String.Empty;
                this.CongViec = String.Empty;
                this.DiaChi = null;
            }

            public Person(string ten, string congviec, string diachi)
            {
                this.Ten = ten;
                this.CongViec = congviec;
                this.DiaChi = diachi;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Person p1 = new Person("Le Ngoc Truong","CNTT","Thanh Hoa");
            Person p2 = new Person("Nguyen Linh Truong", "Co khi", "Hai Duong");
            Person p3 = new Person("Sieu Nhan Gao", "Danh Yeu Quai", "Sao Hoa"); 

            dgv_ds.Items.Add(p1);
            dgv_ds.Items.Add(p2);
            dgv_ds.Items.Add(p3);
        }
    }
}
