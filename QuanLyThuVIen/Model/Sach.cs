using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVIen.Model
{
    public class Sach
    {
        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public IList<TacGia> DanhSachTacGia { get; set; }
        public int MaNhaXuatBan { get; set; }
        public int MaNgonNgu { get; set; }
        public int NamXuatBan { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public int SoTaiBan { get; set; }
        public bool TinhTrang { get; set; }
        public string Anh { get; set; }
        public int MaLoaiSach { get; set; }

        public string AnhWeb { get; set; }
        public Sach()
        {

        }
    }
}
