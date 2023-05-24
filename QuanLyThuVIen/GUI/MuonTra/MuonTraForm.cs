using QuanLyThuVIen.Data;
using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;


namespace QuanLyThuVIen.GUI
{
    public partial class MuonTraForm : Form
    {
        private List<int> listMaSach;
        private int MaDocGiaGlobal;
        public MuonTraForm()
        {
            InitializeComponent();
            DataDocGia_MuonSach dtDGMS = new DataDocGia_MuonSach();
            var lst = dtDGMS.GetListDocGiaMuonSach();

            bsMuonSach.DataSource = lst;

            gridMuon.DataSource = bsMuonSach;
            txtNhanVien_MUON.Text = LoginInfo.TenNguoiDung;

        }

        private void Reload()
        {
            DataDocGia_MuonSach dataDGMS = new DataDocGia_MuonSach();
            var lstDGMS = dataDGMS.GetListDocGiaMuonSach();

            //Gán dữ liệu cho GridDataView
            bsMuonSach.DataSource = lstDGMS;
            gridMuon.DataSource = lstDGMS;
            gridMuon.AutoGenerateColumns = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ScanQR();
        }
        /// <summary>
        /// Xử lý khi quét QR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScanQR()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            openFileDialog.Multiselect = false;
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Sử dụng thư viện ZXing để giải mã QR code và trích xuất thông tin đầu đọc
                Bitmap bitmap = new Bitmap(openFileDialog.FileName);
                BarcodeReader reader = new BarcodeReader();
                reader.Options.PossibleFormats = new List<BarcodeFormat> { BarcodeFormat.QR_CODE };
                Result qrResult = reader.Decode(bitmap);

