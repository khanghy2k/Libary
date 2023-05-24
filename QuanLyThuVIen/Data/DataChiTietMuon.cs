using Dapper;
using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVIen.Data
{
    public class DataChiTietMuon
    {
        /// <summary>
        /// Lấy danh sách chi tiết mượn
        /// </summary>
        /// <returns></returns>
        public List<ChiTietMuon> GetListChiTietMuon()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                //var sql = @"SELECT s.MaSach, s.TenSach,nxb.MaNhaXuatBan, nxb.TenNhaXuatBan, s.DonGia, s.MaNgonNgu, s.NamXuatBan, s.SoLuong, s.SoTaiBan,s.TinhTrang 
                //            from Sach as s inner join NhaXuatBan as nxb on nxb.MaNhaXuatBan = s.MaNhaXuatBan";
                var sql = "select * from ChiTietMuon";
                var lstChiTietMuon = cnn.Query<ChiTietMuon>(sql).ToList();
                return lstChiTietMuon;
            }
        }
        /// <summary>
        /// Lấy thông tin chi tiết mượn theo mã chi tiết mượn
        /// </summary>
        /// <param name="MaChiTietMuon"></param>
        /// <returns></returns>
        public ChiTietMuon GetChiTietMuon(int MaChiTietMuon)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                //var sql = @"SELECT s.MaSach, s.TenSach,nxb.MaNhaXuatBan, nxb.TenNhaXuatBan, s.DonGia, s.MaNgonNgu, s.NamXuatBan, s.SoLuong, s.SoTaiBan,s.TinhTrang 
                //            from Sach as s inner join NhaXuatBan as nxb on nxb.MaNhaXuatBan = s.MaNhaXuatBan";
                var sql = "select * from ChiTietMuon where MaChiTietMuon = @MaChiTietMuon and TrangThai = 0";
                var param = new
                {
                    @MaChiTietMuon = MaChiTietMuon
                };
                var lstChiTietMuon = cnn.Query<ChiTietMuon>(sql, param).ToList();
                return lstChiTietMuon[0];
            }
        }

        public int GetSoLuongDangMuon(int MaDocGia)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"select count(*) from ChiTietMuon
                        where MaDocGia = @MaDocGia and TrangThai = 0 ";
                var param = new
                {
                    MaDocGia = MaDocGia
                };
                List<int> count = cnn.Query<int>(sql, param).ToList();
                return count[0];
            }
        }

        /// <summary>
        /// Thêm 1 chi tiết mượn
        /// </summary>
        /// <param name="ctm"></param>
        /// <returns></returns>
        public int InsertChiTietMuon(ChiTietMuon ctm)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"insert into ChiTietMuon(MaDocGia, NgayMuon, SoLuongMuon, HanTra, TrangThai, MaNguoiDung)
                            values(@MaDocGia, @NgayMuon, @SoLuongMuon, @HanTra, @TrangThai, @MaNguoiDung)
                            select @@identity";
                var param = new
                {
                    MaDocGia = ctm.MaDocGia,
                    NgayMuon = ctm.NgayMuon,
                    SoLuongMuon = ctm.SoLuongMuon,
                    HanTra = ctm.HanTra,
                    TrangThai = ctm.TrangThai,
                    MaNguoiDung = ctm.ID_NguoiDung
                };

                int id = Convert.ToInt32(cnn.ExecuteScalar(sql, param));
                return id;
            }
        }

        public void InsertSach_ChiTietMuon(int MaChiTietMuon, List<int> lstMaSach)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"insert into Sach_ChiTietMuon (MaChiTietMuon, MaSach, TrangThai) values (@MaChiTietMuon, @MaSach, 0)";
                foreach (var item in lstMaSach)
                {
                    var param = new
                    {
                        MaChiTietMuon = MaChiTietMuon,
                        MaSach = item
                    };
                    cnn.Execute(sql, param);
                }
            }
        }

        public void UpdateDaTra_ChiTietMuon(int MaChiTietMuon, List<int> lstSach)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                foreach (var item in lstSach)
                {
                    var sql = @"Update Sach_ChiTietMuon set TrangThai = 1 where MaChiTietMuon = @MaCTM and MaSach = @MaSach";
                    var param = new
                    {
                        MaSach = item,
                        MaCTM = MaChiTietMuon
                    };
                    cnn.Execute(sql, param);
                }
                var sql1 = "select count(*) from Sach_ChiTietMuon where MaChiTietMuon = @MaCTM and TrangThai = 0";
                var param1 = new
                {
                    MaCTM = MaChiTietMuon
                };
                int count = Convert.ToInt32(cnn.ExecuteScalar(sql1, param1));
                if (count == 0)
                {
                    var sql2 = "update ChiTietMuon set TrangThai = 1 where MaChiTietMuon = @MaCTM";
                    var param2 = new
                    {
                        MaCTM = MaChiTietMuon
                    };
                    cnn.Execute(sql2, param2);
                }
            }
        }
        public void UpdateHanTra(int ChiTietMuon, DateTime HanTraMoi)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"update ChiTietMuon set HanTra = @HanTra where MaChiTietMuon = @MaChiTietMuon";
                var param = new
                {
                    HanTra = HanTraMoi,
                    MaChiTietMuon = ChiTietMuon
                };
                cnn.Execute(sql, param);
            }
        }
        public void UpdateDangMuon_ChiTietMuon(int MaChiTietMuon, List<SachChoMuon> lstSach)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                foreach (var item in lstSach)
                {
                    var sql = @"Update Sach_ChiTietMuon set TrangThai = 0 where MaChiTietMuon = @MaCTM and MaSach = @MaSach
                                update ChiTietMuon set TrangThai = 0 where MaChiTietMuon = @MaCTM";
                    var param = new
                    {
                        MaSach = item.MaSach,
                        MaCTM = MaChiTietMuon
                    };
                    cnn.Execute(sql, param);
                }
            }
        }
    }
}

