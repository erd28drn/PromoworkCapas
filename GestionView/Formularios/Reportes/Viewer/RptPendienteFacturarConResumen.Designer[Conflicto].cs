namespace Promowork.Formularios.Reportes.Viewer
{
    partial class RptPendienteFacturarConResumen
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.HorasPendientesFacturarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Promowork_dataDataSet = new GestionData.Promowork_dataDataSet();
            this.EmpresasActualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EmpresasActualTableAdapter = new GestionData.Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter();
            this.HorasPendientesFacturarTableAdapter = new GestionData.Promowork_dataDataSetTableAdapters.HorasPendientesFacturarTableAdapter();
            this.btGenerarFacturas = new System.Windows.Forms.Panel();
            this.cbProveedores = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.HorasPendientesFacturarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasActualBindingSource)).BeginInit();
            this.btGenerarFacturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbProveedores.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // HorasPendientesFacturarBindingSource
            // 
            this.HorasPendientesFacturarBindingSource.DataMember = "HorasPendientesFacturar";
            this.HorasPendientesFacturarBindingSource.DataSource = this.Promowork_dataDataSet;
            // 
            // Promowork_dataDataSet
            // 
            this.Promowork_dataDataSet.DataSetName = "Promowork_dataDataSet";
            this.Promowork_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmpresasActualBindingSource
            // 
            this.EmpresasActualBindingSource.DataMember = "EmpresasActual";
            this.EmpresasActualBindingSource.DataSource = this.Promowork_dataDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HorasPendientesFacturarBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.EmpresasActualBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Promowork.Reportes.PendienteFacturarConResumen.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 56);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1220, 546);
            this.reportViewer1.TabIndex = 0;
            // 
            // EmpresasActualTableAdapter
            // 
            this.EmpresasActualTableAdapter.ClearBeforeFill = true;
            // 
            // HorasPendientesFacturarTableAdapter
            // 
            this.HorasPendientesFacturarTableAdapter.ClearBeforeFill = true;
            // 
            // btGenerarFacturas
            // 
            this.btGenerarFacturas.Controls.Add(this.labelControl1);
            this.btGenerarFacturas.Controls.Add(this.simpleButton1);
            this.btGenerarFacturas.Controls.Add(this.cbProveedores);
            this.btGenerarFacturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btGenerarFacturas.Location = new System.Drawing.Point(0, 0);
            this.btGenerarFacturas.Name = "btGenerarFacturas";
            this.btGenerarFacturas.Size = new System.Drawing.Size(1220, 56);
            this.btGenerarFacturas.TabIndex = 1;
            // 
            // cbProveedores
            // 
            this.cbProveedores.Location = new System.Drawing.Point(100, 12);
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProveedores.Size = new System.Drawing.Size(955, 20);
            this.cbProveedores.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(1075, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(122, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Generar Facturas";
            this.simpleButton1.ToolTip = "Generara facturas de los proveedores selecionados";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Proveedores:";
            // 
            // RptPendienteFacturarConResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 602);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btGenerarFacturas);
            this.Name = "RptPendienteFacturarConResumen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resumen de Obras";
            ((System.ComponentModel.ISupportInitialize)(this.HorasPendientesFacturarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasActualBindingSource)).EndInit();
            this.btGenerarFacturas.ResumeLayout(false);
            this.btGenerarFacturas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbProveedores.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private GestionData.Promowork_dataDataSet Promowork_dataDataSet;
        private System.Windows.Forms.BindingSource EmpresasActualBindingSource;
        private GestionData.Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter EmpresasActualTableAdapter;
        private System.Windows.Forms.BindingSource HorasPendientesFacturarBindingSource;
        private GestionData.Promowork_dataDataSetTableAdapters.HorasPendientesFacturarTableAdapter HorasPendientesFacturarTableAdapter;
        private System.Windows.Forms.Panel btGenerarFacturas;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cbProveedores;

    }
}