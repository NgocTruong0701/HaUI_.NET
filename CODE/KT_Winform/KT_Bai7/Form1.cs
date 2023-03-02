using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KT_Bai7
{
    public partial class Form1 : Form
    {
        List<NhanVien> dsnv = new List<NhanVien>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID = txt_ID.Text;
            string Name = txt_Name.Text;
            double LuongN = double.Parse(txt_LuongN.Text);
            double SoN = double.Parse(txt_SoN.Text);

            NhanVien nv = new NhanVien(ID, Name, LuongN, SoN);
            dsnv.Add(nv);
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            lstView_DSVN.Items.Clear();

            foreach(NhanVien i in dsnv)
            {
                lstView_DSVN.Items.Add(i.ID);
                lstView_DSVN.Items[lstView_DSVN.Items.Count -1].SubItems.Add(i.NameNV);
                lstView_DSVN.Items[lstView_DSVN.Items.Count -1].SubItems.Add(i.LuongN.ToString());
                lstView_DSVN.Items[lstView_DSVN.Items.Count -1].SubItems.Add(i.SoN.ToString());
                lstView_DSVN.Items[lstView_DSVN.Items.Count -1].SubItems.Add(i.Salary().ToString());
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            lstView_DSVN.Items.RemoveAt(lstView_DSVN.Items.Count - 1);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Ban co muon thoat khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
                Application.Exit();
        }

        

        private void lstView_DSVN_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            int row = e.ItemIndex;
            txt_ID.Text = lstView_DSVN.Items[row].SubItems[0].Text;
            txt_Name.Text = lstView_DSVN.Items[row].SubItems[1].Text;
            txt_LuongN.Text = lstView_DSVN.Items[row].SubItems[2].Text;
            txt_SoN.Text = lstView_DSVN.Items[row].SubItems[3].Text;
        }
    }
}
