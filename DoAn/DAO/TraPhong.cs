using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DAO
{
    public class TraPhong : Thue
    {
        DateTime ngaytra;
        string MaTP;
        public TraPhong(string MaTP, KhachHang kh, Phong ph)
        {
            this.MaTP = MaTP;
            this.kh = kh;
            this.ph = ph;
        }
        public TraPhong(string MaTP, KhachHang kh, Phong ph, DateTime ngaytra)
        {
            this.MaTP = MaTP;
            this.kh = kh;
            this.ph = ph;
            this.ngaytra = ngaytra;
        }
        public DateTime Ngaytra
        {
            get { return ngaytra; }
        }
        public string MaTraPhong { get { return MaTP; } }
    }
}
