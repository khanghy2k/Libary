using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVIen.Model
{
    public class ChiTietMuon
    {
        public int MaChiTietMuon { get; set; }
        public int MaDocGia { get; set; }
        public DateTime NgayMuon { get; set; }
        public int SoLuongMuon { get; set; }
        public DateTime HanTra { get; set; }
        public int ID_NguoiDung { get; set; }
        public bool TrangThai { get; set; }

    }
}
