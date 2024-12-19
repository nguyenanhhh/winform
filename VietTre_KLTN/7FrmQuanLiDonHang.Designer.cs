namespace VietTre_KLTN
{
    partial class _7FrmQuanLiDonHang
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTimKiem = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.cbb_khachhang = new System.Windows.Forms.ComboBox();
            this.MaCN = new System.Windows.Forms.Label();
            this.dtpk_ngay_tao = new System.Windows.Forms.DateTimePicker();
            this.HoTenNV = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.MaNV = new System.Windows.Forms.Label();
            this.cbb_nhanvien = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_giaohang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_mota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(328, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÍ ĐƠN HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxTimKiem
            // 
            this.tbxTimKiem.Location = new System.Drawing.Point(335, 112);
            this.tbxTimKiem.Name = "tbxTimKiem";
            this.tbxTimKiem.Size = new System.Drawing.Size(446, 31);
            this.tbxTimKiem.TabIndex = 2;
            this.tbxTimKiem.TextChanged += new System.EventHandler(this.tbxTimKiem_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tìm kiếm đơn hàng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(798, 99);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(121, 56);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.Location = new System.Drawing.Point(43, 183);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.ReadOnly = true;
            this.dgvDonHang.RowHeadersWidth = 82;
            this.dgvDonHang.RowTemplate.Height = 33;
            this.dgvDonHang.Size = new System.Drawing.Size(916, 266);
            this.dgvDonHang.TabIndex = 6;
            this.dgvDonHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(241, 497);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(133, 44);
            this.btnCapNhat.TabIndex = 7;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(441, 497);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(115, 44);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(45, 497);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(127, 44);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(802, 497);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(130, 44);
            this.btnDong.TabIndex = 10;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // cbb_khachhang
            // 
            this.cbb_khachhang.DisplayMember = "TenTK";
            this.cbb_khachhang.FormattingEnabled = true;
            this.cbb_khachhang.Location = new System.Drawing.Point(178, 591);
            this.cbb_khachhang.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_khachhang.Name = "cbb_khachhang";
            this.cbb_khachhang.Size = new System.Drawing.Size(315, 33);
            this.cbb_khachhang.TabIndex = 41;
            this.cbb_khachhang.ValueMember = "ID_TK";
            // 
            // MaCN
            // 
            this.MaCN.AutoSize = true;
            this.MaCN.Location = new System.Drawing.Point(50, 592);
            this.MaCN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaCN.Name = "MaCN";
            this.MaCN.Size = new System.Drawing.Size(130, 25);
            this.MaCN.TabIndex = 40;
            this.MaCN.Text = "Khach Hang";
            this.MaCN.Click += new System.EventHandler(this.MaCN_Click);
            // 
            // dtpk_ngay_tao
            // 
            this.dtpk_ngay_tao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_ngay_tao.Location = new System.Drawing.Point(694, 656);
            this.dtpk_ngay_tao.Margin = new System.Windows.Forms.Padding(4);
            this.dtpk_ngay_tao.Name = "dtpk_ngay_tao";
            this.dtpk_ngay_tao.Size = new System.Drawing.Size(189, 31);
            this.dtpk_ngay_tao.TabIndex = 43;
            // 
            // HoTenNV
            // 
            this.HoTenNV.AutoSize = true;
            this.HoTenNV.Location = new System.Drawing.Point(549, 660);
            this.HoTenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HoTenNV.Name = "HoTenNV";
            this.HoTenNV.Size = new System.Drawing.Size(141, 25);
            this.HoTenNV.TabIndex = 42;
            this.HoTenNV.Text = "Ngay Tao DH";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(694, 589);
            this.tb_id.Margin = new System.Windows.Forms.Padding(4);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(139, 31);
            this.tb_id.TabIndex = 45;
            // 
            // MaNV
            // 
            this.MaNV.AutoSize = true;
            this.MaNV.Location = new System.Drawing.Point(549, 592);
            this.MaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaNV.Name = "MaNV";
            this.MaNV.Size = new System.Drawing.Size(144, 25);
            this.MaNV.TabIndex = 44;
            this.MaNV.Text = "Ma Don Hang";
            // 
            // cbb_nhanvien
            // 
            this.cbb_nhanvien.DisplayMember = "TenTK";
            this.cbb_nhanvien.FormattingEnabled = true;
            this.cbb_nhanvien.Location = new System.Drawing.Point(178, 662);
            this.cbb_nhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_nhanvien.Name = "cbb_nhanvien";
            this.cbb_nhanvien.Size = new System.Drawing.Size(315, 33);
            this.cbb_nhanvien.TabIndex = 47;
            this.cbb_nhanvien.ValueMember = "ID_TK";
            this.cbb_nhanvien.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 663);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Nhan Vien";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbb_giaohang
            // 
            this.cbb_giaohang.DisplayMember = "TenTK";
            this.cbb_giaohang.FormattingEnabled = true;
            this.cbb_giaohang.Location = new System.Drawing.Point(178, 731);
            this.cbb_giaohang.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_giaohang.Name = "cbb_giaohang";
            this.cbb_giaohang.Size = new System.Drawing.Size(315, 33);
            this.cbb_giaohang.TabIndex = 49;
            this.cbb_giaohang.ValueMember = "ID_TK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 732);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 48;
            this.label4.Text = "Giao Hang";
            // 
            // tb_mota
            // 
            this.tb_mota.Location = new System.Drawing.Point(694, 729);
            this.tb_mota.Margin = new System.Windows.Forms.Padding(4);
            this.tb_mota.Multiline = true;
            this.tb_mota.Name = "tb_mota";
            this.tb_mota.Size = new System.Drawing.Size(242, 83);
            this.tb_mota.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(574, 732);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "Mo Ta";
            // 
            // _7FrmQuanLiDonHang
            // 
            this.ClientSize = new System.Drawing.Size(998, 878);
            this.Controls.Add(this.tb_mota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbb_giaohang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbb_nhanvien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.MaNV);
            this.Controls.Add(this.dtpk_ngay_tao);
            this.Controls.Add(this.HoTenNV);
            this.Controls.Add(this.cbb_khachhang);
            this.Controls.Add(this.MaCN);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.dgvDonHang);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxTimKiem);
            this.Controls.Add(this.label1);
            this.Name = "_7FrmQuanLiDonHang";
            this.Text = "Quản Lý Đơn Hàng";
            this.Load += new System.EventHandler(this._7FrmQuanLiDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTimKiem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.ComboBox cbb_khachhang;
        private System.Windows.Forms.Label MaCN;
        private System.Windows.Forms.DateTimePicker dtpk_ngay_tao;
        private System.Windows.Forms.Label HoTenNV;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label MaNV;
        private System.Windows.Forms.ComboBox cbb_nhanvien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_giaohang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_mota;
        private System.Windows.Forms.Label label5;
    }
}
