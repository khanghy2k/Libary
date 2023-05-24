using QuanLyThuVIen.Data;
using QuanLyThuVIen.GUI;
using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVIen
{
    public partial class FormMain : Form
    {
        public int Manguoi;
        int MaSachGlobal { get; set; }
        public FormMain()
        {
            InitializeComponent();
        }
        public FormMain(int Manguoidung)
        {
            Manguoi = Manguoidung;
            InitializeComponent();
            this.MaximizeBox = true;
        
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Size = this.mainPanel.Size;
           
            f.Show();
        }

        private void btnBookManager_Click(object sender, EventArgs e)
        {
            loadForm(new BookManagerForm());
            
        }

        private void btnMuonTra_Click(object sender, EventArgs e)
        {
            loadForm(new MuonTraForm());
        }
        

        private void btnUserManage_Click_1(object sender, EventArgs e)
        {
            loadForm(new UserManagerForm());
            
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            loadForm(new TaikhoanForm(Manguoi));
        }

        private void btnStatisticsReport_Click(object sender, EventArgs e)
        {
            loadForm(new FormThongKe());
        }

        private void btnCategoryManage_Click(object sender, EventArgs e)
        {
            loadForm(new CategoryManagerForm());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }





    }
}
