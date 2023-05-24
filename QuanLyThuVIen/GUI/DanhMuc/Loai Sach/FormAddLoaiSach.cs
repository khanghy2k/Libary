using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVIen.Data;

namespace QuanLyThuVIen.GUI
{
    public partial class FormAddLoaiSach : Form
    {
        public FormAddLoaiSach()
        {
            InitializeComponent();
        }

        private void btnBackFrAdd_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnAddfrAdd_Click(object sender, EventArgs e)
        {
            string tenloai = txtTenLoai.Text;
            string ghichu = txtGhiChu.Text;
            DataLoaiSach LS = new DataLoaiSach();
            LS.AddLoaiSach(tenloai, ghichu);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
