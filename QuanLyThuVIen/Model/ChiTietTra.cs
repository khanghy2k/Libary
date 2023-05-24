using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVIen.Model
{
    public class ChiTietTra
    {
        public int MaChiTietTra { get; set; }
        public int MaChiTietMuon { get; set; }
        public DateTime NgayTra { get; set; }
        public int SoLuong { get; set; }
        public int MaNguoiDung { get; set; }
        public bool TraDungHan { get; set; }
    }
}
