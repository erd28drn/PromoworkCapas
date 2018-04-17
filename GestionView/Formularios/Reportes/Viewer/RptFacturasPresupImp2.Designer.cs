namespace Promowork.Formularios.Reportes.Viewer
{
    partial class RptFacturasPresupImp2
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbGestor = new DevExpress.XtraEditors.LookUpEdit();
            this.lbGestor = new DevExpress.XtraEditors.LabelControl();
            this.chkCopiaGestor = new DevExpress.XtraEditors.CheckEdit();
            this.FacturasDetImpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Promowork_dataDataSet = new GestionData.Promowork_dataDataSet();
            this.empresasPoblacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturasCabImpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vComprasDirectasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosPresupuestos = new GestionData.DatosPresupuestos();
            this.FacturasDetHorasImpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GestoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturasDetImpTableAdapter = new GestionData.Promowork_dataDataSetTableAdapters.FacturasDetImpTableAdapter();
            this.FacturasCabImpTableAdapter = new GestionData.Promowork_dataDataSetTableAdapters.FacturasCabImpTableAdapter();
            this.empresasPoblacion = new GestionData.Promowork_dataDataSetTableAdapters.EmpresasPoblacion();
            this.vComprasDirectasTableAdapter = new GestionData.DatosPresupuestosTableAdapters.vComprasDirectasTableAdapter();
            this.FacturasDetHorasImpTableAdapter = new GestionData.Promowork_dataDataSetTableAdapters.FacturasDetHorasImpTableAdapter();
            this.GestoresTableAdapter = new GestionData.Promowork_dataDataSetTableAdapters.GestoresTableAdapter();
            this.btEnviarFactura = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGestor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCopiaGestor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasDetImpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasPoblacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasCabImpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vComprasDirectasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosPresupuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasDetHorasImpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GestoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.FacturasDetImpBindingSource;
            reportDataSource7.Name = "DataSet2";
            reportDataSource7.Value = this.empresasPoblacionBindingSource;
            reportDataSource8.Name = "DataSet3";
            reportDataSource8.Value = this.FacturasCabImpBindingSource;
            reportDataSource9.Name = "ComprasDirectas";
            reportDataSource9.Value = this.vComprasDirectasBindingSource;
            reportDataSource10.Name = "DetallesHoras";
            reportDataSource10.Value = this.FacturasDetHorasImpBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource10);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Promowork.Reportes.FacturaPresupImp2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 126);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1201, 571);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btEnviarFactura);
            this.panel1.Controls.Add(this.chkCopiaGestor);
            this.panel1.Controls.Add(this.lbGestor);
            this.panel1.Controls.Add(this.cbGestor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 126);
            this.panel1.TabIndex = 1;
            // 
            // cbGestor
            // 
            this.cbGestor.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.GestoresBindingSource, "IdProveedor", true));
            this.cbGestor.Location = new System.Drawing.Point(635, 64);
            this.cbGestor.Name = "cbGestor";
            this.cbGestor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGestor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesProveedor", "Proveedor", 81, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmailProveedor", "Email", 87, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cbGestor.Properties.DataSource = this.GestoresBindingSource;
            this.cbGestor.Properties.DisplayMember = "DescripcionEmail";
            this.cbGestor.Properties.NullText = "";
            this.cbGestor.Properties.ValueMember = "IdProveedor";
            this.cbGestor.Size = new System.Drawing.Size(411, 20);
            this.cbGestor.TabIndex = 0;
            // 
            // lbGestor
            // 
            this.lbGestor.Location = new System.Drawing.Point(575, 67);
            this.lbGestor.Name = "lbGestor";
            this.lbGestor.Size = new System.Drawing.Size(32, 13);
            this.lbGestor.TabIndex = 1;
            this.lbGestor.Text = "Gestor";
            // 
            // chkCopiaGestor
            // 
            this.chkCopiaGestor.EditValue = true;
            this.chkCopiaGestor.Location = new System.Drawing.Point(633, 12);
            this.chkCopiaGestor.Name = "chkCopiaGestor";
            this.chkCopiaGestor.Properties.Caption = "Enviar Copia a Gestor";
            this.chkCopiaGestor.Size = new System.Drawing.Size(153, 19);
            this.chkCopiaGestor.TabIndex = 2;
            this.chkCopiaGestor.CheckedChanged += new System.EventHandler(this.chkCopiaGestor_CheckedChanged);
            // 
            // FacturasDetImpBindingSource
            // 
            this.FacturasDetImpBindingSource.DataMember = "FacturasDetImp";
            this.FacturasDetImpBindingSource.DataSource = this.Promowork_dataDataSet;
            // 
            // Promowork_dataDataSet
            // 
            this.Promowork_dataDataSet.DataSetName = "Promowork_dataDataSet";
            this.Promowork_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresasPoblacionBindingSource
            // 
            this.empresasPoblacionBindingSource.DataMember = "EmpresasPoblacion";
            this.empresasPoblacionBindingSource.DataSource = this.Promowork_dataDataSet;
            // 
            // FacturasCabImpBindingSource
            // 
            this.FacturasCabImpBindingSource.DataMember = "FacturasCabImp";
            this.FacturasCabImpBindingSource.DataSource = this.Promowork_dataDataSet;
            // 
            // vComprasDirectasBindingSource
            // 
            this.vComprasDirectasBindingSource.DataMember = "vComprasDirectas";
            this.vComprasDirectasBindingSource.DataSource = this.DatosPresupuestos;
            // 
            // DatosPresupuestos
            // 
            this.DatosPresupuestos.DataSetName = "DatosPresupuestos";
            this.DatosPresupuestos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FacturasDetHorasImpBindingSource
            // 
            this.FacturasDetHorasImpBindingSource.DataMember = "FacturasDetHorasImp";
            this.FacturasDetHorasImpBindingSource.DataSource = this.Promowork_dataDataSet;
            // 
            // GestoresBindingSource
            // 
            this.GestoresBindingSource.DataMember = "Gestores";
            this.GestoresBindingSource.DataSource = this.Promowork_dataDataSet;
            // 
            // FacturasDetImpTableAdapter
            // 
            this.FacturasDetImpTableAdapter.ClearBeforeFill = true;
            // 
            // FacturasCabImpTableAdapter
            // 
            this.FacturasCabImpTableAdapter.ClearBeforeFill = true;
            // 
            // empresasPoblacion
            // 
            this.empresasPoblacion.ClearBeforeFill = true;
            // 
            // vComprasDirectasTableAdapter
            // 
            this.vComprasDirectasTableAdapter.ClearBeforeFill = true;
            // 
            // FacturasDetHorasImpTableAdapter
            // 
            this.FacturasDetHorasImpTableAdapter.ClearBeforeFill = true;
            // 
            // GestoresTableAdapter
            // 
            this.GestoresTableAdapter.ClearBeforeFill = true;
            // 
            // btEnviarFactura
            // 
            this.btEnviarFactura.Location = new System.Drawing.Point(931, 14);
            this.btEnviarFactura.Name = "btEnviarFactura";
            this.btEnviarFactura.Size = new System.Drawing.Size(126, 23);
            this.btEnviarFactura.TabIndex = 3;
            this.btEnviarFactura.Text = "Enviar Factura";
            this.btEnviarFactura.Click += new System.EventHandler(this.btEnviarFactura_Click);
            // 
            // RptFacturasPresupImp2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 697);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "RptFacturasPresupImp2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presupuesto Actual";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGestor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCopiaGestor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasDetImpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasPoblacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasCabImpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vComprasDirectasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosPresupuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasDetHorasImpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GestoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private GestionData.Promowork_dataDataSet Promowork_dataDataSet;
        private System.Windows.Forms.BindingSource FacturasDetImpBindingSource;
        private System.Windows.Forms.BindingSource FacturasCabImpBindingSource;
        private GestionData.Promowork_dataDataSetTableAdapters.FacturasDetImpTableAdapter FacturasDetImpTableAdapter;
        private GestionData.Promowork_dataDataSetTableAdapters.FacturasCabImpTableAdapter FacturasCabImpTableAdapter;
        private System.Windows.Forms.BindingSource empresasPoblacionBindingSource;
        private GestionData.Promowork_dataDataSetTableAdapters.EmpresasPoblacion empresasPoblacion;
        private System.Windows.Forms.BindingSource vComprasDirectasBindingSource;
        private GestionData.DatosPresupuestos DatosPresupuestos;
        private GestionData.DatosPresupuestosTableAdapters.vComprasDirectasTableAdapter vComprasDirectasTableAdapter;
        private System.Windows.Forms.BindingSource FacturasDetHorasImpBindingSource;
        private GestionData.Promowork_dataDataSetTableAdapters.FacturasDetHorasImpTableAdapter FacturasDetHorasImpTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private GestionData.Promowork_dataDataSetTableAdapters.GestoresTableAdapter GestoresTableAdapter;
        private System.Windows.Forms.BindingSource GestoresBindingSource;
        private DevExpress.XtraEditors.CheckEdit chkCopiaGestor;
        private DevExpress.XtraEditors.LabelControl lbGestor;
        private DevExpress.XtraEditors.LookUpEdit cbGestor;
        private DevExpress.XtraEditors.SimpleButton btEnviarFactura;
    }
}