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
    public partial class FormDanhSachDangCho : Form
    {
        private int MaCTMGlobal;
        private List<SachChoMuon> lsGlobal;
        public FormDanhSachDangCho()
        {
            InitializeComponent();
            Load();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
        private void GetTacGia(List<SachChoMuon> lstSach)
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

        private void gridMuon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataSach dtSach = new DataSach();
                DataGridViewRow row = gridMuon.Rows[e.RowIndex];
                int MaChiTietMuon = Convert.ToInt32(row.Cells["MaChiTietMuon"].Value.ToString());
                List<SachChoMuon> lstS = dtSach.GetSachChoMuon(MaChiTietMuon);

                GetTacGia(lstS);

                gridDSSach.DataSource = lstS;
                gridDSSach.AutoGenerateColumns = false;
                lsGlobal = lstS;
                MaCTMGlobal = MaChiTietMuon;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataChiTietMuon dtCTM = new DataChiTietMuon();
            var confirmResult = MessageBox.Show("Xác nhận đã cho độc giả mượn sách?", "", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                dtCTM.UpdateDangMuon_ChiTietMuon(MaCTMGlobal, lsGlobal);
                Load();
                gridDSSach.DataSource = null;
            }
            else
            {
                // If 'No', do something here.
            }
        }

        private void gridMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Load()
        {
            DataDocGia_MuonSach dtDGMS = new DataDocGia_MuonSach();
            var lst = dtDGMS.GetListDangChoMuon();

            bsMuonSach.DataSource = lst;

            gridMuon.DataSource = bsMuonSach;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
