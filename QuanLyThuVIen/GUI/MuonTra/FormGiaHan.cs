using QuanLyThuVIen.Data;
using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVIen.GUI
{
    public partial class FormGiaHan : Form
    {
        public FormGiaHan()
        {
            InitializeComponent();
        }
        public FormGiaHan(int MaChiTietMuon, int MaDocGia, ListBox lb)
        {
            InitializeComponent();
            txtMaChiTietMuon.Text = MaChiTietMuon.ToString();
            DataChiTietMuon dataCTM = new DataChiTietMuon();
            DataDocGia dataDocGia = new DataDocGia();
            ChiTietMuon ctm = dataCTM.GetChiTietMuon(MaChiTietMuon);
            DocGia dg = dataDocGia.GetDocGia(MaDocGia);
            txtTenDocGia.Text = dg.TenDocGia;
            txtSDT.Text = dg.SoDienThoai;
            lbNgayMuon.Text = ctm.NgayMuon.ToString("dd/MM/yyyy");
            lbHanTra.Text = ctm.HanTra.ToString("dd/MM/yyyy");

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DataChiTietMuon dataCTM = new DataChiTietMuon();
            dataCTM.UpdateHanTra(Convert.ToInt32(txtMaChiTietMuon.Text), dateHanTraMoi.Value);
            MessageBox.Show("Gia hạn thành công");
            this.Close();
        }

        private void dateHanTraMoi_ValueChanged(object sender, EventArgs e)
        {
            if (dateHanTraMoi.Value < DateTime.ParseExact(lbHanTra.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture))
            {
                dateHanTraMoi.Value = DateTime.Now.Date;
                MessageBox.Show("Không thể chọn ngày trước hạn trả cũ");
            }
            else
            {
                TimeSpan soNgay = dateHanTraMoi.Value.Date - DateTime.ParseExact(lbHanTra.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).Date;
                double phiDV = 500 * (int)soNgay.TotalDays;
                txtPhiDichVu.Text = phiDV.ToString();
            }
        }
    }
}
