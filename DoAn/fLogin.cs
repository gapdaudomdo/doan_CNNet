using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using DoAn.DAO;

namespace DoAn
{
    public partial class fLogin : Form
    {
        //SqlConnection con = new SqlConnection("Data Source = PANDA-PC\\SQLEXPRESS2012; Initial Catalog = SQLQUANLYKHACHSAN; Integrated Security = True");
        KetNoiCSDL cn = new KetNoiCSDL();
        SqlConnection con;
        public fLogin()
        {
            InitializeComponent();
        }


        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            string cd = "";
            string name = "";
            string line = "";
            try
            {
                using (StreamReader sr = new StreamReader("file.txt"))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        cd = line;
                        line = sr.ReadLine();
                        name = line;
                    }
                    txtUserName.Text = cd.ToString();
                    txtPassWord.Text = name.ToString();
                    sr.Close();
                }
            }
            catch
            {

            }
           
        }

        private void gunardangnhap_Click(object sender, EventArgs e)
        {
            //con.Open();
            con = cn.conDB();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Account where UserName='" + txtUserName.Text + "'and Passwrd='" + txtPassWord.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string userName = txtUserName.Text;
            string passWord = txtPassWord.Text;
            if (check_DangNhap.Checked)
            {
                string[] names = new string[] { txtUserName.Text, txtPassWord.Text };

                using (StreamWriter sw = new StreamWriter("file.txt"))
                {
                    foreach (string s in names)
                    {

                        sw.WriteLine(s);
                    }
                    sw.Close();
                }
            }
            else
            {
                string[] names = new string[] { "", "" };

                using (StreamWriter sw = new StreamWriter("file.txt"))
                {
                    foreach (string s in names)
                    {
                        sw.WriteLine(s);
                    }
                    sw.Close();
                }
            }
            try
            {
                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    Form1 fmain = new Form1(dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString());//
                    fmain.Show();
                    MessageBox.Show("Chào mừng " + dt.Rows[0][1].ToString(), "Đăng nhập thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch
            {
                MessageBox.Show("Không thể kết nối Server", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }




    }
}
