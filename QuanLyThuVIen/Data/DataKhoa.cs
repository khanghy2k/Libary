using Dapper;
using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVIen.Data
{
    public class DataKhoa
    {
        public List<Khoa> GetListKhoa()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "select * from Khoa";
                var lstKhoa = cnn.Query<Khoa>(sql).ToList();
                return lstKhoa;
            }
        }
    }
}
