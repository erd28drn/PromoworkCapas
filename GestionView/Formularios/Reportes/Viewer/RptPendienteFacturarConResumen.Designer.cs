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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btGenerarFacturas = new System.Windows.Forms.Panel();
            this.btMarcarFinalizados = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btFacturar = new DevExpress.XtraEditors.SimpleButton();
            this.cbObras = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.HorasPendientesFacturarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Promowork_dataDataSet = new GestionData.Promowork_dataDataSet();
            this.EmpresasActualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmpresasActualTableAdapter = new GestionData.Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter();
            this.HorasPendientesFacturarTableAdapter = new GestionData.Promowork_dataDataSetTableAdapters.HorasPendientesFacturarTableAdapter();
            this.btGenerarFacturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbObras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorasPendientesFacturarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasActualBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.reportViewer1.Location = new System.Drawing.Point(0, 50);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1261, 552);
            this.reportViewer1.TabIndex = 0;
            // 
            // btGenerarFacturas
            // 
            this.btGenerarFacturas.Controls.Add(this.btMarcarFinalizados);
            this.btGenerarFacturas.Controls.Add(this.labelControl1);
            this.btGenerarFacturas.Controls.Add(this.btFacturar);
            this.btGenerarFacturas.Controls.Add(this.cbObras);
            this.btGenerarFacturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btGenerarFacturas.Location = new System.Drawing.Point(0, 0);
            this.btGenerarFacturas.Name = "btGenerarFacturas";
            this.btGenerarFacturas.Size = new System.Drawing.Size(1261, 50);
            this.btGenerarFacturas.TabIndex = 1;
            // 
            // btMarcarFinalizados
            // 
            this.btMarcarFinalizados.Location = new System.Drawing.Point(1127, 8);
            this.btMarcarFinalizados.Name = "btMarcarFinalizados";
            this.btMarcarFinalizados.Size = new System.Drawing.Size(122, 23);
            this.btMarcarFinalizados.TabIndex = 3;
            this.btMarcarFinalizados.Text = "Marcar Finalizados";
            this.btMarcarFinalizados.ToolTip = "Generara facturas de las obras selecionadas";
            this.btMarcarFinalizados.Click += new System.EventHandler(this.btMarcarFinalizados_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Obras:";
            // 
            // btFacturar
            // 
            this.btFacturar.Location = new System.Drawing.Point(979, 8);
            this.btFacturar.Name = "btFacturar";
            this.btFacturar.Size = new System.Drawing.Size(122, 23);
            this.btFacturar.TabIndex = 1;
            this.btFacturar.Text = "Generar Facturas";
            this.btFacturar.ToolTip = "Generara facturas de las obras selecionadas";
            this.btFacturar.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cbObras
            // 
            this.cbObras.EditValue = "";
            this.cbObras.Location = new System.Drawing.Point(77, 11);
            this.cbObras.Name = "cbObras";
            this.cbObras.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbObras.Size = new System.Drawing.Size(896, 20);
            this.cbObras.TabIndex = 0;
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
            // EmpresasActualTableAdapter
            // 
            this.EmpresasActualTableAdapter.ClearBeforeFill = true;
            // 
            // HorasPendientesFacturarTableAdapter
            // 
            this.HorasPendientesFacturarTableAdapter.ClearBeforeFill = true;
            // 
            // RptPendienteFacturarConResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 602);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btGenerarFacturas);
            this.Name = "RptPendienteFacturarConResumen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resumen de Obras";
            this.btGenerarFacturas.ResumeLayout(false);
            this.btGenerarFacturas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbObras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorasPendientesFacturarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasActualBindingSource)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton btFacturar;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cbObras;
        private DevExpress.XtraEditors.SimpleButton btMarcarFinalizados;

    }
}