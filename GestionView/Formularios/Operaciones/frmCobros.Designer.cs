﻿namespace Promowork.Formularios.Operaciones
{
    partial class frmCobros
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
            System.Windows.Forms.Label idFormaPagoLabel;
            System.Windows.Forms.Label idCuentaLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label idObraLabel;
            System.Windows.Forms.Label fechaExpLabel;
            System.Windows.Forms.Label fechaRecLabel;
            System.Windows.Forms.Label idFactCabLabel;
            System.Windows.Forms.Label fechaAbonoLabel;
            System.Windows.Forms.Label observLabel;
            System.Windows.Forms.Label fechaVctoLabel;
            System.Windows.Forms.Label referenciaLabel;
            System.Windows.Forms.Label impBaseLabel;
            System.Windows.Forms.Label impIVALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCobros));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.cobrosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.cobrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.promowork_dataDataSet = new GestionData.Promowork_dataDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cobrosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbxAnosCobros = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btVincular = new System.Windows.Forms.ToolStripButton();
            this.cobrosGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Clientes = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colIdObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Obras = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.obrasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colFechaExp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaRec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaAbono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaVcto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFactCab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FormasPago = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.formasPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colIdCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cuentas = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cuentasBancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colImpBase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObserv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCopiaFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrevision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFactCab1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.previsionCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.idFormaPagoComboBox = new System.Windows.Forms.ComboBox();
            this.idCuentaComboBox = new System.Windows.Forms.ComboBox();
            this.idClienteComboBox = new System.Windows.Forms.ComboBox();
            this.idObraComboBox = new System.Windows.Forms.ComboBox();
            this.obrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.fechaExpDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaRecDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaAbonoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idFactCabComboBox = new System.Windows.Forms.ComboBox();
            this.facturasCabListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaVctoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.observTextBox = new System.Windows.Forms.TextBox();
            this.impBaseTextBox = new System.Windows.Forms.TextBox();
            this.referenciaTextBox = new System.Windows.Forms.TextBox();
            this.impIVATextBox = new System.Windows.Forms.TextBox();
            this.cobrosTableAdapter = new GestionData.Promowork_dataDataSetTableAdapters.CobrosTableAdapter();
            this.clientesTableAdapter = new GestionData.Promowork_dataDataSetTableAdapters.ClientesTableAdapter();
            this.obrasTableAdapter = new GestionData.Promowork_dataDataSetTableAdapters.ObrasTableAdapter();
            this.tableAdapterManager = new GestionData.Promowork_dataDataSetTableAdapters.TableAdapterManager();
            this.formasPagoTableAdapter = new GestionData.Promowork_dataDataSetTableAdapters.FormasPagoTableAdapter();
            this.cuentasBancosTableAdapter = new GestionData.Promowork_dataDataSetTableAdapters.CuentasBancosTableAdapter();
            this.facturasCabListaTableAdapter = new GestionData.Promowork_dataDataSetTableAdapters.FacturasCabListaTableAdapter();
            this.anosCobrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anosCobrosTableAdapter = new GestionData.Promowork_dataDataSetTableAdapters.AnosCobrosTableAdapter();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            idFormaPagoLabel = new System.Windows.Forms.Label();
            idCuentaLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            idObraLabel = new System.Windows.Forms.Label();
            fechaExpLabel = new System.Windows.Forms.Label();
            fechaRecLabel = new System.Windows.Forms.Label();
            idFactCabLabel = new System.Windows.Forms.Label();
            fechaAbonoLabel = new System.Windows.Forms.Label();
            observLabel = new System.Windows.Forms.Label();
            fechaVctoLabel = new System.Windows.Forms.Label();
            referenciaLabel = new System.Windows.Forms.Label();
            impBaseLabel = new System.Windows.Forms.Label();
            impIVALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosBindingNavigator)).BeginInit();
            this.cobrosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormasPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formasPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previsionCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasCabListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anosCobrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idFormaPagoLabel
            // 
            idFormaPagoLabel.AutoSize = true;
            idFormaPagoLabel.Location = new System.Drawing.Point(36, 20);
            idFormaPagoLabel.Name = "idFormaPagoLabel";
            idFormaPagoLabel.Size = new System.Drawing.Size(77, 13);
            idFormaPagoLabel.TabIndex = 43;
            idFormaPagoLabel.Text = "Forma Pago(*):";
            // 
            // idCuentaLabel
            // 
            idCuentaLabel.AutoSize = true;
            idCuentaLabel.Location = new System.Drawing.Point(59, 47);
            idCuentaLabel.Name = "idCuentaLabel";
            idCuentaLabel.Size = new System.Drawing.Size(54, 13);
            idCuentaLabel.TabIndex = 45;
            idCuentaLabel.Text = "Cuenta(*):";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(61, 74);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(52, 13);
            idClienteLabel.TabIndex = 47;
            idClienteLabel.Text = "Cliente(*):";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(894, 72);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(34, 13);
            totalLabel.TabIndex = 73;
            totalLabel.Text = "Total:";
            // 
            // idObraLabel
            // 
            idObraLabel.AutoSize = true;
            idObraLabel.Location = new System.Drawing.Point(79, 101);
            idObraLabel.Name = "idObraLabel";
            idObraLabel.Size = new System.Drawing.Size(33, 13);
            idObraLabel.TabIndex = 49;
            idObraLabel.Text = "Obra:";
            // 
            // fechaExpLabel
            // 
            fechaExpLabel.AutoSize = true;
            fechaExpLabel.Location = new System.Drawing.Point(504, 48);
            fechaExpLabel.Name = "fechaExpLabel";
            fechaExpLabel.Size = new System.Drawing.Size(95, 13);
            fechaExpLabel.TabIndex = 51;
            fechaExpLabel.Text = "Fecha Expedición:";
            // 
            // fechaRecLabel
            // 
            fechaRecLabel.AutoSize = true;
            fechaRecLabel.Location = new System.Drawing.Point(514, 75);
            fechaRecLabel.Name = "fechaRecLabel";
            fechaRecLabel.Size = new System.Drawing.Size(85, 13);
            fechaRecLabel.TabIndex = 53;
            fechaRecLabel.Text = "Fecha Recibido:";
            // 
            // idFactCabLabel
            // 
            idFactCabLabel.AutoSize = true;
            idFactCabLabel.Location = new System.Drawing.Point(26, 128);
            idFactCabLabel.Name = "idFactCabLabel";
            idFactCabLabel.Size = new System.Drawing.Size(86, 13);
            idFactCabLabel.TabIndex = 67;
            idFactCabLabel.Text = "Factura Sistema:";
            // 
            // fechaAbonoLabel
            // 
            fechaAbonoLabel.AutoSize = true;
            fechaAbonoLabel.Location = new System.Drawing.Point(525, 102);
            fechaAbonoLabel.Name = "fechaAbonoLabel";
            fechaAbonoLabel.Size = new System.Drawing.Size(74, 13);
            fechaAbonoLabel.TabIndex = 55;
            fechaAbonoLabel.Text = "Fecha Abono:";
            // 
            // observLabel
            // 
            observLabel.AutoSize = true;
            observLabel.Location = new System.Drawing.Point(727, 93);
            observLabel.Name = "observLabel";
            observLabel.Size = new System.Drawing.Size(81, 13);
            observLabel.TabIndex = 65;
            observLabel.Text = "Observaciones:";
            // 
            // fechaVctoLabel
            // 
            fechaVctoLabel.AutoSize = true;
            fechaVctoLabel.Location = new System.Drawing.Point(498, 129);
            fechaVctoLabel.Name = "fechaVctoLabel";
            fechaVctoLabel.Size = new System.Drawing.Size(101, 13);
            fechaVctoLabel.TabIndex = 57;
            fechaVctoLabel.Text = "Fecha Vencimiento:";
            // 
            // referenciaLabel
            // 
            referenciaLabel.AutoSize = true;
            referenciaLabel.Location = new System.Drawing.Point(534, 19);
            referenciaLabel.Name = "referenciaLabel";
            referenciaLabel.Size = new System.Drawing.Size(65, 13);
            referenciaLabel.TabIndex = 63;
            referenciaLabel.Text = "Documento:";
            // 
            // impBaseLabel
            // 
            impBaseLabel.AutoSize = true;
            impBaseLabel.Location = new System.Drawing.Point(846, 19);
            impBaseLabel.Name = "impBaseLabel";
            impBaseLabel.Size = new System.Drawing.Size(82, 13);
            impBaseLabel.TabIndex = 59;
            impBaseLabel.Text = "Importe Base(*):";
            // 
            // impIVALabel
            // 
            impIVALabel.AutoSize = true;
            impIVALabel.Location = new System.Drawing.Point(862, 46);
            impIVALabel.Name = "impIVALabel";
            impIVALabel.Size = new System.Drawing.Size(65, 13);
            impIVALabel.TabIndex = 61;
            impIVALabel.Text = "Importe IVA:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.previsionCheckEdit);
            this.splitContainer1.Panel2.Controls.Add(idFormaPagoLabel);
            this.splitContainer1.Panel2.Controls.Add(this.idFormaPagoComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.idCuentaComboBox);
            this.splitContainer1.Panel2.Controls.Add(idCuentaLabel);
            this.splitContainer1.Panel2.Controls.Add(this.idClienteComboBox);
            this.splitContainer1.Panel2.Controls.Add(idClienteLabel);
            this.splitContainer1.Panel2.Controls.Add(this.idObraComboBox);
            this.splitContainer1.Panel2.Controls.Add(totalLabel);
            this.splitContainer1.Panel2.Controls.Add(idObraLabel);
            this.splitContainer1.Panel2.Controls.Add(this.totalTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.fechaExpDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(fechaExpLabel);
            this.splitContainer1.Panel2.Controls.Add(this.fechaRecDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(fechaRecLabel);
            this.splitContainer1.Panel2.Controls.Add(this.fechaAbonoDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(idFactCabLabel);
            this.splitContainer1.Panel2.Controls.Add(fechaAbonoLabel);
            this.splitContainer1.Panel2.Controls.Add(this.idFactCabComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.fechaVctoDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(observLabel);
            this.splitContainer1.Panel2.Controls.Add(fechaVctoLabel);
            this.splitContainer1.Panel2.Controls.Add(this.observTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.impBaseTextBox);
            this.splitContainer1.Panel2.Controls.Add(referenciaLabel);
            this.splitContainer1.Panel2.Controls.Add(impBaseLabel);
            this.splitContainer1.Panel2.Controls.Add(this.referenciaTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.impIVATextBox);
            this.splitContainer1.Panel2.Controls.Add(impIVALabel);
            this.splitContainer1.Size = new System.Drawing.Size(1149, 558);
            this.splitContainer1.SplitterDistance = 393;
            this.splitContainer1.TabIndex = 43;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.cobrosBindingNavigator);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.cobrosGridControl);
            this.splitContainer2.Size = new System.Drawing.Size(1149, 393);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 42;
            // 
            // cobrosBindingNavigator
            // 
            this.cobrosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cobrosBindingNavigator.BindingSource = this.cobrosBindingSource;
            this.cobrosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cobrosBindingNavigator.DeleteItem = null;
            this.cobrosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorAddNewItem,
            this.cobrosBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.cbxAnosCobros,
            this.toolStripSeparator2,
            this.btVincular,
            this.toolStripSeparator3});
            this.cobrosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cobrosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cobrosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cobrosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cobrosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cobrosBindingNavigator.Name = "cobrosBindingNavigator";
            this.cobrosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cobrosBindingNavigator.Size = new System.Drawing.Size(1149, 25);
            this.cobrosBindingNavigator.TabIndex = 0;
            this.cobrosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // cobrosBindingSource
            // 
            this.cobrosBindingSource.DataMember = "Cobros";
            this.cobrosBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // promowork_dataDataSet
            // 
            this.promowork_dataDataSet.DataSetName = "Promowork_dataDataSet";
            this.promowork_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // cobrosBindingNavigatorSaveItem
            // 
            this.cobrosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cobrosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cobrosBindingNavigatorSaveItem.Image")));
            this.cobrosBindingNavigatorSaveItem.Name = "cobrosBindingNavigatorSaveItem";
            this.cobrosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cobrosBindingNavigatorSaveItem.Text = "Save Data";
            this.cobrosBindingNavigatorSaveItem.Click += new System.EventHandler(this.cobrosBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(157, 22);
            this.toolStripLabel1.Text = "      Mostrar Cobros del Año: ";
            // 
            // cbxAnosCobros
            // 
            this.cbxAnosCobros.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxAnosCobros.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxAnosCobros.Name = "cbxAnosCobros";
            this.cbxAnosCobros.Size = new System.Drawing.Size(75, 25);
            this.cbxAnosCobros.SelectedIndexChanged += new System.EventHandler(this.cbxAnosCobros_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btVincular
            // 
            this.btVincular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btVincular.Image = ((System.Drawing.Image)(resources.GetObject("btVincular.Image")));
            this.btVincular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btVincular.Name = "btVincular";
            this.btVincular.Size = new System.Drawing.Size(124, 22);
            this.btVincular.Text = "Revisar Vinculaciones";
            this.btVincular.ToolTipText = "Revisar y Corregir Vinculaciones Facturas";
            this.btVincular.Click += new System.EventHandler(this.btVincular_Click);
            // 
            // cobrosGridControl
            // 
            this.cobrosGridControl.DataSource = this.cobrosBindingSource;
            this.cobrosGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cobrosGridControl.Location = new System.Drawing.Point(0, 0);
            this.cobrosGridControl.MainView = this.gridView1;
            this.cobrosGridControl.Name = "cobrosGridControl";
            this.cobrosGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Clientes,
            this.Obras,
            this.FormasPago,
            this.Cuentas});
            this.cobrosGridControl.Size = new System.Drawing.Size(1149, 364);
            this.cobrosGridControl.TabIndex = 41;
            this.cobrosGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCobro,
            this.colIdUsuario,
            this.colIdEmpresa,
            this.colIdCliente,
            this.colIdObra,
            this.colFechaExp,
            this.colFechaRec,
            this.colFechaAbono,
            this.colFechaVcto,
            this.colIdFactCab,
            this.colFactura,
            this.colIdFormaPago,
            this.colIdCuenta,
            this.colImpBase,
            this.colImpIVA,
            this.colReferencia,
            this.colObserv,
            this.colTotal,
            this.colFechaFactura,
            this.colCopiaFactura,
            this.colEnBanco,
            this.colPrevision,
            this.colIdFactCab1});
            this.gridView1.GridControl = this.cobrosGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colIdCobro
            // 
            this.colIdCobro.FieldName = "IdCobro";
            this.colIdCobro.Name = "colIdCobro";
            this.colIdCobro.OptionsColumn.ReadOnly = true;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdCliente
            // 
            this.colIdCliente.Caption = "Cliente";
            this.colIdCliente.ColumnEdit = this.Clientes;
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colIdCliente.Name = "colIdCliente";
            this.colIdCliente.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colIdCliente.Visible = true;
            this.colIdCliente.VisibleIndex = 3;
            this.colIdCliente.Width = 247;
            // 
            // Clientes
            // 
            this.Clientes.AutoHeight = false;
            this.Clientes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Clientes.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdCliente", "Id Cliente", 69, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NumCliente", "Número", 67, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesCliente", "Nombre", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.Clientes.DataSource = this.clientesBindingSource;
            this.Clientes.DisplayMember = "DesCliente";
            this.Clientes.Name = "Clientes";
            this.Clientes.NullText = "";
            this.Clientes.ValueMember = "IdCliente";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // colIdObra
            // 
            this.colIdObra.Caption = "Obra";
            this.colIdObra.ColumnEdit = this.Obras;
            this.colIdObra.FieldName = "IdObra";
            this.colIdObra.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colIdObra.Name = "colIdObra";
            this.colIdObra.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colIdObra.Visible = true;
            this.colIdObra.VisibleIndex = 4;
            this.colIdObra.Width = 237;
            // 
            // Obras
            // 
            this.Obras.AutoHeight = false;
            this.Obras.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Obras.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Obra", 200, "Obra")});
            this.Obras.DataSource = this.obrasBindingSource1;
            this.Obras.DisplayMember = "Obra";
            this.Obras.Name = "Obras";
            this.Obras.NullText = "";
            this.Obras.ValueMember = "IdObra";
            // 
            // obrasBindingSource1
            // 
            this.obrasBindingSource1.DataMember = "Obras";
            this.obrasBindingSource1.DataSource = this.promowork_dataDataSet;
            // 
            // colFechaExp
            // 
            this.colFechaExp.Caption = "Fecha Expedido";
            this.colFechaExp.FieldName = "FechaExp";
            this.colFechaExp.Name = "colFechaExp";
            this.colFechaExp.Width = 104;
            // 
            // colFechaRec
            // 
            this.colFechaRec.Caption = "Fecha Recibido";
            this.colFechaRec.FieldName = "FechaRec";
            this.colFechaRec.Name = "colFechaRec";
            // 
            // colFechaAbono
            // 
            this.colFechaAbono.Caption = "Fecha Abono";
            this.colFechaAbono.FieldName = "FechaAbono";
            this.colFechaAbono.Name = "colFechaAbono";
            this.colFechaAbono.Visible = true;
            this.colFechaAbono.VisibleIndex = 0;
            // 
            // colFechaVcto
            // 
            this.colFechaVcto.Caption = "Fecha Vcto";
            this.colFechaVcto.FieldName = "FechaVcto";
            this.colFechaVcto.Name = "colFechaVcto";
            // 
            // colIdFactCab
            // 
            this.colIdFactCab.Caption = "Factura";
            this.colIdFactCab.FieldName = "IdFactCab";
            this.colIdFactCab.Name = "colIdFactCab";
            this.colIdFactCab.Width = 77;
            // 
            // colFactura
            // 
            this.colFactura.FieldName = "Factura";
            this.colFactura.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colFactura.Name = "colFactura";
            this.colFactura.Visible = true;
            this.colFactura.VisibleIndex = 6;
            this.colFactura.Width = 70;
            // 
            // colIdFormaPago
            // 
            this.colIdFormaPago.Caption = "Forma Pago";
            this.colIdFormaPago.ColumnEdit = this.FormasPago;
            this.colIdFormaPago.FieldName = "IdFormaPago";
            this.colIdFormaPago.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colIdFormaPago.Name = "colIdFormaPago";
            this.colIdFormaPago.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colIdFormaPago.Visible = true;
            this.colIdFormaPago.VisibleIndex = 1;
            this.colIdFormaPago.Width = 114;
            // 
            // FormasPago
            // 
            this.FormasPago.AutoHeight = false;
            this.FormasPago.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FormasPago.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesFormaPago", "Forma Pago", 88, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.FormasPago.DataSource = this.formasPagoBindingSource;
            this.FormasPago.DisplayMember = "DesFormaPago";
            this.FormasPago.Name = "FormasPago";
            this.FormasPago.NullText = "";
            this.FormasPago.ValueMember = "IdFormaPago";
            // 
            // formasPagoBindingSource
            // 
            this.formasPagoBindingSource.DataMember = "FormasPago";
            this.formasPagoBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // colIdCuenta
            // 
            this.colIdCuenta.Caption = "Cuenta";
            this.colIdCuenta.ColumnEdit = this.Cuentas;
            this.colIdCuenta.FieldName = "IdCuenta";
            this.colIdCuenta.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colIdCuenta.Name = "colIdCuenta";
            this.colIdCuenta.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colIdCuenta.Visible = true;
            this.colIdCuenta.VisibleIndex = 2;
            this.colIdCuenta.Width = 180;
            // 
            // Cuentas
            // 
            this.Cuentas.AutoHeight = false;
            this.Cuentas.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cuentas.DataSource = this.cuentasBancosBindingSource;
            this.Cuentas.DisplayMember = "CuentaBanco";
            this.Cuentas.Name = "Cuentas";
            this.Cuentas.NullText = "";
            this.Cuentas.ValueMember = "IdCuenta";
            // 
            // cuentasBancosBindingSource
            // 
            this.cuentasBancosBindingSource.DataMember = "CuentasBancos";
            this.cuentasBancosBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // colImpBase
            // 
            this.colImpBase.FieldName = "ImpBase";
            this.colImpBase.Name = "colImpBase";
            // 
            // colImpIVA
            // 
            this.colImpIVA.FieldName = "ImpIVA";
            this.colImpIVA.Name = "colImpIVA";
            // 
            // colReferencia
            // 
            this.colReferencia.FieldName = "Referencia";
            this.colReferencia.Name = "colReferencia";
            // 
            // colObserv
            // 
            this.colObserv.FieldName = "Observ";
            this.colObserv.Name = "colObserv";
            // 
            // colTotal
            // 
            this.colTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotal.Caption = "Importe Total";
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.ReadOnly = true;
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 5;
            this.colTotal.Width = 101;
            // 
            // colFechaFactura
            // 
            this.colFechaFactura.FieldName = "FechaFactura";
            this.colFechaFactura.Name = "colFechaFactura";
            this.colFechaFactura.Visible = true;
            this.colFechaFactura.VisibleIndex = 7;
            this.colFechaFactura.Width = 100;
            // 
            // colCopiaFactura
            // 
            this.colCopiaFactura.FieldName = "CopiaFactura";
            this.colCopiaFactura.Name = "colCopiaFactura";
            // 
            // colEnBanco
            // 
            this.colEnBanco.FieldName = "EnBanco";
            this.colEnBanco.Name = "colEnBanco";
            // 
            // colPrevision
            // 
            this.colPrevision.FieldName = "Prevision";
            this.colPrevision.Name = "colPrevision";
            // 
            // colIdFactCab1
            // 
            this.colIdFactCab1.FieldName = "IdFactCab";
            this.colIdFactCab1.Name = "colIdFactCab1";
            // 
            // previsionCheckEdit
            // 
            this.previsionCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cobrosBindingSource, "Prevision", true));
            this.previsionCheckEdit.Location = new System.Drawing.Point(728, 57);
            this.previsionCheckEdit.Name = "previsionCheckEdit";
            this.previsionCheckEdit.Properties.Caption = "Previsión";
            this.previsionCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.previsionCheckEdit.TabIndex = 81;
            // 
            // idFormaPagoComboBox
            // 
            this.idFormaPagoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idFormaPagoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.idFormaPagoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cobrosBindingSource, "IdFormaPago", true));
            this.idFormaPagoComboBox.DataSource = this.formasPagoBindingSource;
            this.idFormaPagoComboBox.DisplayMember = "DesFormaPago";
            this.idFormaPagoComboBox.FormattingEnabled = true;
            this.idFormaPagoComboBox.Location = new System.Drawing.Point(115, 16);
            this.idFormaPagoComboBox.Name = "idFormaPagoComboBox";
            this.idFormaPagoComboBox.Size = new System.Drawing.Size(314, 21);
            this.idFormaPagoComboBox.TabIndex = 44;
            this.idFormaPagoComboBox.ValueMember = "IdFormaPago";
            // 
            // idCuentaComboBox
            // 
            this.idCuentaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idCuentaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.idCuentaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cobrosBindingSource, "IdCuenta", true));
            this.idCuentaComboBox.DataSource = this.cuentasBancosBindingSource;
            this.idCuentaComboBox.DisplayMember = "CuentaBanco";
            this.idCuentaComboBox.DropDownWidth = 314;
            this.idCuentaComboBox.FormattingEnabled = true;
            this.idCuentaComboBox.Location = new System.Drawing.Point(115, 43);
            this.idCuentaComboBox.Name = "idCuentaComboBox";
            this.idCuentaComboBox.Size = new System.Drawing.Size(314, 21);
            this.idCuentaComboBox.TabIndex = 46;
            this.idCuentaComboBox.ValueMember = "IdCuenta";
            // 
            // idClienteComboBox
            // 
            this.idClienteComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idClienteComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.idClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cobrosBindingSource, "IdCliente", true));
            this.idClienteComboBox.DataSource = this.clientesBindingSource;
            this.idClienteComboBox.DisplayMember = "DesCliente";
            this.idClienteComboBox.FormattingEnabled = true;
            this.idClienteComboBox.Location = new System.Drawing.Point(115, 70);
            this.idClienteComboBox.Name = "idClienteComboBox";
            this.idClienteComboBox.Size = new System.Drawing.Size(314, 21);
            this.idClienteComboBox.TabIndex = 48;
            this.idClienteComboBox.ValueMember = "IdCliente";
            // 
            // idObraComboBox
            // 
            this.idObraComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idObraComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.idObraComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cobrosBindingSource, "IdObra", true));
            this.idObraComboBox.DataSource = this.obrasBindingSource;
            this.idObraComboBox.DisplayMember = "Obra";
            this.idObraComboBox.FormattingEnabled = true;
            this.idObraComboBox.Location = new System.Drawing.Point(115, 97);
            this.idObraComboBox.Name = "idObraComboBox";
            this.idObraComboBox.Size = new System.Drawing.Size(314, 21);
            this.idObraComboBox.TabIndex = 50;
            this.idObraComboBox.ValueMember = "IdObra";
            this.idObraComboBox.SelectedValueChanged += new System.EventHandler(this.idObraComboBox_SelectedValueChanged);
            // 
            // obrasBindingSource
            // 
            this.obrasBindingSource.DataMember = "FK_Obras_Clientes";
            this.obrasBindingSource.DataSource = this.clientesBindingSource;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cobrosBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(930, 69);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 74;
            // 
            // fechaExpDateTimePicker
            // 
            this.fechaExpDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cobrosBindingSource, "FechaExp", true));
            this.fechaExpDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaExpDateTimePicker.Location = new System.Drawing.Point(601, 44);
            this.fechaExpDateTimePicker.Name = "fechaExpDateTimePicker";
            this.fechaExpDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.fechaExpDateTimePicker.TabIndex = 52;
            this.fechaExpDateTimePicker.ValueChanged += new System.EventHandler(this.fechaExpDateTimePicker_ValueChanged);
            // 
            // fechaRecDateTimePicker
            // 
            this.fechaRecDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cobrosBindingSource, "FechaRec", true));
            this.fechaRecDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaRecDateTimePicker.Location = new System.Drawing.Point(601, 71);
            this.fechaRecDateTimePicker.Name = "fechaRecDateTimePicker";
            this.fechaRecDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.fechaRecDateTimePicker.TabIndex = 54;
            // 
            // fechaAbonoDateTimePicker
            // 
            this.fechaAbonoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cobrosBindingSource, "FechaAbono", true));
            this.fechaAbonoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaAbonoDateTimePicker.Location = new System.Drawing.Point(601, 98);
            this.fechaAbonoDateTimePicker.Name = "fechaAbonoDateTimePicker";
            this.fechaAbonoDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.fechaAbonoDateTimePicker.TabIndex = 56;
            // 
            // idFactCabComboBox
            // 
            this.idFactCabComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cobrosBindingSource, "IdFactCab", true));
            this.idFactCabComboBox.DataSource = this.facturasCabListaBindingSource;
            this.idFactCabComboBox.DisplayMember = "Factura";
            this.idFactCabComboBox.FormattingEnabled = true;
            this.idFactCabComboBox.Location = new System.Drawing.Point(115, 124);
            this.idFactCabComboBox.Name = "idFactCabComboBox";
            this.idFactCabComboBox.Size = new System.Drawing.Size(314, 21);
            this.idFactCabComboBox.TabIndex = 69;
            this.idFactCabComboBox.ValueMember = "IdFactCab";
            // 
            // facturasCabListaBindingSource
            // 
            this.facturasCabListaBindingSource.DataMember = "FacturasCabLista";
            this.facturasCabListaBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // fechaVctoDateTimePicker
            // 
            this.fechaVctoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cobrosBindingSource, "FechaVcto", true));
            this.fechaVctoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaVctoDateTimePicker.Location = new System.Drawing.Point(601, 125);
            this.fechaVctoDateTimePicker.Name = "fechaVctoDateTimePicker";
            this.fechaVctoDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.fechaVctoDateTimePicker.TabIndex = 58;
            // 
            // observTextBox
            // 
            this.observTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cobrosBindingSource, "Observ", true));
            this.observTextBox.Location = new System.Drawing.Point(812, 97);
            this.observTextBox.Multiline = true;
            this.observTextBox.Name = "observTextBox";
            this.observTextBox.Size = new System.Drawing.Size(218, 44);
            this.observTextBox.TabIndex = 66;
            // 
            // impBaseTextBox
            // 
            this.impBaseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cobrosBindingSource, "ImpBase", true));
            this.impBaseTextBox.Location = new System.Drawing.Point(930, 16);
            this.impBaseTextBox.Name = "impBaseTextBox";
            this.impBaseTextBox.Size = new System.Drawing.Size(100, 20);
            this.impBaseTextBox.TabIndex = 60;
            // 
            // referenciaTextBox
            // 
            this.referenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cobrosBindingSource, "Referencia", true));
            this.referenciaTextBox.Location = new System.Drawing.Point(601, 16);
            this.referenciaTextBox.Name = "referenciaTextBox";
            this.referenciaTextBox.Size = new System.Drawing.Size(204, 20);
            this.referenciaTextBox.TabIndex = 64;
            // 
            // impIVATextBox
            // 
            this.impIVATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cobrosBindingSource, "ImpIVA", true));
            this.impIVATextBox.Location = new System.Drawing.Point(930, 43);
            this.impIVATextBox.Name = "impIVATextBox";
            this.impIVATextBox.Size = new System.Drawing.Size(100, 20);
            this.impIVATextBox.TabIndex = 62;
            // 
            // cobrosTableAdapter
            // 
            this.cobrosTableAdapter.ClearBeforeFill = true;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // obrasTableAdapter
            // 
            this.obrasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccesosEmpresasTableAdapter = null;
            this.tableAdapterManager.AdjuntosObrasTableAdapter = null;
            this.tableAdapterManager.AnticiposTableAdapter = null;
            this.tableAdapterManager.AnticiposTrabajadoresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BajasMedicaTableAdapter = null;
            this.tableAdapterManager.BancosTableAdapter = null;
            this.tableAdapterManager.CategoriasTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.CobrosTableAdapter = this.cobrosTableAdapter;
            this.tableAdapterManager.ComprasCabTableAdapter = null;
            this.tableAdapterManager.ComprasDetTableAdapter = null;
            this.tableAdapterManager.ConceptosBancosTableAdapter = null;
            this.tableAdapterManager.ContratosTrabajadoresTableAdapter = null;
            this.tableAdapterManager.CopiasHorasTableAdapter = null;
            this.tableAdapterManager.CrucesTrabajadoresTableAdapter = null;
            this.tableAdapterManager.CuentasTableAdapter = null;
            this.tableAdapterManager.CursosTableAdapter = null;
            this.tableAdapterManager.CursosTrabajadoresTableAdapter = null;
            this.tableAdapterManager.DescuentosFacturasTableAdapter = null;
            this.tableAdapterManager.EmpresasActualTableAdapter = null;
            this.tableAdapterManager.EmpresasTableAdapter = null;
            this.tableAdapterManager.EstadoCivilTableAdapter = null;
            this.tableAdapterManager.FabricantesTableAdapter = null;
            this.tableAdapterManager.FacturasCabListaTableAdapter = null;
            this.tableAdapterManager.FacturasCabTableAdapter = null;
            this.tableAdapterManager.FacturasDetHorasTableAdapter = null;
            this.tableAdapterManager.FacturasDetTableAdapter = null;
            this.tableAdapterManager.FestivosEmpresasTableAdapter = null;
            this.tableAdapterManager.FestivosObrasDiaTableAdapter = null;
            this.tableAdapterManager.FestivosObrasTableAdapter = null;
            this.tableAdapterManager.FormasPagoTableAdapter = null;
            this.tableAdapterManager.GruposProductosTableAdapter = null;
            this.tableAdapterManager.HijosTrabajadoresTableAdapter = null;
            this.tableAdapterManager.HorasAdminTableAdapter = null;
            this.tableAdapterManager.HorasTrabajadasTableAdapter = null;
            this.tableAdapterManager.HorasTrabajadoresTableAdapter = null;
            this.tableAdapterManager.NacionesTableAdapter = null;
            this.tableAdapterManager.ObrasTableAdapter = this.obrasTableAdapter;
            this.tableAdapterManager.OperacionesBancoTableAdapter = null;
            this.tableAdapterManager.PagosTableAdapter = null;
            this.tableAdapterManager.ParticipantesTableAdapter = null;
            this.tableAdapterManager.PartObrasTableAdapter = null;
            this.tableAdapterManager.PartPresupTableAdapter = null;
            this.tableAdapterManager.Poblaciones1TableAdapter = null;
            this.tableAdapterManager.PoblacionesProvincias1TableAdapter = null;
            this.tableAdapterManager.PoblacionesProvinciasTableAdapter = null;
            this.tableAdapterManager.PoblacionesTableAdapter = null;
            this.tableAdapterManager.PresupCabTableAdapter = null;
            this.tableAdapterManager.PresupCapTableAdapter = null;
            this.tableAdapterManager.PresupDetTableAdapter = null;
            this.tableAdapterManager.PresupSubTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProductosUtilizadosTableAdapter = null;
            this.tableAdapterManager.ProductosUtTrabajadoresTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.Provincias1TableAdapter = null;
            this.tableAdapterManager.ProvinciasTableAdapter = null;
            this.tableAdapterManager.PuestosTrabajoTableAdapter = null;
            this.tableAdapterManager.SalariosTiposTableAdapter = null;
            this.tableAdapterManager.SalariosVentaAdminTableAdapter = null;
            this.tableAdapterManager.SalariosVentaTableAdapter = null;
            this.tableAdapterManager.SeguridadSocialTableAdapter = null;
            this.tableAdapterManager.TiposProductosTableAdapter = null;
            this.tableAdapterManager.TiposProveedoresTableAdapter = null;
            this.tableAdapterManager.TiposTableAdapter = null;
            this.tableAdapterManager.TrabajadoresListaTableAdapter = null;
            this.tableAdapterManager.TrabajadoresTableAdapter = null;
            this.tableAdapterManager.UMedidasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionData.Promowork_dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // formasPagoTableAdapter
            // 
            this.formasPagoTableAdapter.ClearBeforeFill = true;
            // 
            // cuentasBancosTableAdapter
            // 
            this.cuentasBancosTableAdapter.ClearBeforeFill = true;
            // 
            // facturasCabListaTableAdapter
            // 
            this.facturasCabListaTableAdapter.ClearBeforeFill = true;
            // 
            // anosCobrosBindingSource
            // 
            this.anosCobrosBindingSource.DataMember = "AnosCobros";
            this.anosCobrosBindingSource.DataSource = this.promowork_dataDataSet;
            // 
            // anosCobrosTableAdapter
            // 
            this.anosCobrosTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // frmCobros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 558);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmCobros";
            this.Text = "Cobros";
            this.Load += new System.EventHandler(this.frmCobros_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cobrosBindingNavigator)).EndInit();
            this.cobrosBindingNavigator.ResumeLayout(false);
            this.cobrosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormasPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formasPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previsionCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasCabListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anosCobrosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.BindingNavigator cobrosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton cobrosBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl cobrosGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colIdObra;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaExp;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaRec;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaAbono;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaVcto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFactCab;
        private DevExpress.XtraGrid.Columns.GridColumn colFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colImpBase;
        private DevExpress.XtraGrid.Columns.GridColumn colImpIVA;
        private DevExpress.XtraGrid.Columns.GridColumn colReferencia;
        private DevExpress.XtraGrid.Columns.GridColumn colObserv;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colCopiaFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colEnBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colPrevision;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Clientes;
        private DevExpress.XtraEditors.CheckEdit previsionCheckEdit;
        private System.Windows.Forms.ComboBox idFormaPagoComboBox;
        private System.Windows.Forms.ComboBox idCuentaComboBox;
        private System.Windows.Forms.ComboBox idClienteComboBox;
        private System.Windows.Forms.ComboBox idObraComboBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.DateTimePicker fechaExpDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaRecDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaAbonoDateTimePicker;
        private System.Windows.Forms.ComboBox idFactCabComboBox;
        private System.Windows.Forms.DateTimePicker fechaVctoDateTimePicker;
        private System.Windows.Forms.TextBox observTextBox;
        private System.Windows.Forms.TextBox impBaseTextBox;
        private System.Windows.Forms.TextBox referenciaTextBox;
        private System.Windows.Forms.TextBox impIVATextBox;
        private GestionData.Promowork_dataDataSet promowork_dataDataSet;
        private System.Windows.Forms.BindingSource cobrosBindingSource;
        private GestionData.Promowork_dataDataSetTableAdapters.CobrosTableAdapter cobrosTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private GestionData.Promowork_dataDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Obras;
        private System.Windows.Forms.BindingSource obrasBindingSource;
        private GestionData.Promowork_dataDataSetTableAdapters.ObrasTableAdapter obrasTableAdapter;
        private GestionData.Promowork_dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource obrasBindingSource1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit FormasPago;
        private System.Windows.Forms.BindingSource formasPagoBindingSource;
        private GestionData.Promowork_dataDataSetTableAdapters.FormasPagoTableAdapter formasPagoTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Cuentas;
        private System.Windows.Forms.BindingSource cuentasBancosBindingSource;
        private GestionData.Promowork_dataDataSetTableAdapters.CuentasBancosTableAdapter cuentasBancosTableAdapter;
        private System.Windows.Forms.BindingSource facturasCabListaBindingSource;
        private GestionData.Promowork_dataDataSetTableAdapters.FacturasCabListaTableAdapter facturasCabListaTableAdapter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cbxAnosCobros;
        private System.Windows.Forms.BindingSource anosCobrosBindingSource;
        private GestionData.Promowork_dataDataSetTableAdapters.AnosCobrosTableAdapter anosCobrosTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFactCab1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btVincular;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}