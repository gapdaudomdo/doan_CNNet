using DoAn.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class fHeThong : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = PANDA-PC\\SQLEXPRESS2012; Initial Catalog = SQLQUANLYKHACHSAN; Integrated Security = True");

        AccountController ac = new AccountController();
        public fHeThong()
        {
            InitializeComponent();
        }
        private bool KTNhap()
        {
            if (txtUserName.TextLength == 0)
            {
                txtUserName.Focus();
                MessageBox.Show("Bạn chưa nhập tên tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtDisplayName.TextLength == 0)
            {
                txtDisplayName.Focus();
                MessageBox.Show("Bạn chưa nhập DisplayName!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtPassWord.TextLength == 0)
            {
                txtPassWord.Focus();
                MessageBox.Show("Bạn chưa nhập Password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public void LoadAccount()
        {
            try
            {
                
                dtgvQLTK_Show.AutoGenerateColumns = false;
                DataTable dtAc = new DataTable();
                dtAc = ac.HienThiDuLieu();
                dtgvQLTK_Show.DataSource = dtAc;
                dtgvQLTK_Show.Columns[0].DataPropertyName = "Id";
                dtgvQLTK_Show.Columns[1].DataPropertyName = "UserName";
                dtgvQLTK_Show.Columns[2].DataPropertyName = "DisplayName";
                dtgvQLTK_Show.Columns[3].DataPropertyName = "Passwrd";
                dtgvQLTK_Show.Columns[4].DataPropertyName = "Quyen";

            }
            catch
            {
                
            }
        }
        private void btnQLTK_Them_Click(object sender, EventArgs e)
        {
           
        }

        private void fHeThong_Load(object sender, EventArgs e)
        {
            LoadAccount();
            cmbQuyen.SelectedIndex = 0;
        }

        private void btnQLTK_Xoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnQLTK_Sua_Click(object sender, EventArgs e)
        {
           
        }

        private void btnQLTK_Luu_Click(object sender, EventArgs e)
        {
            
        }

        private void dtgvQLTK_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            try
            {
                numrow = e.RowIndex;
                txtUserName.Text = dtgvQLTK_Show.Rows[numrow].Cells[1].Value.ToString();
                txtDisplayName.Text = dtgvQLTK_Show.Rows[numrow].Cells[2].Value.ToString();
                txtPassWord.Text = dtgvQLTK_Show.Rows[numrow].Cells[3].Value.ToString();
                cmbQuyen.Text = dtgvQLTK_Show.Rows[numrow].Cells[4].Value.ToString();
            }
            catch
            {
                
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (!KTNhap())
            {
                return;
            }

            if (ac.KiemTraDuLieuAccount(txtUserName.Text))
            {
                MessageBox.Show("Tên tài khoản đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    ac.ThemDuLieuAccount(txtUserName.Text, txtDisplayName.Text, txtPassWord.Text, cmbQuyen.Text);
                    MessageBox.Show("Thêm tài khoản thành công!");
                    LoadAccount();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex);
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtSearchUser.Text = "";
            txtUserName.Text = "";
            txtPassWord.Text = "";
            txtDisplayName.Text = "";
            txtUserName.Focus();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (!KTNhap())
            {
                return;
            }
            else
            {
                if (ac.KiemTraDuLieuAccount(txtUserName.Text))
                {
                    try
                    {
                        ac.SuaDuLieuAccount(txtUserName.Text, txtDisplayName.Text, txtPassWord.Text, cmbQuyen.Text);
                        MessageBox.Show("Sửa tài khoản thành công!");
                        LoadAccount();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Tên tài khoản chưa đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
       

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dtgvQLTK_Show.SelectedCells.Count > 0)
            {
                DialogResult r = MessageBox.Show("Xác nhận xoá", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    int rowindex = dtgvQLTK_Show.CurrentCell.RowIndex;

                    string id = dtgvQLTK_Show.Rows[rowindex].Cells[0].Value.ToString();
                    if (ac.XoaDuLieuAccount(id))
                    {
                        MessageBox.Show("Xoá tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAccount();
                    }
                    else
                    {
                        MessageBox.Show("Xoá tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public DataTable HienThiDuLieuTimKiem(string maAcc) //trả về 1 bảng
        {

            conn.Open();
            string sql = "SELECT * FROM Account where UserName LIKE '%" + maAcc + "%' OR DisplayName LIKE'%" + maAcc + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dtgvQLTK_Show.AutoGenerateColumns = false;
                DataTable dtAc = new DataTable();
                dtAc = ac.HienThiDuLieuTimKiem(txtSearchUser.Text);
                dtgvQLTK_Show.DataSource = dtAc;
                dtgvQLTK_Show.Columns[0].DataPropertyName = "Id";
                dtgvQLTK_Show.Columns[1].DataPropertyName = "UserName";
                dtgvQLTK_Show.Columns[2].DataPropertyName = "DisplayName";
                dtgvQLTK_Show.Columns[3].DataPropertyName = "PassWrd";
                dtgvQLTK_Show.Columns[4].DataPropertyName = "Quyen";

            }
            catch
            {
                
            }
        }
    }
}
