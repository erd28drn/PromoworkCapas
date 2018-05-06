namespace Promowork.Formularios.Reportes.Viewer
{
    partial class RptFacturasClientes
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label cuerpoMensajeSinAlbaranLabel;
            System.Windows.Forms.Label asuntoSinAlbaranLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbCliente = new DevExpress.XtraEditors.TextEdit();
            this.cbTrabajadores = new DevExpress.XtraEditors.LookUpEdit();
            this.tbAsuntoMensaje = new DevExpress.XtraEditors.TextEdit();
            this.btEnviarFactura = new DevExpress.XtraEditors.SimpleButton();
            this.lbGestor = new DevExpress.XtraEditors.LabelControl();
            this.cbGestor = new DevExpress.XtraEditors.LookUpEdit();
            this.tbCuerpoMensaje = new DevExpress.XtraEditors.MemoEdit();
            this.tbResultado = new DevExpress.XtraEditors.MemoEdit();
            this.cbFechaEnvio = new DevExpress.XtraEditors.TextEdit();
            this.FacturasCabImpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Promowork_dataDataSet = new GestionData.Promowork_dataDataSet();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturasDetImpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresasPoblacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vComprasDirectasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosPresupuestos = new GestionData.DatosPresupuestos();
            this.FacturasDetHorasImpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GestoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturasDetImpTableAdapter = new GestionData.Promowork_dataDataSetTableAdapters.FacturasDetImpTableAdapter();
            this.FacturasCabImpTableAdapter = new GestionData.Promowork_dataDataSetTableAdapters.FacturasCabImpTableAdapter();
            this.empresasPoblacion = new GestionData.Promowork_dataDataSetTableAdapters.EmpresasPoblacion();
            this.empresasTableAdapter = new GestionData.Promowork_dataDataSetTableAdapters.EmpresasTableAdapter();
            this.vComprasDirectasTableAdapter = new GestionData.DatosPresupuestosTableAdapters.vComprasDirectasTableAdapter();
            this.FacturasDetHorasImpTableAdapter = new GestionData.Promowork_dataDataSetTableAdapters.FacturasDetHorasImpTableAdapter();
            this.GestoresTableAdapter = new GestionData.Promowork_dataDataSetTableAdapters.GestoresTableAdapter();
            label1 = new System.Windows.Forms.Label();
            cuerpoMensajeSinAlbaranLabel = new System.Windows.Forms.Label();
            asuntoSinAlbaranLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTrabajadores.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAsuntoMensaje.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGestor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCuerpoMensaje.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbResultado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFechaEnvio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasCabImpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasDetImpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasPoblacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vComprasDirectasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosPresupuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasDetHorasImpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GestoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(688, 54);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 13);
            label1.TabIndex = 9;
            label1.Text = "Responder A:";
            // 
            // cuerpoMensajeSinAlbaranLabel
            // 
            cuerpoMensajeSinAlbaranLabel.AutoSize = true;
            cuerpoMensajeSinAlbaranLabel.Location = new System.Drawing.Point(18, 55);
            cuerpoMensajeSinAlbaranLabel.Name = "cuerpoMensajeSinAlbaranLabel";
            cuerpoMensajeSinAlbaranLabel.Size = new System.Drawing.Size(87, 13);
            cuerpoMensajeSinAlbaranLabel.TabIndex = 8;
            cuerpoMensajeSinAlbaranLabel.Text = "Cuerpo Mensaje:";
            // 
            // asuntoSinAlbaranLabel
            // 
            asuntoSinAlbaranLabel.AutoSize = true;
            asuntoSinAlbaranLabel.Location = new System.Drawing.Point(18, 20);
            asuntoSinAlbaranLabel.Name = "asuntoSinAlbaranLabel";
            asuntoSinAlbaranLabel.Size = new System.Drawing.Size(86, 13);
            asuntoSinAlbaranLabel.TabIndex = 6;
            asuntoSinAlbaranLabel.Text = "Asunto Mensaje:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(711, 21);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 13);
            label2.TabIndex = 13;
            label2.Text = "Enviar a:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(702, 118);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(58, 13);
            label3.TabIndex = 15;
            label3.Text = "Resultado:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 180);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1370, 517);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbFechaEnvio);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.tbCliente);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(cuerpoMensajeSinAlbaranLabel);
            this.panel1.Controls.Add(asuntoSinAlbaranLabel);
            this.panel1.Controls.Add(this.cbTrabajadores);
            this.panel1.Controls.Add(this.tbAsuntoMensaje);
            this.panel1.Controls.Add(this.btEnviarFactura);
            this.panel1.Controls.Add(this.lbGestor);
            this.panel1.Controls.Add(this.cbGestor);
            this.panel1.Controls.Add(this.tbCuerpoMensaje);
            this.panel1.Controls.Add(this.tbResultado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 180);
            this.panel1.TabIndex = 1;
            // 
            // tbCliente
            // 
            this.tbCliente.Location = new System.Drawing.Point(766, 17);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Properties.ReadOnly = true;
            this.tbCliente.Size = new System.Drawing.Size(411, 20);
            this.tbCliente.TabIndex = 10;
            // 
            // cbTrabajadores
            // 
            this.cbTrabajadores.Location = new System.Drawing.Point(766, 51);
            this.cbTrabajadores.Name = "cbTrabajadores";
            this.cbTrabajadores.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTrabajadores.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreEmailTrabajador", "Trabajador")});
            this.cbTrabajadores.Properties.DisplayMember = "NombreEmailTrabajador";
            this.cbTrabajadores.Properties.NullText = "";
            this.cbTrabajadores.Properties.ValueMember = "IdTrabajador";
            this.cbTrabajadores.Size = new System.Drawing.Size(411, 20);
            this.cbTrabajadores.TabIndex = 7;
            // 
            // tbAsuntoMensaje
            // 
            this.tbAsuntoMensaje.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresasBindingSource, "AsuntoEnvioFacturas", true));
            this.tbAsuntoMensaje.Location = new System.Drawing.Point(108, 17);
            this.tbAsuntoMensaje.Name = "tbAsuntoMensaje";
            this.tbAsuntoMensaje.Size = new System.Drawing.Size(528, 20);
            this.tbAsuntoMensaje.TabIndex = 5;
            // 
            // btEnviarFactura
            // 
            this.btEnviarFactura.Enabled = false;
            this.btEnviarFactura.Location = new System.Drawing.Point(1213, 14);
            this.btEnviarFactura.Name = "btEnviarFactura";
            this.btEnviarFactura.Size = new System.Drawing.Size(126, 23);
            this.btEnviarFactura.TabIndex = 3;
            this.btEnviarFactura.Text = "Enviar Factura";
            this.btEnviarFactura.Click += new System.EventHandler(this.btEnviarFactura_Click);
            // 
            // lbGestor
            // 
            this.lbGestor.Location = new System.Drawing.Point(685, 87);
            this.lbGestor.Name = "lbGestor";
            this.lbGestor.Size = new System.Drawing.Size(75, 13);
            this.lbGestor.TabIndex = 1;
            this.lbGestor.Text = "Copia a Gestor:";
            // 
            // cbGestor
            // 
            this.cbGestor.Location = new System.Drawing.Point(766, 85);
            this.cbGestor.Name = "cbGestor";
            this.cbGestor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGestor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreEmailGestor", "Proveedor", 81, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cbGestor.Properties.DisplayMember = "NombreEmailGestor";
            this.cbGestor.Properties.NullText = "";
            this.cbGestor.Properties.ValueMember = "IdGestor";
            this.cbGestor.Size = new System.Drawing.Size(411, 20);
            this.cbGestor.TabIndex = 0;
            // 
            // tbCuerpoMensaje
            // 
            this.tbCuerpoMensaje.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresasBindingSource, "CuerpoEnvioFacturas", true));
            this.tbCuerpoMensaje.Location = new System.Drawing.Point(108, 52);
            this.tbCuerpoMensaje.Name = "tbCuerpoMensaje";
            this.tbCuerpoMensaje.Size = new System.Drawing.Size(528, 111);
            this.tbCuerpoMensaje.TabIndex = 4;
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(766, 114);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tbResultado.Properties.Appearance.Options.UseFont = true;
            this.tbResultado.Properties.ReadOnly = true;
            this.tbResultado.Size = new System.Drawing.Size(411, 49);
            this.tbResultado.TabIndex = 14;
            // 
            // cbFechaEnvio
            // 
            this.cbFechaEnvio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.FacturasCabImpBindingSource, "FechaEnvioCliente", true));
            this.cbFechaEnvio.Location = new System.Drawing.Point(1213, 52);
            this.cbFechaEnvio.Name = "cbFechaEnvio";
            this.cbFechaEnvio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbFechaEnvio.Properties.Appearance.Options.UseFont = true;
            this.cbFechaEnvio.Properties.ReadOnly = true;
            this.cbFechaEnvio.Size = new System.Drawing.Size(126, 20);
            this.cbFechaEnvio.TabIndex = 16;
            // 
            // FacturasCabImpBindingSource
            // 
            this.FacturasCabImpBindingSource.DataMember = "FacturasCabImp";
            this.FacturasCabImpBindingSource.DataSource = this.Promowork_dataDataSet;
            // 
            // Promowork_dataDataSet
            // 
            this.Promowork_dataDataSet.DataSetName = "Promowork_dataDataSet";
            this.Promowork_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresasBindingSource
            // 
            this.empresasBindingSource.DataMember = "Empresas";
            this.empresasBindingSource.DataSource = this.Promowork_dataDataSet;
            // 
            // FacturasDetImpBindingSource
            // 
            this.FacturasDetImpBindingSource.DataMember = "FacturasDetImp";
            this.FacturasDetImpBindingSource.DataSource = this.Promowork_dataDataSet;
            // 
            // empresasPoblacionBindingSource
            // 
            this.empresasPoblacionBindingSource.DataMember = "EmpresasPoblacion";
            this.empresasPoblacionBindingSource.DataSource = this.Promowork_dataDataSet;
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
            // empresasTableAdapter
            // 
            this.empresasTableAdapter.ClearBeforeFill = true;
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
            // RptFacturasClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 697);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "RptFacturasClientes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presupuesto Actual";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTrabajadores.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAsuntoMensaje.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGestor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCuerpoMensaje.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbResultado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFechaEnvio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasCabImpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasDetImpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasPoblacionBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource empresasBindingSource;
        private GestionData.Promowork_dataDataSetTableAdapters.EmpresasPoblacion empresasPoblacion;
        private GestionData.Promowork_dataDataSetTableAdapters.EmpresasTableAdapter empresasTableAdapter;
        private System.Windows.Forms.BindingSource vComprasDirectasBindingSource;
        private GestionData.DatosPresupuestos DatosPresupuestos;
        private GestionData.DatosPresupuestosTableAdapters.vComprasDirectasTableAdapter vComprasDirectasTableAdapter;
        private System.Windows.Forms.BindingSource FacturasDetHorasImpBindingSource;
        private GestionData.Promowork_dataDataSetTableAdapters.FacturasDetHorasImpTableAdapter FacturasDetHorasImpTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private GestionData.Promowork_dataDataSetTableAdapters.GestoresTableAdapter GestoresTableAdapter;
        private System.Windows.Forms.BindingSource GestoresBindingSource;
        private DevExpress.XtraEditors.LabelControl lbGestor;
        private DevExpress.XtraEditors.LookUpEdit cbGestor;
        private DevExpress.XtraEditors.SimpleButton btEnviarFactura;
        private DevExpress.XtraEditors.MemoEdit tbCuerpoMensaje;
        private DevExpress.XtraEditors.TextEdit tbAsuntoMensaje;
        private DevExpress.XtraEditors.LookUpEdit cbTrabajadores;
        private DevExpress.XtraEditors.TextEdit tbCliente;
        private DevExpress.XtraEditors.MemoEdit tbResultado;
        private DevExpress.XtraEditors.TextEdit cbFechaEnvio;
    }
}