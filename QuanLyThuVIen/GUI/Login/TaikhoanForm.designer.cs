
namespace QuanLyThuVIen.GUI
{
    partial class TaikhoanForm
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
            this.txtHovaten = new System.Windows.Forms.TextBox();
            this.txtGioitinh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDangxuat = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtHovaten
            // 
            this.txtHovaten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHovaten.ForeColor = System.Drawing.Color.Black;
            this.txtHovaten.Location = new System.Drawing.Point(159, 141);
            this.txtHovaten.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHovaten.Name = "txtHovaten";
            this.txtHovaten.Size = new System.Drawing.Size(438, 26);
            this.txtHovaten.TabIndex = 96;
            // 
            // txtGioitinh
            // 
            this.txtGioitinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGioitinh.FormattingEnabled = true;
            this.txtGioitinh.Items.AddRange(new object[] {
            "Nam ",
            "Nữ"});
            this.txtGioitinh.Location = new System.Drawing.Point(159, 393);
            this.txtGioitinh.Margin = new System.Windows.Forms.Padding(6);
            this.txtGioitinh.Name = "txtGioitinh";
            this.txtGioitinh.Size = new System.Drawing.Size(438, 28);
            this.txtGioitinh.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 401);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 92;
            this.label3.Text = "Giới Tính : ";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtNgaySinh.Location = new System.Drawing.Point(159, 337);
            this.dtNgaySinh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(438, 26);
            this.dtNgaySinh.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 343);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 90;
            this.label1.Text = "Ngày Sinh :";
            // 
            // txtDangxuat
            // 
            this.txtDangxuat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDangxuat.BackColor = System.Drawing.Color.White;
            this.txtDangxuat.Location = new System.Drawing.Point(407, 456);
            this.txtDangxuat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDangxuat.Name = "txtDangxuat";
            this.txtDangxuat.Size = new System.Drawing.Size(190, 53);
            this.txtDangxuat.TabIndex = 89;
            this.txtDangxuat.Text = "Đăng Xuất";
            this.txtDangxuat.UseVisualStyleBackColor = false;
            this.txtDangxuat.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.Location = new System.Drawing.Point(159, 286);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(438, 26);
            this.txtPhone.TabIndex = 87;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(159, 236);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(438, 26);
            this.txtEmail.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 31);
            this.label2.TabIndex = 85;
            this.label2.Text = "Quản lý thông tin cá nhân";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 242);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 84;
            this.label6.Text = "Email: ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 292);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 83;
            this.label5.Text = "Điện thoại:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 81;
            this.label4.Text = "Họ Và Tên :";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(159, 456);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 53);
            this.button1.TabIndex = 97;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 193);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 99;
            this.label7.Text = "Chức Vụ :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtChucVu
            // 
            this.txtChucVu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtChucVu.Location = new System.Drawing.Point(159, 187);
            this.txtChucVu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.ReadOnly = true;
            this.txtChucVu.Size = new System.Drawing.Size(438, 26);
            this.txtChucVu.TabIndex = 100;
            // 
            // TaikhoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 689);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHovaten);
            this.Controls.Add(this.txtGioitinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtNgaySinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDangxuat);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TaikhoanForm";
            this.Text = "TaikhoanForm";
            this.Load += new System.EventHandler(this.TaikhoanForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHovaten;
        private System.Windows.Forms.ComboBox txtGioitinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtDangxuat;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtChucVu;
    }
}