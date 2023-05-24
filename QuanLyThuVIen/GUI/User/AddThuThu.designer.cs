namespace QuanLyThuVIen.GUI
{
    partial class AddThuThu
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.btnBackFrAdd = new System.Windows.Forms.Button();
            this.btnAddFrAdd = new System.Windows.Forms.Button();
            this.NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkTrangThai = new System.Windows.Forms.CheckBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";
            this.label1.Click += new System.EventHandler(this.HoTen_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày Sinh";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giới tính";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số điện thoại";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "UserName";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHoTen.Location = new System.Drawing.Point(109, 18);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(271, 20);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.TextChanged += new System.EventHandler(this.HoTen_TextChanged);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoDienThoai.Location = new System.Drawing.Point(109, 144);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(271, 20);
            this.txtSoDienThoai.TabIndex = 1;
            this.txtSoDienThoai.TextChanged += new System.EventHandler(this.SoDienThoai_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(109, 186);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(271, 20);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(109, 102);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(121, 21);
            this.cbGioiTinh.TabIndex = 2;
            this.cbGioiTinh.SelectedIndexChanged += new System.EventHandler(this.GioiTinh_SelectedIndexChanged);
            // 
            // btnBackFrAdd
            // 
            this.btnBackFrAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackFrAdd.Location = new System.Drawing.Point(21, 359);
            this.btnBackFrAdd.Name = "btnBackFrAdd";
            this.btnBackFrAdd.Size = new System.Drawing.Size(75, 23);
            this.btnBackFrAdd.TabIndex = 3;
            this.btnBackFrAdd.Text = "Quay lại";
            this.btnBackFrAdd.UseVisualStyleBackColor = true;
            this.btnBackFrAdd.Click += new System.EventHandler(this.btnBackFrAdd_Click);
            // 
            // btnAddFrAdd
            // 
            this.btnAddFrAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddFrAdd.Location = new System.Drawing.Point(353, 359);
            this.btnAddFrAdd.Name = "btnAddFrAdd";
            this.btnAddFrAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAddFrAdd.TabIndex = 4;
            this.btnAddFrAdd.Text = "Thêm";
            this.btnAddFrAdd.UseVisualStyleBackColor = true;
            this.btnAddFrAdd.Click += new System.EventHandler(this.buttonAddFrAdd_Click);
            // 
            // NgaySinh
            // 
            this.NgaySinh.Location = new System.Drawing.Point(109, 60);
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Size = new System.Drawing.Size(200, 20);
            this.NgaySinh.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Trạng thái";
            this.label7.Click += new System.EventHandler(this.label5_Click);
            // 
            // checkTrangThai
            // 
            this.checkTrangThai.AutoSize = true;
            this.checkTrangThai.Location = new System.Drawing.Point(109, 313);
            this.checkTrangThai.Name = "checkTrangThai";
            this.checkTrangThai.Size = new System.Drawing.Size(51, 17);
            this.checkTrangThai.TabIndex = 6;
            this.checkTrangThai.Text = "Khoá";
            this.checkTrangThai.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserName.Location = new System.Drawing.Point(109, 227);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(271, 20);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(109, 267);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(271, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Password";
            this.label8.Click += new System.EventHandler(this.label5_Click);
            // 
            // AddThuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 405);
            this.Controls.Add(this.checkTrangThai);
            this.Controls.Add(this.NgaySinh);
            this.Controls.Add(this.btnAddFrAdd);
            this.Controls.Add(this.btnBackFrAdd);
            this.Controls.Add(this.cbGioiTinh);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddThuThu";
            this.Text = "AddThuThu";
            this.Load += new System.EventHandler(this.AddThuThu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Button btnBackFrAdd;
        private System.Windows.Forms.Button btnAddFrAdd;
        private System.Windows.Forms.DateTimePicker NgaySinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkTrangThai;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label8;
    }
}