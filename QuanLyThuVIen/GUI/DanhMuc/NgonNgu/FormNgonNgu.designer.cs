
namespace QuanLyThuVIen.GUI
{
    partial class FormNgonNgu
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
            this.gridNgonNgu = new System.Windows.Forms.DataGridView();
            this.Tenngonngu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bs_ngonngu = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_GhiChu = new System.Windows.Forms.TextBox();
            this.textbox_TenNgonNgu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridNgonNgu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_ngonngu)).BeginInit();
            this.SuspendLayout();
            // 
            // gridNgonNgu
            // 
            this.gridNgonNgu.AllowUserToAddRows = false;
            this.gridNgonNgu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridNgonNgu.BackgroundColor = System.Drawing.Color.DarkGray;
            this.gridNgonNgu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNgonNgu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tenngonngu,
            this.Ghichu});
            this.gridNgonNgu.Location = new System.Drawing.Point(74, 86);
            this.gridNgonNgu.Margin = new System.Windows.Forms.Padding(2);
            this.gridNgonNgu.Name = "gridNgonNgu";
            this.gridNgonNgu.RowHeadersWidth = 51;
            this.gridNgonNgu.RowTemplate.Height = 24;
            this.gridNgonNgu.Size = new System.Drawing.Size(411, 282);
            this.gridNgonNgu.TabIndex = 4;
            this.gridNgonNgu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSach_CellContentClick);
            this.gridNgonNgu.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_tacgia_CellMouseClick);
            // 
            // Tenngonngu
            // 
            this.Tenngonngu.DataPropertyName = "TenNgonNgu";
            this.Tenngonngu.HeaderText = "Tên Ngôn Ngữ";
            this.Tenngonngu.MinimumWidth = 6;
            this.Tenngonngu.Name = "Tenngonngu";
            // 
            // Ghichu
            // 
            this.Ghichu.DataPropertyName = "GhiChu";
            this.Ghichu.HeaderText = "Ghi Chú";
            this.Ghichu.MinimumWidth = 6;
            this.Ghichu.Name = "Ghichu";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(164, 52);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(322, 27);
            this.txtSearch.TabIndex = 32;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 54);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 22);
            this.label9.TabIndex = 36;
            this.label9.Text = "Tìm kiếm:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(386, 374);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 32);
            this.button2.TabIndex = 37;
            this.button2.Text = "Xoá";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(625, 314);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 28);
            this.button1.TabIndex = 38;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(74, 374);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 32);
            this.button3.TabIndex = 39;
            this.button3.Text = "Thêm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox_GhiChu
            // 
            this.textBox_GhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_GhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_GhiChu.Location = new System.Drawing.Point(625, 156);
            this.textBox_GhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_GhiChu.Multiline = true;
            this.textBox_GhiChu.Name = "textBox_GhiChu";
            this.textBox_GhiChu.Size = new System.Drawing.Size(210, 130);
            this.textBox_GhiChu.TabIndex = 40;
            // 
            // textbox_TenNgonNgu
            // 
            this.textbox_TenNgonNgu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_TenNgonNgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_TenNgonNgu.Location = new System.Drawing.Point(646, 106);
            this.textbox_TenNgonNgu.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_TenNgonNgu.Name = "textbox_TenNgonNgu";
            this.textbox_TenNgonNgu.Size = new System.Drawing.Size(188, 27);
            this.textbox_TenNgonNgu.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(506, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 42;
            this.label2.Text = "Tên Ngôn Ngữ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(506, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 43;
            this.label1.Text = "Ghi Chú";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(736, 314);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 28);
            this.button4.TabIndex = 44;
            this.button4.Text = "Hủy";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormNgonNgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_TenNgonNgu);
            this.Controls.Add(this.textBox_GhiChu);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gridNgonNgu);
            this.Name = "FormNgonNgu";
            this.Text = "NgonNgu";
            ((System.ComponentModel.ISupportInitialize)(this.gridNgonNgu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_ngonngu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridNgonNgu;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource bs_ngonngu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenngonngu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghichu;
        private System.Windows.Forms.TextBox textBox_GhiChu;
        private System.Windows.Forms.TextBox textbox_TenNgonNgu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
    }
}