using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DoAn.DAO;

namespace DoAn
{
    public partial class fNhanVien : Form
    {
        BindingSource nhanvien = new BindingSource();
        
        public fNhanVien()
        {
            XuLyALL a = new XuLyALL();
            Phong[] phongs = a.GetListOfPhong();
            InitializeComponent();
            dgvNhanvien.DataSource = nhanvien;
            loadNhanvien();
            rbtnNamnv.Checked = true;
            rbtnThungan.Checked = true;
        }

   
        private void loadNhanvien()
        {
            XuLyALL danhsach = new XuLyALL();
            NhanVien[] nhanViens = danhsach.GetListOfNhanVien();
            nhanvien.DataSource = nhanViens;
            
        }
   

      

        private void btnTimNhanvien_Click(object sender, EventArgs e)
        {
            XuLyALL a = new XuLyALL();
            nhanvien.DataSource = a.TimKiemNhanVien(textBox1.Text,textBox1.Text);
            
        }

      

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            try
            {
                numrow = e.RowIndex;
                txtDiachinv.Text = dgvNhanvien.Rows[numrow].Cells[0].Value.ToString();
                txtCmndnv.Text = dgvNhanvien.Rows[numrow].Cells[1].Value.ToString();
                dateTimeNgaysinhnv.Text = dgvNhanvien.Rows[numrow].Cells[2].Value.ToString();
                txtDienthoainv.Text = dgvNhanvien.Rows[numrow].Cells[3].Value.ToString();
                txtEmailnv.Text = dgvNhanvien.Rows[numrow].Cells[4].Value.ToString();
                txtHotennv.Text = dgvNhanvien.Rows[numrow].Cells[5].Value.ToString();
                txtManv.Text = dgvNhanvien.Rows[numrow].Cells[8].Value.ToString();
                if (this.dgvNhanvien.CurrentRow.Cells[5].Value.Equals("Nam"))
                    rbtnNamnv.Checked = true;
                else
                    rbtnNunv.Checked = true;

                if (this.dgvNhanvien.CurrentRow.Cells[6].Value.Equals("Phục vụ"))
                    rbtnPhucvu.Checked = true;
                else if (this.dgvNhanvien.CurrentRow.Cells[6].Value.Equals("Thu ngân"))
                    rbtnThungan.Checked = true;
                else if (this.dgvNhanvien.CurrentRow.Cells[6].Value.Equals("Dọn phòng"))
                    rbtnDonPhong.Checked = true;
                else
                    rbtnBaoVe.Checked = true;
            }
            catch
            {

            }
            
        }

        private void btn_ClearNV_Click(object sender, EventArgs e)
        {
            txtCmndnv.Text = "";
            txtDiachinv.Text = "";
            txtDienthoainv.Text = "";
            txtEmailnv.Text = "";
            txtHotennv.Text = "";
            txtManv.Text = "";
            dateTimeNgaysinhnv.Text = "";
        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            XuLyALL a = new XuLyALL();
            string gioitinh;
            if (txtManv.Text.Length == 0 || txtDienthoainv.Text.Length == 0 || txtDiachinv.Text.Length == 0 || txtHotennv.Text.Length == 0 || txtCmndnv.Text.Length == 0 || txtEmailnv.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            if (rbtnNamnv.Checked == true)
            {
                gioitinh = "Nam";
            }
            else gioitinh = "Nữ";
            string loainv;
            if (rbtnPhucvu.Checked == true)
            {
                loainv = "Phục vụ";

            }
            else if (rbtnDonPhong.Checked == true)
            {
                loainv = "Dọn phòng";
            }
            else if (rbtnBaoVe.Checked == true)
            {
                loainv = "Bảo vệ";
            }
            else
            {
                loainv = "Thu ngân";
            }
            NhanVien[] nhanviens = a.GetListOfNhanVien();
            bool xet = true;
            for (int i = 0; i < nhanviens.Length; i++)
            {
                if (nhanviens[i].Id == txtManv.Text || nhanviens[i].CMND == txtCmndnv.Text) xet = false;
            }
            if (xet)
            {
                NhanVien NhanVien = new NhanVien(txtHotennv.Text, txtManv.Text, txtDiachinv.Text, dateTimeNgaysinhnv.Value, txtCmndnv.Text, txtDienthoainv.Text, txtEmailnv.Text, gioitinh, loainv);
                a.ThemNhanVien(NhanVien);
                nhanvien.DataSource = a.GetListOfNhanVien();
                MessageBox.Show("Đã thêm thành công nhân viên");
            }
            else MessageBox.Show("Thông tin nhân viên không hợp lý");
        }

        private void btn_SuaNV_Click(object sender, EventArgs e)
        {
            XuLyALL a = new XuLyALL();
            string gioitinh;
            if (rbtnNamnv.Checked == true)
            {
                gioitinh = "Nam";
            }
            else gioitinh = "Nữ";
            string loainv;
            if (rbtnPhucvu.Checked == true)
            {
                loainv = "Phục vụ";
            }
            else if (rbtnDonPhong.Checked == true)
            {
                loainv = "Dọn phòng";
            }
            else if (rbtnBaoVe.Checked == true)
            {
                loainv = "Bảo vệ";
            }
            else
            {
                loainv = "Thu ngân";
            }
            try
            {
                NhanVien NhanVien = new NhanVien(txtHotennv.Text, txtManv.Text, txtDiachinv.Text, dateTimeNgaysinhnv.Value, txtCmndnv.Text, txtDienthoainv.Text, txtEmailnv.Text, gioitinh, loainv);
                a.SuaNhanVien(NhanVien);
                nhanvien.DataSource = a.GetListOfNhanVien();
                MessageBox.Show("Đã sửa thành công nhân viên");

            }
            catch
            {
                MessageBox.Show("Lỗi!!!");
            }
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            XuLyALL a = new XuLyALL();
            SuperDAO dao = new SuperDAO();
            NhanVien nhanVien = dao.GetNhanVien(txtManv.Text);
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn Xóa " + txtManv.Text, "Xóa",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                a.XoaNhanVien(nhanVien);
                nhanvien.DataSource = a.GetListOfNhanVien();
            }
        }
    }
}
