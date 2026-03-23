using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_QLSV : Form
    {
        DataBaseDataContext db = new DataBaseDataContext();
        private string maLopCanXem = "";

        // Hàm khởi tạo mặc định (dùng khi mở từ thanh điều hướng)
        public frm_QLSV()
        {
            InitializeComponent();
        }

        // Hàm khởi tạo nhận mã lớp (dùng khi mở từ nút Xem DSSV bên form Lớp)
        public frm_QLSV(string maLop) : this()
        {
            maLopCanXem = maLop;
        }

        private void frm_QLSV_Load(object sender, EventArgs e)
        {
            cmb_gioitinh.Items.Clear();
            cmb_gioitinh.Items.Add("Nam");
            cmb_gioitinh.Items.Add("Nữ");

            LoadComboBoxLop();
            LoadComboBoxLocLop();
            LoadData();
            btn_LamMoi_Click(sender, e);

            // Tự động lọc nếu có mã lớp truyền sang
            if (!string.IsNullOrEmpty(maLopCanXem))
            {
                cmb_LocLop.SelectedValue = maLopCanXem;
            }
        }

        private void dt_ngaysinh_ValueChanged(object sender, EventArgs e)
        {
            dt_ngaysinh.CustomFormat = "dd/MM/yyyy";
        }

        private void LoadComboBoxLop()
        {
            var listLop = db.LopHocs.ToList();
            cmb_Lop.DataSource = listLop;
            cmb_Lop.DisplayMember = "TenLop";
            cmb_Lop.ValueMember = "MaLop";
        }

        private void LoadComboBoxLocLop()
        {
            var listLopLoc = db.LopHocs.ToList();
            listLopLoc.Insert(0, new LopHoc { MaLop = "ALL", TenLop = "--- Tất cả các lớp ---" });

            cmb_LocLop.DataSource = listLopLoc;
            cmb_LocLop.DisplayMember = "TenLop";
            cmb_LocLop.ValueMember = "MaLop";
        }

        private void LoadData()
        {
            var query = from sv in db.SinhViens
                        join lh in db.LopHocs on sv.MaLop equals lh.MaLop
                        select new
                        {
                            sv.MaSV,
                            TenSV = sv.HoTen,
                            sv.GioiTinh,
                            sv.NgaySinh,
                            Lop = lh.TenLop,
                            sv.MaLop
                        };

            dgv_DSSV.DataSource = query.ToList();

            if (dgv_DSSV.Columns.Count > 0)
            {
                dgv_DSSV.Columns["MaSV"].HeaderText = "Mã SV";
                dgv_DSSV.Columns["TenSV"].HeaderText = "Họ tên";
                dgv_DSSV.Columns["GioiTinh"].HeaderText = "Giới tính";
                dgv_DSSV.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dgv_DSSV.Columns["Lop"].HeaderText = "Lớp";
                dgv_DSSV.Columns["MaLop"].Visible = false;
            }
        }

        private void cmb_LocLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_LocLop.SelectedValue == null) return;

            string maLop = cmb_LocLop.SelectedValue.ToString();

            var query = from sv in db.SinhViens
                        join lh in db.LopHocs on sv.MaLop equals lh.MaLop
                        select new
                        {
                            sv.MaSV,
                            TenSV = sv.HoTen,
                            sv.GioiTinh,
                            sv.NgaySinh,
                            Lop = lh.TenLop,
                            sv.MaLop
                        };

            if (maLop != "ALL")
            {
                query = query.Where(x => x.MaLop == maLop);
            }

            dgv_DSSV.DataSource = query.ToList();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txb_masv.Clear();
            txb_hoten.Clear();
            txb_SearchSV.Clear();
            cmb_gioitinh.SelectedIndex = -1;
            cmb_Lop.SelectedIndex = -1;
            cmb_LocLop.SelectedIndex = 0;

            dt_ngaysinh.Format = DateTimePickerFormat.Custom;
            dt_ngaysinh.CustomFormat = " ";

            txb_masv.Enabled = true;
            txb_masv.Focus();

            LoadData();
        }

        private void dgv_DSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DSSV.Rows[e.RowIndex];

                txb_masv.Text = row.Cells["MaSV"].Value?.ToString();
                txb_hoten.Text = row.Cells["TenSV"].Value?.ToString();
                cmb_gioitinh.Text = row.Cells["GioiTinh"].Value?.ToString();

                if (row.Cells["NgaySinh"].Value != null)
                {
                    dt_ngaysinh.Format = DateTimePickerFormat.Custom;
                    dt_ngaysinh.CustomFormat = "dd/MM/yyyy";
                    dt_ngaysinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                }

                cmb_Lop.SelectedValue = row.Cells["MaLop"].Value?.ToString();
                txb_masv.Enabled = false;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_masv.Text) || cmb_Lop.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng điền đủ Mã SV và chọn Lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SinhVien svNew = new SinhVien();
                svNew.MaSV = txb_masv.Text;
                svNew.HoTen = txb_hoten.Text;
                svNew.GioiTinh = cmb_gioitinh.Text;
                svNew.MaLop = cmb_Lop.SelectedValue.ToString();

                if (dt_ngaysinh.CustomFormat != " ")
                    svNew.NgaySinh = dt_ngaysinh.Value.Date;

                db.SinhViens.InsertOnSubmit(svNew);
                db.SubmitChanges();

                MessageBox.Show("Thêm thành công!", "Thông báo");
                LoadData();
                btn_LamMoi_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txb_masv.Enabled) return;

            try
            {
                var svEdit = db.SinhViens.SingleOrDefault(s => s.MaSV == txb_masv.Text);

                if (svEdit != null)
                {
                    svEdit.HoTen = txb_hoten.Text;
                    svEdit.GioiTinh = cmb_gioitinh.Text;
                    svEdit.MaLop = cmb_Lop.SelectedValue.ToString();

                    if (dt_ngaysinh.CustomFormat != " ")
                        svEdit.NgaySinh = dt_ngaysinh.Value.Date;

                    db.SubmitChanges();

                    MessageBox.Show("Cập nhật thành công!", "Thông báo");
                    LoadData();
                    btn_LamMoi_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txb_masv.Enabled) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var svDelete = db.SinhViens.SingleOrDefault(s => s.MaSV == txb_masv.Text);

                    if (svDelete != null)
                    {
                        db.SinhViens.DeleteOnSubmit(svDelete);
                        db.SubmitChanges();

                        MessageBox.Show("Đã xóa thành công!", "Thông báo");
                        LoadData();
                        btn_LamMoi_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txb_SearchSV.Text.Trim();

            var query = from sv in db.SinhViens
                        join lh in db.LopHocs on sv.MaLop equals lh.MaLop
                        where sv.HoTen.Contains(keyword) || sv.MaSV.Contains(keyword)
                        select new
                        {
                            sv.MaSV,
                            TenSV = sv.HoTen,
                            sv.GioiTinh,
                            sv.NgaySinh,
                            Lop = lh.TenLop,
                            sv.MaLop
                        };

            dgv_DSSV.DataSource = query.ToList();
        }

        private void lbl_Nav_QLLH_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_QLLH frm = new frm_QLLH();
            frm.ShowDialog();
            this.Close();
        }

        private void lbl_Nav_DX_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}