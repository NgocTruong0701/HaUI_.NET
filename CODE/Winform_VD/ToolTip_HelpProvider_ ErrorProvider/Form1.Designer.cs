namespace ToolTip_HelpProvider__ErrorProvider
{
    partial class frm_DangNhap
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_DangNhap = new System.Windows.Forms.GroupBox();
            this.btn_Exist = new System.Windows.Forms.Button();
            this.btn_DN = new System.Windows.Forms.Button();
            this.chk_ShowMK = new System.Windows.Forms.CheckBox();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenDN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.grp_DangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::ToolTip_HelpProvider__ErrorProvider.Properties.Resources._7ceceea557890bf26cfef35cf891cc08;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.label1.MinimumSize = new System.Drawing.Size(200, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 300);
            this.label1.TabIndex = 0;
            // 
            // grp_DangNhap
            // 
            this.grp_DangNhap.Controls.Add(this.btn_Exist);
            this.grp_DangNhap.Controls.Add(this.btn_DN);
            this.grp_DangNhap.Controls.Add(this.chk_ShowMK);
            this.grp_DangNhap.Controls.Add(this.txt_MK);
            this.grp_DangNhap.Controls.Add(this.label4);
            this.grp_DangNhap.Controls.Add(this.txt_TenDN);
            this.grp_DangNhap.Controls.Add(this.label3);
            this.grp_DangNhap.Controls.Add(this.label2);
            this.grp_DangNhap.Location = new System.Drawing.Point(311, 37);
            this.grp_DangNhap.Name = "grp_DangNhap";
            this.grp_DangNhap.Size = new System.Drawing.Size(427, 284);
            this.grp_DangNhap.TabIndex = 1;
            this.grp_DangNhap.TabStop = false;
            this.grp_DangNhap.Text = "Nhập thông tin";
            // 
            // btn_Exist
            // 
            this.btn_Exist.Location = new System.Drawing.Point(258, 221);
            this.btn_Exist.Name = "btn_Exist";
            this.btn_Exist.Size = new System.Drawing.Size(107, 34);
            this.btn_Exist.TabIndex = 7;
            this.btn_Exist.Text = "Thoát";
            this.btn_Exist.UseVisualStyleBackColor = true;
            this.btn_Exist.Click += new System.EventHandler(this.btn_Exist_Click);
            // 
            // btn_DN
            // 
            this.btn_DN.Location = new System.Drawing.Point(82, 221);
            this.btn_DN.Name = "btn_DN";
            this.btn_DN.Size = new System.Drawing.Size(107, 34);
            this.btn_DN.TabIndex = 6;
            this.btn_DN.Text = "Đăng nhập";
            this.btn_DN.UseVisualStyleBackColor = true;
            this.btn_DN.Click += new System.EventHandler(this.btn_DN_Click);
            // 
            // chk_ShowMK
            // 
            this.chk_ShowMK.AutoSize = true;
            this.chk_ShowMK.Location = new System.Drawing.Point(131, 180);
            this.chk_ShowMK.Name = "chk_ShowMK";
            this.chk_ShowMK.Size = new System.Drawing.Size(109, 17);
            this.chk_ShowMK.TabIndex = 5;
            this.chk_ShowMK.Text = "Hiển thị mật khẩu";
            this.chk_ShowMK.UseVisualStyleBackColor = true;
            this.chk_ShowMK.CheckedChanged += new System.EventHandler(this.chk_ShowMK_CheckedChanged);
            // 
            // txt_MK
            // 
            this.txt_MK.Location = new System.Drawing.Point(131, 137);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.PasswordChar = '*';
            this.txt_MK.Size = new System.Drawing.Size(243, 20);
            this.txt_MK.TabIndex = 4;
            this.txt_MK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MK_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu";
            // 
            // txt_TenDN
            // 
            this.txt_TenDN.Location = new System.Drawing.Point(131, 87);
            this.txt_TenDN.Name = "txt_TenDN";
            this.txt_TenDN.Size = new System.Drawing.Size(243, 20);
            this.txt_TenDN.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cửa sổ đăng nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(447, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ấn F1 để được hướng dẫn";
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 100;
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 100;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 20;
            this.toolTip.ToolTipTitle = "Thông báo nhập";
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 371);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grp_DangNhap);
            this.Controls.Add(this.label1);
            this.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.Name = "frm_DangNhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frm_DangNhap_Load);
            this.grp_DangNhap.ResumeLayout(false);
            this.grp_DangNhap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_DangNhap;
        private System.Windows.Forms.TextBox txt_MK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TenDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Exist;
        private System.Windows.Forms.Button btn_DN;
        private System.Windows.Forms.CheckBox chk_ShowMK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

