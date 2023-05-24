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
    public partial class DanhMucTacGia : Form
    { int matacgia;
        public DanhMucTacGia()
        {
            InitializeComponent();
            Load();

        }
        private void Load()
        {
            DataTacGia lst = new DataTacGia();
            this.bs_source.DataSource = lst.GetListTacGia();
            dataGrid_tacgia.DataSource = bs_source;
            dataGrid_tacgia.AutoGenerateColumns = false;
            this.button2.Enabled = false;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTacGia dtSach = new DataTacGia();
            bs_source.DataSource = dtSach.Search(this.txtSearch.Text.Trim());
            dataGrid_tacgia.DataSource = bs_source;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormThemTacGia fr = new FormThemTacGia();
            fr.ShowDialog();
            if(fr.DialogResult == DialogResult.OK)
            {
                Load();
            }
        }

        private void dataGrid_tacgia_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = dataGrid_tacgia.CurrentRow;
            if (selectedRow.DataBoundItem != null)
            {
                DataTacGia lst = new DataTacGia();
                TacGia ss = (TacGia)selectedRow.DataBoundItem;
                this.textbox_TenTacGia.Text = ss.TenTacGia;
                this.textBox_GhiChu.Text = ss.GhiChu;
                matacgia = ss.MaTacGia;
                if (lst.Inused(matacgia) == 0)
                {

                    this.button2.Enabled = false;
                }
                if (lst.Inused(matacgia) == 1)
                {
                    this.button2.Enabled = true;

                }


            }
        }

        private void DanhMucTacGia_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)

        {
            XacNhanXoaTacGia tam = new XacNhanXoaTacGia(matacgia);
            tam.ShowDialog();
            if(tam.DialogResult == DialogResult.OK)
            {
                DataTacGia dtTacGia = new DataTacGia();
                dtTacGia.Delete(matacgia);
            }
            Load();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGrid_tacgia.CurrentRow;
            if (selectedRow.DataBoundItem != null)
            {
                DataTacGia data = new DataTacGia();
                TacGia tam = new TacGia();
                tam.GhiChu = this.textBox_GhiChu.Text;
                tam.TenTacGia = this.textbox_TenTacGia.Text;
                tam.MaTacGia = matacgia;
                data.UpdateTacGia(tam);
                DataTacGia lst = new DataTacGia();
                this.bs_source.DataSource = lst.GetListTacGia();
                dataGrid_tacgia.DataSource = bs_source;
                dataGrid_tacgia.AutoGenerateColumns = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGrid_tacgia.CurrentRow;
            DataTacGia lst = new DataTacGia();
            TacGia ss = (TacGia)selectedRow.DataBoundItem;
            this.textbox_TenTacGia.Text = ss.TenTacGia;
            this.textBox_GhiChu.Text = ss.GhiChu;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTacGia lst = new DataTacGia();
            this.bs_source.DataSource = lst.GetListTacGia();
            dataGrid_tacgia.DataSource = bs_source;
            dataGrid_tacgia.AutoGenerateColumns = false;
        }

        private void dataGrid_tacgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGrid_tacgia_Click(object sender, EventArgs e)
        {            

        }
    }
}
