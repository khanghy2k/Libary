using Dapper;
using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVIen.Data
{
    public class SachHau
    {
        public List<SachModel> GetListSach()
        {
            using (var cnn = DbUtils.GetConnection())
            {

                var sql = @"select s.TenSach,s.MaSach,nxb.TenNhaXuatBan,s.SoLuong,(case(s.TinhTrang) when 0 then N'Hết sách'  when 1 then N'Còn sách' end) as 'TinhTrang',s.SoLuongCon,s.DonGia
                                from Sach as s
                                join NhaXuatBan as nxb on s.MaNhaXuatBan=nxb.MaNhaXuatBan";


                var list = cnn.Query<SachModel>(sql).ToList();
                return list;
            }
        }
        public List<SachModel> Search(string searchValue)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                string search = "%" + searchValue + "%";
                var sql = @" select s.TenSach,s.MaSach,nxb.TenNhaXuatBan,s.SoLuong,(case(s.TinhTrang) when 0 then N'Hết sách'  when 1 then N'Còn sách' end) as 'TinhTrang',s.SoLuongCon,s.DonGia
                                from Sach as s
                                join NhaXuatBan as nxb on s.MaNhaXuatBan=nxb.MaNhaXuatBan
                            where  s.TenSach like @search ";

                var param = new
                {
                    searchValue = searchValue,
                    search = search,


                };

                var lstSach = cnn.Query<SachModel>(sql, param).ToList();
                return lstSach;
            }
        }
            public List<SachModel> GetListSachHetHang()
        {
            using (var cnn = DbUtils.GetConnection())
            {

                var sql = @"select s.TenSach,s.MaSach,nxb.TenNhaXuatBan,s.SoLuong,(case(s.TinhTrang) when 0 then N'Hết sách'  when 1 then N'Còn sách' end) as 'TinhTrang',s.SoLuongCon,s.DonGia
                                from Sach as s
                                join NhaXuatBan as nxb on s.MaNhaXuatBan=nxb.MaNhaXuatBan
                                where s.TinhTrang=0";


                var list = cnn.Query<SachModel>(sql).ToList();
                return list;
            }
        }
        public List<SachModel> GetListSapHetHang()
        {
            using (var cnn = DbUtils.GetConnection())
            {

                var sql = @"select s.TenSach,s.MaSach,nxb.TenNhaXuatBan,s.SoLuong,(case(s.TinhTrang) when 0 then N'Hết sách'  when 1 then N'Còn sách' end) as 'TinhTrang',s.SoLuongCon,s.DonGia
                                from Sach as s
                                join NhaXuatBan as nxb on s.MaNhaXuatBan=nxb.MaNhaXuatBan
                                where s.SoLuongCon < 7 and s.SoLuongCon >=1";


                var list = cnn.Query<SachModel>(sql).ToList();
                return list;
            }
        }
        public List<SachModel> SearchCheck1(string searchValue)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                string search = "%" + searchValue + "%";
                var sql = @"  select s.TenSach,s.MaSach,nxb.TenNhaXuatBan,s.SoLuong,(case(s.TinhTrang) when 0 then N'Hết sách'  when 1 then N'Còn sách' end) as 'TinhTrang',s.SoLuongCon,s.DonGia
                                from Sach as s
                                join NhaXuatBan as nxb on s.MaNhaXuatBan=nxb.MaNhaXuatBan
                            where  s.TenSach like @search and s.TinhTrang=0 ";

                var param = new
                {
                    searchValue = searchValue,
                    search = search,


                };

                var lstSach = cnn.Query<SachModel>(sql, param).ToList();
                return lstSach;
            }
        }
        public List<SachModel> SearchCheck2(string searchValue)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                string search = "%" + searchValue + "%";
                var sql = @"  select s.TenSach,s.MaSach,nxb.TenNhaXuatBan,s.SoLuong,(case(s.TinhTrang) when 0 then N'Hết sách'  when 1 then N'Còn sách' end) as 'TinhTrang',s.SoLuongCon,s.DonGia
                                from Sach as s
                                join NhaXuatBan as nxb on s.MaNhaXuatBan=nxb.MaNhaXuatBan
                            where  s.TenSach like @search and ( s.SoLuongCon < 7 and s.SoLuongCon >= 1) ";

                var param = new
                {
                    searchValue = searchValue,
                    search = search,


                };

                var lstSach = cnn.Query<SachModel>(sql, param).ToList();
                return lstSach;
            }
        }
        public int TongSach()
        {
            using (var cnn = DbUtils.GetConnection())
            {

                        var sql = @"  
                                    select sum(SoLuong)
                                    from sach
                                    ";



                int result = Convert.ToInt32(cnn.ExecuteScalar(sql));
                return result;
            }
        }
        public int SachConLai()
        {
            using (var cnn = DbUtils.GetConnection())
            {

                var sql = @"  
                                    select sum(SoLuongCon)
                                    from sach
                                    ";



                int result = Convert.ToInt32(cnn.ExecuteScalar(sql));
                return result;
            }
        }
    }
}
