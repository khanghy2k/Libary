using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVIen.Model
{
    public class PhieuMuonModel
    {
       public int MaChiTietMuon { get; set; }
        public string TenDocGia { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime HanTra { get; set; }
        public DateTime NgayTra { get; set; }
        public int SoLuongMuon { get; set; }
        public int SoLuongTra { get; set; }

        public string TrangThai { get; set; }
        public bool TraDungHan { get; set; }
    }
}
