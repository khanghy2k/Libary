namespace QuanLyThuVIen.GUI
{
    partial class ChonSachForm
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
            this.txtSearchSach = new System.Windows.Forms.TextBox();
            this.gridChonSach = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnApDung = new System.Windows.Forms.Button();
            this.bsSach = new System.Windows.Forms.BindingSource(this.components);
            this.cbSachCon = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridChonSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách sách:";
            // 
            // txtSearchSach
            // 
            this.txtSearchSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSach.Location = new System.Drawing.Point(16, 44);
            this.txtSearchSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchSach.Name = "txtSearchSach";
            this.txtSearchSach.Size = new System.Drawing.Size(624, 30);
            this.txtSearchSach.TabIndex = 2;
            this.txtSearchSach.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gridChonSach
            // 
            this.gridChonSach.AllowUserToAddRows = false;
            this.gridChonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridChonSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.Selected,
            this.TenSach,
            this.TacGia,
            this.NhaXuatBan,
            this.SoLuongCon});
            this.gridChonSach.Location = new System.Drawing.Point(16, 82);
            this.gridChonSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridChonSach.Name = "gridChonSach";
            this.gridChonSach.RowHeadersWidth = 51;
            this.gridChonSach.Size = new System.Drawing.Size(999, 559);
            this.gridChonSach.TabIndex = 3;
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
            this.SoLuongCon.Width = 125;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(895, 663);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 37);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnApDung
            // 
            this.btnApDung.Location = new System.Drawing.Point(736, 663);
            this.btnApDung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApDung.Name = "btnApDung";
            this.btnApDung.Size = new System.Drawing.Size(120, 37);
            this.btnApDung.TabIndex = 5;
            this.btnApDung.Text = "Áp dụng";
            this.btnApDung.UseVisualStyleBackColor = true;
            this.btnApDung.Click += new System.EventHandler(this.btnApDung_Click);
            // 
            // cbSachCon
            // 
            this.cbSachCon.AutoSize = true;
            this.cbSachCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSachCon.Location = new System.Drawing.Point(678, 46);
            this.cbSachCon.Name = "cbSachCon";
            this.cbSachCon.Size = new System.Drawing.Size(337, 29);
            this.cbSachCon.TabIndex = 6;
            this.cbSachCon.Text = "Chỉ hiển thị sách còn trong thư viện";
            this.cbSachCon.UseVisualStyleBackColor = true;
            this.cbSachCon.CheckedChanged += new System.EventHandler(this.cbSachCon_CheckedChanged);
            // 
            // ChonSachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 740);
            this.Controls.Add(this.cbSachCon);
            this.Controls.Add(this.btnApDung);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.gridChonSach);
            this.Controls.Add(this.txtSearchSach);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChonSachForm";
            this.Text = "ChonSachForm";
            this.Load += new System.EventHandler(this.ChonSachForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridChonSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchSach;
        private System.Windows.Forms.DataGridView gridChonSach;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnApDung;
        private System.Windows.Forms.BindingSource bsSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongCon;
        private System.Windows.Forms.CheckBox cbSachCon;
    }
}