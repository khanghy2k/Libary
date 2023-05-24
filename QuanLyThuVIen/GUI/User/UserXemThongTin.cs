using QRCoder;
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
using ZXing.QrCode.Internal;


namespace QuanLyThuVIen.GUI
{
    public partial class UserXemThongTin : Form
    {
        private int MaDocGia;
        public UserXemThongTin()
        {
            InitializeComponent();
        }
        public UserXemThongTin(int MaDocGia)
        {
            InitializeComponent();
            this.MaDocGia = MaDocGia;
            var DataDG = new DataDocGia();
            DocGia DG = DataDG.GetDocGia(this.MaDocGia);
            textBox1.Text = DG.MaDocGia.ToString();
            textBox2.Text = DG.TenDocGia;
            textBox3.Text = DG.NgaySinh.ToString();
            textBox4.Text = DG.Email;
            textBox5.Text = DG.DiaChi;
            textBox6.Text = DG.SoDienThoai;
            textBox7.Text = DG.NgayDangKy.ToString();
            textBox8.Text = DG.NgayHetHan.ToString();
            textBox9.Text = DG.Lop;
            textBox10.Text = DG.MaKhoa.ToString();
            textBox11.Text = DG.GioiTinh.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttMuonTra_Click(object sender, EventArgs e)
        {
            var frm = new UserLichSuMuonTra(MaDocGia);
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void btnGenerateQRCode_Click(object sender, EventArgs e)
        {
            string qrCodeData = MaDocGia.ToString();

            // Generate QR code image
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qRCodeData= qrGenerator.CreateQrCode(qrCodeData, QRCodeGenerator.ECCLevel.Q);
            QRCoder.QRCode qrCode = new QRCoder.QRCode(qRCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(10);

            // Save QR code image to file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png";
            saveFileDialog.Title = "Save QR Code";
            saveFileDialog.FileName = "QRCode_" + MaDocGia.ToString() + ".png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                qrCodeImage.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                MessageBox.Show("QR code saved successfully!");
            }
        }
    }
}
    
 

