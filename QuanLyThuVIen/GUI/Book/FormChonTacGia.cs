using QuanLyThuVIen.Data;
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
    public partial class FormChonTacGia : Form
    {
        public delegate void TruyenChoMuonTraForm(List<int> lsSach);
        public TruyenChoMuonTraForm truyenData;
        private List<int> lstTacGia;
        public FormChonTacGia()
        {
            InitializeComponent();
            DataTacGia dtTG = new DataTacGia();
            gridTacGia.DataSource = dtTG.GetListTacGia();
        }
        public FormChonTacGia(List<int> listMaTacGia)
        {
            InitializeComponent();
            this.lstTacGia = listMaTacGia;

        }

        private void btnThemTG_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            {
                foreach (DataGridViewRow row in gridTacGia.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["Selected"].Value);
                    if (isSelected)
                    {
                        list.Add(Convert.ToInt32(row.Cells["MaTacGia"].Value));
                    }
                }
            }
            truyenData(list);
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void gridTacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormChonTacGia_Load(object sender, EventArgs e)
        {
            DataTacGia dtTG = new DataTacGia();
            gridTacGia.DataSource = dtTG.GetListTacGia();
            if (lstTacGia != null)
            {
                foreach (DataGridViewRow row in gridTacGia.Rows)
                {
                    int MaTacGia = (int)row.Cells["MaTacGia"].Value;
                    if (lstTacGia.Contains(MaTacGia))
                    {
                        DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells["Selected"];
                        row.Cells["Selected"].Value = 1;
                        cell.Value = 1;
                    }
                }
            }
        }
    }
}
