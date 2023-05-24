using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVIen.Model
{
    public class ViPham
    {
        public int MaViPham { get; set; }
        public int MaDocGia { get; set; }
        public string LyDo { get; set; }
        public int SoTienPhat { get; set; }
        public int MaNguoiDung { get; set; }
        public DateTime NgayXuLy { get; set; }
        public int MaChiTietTra { get; set; }
    }
}
