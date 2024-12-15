using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using VietTre_KLTN._2121000995_LeThiQuynhTruc_21DTK2DSSPTableAdapters;
using System.Reflection.Emit;

namespace VietTre_KLTN
{
    public partial class _3FrmDMSanPham : Form
    {
        public _3FrmDMSanPham()
        {
            InitializeComponent();
        }

        static string old_image, imagechoose = "";//Biến toàn cục Lưu tên file hình mà NSD đã chọn (Thêm/Sửa) đối với PictureBox
        string apppath = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(Application.StartupPath)) + "\\image\\"; //BIẾN TOÀN CỤC LƯU ĐƯỜNG DẪN ĐẾN THƯ MỤC LƯU APP BÀI LÀM NAY

        private void _3FrmDMSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_2121000995_LeThiQuynhTruc_21DTK2DSHSP.HieuSanPham' table. You can move, or remove it, as needed.
            this.hieuSanPhamTableAdapter.Fill(this._2121000995_LeThiQuynhTruc_21DTK2DSHSP.HieuSanPham);
            // TODO: This line of code loads data into the '_2121000995_LeThiQuynhTruc_21DTK2DSLSP.LoaiSanPham' table. You can move, or remove it, as needed.
            this.loaiSanPhamTableAdapter.Fill(this._2121000995_LeThiQuynhTruc_21DTK2DSLSP.LoaiSanPham);
            // TODO: This line of code loads data into the '_2121000995_LeThiQuynhTruc_21DTK2DSSP.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this._2121000995_LeThiQuynhTruc_21DTK2DSSP.SanPham);
            //textBoxNhap_TextChanged(sender, e);
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

