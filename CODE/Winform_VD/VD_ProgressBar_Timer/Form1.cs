using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD_ProgressBar_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Add(new TimeSpan());
            lbl_Time.Text = String.Format("{0:hh:mm:ss tt} {1:dd/MM/yyyy}", dt, dt);
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            if(progressBar1.Enabled == true)
            {
                progressBar1.Enabled = false;
                timer2.Start();
                timer1.Start();
            }
            else
            {
                progressBar1.Enabled = true;
                timer2.Stop();
                timer1.Stop();
                
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            progressBar1.Increment(1);
            lbl_Connection.Text = "Connecting to from " + progressBar1.Value.ToString() + "%";
            if(progressBar1.Value == progressBar1.Maximum)
            {
                timer2.Stop();
                frm.ShowDialog();
            }
        }
    }
}
