namespace VD_CheckandGroupBox
{
    partial class frms_Check_Group_Box
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.group_Gioitinh = new System.Windows.Forms.GroupBox();
            this.rdo_Nu = new System.Windows.Forms.RadioButton();
            this.rdo_Nam = new System.Windows.Forms.RadioButton();
            this.group_TTHN = new System.Windows.Forms.GroupBox();
            this.rdo_da = new System.Windows.Forms.RadioButton();
            this.rdo_chua = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_bongda = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_boiloi = new System.Windows.Forms.CheckBox();
            this.chk_amnhac = new System.Windows.Forms.CheckBox();
            this.chk_leonui = new System.Windows.Forms.CheckBox();
            this.lst_danhsach = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.group_Gioitinh.SuspendLayout();
            this.group_TTHN.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(74, 22);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(249, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // group_Gioitinh
            // 
            this.group_Gioitinh.Controls.Add(this.rdo_Nu);
            this.group_Gioitinh.Controls.Add(this.rdo_Nam);
            this.group_Gioitinh.Location = new System.Drawing.Point(32, 126);
            this.group_Gioitinh.Name = "group_Gioitinh";
            this.group_Gioitinh.Size = new System.Drawing.Size(291, 73);
            this.group_Gioitinh.TabIndex = 2;
            this.group_Gioitinh.TabStop = false;
            this.group_Gioitinh.Text = "Giới tính";
            // 
            // rdo_Nu
            // 
            this.rdo_Nu.AutoSize = true;
            this.rdo_Nu.Location = new System.Drawing.Point(6, 42);
            this.rdo_Nu.Name = "rdo_Nu";
            this.rdo_Nu.Size = new System.Drawing.Size(39, 17);
            this.rdo_Nu.TabIndex = 1;
            this.rdo_Nu.TabStop = true;
            this.rdo_Nu.Text = "Nữ";
            this.rdo_Nu.UseVisualStyleBackColor = true;
            // 
            // rdo_Nam
            // 
            this.rdo_Nam.AutoSize = true;
            this.rdo_Nam.Location = new System.Drawing.Point(6, 19);
            this.rdo_Nam.Name = "rdo_Nam";
            this.rdo_Nam.Size = new System.Drawing.Size(47, 17);
            this.rdo_Nam.TabIndex = 0;
            this.rdo_Nam.TabStop = true;
            this.rdo_Nam.Text = "Nam";
            this.rdo_Nam.UseVisualStyleBackColor = true;
            // 
            // group_TTHN
            // 
            this.group_TTHN.Controls.Add(this.rdo_da);
            this.group_TTHN.Controls.Add(this.rdo_chua);
            this.group_TTHN.Location = new System.Drawing.Point(32, 48);
            this.group_TTHN.Name = "group_TTHN";
            this.group_TTHN.Size = new System.Drawing.Size(291, 72);
            this.group_TTHN.TabIndex = 3;
            this.group_TTHN.TabStop = false;
            this.group_TTHN.Text = "Tình trạng hôn nhân";
            // 
            // rdo_da
            // 
            this.rdo_da.AutoSize = true;
            this.rdo_da.Location = new System.Drawing.Point(7, 44);
            this.rdo_da.Name = "rdo_da";
            this.rdo_da.Size = new System.Drawing.Size(78, 17);
            this.rdo_da.TabIndex = 1;
            this.rdo_da.TabStop = true;
            this.rdo_da.Text = "Đã kết hôn";
            this.rdo_da.UseVisualStyleBackColor = true;
            // 
            // rdo_chua
            // 
            this.rdo_chua.AutoSize = true;
            this.rdo_chua.Location = new System.Drawing.Point(7, 20);
            this.rdo_chua.Name = "rdo_chua";
            this.rdo_chua.Size = new System.Drawing.Size(89, 17);
            this.rdo_chua.TabIndex = 0;
            this.rdo_chua.TabStop = true;
            this.rdo_chua.Text = "Chưa kết hôn";
            this.rdo_chua.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lst_danhsach);
            this.panel1.Controls.Add(this.chk_leonui);
            this.panel1.Controls.Add(this.chk_amnhac);
            this.panel1.Controls.Add(this.chk_boiloi);
            this.panel1.Controls.Add(this.chk_bongda);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.group_TTHN);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.group_Gioitinh);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 313);
            this.panel1.TabIndex = 4;
            // 
            // chk_bongda
            // 
            this.chk_bongda.AutoSize = true;
            this.chk_bongda.Location = new System.Drawing.Point(35, 222);
            this.chk_bongda.Name = "chk_bongda";
            this.chk_bongda.Size = new System.Drawing.Size(67, 17);
            this.chk_bongda.TabIndex = 5;
            this.chk_bongda.Text = "Bóng đá";
            this.chk_bongda.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sở thích";
            // 
            // chk_boiloi
            // 
            this.chk_boiloi.AutoSize = true;
            this.chk_boiloi.Location = new System.Drawing.Point(35, 245);
            this.chk_boiloi.Name = "chk_boiloi";
            this.chk_boiloi.Size = new System.Drawing.Size(54, 17);
            this.chk_boiloi.TabIndex = 6;
            this.chk_boiloi.Text = "Bơi lội";
            this.chk_boiloi.UseVisualStyleBackColor = true;
            // 
            // chk_amnhac
            // 
            this.chk_amnhac.AutoSize = true;
            this.chk_amnhac.Location = new System.Drawing.Point(35, 268);
            this.chk_amnhac.Name = "chk_amnhac";
            this.chk_amnhac.Size = new System.Drawing.Size(68, 17);
            this.chk_amnhac.TabIndex = 7;
            this.chk_amnhac.Text = "Âm nhạc";
            this.chk_amnhac.UseVisualStyleBackColor = true;
            // 
            // chk_leonui
            // 
            this.chk_leonui.AutoSize = true;
            this.chk_leonui.Location = new System.Drawing.Point(35, 291);
            this.chk_leonui.Name = "chk_leonui";
            this.chk_leonui.Size = new System.Drawing.Size(61, 17);
            this.chk_leonui.TabIndex = 8;
            this.chk_leonui.Text = "Leo núi";
            this.chk_leonui.UseVisualStyleBackColor = true;
            // 
            // lst_danhsach
            // 
            this.lst_danhsach.FormattingEnabled = true;
            this.lst_danhsach.Location = new System.Drawing.Point(384, 22);
            this.lst_danhsach.Name = "lst_danhsach";
            this.lst_danhsach.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_danhsach.Size = new System.Drawing.Size(324, 277);
            this.lst_danhsach.TabIndex = 9;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(599, 335);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(680, 335);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "Thoát";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // frms_Check_Group_Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 370);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.panel1);
            this.Name = "frms_Check_Group_Box";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật thành viên";
            this.group_Gioitinh.ResumeLayout(false);
            this.group_Gioitinh.PerformLayout();
            this.group_TTHN.ResumeLayout(false);
            this.group_TTHN.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.GroupBox group_Gioitinh;
        private System.Windows.Forms.RadioButton rdo_Nu;
        private System.Windows.Forms.RadioButton rdo_Nam;
        private System.Windows.Forms.GroupBox group_TTHN;
        private System.Windows.Forms.RadioButton rdo_da;
        private System.Windows.Forms.RadioButton rdo_chua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chk_bongda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_danhsach;
        private System.Windows.Forms.CheckBox chk_leonui;
        private System.Windows.Forms.CheckBox chk_amnhac;
        private System.Windows.Forms.CheckBox chk_boiloi;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_close;
    }
}

