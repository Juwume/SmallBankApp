namespace SmallBankApp
{
    partial class ExReportForm
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
            this.SmallBankDataSet = new SmallBankApp.SmallBankDataSet();
            this.FizFacesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FizFacesTableAdapter = new SmallBankApp.SmallBankDataSetTableAdapters.FizFacesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SmallBankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FizFacesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.FizFacesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SmallBankApp.ExReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // SmallBankDataSet
            // 
            this.SmallBankDataSet.DataSetName = "SmallBankDataSet";
            this.SmallBankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FizFacesBindingSource
            // 
            this.FizFacesBindingSource.DataMember = "FizFaces";
            this.FizFacesBindingSource.DataSource = this.SmallBankDataSet;
            // 
            // FizFacesTableAdapter
            // 
            this.FizFacesTableAdapter.ClearBeforeFill = true;
            // 
            // ExReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ExReportForm";
            this.Text = "ExReportForm";
            this.Load += new System.EventHandler(this.ExReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SmallBankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FizFacesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FizFacesBindingSource;
        private SmallBankDataSet SmallBankDataSet;
        private SmallBankDataSetTableAdapters.FizFacesTableAdapter FizFacesTableAdapter;
    }
}