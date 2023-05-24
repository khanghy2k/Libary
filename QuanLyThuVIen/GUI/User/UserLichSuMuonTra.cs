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

namespace QuanLyThuVIen.GUI
{
    public partial class UserLichSuMuonTra : Form
    {

        public UserLichSuMuonTra()
        {
            InitializeComponent();
        }
        public UserLichSuMuonTra(int MaDocGia)
        {
            InitializeComponent();

            var DG = new DataDocGia();
            DocGia lstDG = DG.GetDocGia(MaDocGia);
            label5.Text = Convert.ToString(lstDG.MaDocGia);
            label4.Text = lstDG.TenDocGia;

            var LS = new LichSuMuonTra();
            bs1.DataSource = LS.ListLSMuon(MaDocGia);
            Grid1.DataSource = bs1;


        }

        private void Grid1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Grid1.Rows[e.RowIndex];
                int MaChiTietMuon = Convert.ToInt32(row.Cells["colMaChiTietMuon"].Value);
                var CT = new LichSuMuonTra();
                //bs2.DataSource = CT.ListCTMuon(MaChiTietMuon);
                //Grid2.DataSource = bs2;
                int n = 0;
                foreach(var item in CT.ListCTMuon(MaChiTietMuon))
                {
                    
                    Grid2.Rows.Add();
                    var listSach =new DataSach();
                    foreach(var s in listSach.GetListSach()) {
                        if(item.MaSach==s.MaSach)
                            Grid2.Rows[n].Cells["colMaSach"].Value =s.TenSach ;
                    }
                    Grid2.Rows[n].Cells["colSoLuong"].Value = item.SoLuong;
                    if (item.TrangThai == -1)
                    {
                        Grid2.Rows[n].Cells["colNgayTra"].Value = "Đang chờ";
                        Grid2.Rows[n].Cells["colTraDungHan"].Value = "Đang chờ";
                    }
                    else
                    {
                        if (CT.checkNT(item.MaSach, MaChiTietMuon) != "")
                        {
                            Grid2.Rows[n].Cells["colNgayTra"].Value = CT.checkNT(item.MaSach, MaChiTietMuon).ToString();
                            if (CT.checkDH(item.MaSach, MaChiTietMuon) == 1)
                            {
                                Grid2.Rows[n].Cells["colTraDungHan"].Value = "Đúng hạn";
                            }
                            else
                                Grid2.Rows[n].Cells["colTraDungHan"].Value = "Trễ hạn";
                        }
                        else
                            Grid2.Rows[n].Cells["colNgayTra"].Value = "Chưa trả";
                    }
                    
                    
                    n = n + 1;
                }
                
                
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
