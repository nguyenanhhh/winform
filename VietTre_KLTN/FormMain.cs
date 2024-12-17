using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VietTre_KLTN
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// THOÁT KHỎI CHƯƠNG TRÌNH
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void thoátKhỏiChươngTrình_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thiệt thoát không (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo,
                                                                                  MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _1FrmDMNhanVien fr = new _1FrmDMNhanVien(); // omg ten ham tieng viet =)))
            fr.ShowDialog();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hiển thị thông báo xác nhận đăng xuất
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Đóng form hiện tại
                this.Close();

                // Mở form đăng nhập
                FormDangNhap frmDangNhap = new FormDangNhap();
                frmDangNhap.Show();
            }
        }

        private void kháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _2FrmDMKhachHang fr = new _2FrmDMKhachHang();
            fr.ShowDialog();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _3FrmDMSanPham fr = new _3FrmDMSanPham();
            fr.ShowDialog();
        }

        private void báoCáoDanhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DSNV fr = new Form_DSNV();
            fr.ShowDialog();
        }

        private void báoCáoDanhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DNKH fr = new Form_DNKH();
            fr.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _5FrmHoaDon hoadonForm = new _5FrmHoaDon();
            hoadonForm.ShowDialog();
        }

        private void đơnĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _7FrmQuanLiDonHang qu = new _7FrmQuanLiDonHang();
            qu.ShowDialog();
        }

        /// <summary>
        ///THỦ TỤC NÀY ĐƯỢC TỰ ĐỘNG CHẠY MỖI KHI FORM NÀY ĐƯỢC MỞ RA
        /// THỦ TỤC TỰ ĐỘNG CHẠY (RUN) MỖI KHI FORM MÀN HÌNH NÀY (Fr1Main) ĐƯỢC MỞ (TẢI = LOAD) LÊN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void FormMain_Load(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Welcome to Phần mềm Kế toán Bán hàng");
        //    //StatusLbdate.Text = lbdate.Text = "Hôm nay: " + DateTime.Now.ToShortDateString();
        //}
    }
}
