using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.DAO;



namespace DoAn
{
    public partial class fThuePhong : Form
    {
        BindingSource khachhang = new BindingSource();
        BindingSource phong = new BindingSource();
        public fThuePhong()
        {
            InitializeComponent();
            XuLyALL a = new XuLyALL();
            Phong[] phongs = a.GetListOfPhong();
            phong.DataSource = phongs;
            loadphong();
            Loaddanhsach();
            loadHoadon();
            
        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void fQLThuePhong_Load(object sender, EventArgs e)
        {
            

        }
        public void loadphong()
        {
            XuLyALL danhsachphong = new XuLyALL();
            Phong[] phongs = danhsachphong.GetListOfPhong();
            List<Phong> phongtrong = new List<Phong>();
            for (int i = 0; i < phongs.Length; i++)
            {
                Button btn = new Button();
                btn.Height = 70;
                btn.Width = 150;
                btn.Text = phongs[i].Name;
                if (phongs[i].Phongtrong == 0)
                {
                    btn.BackColor = Color.White;
                    btn.Text += "\n Trống";
                    cbbMaphong.DisplayMember = "Name";
                    phongtrong.Add(phongs[i]);
                }
                else { btn.BackColor = Color.DarkGreen; btn.Text = phongs[i].Name; btn.Text += "\n Có người"; }
                //flowLayoutPanelPhong.Controls.Add(btn);
                phong.DataSource = phongs;

            } cbbMaphong.DataSource = phongtrong;
            cbbMaphong.DisplayMember = "Name";
            rbtnNamphong.Checked = true;

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
            cbbMadatphong.DataSource = dats;
            cbbMadatphong.DisplayMember = "MaDatPhong";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
           
            if(txtMakhphong.Text.Length == 0 || txtTenkhphong.Text.Length == 0 || txtMakhphong.Text.Length == 0 ||txtDiachiphong.Text.Length==0 || txtEmailkhphong.Text.Length == 0 || txtCmndphong.Text.Length == 0 )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            if (txtMaDP.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtMaDP, "Nhập mã đặt phòng");
            }          
            else
            {
                this.errorProvider1.Clear();
                XuLyALL a = new XuLyALL();
                SuperDAO dao = new SuperDAO();
                string gioitinh;
                if (rbtnNamphong.Checked == true)
                {
                    gioitinh = "Nam";
                }
                else gioitinh = "Nữ";
                KhachHang[] khachHangs = a.GetLishKhachHang();
                DatPhong[] datPhongs = a.GetListOfDatPhong();
                bool xet = true;
                for (int i = 0; i < khachHangs.Length; i++)
                {
                    if (khachHangs[i].Id == txtMakhphong.Text || khachHangs[i].CMND == txtCmndphong.Text) xet = false;
                    for (int j = 0; j < datPhongs.Length; j++) if (datPhongs[j].MaDatPhong == txtMaDP.Text) xet = false;
                }
                if (xet)
                {
                    KhachHang khachHang = new KhachHang(txtTenkhphong.Text, txtMakhphong.Text, txtDiachiphong.Text, dateTimeNgaysinhkhphong.Value, txtEmailkhphong.Text, gioitinh, txtCmndphong.Text);
                    a.ThemKhachHang(khachHang);
                    khachhang.DataSource = a.GetLishKhachHang();
                    Phong phong = (Phong)cbbMaphong.SelectedItem;
                    phong.Phongtrongset(1);
                    dao.SuaPhong(phong);
                    DatPhong datPhong = new DatPhong(txtMaDP.Text, khachHang, phong, dateTimeDatphong.Value);
                    a.ThemDatPhong(datPhong);
                    khachhang.DataSource = a.GetLishKhachHang();
                    loadphong();
                    khachchuatraphong();
                    MessageBox.Show("Lưu thành công");
                    txtMakhphong.Clear(); txtTenkhphong.Clear(); txtDiachiphong.Clear(); txtEmailkhphong.Clear(); txtMaDP.Clear(); txtCmndphong.Clear();
                }
                else MessageBox.Show("Thông tin khách hàng không hợp lý hoặc chưa nhập đầy đủ , trùng CMND, mã khách hàng hoặc mã đặt phòng");
            }
        }


