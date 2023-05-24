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
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
            OpenChildForm(new PhieuThu());
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhieuThu());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUIDocGia());
        }


        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUISach());
        }

        
    }
}
