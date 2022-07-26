using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DAO
{
    public class DatPhong : Thue
    {
        DateTime ngaydat;
        string MaDP;
        public DatPhong(string MaDP, KhachHang kh, Phong ph)
        {
            this.MaDP = MaDP;
            this.kh = kh;
            this.ph = ph;
        }
        public DatPhong(string MaDP, KhachHang kh, Phong ph, DateTime ngaydat)
        {
            this.MaDP = MaDP;
            this.kh = kh;
            this.ph = ph;
            this.ngaydat = ngaydat;
        }
        public DateTime Ngaydat
        {
            get { return ngaydat; }
        }
        public string MaDatPhong { get { return MaDP; } }
    }
}
