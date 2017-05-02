namespace Diseño.MPago
{
    partial class FormPagoreporte
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
            this.paReportePagoAlumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtListadoPagos = new Diseño.MPago.dtListadoPagos();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.paReportePagoAlumnoTableAdapter = new Diseño.MPago.dtListadoPagosTableAdapters.paReportePagoAlumnoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.paReportePagoAlumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtListadoPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // paReportePagoAlumnoBindingSource
            // 
            this.paReportePagoAlumnoBindingSource.DataMember = "paReportePagoAlumno";
            this.paReportePagoAlumnoBindingSource.DataSource = this.dtListadoPagos;
            // 
            // dtListadoPagos
            // 
            this.dtListadoPagos.DataSetName = "dtListadoPagos";
            this.dtListadoPagos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "paReportePagoAlumno";
            reportDataSource1.Value = this.paReportePagoAlumnoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Diseño.MPago.ReportePagos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(577, 493);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // paReportePagoAlumnoTableAdapter
            // 
            this.paReportePagoAlumnoTableAdapter.ClearBeforeFill = true;
            // 
            // FormPagoreporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 493);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormPagoreporte";
            this.Text = "FormPagoreporte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPagoreporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paReportePagoAlumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtListadoPagos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource paReportePagoAlumnoBindingSource;
        private dtListadoPagos dtListadoPagos;
        private dtListadoPagosTableAdapters.paReportePagoAlumnoTableAdapter paReportePagoAlumnoTableAdapter;





    }
}