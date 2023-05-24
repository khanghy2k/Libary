using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVIen.Data;
using QuanLyThuVIen.Model;

namespace QuanLyThuVIen.GUI
{
    public partial class AddThuThu : Form
    {
        public AddThuThu()
        {
            InitializeComponent();
            //DataNguoiDung ND =new DataNguoiDung();
            //MaChucVu.DataSource = ND.GetListMaChucVu();
            //MaChucVu.DisplayMember = "TenChucVu";
            //MaChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            //MaChucVu.SelectedItem = null;
            //MaChucVu.Text = "-- Chon chuc vu";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void HoTen_Click(object sender, EventArgs e)
        {

        }

        private void btnBackFrAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaChucVu_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void SoDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void NgaySinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void HoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Thêm Thủ thư
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddFrAdd_Click(object sender, EventArgs e)
        {
            int gioitinh = this.cbGioiTinh.GetItemText(this.cbGioiTinh.SelectedItem) == "Nam" ? 0 : 1;
            NguoiDung TT = new NguoiDung()
            {
                HoTen = txtHoTen.Text,
                NgaySinh = NgaySinh.Value,
                SoDienThoai = txtSoDienThoai.Text,
                Email = txtEmail.Text,
                //MaChucVu = Convert.ToInt32(txtMaChucVu.Text),
                MaChucVu = 1,
                GioiTinh = Convert.ToBoolean(gioitinh),
                TrangThai = checkTrangThai.Checked,
                UserName = txtUserName.Text,
                Password = txtPassword.Text
            };
            var addthuthu = new DataNguoiDung();
            addthuthu.AddThuThu(TT);
            this.DialogResult = DialogResult.OK;
            
            //var lstTT = addthuthu.GetListThuThu();
         
            DialogResult= DialogResult.OK;
            this.Close();
        }

        private void MaChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MaChucVu.DataSource = DataNguoiDung.GetListLoaiSach();
            //cbLoaiSach.DisplayMember = "TenLoai";
            //cbLoaiSach.DropDownStyle = ComboBoxStyle.DropDownList;
            //cbLoaiSach.SelectedItem = null;
            //cbLoaiSach.Text = "-- Chọn loại sách";


        }

        private void AddThuThu_Load(object sender, EventArgs e)
        {

        }
    }
}
