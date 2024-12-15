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
    public partial class _2FrmDMKhachHang : Form
    {
        public _2FrmDMKhachHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn chắc chắn quay về màn hình chính không (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //private void btnDong_Click(object sender, EventArgs e)
        //{
        //    DialogResult ch = MessageBox.Show("Thiệt đóng màn hình không (Y/N)", "Xác nhận",
        //                               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (ch == DialogResult.Yes)
        //    {
        //        Application.Exit();
        //    }
        //}

        private void _2FrmDMKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_2121000995_LeThiQuynhTruc_21DTK2DSKH.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this._2121000995_LeThiQuynhTruc_21DTK2DSKH.KhachHang);

        }

        private void button2_Click(object sender, EventArgs e)
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
            //B1: ĐÓNG _ MỞ : ĐƯỢC PHÉP HAY KHÔNG ĐƯỢC THAY ĐỔI CÁC TEXTBOX THÔNG TIN KHÁCH HÀNG
            txtMaKH.Enabled = !txtMaKH.Enabled;
            txtTenKH.Enabled = !txtTenKH.Enabled;
            txtGioitinh.Enabled = !txtGioitinh.Enabled;
            dateTimePickerNSKH.Enabled = !dateTimePickerNSKH.Enabled;
            txtSDT.Enabled = !txtSDT.Enabled;
            txtDiachi.Enabled = !txtDiachi.Enabled;
            txtMSThue.Enabled = !txtMSThue.Enabled;
            //khóa các nút lệnh khác (ngoại trừ được Đóng form)
            btnXoa.Enabled = !btnXoa.Enabled;
            btnSua.Enabled = !btnSua.Enabled;
            btndong.Enabled = !btndong.Enabled;
            dgvkhachhang.Enabled = !dgvkhachhang.Enabled; //không thay đổi

            if (btnThem.Text == "Thêm")//CHUẨN BỊ THÊM KH
            {
                //XÓA CÁC Ô TEXTBOX TRONG CHI TIẾT Ơ BÊN TRÊN ĐỂ CHUẨN BỊ CHO NSD NHẬP THÔNG TIN KH MỚI
                txtMaKH.Text = "";
                txtTenKH.Text = "";
                txtGioitinh.Text = "";
                txtSDT.Text = "";
                txtDiachi.Text = "";
                txtMSThue.Text = "";
                btnThem.Text = "Lưu";
                //đổi nhãn Thêm => Lưu (sau khi NSD đã nhập đủ các thông tin KH mới)
            }
            else //THÊM KH MỚI VÀO DATABASE VÀ HIỆN LÊN DATAGRIDVIEW
            {   //1. THÊM KH MỚI VÀO DB 
                try
                {
                    //MessageBox.Show(comboBoxMaLSP.SelectedValue.ToString());
                    khachHangTableAdapter.Insert(txtMaKH.Text.Trim(), txtTenKH.Text.Trim(), txtGioitinh.Text.Trim(), dateTimePickerNSKH.Text, txtDiachi.Text.Trim(), txtSDT.Text.Trim(), txtMSThue.Text.Trim());
                    MessageBox.Show("THÊM XONG");
                }
                catch (System.Exception ex) { MessageBox.Show("CÓ LỖI KHI THÊM NCC MỚI " + ex.Message); }

                //2. TẢI LẠI DL SAU KHI THÊM KH MỚI TỪ DB LÊN DATAGRIDWIEW ĐỂ NSD BIẾT KQ [COPY code TỪ form_load OR Combobox_selectIndexChanhe]
                try
                {
                    // TODO: This line of code loads data into the '_2121000995_LeThiQuynhTruc_21DTK2DSKH.KhachHang' table. You can move, or remove it, as needed.
                    this.khachHangTableAdapter.Fill(this._2121000995_LeThiQuynhTruc_21DTK2DSKH.KhachHang);
                }
                catch (System.Exception) { } //bat moi he thong = tranh truong hop ctr bi dung  dot ngot

                //3. THAY ĐỔI TRANG THÁI THÊM KH MỚI
                btnThem.Text = "Thêm";//đổi nhãn trả lại Lưu => Thêm (thêm thêm mới KH khác)
            }
        }

        /// <summary>
        /// XÓA THÔNG TIN KHÁCH HÀNG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            //B1: Hỏi xác nhận 
            DialogResult ch = MessageBox.Show("BẠN CHẮC CHẮN MUỐN XÓA : " + txtMaKH.Text.Trim() + ": " + txtTenKH.Text.Trim() + "? " + " PHẢI KHÔNG (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //B2: XÓA
            if (ch == DialogResult.Yes)
            {
                try
                {
                    khachHangTableAdapter.Delete(txtMaKH.Text.Trim());
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
                this.khachHangTableAdapter.Fill(this._2121000995_LeThiQuynhTruc_21DTK2DSKH.KhachHang);
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

                //txtMaKH.Enabled = !txtMaKH.Enabled;
                txtTenKH.Enabled = !txtTenKH.Enabled;

                txtGioitinh.Enabled = !txtGioitinh.Enabled;

                dateTimePickerNSKH.Enabled = !dateTimePickerNSKH.Enabled;

                txtSDT.Enabled = !txtSDT.Enabled;

                txtDiachi.Enabled = !txtDiachi.Enabled;

                txtMSThue.Enabled = !txtMSThue.Enabled;
                //khóa các nút lệnh khác (ngoại trừ được Đóng form)
                btnThem.Enabled = !btnThem.Enabled;
                btnXoa.Enabled = !btnXoa.Enabled;
                btndong.Enabled = !btndong.Enabled;
                dgvkhachhang.Enabled = !dgvkhachhang.Enabled; //không thay đổi

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
                        khachHangTableAdapter.Update(txtTenKH.Text.Trim(), txtGioitinh.Text.Trim(), dateTimePickerNSKH.Text, txtDiachi.Text.Trim(), txtSDT.Text.Trim(), txtMSThue.Text.Trim(), txtMaKH.Text.Trim());
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
                        this.khachHangTableAdapter.Fill(this._2121000995_LeThiQuynhTruc_21DTK2DSKH.KhachHang);
                    }
                    catch (System.Exception) { }//bat moi he thong = tranh truong hop ctr bi dung  dot ngot
                }

            }
        }
    }
}
