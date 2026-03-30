using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyVanPhongPham.Data;

namespace QuanLyVanPhongPham.Forms
{
    public partial class frmChiTietSanPham : Form
    {
        private QLCHVPPDbContext db = new QLCHVPPDbContext();
        private int? _idSanPham;

        public frmChiTietSanPham(int? id = null)
        {
            InitializeComponent();
            _idSanPham = id;

            // Đăng ký các sự kiện cơ bản
            this.Load += FrmChiTietSanPham_Load;
            btnLuu.Click += BtnLuu_Click;
            btnHuy.Click += (s, e) => this.Close();
            btnChonAnh.Click += BtnChonAnh_Click;

            // --- CẢI THIỆN TRẢI NGHIỆM NHẬP LIỆU ---
            // 1. Chỉ cho phép nhập số vào Giá bán và Số lượng
            txtGiaBan.KeyPress += OnlyNumber_KeyPress;
            txtSoLuong.KeyPress += OnlyNumber_KeyPress;

            // 2. Tự động định dạng tiền tệ khi gõ (ví dụ: 1.000.000)
            txtGiaBan.TextChanged += MoneyFormat_TextChanged;
        }

        private void FrmChiTietSanPham_Load(object sender, EventArgs e)
        {
            LoadComboBox();

            if (_idSanPham != null)
            {
                lblTitle.Text = "CHỈNH SỬA SẢN PHẨM";
                LoadProductData();
            }
            else
            {
                lblTitle.Text = "THÊM MỚI SẢN PHẨM";
                txtGiaBan.Text = "0";
                txtSoLuong.Text = "0";
            }
        }

        private void LoadComboBox()
        {
            try
            {
                cboLoaiSP.DataSource = db.LoaiSanPham.ToList();
                cboLoaiSP.DisplayMember = "TenLoai";
                cboLoaiSP.ValueMember = "ID";
                cboLoaiSP.SelectedIndex = -1;

                cboDVT.DataSource = db.DonViTinh.ToList();
                cboDVT.DisplayMember = "TenDonVi";
                cboDVT.ValueMember = "ID";
                cboDVT.SelectedIndex = -1;

                cboThuongHieu.DataSource = db.ThuongHieu.ToList();
                cboThuongHieu.DisplayMember = "TenThuongHieu";
                cboThuongHieu.ValueMember = "ID";
                cboThuongHieu.SelectedIndex = -1;

                cboNhaCungCap.DataSource = db.NhaCungCap.ToList();
                cboNhaCungCap.DisplayMember = "TenNCC";
                cboNhaCungCap.ValueMember = "ID";
                cboNhaCungCap.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProductData()
        {
            var sp = db.SanPham.Find(_idSanPham);
            if (sp != null)
            {
                txtTenSP.Text = sp.TenSanPham;
                // Khi load dữ liệu lên, TextChanged sẽ tự định dạng dấu chấm cho txtGiaBan
                txtGiaBan.Text = sp.GiaBan.ToString();
                txtSoLuong.Text = sp.SoLuong.ToString();

                cboLoaiSP.SelectedValue = sp.LoaiSanPhamID;
                cboDVT.SelectedValue = sp.DonViTinhID;
                cboThuongHieu.SelectedValue = sp.ThuongHieuID;
                cboNhaCungCap.SelectedValue = sp.NhaCungCapID;

                if (!string.IsNullOrEmpty(sp.HinhAnh))
                {
                    try { ptbHinhAnh.ImageLocation = sp.HinhAnh; } catch { }
                }
            }
        }

        // --- HÀM XỬ LÝ SỰ KIỆN NHẬP LIỆU ---
        private void OnlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép số và phím xóa (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MoneyFormat_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (!string.IsNullOrEmpty(txt.Text))
            {
                try
                {
                    // Xóa dấu chấm hiện tại để lấy số nguyên
                    string value = txt.Text.Replace(".", "");
                    // Định dạng lại theo chuẩn 1.000.000
                    txt.Text = string.Format("{0:N0}", double.Parse(value)).Replace(",", ".");
                    txt.SelectionStart = txt.Text.Length; // Giữ con trỏ ở cuối
                }
                catch { }
            }
        }

        private void BtnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ptbHinhAnh.ImageLocation = ofd.FileName;
                }
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTenSP.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên sản phẩm!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenSP.Focus();
                    return;
                }

                if (cboLoaiSP.SelectedValue == null || cboDVT.SelectedValue == null ||
                    cboThuongHieu.SelectedValue == null || cboNhaCungCap.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn đầy đủ các thông tin danh mục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SanPham sp;
                if (_idSanPham == null)
                {
                    sp = new SanPham();
                    db.SanPham.Add(sp);
                }
                else
                {
                    sp = db.SanPham.Find(_idSanPham);
                }

                sp.TenSanPham = txtTenSP.Text.Trim();

                // Loại bỏ dấu chấm định dạng trước khi lưu vào database (int)
                string giaBanGoc = txtGiaBan.Text.Replace(".", "");
                if (!int.TryParse(giaBanGoc, out int gia)) gia = 0;
                sp.GiaBan = gia;

                if (!int.TryParse(txtSoLuong.Text, out int sl)) sl = 0;
                sp.SoLuong = sl;

                sp.LoaiSanPhamID = (int)cboLoaiSP.SelectedValue;
                sp.DonViTinhID = (int)cboDVT.SelectedValue;
                sp.ThuongHieuID = (int)cboThuongHieu.SelectedValue;
                sp.NhaCungCapID = (int)cboNhaCungCap.SelectedValue;

                sp.HinhAnh = ptbHinhAnh.ImageLocation;

                db.SaveChanges();
                MessageBox.Show("Đã lưu thông tin sản phẩm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                if (ex.InnerException != null) errorMessage += "\nChi tiết: " + ex.InnerException.Message;
                MessageBox.Show("Lỗi khi lưu: " + errorMessage, "Lỗi DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}