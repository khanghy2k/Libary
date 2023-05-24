using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVIen.Model
{
    public class LichSuMuon
    {
        public int MaChiTietMuon { get; set; }
        public int MaDocGia { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime HanTra { get; set; }
        public int SoLuongMuon { get; set; }
        public int MaNguoiDung { get; set; }
        public bool TrangThai { get; set; }

    }
}