                if (qrResult != null)
                {
                    // Lấy thông tin đầu đọc từ QR code
                    string[] parts = qrResult.Text.Split(';');

                    if (parts.Length >= 1)
                    {
                        string maDocGia = parts[0];
                        DataDocGia dtDocGia = new DataDocGia();
                        DocGia docGia = dtDocGia.GetDocGia(Convert.ToInt32(maDocGia));
                        DataSach dtSach = new DataSach();

                        // Check if the docGia exists
                        if (docGia != null)
                        {
                            DataChiTietMuon dtCTM = new DataChiTietMuon();
                            ChiTietMuon ctm = new ChiTietMuon();                           
                            DataDocGia_MuonSach dataDGMS = new DataDocGia_MuonSach();
                            var lstDGMS = dataDGMS.GetListDocGiaMuonSach();
                            var maChiTietMuon = lstDGMS.FirstOrDefault(d => d.MaDocGia == Convert.ToInt32(maDocGia))?.MaChiTietMuon;
                            ctm.MaChiTietMuon = Convert.ToInt32(maChiTietMuon);
                            ctm.TrangThai = false;
                            ctm.SoLuongMuon = Convert.ToInt32(labelSoLuongSachChon.Text);
                            ctm.MaDocGia = docGia.MaDocGia; // set MaDocGia to the ID of the retrieved DocGia object
                            ctm.NgayMuon = dtNgayMuon.Value;
                            ctm.HanTra = dtNgayTra.Value;                          
                            ctm.ID_NguoiDung = LoginInfo.userID;
                            txtMaDocGia_MUON.Text = docGia.MaDocGia.ToString(); // display the ID of the retrieved DocGia object in the textbox
                            dtNgayMuon.Value = DateTime.Now.Date;
                            dtNgayMuon.Value = DateTime.Now.Date;                           
                            if (labelSoLuongSachChon != null)
                            {
                                ctm.SoLuongMuon = Convert.ToInt32(labelSoLuongSachChon.Text);
                            }
                            var lstSach = dtSach.GetListSach(ctm.MaChiTietMuon);
                            lbDangMuon.DataSource = lstSach;
                            lbDangMuon.DisplayMember = "TenSach";
                            labelCount.Text = lstSach.Count().ToString();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy độc giả!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            }





        /// <summary>
        /// Xử lý khi chọn đối tượng trong GridDataView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridMuon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          

            if (e.RowIndex >= 0)
            {
                btnTraSach.Enabled = true;
                DataGridViewRow row = gridMuon.Rows[e.RowIndex];
                DataDocGia dtDocGia = new DataDocGia();
                DataChiTietMuon dtCTM = new DataChiTietMuon();
                DataSach dtSach = new DataSach();

                MaDocGiaGlobal = Convert.ToInt32(row.Cells[0].Value.ToString());
                var MaDocGia = Convert.ToInt32(row.Cells[0].Value.ToString());
                var DocGia = (DocGia)dtDocGia.GetDocGia((int)MaDocGia);

                //Hiển thị thông tin độc giả
                txtTenDocGia.Text = DocGia.TenDocGia;
                txtChucDanh.Text = DocGia.MaChucDanh.ToString();
                txtEmail.Text = DocGia.Email;
                txtDienThoai.Text = DocGia.SoDienThoai;
                DataChucDanh dataChucDanh = new DataChucDanh();
                txtChucDanh.Text = dataChucDanh.GetChucDanh(Convert.ToInt32(DocGia.MaChucDanh)).TenChucDanh;
                txtMaPhieuMuon.Text = row.Cells["MaChiTietMuon"].Value.ToString();

                //Xử lý DateTime
                ChiTietMuon ctm = new ChiTietMuon();
                ctm = dtCTM.GetChiTietMuon(Convert.ToInt32(txtMaPhieuMuon.Text));
                txtHanTra.Text = ctm.HanTra.ToString("dd/MM/yyyy");
                txtNgayMuon.Text = ctm.NgayMuon.ToString("dd/MM/yyyy");
                if (DateTime.Now.Date > ctm.HanTra)
                {
                    labelQuaHan.Visible = true;
                }
                else
                {
                    labelQuaHan.Visible = false;
                }

                //Lấy danh sách sách mượn của độc giả
                var lstSach = dtSach.GetListSach(Convert.ToInt32(txtMaPhieuMuon.Text));
                lbDangMuon.DataSource = lstSach;
                lbDangMuon.DisplayMember = "TenSach";
                labelCount.Text = lstSach.Count().ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataDocGia_MuonSach dtDocGiaMuonSach = new DataDocGia_MuonSach();
            var s = dtDocGiaMuonSach.Search(txtSearch.Text);
            if (s.Count == 0)
                bsMuonSach.DataSource = null;
            else
            {
                bsMuonSach.DataSource = dtDocGiaMuonSach.Search(txtSearch.Text);
                gridMuon.DataSource = bsMuonSach;
            }
        }

        private void cbQuaHan_CheckedChanged(object sender, EventArgs e)
        {
            DataDocGia_MuonSach dtDocGiaMuonSach = new DataDocGia_MuonSach();
            if (cbQuaHan.Checked)
            {
                bsMuonSach.DataSource = dtDocGiaMuonSach.GetListQuaHan();
                gridMuon.DataSource = bsMuonSach;
            }
            else
            {
                bsMuonSach.DataSource = dtDocGiaMuonSach.GetListDocGiaMuonSach();
                gridMuon.DataSource = bsMuonSach;
            }
        }

        private void btnDongY_MUON_Click(object sender, EventArgs e)
        {
            ChiTietMuon ctm = new ChiTietMuon();
            if (string.IsNullOrWhiteSpace(txtMaDocGia_MUON.Text) || string.IsNullOrWhiteSpace(txtTenDocGia_Muon.Text) || listMaSach == null)
            lbNotify.Visible = true;

            else
            {

                ctm.SoLuongMuon = Convert.ToInt32(labelSoLuongSachChon.Text);
                ctm.MaDocGia = Convert.ToInt32(txtMaDocGia_MUON.Text);
                ctm.NgayMuon = dtNgayMuon.Value;
                ctm.HanTra = dtNgayTra.Value;
                ctm.TrangThai = false;
                ctm.ID_NguoiDung = LoginInfo.userID;
                DataChiTietMuon dtCTM = new DataChiTietMuon();
                if (dtCTM.GetSoLuongDangMuon(ctm.MaDocGia) + Convert.ToInt32(labelSoLuongSachChon.Text) > 5)
                {
                    MessageBox.Show("Mỗi độc giả chỉ được mượn tối đa 5 quyển sách 1 lúc");
                }
                else
                {
                    int MaChiTietMuon = dtCTM.InsertChiTietMuon(ctm);
                    dtCTM.InsertSach_ChiTietMuon(MaChiTietMuon, listMaSach);
                    MessageBox.Show("Thêm thành công!");
                    txtMaDocGia_MUON.Text = null;
                    dtNgayMuon.Value = DateTime.Now.Date;
                    dtNgayMuon.Value = DateTime.Now.Date;
                    lbChonSach.DataSource = null;
                    Reload();
                }
            }
        }

        private void txtMaDocGia_MUON_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDocGia_MUON.Text))
            {
                txtTenDocGia_Muon.Text = null;
            }
            else
            {
                if (int.TryParse(txtMaDocGia_MUON.Text, out int maDocGia))
                {
                    DataDocGia dtDocGia = new DataDocGia();
                    DocGia docGia = dtDocGia.GetDocGia(maDocGia);
                    if (docGia != null)
                    {
                        txtTenDocGia_Muon.Text = docGia.TenDocGia;
                    }
                    else
                    {
                        MessageBox.Show("Mã độc giả không tồn tại!");
                        txtMaDocGia_MUON.Text = "";
                    }
                }
 
            }
        }

