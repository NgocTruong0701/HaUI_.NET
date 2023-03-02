using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn mở chương trình?", "Hỏi người dùng", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Cancel)
                Dispose();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tên của bạn là: " + txt_Hoten.Text);
            txt_Hoten.Clear();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.T)
                txt_Hoten.Text = "Lê Ngọc Trường";
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                MessageBox.Show("Bạn vừa click chuột trái");
            if (e.Button == MouseButtons.Right)
                MessageBox.Show("Bạn vừa click chuột phải");
            if (e.Button == MouseButtons.Middle)
                MessageBox.Show("Bạn vừa click chuột giữa");
        }

        private void btn_Exist_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn thoát chứ?", "Hỏi người dùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
                Application.Exit();
        }
    }
}
