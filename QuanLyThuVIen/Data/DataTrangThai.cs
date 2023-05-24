using Dapper;
using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVIen.Data
{
    public class DataTrangThai
    {
        public List<TrangThai> GetListTrangThai()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "select * from TrangThai";
                var lstKhoa = cnn.Query<TrangThai>(sql).ToList();
                return lstKhoa;
            }
        }
    }
}
