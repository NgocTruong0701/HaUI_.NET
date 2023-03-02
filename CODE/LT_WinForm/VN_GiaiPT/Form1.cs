using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VN_GiaiPT
{
    public partial class Form_GiaiPT : Form
    {
        public Form_GiaiPT()
        {
            InitializeComponent();
        }

        private void btn_GiatPT_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBoxA.Text);
            double b = double.Parse(textBoxB.Text);
            double c = double.Parse(textBoxC.Text);
            string nghiem = String.Empty;

            if(a == 0)
            {
                if (b != 0)
                    nghiem = "x = " + (-c / b).ToString();
                else if (c == 0)
                    nghiem = "Phuong trinh co vo so nghiem";
                else
                    nghiem = "phuong trinh vo nghiem";
            }
            else
            {
                double denta = Math.Pow(b, 2) - 4 * a * c;
                if (denta < 0)
                    nghiem = "Phuong trinh vo nghiem";
                else if (denta == 0)
                    nghiem = "Phuong trinh co nghiem kep :" + (-b / 2 * 1).ToString();
                else
                    nghiem = "x1 = " + ((-b - Math.Sqrt(denta)) / 2 * a).ToString() +"    x2 = " + ((-b + Math.Sqrt(denta)) / 2 * a).ToString();
            }
            textBoxX.Text = nghiem;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxC.Clear();
            textBoxX.Clear();
        }


        private void btn_Thoat_Click_1(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Ban that su muon thoat?", "Thong bao", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
                this.Close();
        }
    }
}
