using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace QuanLyThuVIen.Data
{
    public class DataNXB
    {
        public List<NhaXuatBan> GetListNXB()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"select * from NhaXuatBan";
                var lstNXB = cnn.Query<NhaXuatBan>(sql).ToList();
                return lstNXB;
            }
        }

        public NhaXuatBan GetNXB(int MaNXB)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"select * from NhaXuatBan where MaNhaXuatBan = @MaNXB";
                var param = new { MaNXB = MaNXB };
                var lstNXB = cnn.Query<NhaXuatBan>(sql, param).ToList();
                return lstNXB[0];
            }
        }
        public List<NhaXuatBan> GetListNXB1(string searchValue)
        {
            if (searchValue != null)
            {
                searchValue = "%" + searchValue + "%";
            }
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"select * from NhaXuatBan where TenNhaXuatBan like @searchValue";
                var param = new
                {
                    searchValue = searchValue
                };
                var lstNXB = cnn.Query<NhaXuatBan>(sql, param).ToList();
                return lstNXB;
            }
        }
        public bool InsertNXB(NhaXuatBan data)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"INSERT INTO NhaXuatBan (TenNhaXuatBan,GhiChu)
                    VALUES (@TenNhaXuatBan,@GhiChu)";

                var param = new
                {
                    TenNhaXuatBan = data.TenNhaXuatBan,
                    GhiChu = data.GhiChu
                };

                int nEffectedRows = cnn.Execute(sql, param);

                //int nEffectedRows = cnn.Execute("sp_Sach_Insert", param, commandType: CommandType.StoredProcedure);

                return nEffectedRows == 1;
            }
        }
        public bool UpdateNXB(NhaXuatBan data)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"update NhaXuatBan set TenNhaXuatBan=@TenNhaXuatBan,GhiChu=@GhiChu
                            where MaNhaXuatBan=@MaNhaXuatBan";

                var param = new
                {
                    TenNhaXuatBan = data.TenNhaXuatBan,
                    GhiChu = data.GhiChu,
                    MaNhaXuatBan = data.MaNhaXuatBan
                };

                int nEffectedRows = cnn.Execute(sql, param);

                //int nEffectedRows = cnn.Execute("sp_Sach_Insert", param, commandType: CommandType.StoredProcedure);

                return nEffectedRows == 1;
            }
        }
        public bool DeleteNXB(int MaNhaXuatBan)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"Delete from NhaXuatBan where MaNhaXuatBan=@MaNhaXuatBan";

                var param = new
                {
                    MaNhaXuatBan = MaNhaXuatBan
                };

                int nEffectedRows = cnn.Execute(sql, param);

                //int nEffectedRows = cnn.Execute("sp_Sach_Insert", param, commandType: CommandType.StoredProcedure);

                return nEffectedRows == 1;
            }

        }
    }
}
