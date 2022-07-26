using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;

namespace DoAn.DAO
{
    class KetNoiCSDL
    {
        public SqlConnection conDB()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-D97AHVVU\SQLEXPRESS;Initial Catalog=SQLQUANLYKHACHSAN;Integrated Security=True");
            return con;
        }
    }
}
