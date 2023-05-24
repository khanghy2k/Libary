namespace QuanLyThuVIen.GUI
{
    partial class FormChonTacGia
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
            this.gridTacGia = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnThemTG = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDongY = new System.Windows.Forms.Button();
            this.MaTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridTacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTacGia
            // 
            this.gridTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTacGia,
            this.Selected,
            this.TenTacGia,
            this.GhiChu});
            this.gridTacGia.Location = new System.Drawing.Point(34, 123);
            this.gridTacGia.Name = "gridTacGia";
            this.gridTacGia.RowHeadersWidth = 51;
            this.gridTacGia.RowTemplate.Height = 24;
            this.gridTacGia.Size = new System.Drawing.Size(561, 315);
            this.gridTacGia.TabIndex = 0;
            this.gridTacGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTacGia_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách tác giả";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(34, 85);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(561, 32);
            this.txtSearch.TabIndex = 2;
            // 
            // btnThemTG
            // 
            this.btnThemTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTG.Location = new System.Drawing.Point(34, 453);
            this.btnThemTG.Name = "btnThemTG";
            this.btnThemTG.Size = new System.Drawing.Size(137, 37);
            this.btnThemTG.TabIndex = 3;
            this.btnThemTG.Text = "Thêm";
            this.btnThemTG.UseVisualStyleBackColor = true;
            this.btnThemTG.Click += new System.EventHandler(this.btnThemTG_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(458, 546);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(137, 37);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDongY
            // 
            this.btnDongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongY.Location = new System.Drawing.Point(315, 546);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(137, 37);
            this.btnDongY.TabIndex = 5;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // MaTacGia
            // 
            this.MaTacGia.DataPropertyName = "MaTacGia";
            this.MaTacGia.HeaderText = "Mã tác giả";
            this.MaTacGia.MinimumWidth = 6;
            this.MaTacGia.Name = "MaTacGia";
            this.MaTacGia.Visible = false;
            this.MaTacGia.Width = 125;
            // 
            // Selected
            // 
            this.Selected.DataPropertyName = "Selected";
            this.Selected.HeaderText = "";
            this.Selected.MinimumWidth = 6;
            this.Selected.Name = "Selected";
            this.Selected.Width = 50;
            // 
            // TenTacGia
            // 
            this.TenTacGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenTacGia.DataPropertyName = "TenTacGia";
            this.TenTacGia.HeaderText = "Tên tác giả";
            this.TenTacGia.MinimumWidth = 6;
            this.TenTacGia.Name = "TenTacGia";
            this.TenTacGia.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // FormChonTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 608);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThemTG);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridTacGia);
            this.Name = "FormChonTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChonTacGia";
            this.Load += new System.EventHandler(this.FormChonTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTacGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTacGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnThemTG;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTacGia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}