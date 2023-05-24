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
    public partial class EditTacGia : Form
    {
        int MaSachGlobal { get; set; }
        List<TacGia> listTG = new List<TacGia>();
        public EditTacGia(ref IEnumerable<TacGia> lst, int MaSach)
        {
            InitializeComponent();
            MaSachGlobal = MaSach;
            var dataTacGia = new DataTacGia();
            List<TacGia> lstTacGia = dataTacGia.GetListTacGia();
            clbTacGia.Items.AddRange(lstTacGia.ToArray<TacGia>());
            clbTacGia.DisplayMember = "TenTacGia";
            clbTacGia.CheckOnClick = true;

            foreach (var item in lstTacGia)
            {
                foreach(var i in lst)
                {
                    if (i.MaTacGia == item.MaTacGia)
                    {
                        int index = lstTacGia.IndexOf(item);
                        clbTacGia.SetItemChecked(index, true);
                        break;
                    }
                }
            }
        }

        private void clbTacGia_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            listTG.Clear();
            foreach (var item in clbTacGia.CheckedItems)
            {
                listTG.Add((TacGia)item);
            }
            DataTacGia dttg = new DataTacGia();
            dttg.UpdateListTacGia(MaSachGlobal, listTG);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void clbTacGia_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            clbTacGia.Items.Clear();
            DataTacGia dttg = new DataTacGia();
            List<TacGia> lstTacGia = dttg.Search(txtSearchTG.Text.Trim());
            clbTacGia.Items.AddRange(lstTacGia.ToArray<TacGia>());
            clbTacGia.DisplayMember = "TenTacGia";
        }
    }
}
