using GSF.Adapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VietTre_KLTN
{
    public partial class _5FrmHoaDon : Form
    {
        public _5FrmHoaDon()
        {
            InitializeComponent();
        }
        string selectedID_HD = null;

        private void _5FrmHoaDon_Load(object sender, EventArgs e)
        {
            getAllBill();   
            loadDataToAdd();
        }

        public void clearForm()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    // Clear TextBox content
                    textBox.Clear();
                }
                else if (control is ComboBox comboBox)
                {
                    // Reset ComboBox selection
                    comboBox.SelectedIndex = -1;
                }
                else if (control is DateTimePicker dateTimePicker)
                {
                    // Reset DateTimePicker to today
                    dateTimePicker.Value = DateTime.Now;
                }
            }

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

            cbb_khachhanh.DataSource = dtKhachHang;        // Bind data to ComboBox
            cbb_khachhanh.DisplayMember = "HoTenKH";       // Field to display
            cbb_khachhanh.ValueMember = "ID_KH";
            // Query for DonHang
            string query_get_don_hang = @"SELECT DonHang.ID_DH, DonHang.MoTa FROM DonHang";
            SqlDataAdapter adapterDonHang = new SqlDataAdapter(query_get_don_hang, conn);
            DataTable dtDonHang = new DataTable();
            adapterDonHang.Fill(dtDonHang);

            cbb_don_hang.DataSource = dtDonHang;            // Bind data to ComboBox
            cbb_don_hang.DisplayMember = "ID_DH";            // Field to display
            cbb_don_hang.ValueMember = "ID_DH";
        }

        public Boolean IsValidForm(HoaDoncs invoice)
        {
            // Check if the Invoice object is null
            if (invoice == null)
            {
                return false;
            }

            // Check if any required string property is null or empty
            if (string.IsNullOrWhiteSpace(invoice.ID_HD) ||
                string.IsNullOrWhiteSpace(invoice.ID_KH) ||
                string.IsNullOrWhiteSpace(invoice.ID_NV) ||
                string.IsNullOrWhiteSpace(invoice.ID_DH) ||
                string.IsNullOrWhiteSpace(invoice.MaHD) ||
                string.IsNullOrWhiteSpace(invoice.PTTT))
            {
                return false; // Invalid form if any required string is empty
            }

            // Additional validation for NgayLapHD (date)
            if (invoice.NgayLapHD == DateTime.MinValue)
            {
                return false; // Invalid date if NgayLapHD was not set
            }

            // If all checks pass, return true
            return true;
        }
        public void getAllBill()
        {
            string sql = @"select HoaDon.*, 
                        KhachHang.HoTenKH,
                        KhachHang.DiaChi,
                        KhachHang.SDT as DienThoaiKH,
                        KhachHang.MSThue,
                        NhanVien.SDT as DienThoaiNV,
                        NhanVien.HoTenNV
                        from
                        HoaDon,KhachHang, NhanVien
                        where
                        HoaDon.ID_KH = KhachHang.ID_KH
                        and HoaDon.ID_NV = NhanVien.ID_NV";
            SqlConnection conn = new SqlConnection(Adapter.ConnStr);
            SqlDataAdapter daKhachHang = new SqlDataAdapter(sql, conn);
            DataTable dtHoaDon = new DataTable();
            daKhachHang.Fill(dtHoaDon);
            dgvDSHD.DataSource = dtHoaDon;
        }
        public void addNewBill(HoaDoncs invoice)
        {
            string query = @"INSERT INTO HoaDon (ID_HD, ID_KH, ID_NV, ID_DH, MaHD, GhiChu, PTTT, NgayLapHD) 
                             VALUES (@ID_HD, @ID_KH, @ID_NV, @ID_DH, @MaHD, @GhiChu, @PTTT, @NgayLapHD)";
            try
            {
                // Establish SQL connection
                using (SqlConnection conn = new SqlConnection(Adapter.ConnStr))
                {
                    // Create the command object with the query and connection
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL Injection
                        cmd.Parameters.AddWithValue("@ID_HD", invoice.ID_HD);
                        cmd.Parameters.AddWithValue("@ID_KH", invoice.ID_KH);
                        cmd.Parameters.AddWithValue("@ID_NV", invoice.ID_NV);
                        cmd.Parameters.AddWithValue("@ID_DH", invoice.ID_DH);
                        cmd.Parameters.AddWithValue("@MaHD", invoice.MaHD);
                        cmd.Parameters.AddWithValue("@GhiChu", invoice.GhiChu ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@PTTT", invoice.PTTT ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@NgayLapHD", invoice.NgayLapHD);

                        // Open the connection
                        conn.Open();

                        // Execute the INSERT command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if the insert was successful
                        if (rowsAffected > 0)
                        {
                            getAllBill();
                            clearForm();
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Log or display the exception
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        public void removeBill() {

            if (selectedID_HD != null)
            {
                SqlConnection conn = new SqlConnection(Adapter.ConnStr);
                string query = @"DELETE FROM HoaDon WHERE ID_HD = @ID_HD";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID_HD", selectedID_HD);
                conn.Open();
                cmd.ExecuteNonQuery();
                getAllBill();

                // refresh table
            }
        }
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private static Random random = new Random();

        public static string GenerateID()
        {
            // Fixed prefix
            string prefix = "HD_";

            // Random 4-digit number
            int number = random.Next(1000, 9999);

            // Random 3-character alphanumeric string
            string randomString = GenerateRandomString(4);

            // Combine into final ID
            return $"{prefix}{number}{randomString}";
        }

        private static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                result.Append(chars[random.Next(chars.Length)]);
            }
            return result.ToString();
        }

        public HoaDoncs getDataFromForm()
        {
            HoaDoncs invoice = new HoaDoncs();

            // Auto-generate ID_HD as UUID string
            invoice.ID_HD = GenerateID();

            // Get values from the form controls and bind to the Invoice object
            invoice.MaHD = tb_mhd.Text; // TextBox for MaHD
            invoice.NgayLapHD = dtpk_ngay_tao.Value; // DateTimePicker for NgayTaoHD
            invoice.ID_DH = cbb_don_hang.SelectedValue?.ToString(); // ComboBox for ID_DH
            invoice.ID_NV = cbb_nhanvien.SelectedValue?.ToString(); // ComboBox for ID_NV
            invoice.ID_KH = cbb_khachhanh.SelectedValue?.ToString(); // ComboBox for ID_KH
            invoice.PTTT = tb_ptttt.Text; // TextBox for PTTT
            invoice.GhiChu = tb_ghi_chu.Text; // TextBox for GhiChu

            // Return the populated Invoice object
            return invoice;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MaNV_Click(object sender, EventArgs e)
        {

        }

        private void dgvDSHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // selected row
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow selectedRow = dgvDSHD.Rows[e.RowIndex];
            //     selectedID_HD = selectedRow.Cells["ID_HD"].Value?.ToString();
            //    MessageBox.Show(selectedID_HD, "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HoaDoncs formData = getDataFromForm();

            if (this.IsValidForm(formData))
            {
                addNewBill(formData);
            }
            else
            {
                MessageBox.Show("This is a message to the user.", "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
             "Are you sure you want to proceed?", // Message
             "Confirmation",                     // Title
             MessageBoxButtons.YesNo,            // Buttons
             MessageBoxIcon.Question             // Icon
         );

            // Handle user response
            if (result == DialogResult.Yes)
            {
                removeBill();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void dgvDSHD_RowValidated(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSHD_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            // Check if the state change is due to row selection
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            // Ensure the row is valid
            if (e.Row == null || e.Row.Index < 0) return;

            // Access the selected row using the RowIndex
            DataGridViewRow selectedRow = dgvDSHD.Rows[e.Row.Index];

            // Retrieve the ID_HD value from the "ID_HD" column
            string selectedID_HD = selectedRow.Cells["ID_HD"].Value?.ToString();

            // Display the ID_HD in a MessageBox
            if (!string.IsNullOrEmpty(selectedID_HD))
            {
                this.selectedID_HD = selectedID_HD;
            }
        }
    }
}
