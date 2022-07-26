using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DAO
{
    public class NhanVien : User
    {
        string diachi, cmnd, dienthoai, email, gioitinh, loainv;
        DateTime ngaysinh;
        public NhanVien(string name, string id)
        {
            this.name = name;
            this.id = id;
        }
        public NhanVien(string name, string id, string diachi, DateTime ngaysinh, string cmnd, string dienthoai, string email, string gioitinh, string loainv)
        {
            this.name = name;
            this.id = id;
            this.diachi = diachi;
            this.cmnd = cmnd;
            this.ngaysinh = ngaysinh;
            this.email = email;
            this.gioitinh = gioitinh;
            this.loainv = loainv;
            this.dienthoai = dienthoai;
        }
        public string Diachi
        { get { return diachi; } }
        public string CMND
        {
            get { return cmnd; }
        }
        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
        }
        public string Dienthoai
        {
            get { return dienthoai; }
        }
        public string Email
        {
            get { return email; }
        }
        public string Gioitinh
        {
            get { return gioitinh; }
        }
        public string LoaiNV
        {
            get { return loainv; }
        }
    }
}
