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
    public partial class ThemNXB : Form
    {
        public int MaNhaXuatBan1;
        public ThemNXB()
        {
            InitializeComponent();
            label1.Text = "THÊM NHÀ XUẤT BẢN";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var NhaXB = new DataNXB();
            NhaXuatBan NXB = new NhaXuatBan()
            {
                TenNhaXuatBan = textBox1.Text.Trim(),
                GhiChu = richTextBox1.Text.Trim()
            };
            if (MaNhaXuatBan1 > 0)
            {
                NXB.MaNhaXuatBan = MaNhaXuatBan1;
                if (NhaXB.UpdateNXB(NXB))
                {
                    MessageBox.Show("Chỉnh sửa nhà xuất bản thành công!");
                }
                else
                    MessageBox.Show("Chỉnh sửa nhà xuất bản không thành công!");
            }
            else
            {
                if (NXB != null)
                {
                    NhaXB.InsertNXB(NXB);
                    MessageBox.Show("Thêm nhà xuất bản thành công!");
                }
                else
                    MessageBox.Show("Thêm nhà xuất bản thất bại!");
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }
        public ThemNXB(int MaNhaXuatBan)
        {
            InitializeComponent();
            label1.Text = "CHỈNH SỬA NHÀ XUẤT BẢN";
            MaNhaXuatBan1 = MaNhaXuatBan;
            var NhaXB = new DataNXB();
            NhaXuatBan NXB = NhaXB.GetNXB(MaNhaXuatBan);
            textBox1.Text = NXB.TenNhaXuatBan;
            richTextBox1.Text = NXB.GhiChu;
        }
    }
}
