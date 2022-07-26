using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DoAn.DAO
{
    public class AccountController
    {
        Account acc = new Account();
        public DataTable HienThiDuLieu()
        {
            return acc.HienThiDuLieu();
        }
        public bool ThemDuLieuAccount(string username, string display, string password, string quyen)
        {
            return acc.ThemAccount(username, display, password, quyen);
        }
        public bool KiemTraDuLieuAccount(string username)
        {
            return acc.kiemTraTonTai(username);
        }
        public bool XoaDuLieuAccount(string username)
        {
            return acc.XoaAccount(username);
        }
        public bool SuaDuLieuAccount(string username, string display, string password, string quyen)
        {
            return acc.SuaAccount(username, display, password, quyen);
        }
        public DataTable HienThiDuLieuTimKiem(string maAcc)
        {
            return acc.HienThiDuLieuTimKiem(maAcc);
        }
    }
}
