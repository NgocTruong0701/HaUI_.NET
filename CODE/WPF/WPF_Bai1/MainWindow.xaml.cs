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

namespace WPF_Bai1
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

        private void btn_Calc_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_HoTen.Text) || String.IsNullOrWhiteSpace(txt_CSC.Text)
                || String.IsNullOrWhiteSpace(txt_CSM.Text))
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo");
            else
            {
                double csc = double.Parse(txt_CSC.Text);
                double csm = double.Parse(txt_CSM.Text);

                if(csc > csm)
                {
                    MessageBox.Show("Chỉ số mới và chỉ số cũ không hợp lệ", "Thông báo");
                    return;
                }

                double kwtt = csm - csc;
                txt_SoKwTT.Text = kwtt.ToString();

                double kwdm = 0;
                if (kwtt <= 50)
                {
                    kwdm = kwtt;
                    txt_SoKwTr.Text = kwdm.ToString();
                    txt_SoKwNg.Text = String.Empty;

                    txt_TTien.Text = (kwdm * 500).ToString();
                }
                else
                {
                    kwdm = 50;
                    double kwndm = kwtt - 50;
                    txt_SoKwTr.Text = "50";
                    txt_SoKwNg.Text = kwndm.ToString();

                    txt_TTien.Text = (50 * 500 + kwndm * 1000).ToString();
                }
            }
        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            lst_TT.Items.Clear();

            if (String.IsNullOrWhiteSpace(txt_HoTen.Text) || String.IsNullOrWhiteSpace(txt_CSC.Text)
                || String.IsNullOrWhiteSpace(txt_CSM.Text))
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo");
            else
            {
                lst_TT.Items.Add(txt_HoTen.Text);
                lst_TT.Items.Add(txt_SoKwTT.Text);
                lst_TT.Items.Add(txt_TTien.Text);
            }
            
        }

        private void Print_Copy_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
                this.Close();

        }
    }
}
