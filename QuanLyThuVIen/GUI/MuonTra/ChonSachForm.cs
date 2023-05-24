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
    public partial class ChonSachForm : Form
    {
        public delegate void TruyenChoMuonTraForm(List<int> lsSach);
        public TruyenChoMuonTraForm truyenData;
        private List<int> lsMaSach;
        public ChonSachForm()
        {
            InitializeComponent();
        }
        public ChonSachForm(List<int> lstMaSach)
        {
            InitializeComponent();
            this.lsMaSach = lstMaSach;
        }
        private void ChonSachForm_Load(object sender, EventArgs e)
        {


            DataSach dtSach = new DataSach();
            DataTacGia dtTacGia = new DataTacGia();

            var lstSach = dtSach.GetSachForSelect();
            bsSach.DataSource = lstSach;
            gridChonSach.DataSource = bsSach;
            gridChonSach.AutoGenerateColumns = false;

            if (lsMaSach != null)
            {
                foreach (DataGridViewRow row in gridChonSach.Rows)
                {
                    int MaSach = (int)row.Cells["MaSach"].Value;
                    if (lsMaSach.Contains(MaSach))
                    {
                        DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells["Selected"];

                        cell.Value = 1; // or cell.Value = 0;
                    }
                }
            }

            GetTacGia(lstSach);
        }


        private void btnApDung_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            {
                foreach (DataGridViewRow row in gridChonSach.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["Selected"].Value);
                    if (isSelected)
                    {
                        list.Add(Convert.ToInt32(row.Cells["MaSach"].Value));

                    }
                }
            }
            DataChiTietMuon dtCTm = new DataChiTietMuon();
            if (list.Count > 5)
                MessageBox.Show("Mỗi độc giả chỉ được mượn tối đa 5 quyển sách một lúc!");
            else
                truyenData(list);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataSach dtSach = new DataSach();
            DataTacGia dtTacGia = new DataTacGia();

            var lstSach = dtSach.SearchSachForSelect(txtSearchSach.Text);
            bsSach.DataSource = lstSach;
            GetTacGia(lstSach);
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

        private void cbSachCon_CheckedChanged(object sender, EventArgs e)
        {
            DataSach dtSach = new DataSach();
            var lstSach = new List<SachForSelect>();
            if (cbSachCon.Checked)
            {
                lstSach = dtSach.GetListSachConTrongThuVien();
                bsSach.DataSource = lstSach;
                GetTacGia(lstSach);
            }
            else
            {
                lstSach = dtSach.GetSachForSelect();
                bsSach.DataSource = lstSach;
                GetTacGia(lstSach);

            }
        }
    }
}
