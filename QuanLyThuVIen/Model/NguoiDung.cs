using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVIen.Model
{
     public class NguoiDung
    {
        public int MaNguoiDung{ get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public int MaChucVu { get; set; }
        public bool GioiTinh { get; set; }
        public string GetGioiTinh {
            get
            {
                if (this.GioiTinh == true)
                {
                    return "Nam";
                }
                else
                    return "Nữ";
            }
            }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool TrangThai { get; set; } 
    }
}
