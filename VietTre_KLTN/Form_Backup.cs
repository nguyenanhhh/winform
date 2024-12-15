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

namespace VietTre_KLTN
{
    public partial class Form_Backup : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=QUYNHTRUC;Initial Catalog=2121000995_LeThiQuynhTruc_21DTK2;Integrated Security=True");
        public Form_Backup()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtBackup.Text = dlg.SelectedPath;
                btnBak.Enabled = true;
            }
        }

        private void btnBak_Click(object sender, EventArgs e)
        {
            string database = conn.Database.ToString();
            if (txtBackup.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập vị trí file sao lưu");
            }
            else
            {
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK= '" + txtBackup.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".bak'";
                conn.Open();
                SqlCommand command = new SqlCommand(cmd, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Đã sao lưu dữ liệu thành công");
                conn.Close();
                btnBak.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn chắc chắn quay về màn hình chính không (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn chắc chắn thoát chương trình không (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
