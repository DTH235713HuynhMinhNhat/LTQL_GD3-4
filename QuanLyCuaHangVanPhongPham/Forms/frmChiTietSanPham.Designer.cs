namespace QuanLyVanPhongPham.Forms
{
    partial class frmChiTietSanPham
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            grpThongTinChung = new GroupBox();
            label1 = new Label();
            txtTenSP = new TextBox();
            label2 = new Label();
            cboLoaiSP = new ComboBox();
            label6 = new Label();
            cboThuongHieu = new ComboBox();
            label3 = new Label();
            cboDVT = new ComboBox();
            label7 = new Label();
            cboNhaCungCap = new ComboBox();
            grpKhoGia = new GroupBox();
            label4 = new Label();
            txtGiaBan = new TextBox();
            label5 = new Label();
            txtSoLuong = new TextBox();
            grpHinhAnh = new GroupBox();
            ptbHinhAnh = new PictureBox();
            btnChonAnh = new Button();
            btnLuu = new Button();
            btnHuy = new Button();

            pnlHeader.SuspendLayout();
            grpThongTinChung.SuspendLayout();
            grpKhoGia.SuspendLayout();
            grpHinhAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbHinhAnh).BeginInit();
            SuspendLayout();

            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(600, 60);
            pnlHeader.TabIndex = 0;

            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(244, 32);
            lblTitle.Text = "CHI TIẾT SẢN PHẨM";

            // 
            // grpThongTinChung
            // 
            grpThongTinChung.Controls.Add(label1);
            grpThongTinChung.Controls.Add(txtTenSP);
            grpThongTinChung.Controls.Add(label2);
            grpThongTinChung.Controls.Add(cboLoaiSP);
            grpThongTinChung.Controls.Add(label6);
            grpThongTinChung.Controls.Add(cboThuongHieu);
            grpThongTinChung.Controls.Add(label3);
            grpThongTinChung.Controls.Add(cboDVT);
            grpThongTinChung.Controls.Add(label7);
            grpThongTinChung.Controls.Add(cboNhaCungCap);
            grpThongTinChung.Location = new System.Drawing.Point(20, 75);
            grpThongTinChung.Name = "grpThongTinChung";
            grpThongTinChung.Size = new System.Drawing.Size(340, 260);
            grpThongTinChung.TabIndex = 1;
            grpThongTinChung.TabStop = false;
            grpThongTinChung.Text = "Thông tin cơ bản";

            // label1 (Tên SP)
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(15, 30);
            label1.Text = "Tên sản phẩm:";
            txtTenSP.Location = new System.Drawing.Point(15, 55);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new System.Drawing.Size(310, 30);

            // label2 (Loại SP)
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(15, 100);
            label2.Text = "Loại sản phẩm:";
            cboLoaiSP.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSP.Location = new System.Drawing.Point(15, 125);
            cboLoaiSP.Name = "cboLoaiSP";
            cboLoaiSP.Size = new System.Drawing.Size(145, 31);

            // label6 (Thương hiệu)
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(180, 100);
            label6.Text = "Thương hiệu:";
            cboThuongHieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboThuongHieu.Location = new System.Drawing.Point(180, 125);
            cboThuongHieu.Name = "cboThuongHieu";
            cboThuongHieu.Size = new System.Drawing.Size(145, 31);

            // label3 (ĐVT)
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(15, 175);
            label3.Text = "Đơn vị tính:";
            cboDVT.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDVT.Location = new System.Drawing.Point(15, 200);
            cboDVT.Name = "cboDVT";
            cboDVT.Size = new System.Drawing.Size(145, 31);

            // label7 (NCC)
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(180, 175);
            label7.Text = "Nhà cung cấp:";
            cboNhaCungCap.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhaCungCap.Location = new System.Drawing.Point(180, 200);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new System.Drawing.Size(145, 31);

            // 
            // grpKhoGia
            // 
            grpKhoGia.Controls.Add(label4);
            grpKhoGia.Controls.Add(txtGiaBan);
            grpKhoGia.Controls.Add(label5);
            grpKhoGia.Controls.Add(txtSoLuong);
            grpKhoGia.Location = new System.Drawing.Point(20, 345);
            grpKhoGia.Name = "grpKhoGia";
            grpKhoGia.Size = new System.Drawing.Size(340, 100);
            grpKhoGia.TabIndex = 2;
            grpKhoGia.TabStop = false;
            grpKhoGia.Text = "Thông tin kho & Giá";

            // label4 (Giá bán)
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(15, 30);
            label4.Text = "Giá bán:";
            txtGiaBan.Location = new System.Drawing.Point(15, 55);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new System.Drawing.Size(145, 30);
            txtGiaBan.TextAlign = HorizontalAlignment.Right;

            // label5 (Số lượng)
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(180, 30);
            label5.Text = "Số lượng tồn:";
            txtSoLuong.Location = new System.Drawing.Point(180, 55);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new System.Drawing.Size(145, 30);
            txtSoLuong.TextAlign = HorizontalAlignment.Right;

            // 
            // grpHinhAnh
            // 
            grpHinhAnh.Controls.Add(ptbHinhAnh);
            grpHinhAnh.Controls.Add(btnChonAnh);
            grpHinhAnh.Location = new System.Drawing.Point(380, 75);
            grpHinhAnh.Name = "grpHinhAnh";
            grpHinhAnh.Size = new System.Drawing.Size(200, 260);
            grpHinhAnh.TabIndex = 3;
            grpHinhAnh.TabStop = false;
            grpHinhAnh.Text = "Hình ảnh";

            // ptbHinhAnh
            ptbHinhAnh.BorderStyle = BorderStyle.FixedSingle;
            ptbHinhAnh.Location = new System.Drawing.Point(15, 30);
            ptbHinhAnh.Name = "ptbHinhAnh";
            ptbHinhAnh.Size = new System.Drawing.Size(170, 170);
            ptbHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;

            // btnChonAnh
            btnChonAnh.Location = new System.Drawing.Point(15, 210);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new System.Drawing.Size(170, 35);
            btnChonAnh.Text = "Chọn ảnh...";

            // 
            // btnLuu
            // 
            btnLuu.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnLuu.ForeColor = System.Drawing.Color.White;
            btnLuu.Location = new System.Drawing.Point(340, 470);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new System.Drawing.Size(110, 40);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "LƯU";
            btnLuu.UseVisualStyleBackColor = false;

            // 
            // btnHuy
            // 
            btnHuy.BackColor = System.Drawing.Color.FromArgb(189, 195, 199);
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnHuy.ForeColor = System.Drawing.Color.White;
            btnHuy.Location = new System.Drawing.Point(470, 470);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new System.Drawing.Size(110, 40);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "HỦY";
            btnHuy.UseVisualStyleBackColor = false;

            // 
            // frmChiTietSanPham
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(600, 530);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(grpKhoGia);
            Controls.Add(grpHinhAnh);
            Controls.Add(grpThongTinChung);
            Controls.Add(pnlHeader);
            Font = new System.Drawing.Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmChiTietSanPham";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chi tiết sản phẩm";

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpThongTinChung.ResumeLayout(false);
            grpThongTinChung.PerformLayout();
            grpKhoGia.ResumeLayout(false);
            grpKhoGia.PerformLayout();
            grpHinhAnh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbHinhAnh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private GroupBox grpThongTinChung;
        private Label label1;
        private TextBox txtTenSP;
        private Label label2;
        private ComboBox cboLoaiSP;
        private Label label6;
        private ComboBox cboThuongHieu;
        private Label label3;
        private ComboBox cboDVT;
        private Label label7;
        private ComboBox cboNhaCungCap;
        private GroupBox grpKhoGia;
        private Label label4;
        private TextBox txtGiaBan;
        private Label label5;
        private TextBox txtSoLuong;
        private GroupBox grpHinhAnh;
        private PictureBox ptbHinhAnh;
        private Button btnChonAnh;
        private Button btnLuu;
        private Button btnHuy;
    }
}