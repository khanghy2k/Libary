using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace QuanLyThuVIen.Data
{
    public class DataLoaiSach
    {
        public List<LoaiSach> GetListLoaiSach()
        {

            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "SELECT * from LoaiSach";
                var lstLoaiSach = cnn.Query<LoaiSach>(sql).ToList();
                return lstLoaiSach;
            }
        }
        public LoaiSach GetLoaiSach(int maloai)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "select * from LoaiSach where MaLoai = @maloai";
                var param = new { maloai = maloai };
                var LoaiSach = cnn.Query<LoaiSach>(sql, param).ToList();
                return LoaiSach[0];
            }
        }


        public List<LoaiSach> GetListLoaiSach1(string searchValue)
        {
            if (searchValue != "")
                searchValue = "%" + searchValue + "%";
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"select * from LoaiSach where (@searchValue = N'')
                                        or(
                                                (TenLoai like @searchValue)
                                                
                                            )";
                var param = new
                {
                    searchValue = searchValue
                };
                var lstLoaiSach1 = cnn.Query<LoaiSach>(sql, param).ToList();
                return lstLoaiSach1;
            }

        }


        public void AddLoaiSach(string tenloai, string ghichu)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"insert into LoaiSach (TenLoai, GhiChu) values (@tenloai, @ghichu)";
                var param = new { tenloai = tenloai, ghichu = ghichu };
                int nEffectiveRows = cnn.Execute(sql, param);
            }

        }


        /// <summary>
        /// Kiem tra loai sach co lien quan den truong du lieu khac hay khong
        /// </summary>
        /// <param name="maloai"></param>
        /// <returns></returns>
        public int Inused(int maloai)
        {
            int Result = 0;
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"select count(*) from LoaiSach 
                            as ls join Sach as S on ls.MaLoai = s.MaLoaiSach
                            where ls.MaLoai = @maloai";
                var param = new { maloai = maloai };
                Result = Convert.ToInt32(cnn.ExecuteScalar(sql, param));


            }
            return Result;
        }

        /// <summary>
        /// Xoa loai sach
        /// </summary>
        /// <param name="maloai"></param>
        /// <returns></returns>
        public bool DelLoaiSach(int maloai)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"Delete from LoaiSach where MaLoai = @maloai";
                var param = new { maloai = maloai };
                int nEffectedRows = cnn.Execute(sql, param);
                return nEffectedRows == 1;
            }
        }


        /// <summary>
        /// Chinh sua thong tin loai sach
        /// </summary>
        /// <param name="maloai"></param>
        /// <param name="data"></param>
        public void UpdateLoaiSach(int maloai, LoaiSach data)
        {
            using (var cnn = DbUtils.GetConnection())
            {

                var sql = @"Update LoaiSach set TenLoai= @tenloai, GhiChu = @ghichu
                            where MaLoai = @maloai";
                var param = new
                {
                    maloai = maloai,

                    tenloai = data.TenLoai,
                    ghichu = data.GhiChu,


                };
                int nEffectiveRows = cnn.Execute(sql, param);

            }
        }
    }
}
