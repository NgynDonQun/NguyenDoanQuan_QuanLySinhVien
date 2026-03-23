namespace WindowsFormsApp1
{
    partial class frm_QLSV
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnl_Nav = new System.Windows.Forms.Panel();
            this.lbl_Nav_DX = new System.Windows.Forms.Label();
            this.lbl_Nav_QLLH = new System.Windows.Forms.Label();
            this.lbl_Nav_QLSV = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.cmb_Lop = new System.Windows.Forms.ComboBox();
            this.cmb_gioitinh = new System.Windows.Forms.ComboBox();
            this.dt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txb_hoten = new System.Windows.Forms.TextBox();
            this.txb_masv = new System.Windows.Forms.TextBox();
            this.lbl_lop = new System.Windows.Forms.Label();
            this.lbl_gioitinh = new System.Windows.Forms.Label();
            this.lbl_ngaysinh = new System.Windows.Forms.Label();
            this.lbl_hoten = new System.Windows.Forms.Label();
            this.lbl_masv = new System.Windows.Forms.Label();
            this.lbl_thongtinsv = new System.Windows.Forms.Label();
            this.dgv_DSSV = new System.Windows.Forms.DataGridView();
            this.pnl_function = new System.Windows.Forms.Panel();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txb_SearchSV = new System.Windows.Forms.TextBox();
            this.lbl_LocLop = new System.Windows.Forms.Label();
            this.cmb_LocLop = new System.Windows.Forms.ComboBox();
            this.pnl_Nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSV)).BeginInit();
            this.pnl_function.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Nav
            // 
            this.pnl_Nav.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_Nav.Controls.Add(this.lbl_Nav_DX);
            this.pnl_Nav.Controls.Add(this.lbl_Nav_QLLH);
            this.pnl_Nav.Controls.Add(this.lbl_Nav_QLSV);
            this.pnl_Nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Nav.Location = new System.Drawing.Point(0, 0);
            this.pnl_Nav.Name = "pnl_Nav";
            this.pnl_Nav.Size = new System.Drawing.Size(950, 40);
            this.pnl_Nav.TabIndex = 3;
            // 
            // lbl_Nav_DX
            // 
            this.lbl_Nav_DX.AutoSize = true;
            this.lbl_Nav_DX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Nav_DX.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_Nav_DX.ForeColor = System.Drawing.Color.LightCoral;
            this.lbl_Nav_DX.Location = new System.Drawing.Point(300, 10);
            this.lbl_Nav_DX.Name = "lbl_Nav_DX";
            this.lbl_Nav_DX.Size = new System.Drawing.Size(77, 20);
            this.lbl_Nav_DX.TabIndex = 2;
            this.lbl_Nav_DX.Text = "Đăng xuất";
            this.lbl_Nav_DX.Click += new System.EventHandler(this.lbl_Nav_DX_Click);
            // 
            // lbl_Nav_QLLH
            // 
            this.lbl_Nav_QLLH.AutoSize = true;
            this.lbl_Nav_QLLH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Nav_QLLH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_Nav_QLLH.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Nav_QLLH.Location = new System.Drawing.Point(160, 10);
            this.lbl_Nav_QLLH.Name = "lbl_Nav_QLLH";
            this.lbl_Nav_QLLH.Size = new System.Drawing.Size(120, 20);
            this.lbl_Nav_QLLH.TabIndex = 1;
            this.lbl_Nav_QLLH.Text = "Quản lý Lớp Học";
            this.lbl_Nav_QLLH.Click += new System.EventHandler(this.lbl_Nav_QLLH_Click);
            // 
            // lbl_Nav_QLSV
            // 
            this.lbl_Nav_QLSV.AutoSize = true;
            this.lbl_Nav_QLSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Nav_QLSV.Location = new System.Drawing.Point(12, 10);
            this.lbl_Nav_QLSV.Name = "lbl_Nav_QLSV";
            this.lbl_Nav_QLSV.Size = new System.Drawing.Size(133, 20);
            this.lbl_Nav_QLSV.TabIndex = 0;
            this.lbl_Nav_QLSV.Text = "Quản lý Sinh Viên";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 40);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Snow;
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_Lop);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_gioitinh);
            this.splitContainer1.Panel1.Controls.Add(this.dt_ngaysinh);
            this.splitContainer1.Panel1.Controls.Add(this.txb_hoten);
            this.splitContainer1.Panel1.Controls.Add(this.txb_masv);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_lop);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_gioitinh);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_ngaysinh);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_hoten);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_masv);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_thongtinsv);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_DSSV);
            this.splitContainer1.Panel2.Controls.Add(this.pnl_function);
            this.splitContainer1.Size = new System.Drawing.Size(950, 608);
            this.splitContainer1.SplitterDistance = 307;
            this.splitContainer1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_them, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Sua, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Xoa, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_LamMoi, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 440);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(282, 100);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_them.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(3, 3);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(135, 44);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Sua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(144, 3);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(135, 44);
            this.btn_Sua.TabIndex = 2;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Xoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(3, 53);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(135, 44);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.BackColor = System.Drawing.Color.LightGray;
            this.btn_LamMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_LamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LamMoi.Location = new System.Drawing.Point(144, 53);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(135, 44);
            this.btn_LamMoi.TabIndex = 15;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.UseVisualStyleBackColor = false;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // cmb_Lop
            // 
            this.cmb_Lop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Lop.FormattingEnabled = true;
            this.cmb_Lop.Location = new System.Drawing.Point(9, 340);
            this.cmb_Lop.Name = "cmb_Lop";
            this.cmb_Lop.Size = new System.Drawing.Size(282, 28);
            this.cmb_Lop.TabIndex = 17;
            // 
            // cmb_gioitinh
            // 
            this.cmb_gioitinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_gioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_gioitinh.FormattingEnabled = true;
            this.cmb_gioitinh.Location = new System.Drawing.Point(9, 275);
            this.cmb_gioitinh.Name = "cmb_gioitinh";
            this.cmb_gioitinh.Size = new System.Drawing.Size(282, 28);
            this.cmb_gioitinh.TabIndex = 14;
            // 
            // dt_ngaysinh
            // 
            this.dt_ngaysinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngaysinh.Location = new System.Drawing.Point(9, 210);
            this.dt_ngaysinh.Name = "dt_ngaysinh";
            this.dt_ngaysinh.Size = new System.Drawing.Size(283, 26);
            this.dt_ngaysinh.TabIndex = 13;
            this.dt_ngaysinh.ValueChanged += new System.EventHandler(this.dt_ngaysinh_ValueChanged);
            // 
            // txb_hoten
            // 
            this.txb_hoten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_hoten.Location = new System.Drawing.Point(9, 145);
            this.txb_hoten.Name = "txb_hoten";
            this.txb_hoten.Size = new System.Drawing.Size(283, 26);
            this.txb_hoten.TabIndex = 10;
            // 
            // txb_masv
            // 
            this.txb_masv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_masv.Location = new System.Drawing.Point(9, 80);
            this.txb_masv.Name = "txb_masv";
            this.txb_masv.Size = new System.Drawing.Size(283, 26);
            this.txb_masv.TabIndex = 12;
            // 
            // lbl_lop
            // 
            this.lbl_lop.AutoSize = true;
            this.lbl_lop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_lop.ForeColor = System.Drawing.Color.Gray;
            this.lbl_lop.Location = new System.Drawing.Point(7, 315);
            this.lbl_lop.Name = "lbl_lop";
            this.lbl_lop.Size = new System.Drawing.Size(37, 20);
            this.lbl_lop.TabIndex = 4;
            this.lbl_lop.Text = "Lớp:";
            // 
            // lbl_gioitinh
            // 
            this.lbl_gioitinh.AutoSize = true;
            this.lbl_gioitinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_gioitinh.ForeColor = System.Drawing.Color.Gray;
            this.lbl_gioitinh.Location = new System.Drawing.Point(7, 250);
            this.lbl_gioitinh.Name = "lbl_gioitinh";
            this.lbl_gioitinh.Size = new System.Drawing.Size(68, 20);
            this.lbl_gioitinh.TabIndex = 5;
            this.lbl_gioitinh.Text = "Giới tính:";
            // 
            // lbl_ngaysinh
            // 
            this.lbl_ngaysinh.AutoSize = true;
            this.lbl_ngaysinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_ngaysinh.ForeColor = System.Drawing.Color.Gray;
            this.lbl_ngaysinh.Location = new System.Drawing.Point(7, 185);
            this.lbl_ngaysinh.Name = "lbl_ngaysinh";
            this.lbl_ngaysinh.Size = new System.Drawing.Size(77, 20);
            this.lbl_ngaysinh.TabIndex = 6;
            this.lbl_ngaysinh.Text = "Ngày sinh:";
            // 
            // lbl_hoten
            // 
            this.lbl_hoten.AutoSize = true;
            this.lbl_hoten.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_hoten.ForeColor = System.Drawing.Color.Gray;
            this.lbl_hoten.Location = new System.Drawing.Point(7, 120);
            this.lbl_hoten.Name = "lbl_hoten";
            this.lbl_hoten.Size = new System.Drawing.Size(76, 20);
            this.lbl_hoten.TabIndex = 7;
            this.lbl_hoten.Text = "Họ và tên:";
            // 
            // lbl_masv
            // 
            this.lbl_masv.AutoSize = true;
            this.lbl_masv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_masv.ForeColor = System.Drawing.Color.Gray;
            this.lbl_masv.Location = new System.Drawing.Point(7, 55);
            this.lbl_masv.Name = "lbl_masv";
            this.lbl_masv.Size = new System.Drawing.Size(94, 20);
            this.lbl_masv.TabIndex = 8;
            this.lbl_masv.Text = "Mã sinh viên:";
            // 
            // lbl_thongtinsv
            // 
            this.lbl_thongtinsv.AutoSize = true;
            this.lbl_thongtinsv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_thongtinsv.Location = new System.Drawing.Point(5, 15);
            this.lbl_thongtinsv.Name = "lbl_thongtinsv";
            this.lbl_thongtinsv.Size = new System.Drawing.Size(163, 23);
            this.lbl_thongtinsv.TabIndex = 9;
            this.lbl_thongtinsv.Text = "Thông tin sinh viên";
            // 
            // dgv_DSSV
            // 
            this.dgv_DSSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSSV.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DSSV.Location = new System.Drawing.Point(0, 52);
            this.dgv_DSSV.Name = "dgv_DSSV";
            this.dgv_DSSV.RowHeadersWidth = 62;
            this.dgv_DSSV.RowTemplate.Height = 28;
            this.dgv_DSSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSSV.Size = new System.Drawing.Size(639, 556);
            this.dgv_DSSV.TabIndex = 1;
            this.dgv_DSSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSSV_CellClick);
            // 
            // pnl_function
            // 
            this.pnl_function.BackColor = System.Drawing.Color.Snow;
            this.pnl_function.Controls.Add(this.cmb_LocLop);
            this.pnl_function.Controls.Add(this.lbl_LocLop);
            this.pnl_function.Controls.Add(this.btn_TimKiem);
            this.pnl_function.Controls.Add(this.txb_SearchSV);
            this.pnl_function.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_function.Location = new System.Drawing.Point(0, 0);
            this.pnl_function.Name = "pnl_function";
            this.pnl_function.Size = new System.Drawing.Size(639, 52);
            this.pnl_function.TabIndex = 0;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem.Location = new System.Drawing.Point(230, 11);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(65, 28);
            this.btn_TimKiem.TabIndex = 1;
            this.btn_TimKiem.Text = "Tìm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txb_SearchSV
            // 
            this.txb_SearchSV.Location = new System.Drawing.Point(17, 12);
            this.txb_SearchSV.Margin = new System.Windows.Forms.Padding(0);
            this.txb_SearchSV.Name = "txb_SearchSV";
            this.txb_SearchSV.Size = new System.Drawing.Size(200, 26);
            this.txb_SearchSV.TabIndex = 0;
            // 
            // lbl_LocLop
            // 
            this.lbl_LocLop.AutoSize = true;
            this.lbl_LocLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_LocLop.ForeColor = System.Drawing.Color.Gray;
            this.lbl_LocLop.Location = new System.Drawing.Point(320, 15);
            this.lbl_LocLop.Name = "lbl_LocLop";
            this.lbl_LocLop.Size = new System.Drawing.Size(95, 20);
            this.lbl_LocLop.TabIndex = 2;
            this.lbl_LocLop.Text = "Lọc theo lớp:";
            // 
            // cmb_LocLop
            // 
            this.cmb_LocLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_LocLop.FormattingEnabled = true;
            this.cmb_LocLop.Location = new System.Drawing.Point(420, 12);
            this.cmb_LocLop.Name = "cmb_LocLop";
            this.cmb_LocLop.Size = new System.Drawing.Size(190, 28);
            this.cmb_LocLop.TabIndex = 3;
            this.cmb_LocLop.SelectedIndexChanged += new System.EventHandler(this.cmb_LocLop_SelectedIndexChanged);
            // 
            // frm_QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 648);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnl_Nav);
            this.Name = "frm_QLSV";
            this.Text = "Quản lý Sinh Viên";
            this.Load += new System.EventHandler(this.frm_QLSV_Load);
            this.pnl_Nav.ResumeLayout(false);
            this.pnl_Nav.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSV)).EndInit();
            this.pnl_function.ResumeLayout(false);
            this.pnl_function.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Nav;
        private System.Windows.Forms.Label lbl_Nav_QLSV;
        private System.Windows.Forms.Label lbl_Nav_QLLH;
        private System.Windows.Forms.Label lbl_Nav_DX;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.ComboBox cmb_Lop;
        private System.Windows.Forms.ComboBox cmb_gioitinh;
        private System.Windows.Forms.DateTimePicker dt_ngaysinh;
        private System.Windows.Forms.TextBox txb_hoten;
        private System.Windows.Forms.TextBox txb_masv;
        private System.Windows.Forms.Label lbl_lop;
        private System.Windows.Forms.Label lbl_gioitinh;
        private System.Windows.Forms.Label lbl_ngaysinh;
        private System.Windows.Forms.Label lbl_hoten;
        private System.Windows.Forms.Label lbl_masv;
        private System.Windows.Forms.Label lbl_thongtinsv;
        private System.Windows.Forms.DataGridView dgv_DSSV;
        private System.Windows.Forms.Panel pnl_function;
        private System.Windows.Forms.TextBox txb_SearchSV;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Label lbl_LocLop;
        private System.Windows.Forms.ComboBox cmb_LocLop;
    }
}