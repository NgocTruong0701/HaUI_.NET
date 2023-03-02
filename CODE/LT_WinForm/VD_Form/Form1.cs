using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD_Form
{
    public partial class Form_Change_Name : Form
    {
        public Form_Change_Name()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Xin Chao";
        }

        private void Form_Change_Name_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thuc thi click vao form");
        }

        private void Form_Change_Name_ResizeEnd(object sender, EventArgs e)
        {
            string width = "Chieu rong cua form sau doi: " + this.Width.ToString() + "\n";
            string heigth = "Chieu cao cua form sau doi: " + this.Height.ToString();
            MessageBox.Show(width + heigth);
        }
    }
}
