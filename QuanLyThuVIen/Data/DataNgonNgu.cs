using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace QuanLyThuVIen.Data
{
    public class DataNgonNgu
    {
        public List<NgonNgu> GetListNgonNgu()
        {

                using (var cnn = DbUtils.GetConnection())
                {
                    var sql = "SELECT * from NgonNgu";
                    var lstNgonNgu = cnn.Query<NgonNgu>(sql).ToList();
                    return lstNgonNgu;
                }           
        }

        public NgonNgu GetNgonNgu(int MaNgonNgu)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"SELECT * from NgonNgu where MaNgonNgu = @MaNgonNgu";
                var param = new { MaNgonNgu = MaNgonNgu };

                var result = cnn.Query<NgonNgu>(sql, param).ToList();
                return result[0];
            }
        }
        public List<NgonNgu> SearchNN(string searchValue)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                string search = "%" + searchValue + "%";
                var sql = @"select * from NgonNgu where TenNgonNgu like @TenNgonNgu";

                var param = new
                {
                    TenNgonNgu = search
                };

                var lstNgonNgu = cnn.Query<NgonNgu>(sql, param).ToList();
                return lstNgonNgu;
            }
        }

        public bool DeleteNN(int MaNgonNgu)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"delete from NgonNgu where MaNgonNgu = @MaNgonNgu";

                var param = new
                {
                    MaNgonNgu = MaNgonNgu
                };

                int nEffectedRows = cnn.Execute(sql, param);

                //int nEffectedRows = cnn.Execute("sp_Sach_Insert", param, commandType: CommandType.StoredProcedure);

                return nEffectedRows == 1;
            }
        }
        public int Inused(int MaNgonNgu)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                int nEffectedRows = 0;
                var sql = @"select  case when 
				exists(select * from Sach where MaNgonNgu = @searchvalue) then 0 else 1 
				end";

                var param = new
                {
                    searchvalue = MaNgonNgu
                };

                nEffectedRows = Convert.ToInt32(cnn.ExecuteScalar(sql, param));

                //int nEffectedRows = cnn.Execute("sp_Sach_Insert", param, commandType: CommandType.StoredProcedure);

                return nEffectedRows;
            }
        }
        public bool InsertNN(NgonNgu s)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"INSERT INTO NgonNgu(TenNgonNgu,GhiChu)
                VALUES (@TenNgonNgu,@GhiChu)";

                var param = new
                {
                    TenNgonNgu = s.TenNgonNgu,
                    GhiChu = s.GhiChu,
                };

                int nEffectedRows = cnn.Execute(sql, param);
                //int nEffectedRows = cnn.Execute("sp_Sach_Insert", param, commandType: CommandType.StoredProcedure);
                return nEffectedRows == 1;
            }
        }
        public void UpdateNgonNgu(NgonNgu s)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"update NgonNgu set TenNgonNgu = @TenNgonNgu, GhiChu = @GhiChu
                            where MaNgonNgu = @MaNgonNgu";
                var param = new
                {
                    TenNgonNgu = s.TenNgonNgu,
                    MaNgonNgu = s.MaNgonNgu,
                    GhiChu = s.GhiChu,
                };
                cnn.Execute(sql, param);
            }
        }
    }
}
