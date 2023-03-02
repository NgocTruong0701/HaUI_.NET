namespace KT_Bai7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_SoN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_LuongN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lstView_DSVN = new System.Windows.Forms.ListView();
            this.MaNV = new System.Windows.Forms.ColumnHeader();
            this.NameNV = new System.Windows.Forms.ColumnHeader();
            this.LuongN = new System.Windows.Forms.ColumnHeader();
            this.SoN = new System.Windows.Forms.ColumnHeader();
            this.Salary = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_SoN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_LuongN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(58, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // txt_SoN
            // 
            this.txt_SoN.Location = new System.Drawing.Point(127, 114);
            this.txt_SoN.Name = "txt_SoN";
            this.txt_SoN.Size = new System.Drawing.Size(308, 23);
            this.txt_SoN.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số ngày làm việc";
            // 
            // txt_LuongN
            // 
            this.txt_LuongN.Location = new System.Drawing.Point(127, 85);
            this.txt_LuongN.Name = "txt_LuongN";
            this.txt_LuongN.Size = new System.Drawing.Size(308, 23);
            this.txt_LuongN.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tiền lương ngày";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(127, 56);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(308, 23);
            this.txt_Name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(127, 27);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(308, 23);
            this.txt_ID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(602, 40);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(105, 32);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(602, 78);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(105, 32);
            this.btn_Show.TabIndex = 2;
            this.btn_Show.Text = "Hiển thị";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(602, 115);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(105, 32);
            this.btn_Remove.TabIndex = 3;
            this.btn_Remove.Text = "Xóa";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(602, 158);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(105, 32);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lstView_DSVN
            // 
            this.lstView_DSVN.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaNV,
            this.NameNV,
            this.LuongN,
            this.SoN,
            this.Salary});
            this.lstView_DSVN.FullRowSelect = true;
            this.lstView_DSVN.GridLines = true;
            this.lstView_DSVN.HideSelection = false;
            this.lstView_DSVN.Location = new System.Drawing.Point(53, 197);
            this.lstView_DSVN.MultiSelect = false;
            this.lstView_DSVN.Name = "lstView_DSVN";
            this.lstView_DSVN.Size = new System.Drawing.Size(654, 126);
            this.lstView_DSVN.TabIndex = 5;
            this.lstView_DSVN.UseCompatibleStateImageBehavior = false;
            this.lstView_DSVN.View = System.Windows.Forms.View.Details;
            this.lstView_DSVN.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstView_DSVN_ItemSelectionChanged);
            // 
            // MaNV
            // 
            this.MaNV.Text = "Mã NV";
            // 
            // NameNV
            // 
            this.NameNV.Text = "Họ tên";
            // 
            // LuongN
            // 
            this.LuongN.Text = "Lương ngày";
            // 
            // SoN
            // 
            this.SoN.Text = "Số ngày";
            // 
            // Salary
            // 
            this.Salary.Text = "Tiền lương";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 323);
            this.Controls.Add(this.lstView_DSVN);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Quản lý nhân viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_SoN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_LuongN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ListView lstView_DSVN;
        private System.Windows.Forms.ColumnHeader MaNV;
        private System.Windows.Forms.ColumnHeader NameNV;
        private System.Windows.Forms.ColumnHeader LuongN;
        private System.Windows.Forms.ColumnHeader SoN;
        private System.Windows.Forms.ColumnHeader Salary;
    }
}
