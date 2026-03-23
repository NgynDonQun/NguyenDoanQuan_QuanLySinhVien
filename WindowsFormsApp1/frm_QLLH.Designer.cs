namespace WindowsFormsApp1
{
    partial class frm_QLLH
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
            this.pnl_Nav = new System.Windows.Forms.Panel();
            this.lbl_Nav_DX = new System.Windows.Forms.Label();
            this.lbl_Nav_QLLH = new System.Windows.Forms.Label();
            this.lbl_Nav_QLSV = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txb_maID = new System.Windows.Forms.TextBox();
            this.lbl_maID = new System.Windows.Forms.Label();
            this.txb_siSo = new System.Windows.Forms.TextBox();
            this.lbl_siSo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_XemDSSV = new System.Windows.Forms.Button();
            this.txb_tenLop = new System.Windows.Forms.TextBox();
            this.txb_maLophoc = new System.Windows.Forms.TextBox();
            this.lbl_tenLop = new System.Windows.Forms.Label();
            this.lbl_maLophoc = new System.Windows.Forms.Label();
            this.lbl_thongtinLop = new System.Windows.Forms.Label();
            this.dgv_DSLH = new System.Windows.Forms.DataGridView();
            this.pnl_function = new System.Windows.Forms.Panel();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txb_SearchLH = new System.Windows.Forms.TextBox();
            this.pnl_Nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSLH)).BeginInit();
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
            this.pnl_Nav.Size = new System.Drawing.Size(928, 40);
            this.pnl_Nav.TabIndex = 3;
            // 
            // lbl_Nav_DX
            // 
            this.lbl_Nav_DX.AutoSize = true;
            this.lbl_Nav_DX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Nav_DX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lbl_Nav_QLLH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nav_QLLH.Location = new System.Drawing.Point(150, 10);
            this.lbl_Nav_QLLH.Name = "lbl_Nav_QLLH";
            this.lbl_Nav_QLLH.Size = new System.Drawing.Size(123, 20);
            this.lbl_Nav_QLLH.TabIndex = 1;
            this.lbl_Nav_QLLH.Text = "Quản lý Lớp Học";
            // 
            // lbl_Nav_QLSV
            // 
            this.lbl_Nav_QLSV.AutoSize = true;
            this.lbl_Nav_QLSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Nav_QLSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nav_QLSV.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Nav_QLSV.Location = new System.Drawing.Point(12, 10);
            this.lbl_Nav_QLSV.Name = "lbl_Nav_QLSV";
            this.lbl_Nav_QLSV.Size = new System.Drawing.Size(119, 20);
            this.lbl_Nav_QLSV.TabIndex = 0;
            this.lbl_Nav_QLSV.Text = "Quản lý Sinh Viên";
            this.lbl_Nav_QLSV.Click += new System.EventHandler(this.btn_QLSV_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.txb_maID);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_maID);
            this.splitContainer1.Panel1.Controls.Add(this.txb_siSo);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_siSo);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.btn_XemDSSV);
            this.splitContainer1.Panel1.Controls.Add(this.txb_tenLop);
            this.splitContainer1.Panel1.Controls.Add(this.txb_maLophoc);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_tenLop);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_maLophoc);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_thongtinLop);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_DSLH);
            this.splitContainer1.Panel2.Controls.Add(this.pnl_function);
            this.splitContainer1.Size = new System.Drawing.Size(928, 627);
            this.splitContainer1.SplitterDistance = 307;
            this.splitContainer1.TabIndex = 2;
            // 
            // txb_maID
            // 
            this.txb_maID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_maID.Location = new System.Drawing.Point(9, 80);
            this.txb_maID.Name = "txb_maID";
            this.txb_maID.ReadOnly = true;
            this.txb_maID.Size = new System.Drawing.Size(283, 26);
            this.txb_maID.TabIndex = 22;
            // 
            // lbl_maID
            // 
            this.lbl_maID.AutoSize = true;
            this.lbl_maID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maID.ForeColor = System.Drawing.Color.Gray;
            this.lbl_maID.Location = new System.Drawing.Point(7, 55);
            this.lbl_maID.Name = "lbl_maID";
            this.lbl_maID.Size = new System.Drawing.Size(51, 20);
            this.lbl_maID.TabIndex = 21;
            this.lbl_maID.Text = "Mã ID:";
            // 
            // txb_siSo
            // 
            this.txb_siSo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_siSo.Location = new System.Drawing.Point(9, 260);
            this.txb_siSo.Name = "txb_siSo";
            this.txb_siSo.Size = new System.Drawing.Size(283, 26);
            this.txb_siSo.TabIndex = 20;
            // 
            // lbl_siSo
            // 
            this.lbl_siSo.AutoSize = true;
            this.lbl_siSo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_siSo.ForeColor = System.Drawing.Color.Gray;
            this.lbl_siSo.Location = new System.Drawing.Point(7, 235);
            this.lbl_siSo.Name = "lbl_siSo";
            this.lbl_siSo.Size = new System.Drawing.Size(110, 20);
            this.lbl_siSo.TabIndex = 19;
            this.lbl_siSo.Text = "Ghi chú (Sĩ số):";
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
            this.btn_Xoa.Text = "Xóa";
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
            // btn_XemDSSV
            // 
            this.btn_XemDSSV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_XemDSSV.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_XemDSSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XemDSSV.ForeColor = System.Drawing.Color.White;
            this.btn_XemDSSV.Location = new System.Drawing.Point(9, 550);
            this.btn_XemDSSV.Name = "btn_XemDSSV";
            this.btn_XemDSSV.Size = new System.Drawing.Size(282, 50);
            this.btn_XemDSSV.TabIndex = 16;
            this.btn_XemDSSV.Text = "Xem danh sách sinh viên";
            this.btn_XemDSSV.UseVisualStyleBackColor = false;
            // 
            // txb_tenLop
            // 
            this.txb_tenLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_tenLop.Location = new System.Drawing.Point(9, 200);
            this.txb_tenLop.Name = "txb_tenLop";
            this.txb_tenLop.Size = new System.Drawing.Size(283, 26);
            this.txb_tenLop.TabIndex = 10;
            // 
            // txb_maLophoc
            // 
            this.txb_maLophoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_maLophoc.Location = new System.Drawing.Point(9, 140);
            this.txb_maLophoc.Name = "txb_maLophoc";
            this.txb_maLophoc.Size = new System.Drawing.Size(283, 26);
            this.txb_maLophoc.TabIndex = 12;
            // 
            // lbl_tenLop
            // 
            this.lbl_tenLop.AutoSize = true;
            this.lbl_tenLop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenLop.ForeColor = System.Drawing.Color.Gray;
            this.lbl_tenLop.Location = new System.Drawing.Point(7, 175);
            this.lbl_tenLop.Name = "lbl_tenLop";
            this.lbl_tenLop.Size = new System.Drawing.Size(63, 20);
            this.lbl_tenLop.TabIndex = 7;
            this.lbl_tenLop.Text = "Tên lớp:";
            // 
            // lbl_maLophoc
            // 
            this.lbl_maLophoc.AutoSize = true;
            this.lbl_maLophoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maLophoc.ForeColor = System.Drawing.Color.Gray;
            this.lbl_maLophoc.Location = new System.Drawing.Point(7, 115);
            this.lbl_maLophoc.Name = "lbl_maLophoc";
            this.lbl_maLophoc.Size = new System.Drawing.Size(59, 20);
            this.lbl_maLophoc.TabIndex = 8;
            this.lbl_maLophoc.Text = "Mã lớp:";
            // 
            // lbl_thongtinLop
            // 
            this.lbl_thongtinLop.AutoSize = true;
            this.lbl_thongtinLop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thongtinLop.Location = new System.Drawing.Point(5, 15);
            this.lbl_thongtinLop.Name = "lbl_thongtinLop";
            this.lbl_thongtinLop.Size = new System.Drawing.Size(152, 23);
            this.lbl_thongtinLop.TabIndex = 9;
            this.lbl_thongtinLop.Text = "Thông tin lớp học";
            // 
            // dgv_DSLH
            // 
            this.dgv_DSLH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSLH.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DSLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSLH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DSLH.Location = new System.Drawing.Point(0, 52);
            this.dgv_DSLH.Name = "dgv_DSLH";
            this.dgv_DSLH.RowHeadersWidth = 62;
            this.dgv_DSLH.RowTemplate.Height = 28;
            this.dgv_DSLH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSLH.Size = new System.Drawing.Size(617, 575);
            this.dgv_DSLH.TabIndex = 1;
            this.dgv_DSLH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSLH_CellClick);
            // 
            // pnl_function
            // 
            this.pnl_function.BackColor = System.Drawing.Color.Snow;
            this.pnl_function.Controls.Add(this.btn_TimKiem);
            this.pnl_function.Controls.Add(this.txb_SearchLH);
            this.pnl_function.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_function.Location = new System.Drawing.Point(0, 0);
            this.pnl_function.Name = "pnl_function";
            this.pnl_function.Size = new System.Drawing.Size(617, 52);
            this.pnl_function.TabIndex = 0;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem.Location = new System.Drawing.Point(368, 11);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 28);
            this.btn_TimKiem.TabIndex = 1;
            this.btn_TimKiem.Text = "Tìm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.ptb_Search_Click);
            // 
            // txb_SearchLH
            // 
            this.txb_SearchLH.Location = new System.Drawing.Point(17, 12);
            this.txb_SearchLH.Margin = new System.Windows.Forms.Padding(0);
            this.txb_SearchLH.Name = "txb_SearchLH";
            this.txb_SearchLH.Size = new System.Drawing.Size(341, 26);
            this.txb_SearchLH.TabIndex = 0;
            // 
            // frm_QLLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 667);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnl_Nav);
            this.Name = "frm_QLLH";
            this.Text = "Quản lý Lớp Học";
            this.Load += new System.EventHandler(this.frm_QLLH_Load);
            this.pnl_Nav.ResumeLayout(false);
            this.pnl_Nav.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSLH)).EndInit();
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
        private System.Windows.Forms.TextBox txb_tenLop;
        private System.Windows.Forms.TextBox txb_maLophoc;
        private System.Windows.Forms.Label lbl_tenLop;
        private System.Windows.Forms.Label lbl_maLophoc;
        private System.Windows.Forms.Label lbl_thongtinLop;
        private System.Windows.Forms.DataGridView dgv_DSLH;
        private System.Windows.Forms.Panel pnl_function;
        private System.Windows.Forms.TextBox txb_SearchLH;
        private System.Windows.Forms.TextBox txb_siSo;
        private System.Windows.Forms.Label lbl_siSo;
        private System.Windows.Forms.TextBox txb_maID;
        private System.Windows.Forms.Label lbl_maID;
        private System.Windows.Forms.Button btn_XemDSSV;
        private System.Windows.Forms.Button btn_TimKiem;
    }
}