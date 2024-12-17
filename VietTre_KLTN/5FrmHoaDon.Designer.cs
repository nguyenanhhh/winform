
namespace VietTre_KLTN
{
    partial class _5FrmHoaDon
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
            this.dgvDSHD = new System.Windows.Forms.DataGridView();
            this.tb_ptttt = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbb_khachhanh = new System.Windows.Forms.ComboBox();
            this.MaCN = new System.Windows.Forms.Label();
            this.ID_TK = new System.Windows.Forms.Label();
            this.tb_mhd = new System.Windows.Forms.TextBox();
            this.SDT = new System.Windows.Forms.Label();
            this.GioiTinh = new System.Windows.Forms.Label();
            this.HoTenNV = new System.Windows.Forms.Label();
            this.MaNV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpk_ngay_tao = new System.Windows.Forms.DateTimePicker();
            this.cbb_nhanvien = new System.Windows.Forms.ComboBox();
            this.cbb_don_hang = new System.Windows.Forms.ComboBox();
            this.MaCV = new System.Windows.Forms.Label();
            this.tb_ghi_chu = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSHD
            // 
            this.dgvDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHD.Location = new System.Drawing.Point(13, 447);
            this.dgvDSHD.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSHD.Name = "dgvDSHD";
            this.dgvDSHD.ReadOnly = true;
            this.dgvDSHD.RowHeadersWidth = 62;
            this.dgvDSHD.RowTemplate.Height = 28;
            this.dgvDSHD.Size = new System.Drawing.Size(1751, 638);
            this.dgvDSHD.TabIndex = 0;
            this.dgvDSHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHD_CellContentClick);
            this.dgvDSHD.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvDSHD_RowStateChanged);
            this.dgvDSHD.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHD_RowValidated);
            // 
            // tb_ptttt
            // 
            this.tb_ptttt.Location = new System.Drawing.Point(279, 203);
            this.tb_ptttt.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ptttt.Multiline = true;
            this.tb_ptttt.Name = "tb_ptttt";
            this.tb_ptttt.Size = new System.Drawing.Size(362, 122);
            this.tb_ptttt.TabIndex = 25;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(1498, 148);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(149, 61);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(1498, 83);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(149, 61);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbb_khachhanh
            // 
            this.cbb_khachhanh.DisplayMember = "TenTK";
            this.cbb_khachhanh.FormattingEnabled = true;
            this.cbb_khachhanh.Location = new System.Drawing.Point(643, 156);
            this.cbb_khachhanh.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_khachhanh.Name = "cbb_khachhanh";
            this.cbb_khachhanh.Size = new System.Drawing.Size(259, 33);
            this.cbb_khachhanh.TabIndex = 32;
            this.cbb_khachhanh.ValueMember = "ID_TK";
            // 
            // MaCN
            // 
            this.MaCN.AutoSize = true;
            this.MaCN.Location = new System.Drawing.Point(931, 104);
            this.MaCN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaCN.Name = "MaCN";
            this.MaCN.Size = new System.Drawing.Size(108, 25);
            this.MaCN.TabIndex = 29;
            this.MaCN.Text = "Đơn Hàng";
            // 
            // ID_TK
            // 
            this.ID_TK.AutoSize = true;
            this.ID_TK.Location = new System.Drawing.Point(498, 156);
            this.ID_TK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID_TK.Name = "ID_TK";
            this.ID_TK.Size = new System.Drawing.Size(130, 25);
            this.ID_TK.TabIndex = 33;
            this.ID_TK.Text = "Khách Hàng";
            // 
            // tb_mhd
            // 
            this.tb_mhd.Location = new System.Drawing.Point(279, 96);
            this.tb_mhd.Margin = new System.Windows.Forms.Padding(4);
            this.tb_mhd.Name = "tb_mhd";
            this.tb_mhd.Size = new System.Drawing.Size(139, 31);
            this.tb_mhd.TabIndex = 16;
            // 
            // SDT
            // 
            this.SDT.AutoSize = true;
            this.SDT.Location = new System.Drawing.Point(134, 211);
            this.SDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(65, 25);
            this.SDT.TabIndex = 26;
            this.SDT.Text = "PTTT";
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSize = true;
            this.GioiTinh.Location = new System.Drawing.Point(134, 152);
            this.GioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Size = new System.Drawing.Size(112, 25);
            this.GioiTinh.TabIndex = 20;
            this.GioiTinh.Text = "Nhân Viên";
            // 
            // HoTenNV
            // 
            this.HoTenNV.AutoSize = true;
            this.HoTenNV.Location = new System.Drawing.Point(498, 103);
            this.HoTenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HoTenNV.Name = "HoTenNV";
            this.HoTenNV.Size = new System.Drawing.Size(140, 25);
            this.HoTenNV.TabIndex = 17;
            this.HoTenNV.Text = "Ngày Lập HD";
            // 
            // MaNV
            // 
            this.MaNV.AutoSize = true;
            this.MaNV.Location = new System.Drawing.Point(134, 99);
            this.MaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaNV.Name = "MaNV";
            this.MaNV.Size = new System.Drawing.Size(126, 25);
            this.MaNV.TabIndex = 15;
            this.MaNV.Text = "Mã hóa đơn";
            this.MaNV.Click += new System.EventHandler(this.MaNV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(691, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "DANH SÁCH HÓA ĐƠN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpk_ngay_tao
            // 
            this.dtpk_ngay_tao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_ngay_tao.Location = new System.Drawing.Point(643, 103);
            this.dtpk_ngay_tao.Margin = new System.Windows.Forms.Padding(4);
            this.dtpk_ngay_tao.Name = "dtpk_ngay_tao";
            this.dtpk_ngay_tao.Size = new System.Drawing.Size(189, 31);
            this.dtpk_ngay_tao.TabIndex = 37;
            // 
            // cbb_nhanvien
            // 
            this.cbb_nhanvien.DisplayMember = "TenCV";
            this.cbb_nhanvien.FormattingEnabled = true;
            this.cbb_nhanvien.Location = new System.Drawing.Point(279, 148);
            this.cbb_nhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_nhanvien.Name = "cbb_nhanvien";
            this.cbb_nhanvien.Size = new System.Drawing.Size(170, 33);
            this.cbb_nhanvien.TabIndex = 38;
            this.cbb_nhanvien.ValueMember = "ID_CV";
            // 
            // cbb_don_hang
            // 
            this.cbb_don_hang.DisplayMember = "TenTK";
            this.cbb_don_hang.FormattingEnabled = true;
            this.cbb_don_hang.Location = new System.Drawing.Point(1059, 103);
            this.cbb_don_hang.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_don_hang.Name = "cbb_don_hang";
            this.cbb_don_hang.Size = new System.Drawing.Size(315, 33);
            this.cbb_don_hang.TabIndex = 39;
            this.cbb_don_hang.ValueMember = "ID_TK";
            // 
            // MaCV
            // 
            this.MaCV.AutoSize = true;
            this.MaCV.Location = new System.Drawing.Point(931, 166);
            this.MaCV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaCV.Name = "MaCV";
            this.MaCV.Size = new System.Drawing.Size(86, 25);
            this.MaCV.TabIndex = 40;
            this.MaCV.Text = "Ghi chú";
            // 
            // tb_ghi_chu
            // 
            this.tb_ghi_chu.Location = new System.Drawing.Point(1059, 166);
            this.tb_ghi_chu.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ghi_chu.Multiline = true;
            this.tb_ghi_chu.Name = "tb_ghi_chu";
            this.tb_ghi_chu.Size = new System.Drawing.Size(362, 122);
            this.tb_ghi_chu.TabIndex = 41;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(1498, 212);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(149, 61);
            this.btn_reset.TabIndex = 21;
            this.btn_reset.Text = "Clear";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // _5FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1771, 1106);
            this.Controls.Add(this.tb_ghi_chu);
            this.Controls.Add(this.MaCV);
            this.Controls.Add(this.cbb_don_hang);
            this.Controls.Add(this.cbb_nhanvien);
            this.Controls.Add(this.dtpk_ngay_tao);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.tb_ptttt);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbb_khachhanh);
            this.Controls.Add(this.MaCN);
            this.Controls.Add(this.ID_TK);
            this.Controls.Add(this.tb_mhd);
            this.Controls.Add(this.SDT);
            this.Controls.Add(this.GioiTinh);
            this.Controls.Add(this.HoTenNV);
            this.Controls.Add(this.MaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSHD);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "_5FrmHoaDon";
            this.Text = "_5FrmHoaDon";
            this.Load += new System.EventHandler(this._5FrmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSHD;
        private System.Windows.Forms.TextBox tb_ptttt;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbb_khachhanh;
        private System.Windows.Forms.Label MaCN;
        private System.Windows.Forms.Label ID_TK;
        private System.Windows.Forms.TextBox tb_mhd;
        private System.Windows.Forms.Label SDT;
        private System.Windows.Forms.Label GioiTinh;
        private System.Windows.Forms.Label HoTenNV;
        private System.Windows.Forms.Label MaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpk_ngay_tao;
        private System.Windows.Forms.ComboBox cbb_nhanvien;
        private System.Windows.Forms.ComboBox cbb_don_hang;
        private System.Windows.Forms.Label MaCV;
        private System.Windows.Forms.TextBox tb_ghi_chu;
        private System.Windows.Forms.Button btn_reset;
    }
}