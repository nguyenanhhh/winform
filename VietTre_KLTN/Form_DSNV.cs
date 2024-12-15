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
    public partial class Form_DSNV : Form
    {
        public Form_DSNV()
        {
            InitializeComponent();
        }

        private void Form_DSNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_2121000995_LeThiQuynhTruc_21DTK2DSNV.NhanVien' table. You can move, or remove it, as needed.
            this.NhanVienTableAdapter.Fill(this._2121000995_LeThiQuynhTruc_21DTK2DSNV.NhanVien);

            this.reportViewer1.RefreshReport();
        }
    }
}
