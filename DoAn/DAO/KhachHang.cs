using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DAO
{
    public class KhachHang : User
    {
        string diachi, cmnd, email, gioitinh;
        DateTime ngaysinh;
        public KhachHang(string name, string id)
        {
            this.name = name;
            this.id = id;
        }
        public KhachHang(string name, string id, string diachi, DateTime ngaysinh, string email, string gioitinh, string cmnd)
        {
            this.name = name;
            this.id = id;
            this.diachi = diachi;
            this.cmnd = cmnd;
            this.email = email;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
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
        public string Email
        {
            get { return email; }
        }
        public string Gioitinh
        {
            get { return gioitinh; }
        }
    }
}
