namespace VD_ComboandListBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lst_Danhsach = new System.Windows.Forms.ListBox();
            this.btn_Input = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CountDS = new System.Windows.Forms.TextBox();
            this.btn_RemoveAt = new System.Windows.Forms.Button();
            this.btn_RemoveF = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_RemoveL = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 69);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(248, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khai báo y tế điện tử";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.btn_Input);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(276, 309);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(66, 71);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(202, 24);
            this.txt_Name.TabIndex = 1;
            // 
            // lst_Danhsach
            // 
            this.lst_Danhsach.FormattingEnabled = true;
            this.lst_Danhsach.ItemHeight = 18;
            this.lst_Danhsach.Location = new System.Drawing.Point(283, 75);
            this.lst_Danhsach.Name = "lst_Danhsach";
            this.lst_Danhsach.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_Danhsach.Size = new System.Drawing.Size(409, 166);
            this.lst_Danhsach.TabIndex = 2;
            // 
            // btn_Input
            // 
            this.btn_Input.Location = new System.Drawing.Point(85, 102);
            this.btn_Input.Name = "btn_Input";
            this.btn_Input.Size = new System.Drawing.Size(155, 41);
            this.btn_Input.TabIndex = 2;
            this.btn_Input.Text = "Nhập thông tin";
            this.btn_Input.UseVisualStyleBackColor = true;
            this.btn_Input.Click += new System.EventHandler(this.btn_Input_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tổng số người đã khai báo";
            // 
            // txt_CountDS
            // 
            this.txt_CountDS.Location = new System.Drawing.Point(485, 255);
            this.txt_CountDS.Name = "txt_CountDS";
            this.txt_CountDS.Size = new System.Drawing.Size(109, 24);
            this.txt_CountDS.TabIndex = 4;
            this.txt_CountDS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_RemoveAt
            // 
            this.btn_RemoveAt.Location = new System.Drawing.Point(298, 293);
            this.btn_RemoveAt.Name = "btn_RemoveAt";
            this.btn_RemoveAt.Size = new System.Drawing.Size(178, 29);
            this.btn_RemoveAt.TabIndex = 5;
            this.btn_RemoveAt.Text = "Xóa thông tin đang chọn";
            this.btn_RemoveAt.UseVisualStyleBackColor = true;
            this.btn_RemoveAt.Click += new System.EventHandler(this.btn_RemoveAt_Click);
            // 
            // btn_RemoveF
            // 
            this.btn_RemoveF.Location = new System.Drawing.Point(514, 293);
            this.btn_RemoveF.Name = "btn_RemoveF";
            this.btn_RemoveF.Size = new System.Drawing.Size(178, 29);
            this.btn_RemoveF.TabIndex = 6;
            this.btn_RemoveF.Text = "Xóa thông tin đầu";
            this.btn_RemoveF.UseVisualStyleBackColor = true;
            this.btn_RemoveF.Click += new System.EventHandler(this.btn_RemoveF_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(298, 336);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(178, 29);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "Xóa tất cả thông tin";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_RemoveL
            // 
            this.btn_RemoveL.Location = new System.Drawing.Point(514, 336);
            this.btn_RemoveL.Name = "btn_RemoveL";
            this.btn_RemoveL.Size = new System.Drawing.Size(178, 29);
            this.btn_RemoveL.TabIndex = 8;
            this.btn_RemoveL.Text = "Xóa thông tin cuối";
            this.btn_RemoveL.UseVisualStyleBackColor = true;
            this.btn_RemoveL.Click += new System.EventHandler(this.btn_RemoveL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(704, 377);
            this.Controls.Add(this.btn_RemoveL);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_RemoveF);
            this.Controls.Add(this.btn_RemoveAt);
            this.Controls.Add(this.txt_CountDS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lst_Danhsach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Input;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_Danhsach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CountDS;
        private System.Windows.Forms.Button btn_RemoveAt;
        private System.Windows.Forms.Button btn_RemoveF;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_RemoveL;
    }
}

