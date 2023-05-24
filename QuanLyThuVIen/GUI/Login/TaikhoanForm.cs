using QuanLyThuVIen.Data;
using QuanLyThuVIen.Forms;
using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVIen.GUI
{
    public partial class TaikhoanForm : Form
    {
        int nguoidungglobal;

        public TaikhoanForm(int MaNguoiDung)
        {
            nguoidungglobal = MaNguoiDung;
            InitializeComponent();
            DataNguoiDung data = new DataNguoiDung();
            NguoiDung a = data.GetListNguoiDung(MaNguoiDung);
            this.txtHovaten.Text = a.HoTen;
            this.txtEmail.Text = a.Email;
            this.txtPhone.Text = a.SoDienThoai;
            this.txtGioitinh.Text = a.GetGioiTinh;
            this.txtChucVu.Text= data.GetChucVu(a.MaChucVu).Tenchucvu;
            this.dtNgaySinh.Value = a.NgaySinh;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void TaikhoanForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            NguoiDung Nguoi = new NguoiDung();
            Nguoi.HoTen = this.txtHovaten.Text;
            Nguoi.Email = this.txtEmail.Text;
            if (this.txtGioitinh.Text =="Nam")
            {
            Nguoi.GioiTinh = true;


            }
            if (this.txtGioitinh.Text == "Nữ")
            {
                Nguoi.GioiTinh = false;
            }
            Nguoi.SoDienThoai = this.txtPhone.Text;
            Nguoi.NgaySinh = this.dtNgaySinh.Value;
            Nguoi.MaNguoiDung = nguoidungglobal;

            DataNguoiDung data = new DataNguoiDung();
            data.Update(Nguoi);
            MessageBox.Show("Lưu Thành Công");

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
