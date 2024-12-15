
namespace VietTre_KLTN
{
    partial class Form_DSNV
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
            this._2121000995_LeThiQuynhTruc_21DTK2DSNV = new VietTre_KLTN._2121000995_LeThiQuynhTruc_21DTK2DSNV();
            this.NhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NhanVienTableAdapter = new VietTre_KLTN._2121000995_LeThiQuynhTruc_21DTK2DSNVTableAdapters.NhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._2121000995_LeThiQuynhTruc_21DTK2DSNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetNhanVien";
            reportDataSource1.Value = this.NhanVienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VietTre_KLTN.Report_DSNV.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(36, 28);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1131, 654);
            this.reportViewer1.TabIndex = 0;
            // 
            // _2121000995_LeThiQuynhTruc_21DTK2DSNV
            // 
            this._2121000995_LeThiQuynhTruc_21DTK2DSNV.DataSetName = "_2121000995_LeThiQuynhTruc_21DTK2DSNV";
            this._2121000995_LeThiQuynhTruc_21DTK2DSNV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NhanVienBindingSource
            // 
            this.NhanVienBindingSource.DataMember = "NhanVien";
            this.NhanVienBindingSource.DataSource = this._2121000995_LeThiQuynhTruc_21DTK2DSNV;
            // 
            // NhanVienTableAdapter
            // 
            this.NhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // Form_DSNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 694);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_DSNV";
            this.Text = "Form_DSNV";
            this.Load += new System.EventHandler(this.Form_DSNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this._2121000995_LeThiQuynhTruc_21DTK2DSNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NhanVienBindingSource;
        private _2121000995_LeThiQuynhTruc_21DTK2DSNV _2121000995_LeThiQuynhTruc_21DTK2DSNV;
        private _2121000995_LeThiQuynhTruc_21DTK2DSNVTableAdapters.NhanVienTableAdapter NhanVienTableAdapter;
    }
}