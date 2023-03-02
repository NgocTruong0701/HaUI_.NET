namespace Bai_1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbtn_Nu = new System.Windows.Forms.RadioButton();
            this.rdbtn_Nam = new System.Windows.Forms.RadioButton();
            this.txt_Slb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateNgayTD = new System.Windows.Forms.DateTimePicker();
            this.cbo_Phongban = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Hoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_DSNV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Form2 = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lst_DSNV);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 327);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.txt_Slb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateNgayTD);
            this.groupBox1.Controls.Add(this.cbo_Phongban);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Hoten);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 183);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbtn_Nu);
            this.panel2.Controls.Add(this.rdbtn_Nam);
            this.panel2.Location = new System.Drawing.Point(137, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 19);
            this.panel2.TabIndex = 15;
            // 
            // rdbtn_Nu
            // 
            this.rdbtn_Nu.AutoSize = true;
            this.rdbtn_Nu.Location = new System.Drawing.Point(56, 1);
            this.rdbtn_Nu.Name = "rdbtn_Nu";
            this.rdbtn_Nu.Size = new System.Drawing.Size(39, 17);
            this.rdbtn_Nu.TabIndex = 14;
            this.rdbtn_Nu.TabStop = true;
            this.rdbtn_Nu.Text = "Nữ";
            this.rdbtn_Nu.UseVisualStyleBackColor = true;
            // 
            // rdbtn_Nam
            // 
            this.rdbtn_Nam.AutoSize = true;
            this.rdbtn_Nam.Location = new System.Drawing.Point(3, 1);
            this.rdbtn_Nam.Name = "rdbtn_Nam";
            this.rdbtn_Nam.Size = new System.Drawing.Size(47, 17);
            this.rdbtn_Nam.TabIndex = 13;
            this.rdbtn_Nam.TabStop = true;
            this.rdbtn_Nam.Text = "Nam";
            this.rdbtn_Nam.UseVisualStyleBackColor = true;
            // 
            // txt_Slb
            // 
            this.txt_Slb.Location = new System.Drawing.Point(137, 158);
            this.txt_Slb.Name = "txt_Slb";
            this.txt_Slb.Size = new System.Drawing.Size(93, 20);
            this.txt_Slb.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Số lượng bán";
            // 
            // dateNgayTD
            // 
            this.dateNgayTD.Location = new System.Drawing.Point(138, 107);
            this.dateNgayTD.Name = "dateNgayTD";
            this.dateNgayTD.Size = new System.Drawing.Size(200, 20);
            this.dateNgayTD.TabIndex = 10;
            // 
            // cbo_Phongban
            // 
            this.cbo_Phongban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Phongban.FormattingEnabled = true;
            this.cbo_Phongban.Location = new System.Drawing.Point(138, 79);
            this.cbo_Phongban.Name = "cbo_Phongban";
            this.cbo_Phongban.Size = new System.Drawing.Size(132, 21);
            this.cbo_Phongban.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày tuyển dụng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phòng ban";
            // 
            // txt_Hoten
            // 
            this.txt_Hoten.Location = new System.Drawing.Point(138, 54);
            this.txt_Hoten.Name = "txt_Hoten";
            this.txt_Hoten.Size = new System.Drawing.Size(201, 20);
            this.txt_Hoten.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(256, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý nhân viên";
            // 
            // lst_DSNV
            // 
            this.lst_DSNV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lst_DSNV.FullRowSelect = true;
            this.lst_DSNV.GridLines = true;
            this.lst_DSNV.HideSelection = false;
            this.lst_DSNV.Location = new System.Drawing.Point(27, 193);
            this.lst_DSNV.MultiSelect = false;
            this.lst_DSNV.Name = "lst_DSNV";
            this.lst_DSNV.Size = new System.Drawing.Size(687, 121);
            this.lst_DSNV.TabIndex = 1;
            this.lst_DSNV.UseCompatibleStateImageBehavior = false;
            this.lst_DSNV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Họ tên";
            this.columnHeader1.Width = 166;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Phòng ban";
            this.columnHeader2.Width = 137;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày tuyển dụng";
            this.columnHeader3.Width = 151;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giới tính";
            this.columnHeader4.Width = 108;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số lượng bán";
            this.columnHeader5.Width = 118;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(146, 365);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(94, 26);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Nhập";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Form2
            // 
            this.btn_Form2.Location = new System.Drawing.Point(463, 365);
            this.btn_Form2.Name = "btn_Form2";
            this.btn_Form2.Size = new System.Drawing.Size(94, 26);
            this.btn_Form2.TabIndex = 2;
            this.btn_Form2.Text = "Window 2";
            this.btn_Form2.UseVisualStyleBackColor = true;
            this.btn_Form2.Click += new System.EventHandler(this.btn_Form2_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(316, 365);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(94, 26);
            this.btn_Remove.TabIndex = 2;
            this.btn_Remove.Text = "Xóa";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 422);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Form2);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Bài kiểm tra số 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Hoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lst_DSNV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.DateTimePicker dateNgayTD;
        private System.Windows.Forms.ComboBox cbo_Phongban;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Form2;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.TextBox txt_Slb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbtn_Nu;
        private System.Windows.Forms.RadioButton rdbtn_Nam;
    }
}

