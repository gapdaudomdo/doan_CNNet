using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DoAn.DAO
{
    public class SuperDAO
    {
        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();
        KetNoiCSDL ketnoi = new KetNoiCSDL();
        public SuperDAO() { }

        string s = @"Data Source=LAPTOP-D97AHVVU\SQLEXPRESS;Initial Catalog=SQLQUANLYKHACHSAN;Integrated Security=True";
        public List<NhanVien> GetListOfNhanVien()
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            List<NhanVien> nhanViens;
            nhanViens = new List<NhanVien>();

            sql = "SELECT *FROM NhanVien";
            cn = new SqlConnection(s);
            cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    NhanVien t = new NhanVien(dr["TenNV"].ToString(), dr["MaNV"].ToString(), dr["DiaChi"].ToString(), (DateTime)dr["NgaySinh"], dr["SoCMND"].ToString(), dr["DienThoai"].ToString(), dr["Email"].ToString(), dr["GioiTinh"].ToString(), dr["LoaiNV"].ToString());
                    nhanViens.Add(t);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi tải danh sách nhân viên", ex);
            }
            finally
            {
                cn.Close();
            }
            return nhanViens;
        }
        public NhanVien GetNhanVien(string idNhanvien)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            NhanVien nhanVien = new NhanVien("", "");
            sql = "SELECT *FROM NhanVien WHERE MaNV= '" + idNhanvien + "'";
            cn = new SqlConnection(s);
            cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    NhanVien t = new NhanVien(dr["TenNV"].ToString(), dr["MaNV"].ToString(), dr["DiaChi"].ToString(), (DateTime)dr["NgaySinh"], dr["SoCMND"].ToString(), dr["DienThoai"].ToString(), dr["Email"].ToString(), dr["GioiTinh"].ToString(), dr["LoaiNV"].ToString());
                    nhanVien = t;
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi tải danh sách nhân viên", ex);
            }
            finally
            {
                cn.Close();
            }
            return nhanVien;
        }
        public List<KhachHang> GetListOfKhachThue()
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            List<KhachHang> khachhangs;
            khachhangs = new List<KhachHang>();
            sql = "SELECT *FROM KhachThue";
            cn = new SqlConnection(s);
            cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    KhachHang t = new KhachHang(dr["HoTen"].ToString(), dr["MaKH"].ToString(), dr["DiaChi"].ToString(), (DateTime)dr["NgaySinh"], dr["Email"].ToString(), dr["GioiTinh"].ToString(), dr["CMND"].ToString());
                    khachhangs.Add(t);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi tải danh sách khách hàng", ex);
            }
            finally
            {
                cn.Close();
            }
            return khachhangs;
        }
        public KhachHang GetKhachThue(string idKhachHang)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            KhachHang khachhangs = new KhachHang("", "");
            sql = "SELECT *FROM KhachThue WHERE MAKH='" + idKhachHang + "'";
            cn = new SqlConnection(s);
            cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    KhachHang t = new KhachHang(dr["HoTen"].ToString(), dr["MaKH"].ToString(), dr["DiaChi"].ToString(), (DateTime)dr["NgaySinh"], dr["Email"].ToString(), dr["GioiTinh"].ToString(), dr["CMND"].ToString());
                    khachhangs = t;
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi tải danh sách khách hàng", ex);
            }
            finally
            {
                cn.Close();
            }
            return khachhangs;
        }
        public List<Phong> GetListOfPhong()
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            List<Phong> phongs;
            phongs = new List<Phong>();
            sql = "SELECT *FROM Phong";
            cn = new SqlConnection(s);
            cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Phong t = new Phong(dr["TenPhong"].ToString(), dr["MaPhong"].ToString(), dr["LoaiPhong"].ToString(), (int)dr["Phongtrong"], (int)dr["GiaPhong"]);
                    phongs.Add(t);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi tải danh sách phòng", ex);
            }
            finally
            {
                cn.Close();
            }
            return phongs;
        }
        public Phong GetPhong(string idphong)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            Phong phongs = new Phong("", "");
            sql = "SELECT *FROM Phong WHERE MaPhong= '" + idphong + "'";
            cn = new SqlConnection(s);
            cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Phong t = new Phong(dr["TenPhong"].ToString(), dr["MaPhong"].ToString(), dr["LoaiPhong"].ToString(), (int)dr["Phongtrong"], (int)dr["GiaPhong"]);
                    phongs = t;
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi tải danh sách phòng", ex);
            }
            finally
            {
                cn.Close();
            }
            return phongs;
        }
        public List<DatPhong> GetListOfDatPhong()
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            List<DatPhong> datPhongs;
            datPhongs = new List<DatPhong>();

            sql = "SELECT *FROM DatPhong";
            cn = new SqlConnection(s);
            cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    KhachHang khachHang = GetKhachThue(dr["MaKH"].ToString());
                    Phong phong = GetPhong(dr["MaPhong"].ToString());
                    DatPhong t = new DatPhong(dr["MaDP"].ToString(), khachHang, phong, (DateTime)dr["NgayDp"]);
                    datPhongs.Add(t);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi tải danh sách đặt phòng", ex);
            }
            finally
            {
                cn.Close();
            }
            return datPhongs;
        }
        public DatPhong GetDatPhong(string idDatphong)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            KhachHang khachHang = new KhachHang("", "");
            Phong phong = new Phong("", "");
            DatPhong datPhong = new DatPhong("", khachHang, phong);

            sql = "SELECT *FROM DatPhong WHERE MaDP='" + idDatphong + "'";
            cn = new SqlConnection(s);
            cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    khachHang = GetKhachThue(dr["MaKH"].ToString());
                    phong = GetPhong(dr["MaPhong"].ToString());
                    DatPhong t = new DatPhong(dr["MaDP"].ToString(), khachHang, phong, (DateTime)dr["NgayDp"]);
                    datPhong = t;
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi tải danh sách đặt phòng", ex);
            }
            finally
            {
                cn.Close();
            }
            return datPhong;
        }
        public List<TraPhong> GetListOfTraPhong()
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            List<TraPhong> datPhongs;
            datPhongs = new List<TraPhong>();

            sql = "SELECT *FROM TraPhong";
            cn = new SqlConnection(s);
            cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    KhachHang khachHang = GetKhachThue(dr["MaKH"].ToString());
                    Phong phong = GetPhong(dr["MaPhong"].ToString());
                    TraPhong t = new TraPhong(dr["MaTP"].ToString(), khachHang, phong, (DateTime)dr["NgayTP"]);
                    datPhongs.Add(t);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi tải danh sách trả phòng", ex);
            }
            finally
            {
                cn.Close();
            }
            return datPhongs;
        }
        public TraPhong GetTraPhong(string idTraPhong)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            KhachHang khachHang = new KhachHang("", "");
            Phong phong = new Phong("", "");
            TraPhong traPhong = new TraPhong("", khachHang, phong);

            sql = "SELECT *FROM TraPhong WHERE MaTP='" + idTraPhong + "'";
            cn = new SqlConnection(s);
            cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    khachHang = GetKhachThue(dr["MaKH"].ToString());
                    phong = GetPhong(dr["MaPhong"].ToString());
                    TraPhong t = new TraPhong(dr["MaTP"].ToString(), khachHang, phong, (DateTime)dr["NgayTP"]);
                    traPhong = t;
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi tải danh sách trả phòng", ex);
            }
            finally
            {
                cn.Close();
            }
            return traPhong;
        }
        public List<HoaDon> GetListOfHoaDon()
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            List<HoaDon> hoadons;
            hoadons = new List<HoaDon>();
            sql = "SELECT *FROM HoaDon";
            cn = new SqlConnection(s);
            cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DatPhong dp = GetDatPhong(dr["MaDP"].ToString());
                    TraPhong tp = GetTraPhong(dr["MaTP"].ToString());
                    HoaDon d = new HoaDon(dp, tp, (int)dr["SoTien"]);
                    hoadons.Add(d);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi tải danh sách hóa đơn", ex);
            }
            finally
            {
                cn.Close();
            }
            return hoadons;
        }
        public void ThemNhanVien(NhanVien nhanVien)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            sql = "INSERT INTO NhanVien Values (@MaNV,@TenNV,@DiaChi,@NgaySinh,@SoCMND,@DienThoai,@Email,@GioiTinh,@LoaiNV)";
            cn = new SqlConnection(s);
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("MaNV", nhanVien.Id);
            cmd.Parameters.AddWithValue("TenNV", nhanVien.Name);
            cmd.Parameters.AddWithValue("DiaChi", nhanVien.Diachi);
            cmd.Parameters.AddWithValue("NgaySinh", nhanVien.Ngaysinh);
            cmd.Parameters.AddWithValue("SoCMND", nhanVien.CMND);
            cmd.Parameters.AddWithValue("DienThoai", nhanVien.Dienthoai);
            cmd.Parameters.AddWithValue("Email", nhanVien.Email);
            cmd.Parameters.AddWithValue("GioiTinh", nhanVien.Gioitinh);
            cmd.Parameters.AddWithValue("LoaiNV", nhanVien.LoaiNV);
            //truyen bao nhieu cot thi truyen bay nhieu parameters
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi tải không thêm được", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void ThemKhachHang(KhachHang khachHang)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            sql = "INSERT INTO KhachThue Values (@MaKH,@DiaChi,@HoTen,@CMND,@NgaySinh,@Email,@GioiTinh)";
            cn = new SqlConnection(s);
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("MaKH", khachHang.Id);
            cmd.Parameters.AddWithValue("DiaChi", khachHang.Diachi);
            cmd.Parameters.AddWithValue("HoTen", khachHang.Name);
            cmd.Parameters.AddWithValue("CMND", khachHang.CMND);
            cmd.Parameters.AddWithValue("NgaySinh", khachHang.Ngaysinh);
            cmd.Parameters.AddWithValue("Email", khachHang.Email);
            cmd.Parameters.AddWithValue("GioiTinh", khachHang.Gioitinh);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi tải không thêm được", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void ThemDatPhong(DatPhong datPhong)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            sql = "INSERT INTO DatPhong Values (@MaDP,@MaKH,@MaPhong,@NgayDP)";
            cn = new SqlConnection(s);
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("MaDP", datPhong.MaDatPhong);
            cmd.Parameters.AddWithValue("MaKH", datPhong.khachhang.Id);
            cmd.Parameters.AddWithValue("MaPhong", datPhong.phong.Id);
            cmd.Parameters.AddWithValue("NgayDP", datPhong.Ngaydat);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi tải không thêm được", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void ThemTraPhong(TraPhong traPhong)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            sql = "INSERT INTO TraPhong Values (@MaTP,@MaKH,@MaPhong,@NgayTP)";
            cn = new SqlConnection(s);
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("MaTP", traPhong.MaTraPhong);
            cmd.Parameters.AddWithValue("MaKH", traPhong.khachhang.Id);
            cmd.Parameters.AddWithValue("MaPhong", traPhong.phong.Id);
            cmd.Parameters.AddWithValue("NgayTP", traPhong.Ngaytra);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi tải không thêm được", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void XoaNhanVien(NhanVien nhanVien)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            sql = "DELETE FROM NhanVien WHERE MaNV= @MaNV";
            cn = new SqlConnection(s);
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("MaNV", nhanVien.Id);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi không xóa được", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void XoaKhachHang(KhachHang khachHang)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            sql = "DELETE FROM KhachThue WHERE MaKH= '" + khachHang.Id + "'";
            cn = new SqlConnection(s);
            cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi không xóa được", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void XoaDatPhong(DatPhong datPhong)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            sql = "DELETE FROM DatPhong WHERE MaDP=@MaDP";
            cn = new SqlConnection(s);
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("MaDP", datPhong.MaDatPhong);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi không xóa được", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void XoaTraPhong(TraPhong traPhong)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            sql = "DELETE FROM TraPhong WHERE MaTP=@MaTP";
            cn = new SqlConnection(s);
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("MaTP", traPhong.MaTraPhong);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi không xóa được", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void SuaNhanVien(NhanVien nhanVien)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            sql = "UPDATE NhanVien SET TenNV=@TenNV,DiaChi=@DiaChi,NgaySinh=@NgaySinh,SoCMND=@SoCMND,DienThoai=@DienThoai,Email=@Email,GioiTinh=@GioiTinh,LoaiNV =@LoaiNV WHERE MaNV=@MaNV";
            cn = new SqlConnection(s);
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("TenNV", nhanVien.Name);
            cmd.Parameters.AddWithValue("DiaChi", nhanVien.Diachi);
            cmd.Parameters.AddWithValue("NgaySinh", nhanVien.Ngaysinh);
            cmd.Parameters.AddWithValue("SoCMND", nhanVien.CMND);
            cmd.Parameters.AddWithValue("DienThoai", nhanVien.Dienthoai);
            cmd.Parameters.AddWithValue("Email", nhanVien.Email);
            cmd.Parameters.AddWithValue("GioiTinh", nhanVien.Gioitinh);
            cmd.Parameters.AddWithValue("LoaiNV", nhanVien.LoaiNV);
            cmd.Parameters.AddWithValue("MaNV", nhanVien.Id);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi không sửa được", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void SuaKhachHang(KhachHang khachHang)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            sql = "UPDATE KhachThue SET DiaChi=@DiaChi,HoTen=@HoTen,CMND=@CMND,NgaySinh=@NgaySinh,Email=@Email,GioiTinh=@GioiTinh WHERE MaKH=@MaKH";
            cn = new SqlConnection(s);
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("DiaChi", khachHang.Diachi);
            cmd.Parameters.AddWithValue("HoTen", khachHang.Name);
            cmd.Parameters.AddWithValue("CMND", khachHang.CMND);
            cmd.Parameters.AddWithValue("NgaySinh", khachHang.Ngaysinh);
            cmd.Parameters.AddWithValue("Email", khachHang.Email);
            cmd.Parameters.AddWithValue("GioiTinh", khachHang.Gioitinh);
            cmd.Parameters.AddWithValue("MaKH", khachHang.Id);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi không sửa được", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void SuaDatPhong(DatPhong datPhong)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            sql = "UPDATE DatPhong SET MaKH=@MaKH,MaPhong=@MaPhong,NgayDP=@NgayDP where MaDP=@MaDP";
            cn = new SqlConnection(s);
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("MaKH", datPhong.khachhang.Id);
            cmd.Parameters.AddWithValue("MaPhong", datPhong.phong.Id);
            cmd.Parameters.AddWithValue("NgayDP", datPhong.Ngaydat);
            cmd.Parameters.AddWithValue("MaDP", datPhong.MaDatPhong);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi không sửa được", ex);
            }
            finally
            {
                cn.Close();
            }

        }
        public void SuaTraPhong(TraPhong traPhong)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            sql = "UPDATE DatPhong SET MaKH=@MaKH,MaPhong=@MaPhong,NgayTP=@NgayTP WHERE MaTP=@MaTP";
            cn = new SqlConnection(s);
            cmd = new SqlCommand(sql, cn);

            cmd.Parameters.AddWithValue("MaKH", traPhong.khachhang.Id);
            cmd.Parameters.AddWithValue("MaPhong", traPhong.phong.Id);
            cmd.Parameters.AddWithValue("NgayDP", traPhong.Ngaytra);
            cmd.Parameters.AddWithValue("MaTP", traPhong.MaTraPhong);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi không sửa được", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void ThemHoaDon(HoaDon hoaDon)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            sql = "INSERT INTO HoaDon Values (@MaTP,@MaDP,@SoTien)";
            cn = new SqlConnection(s);
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("MaTP", hoaDon.Traphong.MaTraPhong);
            cmd.Parameters.AddWithValue("MaDP", hoaDon.Datphong.MaDatPhong);
            cmd.Parameters.AddWithValue("SoTien", hoaDon.tien);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi tải không thêm được", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void XoaHoaDon(HoaDon hoaDon)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            sql = "DELETE HoaDon WHERE MaDP=@MaDP AND MaTP=@MaTP";
            cn = new SqlConnection(s);
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("MaDP", hoaDon.Datphong.MaDatPhong);
            cmd.Parameters.AddWithValue("MaTP", hoaDon.Traphong.MaTraPhong);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi không XÓA được", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void SuaPhong(Phong phong)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            sql = "UPDATE Phong SET Phongtrong=@Phongtrong where MaPhong=@MaPhong";
            cn = new SqlConnection(s);
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("Phongtrong", phong.Phongtrong);
            cmd.Parameters.AddWithValue("MaPhong", phong.Id);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi không xóa được", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<KhachHang> TimKiemKhachHang(string matk,string tenkh)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            List<KhachHang> khachhangs;
            khachhangs = new List<KhachHang>();

            sql = "SELECT * FROM KhachThue where MaKH LIKE '%" + matk + "%' OR HoTen LIKE'%" + tenkh + "%'";
            cn = new SqlConnection(s);
            cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    KhachHang t = new KhachHang(dr["HoTen"].ToString(), dr["MaKH"].ToString(), dr["DiaChi"].ToString(), (DateTime)dr["NgaySinh"], dr["Email"].ToString(), dr["GioiTinh"].ToString(), dr["CMND"].ToString());
                    khachhangs.Add(t);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi tải danh sách khách hàng", ex);
            }
            finally
            {
                cn.Close();
            }
            return khachhangs;
        }
        public List<NhanVien> TimKiemNhanVien(string matk, string tennv)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            List<NhanVien> nhanViens;
            nhanViens = new List<NhanVien>();
            //sql = "SELECT *FROM NhanVien WHERE MaNV= '" + matk + "'";
            sql = "SELECT * FROM NhanVien where MaNV LIKE '%" + matk + "%' OR TenNV LIKE'%" + tennv + "%'";
            cn = new SqlConnection(s);
            cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    NhanVien t = new NhanVien(dr["TenNV"].ToString(), dr["MaNV"].ToString(), dr["DiaChi"].ToString(), (DateTime)dr["NgaySinh"], dr["SoCMND"].ToString(), dr["DienThoai"].ToString(), dr["Email"].ToString(), dr["GioiTinh"].ToString(), dr["LoaiNV"].ToString());
                    nhanViens.Add(t);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi tải danh sách nhân viên", ex);
            }
            finally
            {
                cn.Close();
            }
            return nhanViens;
        }
        public int ExecuteNonQuery(string sql)
        {
            int dung = 0;
            try
            {
                conn = ketnoi.conDB();
                conn.Open(); ;
                SqlCommand cmd = new SqlCommand(sql, conn);
                dung = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            { }
            return dung;
        }
        public bool XoaKH(string maKH)
        {
            string sqlXoa = "DELETE FROM KhachThue WHERE MaKH= '" + maKH + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlXoa) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool XoaKH_TraPhong(string makh)
        {
            string sqlXoa = "DELETE FROM TraPhong WHERE MaKH= '" + makh + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlXoa) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool XoaKH_DatPhong(string makh)
        {
            string sqlXoa = "DELETE FROM DatPhong WHERE MaKH= '" + makh + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlXoa) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool XoaKH_HoaDon(string maDP, string maTP)
        {
            string sqlXoa = "DELETE HoaDon WHERE MaDP='"+maDP+"' AND MaTP='"+maTP+"'";
            bool kt = false;
            if (ExecuteNonQuery(sqlXoa) > 0)
            {
                kt = true;
            }
            return kt;
        }
       

    }
}
