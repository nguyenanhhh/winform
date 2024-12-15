
namespace VietTre_KLTN
{
    partial class Form_DNKH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this._2121000995_LeThiQuynhTruc_21DTK2DSKH = new VietTre_KLTN._2121000995_LeThiQuynhTruc_21DTK2DSKH();
            this.KhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KhachHangTableAdapter = new VietTre_KLTN._2121000995_LeThiQuynhTruc_21DTK2DSKHTableAdapters.KhachHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._2121000995_LeThiQuynhTruc_21DTK2DSKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DSKH";
            reportDataSource1.Value = this.KhachHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VietTre_KLTN.Report_DSKH.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(43, 44);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(888, 503);
            this.reportViewer1.TabIndex = 0;
            // 
            // _2121000995_LeThiQuynhTruc_21DTK2DSKH
            // 
            this._2121000995_LeThiQuynhTruc_21DTK2DSKH.DataSetName = "_2121000995_LeThiQuynhTruc_21DTK2DSKH";
            this._2121000995_LeThiQuynhTruc_21DTK2DSKH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KhachHangBindingSource
            // 
            this.KhachHangBindingSource.DataMember = "KhachHang";
            this.KhachHangBindingSource.DataSource = this._2121000995_LeThiQuynhTruc_21DTK2DSKH;
            // 
            // KhachHangTableAdapter
            // 
            this.KhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // Form_DNKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 582);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_DNKH";
            this.Text = "Form_DNKH";
            this.Load += new System.EventHandler(this.Form_DNKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this._2121000995_LeThiQuynhTruc_21DTK2DSKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KhachHangBindingSource;
        private _2121000995_LeThiQuynhTruc_21DTK2DSKH _2121000995_LeThiQuynhTruc_21DTK2DSKH;
        private _2121000995_LeThiQuynhTruc_21DTK2DSKHTableAdapters.KhachHangTableAdapter KhachHangTableAdapter;
    }
}