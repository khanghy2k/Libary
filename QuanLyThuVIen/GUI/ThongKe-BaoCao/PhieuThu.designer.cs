
namespace QuanLyThuVIen.GUI
{
    partial class PhieuThu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.GridPhieuMuon = new System.Windows.Forms.DataGridView();
            this.MaChiTietMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TraDungHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GridPhieuMuon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton5
            // 
            this.radioButton5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(1122, 20);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(147, 26);
            this.radioButton5.TabIndex = 35;
            this.radioButton5.Text = "Đã trả quá hạn";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(957, 20);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(157, 26);
            this.radioButton2.TabIndex = 34;
            this.radioButton2.Text = "Đã trả đúng hạn";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(326, 20);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(79, 26);
            this.radioButton4.TabIndex = 33;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Tất cả";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(677, 20);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(274, 26);
            this.radioButton3.TabIndex = 32;
            this.radioButton3.Text = "Đã trả nhưng chưa đủ số lượng";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(421, 20);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(248, 26);
            this.radioButton1.TabIndex = 31;
            this.radioButton1.Text = "Quá hạn trả nhưng chưa trả";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiem.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbTimKiem.Location = new System.Drawing.Point(12, 15);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(309, 27);
            this.tbTimKiem.TabIndex = 29;
            this.tbTimKiem.TextChanged += new System.EventHandler(this.tbTimKiem_TextChanged);
            // 
            // GridPhieuMuon
            // 
            this.GridPhieuMuon.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.GridPhieuMuon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPhieuMuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChiTietMuon,
            this.TenDocGia,
            this.NgayMuon,
            this.NgayTra,
            this.HanTra,
            this.SoLuongMuon,
            this.SoLuongTra,
            this.TrangThai,
            this.TraDungHan});
            this.GridPhieuMuon.GridColor = System.Drawing.SystemColors.Control;
            this.GridPhieuMuon.Location = new System.Drawing.Point(12, 47);
            this.GridPhieuMuon.Name = "GridPhieuMuon";
            this.GridPhieuMuon.ReadOnly = true;
            this.GridPhieuMuon.RowHeadersWidth = 62;
            this.GridPhieuMuon.Size = new System.Drawing.Size(851, 388);
            this.GridPhieuMuon.TabIndex = 27;
            this.GridPhieuMuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPhieuMuon_CellContentClick);
            // 
            // MaChiTietMuon
            // 
            this.MaChiTietMuon.DataPropertyName = "MaChiTietMuon";
            this.MaChiTietMuon.HeaderText = "Mã chi tiết";
            this.MaChiTietMuon.MinimumWidth = 6;
            this.MaChiTietMuon.Name = "MaChiTietMuon";
            this.MaChiTietMuon.ReadOnly = true;
            this.MaChiTietMuon.Width = 50;
            // 
            // TenDocGia
            // 
            this.TenDocGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenDocGia.DataPropertyName = "TenDocGia";
            this.TenDocGia.HeaderText = "Tên độc giả";
            this.TenDocGia.MinimumWidth = 150;
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
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày trả";
            this.NgayTra.MinimumWidth = 80;
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.ReadOnly = true;
            this.NgayTra.Width = 80;
            // 
            // HanTra
            // 
            this.HanTra.DataPropertyName = "HanTra";
            this.HanTra.HeaderText = "Hạn trả";
            this.HanTra.MinimumWidth = 80;
            this.HanTra.Name = "HanTra";
            this.HanTra.ReadOnly = true;
            this.HanTra.Width = 80;
            // 
            // SoLuongMuon
            // 
            this.SoLuongMuon.DataPropertyName = "SoLuongMuon";
            this.SoLuongMuon.HeaderText = "Số lượng mượn";
            this.SoLuongMuon.MinimumWidth = 6;
            this.SoLuongMuon.Name = "SoLuongMuon";
            this.SoLuongMuon.ReadOnly = true;
            this.SoLuongMuon.Width = 50;
            // 
            // SoLuongTra
            // 
            this.SoLuongTra.DataPropertyName = "SoLuongTra";
            this.SoLuongTra.HeaderText = "Số lượng trả";
            this.SoLuongTra.MinimumWidth = 6;
            this.SoLuongTra.Name = "SoLuongTra";
            this.SoLuongTra.ReadOnly = true;
            this.SoLuongTra.Width = 50;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 80;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Width = 80;
            // 
            // TraDungHan
            // 
            this.TraDungHan.DataPropertyName = "TraDungHan";
            this.TraDungHan.HeaderText = "Trả đúng hạn";
            this.TraDungHan.MinimumWidth = 6;
            this.TraDungHan.Name = "TraDungHan";
            this.TraDungHan.ReadOnly = true;
            this.TraDungHan.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng số phiếu mượn :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 44);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tổng số phiếu quá hạn nhưng chưa\r\n trả:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 114);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(244, 44);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tổng số phiếu chưa trả đủ số\r\n lượng :\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(90, 135);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 172);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tổng số phiếu trả đúng hạn :\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(246, 172);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 211);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(256, 22);
            this.label11.TabIndex = 10;
            this.label11.Text = "Tổng số phiếu đã trả quá hạn :\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(261, 211);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 22);
            this.label10.TabIndex = 11;
            this.label10.Text = "label10";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(882, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 278);
            this.panel1.TabIndex = 28;
            // 
            // PhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1346, 700);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GridPhieuMuon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PhieuThu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PhieuThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridPhieuMuon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.DataGridView GridPhieuMuon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChiTietMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TraDungHan;
    }
}