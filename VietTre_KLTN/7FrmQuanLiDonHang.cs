using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VietTre_KLTN
{
    public partial class _7FrmQuanLiDonHang : Form
    {
        private readonly SqlConnection conn = new SqlConnection("Data Source=LAPTOP-84CTG406\\SQLEXPRESS;Initial Catalog=2121000995_LeThiQuynhTruc_21DTK2;Integrated Security=True");
        //LAPTOP-84CTG406\SQLEXPRESS
        //QUYNHTRUC
        private SqlDataAdapter da;

        private String selectedID;
        public _7FrmQuanLiDonHang()
        {
            InitializeComponent();
        }

        private void _7FrmQuanLiDonHang_Load(object sender, EventArgs e)
        {
            LoadData();
            loadDataToAdd();
        }

        public void loadDataToAdd()
        {
            //string query_get_nhanvien = @"select  NhanVien.Id_NV,NhanVien.HoTenNV from NhanVien";

            //string query_get_khachhang = @"select KhachHang.ID_KH,KhachHang.HoTenKH from KhachHang";
            //string query_get_don_hang = @"select DonHang.ID_DH,DonHang.MoTa from DonHang";



            SqlConnection conn = new SqlConnection(Adapter.ConnStr);
            //SqlDataAdapter nhanviens = new SqlDataAdapter(query_get_nhanvien, conn);




            string query_get_nhanvien = @"SELECT NhanVien.Id_NV, NhanVien.HoTenNV FROM NhanVien";
            SqlDataAdapter adapterNhanVien = new SqlDataAdapter(query_get_nhanvien, conn);
            DataTable dtNhanVien = new DataTable();
            adapterNhanVien.Fill(dtNhanVien);

            cbb_nhanvien.DataSource = dtNhanVien;
            cbb_nhanvien.DisplayMember = "HoTenNV";        // Field to display
            cbb_nhanvien.ValueMember = "Id_NV";

            string query_get_khachhang = @"SELECT KhachHang.ID_KH, KhachHang.HoTenKH FROM KhachHang";
            SqlDataAdapter adapterKhachHang = new SqlDataAdapter(query_get_khachhang, conn);
            DataTable dtKhachHang = new DataTable();
            adapterKhachHang.Fill(dtKhachHang);

            cbb_khachhang.DataSource = dtKhachHang;        // Bind data to ComboBox
            cbb_khachhang.DisplayMember = "HoTenKH";       // Field to display
            cbb_khachhang.ValueMember = "ID_KH";
            // Query for DonHang
            string query_get_don_hang = @"SELECT GiaoHang.ID_GH, GiaoHang.NguoiGH FROM GiaoHang";
            SqlDataAdapter adapterDonHang = new SqlDataAdapter(query_get_don_hang, conn);
            DataTable dtDonHang = new DataTable();
            adapterDonHang.Fill(dtDonHang);

            cbb_giaohang.DataSource = dtDonHang;            // Bind data to ComboBox
            cbb_giaohang.DisplayMember = "NguoiGH";            // Field to display
            cbb_giaohang.ValueMember = "ID_GH";
        }
        private void LoadData(string searchKeyword = "")
        {
            try
            {
                string sql = @"SELECT ID_DH, ID_KH, ID_NV, NgayDH, Mota
               FROM DonHang
               WHERE ID_KH LIKE @searchKeyword OR ID_DH LIKE @searchKeyword";


                da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@searchKeyword", "%" + searchKeyword + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDonHang.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchKeyword = tbxTimKiem.Text.Trim(); 
            LoadData(searchKeyword);
        }
        public void themDH(DonHang donHang)
        {
            try
            {
                string sql = @"INSERT INTO DonHang (ID_DH, ID_KH, ID_NV, ID_GH, NgayDH, MoTa)
                               VALUES (@ID_DH, @ID_KH, @ID_NV, @ID_GH, @NgayDH, @MoTa)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID_DH", donHang.ID_DH);
                cmd.Parameters.AddWithValue("@ID_KH", donHang.ID_KH);
                cmd.Parameters.AddWithValue("@ID_NV", donHang.ID_NV);
                cmd.Parameters.AddWithValue("@ID_GH", donHang.ID_GH);
                cmd.Parameters.AddWithValue("@NgayDH", donHang.NgayDH);
                cmd.Parameters.AddWithValue("@MoTa", donHang.MoTa);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Đơn hàng đã được thêm thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm đơn hàng: " + ex.Message);
                conn.Close();
            }
            //TODO: process to insert donhang into database

        }
        public Boolean isValid(DonHang donHang)
        {
            if (string.IsNullOrEmpty(donHang.ID_DH) ||
              string.IsNullOrEmpty(donHang.ID_KH) ||
              string.IsNullOrEmpty(donHang.ID_NV) ||
              string.IsNullOrEmpty(donHang.ID_GH))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return false;
            }
            //TODO: valid donhang
            return true;
        }
        public DonHang getDataFromForm()
        {
            DonHang donHang = new DonHang
            {
                ID_DH = tb_id.Text.Trim(),
                ID_KH = cbb_khachhang.SelectedValue.ToString(),
                ID_NV = cbb_nhanvien.SelectedValue.ToString(),
                ID_GH = cbb_giaohang.SelectedValue.ToString(),
                NgayDH = dtpk_ngay_tao.Value,
                MoTa = tb_mota.Text.Trim()
            };
            return donHang;
        }
        public void suaDH(DonHang donHang)
        {
            try
            {
                string sql = @"UPDATE DonHang
                               SET ID_KH = @ID_KH, ID_NV = @ID_NV, ID_GH = @ID_GH, NgayDH = @NgayDH, MoTa = @MoTa
                               WHERE ID_DH = @ID_DH";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID_DH", donHang.ID_DH);
                cmd.Parameters.AddWithValue("@ID_KH", donHang.ID_KH);
                cmd.Parameters.AddWithValue("@ID_NV", donHang.ID_NV);
                cmd.Parameters.AddWithValue("@ID_GH", donHang.ID_GH);
                cmd.Parameters.AddWithValue("@NgayDH", donHang.NgayDH);
                cmd.Parameters.AddWithValue("@MoTa", donHang.MoTa);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Đơn hàng đã được cập nhật thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật đơn hàng: " + ex.Message);
                conn.Close();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DonHang donHang = getDataFromForm();
            if (isValid(donHang))
            {
                themDH(donHang);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
                DonHang donHang = getDataFromForm();
                if (isValid(donHang))
                {
                    suaDH(donHang);
                }
        }

        // Xử lý sự kiện Xóa đơn hàng
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDonHang.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa đơn hàng này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string idDH = dgvDonHang.SelectedRows[0].Cells["ID_DH"].Value.ToString();
                    string sql = "DELETE FROM DonHang WHERE ID_DH = @ID_DH";
                    try
                    {
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@ID_DH", idDH);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Đơn hàng đã được xóa.");
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa đơn hàng: " + ex.Message);
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một đơn hàng để xóa.");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDonHang.Rows[e.RowIndex];

                // Retrieve the ID_DH (primary key) from the selected row
                string idDonHang = row.Cells["ID_DH"].Value.ToString();

                // Fetch data for the selected DonHang and bind to form
                try
                {
                    string sql = @"SELECT ID_DH, ID_KH, ID_NV, ID_GH, NgayDH, MoTa 
                           FROM DonHang 
                           WHERE ID_DH = @ID_DH";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID_DH", idDonHang);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Binding data to form fields
                        tb_id.Text = reader["ID_DH"].ToString();
                        cbb_khachhang.SelectedValue = reader["ID_KH"].ToString();
                        cbb_nhanvien.SelectedValue = reader["ID_NV"].ToString();
                        cbb_giaohang.SelectedValue = reader["ID_GH"].ToString();
                        dtpk_ngay_tao.Value = Convert.ToDateTime(reader["NgayDH"]);
                        tb_mota.Text = reader["MoTa"].ToString();
                    }

                    reader.Close();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy thông tin đơn hàng: " + ex.Message);
                    conn.Close();
                }
            }
        }

  
        private void tbxTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e); 
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Label 1 clicked!");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Label 2 clicked!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Search button clicked!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDonHang.Rows[e.RowIndex];

                // Retrieve the ID_DH (primary key) from the selected row
                string idDonHang = row.Cells["ID_DH"].Value.ToString();

                // Fetch data for the selected DonHang and bind to form
                try
                {
                    string sql = @"SELECT ID_DH, ID_KH, ID_NV, ID_GH, NgayDH, MoTa 
                           FROM DonHang 
                           WHERE ID_DH = @ID_DH";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID_DH", idDonHang);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Binding data to form fields
                        tb_id.Text = reader["ID_DH"].ToString();
                        cbb_khachhang.SelectedValue = reader["ID_KH"].ToString();
                        cbb_nhanvien.SelectedValue = reader["ID_NV"].ToString();
                        cbb_giaohang.SelectedValue = reader["ID_GH"].ToString();
                        dtpk_ngay_tao.Value = Convert.ToDateTime(reader["NgayDH"]);
                        tb_mota.Text = reader["MoTa"].ToString();
                    }

                    reader.Close();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy thông tin đơn hàng: " + ex.Message);
                    conn.Close();
                }
            }
        }

        private void MaCN_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            DonHang donHang = getDataFromForm();
            if (isValid(donHang))
            {
                themDH(donHang);
            }
        }
    }
}
