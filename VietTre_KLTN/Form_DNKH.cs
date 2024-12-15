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
    public partial class Form_DNKH : Form
    {
        public Form_DNKH()
        {
            InitializeComponent();
        }

        private void Form_DNKH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_2121000995_LeThiQuynhTruc_21DTK2DSKH.KhachHang' table. You can move, or remove it, as needed.
            this.KhachHangTableAdapter.Fill(this._2121000995_LeThiQuynhTruc_21DTK2DSKH.KhachHang);

            this.reportViewer1.RefreshReport();
        }
    }
}
