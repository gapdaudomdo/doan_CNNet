using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DAO
{
    public class XuLyALL
    {
        SuperDAO dao = new SuperDAO();
        public XuLyALL()
        { }
            public XuLyALL(DAO.SuperDAO dao)
        {
            this.dao = dao;
        }
        public NhanVien[] GetListOfNhanVien()
        {
            return (dao.GetListOfNhanVien()).ToArray();
        }
        public KhachHang[] GetLishKhachHang()
        {
            return (dao.GetListOfKhachThue()).ToArray();
        }
        public Phong[] GetListOfPhong()
        {
            return (dao.GetListOfPhong()).ToArray();
        }
        public DatPhong[] GetListOfDatPhong()
        {
            return (dao.GetListOfDatPhong()).ToArray();
        }
        public TraPhong[] GetListOfTraPhong()
        {
            return (dao.GetListOfTraPhong().ToArray());
        }
        public HoaDon[] GetListOfHoaDon()
        {
            return (dao.GetListOfHoaDon()).ToArray();
        }
        public void ThemKhachHang(KhachHang khachHang)
        {
            dao.ThemKhachHang(khachHang);
        }
        public void ThemNhanVien(NhanVien nhanVien)
        {
            dao.ThemNhanVien(nhanVien);
        }
        public void XoaKhachHang(KhachHang khachHang)
        {
            dao.XoaKhachHang(khachHang);
        }
        public void XoaNhanVien(NhanVien nhanVien)
        {
            dao.XoaNhanVien(nhanVien);
        }
        public void SuaNhanVien(NhanVien nhanVien)
        {
            dao.SuaNhanVien(nhanVien);
        }
        public void SuaKhachHang(KhachHang khachHang)
        {
            dao.SuaKhachHang(khachHang);
        }
        public void ThemDatPhong(DatPhong datPhong) { dao.ThemDatPhong(datPhong); }
        public void ThemTraPhong(TraPhong traPhong) { dao.ThemTraPhong(traPhong); }
        public void XoaDatPhong(DatPhong datPhong) { dao.XoaDatPhong(datPhong); }
        public void XoaTraPhong(TraPhong traPhong) { dao.XoaTraPhong(traPhong); }
        public void ThemHoaDon(HoaDon hoaDon) { dao.ThemHoaDon(hoaDon); }
        public void XoaHoaDon(HoaDon hoaDon) { dao.XoaHoaDon(hoaDon); }
        public NhanVien[] TimKiemNhanVien(string matk,string tennv)
        {
            return (dao.TimKiemNhanVien(matk,tennv)).ToArray();
        }
        public KhachHang[] TimKiemKhachHang(string matk,string tenkh)
        {
            return (dao.TimKiemKhachHang(matk,tenkh)).ToArray();
        }
        public bool XoaKH(string maKH)
        {
            return dao.XoaKH(maKH);
        }
       
        public bool XoaKH_DatPhong(string maKH)
        {
            return dao.XoaKH_DatPhong(maKH);
        }
        public bool XoaKH_TraPhong(string maKH)
        {
            return dao.XoaKH_TraPhong(maKH);
        }
        public bool XoaKH_HoaDon(string maDP,string maTP)
        {
            return dao.XoaKH_HoaDon(maDP, maTP);
        }
     
    }
}
