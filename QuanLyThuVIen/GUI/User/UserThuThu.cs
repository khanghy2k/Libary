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
    public partial class UserThuThu : Form
    {
        public int mnd;
        public UserThuThu()
        {
            InitializeComponent();
            var thuthu = new DataNguoiDung();
            var lstTT = thuthu.GetListThuThu();
            bsThuThu.DataSource = lstTT;
            GridThuThu.DataSource = bsThuThu;
            GridThuThu.AutoGenerateColumns = false;
            
            if(LoginInfo.MaChucVu != 2)
            {
                btnAdd.Enabled = false;
                button1.Enabled = false;
                button3.Enabled = false;
            }
            
            //Nạp khoa vào combobox
            //var dataKhoa = new DataKhoa();
            //var lstKhoa = dataKhoa.GetListKhoa();
            //cbbKhoa.Text = "--Khoa--";
            //cbbKhoa.DisplayMember = "TenKhoa";
            //cbbKhoa.DataSource = lstKhoa;

                //Nap chức danh vào combobox
                //var dataCD = new DataChucDanh();
                //cbbNamSinh.DataSource = dataCD.GetListChucDanh();
                //cbbNamSinh.DisplayMember = "TenChucDanh";

        }


        /// <summary>
        /// load lai trang
        /// </summary>
        public void reload()
        {
            var thuthu = new DataNguoiDung();
            var lstTT = thuthu.GetListThuThu();
            bsThuThu.DataSource = lstTT;
            GridThuThu.DataSource = bsThuThu;
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        /// <summary>
        /// chon gioi tinh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataNguoiDung dtNguoiDung = new DataNguoiDung();
            var lstThuThu = dtNguoiDung.GetListManager();

           
        }

        private void cbbNamSinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Tim kiem thong tin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            
            var seachValue = TimKiem.Text;
            DataNguoiDung dtNguoiDung = new DataNguoiDung();
            var lstThuThu = dtNguoiDung.GetListNguoiDung1(seachValue);
            bsThuThu.DataSource = lstThuThu;
            GridThuThu.DataSource = bsThuThu;

            GridThuThu.AutoGenerateColumns = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddThuThu form = new AddThuThu();
           
            
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                reload();
            }
            
        }


        /// <summary>
        /// Sua thong tin thu thu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            EditThuThu form = new EditThuThu(mnd);

            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                reload();
            }
            
            //dtnd.UpdateThuThu(nd);
            //DialogResult dr = form.ShowDialog();
            //if (dr == DialogResult.OK)
            //{
            //    reload();
            //}
            //else
            //{
            //    form.Show();
            //}
        }

        private void GridThuThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        /// <summary>
        /// Xoa thu thu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        { 
           
            var dataTT = new DataNguoiDung();
            if (mnd > 0)
            {
                if (dataTT.InUsed(mnd) == 1)
                {
                    
                    MessageBox.Show("Không thành công! Thủ thư này đang cho độc giả mượn sách");

                }
                else
                {
                    var confirmResult = MessageBox.Show("Xác nhận xóa thủ thư", "", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        dataTT.DelThuThu(mnd);
                        reload();
                    }
                    else
                    {
                        // If 'No', do something here.
                    }
                }
                reload();

            }
            var thuthu = new DataNguoiDung();
            var lstTT = thuthu.GetListThuThu();
            bsThuThu.DataSource = lstTT;
            GridThuThu.DataSource = bsThuThu;


            //if ( user == null )
            //{
            //    MessageBox.Show("Vui long chon thu thu muon xoa");
            //}
            //else
            //{
            //    var datathuthu = new DataNguoiDung();
            //    if (datathuthu.InUsed(mathuthu) == false)
            //}

        }


        /// <summary>
        /// Lay ma thu thu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridThuThu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = GridThuThu.Rows[e.RowIndex];

                mnd = Convert.ToInt32(row.Cells["MaNguoiDung"].Value);
                
             
            }
            
        }

        private void bsThuThu_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
