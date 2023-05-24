using QuanLyThuVIen.Data;
using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVIen.Forms
{
    public partial class LoginForm : Form
    {      
        public LoginForm()
        {
            InitializeComponent();
            button_login.TabStop = false;
            button_login.FlatStyle = FlatStyle.Flat;
            button_login.FlatAppearance.BorderSize = 0;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }     
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       

        private void button1_Click(object sender, EventArgs e)
        {


            DataNguoiDung data = new DataNguoiDung();
            string Email = this.txtUserName.Text;
            string password = this.txtPassword.Text;
            NguoiDung user = data.Login(Email, password);

            if (user != null)
            {
                LoginInfo.userID = user.MaNguoiDung;
                LoginInfo.TenNguoiDung = user.UserName;
                LoginInfo.MaChucVu = user.MaChucVu;
                NguoiDung tam = data.Login(Email, password);
                FormMain f = new FormMain(tam.MaNguoiDung);
                f.Show();
                this.Hide();              
                
            }
            else            
            {
                MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu");
            }
           
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            SendCode sc = new SendCode();
            this.Hide();
            sc.Show();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtUserName_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtUserName.Text == "E-mail")
            {
                txtUserName.Text = "";
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {          
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
