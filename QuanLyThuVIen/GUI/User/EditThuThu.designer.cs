namespace QuanLyThuVIen.GUI
{
    partial class EditThuThu
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
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnBackFrEdit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtTrangThai = new System.Windows.Forms.Label();
            this.checkTrangThai = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = " Email";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam ",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(104, 157);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(121, 21);
            this.cbGioiTinh.TabIndex = 2;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(104, 99);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(207, 20);
            this.DateTimePicker.TabIndex = 3;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(104, 43);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(360, 20);
            this.txtHoTen.TabIndex = 4;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(104, 216);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(360, 20);
            this.txtSoDienThoai.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(104, 272);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(360, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // btnBackFrEdit
            // 
            this.btnBackFrEdit.Location = new System.Drawing.Point(36, 359);
            this.btnBackFrEdit.Name = "btnBackFrEdit";
            this.btnBackFrEdit.Size = new System.Drawing.Size(75, 23);
            this.btnBackFrEdit.TabIndex = 5;
            this.btnBackFrEdit.Text = "Quay lại";
            this.btnBackFrEdit.UseVisualStyleBackColor = true;
            this.btnBackFrEdit.Click += new System.EventHandler(this.btnBackFrEdit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(389, 359);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.AutoSize = true;
            this.txtTrangThai.Location = new System.Drawing.Point(34, 322);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(55, 13);
            this.txtTrangThai.TabIndex = 6;
            this.txtTrangThai.Text = "Trạng thái";
            // 
            // checkTrangThai
            // 
            this.checkTrangThai.AutoSize = true;
            this.checkTrangThai.Location = new System.Drawing.Point(104, 322);
            this.checkTrangThai.Name = "checkTrangThai";
            this.checkTrangThai.Size = new System.Drawing.Size(51, 17);
            this.checkTrangThai.TabIndex = 7;
            this.checkTrangThai.Text = "Khoá";
            this.checkTrangThai.UseVisualStyleBackColor = true;
            // 
            // EditThuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.checkTrangThai);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBackFrEdit);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.cbGioiTinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditThuThu";
            this.Text = "EditThuThu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnBackFrEdit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label txtTrangThai;
        private System.Windows.Forms.CheckBox checkTrangThai;
    }
}