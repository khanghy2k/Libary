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
    public class DataNguoiDung
    {
        public List<NguoiDung> GetListManager()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "SELECT * from NguoiDung where MaChucVu = 2";
                var lstnguoidung = cnn.Query<NguoiDung>(sql).ToList();
                return lstnguoidung;
            }
        }
        public List<NguoiDung> GetListNguoiDung(string search_value)
        {

            {
                using (var cnn = DbUtils.GetConnection())
                {
                    string tam = "%" + search_value + "%";
                    var sql = @"select * from NguoiDung where ((SoDienThoai like @searchvalue) or (HoTen like @searchvalue)) and MaChucVu = 2 ";
                    var param = new
                    {
                        searchvalue = tam.Trim()
                    };
                    //int nEffectedRows = cnn.Execute(sql, param);

                    var lstNguoiDung = cnn.Query<NguoiDung>(sql, param).ToList();
                    return lstNguoiDung;
                }
            }
        }
        /// <summary>
        /// Kiểm tra đăng nhập
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>

        public NguoiDung Login(string email, string password)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "SELECT * from NguoiDung where (Email=@Email and Password=@password) or (UserName = @Email and Password = @password)";
                var param = new
                {
                    Email = email,
                    password = password
                };
                var lstnguoidung = cnn.Query<NguoiDung>(sql, param).ToList();
                return lstnguoidung.Count > 0 ? lstnguoidung[0] : null;
            }
        }
        /// <summary>
        /// Đổi mật khẩu
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool RestPass(string password)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("UPDATE NguoiDung SET Password=@password Where Email=@Email", (SqlConnection)cnn);
                cmd.Parameters.AddWithValue("password", password);
                bool result = cmd.ExecuteNonQuery() > 0;
                return result;
            }
        }
        //public bool Sosanhemail(string Email)
        //{
        //    using (var cnn = DbUtils.GetConnection())
        //    {
        //        SqlCommand cmd = new SqlCommand("Select * from NguoiDung Where Email=@Email", (SqlConnection)cnn);
        //        cmd.Parameters.AddWithValue("Email", Email);
        //        bool result = cmd.ExecuteNonQuery() > 0;
        //        return result;
        //    }
        //}
        public NguoiDung GetListNguoiDung(int MaNguoiDung)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "SELECT * from  NguoiDung where MaNguoiDung = @MaNguoiDung";
                var param = new { MaNguoiDung = MaNguoiDung };
                var result = cnn.Query<NguoiDung>(sql, param).ToList();
                return result[0];
            }
        }
        public List<ChucVu> GetChucVu()
        {
            {
                using (var cnn = DbUtils.GetConnection())
                {
                    var sql = @"select *
                                from ChucVu";
                    //int nEffectedRows = cnn.Execute(sql, param);

                    var lstChucVu = cnn.Query<ChucVu>(sql).ToList();
                    return lstChucVu;

                }
            }
        }
        public List<string> GetNam()
        {
            {
                using (var cnn = DbUtils.GetConnection())
                {
                    var sql = @"select distinct YEAR(NgaySinh)
                                from NguoiDung";
                    //int nEffectedRows = cnn.Execute(sql, param);

                    var lstNam = cnn.Query<string>(sql).ToList();
                    return lstNam;

                }
            }
        }
        public ChucVu GetChucVu(int Machucvu)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "SELECT * from  ChucVu where MaChucVu = @MaChucVu";
                var param = new { MaChucVu=Machucvu };
                var result = cnn.Query<ChucVu>(sql, param).ToList();
                return result[0];
            }
        }
        public NguoiDung sosanhEmail(string Email)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "SELECT * from  NguoiDung where Email = @Email";
                var param = new { Email = Email };
                var result = cnn.Query<NguoiDung>(sql, param).ToList();
                return result[0];
            }
        }
        public bool Update(NguoiDung s)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"update NguoiDung set HoTen=@HoTen,NgaySinh=@NgaySinh,
                GioiTinh=@GioiTinh,SoDienThoai=@SoDienThoai,Email=@Email
                where MaNguoiDung = @MaNguoiDung";

                var param = new
                {
                   Hoten=s.HoTen,
                   NgaySinh=s.NgaySinh,
                   GioiTinh=s.GioiTinh,
                   SoDienThoai=s.SoDienThoai,
                   Email=s.Email,
                   MaNguoiDung=s.MaNguoiDung,
                 

                };
                int nEffectedRows = cnn.Execute(sql, param);
                return nEffectedRows == 1;
            }
        }
        public void UpdateThuThu(int MaNguoiDung, NguoiDung data)
        {
            using (var cnn = DbUtils.GetConnection())
            {

                var sql = @"Update NguoiDung set HoTen= @hoten, NgaySinh = @ngaysinh, GioiTinh = @gioitinh,
                            SoDienThoai = @sodienthoai, Email = @email, MaChucVu = @machucvu
                            where MaNguoiDung = @mathuthu";
                var param = new
                {
                    mathuthu = MaNguoiDung,

                    hoten = data.HoTen,
                    ngaysinh = data.NgaySinh,
                    sodienthoai = data.SoDienThoai,
                    gioitinh = data.GioiTinh,
                    email = data.Email,

                    machucvu = data.MaChucVu,

                };
                int nEffectiveRows = cnn.Execute(sql, param);

            }
        }
        public int InUsed(int mathuthu)
        {
            int Result = 0;
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"select count(*) from NguoiDung 
                            as nd join ChiTietMuon as ctm on nd.MaNguoiDung = ctm.MaNguoiDung
                            where nd.MaNguoiDung = @mathuthu";
                var param = new { mathuthu = mathuthu };
                Result = Convert.ToInt32(cnn.ExecuteScalar(sql, param));


            }
            return Result;
        }
        public bool DelThuThu(int mathuthu)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"Delete from NguoiDung where MaNguoiDung = @mathuthu";
                var param = new { mathuthu = mathuthu };
                int nEffectedRows = cnn.Execute(sql, param);
                return nEffectedRows == 1;
            }
        }
        public List<NguoiDung> GetListThuThu()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "select * from NguoiDung where MaChucVu = 1";
                var lstThuThu = cnn.Query<NguoiDung>(sql).ToList();
                return lstThuThu;
            }
        }
        public List<NguoiDung> GetListNguoiDung1(string searchValue)
        {
            if (searchValue != "")
                searchValue = "%" + searchValue + "%";
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"select * from NguoiDung where (@searchValue = N'')
                                        or(
                                                (HoTen like @searchValue)
                                                or
                                                (SoDienThoai like @searchValue)
                                                or
                                                (Email like @searchValue)
                                            )";
                var param = new
                {
                    searchValue = searchValue
                };
                var lstThuThu1 = cnn.Query<NguoiDung>(sql, param).ToList();
                return lstThuThu1;
            }

        }
        public NguoiDung GetThuThu(int mathuthu)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "select * from NguoiDung where MaNguoiDung = @mathuthu";
                var param = new { mathuthu = mathuthu };
                var ThuThu = cnn.Query<NguoiDung>(sql, param).ToList();
                return ThuThu[0];
            }
        }
        public void AddThuThu(NguoiDung data)
        {

            using (var cnn = DbUtils.GetConnection())
            {

                var sql = @"insert into NguoiDung (HoTen, NgaySinh, SoDienThoai, Email, MaChucVu, UserName, Password, TrangThai)
                            values (@hoten, @ngaysinh, @sodienthoai, @email, @machucvu, @username, @password, @trangthai)";
                var param = new
                {
                    hoten = data.HoTen,
                    ngaysinh = data.NgaySinh,
                    sodienthoai = data.SoDienThoai,
                    email = data.Email,
                    trangthai = data.TrangThai,
                    username = data.UserName,
                    password = data.Password,
                    machucvu = data.MaChucVu

                };
                int nEffectiveRows = cnn.Execute(sql, param);

            }

        }
        public List<NguoiDung> GetNguoiDungTheoGioiTinh(Boolean GioiTinh)
        {
            {
                using (var cnn = DbUtils.GetConnection())
                {
                    var sql = @"select *  from NguoiDung where  GioiTinh like @searchvalue";

                    var param = new
                    {
                        searchvalue = GioiTinh
                    };

                    var lstNguoiDung = cnn.Query<NguoiDung>(sql, param).ToList();
                    return lstNguoiDung;
                }
            }
        }
        public List<NguoiDung> GetNguoiDungTheoNam(string NamSinhNguoiDung)
        {
            {
                using (var cnn = DbUtils.GetConnection())
                {
                    var sql = @"select *
                                from NguoiDung
                                where YEAR(NgaySinh) like @searchvalue";
                    var param = new
                    {
                        searchvalue = NamSinhNguoiDung
                    };

                    var lstNguoiDung = cnn.Query<NguoiDung>(sql, param).ToList();
                    return lstNguoiDung;
                }
            }
        }
        public List<NguoiDung> GetNguoiDungTheoChucVu(int MaChucVu)
        {
            {
                using (var cnn = DbUtils.GetConnection())
                {
                    var sql = @"select *
                                from NguoiDung 
                                where MaChucVu  like @searchvalue";
                    var param = new
                    {
                        searchvalue = MaChucVu
                    };

                    //int nEffectedRows = cnn.Execute(sql, param);
                    var lstNguoiDung = cnn.Query<NguoiDung>(sql, param).ToList();

                    return lstNguoiDung;

                }
            }
        }
        public bool Delete(int MaNguoiDung)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"delete from NguoiDung where MaNguoiDung = @MaNguoiDung";

                var param = new
                {
                    MaNguoiDung = MaNguoiDung
                };

                int nEffectedRows = cnn.Execute(sql, param);

                //int nEffectedRows = cnn.Execute("sp_Sach_Insert", param, commandType: CommandType.StoredProcedure);

                return nEffectedRows == 1;
            }
        }
        public bool Insert(NguoiDung s)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"INSERT INTO NguoiDung (HoTen, Email, NgaySinh, SoDienThoai, GioiTinh, MaChucVu, UserName,Password)
                VALUES (@HoTen, @Email, @NgaySinh, @SoDienThoai, @GioiTinh, @MaChucVu, @UserName,'123')";

                var param = new
                {
                    HoTen = s.HoTen,
                    Email = s.Email,
                    NgaySinh = s.NgaySinh,
                    SoDienThoai = s.SoDienThoai,
                    GioiTinh = s.GioiTinh,
                    MaChucVu = s.MaChucVu,
                    UserName = s.UserName

                };

                int nEffectedRows = cnn.Execute(sql, param);

                //int nEffectedRows = cnn.Execute("sp_Sach_Insert", param, commandType: CommandType.StoredProcedure);

                return nEffectedRows == 1;
            }
        }
    }
}
