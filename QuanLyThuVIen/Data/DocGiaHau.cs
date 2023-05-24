using Dapper;
using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVIen.Data
{
    public class DocGiaHau
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<DocGiaModel> GetListDocGia()
        {
            using (var cnn = DbUtils.GetConnection())
            {

                var sql = @" select dg.MaDocGia,dg.TenDocGia,dg.NgaySinh,cd.TenChucDanh,dg.Email,dg.SoDienThoai,dg.NgayDangKy,dg.NgayHetHan
                            from DocGia as dg
                            join ChucDanh as cd on dg.MaChucDanh=cd.MaChucDanh";


                var list = cnn.Query<DocGiaModel>(sql).ToList();
                return list;
            }
        }
        public List<DocGiaModel> Search(string searchValue)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                string search = "%" + searchValue + "%";
                var sql = @"  select dg.MaDocGia,dg.TenDocGia,dg.NgaySinh,cd.TenChucDanh,dg.Email,dg.SoDienThoai,dg.NgayDangKy,dg.NgayHetHan
                            from DocGia as dg
                            join ChucDanh as cd on dg.MaChucDanh=cd.MaChucDanh
                            where  dg.TenDocGia like @search ";

                var param = new
                {
                    searchValue = searchValue,
                    search = search,


                };

                var lstSach = cnn.Query<DocGiaModel>(sql, param).ToList();
                return lstSach;
            }
        }
        public List<DocGiaModel> GetListDocGiaHetHan()
        {
            using (var cnn = DbUtils.GetConnection())
            {

                var sql = @"select dg.MaDocGia,dg.TenDocGia,dg.NgaySinh,cd.TenChucDanh,dg.Email,dg.SoDienThoai,dg.NgayDangKy,dg.NgayHetHan
                            from DocGia as dg
                            join ChucDanh as cd on dg.MaChucDanh=cd.MaChucDanh
                            where  DATEDIFF(day, GetDate(), dg.NgayHetHan) < 0";


                var list = cnn.Query<DocGiaModel>(sql).ToList();
                return list;
            }
        }
        public List<DocGiaModel> SearchCheck1(string searchValue)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                string search = "%" + searchValue + "%";
                var sql = @"  select dg.MaDocGia,dg.TenDocGia,dg.NgaySinh,cd.TenChucDanh,dg.Email,dg.SoDienThoai,dg.NgayDangKy,dg.NgayHetHan
                            from DocGia as dg
                            join ChucDanh as cd on dg.MaChucDanh=cd.MaChucDanh
                            where  dg.TenDocGia like @search and DATEDIFF(day, GetDate(), dg.NgayHetHan) < 0 ";

                var param = new
                {
                    searchValue = searchValue,
                    search = search,


                };

                var lstSach = cnn.Query<DocGiaModel>(sql, param).ToList();
                return lstSach;
            }
        }
        public List<DocGiaModel> GetListDocGiaSapHetHan()
        {
            using (var cnn = DbUtils.GetConnection())
            {

                var sql = @"select dg.MaDocGia,dg.TenDocGia,dg.NgaySinh,cd.TenChucDanh,dg.Email,dg.SoDienThoai,dg.NgayDangKy,dg.NgayHetHan
                            from DocGia as dg
                            join ChucDanh as cd on dg.MaChucDanh=cd.MaChucDanh
                            where  DATEDIFF(day, GetDate(), dg.NgayHetHan) > 1 and DATEDIFF(day, GetDate(), dg.NgayHetHan) <7";


                var list = cnn.Query<DocGiaModel>(sql).ToList();
                return list;
            }
        }
        public List<DocGiaModel> SearchCheck2(string searchValue)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                string search = "%" + searchValue + "%";
                var sql = @"  select dg.MaDocGia,dg.TenDocGia,dg.NgaySinh,cd.TenChucDanh,dg.Email,dg.SoDienThoai,dg.NgayDangKy,dg.NgayHetHan
                            from DocGia as dg
                            join ChucDanh as cd on dg.MaChucDanh=cd.MaChucDanh
                            where  dg.TenDocGia like @search and DATEDIFF(day, GetDate(), dg.NgayHetHan) > 1 and DATEDIFF(day, GetDate(), dg.NgayHetHan) <7 ";

                var param = new
                {
                    searchValue = searchValue,
                    search = search,


                };

                var lstSach = cnn.Query<DocGiaModel>(sql, param).ToList();
                return lstSach;
            }
        }
        public int GetTongDocGia()
        {
            using (var cnn = DbUtils.GetConnection())
            {

                var sql = @"  select count(MaDocGia)
                                from DocGia
                                ";



                int result = Convert.ToInt32(cnn.ExecuteScalar(sql));
                return result;
            }
        }
        public int GetTongDocGiaHetHan()
        {
            using (var cnn = DbUtils.GetConnection())
            {

                var sql = @"  select count(MaDocGia)
                                from DocGia where DATEDIFF(day, GetDate(), NgayHetHan) < 0 ";



                int result = Convert.ToInt32(cnn.ExecuteScalar(sql));
                return result;
            }
        }
        public int GetTongDocGiaSapHetHan()
        {
            using (var cnn = DbUtils.GetConnection())
            {

                var sql = @"  select count(MaDocGia)
                                from DocGia where DATEDIFF(day, GetDate(), NgayHetHan) < 7 and DATEDIFF(day, GetDate(), NgayHetHan) >1 ";



                int result = Convert.ToInt32(cnn.ExecuteScalar(sql));
                return result;
            }
        }
    }
}
