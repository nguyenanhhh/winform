using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VietTre_KLTN
{
    public partial class _9FrmPhieuXuat : Form
    {
        private readonly SqlConnection conn = new SqlConnection("Data Source=LAPTOP-84CTG406\\SQLEXPRESS;Initial Catalog=2121000995_LeThiQuynhTruc_21DTK2;Integrated Security=True");
        private SqlDataAdapter da;

        public _9FrmPhieuXuat()
        {
            InitializeComponent();
        }

        // Load Dữ Liệu
        private void _9FrmPhieuXuat_Load(object sender, EventArgs e)
        {
            LoadPhieuXuatChiTiet();
        }

        private void LoadPhieuXuatChiTiet()
        {
            try
            {
                string query = @"SELECT ID_PX, ID_SP, SoLuongXuat, Ghichu FROM CT_PhieuXuat";
                da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPhieuXuat.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        // Thêm Dữ Liệu
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"INSERT INTO CT_PhieuXuat (ID_PX, ID_SP, SoLuongXuat, Ghichu)
                                 VALUES (@ID_PX, @ID_SP, @SoLuongXuat, @Ghichu)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID_PX", txtID.Text);
                cmd.Parameters.AddWithValue("@ID_SP", txbSp.Text);
                cmd.Parameters.AddWithValue("@SoLuongXuat", int.Parse(numPX.Text));
                cmd.Parameters.AddWithValue("@Ghichu", txbGC.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                LoadPhieuXuatChiTiet();
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
            }
        }

        // Sửa Dữ Liệu
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"UPDATE CT_PhieuXuat
                                 SET ID_SP = @ID_SP, SoLuongXuat = @SoLuongXuat, Ghichu = @Ghichu
                                 WHERE ID_PX = @ID_PX";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID_PX", txtID.Text);
                cmd.Parameters.AddWithValue("@ID_SP", txbSp.Text);
                cmd.Parameters.AddWithValue("@SoLuongXuat", int.Parse(numPX.Text));
                cmd.Parameters.AddWithValue("@Ghichu", txbGC.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                LoadPhieuXuatChiTiet();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message);
            }
        }

        // Xóa Dữ Liệu
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhieuXuat.SelectedRows.Count > 0)
            {
                string idPX = dgvPhieuXuat.SelectedRows[0].Cells["ID_PX"].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa phiếu xuất này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string query = "DELETE FROM CT_PhieuXuat WHERE ID_PX = @ID_PX";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ID_PX", idPX);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        LoadPhieuXuatChiTiet();
                        MessageBox.Show("Xóa thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
            }
        }

        // Tìm Kiếm Dữ Liệu
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT * FROM CT_PhieuXuat
                                 WHERE ID_PX LIKE @ID_PX";
                da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@ID_PX", "%" + txbTimKiem.Text + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPhieuXuat.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        // Click Dòng DataGridView để Load Lên TextBox
        private void dgvPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhieuXuat.Rows[e.RowIndex];
                txtID.Text = row.Cells["ID_PX"].Value.ToString();
                txtIDSP.Text = row.Cells["ID_SP"].Value.ToString();
                numPX.Text = row.Cells["SoLuongXuat"].Value.ToString();
                txbGC.Text = row.Cells["Ghichu"].Value.ToString();
            }
        }

        private void tbxTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txbIdsp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
