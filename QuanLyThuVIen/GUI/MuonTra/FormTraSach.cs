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
    public partial class FormTraSach : Form
    {
        private int MaChiTietMuon;
        DataTable dt = new DataTable();
        ChiTietMuon chiTietMuon;

        public FormTraSach()
        {
            InitializeComponent();
        }
        public FormTraSach(int MaChiTietMuon)
        {
            InitializeComponent();
            this.MaChiTietMuon = MaChiTietMuon;
            DataSach dtSach = new DataSach();
            DataChiTietMuon dtCTM = new DataChiTietMuon();

            List<SachForSelect> lstSach = dtSach.GetSachForSelect(Convert.ToInt32(MaChiTietMuon));
            gridTraSach.DataSource = lstSach;
            this.chiTietMuon = dtCTM.GetChiTietMuon(MaChiTietMuon);

            //foreach (DataGridViewRow row in gridTraSach.Rows)
            //{
            //    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells["Selected"];
            //    cell.Value = 1; // or cell.Value = 0;
            //}
            dt.Columns.Add("LyDo", typeof(string));
            dt.Columns.Add("SoTienPhat", typeof(int));

            GetTacGia(lstSach);

            labelCount.Text = gridTraSach.Rows.Count.ToString();
        }

        private void GetTacGia(List<SachForSelect> lstSach)
        {
            DataTacGia dtTacGia = new DataTacGia();
            foreach (var item in lstSach)
            {
                string tacgia = "";
                var lsTacGia = dtTacGia.GetListTacGia(item.MaSach);
                foreach (var tg in lsTacGia)
                {
                    tacgia += tg.TenTacGia + ", ";
                }
                item.TacGia = tacgia;
            }
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in gridTraSach.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Selected"].Value);
                if (isSelected)
                {
                    count++;

                }
            }
            if (count == 0)
                MessageBox.Show("Bạn cần chọn sách cần trả trước!");
            else
            {
                DataChiTietMuon dtCTM = new DataChiTietMuon();
                DataChiTietTra dtCTT = new DataChiTietTra();
                DataViPham dtViPham = new DataViPham();
                List<int> lstSach = new List<int>();
                DataDocGia dtDocGia = new DataDocGia();

                foreach (DataGridViewRow row in gridTraSach.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["Selected"].Value);
                    if (isSelected)
                    {
                        lstSach.Add((int)row.Cells["MaSach"].Value);
                    }
                }

                int MaChiTietTra = dtCTT.InsertChiTietTra(MaChiTietMuon, lstSach,3, DateTime.Now.Date <= dtCTM.GetChiTietMuon(MaChiTietMuon).HanTra ? true : false);
                foreach (DataRow row in dt.Rows)
                {
                    string LyDo = row["LyDo"].ToString();
                    int SoTienPhat = Convert.ToInt32(row["SoTienPhat"]);
                    ViPham vp = new ViPham();
                    vp.LyDo = LyDo;
                    vp.SoTienPhat = SoTienPhat;
                    vp.NgayXuLy = DateTime.Now.Date;
                    vp.MaDocGia = dtDocGia.GetMaDocGia(MaChiTietMuon);
                    vp.MaChiTietTra = MaChiTietTra;
                    //TODO sửa lại sau khi kết hợp code
                    vp.MaNguoiDung = 1;
                    dtViPham.InsertViPham(vp);
                }

                dtCTM.UpdateDaTra_ChiTietMuon(MaChiTietMuon, lstSach);

                MessageBox.Show("Trả sách thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnThemVP_Click(object sender, EventArgs e)
        {
            ViPham vp = new ViPham();

            DataDocGia dtDocGia = new DataDocGia();

            vp.LyDo = txtLyDo.Text.Trim();
            vp.SoTienPhat = Convert.ToInt32(txtSoTienPhat.Text.Trim());
            vp.MaDocGia = dtDocGia.GetMaDocGia(MaChiTietMuon);
            //TODO sửa lại MaNguoiDung khi Hy code xong
            vp.MaNguoiDung = 1;
            vp.NgayXuLy = DateTime.Now.Date;



            DataRow dr = dt.NewRow();
            dr["LyDo"] = vp.LyDo;
            dr["SoTienPhat"] = vp.SoTienPhat;
            dt.Rows.Add(dr);

            string TotalPrice = Convert.ToString(dt.Compute("SUM(SoTienPhat)", string.Empty));
            labelTienPhat.Text =  string.IsNullOrWhiteSpace(TotalPrice) ? "0" : TotalPrice.ToString();

            gridDanhSachViPham.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gridDanhSachViPham.SelectedRows.Count > 0 && !gridDanhSachViPham.SelectedRows[0].IsNewRow)
            {
                gridDanhSachViPham.Rows.Remove(gridDanhSachViPham.SelectedRows[0]);
                string TotalPrice = Convert.ToString(dt.Compute("SUM(SoTienPhat)", string.Empty));
                labelTienPhat.Text = string.IsNullOrWhiteSpace(TotalPrice) ? "0" : TotalPrice.ToString();
                // Don't call this if you have a DB to update.
                // (myGridView.DataSource as DataTable).AcceptChanges();
            }
        }
    }
}
