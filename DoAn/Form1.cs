using DoAn.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        BindingSource phong = new BindingSource();
        string username1 = "", display1 = "", pass1 = "", quyen1 = "";
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        public Form1(string username1, string display1, string pass1, string quyen1)
        {
            InitializeComponent();
            //lblxinchao.Text = "Xin chào "+ display1.ToString();
            random = new Random();
            XuLyALL a = new XuLyALL();
            Phong[] phongs = a.GetListOfPhong();
            phong.DataSource = phongs;
            this.username1 = username1;
            this.display1 = display1;
            this.pass1 = pass1;
            this.quyen1 = quyen1;
        }

        private void btnThongTinPhong_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            ActivateButton(sender);
            fThongTin frm2 = new fThongTin();
            frm2.TopLevel = false;
            panel2.Controls.Add(frm2);
            frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            ActivateButton(sender);
            fNhanVien frm3 = new fNhanVien();
            frm3.TopLevel = false;
            panel2.Controls.Add(frm3);
            frm3.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm3.Dock = DockStyle.Fill;
            frm3.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            panel2.Controls.Clear();
            fKhachHang frm4 = new fKhachHang();
            frm4.TopLevel = false;
            panel2.Controls.Add(frm4);
            frm4.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm4.Dock = DockStyle.Fill;
            frm4.Show();
        }

        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            panel2.Controls.Clear();
            fThuePhong frm5 = new fThuePhong();
            frm5.TopLevel = false;
            panel2.Controls.Add(frm5);
            frm5.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm5.Dock = DockStyle.Fill;
            frm5.Show();
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            fHeThong frm6 = new fHeThong();
            frm6.TopLevel = false;
            frm6.Dock = DockStyle.Fill;
            panel2.Controls.Add(frm6);
            frm6.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm6.Show();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }

        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
            if (a == DialogResult.Yes)
            {
                
                Close();
                fLogin f = new fLogin();
                f.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblxinchao.Text = "Xin chào " + display1 + ",";
            if (quyen1 == "Admin")
            {
                btnHeThong.Visible = true;

            }
            else
            {
                btnHeThong.Visible = false;
            }
        }

 

       
      
    }
}
