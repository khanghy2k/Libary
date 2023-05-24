
namespace QuanLyThuVIen.GUI
{
    partial class FormQuanLyNguoiDung
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
            this.dataGridView_QuanLy = new System.Windows.Forms.DataGridView();
            this.ColMaNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinhhienthi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_TimKiem = new System.Windows.Forms.TextBox();
            this.bs_QuanLy = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QuanLy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_QuanLy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Manager";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView_QuanLy
            // 
            this.dataGridView_QuanLy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_QuanLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_QuanLy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMaNguoiDung,
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh,
            this.SoDienThoai,
            this.Email,
            this.MaChucVu,
            this.UserName,
            this.Password,
            this.GioiTinhhienthi});
            this.dataGridView_QuanLy.Location = new System.Drawing.Point(15, 164);
            this.dataGridView_QuanLy.Name = "dataGridView_QuanLy";
            this.dataGridView_QuanLy.RowHeadersWidth = 51;
            this.dataGridView_QuanLy.RowTemplate.Height = 24;
            this.dataGridView_QuanLy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_QuanLy.Size = new System.Drawing.Size(1114, 330);
            this.dataGridView_QuanLy.TabIndex = 7;
            this.dataGridView_QuanLy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_QuanLy_CellContentClick);
            // 
            // ColMaNguoiDung
            // 
            this.ColMaNguoiDung.DataPropertyName = "MaNguoiDung";
            this.ColMaNguoiDung.HeaderText = "Mã Người Dùng";
            this.ColMaNguoiDung.MinimumWidth = 6;
            this.ColMaNguoiDung.Name = "ColMaNguoiDung";
            this.ColMaNguoiDung.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColMaNguoiDung.Visible = false;
            this.ColMaNguoiDung.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 125;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Visible = false;
            this.GioiTinh.Width = 125;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số Điện Thoại";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Visible = false;
            this.Email.Width = 125;
            // 
            // MaChucVu
            // 
            this.MaChucVu.DataPropertyName = "MaChucVu";
            this.MaChucVu.HeaderText = "MaChucVu";
            this.MaChucVu.MinimumWidth = 6;
            this.MaChucVu.Name = "MaChucVu";
            this.MaChucVu.Visible = false;
            this.MaChucVu.Width = 125;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "UserName";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.Visible = false;
            this.UserName.Width = 125;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.Visible = false;
            this.Password.Width = 125;
            // 
            // GioiTinhhienthi
            // 
            this.GioiTinhhienthi.DataPropertyName = "GetGioiTinh";
            this.GioiTinhhienthi.HeaderText = "Giới Tính";
            this.GioiTinhhienthi.MinimumWidth = 6;
            this.GioiTinhhienthi.Name = "GioiTinhhienthi";
            this.GioiTinhhienthi.Width = 125;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(15, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Xem thông tin chi tiết";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_TimKiem
            // 
            this.textBox_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_TimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TimKiem.Location = new System.Drawing.Point(15, 123);
            this.textBox_TimKiem.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.textBox_TimKiem.Name = "textBox_TimKiem";
            this.textBox_TimKiem.Size = new System.Drawing.Size(553, 32);
            this.textBox_TimKiem.TabIndex = 10;
            this.textBox_TimKiem.TextChanged += new System.EventHandler(this.textBox_TimKiem_TextChanged);
            // 
            // FormQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 573);
            this.Controls.Add(this.textBox_TimKiem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_QuanLy);
            this.Controls.Add(this.label1);
            this.Name = "FormQuanLyNguoiDung";
            this.Text = "FormQuanLyNguoiDung";
            this.Load += new System.EventHandler(this.FormQuanLyNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QuanLy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_QuanLy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_QuanLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinhhienthi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_TimKiem;
        private System.Windows.Forms.BindingSource bs_QuanLy;
    }
}