﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace DoAn.DAO
{
    public class Account
    {
        SqlConnection conn = new SqlConnection("Data Source = LAPTOP-D97AHVVU\\SQLEXPRESS; Initial Catalog = SQLQUANLYKHACHSAN; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
      
        //đóng mở kết nối csdl

        //Load dữ liệu cho datagidview
        public DataTable HienThiDuLieu() //trả về 1 bảng
        {
           
            conn.Open();
            string sql = "SELECT * FROM Account";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public int ExecuteNonQuery(string sql)
        {
            int dung = 0;
            try
            {
                
                conn.Open(); ;
                SqlCommand cmd = new SqlCommand(sql, conn);
                dung = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            { }
            return dung;
        }
        public bool ThemAccount(string username, string display, string password, string quyen)
        {
            string sqlThem = "INSERT INTO [Account] ([UserName], [DisplayName],[PassWrd], [Quyen]) VALUES ('" + username + "',N'" + display + "', '" + password + "',N'" + quyen + "')";
            bool kt = false;
            if (ExecuteNonQuery(sqlThem) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool kiemTraTonTai(string maAcc)
        {
            conn.Open();
            bool tatkt = false;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT UserName FROM Account where UserName='" + maAcc + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (maAcc == dr.GetString(0))
                    {
                        tatkt = true;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            conn.Close();
            return tatkt;
        }

        public bool XoaAccount(string maAcc)
        {
            string sqlXoa = "DELETE FROM Account WHERE Id= '" + maAcc + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlXoa) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool SuaAccount(string username, string display, string password, string quyen)
        {
            string sqlSua = "UPDATE Account set DisplayName= N'" + display + "', PassWrd= '" + password + "',Quyen = N'" + quyen + "' where UserName= '" + username + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlSua) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public DataTable HienThiDuLieuTimKiem(string maAcc) //trả về 1 bảng
        {
           
            conn.Open();
            string sql = "SELECT * FROM Account where UserName LIKE '%" + maAcc + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

    }
}
