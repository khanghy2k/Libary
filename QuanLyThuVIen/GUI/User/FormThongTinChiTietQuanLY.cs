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
    public partial class ThongTinChiTietQuanLy : Form
    {
        private int MaNguoiDungGlobal { get; set; }
        public ThongTinChiTietQuanLy(NguoiDung tam)
        {
          
            InitializeComponent();
            DataNguoiDung data = new DataNguoiDung();
            this.textBox_MaNhanVien.Text = Convert.ToString(tam.MaNguoiDung);
            this.textBox_HoTen.Text= tam.HoTen;
            this.textBox_Email.Text = tam.Email;

            this.dtNgaySinh.Value= tam.NgaySinh;
            this.textBox_SoDienThoai.Text = tam.SoDienThoai;
            this.comboBox_GioiTinh1.Text = tam.GetGioiTinh;
            this.textBox_UserName.Text = tam.UserName;
            comboBox_ChucVu1.DataSource =data.GetChucVu();
            comboBox_ChucVu1.DisplayMember = "TenChucVu";
            comboBox_ChucVu1.SelectedItem = tam.MaChucVu;
            comboBox_ChucVu1.ValueMember = "MaChucVu";
         
            comboBox_ChucVu1.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void FormThongTinChiTietQuanLY_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new FormXacNhanXoa();
            frm.StartPosition = FormStartPosition.CenterParent;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                var dataNguoiDung = new DataNguoiDung();
                bool result = dataNguoiDung.Delete(MaNguoiDungGlobal);
                frm.Close();
                this.Close();
            }
    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = true;
                bool checkemail = true;
                NguoiDung tam = (NguoiDung)bs_source.DataSource;
                NguoiDung s = new NguoiDung();
                DataNguoiDung data = new DataNguoiDung();

                s.HoTen = Convert.ToString(this.textBox_HoTen.Text.Trim());
                if(string.IsNullOrWhiteSpace(s.HoTen))
                {
                    check = false;
                    

                }
                s.MaChucVu = ((ChucVu)this.comboBox_ChucVu1.SelectedItem).MaChucVu;
                if (comboBox_GioiTinh1.SelectedItem == "Nam")
                {
                    s.GioiTinh = true;


                }
                if (comboBox_GioiTinh1.SelectedItem == "Nữ")
                {
                    s.GioiTinh = false;
                }
                s.MaNguoiDung = Convert.ToInt32(this.textBox_MaNhanVien.Text);
                s.SoDienThoai = Convert.ToString(this.textBox_SoDienThoai.Text.Trim());
                if (string.IsNullOrWhiteSpace(s.SoDienThoai))
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
           
                s.Email = Convert.ToString(this.textBox_Email.Text.Trim());
                if (string.IsNullOrWhiteSpace(s.Email))
                {
                    check = false;


                }
                s.UserName = Convert.ToString(this.textBox_UserName.Text.Trim());
                if (string.IsNullOrWhiteSpace(s.UserName))
                {
                    check = false;


                }
                s.NgaySinh = this.dtNgaySinh.Value;
                DataNguoiDung dt = new DataNguoiDung();
                bool result = dt.Update(s);
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


                if (result && check && checkemail)
                {
                    DialogResult rs;
                    // Displays the MessageBox.
                    rs = MessageBox.Show(this, "Lưu thành công!");

                }
                else
                    MessageBox.Show("Lưu thất bại!,có lẽ bạn chưa nhập đầy đủ thông tin");
            }
            catch
            {
                MessageBox.Show("Lưu thất bại!,có lẽ bạn chưa nhập đầy đủ thông tin");
            }
        }

        private void comboBox_GioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void comboBox_ChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
