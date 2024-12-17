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
    public partial class _1FrmDMNhanVien : Form
    {
        public _1FrmDMNhanVien()
        {
            InitializeComponent();
        }

        private void manhinhchinh_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn chắc chắn quay về màn hình chính không (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void _1FrmDMNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_2121000995_LeThiQuynhTruc_21DTK2DSCV.ChucVu' table. You can move, or remove it, as needed.
            //this.chucVuTableAdapter.Fill(this._2121000995_LeThiQuynhTruc_21DTK2DSCV.ChucVu);
            // TODO: This line of code loads data into the '_2121000995_LeThiQuynhTruc_21DTK2DSTK.TaiKhoanDangNhap' table. You can move, or remove it, as needed.
            //this.taiKhoanDangNhapTableAdapter.Fill(this._2121000995_LeThiQuynhTruc_21DTK2DSTK.TaiKhoanDangNhap);
            // TODO: This line of code loads data into the '_2121000995_LeThiQuynhTruc_21DTK2DSNV.NhanVien' table. You can move, or remove it, as needed.
            //this.nhanVienTableAdapter.Fill(this._2121000995_LeThiQuynhTruc_21DTK2DSNV.NhanVien);

        }

        private void btndong_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thiệt đóng màn hình không (Y/N)", "Xác nhận",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// THÊM THÔNG TIN KHÁCH HÀNG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            //B1: ĐÓNG _ MỞ : ĐƯỢC PHÉP HAY KHÔNG ĐƯỢC THAY ĐỔI CÁC TEXTBOX THÔNG TIN SAN PHAM

            txtMaNV.Enabled = !txtMaNV.Enabled;

            txtHoTenNV.Enabled = !txtHoTenNV.Enabled;

            txtGioitinh.Enabled = !txtGioitinh.Enabled;

            dateTimePickerNSNV.Enabled = !dateTimePickerNSNV.Enabled;

            txtSDT.Enabled = !txtSDT.Enabled;

            txtDiachi.Enabled = !txtDiachi.Enabled;

            txtEmail.Enabled = !txtEmail.Enabled;

            txtcccd.Enabled = !txtcccd.Enabled;

            comboBoxMaCV.Enabled = !comboBoxMaCV.Enabled;

            comboBoxID_TK.Enabled = !comboBoxID_TK.Enabled;

            //khóa các nút lệnh khác (ngoại trừ được Đóng form)

            btnXoa.Enabled = !btnXoa.Enabled;

            btnSua.Enabled = !btnSua.Enabled;

            btndong.Enabled = !btndong.Enabled;

            dgvNhanVien.Enabled = !dgvNhanVien.Enabled; //không thay đổi

            if (btnThem.Text == "Thêm")//CHUẨN BỊ THÊM NS

            {//MỞ CHẾ ĐỘ CHO NSD CHỌN HÌNH CHO SP MỚI

                // pictureBoxSPham.ImageLocation = apppath + "Chonhinh.png"; //hiện hình ảnh thông báo NSD chọn hình

                //pictureBoxSPham.Click += new EventHandler(Chonhinh);// cho phép NSD click vào PictureBox để chọn hình (Gán Event Click vào PictureBox SPham)                                                    

                //XÓA CÁC Ô TEXTBOX TRONG CHI TIẾT Ơ BÊN TRÊN ĐỂ CHUẨN BỊ CHO NSD NHẬP THÔNG TIN SP MỚI

                txtMaNV.Text = "";

                txtHoTenNV.Text = "";

                txtGioitinh.Text = "";

                txtSDT.Text = "";

                txtDiachi.Text = "";

                txtEmail.Text = "";

                txtcccd.Text = "";

                btnThem.Text = "Lưu";

                //đổi nhãn Thêm => Lưu (sau khi NSD đã nhập đủ các thông tin NS mới)

            }

            else //THÊM NS MỚI VÀO DATABASE VÀ HIỆN LÊN DATAGRIDVIEW

            {   //1. THÊM NS MỚI VÀO DB 

                try

                {

                    //MessageBox.Show(comboBoxID_TK.SelectedValue.ToString());

                    nhanVienTableAdapter.Insert(txtMaNV.Text.Trim(), comboBoxID_TK.SelectedValue.ToString(), comboBoxMaCV.SelectedValue.ToString(), txtHoTenNV.Text.Trim(), DateTime.Parse(dateTimePickerNSNV.Text), txtGioitinh.Text.Trim(), txtDiachi.Text.Trim(), txtSDT.Text.Trim(), txtEmail.Text.Trim(), txtcccd.Text.Trim());

                    MessageBox.Show("THÊM XONG");

                }

                catch (System.Exception ex) { MessageBox.Show("CÓ LỖI KHI THÊM SP MỚI " + ex.Message); }

                //2. TẢI LẠI DL SAU KHI THÊM SP MỚI TỪ DB LÊN DATAGRIDWIEW ĐỂ NSD BIẾT KQ [COPY code TỪ form_load OR Combobox_selectIndexChanhe]

                try

                {

                    // TODO: This line of code loads data into the 'hPStore_SaleDataSetSP.SanPham' table. You can move, or remove it, as needed.

                    this.nhanVienTableAdapter.Fill(this._2121000995_LeThiQuynhTruc_21DTK2DSNV.NhanVien);

                }

                catch (System.Exception) { } //bat moi he thong = tranh truong hop ctr bi dung  dot ngot

                //3. THAY ĐỔI TRANG THÁI THÊM SP MỚI

                //delete pictureBoxSPham.Click;//KHÔNG CHO NSD click vào PictureBoX SPham (Xóa Event Click của PictureBox SPham)

                //pictureBoxSPham.ImageLocation = ""; //GỠ BỎ hình ảnh thông báo chọn hình

                btnThem.Text = "Thêm";//đổi nhãn trả lại Lưu => Thêm (thêm thêm mới NS khác)
            }
        }

        /// <summary>
        /// XÓA THÔNG TIN KHÁCH HÀNG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            //B1: Hỏi xác nhận 
            DialogResult ch = MessageBox.Show("BẠN CHẮC CHẮN MUỐN XÓA : " + txtMaNV.Text.Trim() + ": " + txtHoTenNV.Text.Trim() + "? " + " PHẢI KHÔNG (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //B2: XÓA
            if (ch == DialogResult.Yes)
            {
                try
                {
                    nhanVienTableAdapter.Delete(txtMaNV.Text.Trim());
                    MessageBox.Show("Đã Xóa");

                    // DialogResult c = MessageBox.Show("Có xóa luôn hình không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ch == DialogResult.No)
                    {
                        try
                        {
                            // imagechoose = System.IO.Path.GetFileName(pictureBoxSPham.ImageLocation); //lay ten hinh cu
                            //  System.IO.File.Copy(pictureBoxSPham.ImageLocation, apppath + "Z\\" + imagechoose);
                            // MessageBox.Show("hình cũ copy vao thu muc ...\\Z nha !");
                        }
                        catch (System.Exception ex) { MessageBox.Show("Lỗi xóa hình ra khỏi hệ thống" + ex.Message); }
                    }
                    else
                    {
                        // MessageBox.Show("Xóa hình cũ nha !");
                    }
                    //System.IO.File.Delete(pictureBoxSPham.ImageLocation);//picturebox, imagelocation
                }
                catch (System.Exception ex)// KHÔNG XÓA ĐƯỢC DO CÒN RBTV DL
                {
                    MessageBox.Show("Lỗi xóa nhân viên" + ex.Message);
                    //gọi Form xử lý RBTV trước khi Xóa
                    //Fr2_QLSP fr = new Fr2_QLSP(txtMaSP.Text.Trim(), txtTenSP.Text.Trim());//TRUYỀN masp và tensp SANG FORM XL RBTV
                    //fr.ShowDialog();
                }
            }
            //B3: Tải BD lên DataGridView sau khi xóa
            try
            {
                // Tai ds cac NS vao DataGridView ben duoi theo Nhom NS da chon trong ComboBox phia tren.
                this.nhanVienTableAdapter.Fill(this._2121000995_LeThiQuynhTruc_21DTK2DSNV.NhanVien);
            }
            catch (System.Exception) { }//bat moi he thong = tranh truong hop ctr bi dung  dot ngot
        }

        /// <summary>
        /// SỬA THÔNG TIN KHÁCH HÀNG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
            {//B1: ĐÓNG _ MỞ : ĐƯỢC PHÉP HAY KHÔNG ĐƯỢC SỬA
                //txtMaNV.Enabled = !txtMaNV.Enabled;

               // txtMaNV.Enabled = !txtMaNV.Enabled;

                txtHoTenNV.Enabled = !txtHoTenNV.Enabled;

                txtGioitinh.Enabled = !txtGioitinh.Enabled;

                dateTimePickerNSNV.Enabled = !dateTimePickerNSNV.Enabled;

                txtSDT.Enabled = !txtSDT.Enabled;

                txtDiachi.Enabled = !txtDiachi.Enabled;

                txtEmail.Enabled = !txtEmail.Enabled;

                txtcccd.Enabled = !txtcccd.Enabled;

                comboBoxMaCV.Enabled = !comboBoxMaCV.Enabled;

                comboBoxID_TK.Enabled = !comboBoxID_TK.Enabled; 
                
                //khóa các thao tác khác
                btnThem.Enabled = !btnThem.Enabled;
                btnXoa.Enabled = !btnXoa.Enabled;
                btndong.Enabled = !btndong.Enabled;
                dgvNhanVien.Enabled = !dgvNhanVien.Enabled; //không thay đổi

                if (btnSua.Text == "Sửa")//Bắt đầu sửa
                {
                    //B2: HƯỚNG DẪN CÁCH SỬA
                    // MessageBox.Show("Moi ban sua thong tin");
                    btnSua.Text = "Lưu (Sửa)";
                }
                else //LƯU SAU KHI SỬA XONG
                {
                    try
                    { //B3: lưu DB0
                       // MessageBox.Show(comboBoxID_TK.SelectedValue.ToString());
                        nhanVienTableAdapter.Update(comboBoxID_TK.SelectedValue.ToString(), comboBoxMaCV.SelectedValue.ToString(), txtHoTenNV.Text.Trim(), DateTime.Parse(dateTimePickerNSNV.Text), txtGioitinh.Text.Trim(), txtDiachi.Text.Trim(), txtSDT.Text.Trim(), txtEmail.Text.Trim(), txtcccd.Text.Trim(), txtMaNV.Text.Trim());
                        //MessageBox.Show("Đã sửa xong");
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Có lỗi sửa chữa thông tin nhân viên " + ex.Message);
                    }
                    //B4: ĐỔI NHÃN 
                    btnSua.Text = "Sửa";

                    //B5: Tải BD lên DataGridView sau khi xóa
                    try
                    {
                        // Tai ds cac NS vao DataGridView ben duoi theo Nhom NS da chon trong ComboBox phia tren.
                        this.nhanVienTableAdapter.Fill(this._2121000995_LeThiQuynhTruc_21DTK2DSNV.NhanVien);
                    }
                    catch (System.Exception) { }//bat moi he thong = tranh truong hop ctr bi dung  dot ngot
                }

            }
        }

        //private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    MessageBox.Show("Lỗi dữ liệu: " + e.Exception.Message);
        //    e.ThrowException = false; // Ngăn lỗi làm treo chương trìn
        //}
    }
}
