using Dapper;
using QuanLyThuVIen.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVIen.Data
{
    public class DataDocGia
    {
        public int GetMaDocGia(int MaChiTietMuon)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"select MaDocGia from ChiTietMuon where MaChiTietMuon = @MaChiTietMuon";
                var param = new
                {
                    MaChiTietMuon = MaChiTietMuon
                };
                int MaDocGia = Convert.ToInt32(cnn.ExecuteScalar(sql, param));
                return MaDocGia;
            }
        }
        public List<DocGia> GetListDocGia()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "select * from DocGia";
                var lstSach = cnn.Query<DocGia>(sql).ToList();
                return lstSach;
            }
        }
        public List<DocGia> GetListDocGia1(int MaKhoa)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "select * from DocGia where MaKhoa=@MaKhoa";
                var param = new
                {
                    MaKhoa = MaKhoa
                };
                var lstSach = cnn.Query<DocGia>(sql, param).ToList();
                return lstSach;
            }
        }
        public List<DocGia> GetListDocGia2(int MaChucDanh)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "select * from DocGia where MaChucDanh=@MaChucDanh";
                var param = new
                {
                    MaChucDanh = MaChucDanh
                };
                var lstSach = cnn.Query<DocGia>(sql, param).ToList();
                return lstSach;
            }
        }

        public List<DocGia> GetListDocGia3(int MaTrangThai)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "select * from DocGia where MaTrangThai=@MaTrangThai";
                var param = new
                {
                    MaTrangThai = MaTrangThai
                };
                var lstSach = cnn.Query<DocGia>(sql, param).ToList();
                return lstSach;
            }
        }
        public DocGia GetDocGia(int MaDocGia)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "select * from DocGia where MaDocGia=@MaDocGia";
                var param = new
                {
                    MaDocGia = MaDocGia
                };
                var lstSach = cnn.Query<DocGia>(sql, param).ToList();
                return lstSach[0];
            }
        }
        public List<DocGia> TimkiemDocGia (string searchValue)
        {
            if (searchValue != null)
            {
                searchValue = "%"+searchValue+"%";
            }
            using (var cnn = DbUtils.GetConnection())
            {

                var sql = "select * from DocGia where TenDocGia like @searchValue";
                var param = new
                {
                    searchValue = searchValue
                };
                var lstSach = cnn.Query<DocGia>(sql, param).ToList();
                return lstSach;
            }
        }
        public bool Insert(DocGia DG)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"INSERT INTO DocGia (TenDocGia,NgaySinh,MaChucDanh, GioiTinh,Email,DiaChi, SoDienThoai, NgayDangKy,NgayHetHan,Lop,MaKhoa,KhoaHoc,UserName,Password,MaTrangThai)
                    VALUES (@TenDocGia,@NgaySinh,@MaChucDanh, @GioiTinh,@Email,@DiaChi, @SoDienThoai, @NgayDangKy,@NgayHetHan,@Lop,@MaKhoa,@KhoaHoc,@UserName,@Password,1)";

                var param = new
                {
                    TenDocGia = DG.TenDocGia,
                    NgaySinh = DG.NgaySinh,
                    MaChucDanh = DG.MaChucDanh,
                    GioiTinh = DG.GioiTinh,
                    Email = DG.Email,
                    DiaChi = DG.DiaChi,
                    SoDienThoai = DG.SoDienThoai,
                    NgayDangKy = DG.NgayDangKy,
                    NgayHetHan = DG.NgayHetHan,
                    Lop = DG.Lop,
                    MaKhoa = DG.MaKhoa ,
                    KhoaHoc = DG.KhoaHoc ,
                    UserName= DG.Username,
                    Password = DG.Password
                };

                int nEffectedRows = cnn.Execute(sql, param);

                //int nEffectedRows = cnn.Execute("sp_Sach_Insert", param, commandType: CommandType.StoredProcedure);

                return nEffectedRows == 1;
            }
        }
        public bool Update(DocGia DG)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"update DocGia set TenDocGia=@TenDocGia,NgaySinh=@NgaySinh,MaChucDanh=@MaChucDanh,GioiTinh=@GioiTinh,
                            Email=@Email,DiaChi=@DiaChi,SoDienThoai=@SoDienThoai,NgayDangKy=@NgayDangKy,NgayHetHan=@NgayHetHan,
                            Lop=@Lop,MaKhoa=@MaKhoa,KhoaHoc=@KhoaHoc,Username=@Username,Password=@Password,MaTrangThai=@MaTrangThai
                            where MaDocGia=@MaDocGia";

                var param = new
                {
                    TenDocGia = DG.TenDocGia,
                    NgaySinh = DG.NgaySinh,
                    MaChucDanh = DG.MaChucDanh,
                    GioiTinh = DG.GioiTinh,
                    Email = DG.Email,
                    DiaChi = DG.DiaChi,
                    SoDienThoai = DG.SoDienThoai,
                    NgayDangKy = DG.NgayDangKy,
                    NgayHetHan = DG.NgayHetHan,
                    Lop = DG.Lop,
                    MaKhoa = DG.MaKhoa,
                    KhoaHoc = DG.KhoaHoc,
                    UserName = DG.Username,
                    Password = DG.Password,
                    MaDocGia=DG.MaDocGia,
                    MaTrangThai=DG.MaTrangThai
                };

                int nEffectedRows = cnn.Execute(sql, param);

                //int nEffectedRows = cnn.Execute("sp_Sach_Insert", param, commandType: CommandType.StoredProcedure);

                return nEffectedRows == 1;
            }
        }
        public bool DeleteDG(int MaDocGia)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"Delete from DocGia where MaDocGia=@MaDocGia";

                var param = new
                {
                    MaDocGia = MaDocGia
                };

                int nEffectedRows = cnn.Execute(sql, param);

                //int nEffectedRows = cnn.Execute("sp_Sach_Insert", param, commandType: CommandType.StoredProcedure);

                return nEffectedRows == 1;
            }

        }
        public int InUsedDG(int MaDocGia)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"Select count(*) from ChiTietMuon where TrangThai=1 and MaDocGia=@MaDocGia";

                var param = new
                {
                    MaDocGia = MaDocGia
                };

                int nEffectedRows = Convert.ToInt32(cnn.ExecuteScalar(sql, param));

                //int nEffectedRows = cnn.Execute("sp_Sach_Insert", param, commandType: CommandType.StoredProcedure);

                return nEffectedRows;
            }
        }
        public int MaxOfMaDocGia()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"select Max(MaDocGia) from DocGia";
                int result = Convert.ToInt32(cnn.ExecuteScalar(sql));
                return result;
            }
        }
        public bool DocGiaExists(int maDocGia)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "SELECT COUNT(*) FROM DocGia WHERE MaDocGia = @MaDocGia";
                var cmd = new SqlCommand(sql, (SqlConnection)cnn);
                cmd.Parameters.AddWithValue("@MaDocGia", maDocGia);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

    }
}
