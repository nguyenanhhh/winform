
namespace VietTre_KLTN
{
    partial class FormDangNhap
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.taiKhoanDangNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._2121000995_LeThiQuynhTruc_21DTK2DSTK = new VietTre_KLTN._2121000995_LeThiQuynhTruc_21DTK2DSTK();
            this.txtdangnhap = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.taiKhoanDangNhapTableAdapter = new VietTre_KLTN._2121000995_LeThiQuynhTruc_21DTK2DSTKTableAdapters.TaiKhoanDangNhapTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanDangNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._2121000995_LeThiQuynhTruc_21DTK2DSTK)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txtmk
            // 
            this.txtmk.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.taiKhoanDangNhapBindingSource, "MatKhau", true));
            this.txtmk.Location = new System.Drawing.Point(298, 425);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(182, 26);
            this.txtmk.TabIndex = 15;
            // 
            // taiKhoanDangNhapBindingSource
            // 
            this.taiKhoanDangNhapBindingSource.DataMember = "TaiKhoanDangNhap";
            this.taiKhoanDangNhapBindingSource.DataSource = this._2121000995_LeThiQuynhTruc_21DTK2DSTK;
            // 
            // _2121000995_LeThiQuynhTruc_21DTK2DSTK
            // 
            this._2121000995_LeThiQuynhTruc_21DTK2DSTK.DataSetName = "_2121000995_LeThiQuynhTruc_21DTK2DSTK";
            this._2121000995_LeThiQuynhTruc_21DTK2DSTK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtdangnhap
            // 
            this.txtdangnhap.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.taiKhoanDangNhapBindingSource, "TenTK", true));
            this.txtdangnhap.Location = new System.Drawing.Point(298, 373);
            this.txtdangnhap.Name = "txtdangnhap";
            this.txtdangnhap.Size = new System.Drawing.Size(182, 26);
            this.txtdangnhap.TabIndex = 14;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.IndianRed;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(358, 484);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(80, 41);
            this.btnthoat.TabIndex = 13;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btndangnhap
            // 
            this.btndangnhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.ForeColor = System.Drawing.Color.Black;
            this.btndangnhap.Location = new System.Drawing.Point(199, 484);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(132, 41);
            this.btndangnhap.TabIndex = 12;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = false;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(217, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 36);
            this.label3.TabIndex = 11;
            this.label3.Text = "ĐĂNG NHẬP";
            // 
            // taiKhoanDangNhapTableAdapter
            // 
            this.taiKhoanDangNhapTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtmk);
            this.groupBox1.Controls.Add(this.txtdangnhap);
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btndangnhap);
            this.groupBox1.Location = new System.Drawing.Point(567, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 624);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VietTre_KLTN.Properties.Resources.LOGIN_1;
            this.pictureBox1.Location = new System.Drawing.Point(219, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = global::VietTre_KLTN.Properties.Resources.anh_VietTre;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1346, 680);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormDangNhap";
            this.Text = "FormDangNhap";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanDangNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._2121000995_LeThiQuynhTruc_21DTK2DSTK)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txtdangnhap;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Label label3;
        private _2121000995_LeThiQuynhTruc_21DTK2DSTK _2121000995_LeThiQuynhTruc_21DTK2DSTK;
        private System.Windows.Forms.BindingSource taiKhoanDangNhapBindingSource;
        private _2121000995_LeThiQuynhTruc_21DTK2DSTKTableAdapters.TaiKhoanDangNhapTableAdapter taiKhoanDangNhapTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}