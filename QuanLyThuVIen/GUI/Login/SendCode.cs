using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using QuanLyThuVIen.Data;

namespace QuanLyThuVIen.Forms
{
    public partial class SendCode : Form
    {
        string randomCode;
        public static string to;
        public SendCode()
        {
            InitializeComponent();
            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button2.TabStop = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataNguoiDung data = new DataNguoiDung();
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Bạn chưa nhập email");

            }
            else
            {
                try
                {
                    data.sosanhEmail(txtEmail.Text);



                    string from, pass, messagebody;
                    Random rand = new Random();
                    randomCode = (rand.Next(999999)).ToString();
                    using (MailMessage message = new MailMessage())
                    {

                        to = (txtEmail.Text).ToString();
                        from = "ktpm.husc.qltv@gmail.com";
                        pass = "phuocdeptrai";
                        messagebody = "Mã xác nhận của bạn là: " + randomCode;
                        message.To.Add(to);
                        message.From = new MailAddress(from);
                        message.Body = messagebody;
                        message.Subject = "Reset mật khẩu tài khoản quản lý thư viện";
                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com"))
                        {
                            smtp.EnableSsl = true;
                            smtp.Port = 587;
                            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                            smtp.Credentials = new NetworkCredential(from, pass);
                            try
                            {
                                smtp.Send(message);
                                MessageBox.Show("Gửi mã xác nhận thành công");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Bạn không có tài khoản");

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (randomCode == (txtVerCode.Text).ToString())
            {
                to = txtEmail.Text;
                ResetPassword rp = new ResetPassword();
                this.Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("Sai Mã");
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
