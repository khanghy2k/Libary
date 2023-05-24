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
    public partial class FormQuanLyNguoiDung : Form
    {
        public FormQuanLyNguoiDung()
        {
            InitializeComponent();
          
            var getlist = new DataNguoiDung();
            var data = getlist.GetListManager();
            bs_QuanLy.DataSource = data;
            dataGridView_QuanLy.DataSource = bs_QuanLy;
            dataGridView_QuanLy.AutoGenerateColumns = false;


            if (bs_QuanLy.DataSource != null)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void FormQuanLyNguoiDung_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView_QuanLy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_TimKiem_TextChanged(object sender, EventArgs e)
        {
            DataNguoiDung dtSach = new DataNguoiDung();
            this.bs_QuanLy.DataSource = dtSach.GetListNguoiDung(this.textBox_TimKiem.Text.Trim());
            this.dataGridView_QuanLy.DataSource = bs_QuanLy;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataGridViewRow selectedRow = dataGridView_QuanLy.CurrentRow;
            if (selectedRow.DataBoundItem != null)
            {

                NguoiDung ss = (NguoiDung)selectedRow.DataBoundItem;
                ThongTinChiTietQuanLy form_thongtin = new ThongTinChiTietQuanLy(ss);
                form_thongtin.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var getlist = new DataNguoiDung();
            var data = getlist.GetListManager();
            bs_QuanLy.DataSource = data;
            dataGridView_QuanLy.DataSource = bs_QuanLy;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormThemNguoiDung fr = new FormThemNguoiDung();
            fr.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
