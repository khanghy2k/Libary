
namespace QuanLyThuVIen.GUI
{
    partial class UserManagerForm
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
            this.bttThuThu = new System.Windows.Forms.Button();
            this.bttQuanLy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttDocGia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttThuThu
            // 
            this.bttThuThu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttThuThu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttThuThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThuThu.Location = new System.Drawing.Point(551, 9);
            this.bttThuThu.Name = "bttThuThu";
            this.bttThuThu.Size = new System.Drawing.Size(269, 37);
            this.bttThuThu.TabIndex = 0;
            this.bttThuThu.Text = "Thủ thư";
            this.bttThuThu.UseVisualStyleBackColor = false;
            this.bttThuThu.Click += new System.EventHandler(this.button2_Click);
            // 
            // bttQuanLy
            // 
            this.bttQuanLy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttQuanLy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttQuanLy.Location = new System.Drawing.Point(826, 8);
            this.bttQuanLy.Name = "bttQuanLy";
            this.bttQuanLy.Size = new System.Drawing.Size(269, 37);
            this.bttQuanLy.TabIndex = 0;
            this.bttQuanLy.Text = "Quản lý";
            this.bttQuanLy.UseVisualStyleBackColor = false;
            this.bttQuanLy.Click += new System.EventHandler(this.bttQuanLy_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(13, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1349, 472);
            this.panel1.TabIndex = 1;
            // 
            // bttDocGia
            // 
            this.bttDocGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttDocGia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttDocGia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDocGia.Location = new System.Drawing.Point(276, 9);
            this.bttDocGia.Name = "bttDocGia";
            this.bttDocGia.Size = new System.Drawing.Size(269, 37);
            this.bttDocGia.TabIndex = 0;
            this.bttDocGia.Text = "Độc giả";
            this.bttDocGia.UseVisualStyleBackColor = false;
            this.bttDocGia.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1373, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bttQuanLy);
            this.Controls.Add(this.bttThuThu);
            this.Controls.Add(this.bttDocGia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserManagerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttDocGia;
        private System.Windows.Forms.Button bttThuThu;
        private System.Windows.Forms.Button bttQuanLy;
        private System.Windows.Forms.Panel panel1;
    }
}