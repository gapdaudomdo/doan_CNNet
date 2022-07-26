namespace DoAn
{
    partial class fKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fKhachHang));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_SuaKH = new System.Windows.Forms.ToolStripButton();
            this.btnXoaKhachhang = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMatimkiem = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnTimKhachhang = new System.Windows.Forms.Button();
            this.dateTimeNgaysinhkhachhang = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvKhachhang = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbtnNukh = new System.Windows.Forms.RadioButton();
            this.rbtnNamkh = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtHotenkh = new System.Windows.Forms.TextBox();
            this.txtSocmnd = new System.Windows.Forms.TextBox();
            this.txtDiachikhachhang = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMakhkh = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachhang)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox4.Controls.Add(this.toolStrip1);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.dateTimeNgaysinhkhachhang);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtHotenkh);
            this.groupBox4.Controls.Add(this.txtSocmnd);
            this.groupBox4.Controls.Add(this.txtDiachikhachhang);
            this.groupBox4.Controls.Add(this.txtEmail);
            this.groupBox4.Controls.Add(this.txtMakhkh);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(1358, 758);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Quản lý khách hàng";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_SuaKH,
            this.btnXoaKhachhang});
            this.toolStrip1.Location = new System.Drawing.Point(4, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(397, 34);
            this.toolStrip1.TabIndex = 36;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_SuaKH
            // 
            this.btn_SuaKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_SuaKH.Image = global::DoAn.Properties.Resources._4014665_fix_fixing_phone_repair_tool_wrench_112887;
            this.btn_SuaKH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SuaKH.Name = "btn_SuaKH";
            this.btn_SuaKH.Size = new System.Drawing.Size(166, 29);
            this.btn_SuaKH.Text = "Sửa Khách Hàng";
            this.btn_SuaKH.Click += new System.EventHandler(this.btn_SuaKH_Click);
            // 
            // btnXoaKhachhang
            // 
            this.btnXoaKhachhang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoaKhachhang.Image = global::DoAn.Properties.Resources.trash_can_115312;
            this.btnXoaKhachhang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaKhachhang.Name = "btnXoaKhachhang";
            this.btnXoaKhachhang.Size = new System.Drawing.Size(167, 29);
            this.btnXoaKhachhang.Text = "Xóa Khách Hàng";
            this.btnXoaKhachhang.Click += new System.EventHandler(this.btnXoaKhachhang_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtMatimkiem);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.btnTimKhachhang);
            this.groupBox1.Location = new System.Drawing.Point(712, 192);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(464, 172);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm:";
            // 
            // txtMatimkiem
            // 
            this.txtMatimkiem.Location = new System.Drawing.Point(251, 25);
            this.txtMatimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatimkiem.Name = "txtMatimkiem";
            this.txtMatimkiem.Size = new System.Drawing.Size(148, 26);
            this.txtMatimkiem.TabIndex = 32;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label18.Location = new System.Drawing.Point(19, 29);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(194, 20);
            this.label18.TabIndex = 31;
            this.label18.Text = "Tìm kiếm (Mã khách hàng)";
            // 
            // btnTimKhachhang
            // 
            this.btnTimKhachhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTimKhachhang.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKhachhang.Image")));
            this.btnTimKhachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKhachhang.Location = new System.Drawing.Point(251, 86);
            this.btnTimKhachhang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimKhachhang.Name = "btnTimKhachhang";
            this.btnTimKhachhang.Size = new System.Drawing.Size(148, 72);
            this.btnTimKhachhang.TabIndex = 29;
            this.btnTimKhachhang.Text = "       Tìm kiếm";
            this.btnTimKhachhang.UseVisualStyleBackColor = false;
            this.btnTimKhachhang.Click += new System.EventHandler(this.btnTimKhachhang_Click);
            // 
            // dateTimeNgaysinhkhachhang
            // 
            this.dateTimeNgaysinhkhachhang.CustomFormat = "dd/MM/yyyy";
            this.dateTimeNgaysinhkhachhang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgaysinhkhachhang.Location = new System.Drawing.Point(194, 241);
            this.dateTimeNgaysinhkhachhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeNgaysinhkhachhang.Name = "dateTimeNgaysinhkhachhang";
            this.dateTimeNgaysinhkhachhang.Size = new System.Drawing.Size(270, 26);
            this.dateTimeNgaysinhkhachhang.TabIndex = 30;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox5.Controls.Add(this.dgvKhachhang);
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(39, 405);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(1202, 219);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin khách hàng";
            // 
            // dgvKhachhang
            // 
            this.dgvKhachhang.AllowUserToOrderColumns = true;
            this.dgvKhachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachhang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachhang.Location = new System.Drawing.Point(4, 24);
            this.dgvKhachhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKhachhang.Name = "dgvKhachhang";
            this.dgvKhachhang.RowHeadersWidth = 62;
            this.dgvKhachhang.RowTemplate.Height = 28;
            this.dgvKhachhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachhang.Size = new System.Drawing.Size(1194, 190);
            this.dgvKhachhang.TabIndex = 0;
            this.dgvKhachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachhang_CellClick);
            this.dgvKhachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachhang_CellContentClick);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.rbtnNukh);
            this.groupBox6.Controls.Add(this.rbtnNamkh);
            this.groupBox6.Location = new System.Drawing.Point(194, 279);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Size = new System.Drawing.Size(382, 92);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Giới tính";
            // 
            // rbtnNukh
            // 
            this.rbtnNukh.AutoSize = true;
            this.rbtnNukh.Location = new System.Drawing.Point(237, 31);
            this.rbtnNukh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnNukh.Name = "rbtnNukh";
            this.rbtnNukh.Size = new System.Drawing.Size(54, 24);
            this.rbtnNukh.TabIndex = 1;
            this.rbtnNukh.TabStop = true;
            this.rbtnNukh.Text = "Nữ";
            this.rbtnNukh.UseVisualStyleBackColor = true;
            // 
            // rbtnNamkh
            // 
            this.rbtnNamkh.AutoSize = true;
            this.rbtnNamkh.Location = new System.Drawing.Point(50, 31);
            this.rbtnNamkh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnNamkh.Name = "rbtnNamkh";
            this.rbtnNamkh.Size = new System.Drawing.Size(71, 24);
            this.rbtnNamkh.TabIndex = 0;
            this.rbtnNamkh.TabStop = true;
            this.rbtnNamkh.Text = "Nam ";
            this.rbtnNamkh.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(96, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Họ tên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(92, 186);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Số CMND";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(92, 241);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Ngày sinh";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(687, 82);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Địa chỉ";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(687, 135);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Email";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(96, 79);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 22);
            this.label14.TabIndex = 8;
            this.label14.Text = "Mã KH";
            // 
            // txtHotenkh
            // 
            this.txtHotenkh.Location = new System.Drawing.Point(194, 129);
            this.txtHotenkh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHotenkh.Name = "txtHotenkh";
            this.txtHotenkh.Size = new System.Drawing.Size(257, 26);
            this.txtHotenkh.TabIndex = 7;
            // 
            // txtSocmnd
            // 
            this.txtSocmnd.Location = new System.Drawing.Point(194, 186);
            this.txtSocmnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSocmnd.Name = "txtSocmnd";
            this.txtSocmnd.Size = new System.Drawing.Size(257, 26);
            this.txtSocmnd.TabIndex = 6;
            // 
            // txtDiachikhachhang
            // 
            this.txtDiachikhachhang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiachikhachhang.Location = new System.Drawing.Point(784, 79);
            this.txtDiachikhachhang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiachikhachhang.Name = "txtDiachikhachhang";
            this.txtDiachikhachhang.Size = new System.Drawing.Size(275, 26);
            this.txtDiachikhachhang.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(784, 131);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(275, 26);
            this.txtEmail.TabIndex = 2;
            // 
            // txtMakhkh
            // 
            this.txtMakhkh.Location = new System.Drawing.Point(194, 79);
            this.txtMakhkh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMakhkh.Name = "txtMakhkh";
            this.txtMakhkh.ReadOnly = true;
            this.txtMakhkh.Size = new System.Drawing.Size(259, 26);
            this.txtMakhkh.TabIndex = 0;
            // 
            // fKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 758);
            this.Controls.Add(this.groupBox4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fKhachHang";
            this.Text = "fKhachHang";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachhang)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMatimkiem;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dateTimeNgaysinhkhachhang;
        private System.Windows.Forms.Button btnTimKhachhang;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvKhachhang;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbtnNukh;
        private System.Windows.Forms.RadioButton rbtnNamkh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtHotenkh;
        private System.Windows.Forms.TextBox txtSocmnd;
        private System.Windows.Forms.TextBox txtDiachikhachhang;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMakhkh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_SuaKH;
        private System.Windows.Forms.ToolStripButton btnXoaKhachhang;
    }
}