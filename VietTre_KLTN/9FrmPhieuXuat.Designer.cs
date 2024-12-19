namespace VietTre_KLTN
{
    partial class _9FrmPhieuXuat
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
            this.components = new System.ComponentModel.Container();
            this.lableTitle = new System.Windows.Forms.Label();
            this.LableTimkiem = new System.Windows.Forms.Label();
            this.txbTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.labelNV = new System.Windows.Forms.Label();
            this.dgvPhieuXuat = new System.Windows.Forms.DataGridView();
            this.cT_DonHangTableAdapter1 = new VietTre_KLTN._2121000995_LeThiQuynhTruc_21DTK2DSCTDHTableAdapters.CT_DonHangTableAdapter();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelId = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtIDSP = new System.Windows.Forms.Label();
            this.txbSp = new System.Windows.Forms.TextBox();
            this.numPX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txbGC = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPX)).BeginInit();
            this.SuspendLayout();
            // 
            // lableTitle
            // 
            this.lableTitle.AutoSize = true;
            this.lableTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lableTitle.Location = new System.Drawing.Point(596, 47);
            this.lableTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableTitle.Name = "lableTitle";
            this.lableTitle.Size = new System.Drawing.Size(218, 37);
            this.lableTitle.TabIndex = 9;
            this.lableTitle.Text = "PHIẾU XUẤT";
            this.lableTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LableTimkiem
            // 
            this.LableTimkiem.AutoSize = true;
            this.LableTimkiem.Location = new System.Drawing.Point(154, 132);
            this.LableTimkiem.Name = "LableTimkiem";
            this.LableTimkiem.Size = new System.Drawing.Size(212, 25);
            this.LableTimkiem.TabIndex = 19;
            this.LableTimkiem.Text = "Tìm Kiếm Phiếu Xuất";
            // 
            // txbTimKiem
            // 
            this.txbTimKiem.Location = new System.Drawing.Point(428, 129);
            this.txbTimKiem.Name = "txbTimKiem";
            this.txbTimKiem.Size = new System.Drawing.Size(446, 31);
            this.txbTimKiem.TabIndex = 20;
            this.txbTimKiem.TextChanged += new System.EventHandler(this.tbxTimKiem_TextChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(968, 116);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(141, 57);
            this.btnTimKiem.TabIndex = 21;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(652, 852);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(141, 57);
            this.btnXoa.TabIndex = 36;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(427, 852);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(141, 57);
            this.btnSua.TabIndex = 35;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(210, 852);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(141, 57);
            this.btnThem.TabIndex = 34;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // labelNV
            // 
            this.labelNV.AutoSize = true;
            this.labelNV.Location = new System.Drawing.Point(792, 229);
            this.labelNV.Name = "labelNV";
            this.labelNV.Size = new System.Drawing.Size(0, 25);
            this.labelNV.TabIndex = 32;
            // 
            // dgvPhieuXuat
            // 
            this.dgvPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuXuat.Location = new System.Drawing.Point(210, 409);
            this.dgvPhieuXuat.Name = "dgvPhieuXuat";
            this.dgvPhieuXuat.RowHeadersWidth = 82;
            this.dgvPhieuXuat.RowTemplate.Height = 33;
            this.dgvPhieuXuat.Size = new System.Drawing.Size(1160, 398);
            this.dgvPhieuXuat.TabIndex = 28;
            // 
            // cT_DonHangTableAdapter1
            // 
            this.cT_DonHangTableAdapter1.ClearBeforeFill = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(50, 232);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(143, 25);
            this.labelId.TabIndex = 29;
            this.labelId.Text = "ID Phiếu Xuất";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(224, 229);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(368, 31);
            this.txtID.TabIndex = 24;
            // 
            // txtIDSP
            // 
            this.txtIDSP.AutoSize = true;
            this.txtIDSP.Location = new System.Drawing.Point(841, 229);
            this.txtIDSP.Name = "txtIDSP";
            this.txtIDSP.Size = new System.Drawing.Size(137, 25);
            this.txtIDSP.TabIndex = 37;
            this.txtIDSP.Text = "ID Sản Phẩm";
            // 
            // txbSp
            // 
            this.txbSp.Location = new System.Drawing.Point(1002, 229);
            this.txbSp.Name = "txbSp";
            this.txbSp.Size = new System.Drawing.Size(368, 31);
            this.txbSp.TabIndex = 38;
            this.txbSp.TextChanged += new System.EventHandler(this.txbIdsp_TextChanged);
            // 
            // numPX
            // 
            this.numPX.Location = new System.Drawing.Point(1002, 313);
            this.numPX.Name = "numPX";
            this.numPX.Size = new System.Drawing.Size(120, 31);
            this.numPX.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(841, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Số lượng";
            // 
            // txbGC
            // 
            this.txbGC.Location = new System.Drawing.Point(224, 315);
            this.txbGC.Name = "txbGC";
            this.txbGC.Size = new System.Drawing.Size(368, 31);
            this.txbGC.TabIndex = 42;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.AutoSize = true;
            this.txtGhiChu.Location = new System.Drawing.Point(50, 321);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(90, 25);
            this.txtGhiChu.TabIndex = 43;
            this.txtGhiChu.Text = "Ghi Chú";
            // 
            // _9FrmPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 933);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txbGC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numPX);
            this.Controls.Add(this.txbSp);
            this.Controls.Add(this.txtIDSP);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.labelNV);
            this.Controls.Add(this.dgvPhieuXuat);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txbTimKiem);
            this.Controls.Add(this.LableTimkiem);
            this.Controls.Add(this.lableTitle);
            this.Name = "_9FrmPhieuXuat";
            this.Text = "_9FrmPhieuXuat";
            this.Load += new System.EventHandler(this._9FrmPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lableTitle;
        private System.Windows.Forms.Label LableTimkiem;
        private System.Windows.Forms.TextBox txbTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label labelNV;
        private System.Windows.Forms.DataGridView dgvPhieuXuat;
        private _2121000995_LeThiQuynhTruc_21DTK2DSCTDHTableAdapters.CT_DonHangTableAdapter cT_DonHangTableAdapter1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label txtIDSP;
        private System.Windows.Forms.TextBox txbSp;
        private System.Windows.Forms.NumericUpDown numPX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbGC;
        private System.Windows.Forms.Label txtGhiChu;
    }
}