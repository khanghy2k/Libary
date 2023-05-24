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

    public partial class FormNgonNgu : Form
    {
        int MaNgonNgu;
        public FormNgonNgu()
        {

            InitializeComponent();
            Load();
        }
        public void Load()
        {
        
            DataNgonNgu lst = new DataNgonNgu();
            this.bs_ngonngu.DataSource = lst.GetListNgonNgu();
            gridNgonNgu.DataSource = bs_ngonngu;
            gridNgonNgu.AutoGenerateColumns = false;
            this.button2.Enabled = false;
        }


        private void gridSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Themngonngu fr = new Themngonngu();
            
            fr.ShowDialog();
            if(fr.DialogResult==DialogResult.OK)
            {
                Load();
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Xác nhận xóa ngôn ngữ này?", "", MessageBoxButtons.YesNo);
            if(rs == DialogResult.Yes)
            {
                DataNgonNgu tam = new DataNgonNgu();
                tam.DeleteNN(MaNgonNgu);
                textBox_GhiChu.Text = null;
                textbox_TenNgonNgu.Text = null;
                Load();
            }    
            

        }
        private void dataGrid_tacgia_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = gridNgonNgu.CurrentRow; 
            if (e.RowIndex >0)
            {
                DataNgonNgu lst = new DataNgonNgu();
                NgonNgu ss = (NgonNgu)selectedRow.DataBoundItem;
                this.textbox_TenNgonNgu.Text = ss.TenNgonNgu;
                this.textBox_GhiChu.Text = ss.GhiChu;
              
                MaNgonNgu = ss.MaNgonNgu;
                if (lst.Inused(MaNgonNgu) == 0)
                {

                    this.button2.Enabled = false;
                }
                if (lst.Inused(MaNgonNgu) == 1)
                {
                    this.button2.Enabled = true;

                }


            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = gridNgonNgu.CurrentRow;
            if (selectedRow.DataBoundItem != null)
            {
                DataNgonNgu f = new DataNgonNgu();
                NgonNgu tam = new NgonNgu();
                tam.TenNgonNgu = this.textbox_TenNgonNgu.Text;
                tam.MaNgonNgu = MaNgonNgu;
                tam.GhiChu = this.textBox_GhiChu.Text;
                f.UpdateNgonNgu(tam);
                DataNgonNgu lst = new DataNgonNgu();
                this.bs_ngonngu.DataSource = lst.GetListNgonNgu();
                gridNgonNgu.DataSource = bs_ngonngu;
                gridNgonNgu.AutoGenerateColumns = false;



            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = gridNgonNgu.CurrentRow;
            DataNgonNgu lst = new DataNgonNgu();
            NgonNgu ss = (NgonNgu)selectedRow.DataBoundItem;
            this.textbox_TenNgonNgu.Text = ss.TenNgonNgu;
            this.textBox_GhiChu.Text = ss.GhiChu;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataNgonNgu dtnn = new DataNgonNgu();
            bs_ngonngu.DataSource = dtnn.SearchNN(this.txtSearch.Text.Trim());
            gridNgonNgu.DataSource = bs_ngonngu;
        }
    }
}
