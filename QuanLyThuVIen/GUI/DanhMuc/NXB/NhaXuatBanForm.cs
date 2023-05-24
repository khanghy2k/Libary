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
    public partial class NhaXuatBanForm : Form
    {
        public int MaNhaXuatBan;
        public NhaXuatBanForm()
        {
            InitializeComponent();
            var NXB = new DataNXB();
            bindingSource1.DataSource = NXB.GetListNXB();
            dataGridView1.DataSource = bindingSource1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var NXB = new DataNXB();
            bindingSource1.DataSource = NXB.GetListNXB1(textBox1.Text.Trim());
            dataGridView1.DataSource = bindingSource1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new ThemNXB();
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Load_form();
            }
        }

        public void Load_form()
        {
            var NXB = new DataNXB();
            bindingSource1.DataSource = NXB.GetListNXB();
            dataGridView1.DataSource = bindingSource1;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                MaNhaXuatBan = Convert.ToInt32(row.Cells["colMaNhaXuatBan"].Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MaNhaXuatBan > 0)
            {
                var frm = new ThemNXB(MaNhaXuatBan);
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Load_form();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MaNhaXuatBan > 0)
            {
                MessageBox.Show("Bạn muốn xóa nhà xuất bản này hay không?");
                var NhaXB = new DataNXB();
              
                if (NhaXB.DeleteNXB(MaNhaXuatBan))
                    MessageBox.Show("Xóa nhà xuất bản thành công!");
                else
                    MessageBox.Show("Xóa nhà xuất bản thất bại!");
                Load_form();


            }
        }
    }
}
