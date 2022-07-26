using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DAO
{
    public class HoaDon
    {
        DatPhong dp;
        TraPhong tp;
        int sotien;
        public HoaDon(DatPhong dp, TraPhong tp, int sotien)
        {
            this.dp = dp;
            this.tp = tp;
            this.sotien = sotien;
        }
        public DatPhong Datphong
        { get { return dp; } }
        public TraPhong Traphong
        {
            get { return tp; }
        }
        public int tien
        {
            get { return sotien; }
        }
    }
}
