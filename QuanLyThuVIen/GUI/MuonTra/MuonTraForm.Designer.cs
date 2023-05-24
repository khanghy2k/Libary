namespace QuanLyThuVIen.GUI
{
    partial class MuonTraForm
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
            this.cbQuaHan = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaPhieuMuon = new System.Windows.Forms.TextBox();
            this.txtTenDocGia = new System.Windows.Forms.TextBox();
            this.txtNgayMuon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHanTra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbDangMuon = new System.Windows.Forms.ListBox();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtMaDocGia_MUON = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNhanVien_MUON = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.labelSoLuongSachChon = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtChucDanh = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dtNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.dtNgayTra = new System.Windows.Forms.DateTimePicker();
            this.btnHuy_MUON = new System.Windows.Forms.Button();
            this.btnDongY_MUON = new System.Windows.Forms.Button();
            this.txtTenDocGia_Muon = new System.Windows.Forms.TextBox();
            this.lbNotify = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbChonSach = new System.Windows.Forms.ListBox();
            this.labelQuaHan = new System.Windows.Forms.Label();
            this.gridMuon = new System.Windows.Forms.DataGridView();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChiTietMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.bsMuonSach = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMuonSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách đang mượn:";
            // 
            // cbQuaHan
            // 
            this.cbQuaHan.AutoSize = true;
            this.cbQuaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuaHan.Location = new System.Drawing.Point(503, 74);
            this.cbQuaHan.Margin = new System.Windows.Forms.Padding(2);
            this.cbQuaHan.Name = "cbQuaHan";
            this.cbQuaHan.Size = new System.Drawing.Size(240, 26);
            this.cbQuaHan.TabIndex = 2;
            this.cbQuaHan.Text = "Chỉ hiện phiếu quá hạn trả";
            this.cbQuaHan.UseVisualStyleBackColor = true;
            this.cbQuaHan.CheckedChanged += new System.EventHandler(this.cbQuaHan_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(158, 86);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(326, 26);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tìm kiếm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 450);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã phiếu mượn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 489);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên độc giả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 687);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 605);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Chức danh:";
            // 
            // txtMaPhieuMuon
            // 
            this.txtMaPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuMuon.Location = new System.Drawing.Point(226, 450);
            this.txtMaPhieuMuon.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPhieuMuon.Name = "txtMaPhieuMuon";
            this.txtMaPhieuMuon.ReadOnly = true;
            this.txtMaPhieuMuon.Size = new System.Drawing.Size(169, 26);
            this.txtMaPhieuMuon.TabIndex = 7;
            this.txtMaPhieuMuon.TextChanged += new System.EventHandler(this.txtMaPhieuMuon_TextChanged);
            // 
            // txtTenDocGia
            // 
            this.txtTenDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDocGia.Location = new System.Drawing.Point(226, 489);
            this.txtTenDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.ReadOnly = true;
            this.txtTenDocGia.Size = new System.Drawing.Size(169, 26);
            this.txtTenDocGia.TabIndex = 9;
            // 
            // txtNgayMuon
            // 
            this.txtNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayMuon.Location = new System.Drawing.Point(226, 527);
            this.txtNgayMuon.Margin = new System.Windows.Forms.Padding(2);
            this.txtNgayMuon.Name = "txtNgayMuon";
            this.txtNgayMuon.ReadOnly = true;
            this.txtNgayMuon.Size = new System.Drawing.Size(169, 26);
            this.txtNgayMuon.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(68, 528);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "Ngày mượn:";
            // 
            // txtHanTra
            // 
            this.txtHanTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHanTra.Location = new System.Drawing.Point(226, 563);
            this.txtHanTra.Margin = new System.Windows.Forms.Padding(2);
            this.txtHanTra.Name = "txtHanTra";
            this.txtHanTra.ReadOnly = true;
            this.txtHanTra.Size = new System.Drawing.Size(169, 26);
            this.txtHanTra.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 566);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 22);
            this.label7.TabIndex = 21;
            this.label7.Text = "Hạn trả:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(476, 417);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(238, 22);
            this.label12.TabIndex = 25;
            this.label12.Text = "Danh sách sách đang mượn:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // lbDangMuon
            // 
            this.lbDangMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangMuon.FormattingEnabled = true;
            this.lbDangMuon.ItemHeight = 20;
            this.lbDangMuon.Location = new System.Drawing.Point(429, 441);
            this.lbDangMuon.Margin = new System.Windows.Forms.Padding(2);
            this.lbDangMuon.Name = "lbDangMuon";
            this.lbDangMuon.Size = new System.Drawing.Size(351, 104);
            this.lbDangMuon.TabIndex = 26;
            this.lbDangMuon.SelectedIndexChanged += new System.EventHandler(this.lbDangMuon_SelectedIndexChanged);
            // 
            // btnTraSach
            // 
            this.btnTraSach.Enabled = false;
            this.btnTraSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraSach.Location = new System.Drawing.Point(429, 568);
            this.btnTraSach.Margin = new System.Windows.Forms.Padding(2);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(173, 34);
            this.btnTraSach.TabIndex = 27;
            this.btnTraSach.Text = "Trả sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaHan.Location = new System.Drawing.Point(623, 568);
            this.btnGiaHan.Margin = new System.Windows.Forms.Padding(2);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(173, 34);
            this.btnGiaHan.TabIndex = 28;
            this.btnGiaHan.Text = "Gia hạn";
            this.btnGiaHan.UseVisualStyleBackColor = true;
            this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(718, 421);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 15);
            this.label17.TabIndex = 35;
            this.label17.Text = "SL:";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.Location = new System.Drawing.Point(747, 421);
            this.labelCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(14, 15);
            this.labelCount.TabIndex = 36;
            this.labelCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 646);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Điện thoại:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienThoai.Location = new System.Drawing.Point(226, 643);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(2);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.ReadOnly = true;
            this.txtDienThoai.Size = new System.Drawing.Size(169, 26);
            this.txtDienThoai.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(68, 414);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 25);
            this.label11.TabIndex = 37;
            this.label11.Text = "Thông tin:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(763, 74);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(160, 25);
            this.label19.TabIndex = 40;
            this.label19.Text = "Tạo phiếu mượn:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(852, 228);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 22);
            this.label20.TabIndex = 41;
            this.label20.Text = "Ngày trả:";
            // 
            // txtMaDocGia_MUON
            // 
            this.txtMaDocGia_MUON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDocGia_MUON.Location = new System.Drawing.Point(941, 114);
            this.txtMaDocGia_MUON.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaDocGia_MUON.Name = "txtMaDocGia_MUON";
            this.txtMaDocGia_MUON.Size = new System.Drawing.Size(284, 26);
            this.txtMaDocGia_MUON.TabIndex = 44;
            this.txtMaDocGia_MUON.TextChanged += new System.EventHandler(this.txtMaDocGia_MUON_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(835, 116);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 22);
            this.label9.TabIndex = 43;
            this.label9.Text = "Mã độc giả:";
            // 
            // txtNhanVien_MUON
            // 
            this.txtNhanVien_MUON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanVien_MUON.Location = new System.Drawing.Point(941, 263);
            this.txtNhanVien_MUON.Margin = new System.Windows.Forms.Padding(2);
            this.txtNhanVien_MUON.Name = "txtNhanVien_MUON";
            this.txtNhanVien_MUON.ReadOnly = true;
            this.txtNhanVien_MUON.Size = new System.Drawing.Size(284, 26);
            this.txtNhanVien_MUON.TabIndex = 46;
            this.txtNhanVien_MUON.TextChanged += new System.EventHandler(this.txtNhanVien_MUON_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(834, 266);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 22);
            this.label21.TabIndex = 45;
            this.label21.Text = "Nhân viên :";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(785, 294);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(150, 22);
            this.label22.TabIndex = 48;
            this.label22.Text = "Chọn sách mượn:";
            // 
            // labelSoLuongSachChon
            // 
            this.labelSoLuongSachChon.AutoSize = true;
            this.labelSoLuongSachChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuongSachChon.Location = new System.Drawing.Point(967, 450);
            this.labelSoLuongSachChon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSoLuongSachChon.Name = "labelSoLuongSachChon";
            this.labelSoLuongSachChon.Size = new System.Drawing.Size(14, 15);
            this.labelSoLuongSachChon.TabIndex = 50;
            this.labelSoLuongSachChon.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(938, 450);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(25, 15);
            this.label24.TabIndex = 49;
            this.label24.Text = "SL:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(824, 192);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(111, 22);
            this.label25.TabIndex = 51;
            this.label25.Text = "Ngày mượn :";
            // 
            // txtChucDanh
            // 
            this.txtChucDanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucDanh.Location = new System.Drawing.Point(226, 602);
            this.txtChucDanh.Margin = new System.Windows.Forms.Padding(2);
            this.txtChucDanh.Name = "txtChucDanh";
            this.txtChucDanh.ReadOnly = true;
            this.txtChucDanh.Size = new System.Drawing.Size(169, 26);
            this.txtChucDanh.TabIndex = 70;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(226, 684);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(169, 26);
            this.txtEmail.TabIndex = 71;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(827, 155);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 22);
            this.label15.TabIndex = 72;
            this.label15.Text = "Tên độc giả:";
            // 
            // dtNgayMuon
            // 
            this.dtNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayMuon.Location = new System.Drawing.Point(941, 192);
            this.dtNgayMuon.Margin = new System.Windows.Forms.Padding(2);
            this.dtNgayMuon.Name = "dtNgayMuon";
            this.dtNgayMuon.Size = new System.Drawing.Size(284, 26);
            this.dtNgayMuon.TabIndex = 74;
            // 
            // dtNgayTra
            // 
            this.dtNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayTra.Location = new System.Drawing.Point(941, 228);
            this.dtNgayTra.Margin = new System.Windows.Forms.Padding(2);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Size = new System.Drawing.Size(284, 26);
            this.dtNgayTra.TabIndex = 75;
            // 
            // btnHuy_MUON
            // 
            this.btnHuy_MUON.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy_MUON.Location = new System.Drawing.Point(1128, 493);
            this.btnHuy_MUON.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy_MUON.Name = "btnHuy_MUON";
            this.btnHuy_MUON.Size = new System.Drawing.Size(97, 34);
            this.btnHuy_MUON.TabIndex = 79;
            this.btnHuy_MUON.Text = "Hủy";
            this.btnHuy_MUON.UseVisualStyleBackColor = true;
            this.btnHuy_MUON.Click += new System.EventHandler(this.btnHuy_MUON_Click);
            // 
            // btnDongY_MUON
            // 
            this.btnDongY_MUON.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongY_MUON.Location = new System.Drawing.Point(941, 493);
            this.btnDongY_MUON.Margin = new System.Windows.Forms.Padding(2);
            this.btnDongY_MUON.Name = "btnDongY_MUON";
            this.btnDongY_MUON.Size = new System.Drawing.Size(97, 34);
            this.btnDongY_MUON.TabIndex = 80;
            this.btnDongY_MUON.Text = "Đồng ý";
            this.btnDongY_MUON.UseVisualStyleBackColor = true;
            this.btnDongY_MUON.Click += new System.EventHandler(this.btnDongY_MUON_Click);
            // 
            // txtTenDocGia_Muon
            // 
            this.txtTenDocGia_Muon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDocGia_Muon.Location = new System.Drawing.Point(941, 152);
            this.txtTenDocGia_Muon.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenDocGia_Muon.Name = "txtTenDocGia_Muon";
            this.txtTenDocGia_Muon.ReadOnly = true;
            this.txtTenDocGia_Muon.Size = new System.Drawing.Size(284, 26);
            this.txtTenDocGia_Muon.TabIndex = 73;
            // 
            // lbNotify
            // 
            this.lbNotify.AutoSize = true;
            this.lbNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotify.ForeColor = System.Drawing.Color.Red;
            this.lbNotify.Location = new System.Drawing.Point(940, 563);
            this.lbNotify.Name = "lbNotify";
            this.lbNotify.Size = new System.Drawing.Size(285, 22);
            this.lbNotify.TabIndex = 81;
            this.lbNotify.Text = "Cần nhập đủ và đúng thông tin";
            this.lbNotify.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1135, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 29);
            this.button1.TabIndex = 82;
            this.button1.Text = "Chọn sách";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbChonSach
            // 
            this.lbChonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChonSach.FormattingEnabled = true;
            this.lbChonSach.ItemHeight = 20;
            this.lbChonSach.Location = new System.Drawing.Point(941, 294);
            this.lbChonSach.Name = "lbChonSach";
            this.lbChonSach.Size = new System.Drawing.Size(284, 144);
            this.lbChonSach.TabIndex = 83;
            // 
            // labelQuaHan
            // 
            this.labelQuaHan.AutoSize = true;
            this.labelQuaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuaHan.ForeColor = System.Drawing.Color.Red;
            this.labelQuaHan.Location = new System.Drawing.Point(146, 568);
            this.labelQuaHan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuaHan.Name = "labelQuaHan";
            this.labelQuaHan.Size = new System.Drawing.Size(70, 20);
            this.labelQuaHan.TabIndex = 84;
            this.labelQuaHan.Text = "Quá hạn";
            this.labelQuaHan.Visible = false;
            // 
            // gridMuon
            // 
            this.gridMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDocGia,
            this.MaChiTietMuon,
            this.TenDocGia,
            this.NgayMuon,
            this.SoLuong,
            this.HanTra});
            this.gridMuon.Location = new System.Drawing.Point(11, 116);
            this.gridMuon.Margin = new System.Windows.Forms.Padding(2);
            this.gridMuon.Name = "gridMuon";
            this.gridMuon.RowHeadersWidth = 51;
            this.gridMuon.RowTemplate.Height = 24;
            this.gridMuon.Size = new System.Drawing.Size(769, 296);
            this.gridMuon.TabIndex = 85;
            this.gridMuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMuon_CellContentClick_1);
            this.gridMuon.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridMuon_CellMouseClick);
            // 
            // MaDocGia
            // 
            this.MaDocGia.DataPropertyName = "MaDocGia";
            this.MaDocGia.HeaderText = "Mã độc giả";
            this.MaDocGia.MinimumWidth = 6;
            this.MaDocGia.Name = "MaDocGia";
            this.MaDocGia.ReadOnly = true;
            this.MaDocGia.Visible = false;
            this.MaDocGia.Width = 125;
            // 
            // MaChiTietMuon
            // 
            this.MaChiTietMuon.DataPropertyName = "MaChiTietMuon";
            this.MaChiTietMuon.HeaderText = "Mã phiếu mượn";
            this.MaChiTietMuon.MinimumWidth = 6;
            this.MaChiTietMuon.Name = "MaChiTietMuon";
            this.MaChiTietMuon.ReadOnly = true;
            this.MaChiTietMuon.Width = 125;
            // 
            // TenDocGia
            // 
            this.TenDocGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenDocGia.DataPropertyName = "TenDocGia";
            this.TenDocGia.HeaderText = "Tên độc giả";
            this.TenDocGia.MinimumWidth = 6;
            this.TenDocGia.Name = "TenDocGia";
            this.TenDocGia.ReadOnly = true;
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.HeaderText = "Ngày mượn";
            this.NgayMuon.MinimumWidth = 6;
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.ReadOnly = true;
            this.NgayMuon.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuongMuon";
            this.SoLuong.HeaderText = "SL";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 125;
            // 
            // HanTra
            // 
            this.HanTra.DataPropertyName = "HanTra";
            this.HanTra.HeaderText = "Hạn trả";
            this.HanTra.MinimumWidth = 6;
            this.HanTra.Name = "HanTra";
            this.HanTra.ReadOnly = true;
            this.HanTra.Width = 125;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(503, 31);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 28);
            this.button2.TabIndex = 86;
            this.button2.Text = "Danh sách đang chờ mượn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(429, 607);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 31);
            this.button3.TabIndex = 89;
            this.button3.Text = "ĐọcQR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MuonTraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gridMuon);
            this.Controls.Add(this.labelQuaHan);
            this.Controls.Add(this.lbChonSach);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbNotify);
            this.Controls.Add(this.btnDongY_MUON);
            this.Controls.Add(this.btnHuy_MUON);
            this.Controls.Add(this.dtNgayTra);
            this.Controls.Add(this.dtNgayMuon);
            this.Controls.Add(this.txtTenDocGia_Muon);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtChucDanh);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.labelSoLuongSachChon);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtNhanVien_MUON);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtMaDocGia_MUON);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnGiaHan);
            this.Controls.Add(this.btnTraSach);
            this.Controls.Add(this.lbDangMuon);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtHanTra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNgayMuon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtTenDocGia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaPhieuMuon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbQuaHan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MuonTraForm";
            this.Text = "MuonTraForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMuonSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbQuaHan;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaPhieuMuon;
        private System.Windows.Forms.TextBox txtTenDocGia;
        private System.Windows.Forms.TextBox txtNgayMuon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHanTra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lbDangMuon;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtMaDocGia_MUON;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNhanVien_MUON;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label labelSoLuongSachChon;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtChucDanh;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtNgayMuon;
        private System.Windows.Forms.DateTimePicker dtNgayTra;
        private System.Windows.Forms.Button btnHuy_MUON;
        private System.Windows.Forms.Button btnDongY_MUON;
        private System.Windows.Forms.TextBox txtTenDocGia_Muon;
        private System.Windows.Forms.BindingSource bsMuonSach;
        private System.Windows.Forms.Label lbNotify;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbChonSach;
        private System.Windows.Forms.Label labelQuaHan;
        private System.Windows.Forms.DataGridView gridMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChiTietMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanTra;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}