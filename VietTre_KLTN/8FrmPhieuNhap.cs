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
    public partial class _8FrmPhieuNhap : Form
    {
        private readonly SqlConnection conn = new SqlConnection("Data Source=LAPTOP-84CTG406\\SQLEXPRESS;Initial Catalog=2121000995_LeThiQuynhTruc_21DTK2;Integrated Security=True");
        private SqlDataAdapter da;

        public _8FrmPhieuNhap()
        {
            InitializeComponent();
        }

        private void _8FrmPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Load dữ liệu phiếu nhập
        private void LoadData(string searchKeyword = "")
        {
            try
            {
                string query = @"SELECT ID_PN, ID_SP, SoLuongNhap, DonGiaNhap, GhiChu 
                                 FROM CT_PhieuNhap
                                 WHERE ID_PN LIKE @searchKeyword";
                da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@searchKeyword", "%" + searchKeyword + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPhieuNhap.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        // Thêm phiếu nhập
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"INSERT INTO CT_PhieuNhap (ID_PN, ID_SP, SoLuongNhap, DonGiaNhap, GhiChu)
                                 VALUES (@ID_PN, @ID_SP, @SoLuongNhap, @DonGiaNhap, @GhiChu)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID_PN", txtID.Text.Trim());
                cmd.Parameters.AddWithValue("@ID_SP", txbSp.Text.Trim());
                cmd.Parameters.AddWithValue("@SoLuongNhap", int.Parse(numSP.Value.ToString()));
                cmd.Parameters.AddWithValue("@DonGiaNhap", decimal.Parse(txbDonGia.Text.Trim()));
                cmd.Parameters.AddWithValue("@GhiChu", txbGhiChu.Text.Trim());

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm phiếu nhập thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phiếu nhập: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Sửa phiếu nhập
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"UPDATE CT_PhieuNhap 
                                 SET ID_SP = @ID_SP, SoLuongNhap = @SoLuongNhap, DonGiaNhap = @DonGiaNhap, GhiChu = @GhiChu
                                 WHERE ID_PN = @ID_PN";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID_PN", txtID.Text.Trim());
                cmd.Parameters.AddWithValue("@ID_SP", txbSp.Text.Trim());
                cmd.Parameters.AddWithValue("@SoLuongNhap", int.Parse(numSP.Value.ToString()));
                cmd.Parameters.AddWithValue("@DonGiaNhap", decimal.Parse(txbDonGia.Text.Trim()));
                cmd.Parameters.AddWithValue("@GhiChu", txbGhiChu.Text.Trim());

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật phiếu nhập thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật phiếu nhập: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Xóa phiếu nhập
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu nhập này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string idPN = dgvPhieuNhap.SelectedRows[0].Cells["ID_PN"].Value.ToString();
                    try
                    {
                        string query = "DELETE FROM CT_PhieuNhap WHERE ID_PN = @ID_PN";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ID_PN", idPN);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa phiếu nhập thành công!");
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa phiếu nhập: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu nhập để xóa.");
            }
        }

        // Tìm kiếm phiếu nhập
        //private void btnTimKiem_Click(object sender, EventArgs e)
        //{
        // //   string searchKeyword = txtTimKiem.Text.Trim();
        //    LoadData(searchKeyword);
        //}

        // Load dữ liệu lên textbox khi click vào DataGridView
        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhieuNhap.Rows[e.RowIndex];
                txtID.Text = row.Cells["ID_PN"].Value.ToString();
                txbSp.Text = row.Cells["ID_SP"].Value.ToString();
                numSP.Value = Convert.ToInt32(row.Cells["SoLuongNhap"].Value);
                txbDonGia.Text = row.Cells["DonGiaNhap"].Value.ToString();
                txbGhiChu.Text = row.Cells["GhiChu"].Value.ToString();
            }
        }

        private void _8FrmPhieuNhap_Load_1(object sender, EventArgs e)
        {

        }
    }
}
    