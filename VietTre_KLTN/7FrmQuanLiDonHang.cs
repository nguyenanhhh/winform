using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VietTre_KLTN
{
    public partial class _7FrmQuanLiDonHang : Form
    {
        private readonly SqlConnection conn = new SqlConnection("Data Source=QUYNHTRUC;Initial Catalog=2121000995_LeThiQuynhTruc_21DTK2;Integrated Security=True");
        private SqlDataAdapter da;

        public _7FrmQuanLiDonHang()
        {
            InitializeComponent();
        }

        private void _7FrmQuanLiDonHang_Load(object sender, EventArgs e)
        {
            LoadData();
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemDonHang formThem = new FormThemDonHang();
            formThem.ShowDialog();
            LoadData();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvDonHang.SelectedRows.Count > 0)
            {
                int maDonHang = Convert.ToInt32(dgvDonHang.SelectedRows[0].Cells[0].Value);
           
                 //FormCapNhatDonHang formCapNhat = new FormCapNhatDonHang(maDonHang);
                 //formCapNhat.ShowDialog();
                LoadData(); 
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một đơn hàng để cập nhật.");
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
                    int maDonHang = Convert.ToInt32(dgvDonHang.SelectedRows[0].Cells[0].Value);
                    string sql = "DELETE FROM DonHang WHERE MaDonHang = @MaDonHang";
                    try
                    {
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@MaDonHang", maDonHang);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Đơn hàng đã được xóa.");
                        LoadData(); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa đơn hàng: " + ex.Message);
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
     
                string maDonHang = row.Cells["MaDonHang"].Value.ToString();
              
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
            MessageBox.Show("Cell content clicked!");
        }
    }
}
