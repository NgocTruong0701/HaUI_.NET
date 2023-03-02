using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD_ComboBox
{
    public partial class Doi_mau : Form
    {
        public Doi_mau()
        {
            InitializeComponent();
        }

        private void Doi_mau_Load(object sender, EventArgs e)
        {
            cbo_DsColor.Items.Add("Green");
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (cbo_DsColor.Text == String.Empty)
                MessageBox.Show("Mời chọn màu để đổi.", "Thông báo");
            else
            {
                if(cbo_DsColor.Text == "Red")
                {
                    lab_Tittel.ForeColor = Color.Red;
                    lab_Tittel.BackColor = Color.Yellow;
                }

                else if (cbo_DsColor.Text == "Blue")
                {
                    lab_Tittel.ForeColor = Color.Blue;
                    lab_Tittel.BackColor = Color.Green;
                }

                else if (cbo_DsColor.Text == "Black")
                {
                    lab_Tittel.ForeColor = Color.Black;
                    lab_Tittel.BackColor = Color.Blue;
                }

                else if (cbo_DsColor.Text == "Pink")
                {
                    lab_Tittel.ForeColor = Color.Pink;
                    lab_Tittel.BackColor = Color.Violet;
                }

                else if (cbo_DsColor.Text == "Green")
                {
                    lab_Tittel.ForeColor = Color.Green;
                    lab_Tittel.BackColor = Color.Yellow;
                }

                else if (cbo_DsColor.Text == "Yellow")
                {
                    lab_Tittel.ForeColor = Color.Yellow;
                    lab_Tittel.BackColor = Color.Green;
                }

                else if (cbo_DsColor.Text == "White")
                {
                    lab_Tittel.ForeColor = Color.White;
                    lab_Tittel.BackColor = Color.Black;
                }

                else
                {
                    MessageBox.Show("Không có màu này để đổi", "Thông báo");
                }
               
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình", "Thông báo", MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
                Application.Exit();
        }
    }
}
