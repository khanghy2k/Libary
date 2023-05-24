namespace QuanLyThuVIen.GUI
{
    partial class EditLoaiSach
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnBackFrEdit = new System.Windows.Forms.Button();
            this.btnEditFrEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ghi chú";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(84, 42);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(255, 20);
            this.txtTenLoai.TabIndex = 1;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(84, 88);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(255, 20);
            this.txtGhiChu.TabIndex = 1;
            // 
            // btnBackFrEdit
            // 
            this.btnBackFrEdit.Location = new System.Drawing.Point(55, 132);
            this.btnBackFrEdit.Name = "btnBackFrEdit";
            this.btnBackFrEdit.Size = new System.Drawing.Size(75, 23);
            this.btnBackFrEdit.TabIndex = 2;
            this.btnBackFrEdit.Text = "Quay lại";
            this.btnBackFrEdit.UseVisualStyleBackColor = true;
            this.btnBackFrEdit.Click += new System.EventHandler(this.btnBackFrEdit_Click);
            // 
            // btnEditFrEdit
            // 
            this.btnEditFrEdit.Location = new System.Drawing.Point(264, 132);
            this.btnEditFrEdit.Name = "btnEditFrEdit";
            this.btnEditFrEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEditFrEdit.TabIndex = 2;
            this.btnEditFrEdit.Text = "Sửa";
            this.btnEditFrEdit.UseVisualStyleBackColor = true;
            this.btnEditFrEdit.Click += new System.EventHandler(this.btnEditFrEdit_Click);
            // 
            // EditLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 183);
            this.Controls.Add(this.btnEditFrEdit);
            this.Controls.Add(this.btnBackFrEdit);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtTenLoai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditLoaiSach";
            this.Text = "AddLoaiSach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnBackFrEdit;
        private System.Windows.Forms.Button btnEditFrEdit;
    }
}