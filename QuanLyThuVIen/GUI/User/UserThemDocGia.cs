using QuanLyThuVIen.Data;
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
using ZXing;
using System.IO;
using System.Drawing.Imaging;

namespace QuanLyThuVIen.GUI
{
    public partial class UserThemDocGia : Form
    {
        public int MaDocGia1;
        public UserThemDocGia()
        {
            InitializeComponent();
            var dataKhoa = new DataKhoa();
            comboBox1.DataSource = dataKhoa.GetListKhoa();
            comboBox1.DisplayMember = "TenKhoa";
            comboBox1.SelectedItem = null;
            comboBox1.Text = "-- Khoa --";

            //Nap chức danh vào combobox
            var dataCD = new DataChucDanh();
            comboBox3.DataSource = dataCD.GetListChucDanh();
            comboBox3.DisplayMember = "TenChucDanh";
            comboBox3.SelectedItem = null;
            comboBox3.Text = "-- Chức danh --";

            label16.Visible = false;
            comboBox4.Visible = false;
       


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            int GioiTinh = this.comboBox2.GetItemText(this.comboBox2.SelectedItem) == "Nam" ? 0 : 1;
            DocGia DG = new DocGia()
            {
                TenDocGia = tb1.Text.Trim(),
                NgaySinh = dtNgaySinh.Value,
                GioiTinh = Convert.ToBoolean(GioiTinh),
                Email = tb2.Text.Trim(),
                DiaChi = tb3.Text.Trim(),
                SoDienThoai = tb4.Text.Trim(),
                NgayDangKy = dtNgayDangKy.Value,
                NgayHetHan = dtNgayHetHan.Value,
                Lop = tb5.Text.Trim(),
                MaKhoa = ((Khoa)comboBox1.SelectedItem).MaKhoa,
                KhoaHoc =Convert.ToInt32(tb6.Text.Trim()),
                MaChucDanh = ((ChucDanh)comboBox3.SelectedItem).MaChucDanh,
                Username = tb7.Text.Trim(),
                Password = tb8.Text.Trim(),
                
                

            };
            var DocGia = new DataDocGia();
            if (MaDocGia1 > 0)
            {
                DG.MaTrangThai = ((TrangThai)comboBox4.SelectedItem).MaTrangThai;
                DG.MaDocGia = MaDocGia1;
                bool result = DocGia.Update(DG);
                if (result == false)
                {
                    MessageBox.Show("Chỉnh sửa độc giả thất bại.");
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa độc giả thành công");
                }
            }
            else
            {
                bool result = DocGia.Insert(DG);
                if (result == false)
                {
                    MessageBox.Show("Thêm độc giả thất bại.");
                }
                else
                {
                    MessageBox.Show("Thêm độc giả thành công");
                }
            }
            
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void UserThemDocGia_Load(object sender, EventArgs e)
        {

        }
        public UserThemDocGia(int MaDocGia)
        {
            InitializeComponent();
            var dataKhoa = new DataKhoa();
            comboBox1.DataSource = dataKhoa.GetListKhoa();
            comboBox1.DisplayMember = "TenKhoa";
            comboBox1.SelectedItem = null;
            comboBox1.Text = "-- Khoa --";

            //Nap chức danh vào combobox
            var dataCD = new DataChucDanh();
            comboBox3.DataSource = dataCD.GetListChucDanh();
            comboBox3.DisplayMember = "TenChucDanh";
            comboBox3.SelectedItem = null;
            comboBox3.Text = "-- Chức danh --";

            label1.Text = "CHỈNH SỬA ĐỘC GIẢ";

            //Nạp trạng thái vào combobox
            var dataTT = new DataTrangThai();
            comboBox4.DataSource = dataTT.GetListTrangThai();
            comboBox4.DisplayMember = "TenTrangThai";
            comboBox4.SelectedItem = null;


            var DataDG = new DataDocGia();
            DocGia DG = DataDG.GetDocGia(MaDocGia);

            tb1.Text = DG.TenDocGia;
            dtNgaySinh.Value = DG.NgaySinh;
            if (DG.GioiTinh)
            {
                comboBox2.Text = "Nữ";
            }
            else
                comboBox2.Text = "Nam";

            tb2.Text = DG.Email;
            tb3.Text = DG.DiaChi;
            tb4.Text = DG.SoDienThoai;
            dtNgayDangKy.Text = Convert.ToString(DG.NgayDangKy);
            dtNgayHetHan.Text = Convert.ToString(DG.NgayHetHan);
            tb5.Text = DG.Lop;
            tb6.Text = Convert.ToString(DG.KhoaHoc);
            tb7.Text = DG.Username;
            tb8.Text = DG.Password;
            var K = new DataKhoa();
            foreach(var item in K.GetListKhoa())
            {
                if(DG.MaKhoa == item.MaKhoa)
                {
                    comboBox1.Text = item.TenKhoa;
                }
                
            }
            var CD = new DataChucDanh();
            foreach (var item in CD.GetListChucDanh())
            {
                if (DG.MaChucDanh == item.MaChucDanh)
                {
                    comboBox3.Text = item.TenChucDanh;
                }

            }
            var TT = new DataTrangThai();
            foreach (var item in TT.GetListTrangThai())
            {
                if (DG.MaTrangThai == item.MaTrangThai)
                {
                    comboBox4.Text = item.TenTrangThai;
                }

            }
            MaDocGia1 = MaDocGia;
            
        }

       
        
     
    }
}
