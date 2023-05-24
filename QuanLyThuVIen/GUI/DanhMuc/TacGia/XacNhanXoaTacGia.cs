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
    public partial class XacNhanXoaTacGia : Form
    {
        int matacgia;
        public XacNhanXoaTacGia(int tam)
        {
            InitializeComponent();
            matacgia = tam;

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DataTacGia tam = new DataTacGia();
            tam.Delete(matacgia);
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
