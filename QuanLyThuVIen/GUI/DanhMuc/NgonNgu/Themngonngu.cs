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
using QuanLyThuVIen.Model;



namespace QuanLyThuVIen.GUI
{
    public partial class Themngonngu : Form
    {
        public Themngonngu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataNgonNgu data = new DataNgonNgu();
            NgonNgu tam = new NgonNgu();
            tam.TenNgonNgu =this.textBox_TenNgonNgu.Text;
            tam.GhiChu = this.textBox_GhiChu.Text;
            data.InsertNN(tam);
            this.DialogResult = DialogResult.OK;
            this.Close();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
