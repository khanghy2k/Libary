using Dapper;
using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVIen.Data
{
    public class LichSuMuonTra
    {
        public List<LichSuMuon> ListLSMuon(int MaDocGia)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "select * from ChiTietMuon where MaDocGia=@MaDocGia";
                var param = new
                {
                    MaDocGia = MaDocGia
                };
                var lstSach = cnn.Query<LichSuMuon>(sql,param).ToList();
                return lstSach;
            }
        }
        public List<ChiTietSachMuon> ListCTMuon(int MaChiTietMuon)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "select * from Sach_ChiTietMuon where MaChiTietMuon=@MaChiTietMuon";
                var param = new
                {
                    MaChiTietMuon = MaChiTietMuon
                };
                var lstSach = cnn.Query<ChiTietSachMuon>(sql, param).ToList();
                return lstSach;
            }
        }
        public string checkNT(int MaSach, int MaChiTietMuon)
        {    
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"select NgayTra from ChiTietTra as t
                           join Sach_ChiTietTra as s on s.MaChiTietTra = t.MaChiTietTra
                           where s.MaSach = @MaSach and MaChiTietMuon = @MaChiTietMuon";
                var param = new
                {
                    MaChiTietMuon = MaChiTietMuon,
                    MaSach = MaSach
                };
                string count = Convert.ToString(cnn.ExecuteScalar(sql, param));
                return count;

            }
        }
        public int checkDH(int MaSach, int MaChiTietMuon)
        {
            
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"select TraDungHan from ChiTietTra as t
                           join Sach_ChiTietTra as s on s.MaChiTietTra = t.MaChiTietTra
                           where s.MaSach = @MaSach and MaChiTietMuon = @MaChiTietMuon";
                var param = new
                {
                    MaChiTietMuon = MaChiTietMuon,
                    MaSach = MaSach
                };
                int count = Convert.ToInt32(cnn.ExecuteScalar(sql, param));
                return count;

            }
        }
    }
}
