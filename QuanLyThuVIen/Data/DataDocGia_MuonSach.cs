using Dapper;
using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVIen.Data
{
    public class DataDocGia_MuonSach
    {
        public List<DocGia_MuonSach> GetListDocGiaMuonSach()
        {
            using(var cnn = DbUtils.GetConnection())
            {
                var sql = @"select dg.MaDocGia, ctm.MaChiTietMuon, dg.TenDocGia, ctm.NgayMuon, ctm.SoLuongMuon, ctm.HanTra
                            from DocGia as dg join ChiTietMuon as ctm on ctm.MaDocGia = dg.MaDocGia where ctm.TrangThai = 0";
                var lstSach = cnn.Query<DocGia_MuonSach>(sql).ToList();
                cnn.Close();
                return lstSach;
            }
        }
        public List<DocGia_MuonSach> GetListDangChoMuon()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"select dg.MaDocGia, ctm.MaChiTietMuon, dg.TenDocGia, ctm.NgayMuon, ctm.SoLuongMuon, ctm.HanTra
                            from DocGia as dg join ChiTietMuon as ctm on ctm.MaDocGia = dg.MaDocGia where ctm.TrangThai = -1";
                var lstSach = cnn.Query<DocGia_MuonSach>(sql).ToList();
                cnn.Close();
                return lstSach;
            }
        }
        public void XacNhanChoMuon(int MaChiTietMuon)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"update ChiTietMuon set TrangThai = 0 where MaChiTietMuon = @MaChiTietMuon";
                var param = new
                {
                    MaChiTietMuon = MaChiTietMuon
                };
                cnn.Execute(sql, param);
                cnn.Close();
            }
        }
        public List<DocGia_MuonSach> GetListQuaHan()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"select dg.MaDocGia, ctm.MaChiTietMuon, dg.TenDocGia, ctm.NgayMuon, ctm.SoLuongMuon, ctm.HanTra, ctm.TrangThai 
                            from DocGia as dg join ChiTietMuon as ctm on ctm.MaDocGia = dg.MaDocGia where DATEADD(dd, 0, DATEDIFF(dd, 0, GETDATE()))> ctm.HanTra and ctm.TrangThai = 0";
                var lstSach = cnn.Query<DocGia_MuonSach>(sql).ToList();
                cnn.Close();
                return lstSach;
            }
        }
        public List<DocGia_MuonSach> Search(string searchValue)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                string search = "%" + searchValue + "%";
                var sql = @"select dg.MaDocGia, ctm.MaChiTietMuon, dg.TenDocGia, ctm.NgayMuon, ctm.SoLuongMuon, ctm.HanTra, ctm.TrangThai 
                            from DocGia as dg join ChiTietMuon as ctm on ctm.MaDocGia = dg.MaDocGia
                            where ctm.MaChiTietMuon like @searchValue or dg.TenDocGia like @search";

                var param = new
                {
                    searchValue = searchValue,
                    search = search
                };

                var lstSach = cnn.Query<DocGia_MuonSach>(sql, param).ToList();
                cnn.Close();
                return lstSach;
            }
        }
    }
}
