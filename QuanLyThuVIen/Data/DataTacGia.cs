using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace QuanLyThuVIen.Data
{
    public class DataTacGia
    {
        public TacGia GetTacGia(int MaTacGia)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "select * from TacGia where MaTacGia = @MaTacGia";
                var param = new { MaTacGia = MaTacGia };
                var TacGia = cnn.Query<TacGia>(sql, param).ToList();
                return TacGia[0];
            }
        }
        public List<TacGia> GetListTacGia()
        {

            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "SELECT * from TacGia";
                var lstTacGia = cnn.Query<TacGia>(sql).ToList();
                return lstTacGia;
            }
        }

        public List<TacGia> GetListTacGia(int MaSach)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "SELECT * from Sach_TacGia as stg join TacGia as tg on tg.MaTacGia = stg.MaTacGia where MaSach = @MaSach";
                var param = new { MaSach = MaSach };

                var result = cnn.Query<TacGia>(sql, param).ToList();
                return result;
            }
        }
        public void UpdateListTacGia(int MaSach, List<TacGia> lstTG)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"delete from Sach_TacGia where MaSach = @MaSach";

                var param = new
                {
                    MaSach = MaSach
                };
                cnn.Execute(sql, param);

                int nEffectedRows = cnn.Execute(sql, param);
                foreach (var item in lstTG)
                {
                    sql = "insert into Sach_TacGia values(@MaSach, @MaTacGia)";
                    var p = new { MaSach = MaSach, MaTacGia = item.MaTacGia };
                    cnn.Execute(sql, p);
                }
            }
        }
        public List<TacGia> Search(string searchValue)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                string search = "%" + searchValue + "%";
                var sql = @"select * from TacGia where TenTacGia like @TenTacGia";

                var param = new
                {
                    TenTacGia = search
                };

                var lstTacGia = cnn.Query<TacGia>(sql, param).ToList();
                return lstTacGia;
            }
        }
        public void UpdateTacGia(TacGia s)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"update TacGia set TenTacGia = @TenTacGia, GhiChu = @GhiChu
                            where MaTacGia = @MaTacGia";

                var param = new
                {
                    TenTacGia = s.TenTacGia,
                    MaTacGia = s.MaTacGia,
                    GhiChu = s.GhiChu,

                };

                cnn.Execute(sql, param);

                //int nEffectedRows = cnn.Execute("sp_Sach_Insert", param, commandType: CommandType.StoredProcedure);


            }
        }
        public bool Delete(int Matacgia)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"delete from TacGia where MaTacGia = @MaTacGia";

                var param = new
                {
                    MaTacGia = Matacgia
                };

                int nEffectedRows = cnn.Execute(sql, param);

                //int nEffectedRows = cnn.Execute("sp_Sach_Insert", param, commandType: CommandType.StoredProcedure);

                return nEffectedRows == 1;
            }
        }
        public int Inused(int Matacgia)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                int nEffectedRows = 0;
                var sql = @"select  case when 
				exists(select * from Sach_TacGia where MaTacGia = @searchvalue) then 0 else 1 
				end";

                var param = new
                {
                    searchvalue = Matacgia
                };

                nEffectedRows = Convert.ToInt32(cnn.ExecuteScalar(sql, param));

                //int nEffectedRows = cnn.Execute("sp_Sach_Insert", param, commandType: CommandType.StoredProcedure);

                return nEffectedRows;
            }
        }
        public bool Insert(TacGia s)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"INSERT INTO TacGia(TenTacGia,GhiChu)
                VALUES (@TenTacGia,@GhiChu)";

                var param = new
                {
                    TenTacGia = s.TenTacGia,
                    GhiChu = s.GhiChu,
                };

                int nEffectedRows = cnn.Execute(sql, param);

                //int nEffectedRows = cnn.Execute("sp_Sach_Insert", param, commandType: CommandType.StoredProcedure);

                return nEffectedRows == 1;
            }
        }
    }
}
