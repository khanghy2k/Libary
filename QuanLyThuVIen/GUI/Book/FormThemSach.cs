using QuanLyThuVIen.Data;
using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing.Common;
using ZXing;

namespace QuanLyThuVIen.GUI
{
    public partial class FormThemSach : Form
    {
        private List<int> listMaTacGia = new List<int>();
        public FormThemSach()
        {
            InitializeComponent();
            var dataSach = new DataSach();
            var dataNXB = new DataNXB();
            var dataNgonNgu = new DataNgonNgu();
            var dataLoaiSach = new DataLoaiSach();
            var dataTacGia = new DataTacGia();

            var lstNgonNgu = dataNgonNgu.GetListNgonNgu();

            cbNgonNgu.DataSource = lstNgonNgu;
            cbNgonNgu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNgonNgu.DisplayMember = "TenNgonNgu";
            cbNgonNgu.SelectedItem = null;
            cbNgonNgu.Text = "-- Chọn ngôn ngữ --";

            cbNXB.DataSource = dataNXB.GetListNXB();
            cbNXB.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNXB.DisplayMember = "TenNhaXuatBan";
            cbNXB.SelectedItem = null;
            cbNXB.Text = "-- Chọn nhà xuất bản --";

            cbLoaiSach.DataSource = dataLoaiSach.GetListLoaiSach();
            cbLoaiSach.DisplayMember = "TenLoai";
            cbLoaiSach.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLoaiSach.SelectedItem = null;
            cbLoaiSach.Text = "-- Chọn loại sách";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
      


        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *png)|*.jpg; *.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = open.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = new Bitmap(open.FileName);
               

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private bool dataIsValid()
        {
            bool result = true;
            var TenSach = txtBookName.Text.Trim();
            if (TenSach.Length == 0)
            {
                labelTenTrong.Visible = true;
                result = false;
            }
            else
                labelTenTrong.Visible = false;
            if (TenSach.Length > 100)
            {
                labelTenSachQuaDai.Visible = true;
                result = false;
            }
            else
                labelTenSachQuaDai.Visible = false;

            if (listMaTacGia.Count == 0)
            {
                labelTacGiaRong.Visible = true;
                result = false;
            }
            else
                labelTacGiaRong.Visible = false;

            if (((LoaiSach)cbLoaiSach.SelectedItem) == null)
            {
                labelLoaiSachDeTrong.Visible = true;
                result = false;
            }
            else
                labelLoaiSachDeTrong.Visible = false;

            if (((NhaXuatBan)cbNXB.SelectedItem) == null)
            {
                labelNXBDeTrong.Visible = true;
                result = false;
            }
            else
                labelNXBDeTrong.Visible = false;

            if (((NgonNgu)cbNgonNgu.SelectedItem) == null)
            {
                labelNgonNguDeTrong.Visible = true;
                result = false;
            }
            else
                labelNgonNguDeTrong.Visible = false;

            int num = 0;
            if (!int.TryParse(txtSoLuong.Text, out num) || int.Parse(txtSoLuong.Text) < 0)
            {
                labelSoLuong.Visible = true;
                result = false;
            }
            else
                labelSoLuong.Visible = false;

            if (!int.TryParse(txtGiaBia.Text, out num) || int.Parse(txtGiaBia.Text) < 0)
            {
                labelGiaBia.Visible = true;
                result = false;
            }
            else
                labelGiaBia.Visible = false;

            if (!int.TryParse(txtLanTaiBan.Text, out num) || int.Parse(txtLanTaiBan.Text) < 0)
            {
                labelSoTaiBan.Visible = true;
                result = false;
            }
            else
                labelSoTaiBan.Visible = false;

            return result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Sach s = new Sach();
            var TenSach = txtBookName.Text.Trim();

            if (dataIsValid())
            {
                s.TenSach = TenSach;
                s.MaLoaiSach = ((LoaiSach)cbLoaiSach.SelectedItem).MaLoai;
                if (txtNamXB.TextLength > 0)
                    s.NamXuatBan = Convert.ToInt32(txtNamXB.Text);
                else
                    s.NamXuatBan = 0;
                s.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                s.SoTaiBan = Convert.ToInt32(txtLanTaiBan.Text);
                s.TinhTrang = true;
                s.DonGia = Convert.ToInt32(txtGiaBia.Text.Trim());
                s.MaNgonNgu = ((NgonNgu)cbNgonNgu.SelectedItem).MaNgonNgu;
                s.MaNhaXuatBan = ((NhaXuatBan)cbNXB.SelectedItem).MaNhaXuatBan;
                if (txtFile.Text.Length > 0)
                {
                    File.Copy(txtFile.Text, Path.Combine(@"D:\QuanLyThuVien\QuanLyThuVIen\images\Sach\", Path.GetFileName(txtFile.Text)), true);
                    //File.Copy(txtFile.Text, Path.Combine(@"P:\Ver1\WebQLTV.Web\images\Sach", Path.GetFileName(txtFile.Text)), true);
                    //s.AnhWeb = Path.GetFileName(txtFile.Text);
                   s.Anh = @"D:\QuanLyThuVien\QuanLyThuVIen\images\Sach\" + Path.GetFileName(txtFile.Text);
                   // s.AnhWeb = Path.GetFileName(txtFile.Text);
                }
                var dataSach = new DataSach();
                int MaSach = dataSach.Insert(s);
                dataSach.InsertTacGia(MaSach, listMaTacGia);
                if (MaSach != 0)
                {
                    MessageBox.Show("Thêm sách thành công");
                }
                else
                {
                    MessageBox.Show("Thêm sách thất bại.");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void FormThemSach_Load(object sender, EventArgs e)
        {

        }
        void LoadData(List<int> lstTacGia)
        {
            DataTacGia dtTG = new DataTacGia();
            List<TacGia> listTacGia = new List<TacGia>();
            foreach (int i in lstTacGia)
            {
                listTacGia.Add(dtTG.GetTacGia(i));
            }
            lbTacGia.DataSource = listTacGia;
            lbTacGia.DisplayMember = "TenTacGia";

            ///Gán danh sách mã sách được nhập từ form Thêm sách vào biến toàn cục listSach
            listMaTacGia = lstTacGia;
        }
        private void EditAuthorButton_Click(object sender, EventArgs e)
        {
            var lstTG = new List<int>();
            foreach(var item in lbTacGia.Items)
            {
                lstTG.Add(((TacGia)item).MaTacGia);
            }
            if (lstTG.Count == 0)
            {
                FormChonTacGia f = new FormChonTacGia();
                f.truyenData = new FormChonTacGia.TruyenChoMuonTraForm(LoadData);
                f.ShowDialog();              
            }
            else
            {
                List<int> curList = listMaTacGia;
                FormChonTacGia f = new FormChonTacGia(listMaTacGia);
                f.truyenData = new FormChonTacGia.TruyenChoMuonTraForm(LoadData);
                f.ShowDialog();
                if (f.DialogResult == DialogResult.Cancel)
                {
                    DataTacGia dtTG = new DataTacGia();
                    List<TacGia> listTacGia = new List<TacGia>();
                    listMaTacGia = curList;
                    foreach (int i in curList)
                    {
                        listTacGia.Add(dtTG.GetTacGia(i));
                    }
                    lbTacGia.DataSource = listTacGia;
                    lbTacGia.DisplayMember = "TenTacGia";
                }
            }          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
