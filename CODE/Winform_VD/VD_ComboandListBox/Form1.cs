using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD_ComboandListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Input_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txt_Name.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin!","Thông báo");
                txt_Name.Focus();
            }
            else
            {
                lst_Danhsach.Items.Add(txt_Name.Text);
                txt_CountDS.Text = lst_Danhsach.Items.Count.ToString();
                txt_Name.Clear();
                txt_Name.Focus();
            }

        }

        private void btn_RemoveAt_Click(object sender, EventArgs e)
        {
            List<int> selectCount = new List<int>();
            foreach (int item in lst_Danhsach.SelectedIndices)
                selectCount.Add(item);
            for(int i  = 0;i < lst_Danhsach.Items.Count;i++)
            {
                for(int j = 0;j < selectCount.Count;j++)
                {
                    if (i == selectCount[j])
                    {
                        lst_Danhsach.Items.RemoveAt(i);
                        i--;
                    }

                }    
            }
            txt_CountDS.Text = lst_Danhsach.Items.Count.ToString();
        }

        private void btn_RemoveF_Click(object sender, EventArgs e)
        {
            lst_Danhsach.Items.RemoveAt(0);
            txt_CountDS.Text = lst_Danhsach.Items.Count.ToString();
        }

        private void btn_RemoveL_Click(object sender, EventArgs e)
        {
            lst_Danhsach.Items.RemoveAt(lst_Danhsach.Items.Count-1);
            txt_CountDS.Text = lst_Danhsach.Items.Count.ToString();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lst_Danhsach.Items.Clear();
            txt_CountDS.Text = lst_Danhsach.Items.Count.ToString();
        }
    }
}
