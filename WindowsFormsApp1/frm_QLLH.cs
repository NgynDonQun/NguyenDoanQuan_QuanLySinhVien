using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_QLLH : Form
    {
        DataBaseDataContext db = new DataBaseDataContext();

        public frm_QLLH()
        {
            InitializeComponent();
            // Tự động gắn sự kiện click cho nút Xem DSSV để không cần đụng file Designer
            this.btn_XemDSSV.Click += new System.EventHandler(this.btn_XemDSSV_Click);
        }

        private void frm_QLLH_Load(object sender, EventArgs e)
        {
            loadData();
            btn_LamMoi_Click(sender, e);
        }

        private void loadData()
        {
            var lopHoc = from c in db.LopHocs
                         select new
                         {
                             c.MaLop,
                             c.TenLop,
                             c.SiSo,
                         };
            dgv_DSLH.DataSource = lopHoc.ToList();

            if (dgv_DSLH.Columns.Count > 0)
            {
                dgv_DSLH.Columns["MaLop"].HeaderText = "Mã lớp";
                dgv_DSLH.Columns["TenLop"].HeaderText = "Tên lớp";
                dgv_DSLH.Columns["SiSo"].HeaderText = "Ghi chú";
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txb_maID.Clear();
            txb_maLophoc.Clear();
            txb_tenLop.Clear();
            txb_siSo.Clear();
            txb_SearchLH.Clear();

            txb_maLophoc.Enabled = true;
            txb_maLophoc.Focus();
            loadData();
        }

        private void dgv_DSLH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DSLH.Rows[e.RowIndex];

                txb_maID.Text = (e.RowIndex + 1).ToString();
                txb_maLophoc.Text = row.Cells["MaLop"].Value?.ToString();
                txb_tenLop.Text = row.Cells["TenLop"].Value?.ToString();
                txb_siSo.Text = row.Cells["SiSo"].Value?.ToString();

                txb_maLophoc.Enabled = false;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_maLophoc.Text) || string.IsNullOrWhiteSpace(txb_tenLop.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin lớp học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                LopHoc newLop = new LopHoc();
                newLop.MaLop = txb_maLophoc.Text;
                newLop.TenLop = txb_tenLop.Text;

                if (int.TryParse(txb_siSo.Text, out int siSo))
                {
                    newLop.SiSo = siSo;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập SỐ vào ô Ghi chú (do CSDL đang lưu dưới dạng Sĩ số).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                db.LopHocs.InsertOnSubmit(newLop);
                db.SubmitChanges();
                MessageBox.Show("Thêm lớp học thành công!", "Thông báo");

                loadData();
                btn_LamMoi_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txb_maLophoc.Enabled) return;

            try
            {
                var EditLop = db.LopHocs.SingleOrDefault(l => l.MaLop == txb_maLophoc.Text);

                if (EditLop != null)
                {
                    EditLop.TenLop = txb_tenLop.Text;
                    if (int.TryParse(txb_siSo.Text, out int siSo))
                    {
                        EditLop.SiSo = siSo;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập SỐ vào ô Ghi chú.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    db.SubmitChanges();
                    MessageBox.Show("Sửa lớp học thành công!", "Thông báo");

                    loadData();
                    btn_LamMoi_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txb_maLophoc.Enabled) return;

            if (MessageBox.Show("Bạn có chắc muốn xóa lớp học này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var DeleteLop = db.LopHocs.SingleOrDefault(l => l.MaLop == txb_maLophoc.Text);
                    if (DeleteLop != null)
                    {
                        db.LopHocs.DeleteOnSubmit(DeleteLop);
                        db.SubmitChanges();
                        MessageBox.Show("Xóa lớp học thành công!", "Thông báo");

                        loadData();
                        btn_LamMoi_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ptb_Search_Click(object sender, EventArgs e)
        {
            string keyword = txb_SearchLH.Text.Trim();
            var searchResult = from c in db.LopHocs
                               where c.MaLop.Contains(keyword) || c.TenLop.Contains(keyword)
                               select new
                               {
                                   c.MaLop,
                                   c.TenLop,
                                   c.SiSo,
                               };
            dgv_DSLH.DataSource = searchResult.ToList();
        }

        private void btn_QLSV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_QLSV frmQLSV = new frm_QLSV();
            frmQLSV.ShowDialog();
            this.Close();
        }

        private void lbl_Nav_DX_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // CHỨC NĂNG XEM DANH SÁCH SINH VIÊN
        private void btn_XemDSSV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_maLophoc.Text) || txb_maLophoc.Enabled)
            {
                MessageBox.Show("Vui lòng chọn một lớp trong bảng bên phải để xem danh sách sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.Hide();
            // Mở form QLSV và truyền theo mã lớp đang chọn
            frm_QLSV frm = new frm_QLSV(txb_maLophoc.Text);
            frm.ShowDialog();
            this.Close();
        }
    }
}