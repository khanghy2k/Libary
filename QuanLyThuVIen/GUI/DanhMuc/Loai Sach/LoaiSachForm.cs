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

    public partial class LoaiSachForm : Form
    {

        public int mls;
        public LoaiSachForm()
        {
            InitializeComponent();
            var loaisach = new DataLoaiSach();
            var lstLS = loaisach.GetListLoaiSach();
            bsLoaiSach.DataSource = lstLS;
            GridLoaiSach.DataSource = bsLoaiSach;
            GridLoaiSach.AutoGenerateColumns = false;
        }

        public void reload()
        {
            var loaisach = new DataLoaiSach();
            var lstLS = loaisach.GetListLoaiSach();
            bsLoaiSach.DataSource = lstLS;
            GridLoaiSach.DataSource = bsLoaiSach;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GridLoaiSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = GridLoaiSach.Rows[e.RowIndex];

                mls = Convert.ToInt32(row.Cells["MaLoai"].Value);


            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            var seachValue = searchBox.Text;
            DataLoaiSach dataloaisach = new DataLoaiSach();
            var lstloaisach = dataloaisach.GetListLoaiSach1(seachValue);
            bsLoaiSach.DataSource = lstloaisach;
            GridLoaiSach.DataSource = bsLoaiSach;

            GridLoaiSach.AutoGenerateColumns = false;
        }



        /// <summary>
        /// Them loai sách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddLoaiSach form = new FormAddLoaiSach();
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                reload();
            }
        }



        /// <summary>
        /// Xoa Loai Sach
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {

            var dataLS = new DataLoaiSach();
            if (mls > 0)
            {
                if (dataLS.Inused(mls) == 1)
                {
                    MessageBox.Show("Không thành công! Loại sách này có liên quan đến trường dữ liệu khác");
                }
                else
                {
                    var confirmResult = MessageBox.Show("Xác nhận xóa loại sách", "", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        dataLS.DelLoaiSach(mls);
                        reload();
                    }
                    else
                    {
                        // If 'No', do something here.
                    }
                    
                }

            }
            reload();

        }


        /// <summary>
        /// Sua loai sach
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditLoaiSach form = new EditLoaiSach(mls);
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                reload();
            }
        }
    }
}
