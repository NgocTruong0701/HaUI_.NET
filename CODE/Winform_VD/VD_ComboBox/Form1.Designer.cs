namespace VD_ComboBox
{
    partial class Doi_mau
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
            this.lab_Tittel = new System.Windows.Forms.Label();
            this.cbo_DsColor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_Tittel
            // 
            this.lab_Tittel.AutoSize = true;
            this.lab_Tittel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Tittel.Location = new System.Drawing.Point(114, 60);
            this.lab_Tittel.Name = "lab_Tittel";
            this.lab_Tittel.Size = new System.Drawing.Size(553, 31);
            this.lab_Tittel.TabIndex = 0;
            this.lab_Tittel.Text = "Chào mừng bạn đến với website của mình";
            // 
            // cbo_DsColor
            // 
            this.cbo_DsColor.FormattingEnabled = true;
            this.cbo_DsColor.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Yellow",
            "Pink",
            "Black",
            "White"});
            this.cbo_DsColor.Location = new System.Drawing.Point(303, 186);
            this.cbo_DsColor.Name = "cbo_DsColor";
            this.cbo_DsColor.Size = new System.Drawing.Size(185, 21);
            this.cbo_DsColor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn màu";
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(245, 256);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(82, 28);
            this.btn_change.TabIndex = 3;
            this.btn_change.Text = "Đổi màu";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(406, 256);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(82, 28);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.Text = "Thoát";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Doi_mau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 371);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_DsColor);
            this.Controls.Add(this.lab_Tittel);
            this.Name = "Doi_mau";
            this.Text = "Đổi màu";
            this.Load += new System.EventHandler(this.Doi_mau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Tittel;
        private System.Windows.Forms.ComboBox cbo_DsColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_Close;
    }
}

