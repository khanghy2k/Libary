namespace QuanLyThuVIen.GUI
{
    partial class BookManagerForm
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
            this.gridSach = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureSach = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTacGia = new System.Windows.Forms.ListBox();
            this.btnEditTacGia = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLoaiSach = new System.Windows.Forms.ComboBox();
            this.cbNXB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbNgonNgu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGiaBia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNamXuatBan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTaiBan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnChangePhoto = new System.Windows.Forms.Button();
            this.bsSach = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSach)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSach
            // 
            this.gridSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.NhaXuatBan});
            this.gridSach.Location = new System.Drawing.Point(6, 78);
            this.gridSach.Margin = new System.Windows.Forms.Padding(2);
            this.gridSach.Name = "gridSach";
            this.gridSach.RowHeadersWidth = 51;
            this.gridSach.RowTemplate.Height = 24;
            this.gridSach.Size = new System.Drawing.Size(685, 572);
            this.gridSach.TabIndex = 3;
            this.gridSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSach_CellContentClick);
            this.gridSach.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridSach_CellMouseClick);
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            this.MaSach.Visible = false;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            // 
            // NhaXuatBan
            // 
            this.NhaXuatBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NhaXuatBan.DataPropertyName = "TenNhaXuatBan";
            this.NhaXuatBan.HeaderText = "Nhà xuất bản";
            this.NhaXuatBan.MinimumWidth = 6;
            this.NhaXuatBan.Name = "NhaXuatBan";
            this.NhaXuatBan.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(714, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "THÔNG TIN";
            // 
            // pictureSach
            // 
            this.pictureSach.Location = new System.Drawing.Point(706, 78);
            this.pictureSach.Margin = new System.Windows.Forms.Padding(2);
            this.pictureSach.Name = "pictureSach";
            this.pictureSach.Size = new System.Drawing.Size(157, 195);
            this.pictureSach.TabIndex = 5;
            this.pictureSach.TabStop = false;
            this.pictureSach.Click += new System.EventHandler(this.pictureSach_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(873, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên sách:";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(955, 78);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(282, 26);
            this.txtTenSach.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(887, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tác giả:";
            // 
            // lbTacGia
            // 
            this.lbTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTacGia.FormattingEnabled = true;
            this.lbTacGia.ItemHeight = 20;
            this.lbTacGia.Location = new System.Drawing.Point(955, 117);
            this.lbTacGia.Margin = new System.Windows.Forms.Padding(2);
            this.lbTacGia.Name = "lbTacGia";
            this.lbTacGia.Size = new System.Drawing.Size(282, 124);
            this.lbTacGia.TabIndex = 9;
            // 
            // btnEditTacGia
            // 
            this.btnEditTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTacGia.Location = new System.Drawing.Point(1167, 245);
            this.btnEditTacGia.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditTacGia.Name = "btnEditTacGia";
            this.btnEditTacGia.Size = new System.Drawing.Size(70, 32);
            this.btnEditTacGia.TabIndex = 10;
            this.btnEditTacGia.Text = "Sửa";
            this.btnEditTacGia.UseVisualStyleBackColor = true;
            this.btnEditTacGia.Click += new System.EventHandler(this.btnEditTacGia_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(750, 343);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Loại sách:";
            // 
            // cbLoaiSach
            // 
            this.cbLoaiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiSach.FormattingEnabled = true;
            this.cbLoaiSach.Location = new System.Drawing.Point(845, 343);
            this.cbLoaiSach.Margin = new System.Windows.Forms.Padding(2);
            this.cbLoaiSach.Name = "cbLoaiSach";
            this.cbLoaiSach.Size = new System.Drawing.Size(185, 28);
            this.cbLoaiSach.TabIndex = 12;
            this.cbLoaiSach.SelectedIndexChanged += new System.EventHandler(this.cbLoaiSach_SelectedIndexChanged);
            // 
            // cbNXB
            // 
            this.cbNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNXB.FormattingEnabled = true;
            this.cbNXB.Location = new System.Drawing.Point(845, 384);
            this.cbNXB.Margin = new System.Windows.Forms.Padding(2);
            this.cbNXB.Name = "cbNXB";
            this.cbNXB.Size = new System.Drawing.Size(185, 28);
            this.cbNXB.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(724, 384);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nhà xuất bản:";
            // 
            // cbNgonNgu
            // 
            this.cbNgonNgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNgonNgu.FormattingEnabled = true;
            this.cbNgonNgu.Location = new System.Drawing.Point(845, 436);
            this.cbNgonNgu.Margin = new System.Windows.Forms.Padding(2);
            this.cbNgonNgu.Name = "cbNgonNgu";
            this.cbNgonNgu.Size = new System.Drawing.Size(185, 28);
            this.cbNgonNgu.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(750, 439);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ngôn ngữ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1071, 343);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Giá bìa:";
            // 
            // txtGiaBia
            // 
            this.txtGiaBia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBia.Location = new System.Drawing.Point(1154, 340);
            this.txtGiaBia.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiaBia.Name = "txtGiaBia";
            this.txtGiaBia.Size = new System.Drawing.Size(182, 26);
            this.txtGiaBia.TabIndex = 18;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(1154, 384);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(182, 26);
            this.txtSoLuong.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1058, 384);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Số lượng:";
            // 
            // txtNamXuatBan
            // 
            this.txtNamXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamXuatBan.Location = new System.Drawing.Point(1154, 297);
            this.txtNamXuatBan.Margin = new System.Windows.Forms.Padding(2);
            this.txtNamXuatBan.Name = "txtNamXuatBan";
            this.txtNamXuatBan.Size = new System.Drawing.Size(182, 26);
            this.txtNamXuatBan.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1043, 302);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Năm xuất bản:";
            // 
            // txtTaiBan
            // 
            this.txtTaiBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiBan.Location = new System.Drawing.Point(1154, 433);
            this.txtTaiBan.Margin = new System.Windows.Forms.Padding(2);
            this.txtTaiBan.Name = "txtTaiBan";
            this.txtTaiBan.Size = new System.Drawing.Size(182, 26);
            this.txtTaiBan.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1034, 439);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Tái bản lần thứ:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(766, 499);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 31);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1260, 495);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 35);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1140, 495);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 35);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(80, 50);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(611, 26);
            this.txtSearch.TabIndex = 31;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.Location = new System.Drawing.Point(891, 499);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(93, 31);
            this.btnAddBook.TabIndex = 32;
            this.btnAddBook.Text = "Thêm sách";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnChangePhoto
            // 
            this.btnChangePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePhoto.Location = new System.Drawing.Point(738, 297);
            this.btnChangePhoto.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangePhoto.Name = "btnChangePhoto";
            this.btnChangePhoto.Size = new System.Drawing.Size(93, 31);
            this.btnChangePhoto.TabIndex = 33;
            this.btnChangePhoto.Text = "Đổi ảnh";
            this.btnChangePhoto.UseVisualStyleBackColor = true;
            this.btnChangePhoto.Click += new System.EventHandler(this.btnChangePhoto_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(1058, 560);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(56, 19);
            this.btnRefresh.TabIndex = 34;
            this.btnRefresh.Text = "button1";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 50);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Tìm kiếm:";
            // 
            // txtFile
            // 
            this.txtFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFile.Location = new System.Drawing.Point(845, 301);
            this.txtFile.Margin = new System.Windows.Forms.Padding(2);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(184, 27);
            this.txtFile.TabIndex = 36;
            this.txtFile.TextChanged += new System.EventHandler(this.txtFile_TextChanged);
            // 
            // BookManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnChangePhoto);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtTaiBan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNamXuatBan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGiaBia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbNgonNgu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbNXB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbLoaiSach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEditTacGia);
            this.Controls.Add(this.lbTacGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureSach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookManagerForm";
            this.Text = "BookManagerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbTacGia;
        private System.Windows.Forms.Button btnEditTacGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLoaiSach;
        private System.Windows.Forms.ComboBox cbNXB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbNgonNgu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGiaBia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNamXuatBan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTaiBan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnChangePhoto;
        private System.Windows.Forms.BindingSource bsSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaXuatBan;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFile;
    }
}