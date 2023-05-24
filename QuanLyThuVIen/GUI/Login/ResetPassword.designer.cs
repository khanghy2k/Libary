
namespace QuanLyThuVIen.Forms
{
    partial class ResetPassword
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
            this.txtResetPass = new System.Windows.Forms.TextBox();
            this.txtResetPassVer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResetPass
            // 
            this.txtResetPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtResetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResetPass.Location = new System.Drawing.Point(582, 259);
            this.txtResetPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResetPass.Name = "txtResetPass";
            this.txtResetPass.Size = new System.Drawing.Size(235, 32);
            this.txtResetPass.TabIndex = 0;
            this.txtResetPass.UseSystemPasswordChar = true;
            // 
            // txtResetPassVer
            // 
            this.txtResetPassVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtResetPassVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResetPassVer.Location = new System.Drawing.Point(582, 313);
            this.txtResetPassVer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResetPassVer.Name = "txtResetPassVer";
            this.txtResetPassVer.Size = new System.Drawing.Size(235, 32);
            this.txtResetPassVer.TabIndex = 1;
            this.txtResetPassVer.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(217)))), ((int)(((byte)(209)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(502, 386);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Đổi mật khẩu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(470, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thay đổi mật khẩu:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập mật khẩu mới:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập lại mật khẩu:";
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1196, 586);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResetPassVer);
            this.Controls.Add(this.txtResetPass);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResetPass;
        private System.Windows.Forms.TextBox txtResetPassVer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}