        void LoadData(List<int> lstMaSach)
        {
            DataSach dtSach = new DataSach();
            List<Sach> listSach = new List<Sach>();
            foreach (int i in lstMaSach)
            {
                listSach.Add(dtSach.GetSach(i));
            }
            lbChonSach.DataSource = listSach;
            lbChonSach.DisplayMember = "TenSach";
            labelSoLuongSachChon.Text = lbChonSach.Items.Count.ToString();

            ///Gán danh sách mã sách được nhập từ form Thêm sách vào biến toàn cục listSach
            listMaSach = lstMaSach;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lstSach = new List<Sach>();
            foreach (var item in lbChonSach.Items)
            {
                lstSach.Add((Sach)item);
            }
            var lstMaSach = new List<int>();
            foreach (var item in lstSach)
            {
                lstMaSach.Add((int)item.MaSach);
            }
            if (lstMaSach.Count > 0)
            {
                ChonSachForm f = new ChonSachForm(lstMaSach);
                f.truyenData = new ChonSachForm.TruyenChoMuonTraForm(LoadData);
                f.ShowDialog();
            }
            else
            {
                ChonSachForm f = new ChonSachForm();
                f.truyenData = new ChonSachForm.TruyenChoMuonTraForm(LoadData);
                f.ShowDialog();
            }


        }

        private void  btnTraSach_Click(object sender, EventArgs e)
        {
            if (gridMuon.SelectedRows != null)
            {
                if (!string.IsNullOrWhiteSpace(txtMaPhieuMuon.Text))
                {
                    FormTraSach f = new FormTraSach(Convert.ToInt32(txtMaPhieuMuon.Text));
                    DialogResult dr = f.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        Reload();
                        txtTenDocGia.Text = null;
                        txtChucDanh.Text = null;
                        txtEmail.Text = null;
                        txtDienThoai.Text = null;
                        DataChucDanh dataChucDanh = new DataChucDanh();
                        txtChucDanh.Text = null;
                        txtMaPhieuMuon.Text = null;
                        txtNgayMuon.Text = null;
                        txtHanTra.Text = null;
                        lbDangMuon.DataSource = null;
                    }
                }

            }

        }

        private void txtMaPhieuMuon_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            FormGiaHan f = new FormGiaHan(Convert.ToInt32(txtMaPhieuMuon.Text), MaDocGiaGlobal, lbDangMuon);
            f.ShowDialog();
        }

        private void btnHuy_MUON_Click(object sender, EventArgs e)
        {
            txtMaDocGia_MUON.Text = "";
            dtNgayMuon.Value = DateTime.Now.Date;
            dtNgayTra.Value = DateTime.Now.Date;
            txtNhanVien_MUON = null;
            lbChonSach.DataSource = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDanhSachDangCho form = new FormDanhSachDangCho();
            form.ShowDialog();
            if(form.DialogResult == DialogResult.OK)
            {
                Reload();
            }
        }

        private void txtNhanVien_MUON_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridMuon_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void lbDangMuon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
