namespace QuanLyThuVIen.GUI
{
    partial class EditTacGia
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
            this.clbTacGia = new System.Windows.Forms.CheckedListBox();
            this.txtSearchTG = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH TÁC GIẢ";
            // 
            // clbTacGia
            // 
            this.clbTacGia.FormattingEnabled = true;
            this.clbTacGia.Location = new System.Drawing.Point(12, 77);
            this.clbTacGia.Name = "clbTacGia";
            this.clbTacGia.Size = new System.Drawing.Size(379, 310);
            this.clbTacGia.TabIndex = 2;
            this.clbTacGia.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbTacGia_ItemCheck);
            this.clbTacGia.SelectedIndexChanged += new System.EventHandler(this.clbTacGia_SelectedIndexChanged);
            // 
            // txtSearchTG
            // 
            this.txtSearchTG.Location = new System.Drawing.Point(12, 49);
            this.txtSearchTG.Name = "txtSearchTG";
            this.txtSearchTG.Size = new System.Drawing.Size(379, 22);
            this.txtSearchTG.TabIndex = 3;
            this.txtSearchTG.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(316, 393);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 31);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(315, 470);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(201, 470);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(100, 28);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "Xác nhận";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // EditTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 510);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSearchTG);
            this.Controls.Add(this.clbTacGia);
            this.Controls.Add(this.label1);
            this.Name = "EditTacGia";
            this.Text = "EditTacGia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbTacGia;
        private System.Windows.Forms.TextBox txtSearchTG;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
    }
}