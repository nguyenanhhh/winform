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
    public partial class Form_SelectKH : Form
    {
        public Form_SelectKH()
        {
            InitializeComponent();
        }

        private void Form_SelectKH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_2121000995_LeThiQuynhTruc_21DTK2DSKH.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this._2121000995_LeThiQuynhTruc_21DTK2DSKH.KhachHang);

        }
    }
}
