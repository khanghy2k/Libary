using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVIen.Model
{
    public class DocGia
    {
        public int MaDocGia { get; set; }
        public string TenDocGia { get; set; }
        public DateTime NgaySinh { get; set; }
        public int MaChucDanh { get; set; }
        public Boolean GioiTinh { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime NgayDangKy { get; set; }
        public DateTime NgayHetHan { get; set; }
        public string Lop { get; set; }
        public int MaKhoa { get; set; }
        public int KhoaHoc { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int MaTrangThai { get; set; }
    }
}
