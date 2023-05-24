using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVIen.Data
{
    public class DataChiTietTra
    {
        public int InsertChiTietTra(int MaChiTietMuon, List<int> lstMaSach, int MaNguoiDung, bool TraDungHan)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"insert into ChiTietTra (MaChiTietMuon, NgayTra, SoLuongTra, MaNguoiDung, TraDungHan) values (@MaChiTietMuon, getdate(), @SoLuongTra, @MaNguoiDung, @TraDungHan)
                           select @@identity";
                var param = new
                {
                    MaChiTietMuon = MaChiTietMuon,
                    SoLuongTra = lstMaSach.Count,
                    MaNguoiDung = MaNguoiDung,
                    TraDungHan = TraDungHan
                };
                int id = Convert.ToInt32(cnn.ExecuteScalar(sql, param));
                foreach(var item in lstMaSach)
                {
                    var sql1 = @"insert into Sach_ChiTietTra (MaChiTietTra, MaSach) values (@MaChiTietTra, @MaSach)";
                    var param1 = new
                    {
                        MaChiTietTra = id,
                        MaSach = item
                    };
                    cnn.Execute(sql1, param1);
                }
                return id;
            }
        }
    }
}
