using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace VietTre_KLTN
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
            txtmk.UseSystemPasswordChar = true;
        }

        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (txtdangnhap.Text != string.Empty || txtmk.Text != string.Empty)
            {
                //SELECT* FROM TaiKhoan WHERE TenTK = 'Admin' and MatKhau = '123@'
                //cmd = new SqlCommand("SELECT * FROM TaiKhoan WHERE TenTK='" + txtdangnhap.Text + "' and MatKhau='" + txtmk.Text + "'", cn);
                cmd = new SqlCommand("SELECT * FROM TaiKhoanDangNhap WHERE TenTK='" + txtdangnhap.Text + "' and MatKhau='" + txtmk.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    FormMain home = new FormMain();
                    home.Show();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Không có tài khoản nào có tên đăng nhập và mật khẩu này ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập giá trị vào tất cả các ô.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_2121000995_LeThiQuynhTruc_21DTK2DSTK.TaiKhoanDangNhap' table. You can move, or remove it, as needed.
            //this.taiKhoanDangNhapTableAdapter.Fill(this._2121000995_LeThiQuynhTruc_21DTK2DSTK.TaiKhoanDangNhap);
            cn = new SqlConnection(@"Data Source=LAPTOP-84CTG406\SQLEXPRESS;Initial Catalog=2121000995_LeThiQuynhTruc_21DTK2;Integrated Security=True");
            cn.Open();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thiệt thoát không (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo,
                                                                                  MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                System.Windows.Forms.Application.ExitThread();
            }
        }

    }
}
