namespace QuanLyThuVIen.GUI
{
    partial class FormTraSach
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
            this.labelCount = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.gridTraSach = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.txtSoTienPhat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThemVP = new System.Windows.Forms.Button();
            this.gridDanhSachViPham = new System.Windows.Forms.DataGridView();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDSViPham = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTienPhat = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridTraSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSachViPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDSViPham)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.Location = new System.Drawing.Point(662, 57);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(16, 18);
            this.labelCount.TabIndex = 102;
            this.labelCount.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(610, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 18);
            this.label17.TabIndex = 101;
            this.label17.Text = "SL:";
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaHan.Location = new System.Drawing.Point(1072, 659);
            this.btnGiaHan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(170, 34);
            this.btnGiaHan.TabIndex = 100;
            this.btnGiaHan.Text = "Hủy";
            this.btnGiaHan.UseVisualStyleBackColor = true;
            // 
            // btnTraSach
            // 
            this.btnTraSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraSach.Location = new System.Drawing.Point(857, 659);
            this.btnTraSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(170, 34);
            this.btnTraSach.TabIndex = 99;
            this.btnTraSach.Text = "Trả";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 26);
            this.label12.TabIndex = 97;
            this.label12.Text = "Chọn sách trả";
            // 
            // gridTraSach
            // 
            this.gridTraSach.AllowUserToAddRows = false;
            this.gridTraSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridTraSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTraSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.Selected,
            this.TenSach,
            this.TacGia,
            this.NhaXuatBan,
            this.SoLuongCon});
            this.gridTraSach.Location = new System.Drawing.Point(27, 79);
            this.gridTraSach.Margin = new System.Windows.Forms.Padding(4);
            this.gridTraSach.Name = "gridTraSach";
            this.gridTraSach.RowHeadersWidth = 51;
            this.gridTraSach.Size = new System.Drawing.Size(651, 246);
            this.gridTraSach.TabIndex = 103;
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
            // Selected
            // 
            this.Selected.HeaderText = "";
            this.Selected.MinimumWidth = 6;
            this.Selected.Name = "Selected";
            this.Selected.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Selected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Selected.Width = 50;
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
            // SoLuongCon
            // 
            this.SoLuongCon.DataPropertyName = "SoLuongCon";
            this.SoLuongCon.HeaderText = "Số lượng còn lại";
            this.SoLuongCon.MinimumWidth = 6;
            this.SoLuongCon.Name = "SoLuongCon";
            this.SoLuongCon.Visible = false;
            this.SoLuongCon.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 104;
            this.label1.Text = "Xử phạt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 105;
            this.label2.Text = "Lý do:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 106;
            this.label3.Text = "Số tiền phạt:";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyDo.Location = new System.Drawing.Point(124, 422);
            this.txtLyDo.Multiline = true;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(450, 81);
            this.txtLyDo.TabIndex = 107;
            // 
            // txtSoTienPhat
            // 
            this.txtSoTienPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienPhat.Location = new System.Drawing.Point(187, 531);
            this.txtSoTienPhat.Name = "txtSoTienPhat";
            this.txtSoTienPhat.Size = new System.Drawing.Size(316, 30);
            this.txtSoTienPhat.TabIndex = 108;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(520, 531);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 109;
            this.label4.Text = "VNĐ";
            // 
            // btnThemVP
            // 
            this.btnThemVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemVP.Location = new System.Drawing.Point(358, 599);
            this.btnThemVP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemVP.Name = "btnThemVP";
            this.btnThemVP.Size = new System.Drawing.Size(216, 42);
            this.btnThemVP.TabIndex = 110;
            this.btnThemVP.Text = "Thêm";
            this.btnThemVP.UseVisualStyleBackColor = true;
            this.btnThemVP.Click += new System.EventHandler(this.btnThemVP_Click);
            // 
            // gridDanhSachViPham
            // 
            this.gridDanhSachViPham.AllowUserToAddRows = false;
            this.gridDanhSachViPham.AutoGenerateColumns = false;
            this.gridDanhSachViPham.BackgroundColor = System.Drawing.Color.White;
            this.gridDanhSachViPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDanhSachViPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LyDo,
            this.SoTienPhat});
            this.gridDanhSachViPham.DataSource = this.bsDSViPham;
            this.gridDanhSachViPham.GridColor = System.Drawing.SystemColors.Control;
            this.gridDanhSachViPham.Location = new System.Drawing.Point(769, 79);
            this.gridDanhSachViPham.Name = "gridDanhSachViPham";
            this.gridDanhSachViPham.RowHeadersWidth = 51;
            this.gridDanhSachViPham.RowTemplate.Height = 24;
            this.gridDanhSachViPham.Size = new System.Drawing.Size(473, 246);
            this.gridDanhSachViPham.TabIndex = 111;
            // 
            // LyDo
            // 
            this.LyDo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LyDo.DataPropertyName = "LyDo";
            this.LyDo.HeaderText = "Lý do";
            this.LyDo.MinimumWidth = 6;
            this.LyDo.Name = "LyDo";
            // 
            // SoTienPhat
            // 
            this.SoTienPhat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoTienPhat.DataPropertyName = "SoTienPhat";
            this.SoTienPhat.HeaderText = "Số tiền phạt";
            this.SoTienPhat.MinimumWidth = 6;
            this.SoTienPhat.Name = "SoTienPhat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(764, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 26);
            this.label5.TabIndex = 112;
            this.label5.Text = "Danh sách vi phạm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(814, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 26);
            this.label6.TabIndex = 113;
            this.label6.Text = "Tổng tiền phạt:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1128, 330);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 36);
            this.button1.TabIndex = 114;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTienPhat
            // 
            this.labelTienPhat.AutoSize = true;
            this.labelTienPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTienPhat.ForeColor = System.Drawing.Color.Red;
            this.labelTienPhat.Location = new System.Drawing.Point(1015, 389);
            this.labelTienPhat.Name = "labelTienPhat";
            this.labelTienPhat.Size = new System.Drawing.Size(24, 25);
            this.labelTienPhat.TabIndex = 115;
            this.labelTienPhat.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1188, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 25);
            this.label8.TabIndex = 116;
            this.label8.Text = "VNĐ";
            // 
            // FormTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 738);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelTienPhat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gridDanhSachViPham);
            this.Controls.Add(this.btnThemVP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoTienPhat);
            this.Controls.Add(this.txtLyDo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridTraSach);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnGiaHan);
            this.Controls.Add(this.btnTraSach);
            this.Controls.Add(this.label12);
            this.Name = "FormTraSach";
            this.Text = "FormTraSach";
            ((System.ComponentModel.ISupportInitialize)(this.gridTraSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSachViPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDSViPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView gridTraSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongCon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.TextBox txtSoTienPhat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThemVP;
        private System.Windows.Forms.DataGridView gridDanhSachViPham;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bsDSViPham;
        private System.Windows.Forms.Label labelTienPhat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienPhat;
    }
}