namespace EnrollmentSystemProject.EnrollmentSystem.Forms
{
    partial class PolicyReportForm
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
            this.pAYMENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.policyIncomeDataSet = new EnrollmentSystemProject.PolicyIncomeDataSet();
            this.pAYMENTSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pAYMENTSTableAdapter = new EnrollmentSystemProject.PolicyIncomeDataSetTableAdapters.PAYMENTSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pAYMENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyIncomeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYMENTSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pAYMENTSBindingSource
            // 
            this.pAYMENTSBindingSource.DataMember = "PAYMENTS";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PolicyDataSet";
            reportDataSource1.Value = this.pAYMENTSBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EnrollmentSystemProject.PolicyIncomeReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1363, 1324);
            this.reportViewer1.TabIndex = 0;
            // 
            // policyIncomeDataSet
            // 
            this.policyIncomeDataSet.DataSetName = "PolicyIncomeDataSet";
            this.policyIncomeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pAYMENTSBindingSource1
            // 
            this.pAYMENTSBindingSource1.DataMember = "PAYMENTS";
            this.pAYMENTSBindingSource1.DataSource = this.policyIncomeDataSet;
            // 
            // pAYMENTSTableAdapter
            // 
            this.pAYMENTSTableAdapter.ClearBeforeFill = true;
            // 
            // PolicyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 1324);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PolicyReportForm";
            this.Text = "PolicyReportForm";
            this.Load += new System.EventHandler(this.PolicyReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pAYMENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyIncomeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYMENTSBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pAYMENTSBindingSource;
        private PolicyIncomeDataSet policyIncomeDataSet;
        private System.Windows.Forms.BindingSource pAYMENTSBindingSource1;
        private PolicyIncomeDataSetTableAdapters.PAYMENTSTableAdapter pAYMENTSTableAdapter;
    }
}