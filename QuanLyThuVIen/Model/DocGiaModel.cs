using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVIen.Model
{
    public class DocGiaModel
    {
        public int MaDocGia { get;set; }
        public string TenDocGia { get; set; }
        public DateTime NgaySinh { get; set; }
        public string TenChucDanh { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime NgayDangKy { get; set; }
        public DateTime NgayHetHan { get; set; }

    }
}
