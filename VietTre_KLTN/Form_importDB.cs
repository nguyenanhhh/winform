using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;
using xls = Microsoft.Office.Interop.Excel;

namespace VietTre_KLTN
{
    public partial class Form_importDB : Form
    {
        ////tao mot bang tam de chua du lieu lay tu file excel vao
        //private DataTable oTbl;
        ////mot file de chua thong tin file import
        //private string fileName;

        ////method doc du lieu tu file excel vao datatable oTbl
        //private void readExcel()
        //{
        //    fileName = txtFile.Text;
        //    //kiem tra du lieu fileName da co chua
        //    if (fileName==null)
        //    {
        //        MessageBox.Show("Chua chon File Excel");
        //    }
        //    else
        //    {
        //        //neu da ton tai file excel thi chung ta mo file va doc du lieu vao
        //        xls.Application ExcelApp = new xls.Application();//tao mot ap lam viec moi

        //        //kiem tra xem co mo duoc du lieu tu fileName khong
        //        try
        //        {
        //            ExcelApp.Workbooks.Open(fileName);
        //        }
        //        catch
        //        {
        //            MessageBox.Show("Khong the mo file du lieu");
        //        }

        //        //tao cau truc cho table oTbl
        //        oTbl = new DataTable();
        //        oTbl.Columns.Add("STT", typeof(string));
        //        oTbl.Columns.Add("A", typeof(string));//tao mot cot ten la A cos kieu du lieu string
        //        oTbl.Columns.Add("B", typeof(string));
        //        oTbl.Columns.Add("C", typeof(string));
        //        oTbl.Columns.Add("D", typeof(string));

        //        //doc du lieu tung sheet cura excel
        //        foreach (xls.Worksheet wSheet in ExcelApp.Worksheets)
        //        {
        //            //tao mot datarow de lay du lieu cho tung do
        //            DataRow dr;
        //            //bien i de doc tung dong cua sheet excel
        //            long i = 1;
        //            try
        //            {
        //                do
        //                {
        //                    dynamic dynamic = (wSheet.Range["D" + i].Value == null);
        //                    if (wSheet.Range["A" + i].Value == null && wSheet.Range["B" + i].Value == null && wSheet.Range["C" + i].Value == null && wSheet.Range["D" + i].Value == null)
        //                    {
        //                        break;//neu den dong cuoi cung cura sheet date thi dung lai
        //                    }
        //                    dr = oTbl.NewRow();
        //                    dr["STT"] = i;
        //                    dr["A"] = wSheet.Range["A" + i].Value;
        //                    dr["B"] = wSheet.Range["A" + i].Value;
        //                    dr["C"] = wSheet.Range["A" + i].Value;
        //                    dr["D"] = wSheet.Range["A" + i].Value;
        //                    oTbl.Rows.Add(dr);
        //                    i++;
        //                }
        //                while (true);
        //            }
        //            catch
        //            {
        //                MessageBox.Show("Co loi khi thuc hien");
        //            }
        //        }
        //    }
        //}

        ////viet su kien khi click nut chon
        //private void cmdChon_Click(object sender, EventArgs e)
        //{
        //    //khi click vao nut browse thi se mo ra hop thoai chon file
        //    OpenFileDialog fDialog = new OpenFileDialog();
        //    fDialog.Filter = "excel file |*.xls;*.xlsx";
        //    fDialog.FilterIndex = 1;
        //    fDialog.RestoreDirectory = true;
        //    fDialog.Multiselect = false;
        //    fDialog.Title = "Chon file excel";

        //    if(fDialog.ShowDialog()== DialogResult.OK)
        //    {
        //        //thuc thi method readexcel
        //        readExcel();
        //        //do du lieu vao datagrid
        //        if(oTbl !=null)
        //        {
        //            dataGrid.DataSource = oTbl;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Khong co du lieu");
        //        }
        //    }
        //}
        public Form_importDB()
        {
            InitializeComponent();
        }

        DataTableCollection tableCollection;

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];
            dataGrid.DataSource = dt;
            if(dt!=null)
            {
                List<Class_KhachHang> class_KhachHangs = new List<Class_KhachHang>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Class_KhachHang class_KhachHang = new Class_KhachHang();
                    class_KhachHang.ID_KH = dt.Rows[i]["ID_KH"].ToString();
                    class_KhachHang.HoTenKH = dt.Rows[i]["HoTenKH"].ToString();
                    class_KhachHang.GioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                    class_KhachHang.NgaySinh = dt.Rows[i]["NgaySinh"].ToString();
                    class_KhachHang.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                    class_KhachHang.SDT = dt.Rows[i]["SDT"].ToString();
                    class_KhachHang.MSThue = dt.Rows[i]["MSThue"].ToString();

                }
                khachHangBindingSource.DataSource = class_KhachHangs;
            }
        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "excel file |*.xls;*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFile.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cboSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cboSheet.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e, object ex)
        {

            try
            {
                string connectionString = "Data Source=QUYNHTRUC;Initial Catalog=2121000995_LeThiQuynhTruc_21DTK2;Integrated Security=True";
                DapperPlusManager.Entity<Class_KhachHang>().Table("Khach Hang");
                List<Class_KhachHang> class_KhachHangs = khachHangBindingSource.DataSource as List<Class_KhachHang>;
                if (class_KhachHangs != null)
                {
                    using (IDbConnection db = new SqlConnection(connectionString))
                    {
                        db.BulkInsert(class_KhachHangs);
                    }
                    MessageBox.Show("Finish !!!");
                }
            }
            catch 
            {
                MessageBox.Show("Khong import duoc du lieu");
            }

        }

        private void Form_importDB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_2121000995_LeThiQuynhTruc_21DTK2DSKH.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this._2121000995_LeThiQuynhTruc_21DTK2DSKH.KhachHang);

        }
    }
}
