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

        private void _5FrmHoaDon_Load(object sender, EventArgs e)
        {
            string sql = @" select 
                        select HoaDon.*, 
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
    }
}
