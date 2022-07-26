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
    public partial class fThongTin : Form
    {
        BindingSource phong = new BindingSource();

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
                    btn.Text += "\n Phòng Trống";
                    
                    phongtrong.Add(phongs[i]);
                }
                else { btn.BackColor = Color.DarkGreen; btn.Text = phongs[i].Name; btn.Text += "\n Đã Đặt"; }
                flowLayoutPanelPhong.Controls.Add(btn);
                phong.DataSource = phongs;

                

            }
        }
        public fThongTin()
        {
            XuLyALL a = new XuLyALL();
            Phong[] phongs = a.GetListOfPhong();
            InitializeComponent();
            dgvPhong.DataSource = phong;
            phong.DataSource = phongs;
            loadphong();
            
        }

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void fThongTin_Load(object sender, EventArgs e)
        {

        }
       

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            try
            {
                numrow = e.RowIndex;
                txtLoaiphong.Text = dgvPhong.Rows[numrow].Cells[0].Value.ToString();
                txtPhongtrong.Text = dgvPhong.Rows[numrow].Cells[1].Value.ToString();
                txtGiaphong.Text = dgvPhong.Rows[numrow].Cells[2].Value.ToString();
                txtTenphong.Text = dgvPhong.Rows[numrow].Cells[3].Value.ToString();
                txtMaphong.Text = dgvPhong.Rows[numrow].Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

       
    }
}
