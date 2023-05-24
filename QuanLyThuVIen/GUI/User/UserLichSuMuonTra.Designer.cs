
namespace QuanLyThuVIen.GUI
{
    partial class UserLichSuMuonTra
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
            System.Windows.Forms.Label label1;
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Grid1 = new System.Windows.Forms.DataGridView();
            this.colMaChiTietMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHanTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Grid2 = new System.Windows.Forms.DataGridView();
            this.colMaDocGia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTraDungHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs1 = new System.Windows.Forms.BindingSource(this.components);
            this.bs2 = new System.Windows.Forms.BindingSource(this.components);
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.CausesValidation = false;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(293, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(177, 20);
            label1.TabIndex = 0;
            label1.Text = "LỊCH SỬ MƯỢN TRẢ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã độc giả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên độc giả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "label4";
            // 
            // Grid1
            // 
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaChiTietMuon,
            this.colMaDocGia,
            this.colNgayMuon,
            this.colHanTra,
            this.colSoLuongMuon,
            this.colMaNguoiDung,
            this.colTrangThai});
            this.Grid1.Location = new System.Drawing.Point(34, 143);
            this.Grid1.Name = "Grid1";
            this.Grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid1.Size = new System.Drawing.Size(698, 157);
            this.Grid1.TabIndex = 3;
            this.Grid1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid1_CellMouseClick);
            // 
            // colMaChiTietMuon
            // 
            this.colMaChiTietMuon.DataPropertyName = "MaChiTietMuon";
            this.colMaChiTietMuon.HeaderText = "Mã Chi Tiết Mượn";
            this.colMaChiTietMuon.MinimumWidth = 100;
            this.colMaChiTietMuon.Name = "colMaChiTietMuon";
            // 
            // colMaDocGia
            // 
            this.colMaDocGia.DataPropertyName = "MaDocGia";
            this.colMaDocGia.HeaderText = "Mã Độc Giả";
            this.colMaDocGia.Name = "colMaDocGia";
            this.colMaDocGia.Visible = false;
            // 
            // colNgayMuon
            // 
            this.colNgayMuon.DataPropertyName = "NgayMuon";
            this.colNgayMuon.HeaderText = "Ngày mượn";
            this.colNgayMuon.MinimumWidth = 100;
            this.colNgayMuon.Name = "colNgayMuon";
            this.colNgayMuon.Width = 150;
            // 
            // colHanTra
            // 
            this.colHanTra.DataPropertyName = "HanTra";
            this.colHanTra.HeaderText = "Hạn trả";
            this.colHanTra.MinimumWidth = 100;
            this.colHanTra.Name = "colHanTra";
            this.colHanTra.Width = 150;
            // 
            // colSoLuongMuon
            // 
            this.colSoLuongMuon.DataPropertyName = "SoLuongMuon";
            this.colSoLuongMuon.HeaderText = "Số sách mượn";
            this.colSoLuongMuon.MinimumWidth = 100;
            this.colSoLuongMuon.Name = "colSoLuongMuon";
            this.colSoLuongMuon.Width = 150;
            // 
            // colMaNguoiDung
            // 
            this.colMaNguoiDung.DataPropertyName = "MaNguoiDung";
            this.colMaNguoiDung.HeaderText = "Mã người dùng";
            this.colMaNguoiDung.MinimumWidth = 100;
            this.colMaNguoiDung.Name = "colMaNguoiDung";
            this.colMaNguoiDung.Visible = false;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 100;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Width = 150;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Đã trả ",
            "Chưa trả"});
            this.comboBox1.Location = new System.Drawing.Point(34, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "- Trạng thái - ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tìm kiếm";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.Location = new System.Drawing.Point(614, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Chi tiết mượn";
            // 
            // Grid2
            // 
            this.Grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDocGia1,
            this.colMaSach,
            this.colSoLuong,
            this.colTrangThai1,
            this.colNgayTra,
            this.colTraDungHan});
            this.Grid2.Location = new System.Drawing.Point(34, 327);
            this.Grid2.Name = "Grid2";
            this.Grid2.Size = new System.Drawing.Size(497, 132);
            this.Grid2.TabIndex = 7;
            // 
            // colMaDocGia1
            // 
            this.colMaDocGia1.DataPropertyName = "MaDocGia";
            this.colMaDocGia1.HeaderText = "Mã độc giả";
            this.colMaDocGia1.Name = "colMaDocGia1";
            this.colMaDocGia1.Visible = false;
            // 
            // colMaSach
            // 
            this.colMaSach.DataPropertyName = "MaSach";
            this.colMaSach.HeaderText = "Tên sách";
            this.colMaSach.Name = "colMaSach";
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Width = 120;
            // 
            // colTrangThai1
            // 
            this.colTrangThai1.DataPropertyName = "TrangThai";
            this.colTrangThai1.HeaderText = "Trạng thái";
            this.colTrangThai1.Name = "colTrangThai1";
            this.colTrangThai1.Visible = false;
            this.colTrangThai1.Width = 150;
            // 
            // colNgayTra
            // 
            this.colNgayTra.DataPropertyName = "NgayTra";
            this.colNgayTra.HeaderText = "Ngày trả";
            this.colNgayTra.Name = "colNgayTra";
            this.colNgayTra.Width = 140;
            // 
            // colTraDungHan
            // 
            this.colTraDungHan.DataPropertyName = "TraDungHan";
            this.colTraDungHan.HeaderText = "Trả đúng hạn";
            this.colTraDungHan.Name = "colTraDungHan";
            // 
            // UserLichSuMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 522);
            this.Controls.Add(this.Grid2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Grid1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(label1);
            this.Name = "UserLichSuMuonTra";
            this.Text = "UserLichSuMuonTra";
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView Grid1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView Grid2;
        private System.Windows.Forms.BindingSource bs1;
        private System.Windows.Forms.BindingSource bs2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaChiTietMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHanTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDocGia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTraDungHan;
    }
}