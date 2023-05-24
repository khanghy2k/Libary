
namespace QuanLyThuVIen.GUI
{
    partial class DanhMucTacGia
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGrid_tacgia = new System.Windows.Forms.DataGridView();
            this.Coltentacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colmatacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textbox_TenTacGia = new System.Windows.Forms.TextBox();
            this.textBox_GhiChu = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bs_source = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_tacgia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_source)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(23, 77);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(359, 32);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGrid_tacgia
            // 
            this.dataGrid_tacgia.AllowUserToAddRows = false;
            this.dataGrid_tacgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_tacgia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coltentacgia,
            this.Colghichu,
            this.Colmatacgia});
            this.dataGrid_tacgia.Location = new System.Drawing.Point(23, 117);
            this.dataGrid_tacgia.Name = "dataGrid_tacgia";
            this.dataGrid_tacgia.RowHeadersWidth = 51;
            this.dataGrid_tacgia.RowTemplate.Height = 24;
            this.dataGrid_tacgia.Size = new System.Drawing.Size(598, 391);
            this.dataGrid_tacgia.TabIndex = 2;
            this.dataGrid_tacgia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_tacgia_CellClick);
            this.dataGrid_tacgia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGrid_tacgia.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_tacgia_CellMouseClick);
            this.dataGrid_tacgia.Click += new System.EventHandler(this.dataGrid_tacgia_Click);
            // 
            // Coltentacgia
            // 
            this.Coltentacgia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Coltentacgia.DataPropertyName = "TenTacGia";
            this.Coltentacgia.HeaderText = "Tên Tác Giả";
            this.Coltentacgia.MinimumWidth = 6;
            this.Coltentacgia.Name = "Coltentacgia";
            // 
            // Colghichu
            // 
            this.Colghichu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Colghichu.DataPropertyName = "GhiChu";
            this.Colghichu.HeaderText = "Ghi Chú";
            this.Colghichu.MinimumWidth = 6;
            this.Colghichu.Name = "Colghichu";
            // 
            // Colmatacgia
            // 
            this.Colmatacgia.DataPropertyName = "MaTacGia";
            this.Colmatacgia.HeaderText = "Matacgia";
            this.Colmatacgia.MinimumWidth = 6;
            this.Colmatacgia.Name = "Colmatacgia";
            this.Colmatacgia.Visible = false;
            this.Colmatacgia.Width = 125;
            // 
            // textbox_TenTacGia
            // 
            this.textbox_TenTacGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_TenTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_TenTacGia.Location = new System.Drawing.Point(852, 164);
            this.textbox_TenTacGia.Name = "textbox_TenTacGia";
            this.textbox_TenTacGia.Size = new System.Drawing.Size(250, 32);
            this.textbox_TenTacGia.TabIndex = 3;
            // 
            // textBox_GhiChu
            // 
            this.textBox_GhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_GhiChu.Location = new System.Drawing.Point(823, 239);
            this.textBox_GhiChu.Multiline = true;
            this.textBox_GhiChu.Name = "textBox_GhiChu";
            this.textBox_GhiChu.Size = new System.Drawing.Size(279, 160);
            this.textBox_GhiChu.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(479, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 34);
            this.button3.TabIndex = 6;
            this.button3.Text = "Thêm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(685, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ghi Chú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(685, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên Tác Giả";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(933, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(690, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "Xoá";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1027, 418);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 34);
            this.button4.TabIndex = 11;
            this.button4.Text = "Huỷ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DanhMucTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1192, 584);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox_GhiChu);
            this.Controls.Add(this.textbox_TenTacGia);
            this.Controls.Add(this.dataGrid_tacgia);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhMucTacGia";
            this.Text = "DanhMucTacGia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_tacgia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_source)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGrid_tacgia;
        private System.Windows.Forms.BindingSource bs_source;
        private System.Windows.Forms.TextBox textbox_TenTacGia;
        private System.Windows.Forms.TextBox textBox_GhiChu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coltentacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colghichu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colmatacgia;
    }
}