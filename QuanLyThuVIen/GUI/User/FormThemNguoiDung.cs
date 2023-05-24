using QuanLyThuVIen.Data;
using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVIen.GUI
{
    public partial class FormThemNguoiDung : Form
    {
        public FormThemNguoiDung()
        {
            InitializeComponent();



            DataNguoiDung getlist = new DataNguoiDung();
            int index = 1;


            comboBox_ChucVu1.Text = "Chức Vụ";
            comboBox_ChucVu1.DataSource = getlist.GetChucVu();
            comboBox_ChucVu1.DisplayMember = "TenChucVu";
            comboBox_ChucVu1.SelectedItem = null;
        }

        private void FormThemNguoiDung_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                bool check = true;
                bool checkemail = true;
                NguoiDung s = new NguoiDung();
                DataNguoiDung data = new DataNguoiDung();
                s.HoTen = Convert.ToString(this.textBox_HoTen.Text.Trim());
                s.MaChucVu = ((ChucVu)this.comboBox_ChucVu1.SelectedItem).MaChucVu;
                if (comboBox_GioiTinh1.SelectedItem == "Nam")
                {
                    s.GioiTinh = true;
                }
                if (comboBox_GioiTinh1.SelectedItem == "Nữ")
                {
                    s.GioiTinh = false;
                }
                s.SoDienThoai = Convert.ToString(this.textBox_SoDienThoai.Text.Trim());
                s.Email = Convert.ToString(this.textBox_Email.Text.Trim());
                s.UserName = Convert.ToString(this.textBox_UserName.Text.Trim());
                s.NgaySinh = this.dtNgaySinh.Value;
                if (string.IsNullOrWhiteSpace(s.SoDienThoai))
                {
                    check = false;


                }
                if (string.IsNullOrWhiteSpace(s.HoTen))
                {
                    check = false;


                }
                if (string.IsNullOrWhiteSpace(s.UserName))
                {
                    check = false;


                }
                if (string.IsNullOrWhiteSpace(s.Email))
                {
                    check = false;


                }
                string strRegex1 = @"^[0-9]+[0-9]*$";
                Regex re1 = new Regex(strRegex1);
                if (re1.IsMatch(s.SoDienThoai))
                { check = true; }
                else
                {
                    check = false;

                }
                string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(s.Email))
                { checkemail = true; }
                else
                {
                    checkemail = false;
                  
                }
                DataNguoiDung dt = new DataNguoiDung();
                bool result = dt.Insert(s);
                
                if (result && check && checkemail)
                {
                    DialogResult rs;
                    // Displays the MessageBox.
                    rs = MessageBox.Show(this, "Lưu thành công!");

                }
                else
                    MessageBox.Show("Lưu thất bại!, có lẽ bạn nhập chưa đầy đủ thông tin");


            }
            catch
            {
                MessageBox.Show("Lưu thất bại!, có lẽ bạn nhập chưa đầy đủ thông tin");

            }
       

        }

        private void dtNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
