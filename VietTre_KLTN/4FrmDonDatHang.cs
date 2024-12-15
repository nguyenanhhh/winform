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
    public partial class _4FrmDonDatHang : Form
    {
        public _4FrmDonDatHang()
        {
            InitializeComponent();
        }
        public string makhachhang = "";
        public _4FrmDonDatHang(string makh)
        {
            InitializeComponent();
            makhachhang = makh;
        }
        private void _4FrmDonDatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_2121000995_LeThiQuynhTruc_21DTK2DSDH1.DonHang' table. You can move, or remove it, as needed.
            this.donHangTableAdapter1.Fill(this._2121000995_LeThiQuynhTruc_21DTK2DSDH1.DonHang);
            // TODO: This line of code loads data into the '_2121000995_LeThiQuynhTruc_21DTK2DSGH.GiaoHang' table. You can move, or remove it, as needed.
            this.giaoHangTableAdapter.Fill(this._2121000995_LeThiQuynhTruc_21DTK2DSGH.GiaoHang);
            // TODO: This line of code loads data into the '_2121000995_LeThiQuynhTruc_21DTK2DSNV.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this._2121000995_LeThiQuynhTruc_21DTK2DSNV.NhanVien);
            // TODO: This line of code loads data into the '_2121000995_LeThiQuynhTruc_21DTK2DSKH.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this._2121000995_LeThiQuynhTruc_21DTK2DSKH.KhachHang);
            // TODO: This line of code loads data into the '_2121000995_LeThiQuynhTruc_21DTK2DSDH.DonHang' table. You can move, or remove it, as needed.
            this.donHangTableAdapter.Fill(this._2121000995_LeThiQuynhTruc_21DTK2DSDH.DonHang);
            // TODO: This line of code loads data into the '_2121000995_LeThiQuynhTruc_21DTK2DSSP.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this._2121000995_LeThiQuynhTruc_21DTK2DSSP.SanPham);
            // TODO: This line of code loads data into the '_2121000995_LeThiQuynhTruc_21DTK2DSCTDH.CT_DonHang' table. You can move, or remove it, as needed.
            this.cT_DonHangTableAdapter.Fill(this._2121000995_LeThiQuynhTruc_21DTK2DSCTDH.CT_DonHang);
            comboBoxKH.ValueMember = "";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Form_SelectKH fr = new Form_SelectKH();
            fr.ShowDialog();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Cells[2].Value.ToString() == "")
                {
                    MessageBox.Show("Không thể lập đơn đặt hàng với sản phẩm chưa có giá bán");
                }
                else
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row = dataGridView1.CurrentRow;
                    dataGridView2.Rows.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[3].Value.ToString(), "", row.Cells[2].Value, "", row.Cells[4].Value.ToString(), "", row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString());
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                }
            }
            catch { }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView2.CurrentRow;

                DataTable dt = new DataTable();
                //dt = this.kTBH_HH_DDH.sp_select_HH_DDH;

                dt.Rows.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[8].Value.ToString(), row.Cells[9].Value.ToString(), row.Cells[4].Value);
                dataGridView1.DataSource = dt;
                dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            }
            catch { }
        }
    }
}
