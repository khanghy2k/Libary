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
    public partial class PhieuThu : Form
    {
        int a;
        public PhieuThu()
        {
            InitializeComponent();
            GetListPhieu();
            GetLabelPhieu();
        }
        void GetListPhieu()
        {
            PhieuMuonHau dataPhieu = new PhieuMuonHau();
            List<PhieuMuonModel> list = dataPhieu.GetListPhieuMuon();

            GridPhieuMuon.DataSource = list;

        }
        void GetLabelPhieu()
        {
            PhieuMuonHau dtPhieuMuon = new PhieuMuonHau();
            label3.Text = Convert.ToString(dtPhieuMuon.GetTongPhieu());
            label4.Text = Convert.ToString(dtPhieuMuon.GetQuaHanChuaTra());
            label8.Text = Convert.ToString(dtPhieuMuon.GetChuaTraDu());
            label6.Text = Convert.ToString(dtPhieuMuon.GetDaTraDungHan());
            label10.Text = Convert.ToString(dtPhieuMuon.GetDaTraQuaHan());
        }

        private void PhieuThu_Load(object sender, EventArgs e)
        {

        }

        private void GridPhieuMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            PhieuMuonHau dtPhieuMuon = new PhieuMuonHau();
            if (a == 1)
            {
                var s = dtPhieuMuon.Search(tbTimKiem.Text);

                if (s.Count == 0)
                    GridPhieuMuon.DataSource = null;
                else
                {
                    GridPhieuMuon.DataSource = dtPhieuMuon.Search(tbTimKiem.Text);
                }
            }
            else if (a == 2)
            {
                var s = dtPhieuMuon.SearchQuaHanChuaTra(tbTimKiem.Text);

                if (s.Count == 0)
                    GridPhieuMuon.DataSource = null;
                else
                {
                    GridPhieuMuon.DataSource = dtPhieuMuon.SearchQuaHanChuaTra(tbTimKiem.Text);
                }
            }

            else if (a == 4)
            {
                var s = dtPhieuMuon.SearchDaTraDungHan(tbTimKiem.Text);

                if (s.Count == 0)
                    GridPhieuMuon.DataSource = null;
                else
                {
                    GridPhieuMuon.DataSource = dtPhieuMuon.SearchDaTraDungHan(tbTimKiem.Text);
                }
            }
            else if (a == 5)
            {
                var s = dtPhieuMuon.SearchChuaTraDu(tbTimKiem.Text);

                if (s.Count == 0)
                    GridPhieuMuon.DataSource = null;
                else
                {
                    GridPhieuMuon.DataSource = dtPhieuMuon.SearchChuaTraDu(tbTimKiem.Text);
                }
            }
            else if (a == 6)
            {
                var s = dtPhieuMuon.SearchDaTraQuaHan(tbTimKiem.Text);

                if (s.Count == 0)
                    GridPhieuMuon.DataSource = null;
                else
                {
                    GridPhieuMuon.DataSource = dtPhieuMuon.SearchDaTraQuaHan(tbTimKiem.Text);
                }
            }
            else
            {
                var s = dtPhieuMuon.Search(tbTimKiem.Text);

                if (s.Count == 0)
                    GridPhieuMuon.DataSource = null;
                else
                {
                    GridPhieuMuon.DataSource = dtPhieuMuon.Search(tbTimKiem.Text);
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            a = 1;
            PhieuMuonHau dataPhieu = new PhieuMuonHau();
            GridPhieuMuon.DataSource = dataPhieu.GetListPhieuMuon();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            PhieuMuonHau dataPhieu = new PhieuMuonHau();
            a = 2;
            GridPhieuMuon.DataSource = dataPhieu.GetListQuaHan();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            PhieuMuonHau dataPhieu = new PhieuMuonHau();
            a = 5;
            GridPhieuMuon.DataSource = dataPhieu.GetListChuTraDu();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            PhieuMuonHau dataPhieu = new PhieuMuonHau();
            a = 4;
            GridPhieuMuon.DataSource = dataPhieu.GetListDaTraDungHan();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            PhieuMuonHau dataPhieu = new PhieuMuonHau();
            a = 6;
            GridPhieuMuon.DataSource = dataPhieu.GetListDaTraQuaHan();
        }
    }
}
