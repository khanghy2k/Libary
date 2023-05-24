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
    public partial class GUISach : Form
    {
        int a;
        public GUISach()
        {
            InitializeComponent();
            GetListSachGui();
            HienThiLabel();
        }
        void GetListSachGui()
        {
            SachHau dataSach = new SachHau();
            List<SachModel> list = dataSach.GetListSach();
            GridSach.DataSource = list;

        }
        void HienThiLabel()
        {
            SachHau dataSach = new SachHau();
            label3.Text = Convert.ToString(dataSach.TongSach());
            label4.Text = Convert.ToString(dataSach.SachConLai());
        }
        private void GUISach_Load(object sender, EventArgs e)
        {

        }

        private void GridGuiSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            SachHau sachData = new SachHau();
            if (a == 1)
            {
                var s = sachData.SearchCheck1(tbTimKiem.Text);

                if (s.Count == 0)
                    GridSach.DataSource = null;
                else
                {
                    GridSach.DataSource = sachData.SearchCheck1(tbTimKiem.Text);
                }
            }
            else if (a == 3)
            {
                var s = sachData.SearchCheck2(tbTimKiem.Text);

                if (s.Count == 0)
                    GridSach.DataSource = null;
                else
                {
                    GridSach.DataSource = sachData.SearchCheck2(tbTimKiem.Text);
                }
            }
            else
            {
                var s = sachData.Search(tbTimKiem.Text);

                if (s.Count == 0)
                    GridSach.DataSource = null;
                else
                {
                    GridSach.DataSource = sachData.Search(tbTimKiem.Text);
                }
            }
           
            
        }

      

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SachHau dataSach = new SachHau();
            a = 1;
            GridSach.DataSource = dataSach.GetListSachHetHang();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SachHau dataSach = new SachHau();
            a = 2;
            GridSach.DataSource = dataSach.GetListSach();
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            SachHau dataSach = new SachHau();
            a = 3;
            GridSach.DataSource = dataSach.GetListSapHetHang();
        }
    }
}
