using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVIen.Model
{
    public class DocGia_MuonSach
    {
        public int MaDocGia { get; set; }
        public int MaChiTietMuon { get; set; }
        public string TenDocGia { get; set; }
        public DateTime NgayMuon { get; set; }
        public int SoLuongMuon { get; set; }
        public DateTime HanTra { get; set; }
        public bool TinhTrang { get; set; }

    }
}
