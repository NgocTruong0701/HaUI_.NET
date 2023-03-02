namespace VD_ListView
{
    partial class frm_VD_ListView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grp_Input_Information = new System.Windows.Forms.GroupBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dt_Ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txt_Quequan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Hoten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstv_Danhsach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grp_Input_Information.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Input_Information
            // 
            this.grp_Input_Information.Controls.Add(this.btn_thoat);
            this.grp_Input_Information.Controls.Add(this.btn_xoa);
            this.grp_Input_Information.Controls.Add(this.btn_Them);
            this.grp_Input_Information.Controls.Add(this.dt_Ngaysinh);
            this.grp_Input_Information.Controls.Add(this.txt_Quequan);
            this.grp_Input_Information.Controls.Add(this.label3);
            this.grp_Input_Information.Controls.Add(this.label2);
            this.grp_Input_Information.Controls.Add(this.txt_Hoten);
            this.grp_Input_Information.Controls.Add(this.label1);
            this.grp_Input_Information.Location = new System.Drawing.Point(12, 12);
            this.grp_Input_Information.Name = "grp_Input_Information";
            this.grp_Input_Information.Size = new System.Drawing.Size(754, 154);
            this.grp_Input_Information.TabIndex = 0;
            this.grp_Input_Information.TabStop = false;
            this.grp_Input_Information.Text = "Nhập thông tin";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(518, 116);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 9;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(437, 116);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 8;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(356, 116);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 7;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dt_Ngaysinh
            // 
            this.dt_Ngaysinh.Location = new System.Drawing.Point(85, 54);
            this.dt_Ngaysinh.Name = "dt_Ngaysinh";
            this.dt_Ngaysinh.Size = new System.Drawing.Size(508, 20);
            this.dt_Ngaysinh.TabIndex = 6;
            // 
            // txt_Quequan
            // 
            this.txt_Quequan.Location = new System.Drawing.Point(85, 80);
            this.txt_Quequan.Name = "txt_Quequan";
            this.txt_Quequan.Size = new System.Drawing.Size(508, 20);
            this.txt_Quequan.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quê quán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày sinh";
            // 
            // txt_Hoten
            // 
            this.txt_Hoten.Location = new System.Drawing.Point(85, 28);
            this.txt_Hoten.Name = "txt_Hoten";
            this.txt_Hoten.Size = new System.Drawing.Size(508, 20);
            this.txt_Hoten.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // lstv_Danhsach
            // 
            this.lstv_Danhsach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstv_Danhsach.FullRowSelect = true;
            this.lstv_Danhsach.GridLines = true;
            this.lstv_Danhsach.HideSelection = false;
            this.lstv_Danhsach.Location = new System.Drawing.Point(12, 172);
            this.lstv_Danhsach.MultiSelect = false;
            this.lstv_Danhsach.Name = "lstv_Danhsach";
            this.lstv_Danhsach.Size = new System.Drawing.Size(754, 187);
            this.lstv_Danhsach.TabIndex = 1;
            this.lstv_Danhsach.UseCompatibleStateImageBehavior = false;
            this.lstv_Danhsach.View = System.Windows.Forms.View.Details;
            this.lstv_Danhsach.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstv_Danhsach_ItemSelectionChanged);
            this.lstv_Danhsach.SelectedIndexChanged += new System.EventHandler(this.lstv_Danhsach_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Họ tên";
            this.columnHeader1.Width = 199;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày sinh";
            this.columnHeader2.Width = 153;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quê quán";
            this.columnHeader3.Width = 408;
            // 
            // frm_VD_ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 370);
            this.Controls.Add(this.lstv_Danhsach);
            this.Controls.Add(this.grp_Input_Information);
            this.Name = "frm_VD_ListView";
            this.Text = "Thông tin cá nhân";
            this.grp_Input_Information.ResumeLayout(false);
            this.grp_Input_Information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Input_Information;
        private System.Windows.Forms.DateTimePicker dt_Ngaysinh;
        private System.Windows.Forms.TextBox txt_Quequan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Hoten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.ListView lstv_Danhsach;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

