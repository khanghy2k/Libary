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
using QuanLyThuVIen.Model;

namespace QuanLyThuVIen.GUI
{
    public partial class EditLoaiSach : Form
    {

        public int maloaisach;
        public EditLoaiSach()
        {
            InitializeComponent();
        }


        public EditLoaiSach(int mls) : this()
        {
            maloaisach = mls;
            var datals = new DataLoaiSach();
            LoaiSach ls = datals.GetLoaiSach(mls);
            txtTenLoai.Text = ls.TenLoai;
            txtGhiChu.Text = ls.GhiChu;
            




        }
        private void btnBackFrEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditFrEdit_Click(object sender, EventArgs e)
        {
            LoaiSach ls = new LoaiSach()
            {
                TenLoai = txtTenLoai.Text,
                GhiChu = txtGhiChu.Text,
            };

            DataLoaiSach dtls = new DataLoaiSach();

            dtls.UpdateLoaiSach(maloaisach, ls);
            this.DialogResult = DialogResult.OK;

            //var lstTT = addthuthu.GetListThuThu();

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
