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
    public partial class fKhachHang : Form
    {
        fThongTin f = new fThongTin();
        fThuePhong f1 = new fThuePhong();
        BindingSource khachhang = new BindingSource();
        KetNoiCSDL ketnoi = new KetNoiCSDL();
        SqlConnection con;
        SqlCommand cm;
        public fKhachHang()
        {
            XuLyALL a = new XuLyALL();
            Phong[] phongs = a.GetListOfPhong();
            InitializeComponent();
            dgvKhachhang.DataSource = khachhang;
            Loaddanhsach();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        private void Loaddanhsach()
        {
            XuLyALL danhsach = new XuLyALL();
            KhachHang[] khachHangs = danhsach.GetLishKhachHang();
            HoaDon[] hoaDons = danhsach.GetListOfHoaDon();
            khachhang.DataSource = khachHangs;
            khachchuatraphong();
            

        }
        private void khachchuatraphong()
        {
            XuLyALL danhsach = new XuLyALL();
            DatPhong[] datPhongs = danhsach.GetListOfDatPhong();
            List<DatPhong> dats = new List<DatPhong>();
            KhachHang[] khachHangs = danhsach.GetLishKhachHang();
            TraPhong[] traPhongs = danhsach.GetListOfTraPhong();
            for (int i = 0; i < datPhongs.Length; i++)
            {
                bool chophep = true;
                for (int j = 0; j < traPhongs.Length; j++)
                {
                    if (datPhongs[i].khachhang.Id == traPhongs[j].khachhang.Id) { chophep = false; break; }
                }
                if (chophep)
                {
                    dats.Add(datPhongs[i]);
                }
            }
        }

        private void dgvKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            XuLyALL a = new XuLyALL();
            khachhang.DataSource = a.GetLishKhachHang();
        }
        

        private void btnTimKhachhang_Click(object sender, EventArgs e)
        {

            XuLyALL a = new XuLyALL();
            KhachHang[] khachhangs = a.GetLishKhachHang();
            khachhang.DataSource = a.TimKiemKhachHang(txtMatimkiem.Text, txtMatimkiem.Text);
        }

        private void dgvKhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMakhkh.Text = dgvKhachhang.Rows[numrow].Cells[6].Value.ToString();
            txtDiachikhachhang.Text = dgvKhachhang.Rows[numrow].Cells[0].Value.ToString();
            txtHotenkh.Text = dgvKhachhang.Rows[numrow].Cells[5].Value.ToString();
            txtSocmnd.Text = dgvKhachhang.Rows[numrow].Cells[1].Value.ToString();
            txtEmail.Text = dgvKhachhang.Rows[numrow].Cells[3].Value.ToString();
            dateTimeNgaysinhkhachhang.Text = dgvKhachhang.Rows[numrow].Cells[2].Value.ToString();
            if (this.dgvKhachhang.CurrentRow.Cells[4].Value.Equals("Nam"))
                rbtnNamkh.Checked = true;
            else
                rbtnNukh.Checked = true;
        }

       

     
      

        private void btn_SuaKH_Click(object sender, EventArgs e)
        {
            XuLyALL a = new XuLyALL();
            string gioitinh;
            if (rbtnNamkh.Checked == true)
            {
                gioitinh = "Nam";
            }
            else gioitinh = "Nữ";
            KhachHang khachHang = new KhachHang(txtHotenkh.Text, txtMakhkh.Text, txtDiachikhachhang.Text, dateTimeNgaysinhkhachhang.Value, txtEmail.Text, gioitinh, txtSocmnd.Text);
            a.SuaKhachHang(khachHang);
            khachhang.DataSource = a.GetLishKhachHang();
            khachchuatraphong();
            
        }

        private void btnXoaKhachhang_Click(object sender, EventArgs e)
        {
            XuLyALL a = new XuLyALL();
            SuperDAO dao = new SuperDAO();
            KhachHang khachHang = dao.GetKhachThue(txtMakhkh.Text);
            DatPhong[] datPhongs = a.GetListOfDatPhong();
            TraPhong[] traphongs = a.GetListOfTraPhong();

            DialogResult r;
            r = MessageBox.Show("Bạn có muốn Xóa " + txtMakhkh.Text, "Xóa",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                for (int i = 0; i < datPhongs.Length; i++)
                {
                    if (datPhongs[i].khachhang.Id == txtMakhkh.Text)
                    {
                        DatPhong datPhong = datPhongs[i];
                        for (int j = 0; j < traphongs.Length; j++)
                        {
                            if (traphongs[j].khachhang.Id == txtMakhkh.Text)
                            {

                                TraPhong traPhong = traphongs[j];

                                HoaDon hoaDon = new HoaDon(datPhong, traPhong, 0);
                                a.XoaHoaDon(hoaDon);
                                a.XoaTraPhong(traPhong);
                                break;
                            }
                        }
                        Phong phong = dao.GetPhong(datPhongs[i].phong.Id);
                        phong.Phongtrongset(0);
                        dao.SuaPhong(phong);
                        a.XoaDatPhong(datPhong);
                        break;
                    }
                }
                a.XoaKhachHang(khachHang);
                khachhang.DataSource = a.GetLishKhachHang();
                f.loadphong();
                
                khachchuatraphong();
                f1.loadHoadon();
            }
        }
    }
}