        private void groupBox11_Enter(object sender, EventArgs e)
        {

        }
        public void loadHoadon()
        {
            lvHoadon.Items.Clear();
            XuLyALL danhsach = new XuLyALL();
            HoaDon[] hoaDons = danhsach.GetListOfHoaDon();
            foreach (HoaDon hoadon in hoaDons)
            {
                ListViewItem lvItem = new ListViewItem(hoadon.Datphong.MaDatPhong.ToString());
                lvItem.SubItems.Add(hoadon.Traphong.MaTraPhong.ToString());
                lvItem.SubItems.Add(hoadon.Datphong.khachhang.Id.ToString());
                lvItem.SubItems.Add(hoadon.Datphong.khachhang.Name.ToString());
                lvItem.SubItems.Add(hoadon.Datphong.phong.Name.ToString());
                lvItem.SubItems.Add(hoadon.Datphong.Ngaydat.ToString());
                lvItem.SubItems.Add(hoadon.Traphong.Ngaytra.ToString());
                lvItem.SubItems.Add(hoadon.tien.ToString());
                lvHoadon.Items.Add(lvItem);
            }
        }
        
        private void Loaddanhsach()
        {
            XuLyALL danhsach = new XuLyALL();
            KhachHang[] khachHangs = danhsach.GetLishKhachHang();
            HoaDon[] hoaDons = danhsach.GetListOfHoaDon();
            khachhang.DataSource = khachHangs;
            khachchuatraphong();
            

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cbbMadatphong_MouseClick(object sender, MouseEventArgs e)
        {
            DatPhong datPhong = (DatPhong)cbbMadatphong.SelectedItem;
            if (datPhong != null)
            {
                txtTenkhtra.Text = datPhong.khachhang.Name;
                txtDiachikhtra.Text = datPhong.khachhang.Diachi;
                txtCmndkhtra.Text = datPhong.khachhang.CMND;
                txtEmailtra.Text = datPhong.khachhang.Email;
                txtGioitinhkhtra.Text = datPhong.khachhang.Gioitinh;
                txtMaphongtra.Text = datPhong.phong.Name;
                dateTimeDatphongtra.Value = datPhong.Ngaydat;
                dateTimeNgaysinhkhachhangtra.Value = datPhong.khachhang.Ngaysinh;
            }
        }

        private void btnXuatReport_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Xuat_Click(object sender, EventArgs e)
        {
          
            if (txtMatraphong.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtMatraphong, "Nhập mã trả phòng");
            }
            else
            {
                this.errorProvider1.Clear();
                SuperDAO a = new SuperDAO();
                XuLyALL dao = new XuLyALL();
                DatPhong datPhong = (DatPhong)cbbMadatphong.SelectedItem;
                TraPhong traPhong = new TraPhong(txtMatraphong.Text, datPhong.khachhang, datPhong.phong, dateTimeTraphong.Value);
                dao.ThemTraPhong(traPhong);
                Phong phong = a.GetPhong(datPhong.phong.Id);
                int sotien = phong.Giaphong * (traPhong.Ngaytra - datPhong.Ngaydat).Days;
                txtThanhtien.Text = sotien.ToString();
                txtThanhtien.Show();
                HoaDon hoaDon = new HoaDon(datPhong, traPhong, sotien);
                dao.ThemHoaDon(hoaDon);
                phong.Phongtrongset(0);
                a.SuaPhong(phong);
                loadphong();
                khachchuatraphong();
                loadHoadon();
                txtMatraphong.Clear();
            }
        }

        private void btn_XuatRP_Click(object sender, EventArgs e)
        {
            fXuatHoaDon f = new fXuatHoaDon();
            f.Show();
            this.Hide();
        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }
    }
}
