using Dapper;
using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVIen.Data
{
    public class DataViPham
    {
        public int InsertViPham(ViPham vp)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"insert into ViPham (MaDocGia, LyDo, SoTienPhat, MaNguoiDung, NgayXuLy, MaChiTietTra)
                            values(@MaDocGia, @LyDo, @SoTienPhat, @MaNguoiDung, @NgayXuLy, @MaChiTietTra)
                            select @@identity";
                var param = new
                {
                    MaDocGia = vp.MaDocGia,
                    LyDo = vp.LyDo,
                    SoTienPhat = vp.SoTienPhat,
                    MaNguoiDung = vp.MaNguoiDung,
                    NgayXuLy = vp.NgayXuLy,
                    MaChiTietTra = vp.MaChiTietTra
                };
                int MaChiTietTra = Convert.ToInt32(cnn.Execute(sql, param));
                return MaChiTietTra;
                
            }
        }
    }
}
