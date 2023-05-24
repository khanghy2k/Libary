namespace QuanLyThuVIen.GUI
{
    partial class FormDanhSachDangCho
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
            this.gridMuon = new System.Windows.Forms.DataGridView();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChiTietMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMuonSach = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridDSSach = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMuonSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách đang chờ mượn";
            // 
            // gridMuon
            // 
            this.gridMuon.AllowUserToAddRows = false;
            this.gridMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDocGia,
            this.MaChiTietMuon,
            this.TenDocGia,
            this.NgayMuon,
            this.SoLuong,
            this.HanTra});
            this.gridMuon.Location = new System.Drawing.Point(73, 154);
            this.gridMuon.Name = "gridMuon";
            this.gridMuon.RowHeadersWidth = 51;
            this.gridMuon.RowTemplate.Height = 24;
            this.gridMuon.Size = new System.Drawing.Size(1024, 265);
            this.gridMuon.TabIndex = 86;
            this.gridMuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMuon_CellContentClick);
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
            // bsMuonSach
            // 
            this.bsMuonSach.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(653, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(444, 32);
            this.textBox1.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 31);
            this.label2.TabIndex = 89;
            this.label2.Text = "Danh sách sách:";
            // 
            // gridDSSach
            // 
            this.gridDSSach.AllowUserToAddRows = false;
            this.gridDSSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDSSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.TacGia,
            this.NhaXuatBan,
            this.SoLuongMuon});
            this.gridDSSach.Location = new System.Drawing.Point(73, 477);
            this.gridDSSach.Margin = new System.Windows.Forms.Padding(4);
            this.gridDSSach.Name = "gridDSSach";
            this.gridDSSach.RowHeadersWidth = 51;
            this.gridDSSach.Size = new System.Drawing.Size(1023, 220);
            this.gridDSSach.TabIndex = 90;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "MaSach";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.Visible = false;
            this.MaSach.Width = 125;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.Width = 125;
            // 
            // TacGia
            // 
            this.TacGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TacGia.DataPropertyName = "TacGia";
            this.TacGia.HeaderText = "Tác giả";
            this.TacGia.MinimumWidth = 6;
            this.TacGia.Name = "TacGia";
            this.TacGia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NhaXuatBan
            // 
            this.NhaXuatBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NhaXuatBan.DataPropertyName = "TenNhaXuatBan";
            this.NhaXuatBan.HeaderText = "Nhà xuất bản";
            this.NhaXuatBan.MinimumWidth = 6;
            this.NhaXuatBan.Name = "NhaXuatBan";
            // 
            // SoLuongMuon
            // 
            this.SoLuongMuon.DataPropertyName = "SoLuong";
            this.SoLuongMuon.HeaderText = "Số lượng mượn";
            this.SoLuongMuon.MinimumWidth = 6;
            this.SoLuongMuon.Name = "SoLuongMuon";
            this.SoLuongMuon.Width = 125;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(73, 704);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 45);
            this.button1.TabIndex = 91;
            this.button1.Text = "Xác nhận đã cho mượn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(340, 704);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(261, 45);
            this.button2.TabIndex = 92;
            this.button2.Text = "Từ chối";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(927, 768);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 45);
            this.button3.TabIndex = 93;
            this.button3.Text = "Đóng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormDanhSachDangCho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 838);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridDSSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gridMuon);
            this.Controls.Add(this.label1);
            this.Name = "FormDanhSachDangCho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDanhSachDangCho";
            ((System.ComponentModel.ISupportInitialize)(this.gridMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMuonSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChiTietMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanTra;
        private System.Windows.Forms.BindingSource bsMuonSach;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridDSSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongMuon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}