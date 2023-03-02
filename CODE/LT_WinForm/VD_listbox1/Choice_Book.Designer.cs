namespace VD_listbox1
{
    partial class Form_List_Box
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
            this.label2 = new System.Windows.Forms.Label();
            this.lst_DS = new System.Windows.Forms.ListBox();
            this.lst_SC = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_chon1 = new System.Windows.Forms.Button();
            this.btn_chonn = new System.Windows.Forms.Button();
            this.btn_xoa1 = new System.Windows.Forms.Button();
            this.btn_xoan = new System.Windows.Forms.Button();
            this.btn_chon1s = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách";
            // 
            // lst_DS
            // 
            this.lst_DS.FormattingEnabled = true;
            this.lst_DS.ItemHeight = 19;
            this.lst_DS.Items.AddRange(new object[] {
            "Lê Ngọc Trường"});
            this.lst_DS.Location = new System.Drawing.Point(59, 51);
            this.lst_DS.Name = "lst_DS";
            this.lst_DS.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_DS.Size = new System.Drawing.Size(244, 270);
            this.lst_DS.Sorted = true;
            this.lst_DS.TabIndex = 2;
            // 
            // lst_SC
            // 
            this.lst_SC.FormattingEnabled = true;
            this.lst_SC.ItemHeight = 19;
            this.lst_SC.Location = new System.Drawing.Point(390, 51);
            this.lst_SC.Name = "lst_SC";
            this.lst_SC.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_SC.Size = new System.Drawing.Size(234, 270);
            this.lst_SC.Sorted = true;
            this.lst_SC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sách đã chọn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 3;
            // 
            // btn_chon1
            // 
            this.btn_chon1.Location = new System.Drawing.Point(309, 65);
            this.btn_chon1.Name = "btn_chon1";
            this.btn_chon1.Size = new System.Drawing.Size(75, 23);
            this.btn_chon1.TabIndex = 6;
            this.btn_chon1.Text = ">";
            this.btn_chon1.UseVisualStyleBackColor = true;
            this.btn_chon1.Click += new System.EventHandler(this.btn_chon1_Click);
            // 
            // btn_chonn
            // 
            this.btn_chonn.Location = new System.Drawing.Point(309, 123);
            this.btn_chonn.Name = "btn_chonn";
            this.btn_chonn.Size = new System.Drawing.Size(75, 23);
            this.btn_chonn.TabIndex = 7;
            this.btn_chonn.Text = ">>>";
            this.btn_chonn.UseVisualStyleBackColor = true;
            this.btn_chonn.Click += new System.EventHandler(this.btn_chonn_Click);
            // 
            // btn_xoa1
            // 
            this.btn_xoa1.Location = new System.Drawing.Point(309, 217);
            this.btn_xoa1.Name = "btn_xoa1";
            this.btn_xoa1.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa1.TabIndex = 8;
            this.btn_xoa1.Text = "<";
            this.btn_xoa1.UseVisualStyleBackColor = true;
            this.btn_xoa1.Click += new System.EventHandler(this.btn_xoa1_Click);
            // 
            // btn_xoan
            // 
            this.btn_xoan.Location = new System.Drawing.Point(309, 246);
            this.btn_xoan.Name = "btn_xoan";
            this.btn_xoan.Size = new System.Drawing.Size(75, 28);
            this.btn_xoan.TabIndex = 9;
            this.btn_xoan.Text = "<<";
            this.btn_xoan.UseVisualStyleBackColor = true;
            this.btn_xoan.Click += new System.EventHandler(this.btn_xoan_Click);
            // 
            // btn_chon1s
            // 
            this.btn_chon1s.Location = new System.Drawing.Point(309, 94);
            this.btn_chon1s.Name = "btn_chon1s";
            this.btn_chon1s.Size = new System.Drawing.Size(75, 23);
            this.btn_chon1s.TabIndex = 10;
            this.btn_chon1s.Text = ">>";
            this.btn_chon1s.UseVisualStyleBackColor = true;
            this.btn_chon1s.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "<<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_List_Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 348);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_chon1s);
            this.Controls.Add(this.btn_xoan);
            this.Controls.Add(this.btn_xoa1);
            this.Controls.Add(this.btn_chonn);
            this.Controls.Add(this.btn_chon1);
            this.Controls.Add(this.lst_SC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lst_DS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_List_Box";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn Sách";
            this.Load += new System.EventHandler(this.Form_List_Box_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_DS;
        private System.Windows.Forms.ListBox lst_SC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_chon1;
        private System.Windows.Forms.Button btn_chonn;
        private System.Windows.Forms.Button btn_xoa1;
        private System.Windows.Forms.Button btn_xoan;
        private System.Windows.Forms.Button btn_chon1s;
        private System.Windows.Forms.Button button2;
    }
}

