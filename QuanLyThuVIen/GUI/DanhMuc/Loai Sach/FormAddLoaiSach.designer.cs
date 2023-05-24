namespace QuanLyThuVIen.GUI
{
    partial class FormAddLoaiSach
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
            this.btnBackFrAdd = new System.Windows.Forms.Button();
            this.btnAddfrAdd = new System.Windows.Forms.Button();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ghi chú";
            // 
            // btnBackFrAdd
            // 
            this.btnBackFrAdd.Location = new System.Drawing.Point(69, 155);
            this.btnBackFrAdd.Name = "btnBackFrAdd";
            this.btnBackFrAdd.Size = new System.Drawing.Size(75, 23);
            this.btnBackFrAdd.TabIndex = 1;
            this.btnBackFrAdd.Text = "Quay lại";
            this.btnBackFrAdd.UseVisualStyleBackColor = true;
            this.btnBackFrAdd.Click += new System.EventHandler(this.btnBackFrAdd_Click);
            // 
            // btnAddfrAdd
            // 
            this.btnAddfrAdd.Location = new System.Drawing.Point(293, 155);
            this.btnAddfrAdd.Name = "btnAddfrAdd";
            this.btnAddfrAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAddfrAdd.TabIndex = 1;
            this.btnAddfrAdd.Text = "Thêm";
            this.btnAddfrAdd.UseVisualStyleBackColor = true;
            this.btnAddfrAdd.Click += new System.EventHandler(this.btnAddfrAdd_Click);
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(82, 48);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(296, 20);
            this.txtTenLoai.TabIndex = 2;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(82, 103);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(296, 20);
            this.txtGhiChu.TabIndex = 2;
            // 
            // FormAddLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 198);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtTenLoai);
            this.Controls.Add(this.btnAddfrAdd);
            this.Controls.Add(this.btnBackFrAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddLoaiSach";
            this.Text = "FormAddLoaiSach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBackFrAdd;
        private System.Windows.Forms.Button btnAddfrAdd;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.TextBox txtGhiChu;
    }
}