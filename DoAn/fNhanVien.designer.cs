namespace DoAn
{
    partial class fNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_ClearNV = new System.Windows.Forms.ToolStripButton();
            this.btn_ThemNV = new System.Windows.Forms.ToolStripButton();
            this.btn_SuaNV = new System.Windows.Forms.ToolStripButton();
            this.btn_XoaNV = new System.Windows.Forms.ToolStripButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtCmndnv = new System.Windows.Forms.TextBox();
            this.CMND = new System.Windows.Forms.Label();
            this.txtEmailnv = new System.Windows.Forms.TextBox();
            this.txtDiachinv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHotennv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDienthoainv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeNgaysinhnv = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTimNhanvien = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvNhanvien = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnBaoVe = new System.Windows.Forms.RadioButton();
            this.rbtnDonPhong = new System.Windows.Forms.RadioButton();
            this.rbtnPhucvu = new System.Windows.Forms.RadioButton();
            this.rbtnThungan = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnNunv = new System.Windows.Forms.RadioButton();
            this.rbtnNamnv = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1246, 641);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_ClearNV,
            this.btn_ThemNV,
            this.btn_SuaNV,
            this.btn_XoaNV});
            this.toolStrip1.Location = new System.Drawing.Point(4, 19);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1238, 27);
            this.toolStrip1.TabIndex = 32;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_ClearNV
            // 
            this.btn_ClearNV.ForeColor = System.Drawing.Color.Black;
            this.btn_ClearNV.Image = global::DoAn.Properties.Resources.actions_edit_clear_15784;
            this.btn_ClearNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ClearNV.Name = "btn_ClearNV";
            this.btn_ClearNV.Size = new System.Drawing.Size(67, 24);
            this.btn_ClearNV.Text = "Clear";
            this.btn_ClearNV.Click += new System.EventHandler(this.btn_ClearNV_Click);
            // 
            // btn_ThemNV
            // 
            this.btn_ThemNV.ForeColor = System.Drawing.Color.Black;
            this.btn_ThemNV.Image = global::DoAn.Properties.Resources.addusergroup_1251;
            this.btn_ThemNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ThemNV.Name = "btn_ThemNV";
            this.btn_ThemNV.Size = new System.Drawing.Size(70, 24);
            this.btn_ThemNV.Text = "Thêm";
            this.btn_ThemNV.Click += new System.EventHandler(this.btn_ThemNV_Click);
            // 
            // btn_SuaNV
            // 
            this.btn_SuaNV.ForeColor = System.Drawing.Color.Black;
            this.btn_SuaNV.Image = global::DoAn.Properties.Resources._3706888_assembly_control_fix_setting_108715;
            this.btn_SuaNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SuaNV.Name = "btn_SuaNV";
            this.btn_SuaNV.Size = new System.Drawing.Size(58, 24);
            this.btn_SuaNV.Text = "Sửa";
            this.btn_SuaNV.Click += new System.EventHandler(this.btn_SuaNV_Click);
            // 
            // btn_XoaNV
            // 
            this.btn_XoaNV.ForeColor = System.Drawing.Color.Black;
            this.btn_XoaNV.Image = global::DoAn.Properties.Resources.flat_style_circle_delete_trash_icon_icons_com_66945;
            this.btn_XoaNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_XoaNV.Name = "btn_XoaNV";
            this.btn_XoaNV.Size = new System.Drawing.Size(59, 24);
            this.btn_XoaNV.Text = "Xóa";
            this.btn_XoaNV.Click += new System.EventHandler(this.btn_XoaNV_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtCmndnv);
            this.groupBox5.Controls.Add(this.CMND);
            this.groupBox5.Controls.Add(this.txtEmailnv);
            this.groupBox5.Controls.Add(this.txtDiachinv);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txtManv);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtHotennv);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txtDienthoainv);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.dateTimeNgaysinhnv);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(89, 130);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(801, 202);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin nhân viên:";
            // 
            // txtCmndnv
            // 
            this.txtCmndnv.Location = new System.Drawing.Point(499, 161);
            this.txtCmndnv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCmndnv.Name = "txtCmndnv";
            this.txtCmndnv.Size = new System.Drawing.Size(248, 22);
            this.txtCmndnv.TabIndex = 28;
            // 
            // CMND
            // 
            this.CMND.AutoSize = true;
            this.CMND.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CMND.Location = new System.Drawing.Point(414, 161);
            this.CMND.Name = "CMND";
            this.CMND.Size = new System.Drawing.Size(69, 17);
            this.CMND.TabIndex = 27;
            this.CMND.Text = "Số CMND";
            // 
            // txtEmailnv
            // 
            this.txtEmailnv.Location = new System.Drawing.Point(499, 124);
            this.txtEmailnv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmailnv.Name = "txtEmailnv";
            this.txtEmailnv.Size = new System.Drawing.Size(248, 22);
            this.txtEmailnv.TabIndex = 12;
            // 
            // txtDiachinv
            // 
            this.txtDiachinv.Location = new System.Drawing.Point(499, 87);
            this.txtDiachinv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiachinv.Name = "txtDiachinv";
            this.txtDiachinv.Size = new System.Drawing.Size(248, 22);
            this.txtDiachinv.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(433, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Họ tên";
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(93, 43);
            this.txtManv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(251, 22);
            this.txtManv.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(428, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(428, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Địa chỉ";
            // 
            // txtHotennv
            // 
            this.txtHotennv.Location = new System.Drawing.Point(499, 43);
            this.txtHotennv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHotennv.Name = "txtHotennv";
            this.txtHotennv.Size = new System.Drawing.Size(248, 22);
            this.txtHotennv.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV";
            // 
            // txtDienthoainv
            // 
            this.txtDienthoainv.Location = new System.Drawing.Point(93, 91);
            this.txtDienthoainv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDienthoainv.Name = "txtDienthoainv";
            this.txtDienthoainv.Size = new System.Drawing.Size(249, 22);
            this.txtDienthoainv.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Điện thoại";
            // 
            // dateTimeNgaysinhnv
            // 
            this.dateTimeNgaysinhnv.CustomFormat = "dd/MM/yyyy";
            this.dateTimeNgaysinhnv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgaysinhnv.Location = new System.Drawing.Point(91, 145);
            this.dateTimeNgaysinhnv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeNgaysinhnv.Name = "dateTimeNgaysinhnv";
            this.dateTimeNgaysinhnv.Size = new System.Drawing.Size(251, 22);
            this.dateTimeNgaysinhnv.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.btnTimNhanvien);
            this.groupBox4.Location = new System.Drawing.Point(89, 49);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(684, 75);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tim kiếm nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông tin cần tìm:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 22);
            this.textBox1.TabIndex = 0;
            // 
            // btnTimNhanvien
            // 
            this.btnTimNhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTimNhanvien.Image = global::DoAn.Properties.Resources.business_man_usersearch_thesearch_theclient_2356__1_;
            this.btnTimNhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimNhanvien.Location = new System.Drawing.Point(484, 11);
            this.btnTimNhanvien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimNhanvien.Name = "btnTimNhanvien";
            this.btnTimNhanvien.Size = new System.Drawing.Size(144, 61);
            this.btnTimNhanvien.TabIndex = 25;
            this.btnTimNhanvien.Text = "Tìm kiếm";
            this.btnTimNhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimNhanvien.UseVisualStyleBackColor = false;
            this.btnTimNhanvien.Click += new System.EventHandler(this.btnTimNhanvien_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.dgvNhanvien);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox7.Location = new System.Drawing.Point(53, 414);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Size = new System.Drawing.Size(1172, 171);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Danh sách nhân viên";
            // 
            // dgvNhanvien
            // 
            this.dgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanvien.GridColor = System.Drawing.SystemColors.Desktop;
            this.dgvNhanvien.Location = new System.Drawing.Point(15, 22);
            this.dgvNhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.RowHeadersWidth = 62;
            this.dgvNhanvien.RowTemplate.Height = 28;
            this.dgvNhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanvien.Size = new System.Drawing.Size(1151, 143);
            this.dgvNhanvien.TabIndex = 0;
            this.dgvNhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanvien_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.rbtnBaoVe);
            this.groupBox3.Controls.Add(this.rbtnDonPhong);
            this.groupBox3.Controls.Add(this.rbtnPhucvu);
            this.groupBox3.Controls.Add(this.rbtnThungan);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(541, 343);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(527, 63);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại nhân viên";
            // 
            // rbtnBaoVe
            // 
            this.rbtnBaoVe.AutoSize = true;
            this.rbtnBaoVe.BackColor = System.Drawing.Color.Transparent;
            this.rbtnBaoVe.Location = new System.Drawing.Point(389, 27);
            this.rbtnBaoVe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnBaoVe.Name = "rbtnBaoVe";
            this.rbtnBaoVe.Size = new System.Drawing.Size(73, 21);
            this.rbtnBaoVe.TabIndex = 3;
            this.rbtnBaoVe.TabStop = true;
            this.rbtnBaoVe.Text = "Bảo vệ";
            this.rbtnBaoVe.UseVisualStyleBackColor = false;
            // 
            // rbtnDonPhong
            // 
            this.rbtnDonPhong.AutoSize = true;
            this.rbtnDonPhong.BackColor = System.Drawing.Color.Transparent;
            this.rbtnDonPhong.Location = new System.Drawing.Point(250, 27);
            this.rbtnDonPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnDonPhong.Name = "rbtnDonPhong";
            this.rbtnDonPhong.Size = new System.Drawing.Size(99, 21);
            this.rbtnDonPhong.TabIndex = 2;
            this.rbtnDonPhong.TabStop = true;
            this.rbtnDonPhong.Text = "Dọn phòng";
            this.rbtnDonPhong.UseVisualStyleBackColor = false;
            // 
            // rbtnPhucvu
            // 
            this.rbtnPhucvu.AutoSize = true;
            this.rbtnPhucvu.BackColor = System.Drawing.Color.Transparent;
            this.rbtnPhucvu.Location = new System.Drawing.Point(36, 27);
            this.rbtnPhucvu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnPhucvu.Name = "rbtnPhucvu";
            this.rbtnPhucvu.Size = new System.Drawing.Size(80, 21);
            this.rbtnPhucvu.TabIndex = 1;
            this.rbtnPhucvu.TabStop = true;
            this.rbtnPhucvu.Text = "Phục vụ";
            this.rbtnPhucvu.UseVisualStyleBackColor = false;
            // 
            // rbtnThungan
            // 
            this.rbtnThungan.AutoSize = true;
            this.rbtnThungan.BackColor = System.Drawing.Color.Transparent;
            this.rbtnThungan.Location = new System.Drawing.Point(131, 27);
            this.rbtnThungan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnThungan.Name = "rbtnThungan";
            this.rbtnThungan.Size = new System.Drawing.Size(90, 21);
            this.rbtnThungan.TabIndex = 0;
            this.rbtnThungan.TabStop = true;
            this.rbtnThungan.Text = "Thu ngân";
            this.rbtnThungan.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rbtnNunv);
            this.groupBox2.Controls.Add(this.rbtnNamnv);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(98, 339);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(348, 63);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giới tính";
            // 
            // rbtnNunv
            // 
            this.rbtnNunv.AutoSize = true;
            this.rbtnNunv.BackColor = System.Drawing.Color.Transparent;
            this.rbtnNunv.Location = new System.Drawing.Point(229, 27);
            this.rbtnNunv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnNunv.Name = "rbtnNunv";
            this.rbtnNunv.Size = new System.Drawing.Size(47, 21);
            this.rbtnNunv.TabIndex = 1;
            this.rbtnNunv.TabStop = true;
            this.rbtnNunv.Text = "Nữ";
            this.rbtnNunv.UseVisualStyleBackColor = false;
            // 
            // rbtnNamnv
            // 
            this.rbtnNamnv.AutoSize = true;
            this.rbtnNamnv.BackColor = System.Drawing.Color.Transparent;
            this.rbtnNamnv.Location = new System.Drawing.Point(40, 27);
            this.rbtnNamnv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnNamnv.Name = "rbtnNamnv";
            this.rbtnNamnv.Size = new System.Drawing.Size(58, 21);
            this.rbtnNamnv.TabIndex = 0;
            this.rbtnNamnv.TabStop = true;
            this.rbtnNamnv.Text = "Nam";
            this.rbtnNamnv.UseVisualStyleBackColor = false;
            // 
            // fNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 641);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fNhanVien";
            this.Text = "fNV";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhanvien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCmndnv;
        private System.Windows.Forms.Label CMND;
        private System.Windows.Forms.DateTimePicker dateTimeNgaysinhnv;
        private System.Windows.Forms.Button btnTimNhanvien;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtnPhucvu;
        private System.Windows.Forms.RadioButton rbtnThungan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnNunv;
        private System.Windows.Forms.RadioButton rbtnNamnv;
        private System.Windows.Forms.TextBox txtEmailnv;
        private System.Windows.Forms.TextBox txtDiachinv;
        private System.Windows.Forms.TextBox txtHotennv;
        private System.Windows.Forms.TextBox txtDienthoainv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnBaoVe;
        private System.Windows.Forms.RadioButton rbtnDonPhong;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_ClearNV;
        private System.Windows.Forms.ToolStripButton btn_ThemNV;
        private System.Windows.Forms.ToolStripButton btn_SuaNV;
        private System.Windows.Forms.ToolStripButton btn_XoaNV;
    }
}