        private void manhinhchinh_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn chắc chắn quay về màn hình chính không (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                this.Close();
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
            txtID_SP.Enabled = !txtID_SP.Enabled;
            txtTenSP.Enabled = !txtTenSP.Enabled;
            txtMaSP.Enabled = !txtMaSP.Enabled;
            txtGiaSP.Enabled = !txtGiaSP.Enabled;
            txtGiaKM.Enabled = !txtGiaKM.Enabled;
            txtMausac.Enabled = !txtMausac.Enabled;
            txtChatlieu.Enabled = !txtChatlieu.Enabled;
            txtTrangThaiSP.Enabled = !txtTrangThaiSP.Enabled;
            txtMota.Enabled = !txtMota.Enabled;
           // textBoxNhap.Enabled = !textBoxNhap.Enabled;
            comboBoxID_LSP.Enabled = !comboBoxID_LSP.Enabled;
            comboBoxID_HSP.Enabled = !comboBoxID_HSP.Enabled;
            //khóa các nút lệnh khác (ngoại trừ được Đóng form)
            btnXoa.Enabled = !btnXoa.Enabled;
            btnSua.Enabled = !btnSua.Enabled;
            btndong.Enabled = !btndong.Enabled;
            dgvSanPham.Enabled = !dgvSanPham.Enabled; //không thay đổi

            if (btnThem.Text == "Thêm")//CHUẨN BỊ THÊM KH
            {
                //XÓA CÁC Ô TEXTBOX TRONG CHI TIẾT Ơ BÊN TRÊN ĐỂ CHUẨN BỊ CHO NSD NHẬP THÔNG TIN KH MỚI
                txtID_SP.Text = "";
                txtTenSP.Text = "";
                txtMaSP.Text = "";
                txtGiaSP.Text = "";
                txtGiaKM.Text = "";
                txtMausac.Text = "";
                txtChatlieu.Text = "";
                txtTrangThaiSP.Text = "";
                txtMota.Text = "";
                //textBoxNhap.Text = "";
                btnThem.Text = "Lưu";
                //đổi nhãn Thêm => Lưu (sau khi NSD đã nhập đủ các thông tin KH mới)

                //MessageBox.Show("Bạn vui lòng nhập thông tin vào các ô bên trong màn hình");
                pictureBoxSPham.ImageLocation = apppath + "chooseimage.png";
                //hiện hình ảnh thông báo NSD chọn hình
                pictureBoxSPham.Click += new EventHandler(pictureBoxSPham_Click);
                btnThem.Text = "Lưu";
                //đổi nhãn Thêm => Lưu (sau khi NSD đã nhập đủ các thông tin NS mới)
            }
            else //THÊM KH MỚI VÀO DATABASE VÀ HIỆN LÊN DATAGRIDVIEW
            {   //1. THÊM KH MỚI VÀO DB 
                try
                {
                    //MessageBox.Show(comboBoxMaLSP.SelectedValue.ToString());
                    sanPhamTableAdapter.Insert(txtID_SP.Text.Trim(),comboBoxID_LSP.SelectedValue.ToString(), comboBoxID_HSP.SelectedValue.ToString(), txtMaSP.Text.Trim(), txtTenSP.Text.Trim(), apppath + imagechoose, txtGiaSP.Text.Trim(), txtGiaKM.Text.Trim(), txtGiaKM.Text.Trim(), txtChatlieu.Text.Trim(), txtTrangThaiSP.Text.Trim(), txtMota.Text.Trim());
                    MessageBox.Show("THÊM XONG");
                }
                catch (System.Exception ex) { MessageBox.Show("CÓ LỖI KHI THÊM SẢN PHẨM MỚI " + ex.Message); }

                //2. TẢI LẠI DL SAU KHI THÊM KH MỚI TỪ DB LÊN DATAGRIDWIEW ĐỂ NSD BIẾT KQ [COPY code TỪ form_load OR Combobox_selectIndexChanhe]
                try
                {
                    // TODO: This line of code loads data into the '_2121000995_LeThiQuynhTruc_21DTK2DSKH.KhachHang' table. You can move, or remove it, as needed.
                    this.sanPhamTableAdapter.Fill(this._2121000995_LeThiQuynhTruc_21DTK2DSSP.SanPham);
                    //textBoxNhap_TextChanged(sender, e);
                }
                catch (System.Exception) { } //bat moi he thong = tranh truong hop ctr bi dung  dot ngot

                //3. THAY ĐỔI TRANG THÁI THÊM KH MỚI
                btnThem.Text = "Thêm";//đổi nhãn trả lại Lưu => Thêm (thêm thêm mới KH khác)
                pictureBoxSPham.Click -= pictureBoxSPham_Click;//đổi nhãn trả lại Lưu => Thêm 
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
            DialogResult ch = MessageBox.Show("BẠN CHẮC CHẮN MUỐN XÓA : " + txtID_SP.Text.Trim() + ": " + txtTenSP.Text.Trim() + "? " + " PHẢI KHÔNG (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //B2: XÓA
            if (ch == DialogResult.Yes)
            {
                try
                {
                    sanPhamTableAdapter.Delete(txtID_SP.Text.Trim());
                    MessageBox.Show("Đã Xóa");
                    //textBoxNhap_TextChanged(sender, e);

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
                this.sanPhamTableAdapter.Fill(this._2121000995_LeThiQuynhTruc_21DTK2DSSP.SanPham);
            }
            catch (System.Exception) { }//bat moi he thong = tranh truong hop ctr bi dung  dot ngot
        }

        private void pictureBoxSPham_Click(object sender, EventArgs e)
        {
            DialogResult ch = openFileDialogHinh.ShowDialog();
            if (ch == DialogResult.OK)//NSD đồng ý với hình đã chọn
            {
                //1. Lưu tên file của hình vừa copy nêu trên vào biến toàn cục để sau này (Thêm/Sửa) sẽ cập nhật vào thuộc tính hinh trong Table DMVHP của DB
                imagechoose = System.IO.Path.GetFileName(openFileDialogHinh.FileName);//chỉ lấy tên file ko lấy đường dẫn

                //2. Copy hình vừa chọn vào thư mục hình anh_vhp của App (để sau này Copy App đi nơi khác thư mục hình sẽ tự đi theo)
                try
                {
                    System.IO.File.Copy(openFileDialogHinh.FileName, apppath + imagechoose, true);//true = "chồng" lên hình cũ (nếu đã có)
                    pictureBoxSPham.ImageLocation = apppath + imagechoose;
                }
                catch (System.Exception ex) { MessageBox.Show("Có lỗi sao chép hình vào thư mục của App" + ex.Message); }
            }
        }

        //private void textBoxNhap_TextChanged(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'kTBH_HANGHOA.sp_select_HANGHOA' table. You can move, or remove it, as needed.
        //    this.sanPhamTableAdapter.Fill(_2121000995_LeThiQuynhTruc_21DTK2DSSP.SanPham, textBoxNhap.Text);
        //}

        /// <summary>
        /// SỬA THÔNG TIN KHÁCH HÀNG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
            {//B1: ĐÓNG _ MỞ : ĐƯỢC PHÉP HAY KHÔNG ĐƯỢC SỬA

                //txtID_SP.Enabled = !txtID_SP.Enabled;
                txtTenSP.Enabled = !txtTenSP.Enabled;
                txtMaSP.Enabled = !txtMaSP.Enabled;
                txtGiaSP.Enabled = !txtGiaSP.Enabled;
                txtGiaKM.Enabled = !txtGiaKM.Enabled;
                txtMausac.Enabled = !txtMausac.Enabled;
                txtChatlieu.Enabled = !txtChatlieu.Enabled;
                txtTrangThaiSP.Enabled = !txtTrangThaiSP.Enabled;
                txtMota.Enabled = !txtMota.Enabled;
                //textBoxNhap.Enabled = !textBoxNhap.Enabled;
                comboBoxID_LSP.Enabled = !comboBoxID_LSP.Enabled;
                comboBoxID_HSP.Enabled = !comboBoxID_HSP.Enabled;
                //khóa các nút lệnh khác (ngoại trừ được Đóng form)
                btnThem.Enabled = !btnThem.Enabled;
                btnXoa.Enabled = !btnXoa.Enabled;
                btndong.Enabled = !btndong.Enabled;
                dgvSanPham.Enabled = !dgvSanPham.Enabled; //không thay đổi

                if (btnSua.Text == "Sửa")//Bắt đầu sửa
                {
                    //B2: HƯỚNG DẪN CÁCH SỬA
                    // MessageBox.Show("Moi ban sua thong tin");
                    //MessageBox.Show("Bạn vui lòng sửa vào các ô bên dưới");
                    old_image = System.IO.Path.GetFileName(pictureBoxSPham.ImageLocation);
                    pictureBoxSPham.ImageLocation = apppath + "chooseimage.png";
                    pictureBoxSPham.Click += new EventHandler(pictureBoxSPham_Click);

                    btnSua.Text = "Lưu (Sửa)";
                }
                else //LƯU SAU KHI SỬA XONG
                {
                    if (imagechoose == "") imagechoose = old_image;
                    try
                    { //B3: lưu DB0
                      // MessageBox.Show(comboBoxID_TK.SelectedValue.ToString());
                        sanPhamTableAdapter.Update(comboBoxID_LSP.SelectedValue.ToString(), comboBoxID_HSP.SelectedValue.ToString(), txtMaSP.Text.Trim(), txtTenSP.Text.Trim(), apppath + imagechoose, txtGiaSP.Text.Trim(), txtGiaKM.Text.Trim(), txtMausac.Text.Trim(), txtChatlieu.Text.Trim(), txtTrangThaiSP.Text.Trim(), txtMota.Text.Trim(), txtID_SP.Text.Trim());
                        MessageBox.Show("Đã sửa xong");
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Có lỗi sửa chữa thông tin sản phẩm " + ex.Message);
                    }
                    try
                    {
                        // Tai ds cac NS vao DataGridView ben duoi theo Nhom NS da chon trong ComboBox phia tren.
                        this.sanPhamTableAdapter.Fill(this._2121000995_LeThiQuynhTruc_21DTK2DSSP.SanPham);
                       // textBoxNhap_TextChanged(sender, e);
                    }
                    catch (System.Exception) { }//bat moi he thong = tranh truong hop ctr bi dung  dot ngot

                    pictureBoxSPham.Click -= pictureBoxSPham_Click;//KHÔNG CHO NSD click vào PictureBoX hình (Xóa Event Click của PictureBox Hình)
                                                      //pictureBoxHinh.ImageLocation = ""; //GỠ BỎ hình ảnh thông báo chọn hình
                    btnSua.Text = "Sửa";//đổi nhãn trả lại Lưu => Sửa (thêm sửa NS khác)

                }
            }
        }
    }
}
