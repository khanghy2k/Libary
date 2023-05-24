using QuanLyThuVIen.Data;
using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace QuanLyThuVIen.GUI
{
    public partial class BookManagerForm : Form
    {
        OpenFileDialog open = new OpenFileDialog();
        private int MaSachGlobal { get; set; }
        public BookManagerForm()
        {
            InitializeComponent();
            var dataSach = new DataSach();
            var dataNXB = new DataNXB();
            var dataNgonNgu = new DataNgonNgu();
            var dataLoaiSach = new DataLoaiSach();
            var dataTacGia = new DataTacGia();

            var lstNXB = dataNXB.GetListNXB();
            var lstSach = dataSach.GetListSachResponse();
            bsSach.DataSource = lstSach;
            gridSach.DataSource = bsSach;
            gridSach.AutoGenerateColumns = false;

            txtTenSach.Enabled = false;
            txtGiaBia.Enabled = false;
            txtTaiBan.Enabled = false;
            txtSoLuong.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnChangePhoto.Enabled = false;
            txtNamXuatBan.Enabled = false;
            lbTacGia.Enabled = false;

            cbLoaiSach.DataSource = dataLoaiSach.GetListLoaiSach();
            cbLoaiSach.DisplayMember = "TenLoai";
            cbLoaiSach.SelectedItem = null;
            cbLoaiSach.Text = "-- Chọn thể loại --";
            cbLoaiSach.Enabled = false;
            cbLoaiSach.DropDownStyle = ComboBoxStyle.DropDownList;

            cbNgonNgu.DataSource = dataNgonNgu.GetListNgonNgu();
            cbNgonNgu.DisplayMember = "TenNgonNgu";
            cbNgonNgu.SelectedItem = null;
            cbNgonNgu.Text = "-- Chọn ngôn ngữ --";
            cbNgonNgu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNgonNgu.Enabled = false;

            lbTacGia.Text = "-- Chọn tác giả --";
            lbTacGia.Enabled = false;
            btnEditTacGia.Enabled = false;

            cbNXB.DataSource = dataNXB.GetListNXB();
            cbNXB.DisplayMember = "TenNhaXuatBan";
            cbNXB.SelectedItem = null;
            cbNXB.Text = "-- Chọn nhà xuất bản --";
            cbNXB.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNXB.Enabled = false;


            gridSach.DataSource = bsSach;

            gridSach.AutoGenerateColumns = false;

            btnRefresh.Hide();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var dataSach = new DataSach();
                var dataNXB = new DataNXB();
                var dataNgonNgu = new DataNgonNgu();
                var dataLoaiSach = new DataLoaiSach();
                var dataTacGia = new DataTacGia();

                var lstNgonNgu = dataNgonNgu.GetListNgonNgu();

                DataGridViewRow row = gridSach.Rows[e.RowIndex];
                MaSachGlobal = Convert.ToInt32(row.Cells["MaSach"].Value);

                btnDelete.Enabled = true;
                txtTenSach.Enabled = true;
                txtGiaBia.Enabled = true;
                txtTaiBan.Enabled = true;
                txtSoLuong.Enabled = true;
                cbNXB.Enabled = true;
                cbNgonNgu.Enabled = true;
                lbTacGia.Enabled = true;
                cbLoaiSach.Enabled = true;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                btnChangePhoto.Enabled = true;
                txtNamXuatBan.Enabled = true;
           


                Sach currentSach = dataSach.GetSach(Convert.ToInt32(row.Cells[0].Value));
                txtNamXuatBan.Text = currentSach.NamXuatBan.ToString();
                txtTenSach.Text = currentSach.TenSach;

                btnEditTacGia.Enabled = true;

                if (!File.Exists(currentSach.Anh))
                {
                    MessageBox.Show("Không tìm thấy tập tin hình ảnh: " + currentSach.Anh);
                }
                else
                {
                    try
                    {
                        pictureSach.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureSach.Image = Image.FromFile(currentSach.Anh);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi tải hình ảnh : " + ex.Message);
                    }
                }





                cbNgonNgu.DataSource = lstNgonNgu;
                cbNgonNgu.DisplayMember = "TenNgonNgu";
                cbNgonNgu.Text = dataNgonNgu.GetNgonNgu(currentSach.MaNgonNgu).TenNgonNgu;
                cbNgonNgu.SelectedItem = dataNgonNgu.GetNgonNgu(currentSach.MaNgonNgu);

                cbNXB.DataSource = dataNXB.GetListNXB();
                cbNXB.DisplayMember = "TenNgonNgu";
                cbNXB.Text = dataNXB.GetNXB(currentSach.MaNhaXuatBan).TenNhaXuatBan;
                cbNXB.SelectedItem = dataNXB.GetNXB(currentSach.MaNhaXuatBan).TenNhaXuatBan;

                List<TacGia> lstTacGia = dataTacGia.GetListTacGia(Convert.ToInt32(row.Cells[0].Value));
                lbTacGia.DataSource = lstTacGia;
                lbTacGia.DisplayMember = "TenTacGia";
                lbTacGia.Text = "-- Danh sách tác giả --";
                lbTacGia.SelectedItem = null;

                cbLoaiSach.DataSource = dataLoaiSach.GetListLoaiSach();
                cbLoaiSach.DisplayMember = "TenLoai";
                cbLoaiSach.SelectedItem = currentSach.MaLoaiSach;

                txtGiaBia.Text = currentSach.DonGia.ToString();
                txtTaiBan.Text = currentSach.SoTaiBan.ToString();
                txtSoLuong.Text = currentSach.SoLuong.ToString();
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var frm = new FormThemSach();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            frm.Show();
        }
        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            btnRefresh.Show();
            btnRefresh.PerformClick();
            btnRefresh.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var dataSach = new DataSach();
            var dataNXB = new DataNXB();
            var dataNgonNgu = new DataNgonNgu();
            var dataLoaiSach = new DataLoaiSach();
            var dataTacGia = new DataTacGia();

            var lstNXB = dataNXB.GetListNXB();
            var lstSach = dataSach.GetListSachResponse();
            bsSach.DataSource = lstSach;
            gridSach.DataSource = bsSach;
            gridSach.AutoGenerateColumns = false;

            txtTenSach.Enabled = false;
            txtGiaBia.Enabled = false;
            txtTaiBan.Enabled = false;
            txtSoLuong.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnChangePhoto.Enabled = false;
            txtNamXuatBan.Enabled = false;
            lbTacGia.Enabled = false;

            cbLoaiSach.DataSource = dataLoaiSach.GetListLoaiSach();
            cbLoaiSach.DisplayMember = "TenLoai";
            cbLoaiSach.SelectedItem = null;
            cbLoaiSach.Text = "-- Chọn thể loại --";
            cbLoaiSach.Enabled = false;
            cbLoaiSach.DropDownStyle = ComboBoxStyle.DropDownList;

            cbNgonNgu.DataSource = dataNgonNgu.GetListNgonNgu();
            cbNgonNgu.DisplayMember = "TenNgonNgu";
            cbNgonNgu.SelectedItem = null;
            cbNgonNgu.Text = "-- Chọn ngôn ngữ --";
            cbNgonNgu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNgonNgu.Enabled = false;

            lbTacGia.Text = "-- Chọn tác giả --";
            lbTacGia.Enabled = false;
            btnEditTacGia.Enabled = false;

            cbNXB.DataSource = dataNXB.GetListNXB();
            cbNXB.DisplayMember = "TenNhaXuatBan";
            cbNXB.SelectedItem = null;
            cbNXB.Text = "-- Chọn nhà xuất bản --";
            cbNXB.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNXB.Enabled = false;


            gridSach.DataSource = bsSach;

            gridSach.AutoGenerateColumns = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var frm = new FormXacNhanXoa();
            frm.StartPosition = FormStartPosition.CenterParent;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                var dataSach = new DataSach();
                bool result = dataSach.Delete(MaSachGlobal);
            }
            btnRefresh.Show();
            btnRefresh.PerformClick();
            btnRefresh.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Sach s = new Sach();
            if (txtFile.Text.Length > 0)
            {
                File.Copy(txtFile.Text, Path.Combine(@"D:\QuanLyThuVien\QuanLyThuVIen\images\Sach\", Path.GetFileName(txtFile.Text)), true);
                //File.Copy(txtFile.Text, Path.Combine(@"P:\Ver1\WebQLTV.Web\images\Sach", Path.GetFileName(txtFile.Text)), true);
                s.Anh = @"D:\QuanLyThuVien\QuanLyThuVIen\images\Sach\" + Path.GetFileName(txtFile.Text);
                //s.AnhWeb = Path.GetFileName(txtFile.Text);
            }
            s.TenSach = Convert.ToString(txtTenSach.Text.Trim());
            s.MaLoaiSach = ((LoaiSach)cbLoaiSach.SelectedItem).MaLoai;
            s.MaNgonNgu = ((NgonNgu)cbNgonNgu.SelectedItem).MaNgonNgu;
            s.NamXuatBan = Int32.Parse(txtNamXuatBan.Text.Trim());
            s.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            s.SoTaiBan = Convert.ToInt32(txtTaiBan.Text);
            s.MaNhaXuatBan = ((NhaXuatBan)cbNXB.SelectedItem).MaNhaXuatBan;
            s.MaSach = MaSachGlobal;
            DataSach dtSach = new DataSach();
            bool result = dtSach.Update(s);


            if (result)
            {
                DialogResult rs;
                // Displays the MessageBox.
                rs = MessageBox.Show(this, "Lưu thành công!", "Cập nhật thông tin");
                if (rs == DialogResult.OK)
                {
                    btnRefresh.Show();
                    btnRefresh.PerformClick();
                    btnRefresh.Hide();
                }
            }
            else
                MessageBox.Show("Lưu thất bại!");

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSach dtSach = new DataSach();
            bsSach.DataSource = dtSach.Search(txtSearch.Text.Trim());
            gridSach.DataSource = bsSach;
        }

        private void btnEditTacGia_Click(object sender, EventArgs e)
        {
            var lst = (IEnumerable<TacGia>)lbTacGia.DataSource;
            var frm = new EditTacGia(ref lst, MaSachGlobal);
            frm.StartPosition = FormStartPosition.CenterParent;

            frm.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            frm.Show();
        }

        private void btnChangePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *png)|*.jpg; *.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = open.FileName;
                pictureSach.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureSach.Image = new Bitmap(open.FileName);

            }
        }
        /// <summary>
        /// Up ảnh
        /// </summary>
        /// <param name="fileName"></param>
        private void uploadFile(string fileName)
        {
            //try
            //{
            //    var client = new WebClient();
            //    var uir = new Uri();
            //    {
            //        client.Headers.Add("fileName", System.IO.Path.GetFileName(fileName));
            //        client.UploadFileAsync(Uri, fileName);
            //        MessageBox.Show("Tải ảnh lên thành công");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void pictureSach_Click(object sender, EventArgs e)
        {

        }

        private void gridSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
