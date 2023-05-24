using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using QuanLyThuVIen.Data;
using QuanLyThuVIen.Model;

namespace QuanLyThuVIen.Forms
{
    public partial class ResetPassword : Form
    {
        string username = SendCode.to;
        public ResetPassword()
        {
            InitializeComponent();
            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtResetPass.Text == txtResetPassVer.Text)
            {
                SqlConnection cn = new SqlConnection("Data Source=LAPCN-i-hy-tqk;Initial Catalog=QuanLyThuVien;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[NguoiDung]  SET  [Password] ='" + txtResetPassVer.Text + "' WHERE Email='" + username + "'", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Đổi Mật Khẩu Thành Công");
                this.Close();
                LoginForm f1 = new LoginForm();
                f1.Show();

            }
            else
            {
                MessageBox.Show("Đổi Mật Khẩu Thất Bại");
            }
        }
       
    }
}
