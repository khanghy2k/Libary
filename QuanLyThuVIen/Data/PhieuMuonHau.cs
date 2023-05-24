using Dapper;
using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVIen.Data
{
    public class PhieuMuonHau
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<PhieuMuonModel> GetListPhieuMuon()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                
                var sql = @" select ct.MaChiTietMuon,dg.TenDocGia , NgayMuon ,ct.HanTra, ctt.NgayTra, SoLuongMuon,ctt.SoLuongTra , (case(ct.TrangThai) when 0 then N'Đang mượn' when -1 then N'Đang chờ mượn' when 1 then N'Đã trả' end) as 'TrangThai', ctt.TraDungHan
                             from ChiTietMuon as Ct
                             left join ChiTietTra as ctt on ctt.MaChiTietMuon=ct.MaChiTietMuon
                             left join DocGia as dg on dg.MaDocGia = ct.MaDocGia";


                var listPhieuMuon = cnn.Query<PhieuMuonModel>(sql).ToList();
                return listPhieuMuon;
            }
        }
        
        public List<PhieuMuonModel> Search(string searchValue)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                string search = "%" + searchValue + "%";
                var sql = @"  select ct.MaChiTietMuon,dg.TenDocGia , NgayMuon ,ct.HanTra, ctt.NgayTra, SoLuongMuon,ctt.SoLuongTra , (case(ct.TrangThai) when 0 then N'Đang mượn' when -1 then N'Đang chờ mượn' when 1 then N'Đã trả' end) as 'TrangThai', ctt.TraDungHan
                             from ChiTietMuon as Ct
                             left join ChiTietTra as ctt on ctt.MaChiTietMuon=ct.MaChiTietMuon
                             left join DocGia as dg on dg.MaDocGia = ct.MaDocGia
                            where  dg.TenDocGia like @search ";

                var param = new
                {
                    searchValue = searchValue,
                    search = search,
                    
                   
                };

                var lstSach = cnn.Query<PhieuMuonModel>(sql, param).ToList();
                return lstSach;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        public List<PhieuMuonModel> SearchQuaHanChuaTra(string searchValue,string quaHan="",string chuaTra="",string chuaDu="" )
        {
            using (var cnn = DbUtils.GetConnection())
            {
                string search = "%" + searchValue + "%";
                var sql = @" 
                            select ct.MaChiTietMuon,dg.TenDocGia , NgayMuon ,ct.HanTra, ctt.NgayTra, SoLuongMuon,ctt.SoLuongTra , (case(ct.TrangThai) when 0 then N'Đang mượn' when -1 then N'Đang chờ mượn' when 1 then N'Đã trả' end) as 'TrangThai', ctt.TraDungHan
                             from ChiTietMuon as Ct
                             left join ChiTietTra as ctt on ctt.MaChiTietMuon=ct.MaChiTietMuon
                             left join DocGia as dg on dg.MaDocGia = ct.MaDocGia
                              where DATEDIFF(day, ct.HanTra, ctt.NgayTra) <=0 and TrangThai = 1";

                var param = new
                {
                    searchValue = searchValue,
                    search = search
                };

                var lstSach = cnn.Query<PhieuMuonModel>(sql, param).ToList();
                return lstSach;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        public List<PhieuMuonModel> SearchChuaTraDu(string searchValue)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                string search = "%" + searchValue + "%";
                var sql = @"  select ct.MaChiTietMuon,dg.TenDocGia , NgayMuon ,ct.HanTra, ctt.NgayTra, SoLuongMuon,ctt.SoLuongTra , (case(ct.TrangThai) when 0 then N'Đang mượn' when -1 then N'Đang chờ mượn' when 1 then N'Đã trả' end) as 'TrangThai', ctt.TraDungHan
                             from ChiTietMuon as Ct
                             left join ChiTietTra as ctt on ctt.MaChiTietMuon=ct.MaChiTietMuon
                             left join DocGia as dg on dg.MaDocGia = ct.MaDocGia
                            where  dg.TenDocGia like @search and SoLuongMuon > ctt.SoLuongTra and ctt.SoLuongTra >0";

                var param = new
                {
                    
                    search = search
                };

                var lstSach = cnn.Query<PhieuMuonModel>(sql, param).ToList();
                return lstSach;
            }
        }
        
        public List<PhieuMuonModel> GetListQuaHan()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"  select ct.MaChiTietMuon,dg.TenDocGia , NgayMuon ,ct.HanTra, ctt.NgayTra, SoLuongMuon,ctt.SoLuongTra , (case(ct.TrangThai) when 0 then N'Đang mượn' when -1 then N'Đang chờ mượn' when 1 then N'Đã trả' end) as 'TrangThai', ctt.TraDungHan
                             from ChiTietMuon as Ct
                             left join ChiTietTra as ctt on ctt.MaChiTietMuon=ct.MaChiTietMuon
                             left join DocGia as dg on dg.MaDocGia = ct.MaDocGia
                              where DATEDIFF(day, 0, GETDATE()) > DATEDIFF(day, 0, HanTra) and TrangThai=0";
                var lstSach = cnn.Query<PhieuMuonModel>(sql).ToList();
                return lstSach;
            }
        }
        public List<PhieuMuonModel> GetListChuTraDu()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"  select ct.MaChiTietMuon,dg.TenDocGia , NgayMuon ,ct.HanTra, ctt.NgayTra, SoLuongMuon,ctt.SoLuongTra , (case(ct.TrangThai) when 0 then N'Đang mượn' when -1 then N'Đang chờ mượn' when 1 then N'Đã trả' end) as 'TrangThai', ctt.TraDungHan
                             from ChiTietMuon as Ct
                             left join ChiTietTra as ctt on ctt.MaChiTietMuon=ct.MaChiTietMuon
                             left join DocGia as dg on dg.MaDocGia = ct.MaDocGia
                              where SoLuongMuon > ctt.SoLuongTra  and ctt.SoLuongTra >0";
                var lstSach = cnn.Query<PhieuMuonModel>(sql).ToList();
                return lstSach;
            }
        }
        public List<PhieuMuonModel> GetListDaTraDungHan()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @" select ct.MaChiTietMuon,dg.TenDocGia , NgayMuon ,ct.HanTra, ctt.NgayTra, SoLuongMuon,ctt.SoLuongTra , (case(ct.TrangThai) when 0 then N'Đang mượn' when -1 then N'Đang chờ mượn' when 1 then N'Đã trả' end) as 'TrangThai', ctt.TraDungHan
                             from ChiTietMuon as Ct
                             left join ChiTietTra as ctt on ctt.MaChiTietMuon=ct.MaChiTietMuon
                             left join DocGia as dg on dg.MaDocGia = ct.MaDocGia
                              where DATEDIFF(day, ct.HanTra, ctt.NgayTra) <=0 and TrangThai = 1";
                var lstSach = cnn.Query<PhieuMuonModel>(sql).ToList();
                return lstSach;
            }
        }
        public List<PhieuMuonModel> SearchDaTraDungHan(string searchValue)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                string search = "%" + searchValue + "%";
                var sql = @" select ct.MaChiTietMuon,dg.TenDocGia , NgayMuon ,ct.HanTra, ctt.NgayTra, SoLuongMuon,ctt.SoLuongTra , (case(ct.TrangThai) when 0 then N'Đang mượn' when -1 then N'Đang chờ mượn' when 1 then N'Đã trả' end) as 'TrangThai', ctt.TraDungHan
                             from ChiTietMuon as Ct
                             left join ChiTietTra as ctt on ctt.MaChiTietMuon=ct.MaChiTietMuon
                             left join DocGia as dg on dg.MaDocGia = ct.MaDocGia
                            where  dg.TenDocGia like @search and DATEDIFF(day, ct.HanTra, ctt.NgayTra) <=0 and TrangThai = 1";

                var param = new
                {

                    search = search
                };

                var lstSach = cnn.Query<PhieuMuonModel>(sql, param).ToList();
                return lstSach;
            }
        }
        public List<PhieuMuonModel> GetListDaTraQuaHan()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @" select ct.MaChiTietMuon,dg.TenDocGia , NgayMuon ,ct.HanTra, ctt.NgayTra, SoLuongMuon,ctt.SoLuongTra , (case(ct.TrangThai) when 0 then N'Đang mượn' when -1 then N'Đang chờ mượn' when 1 then N'Đã trả' end) as 'TrangThai', ctt.TraDungHan
                             from ChiTietMuon as Ct
                             left join ChiTietTra as ctt on ctt.MaChiTietMuon=ct.MaChiTietMuon
                             left join DocGia as dg on dg.MaDocGia = ct.MaDocGia
                              where DATEDIFF(day, ct.HanTra, ctt.NgayTra) >0 and TrangThai = 1";
                var lstSach = cnn.Query<PhieuMuonModel>(sql).ToList();
                return lstSach;
            }
        }
        public List<PhieuMuonModel> SearchDaTraQuaHan(string searchValue)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                string search = "%" + searchValue + "%";
                var sql = @" select ct.MaChiTietMuon,dg.TenDocGia , NgayMuon ,ct.HanTra, ctt.NgayTra, SoLuongMuon,ctt.SoLuongTra , (case(ct.TrangThai) when 0 then N'Đang mượn' when -1 then N'Đang chờ mượn' when 1 then N'Đã trả' end) as 'TrangThai', ctt.TraDungHan
                             from ChiTietMuon as Ct
                             left join ChiTietTra as ctt on ctt.MaChiTietMuon=ct.MaChiTietMuon
                             left join DocGia as dg on dg.MaDocGia = ct.MaDocGia
                            where  dg.TenDocGia like @search and DATEDIFF(day, ct.HanTra, ctt.NgayTra) >0 and TrangThai = 1";

                var param = new
                {

                    search = search
                };

                var lstSach = cnn.Query<PhieuMuonModel>(sql, param).ToList();
                return lstSach;
            }
        }
        public int GetTongPhieu()
        {
            using (var cnn = DbUtils.GetConnection())
            {

                var sql = @"  select count(ct.MaChiTietMuon)
                                from ChiTietMuon as ct ";



                int result = Convert.ToInt32(cnn.ExecuteScalar(sql));
                return result;
            }
        }
        public int GetQuaHanChuaTra()
        {
            using (var cnn = DbUtils.GetConnection())
            {

                var sql = @"  select count(ct.MaChiTietMuon)
                            from ChiTietMuon as ct 
                            where DATEDIFF(day, 0, GETDATE()) > DATEDIFF(day, 0, HanTra) and ct.TrangThai=0";



                int result = Convert.ToInt32(cnn.ExecuteScalar(sql));
                return result;
            }
        }
        public int GetChuaTraDu()
        {
            using (var cnn = DbUtils.GetConnection())
            {

                var sql = @"  select COUNT(Ct.MaChiTietMuon)
                             from ChiTietMuon as Ct
                             left join ChiTietTra as ctt on ctt.MaChiTietMuon=ct.MaChiTietMuon
                              where SoLuongMuon > ctt.SoLuongTra  and ctt.SoLuongTra >0";



                int result = Convert.ToInt32(cnn.ExecuteScalar(sql));
                return result;
            }
        }
        public int GetDaTraDungHan()
        {
            using (var cnn = DbUtils.GetConnection())
            {

                var sql = @"  select count(ct.MaChiTietMuon)
                             from ChiTietMuon as Ct
                             left join ChiTietTra as ctt on ctt.MaChiTietMuon=ct.MaChiTietMuon
                             left join DocGia as dg on dg.MaDocGia = ct.MaDocGia
                              where DATEDIFF(day, ct.HanTra, ctt.NgayTra) <=0 and TrangThai = 1";



                int result = Convert.ToInt32(cnn.ExecuteScalar(sql));
                return result;
            }
        }
        public int GetDaTraQuaHan()
        {
            using (var cnn = DbUtils.GetConnection())
            {

                var sql = @"  select count(ct.MaChiTietMuon)
                             from ChiTietMuon as Ct
                             left join ChiTietTra as ctt on ctt.MaChiTietMuon=ct.MaChiTietMuon
                             left join DocGia as dg on dg.MaDocGia = ct.MaDocGia
                              where DATEDIFF(day, ct.HanTra, ctt.NgayTra) >0 and TrangThai = 1";



                int result = Convert.ToInt32(cnn.ExecuteScalar(sql));
                return result;
            }
        }
    }
}
