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
    public partial class GUIDocGia : Form
    {
        int a;
        public GUIDocGia()
        {
            InitializeComponent();
            GetListDocGia();
            HienThiLabel();
        }
        void GetListDocGia()
        {
           DocGiaHau docGia = new DocGiaHau();
           List<DocGiaModel> list = docGia.GetListDocGia();
           GridDocGia.DataSource = list;
        }
        void HienThiLabel()
        {
            DocGiaHau docGia = new DocGiaHau();
            label3.Text = Convert.ToString(docGia.GetTongDocGia());
            label4.Text = Convert.ToString(docGia.GetTongDocGiaHetHan());
            label5.Text = Convert.ToString(docGia.GetTongDocGiaSapHetHan());
        }
        private void GridPhieuMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            DocGiaHau docGia = new DocGiaHau();
            if (a == 1)
            {
                var s = docGia.Search(tbTimKiem.Text);

                if (s.Count == 0)
                    GridDocGia.DataSource = null;
                else
                {
                    GridDocGia.DataSource = docGia.Search(tbTimKiem.Text);
                }
            }
            else if (a == 2)
            {
                var s = docGia.SearchCheck1(tbTimKiem.Text);

                if (s.Count == 0)
                    GridDocGia.DataSource = null;
                else
                {
                    GridDocGia.DataSource = docGia.SearchCheck1(tbTimKiem.Text);
                }
            }
            else if (a == 3)
            {
                var s = docGia.SearchCheck2(tbTimKiem.Text);

                if (s.Count == 0)
                    GridDocGia.DataSource = null;
                else
                {
                    GridDocGia.DataSource = docGia.SearchCheck2(tbTimKiem.Text);
                }
            }
            else
            {
                var s = docGia.Search(tbTimKiem.Text);

                if (s.Count == 0)
                    GridDocGia.DataSource = null;
                else
                {
                    GridDocGia.DataSource = docGia.Search(tbTimKiem.Text);
                }
            }
        }

        private void GUIDocGia_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DocGiaHau dataDG = new DocGiaHau();
            a = 1;
            GridDocGia.DataSource = dataDG.GetListDocGia();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DocGiaHau dataDG = new DocGiaHau();
            a = 2;
            GridDocGia.DataSource = dataDG.GetListDocGiaHetHan();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            DocGiaHau dataDG = new DocGiaHau();
            a = 3;
            GridDocGia.DataSource = dataDG.GetListDocGiaSapHetHan();
        }
    }
}
