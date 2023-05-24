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
    public partial class EditThuThu : Form
    {

        public int MaNguoiDung;

        public EditThuThu()
        {
            InitializeComponent();
        }


        public EditThuThu(int mnd):this()
        {
            MaNguoiDung = mnd;
            var datand = new DataNguoiDung();
            NguoiDung nd = datand.GetThuThu(mnd);
            txtHoTen.Text = nd.HoTen;
            txtEmail.Text = nd.Email;
            txtSoDienThoai.Text = nd.SoDienThoai;
            txtEmail.Text = nd.Email;
            cbGioiTinh.Text = Convert.ToString(nd.GioiTinh);




        }


        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        
        }


        /// <summary>
        /// Cập nhật thông tin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            int gioitinh = this.cbGioiTinh.GetItemText(this.cbGioiTinh.SelectedItem) == "Nam" ? 0 : 1;
            NguoiDung TT = new NguoiDung()
            {
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = DateTimePicker.Value,
                SoDienThoai = txtSoDienThoai.Text,
                Email = txtEmail.Text,
                //MaChucVu = Convert.ToInt32(txtMaChucVu.Text),
                MaChucVu = 1,
                GioiTinh = Convert.ToBoolean(gioitinh)


            };
            var editthuthu = new DataNguoiDung();
            editthuthu.UpdateThuThu(MaNguoiDung,TT);
            this.DialogResult = DialogResult.OK;

            //var lstTT = addthuthu.GetListThuThu();

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBackFrEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
