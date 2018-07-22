namespace Promowork.Formularios.Operaciones
{
    partial class frmParticipantesPresupuestos
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
            System.Windows.Forms.Label nomPresupLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParticipantesPresupuestos));
            this.participantesPresupuestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.participantesPresupuestosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.participantesPresupuestosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.proveedoresParticipantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.participantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomPresupTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cbParticipante = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gvParticipantesPresupuestos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdParticipantePresupuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPresupCab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPresupCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPresupDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPresupSub = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombrePartida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdParticipante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEsServicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCrea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModifica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbProveedores = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colIdProveedor2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionado2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionado3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.chkMostrarTodoPresupuesto = new DevExpress.XtraEditors.CheckEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            nomPresupLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.participantesPresupuestosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantesPresupuestosBindingNavigator)).BeginInit();
            this.participantesPresupuestosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresParticipantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomPresupTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbParticipante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvParticipantesPresupuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMostrarTodoPresupuesto.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomPresupLabel
            // 
            nomPresupLabel.AutoSize = true;
            nomPresupLabel.Location = new System.Drawing.Point(13, 16);
            nomPresupLabel.Name = "nomPresupLabel";
            nomPresupLabel.Size = new System.Drawing.Size(69, 13);
            nomPresupLabel.TabIndex = 3;
            nomPresupLabel.Text = "Presupuesto:";
            // 
            // participantesPresupuestosBindingSource
            // 
            this.participantesPresupuestosBindingSource.DataSource = typeof(GestionData.Modelos.ParticipantesPresupuestos);
            // 
            // participantesPresupuestosBindingNavigator
            // 
            this.participantesPresupuestosBindingNavigator.AddNewItem = null;
            this.participantesPresupuestosBindingNavigator.BindingSource = this.participantesPresupuestosBindingSource;
            this.participantesPresupuestosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.participantesPresupuestosBindingNavigator.DeleteItem = null;
            this.participantesPresupuestosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.participantesPresupuestosBindingNavigatorSaveItem});
            this.participantesPresupuestosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.participantesPresupuestosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.participantesPresupuestosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.participantesPresupuestosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.participantesPresupuestosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.participantesPresupuestosBindingNavigator.Name = "participantesPresupuestosBindingNavigator";
            this.participantesPresupuestosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.participantesPresupuestosBindingNavigator.Size = new System.Drawing.Size(1194, 25);
            this.participantesPresupuestosBindingNavigator.TabIndex = 0;
            this.participantesPresupuestosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
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
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::Promowork.Properties.Resources.Duplicar_32;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Duplicar";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // participantesPresupuestosBindingNavigatorSaveItem
            // 
            this.participantesPresupuestosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.participantesPresupuestosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("participantesPresupuestosBindingNavigatorSaveItem.Image")));
            this.participantesPresupuestosBindingNavigatorSaveItem.Name = "participantesPresupuestosBindingNavigatorSaveItem";
            this.participantesPresupuestosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.participantesPresupuestosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.participantesPresupuestosBindingNavigatorSaveItem.Click += new System.EventHandler(this.participantesPresupuestosBindingNavigatorSaveItem_Click);
            // 
            // proveedoresParticipantesBindingSource
            // 
            this.proveedoresParticipantesBindingSource.DataSource = typeof(GestionData.Modelos.ProveedoresParticipantes);
            // 
            // participantesBindingSource
            // 
            this.participantesBindingSource.DataSource = typeof(GestionData.Modelos.Participantes);
            // 
            // nomPresupTextEdit
            // 
            this.nomPresupTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.participantesPresupuestosBindingSource, "PresupCab.NomPresup", true));
            this.nomPresupTextEdit.Location = new System.Drawing.Point(87, 12);
            this.nomPresupTextEdit.Name = "nomPresupTextEdit";
            this.nomPresupTextEdit.Properties.ReadOnly = true;
            this.nomPresupTextEdit.Size = new System.Drawing.Size(378, 20);
            this.nomPresupTextEdit.TabIndex = 4;
            // 
            // cbParticipante
            // 
            this.cbParticipante.AutoHeight = false;
            this.cbParticipante.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbParticipante.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesParticipante", "Participante", 88, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cbParticipante.DataSource = this.participantesBindingSource;
            this.cbParticipante.DisplayMember = "DesParticipante";
            this.cbParticipante.Name = "cbParticipante";
            this.cbParticipante.ValueMember = "IdParticipante";
            // 
            // gvParticipantesPresupuestos
            // 
            this.gvParticipantesPresupuestos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdParticipantePresupuesto,
            this.colIdEmpresa,
            this.colIdUsuario,
            this.colIdPresupCab,
            this.colIdPresupCap,
            this.colIdPresupDet,
            this.colIdPresupSub,
            this.colNombrePartida,
            this.colIdParticipante,
            this.colEsServicio,
            this.colFechaCrea,
            this.colFechaModifica,
            this.colIdProveedor1,
            this.colIdProveedor2,
            this.colIdProveedor3,
            this.colPrecio1,
            this.colPrecio2,
            this.colPrecio3,
            this.colSeleccionado1,
            this.colSeleccionado2,
            this.colSeleccionado3});
            this.gvParticipantesPresupuestos.GridControl = this.gridControl1;
            this.gvParticipantesPresupuestos.Name = "gvParticipantesPresupuestos";
            this.gvParticipantesPresupuestos.OptionsView.ShowAutoFilterRow = true;
            // 
            // colIdParticipantePresupuesto
            // 
            this.colIdParticipantePresupuesto.FieldName = "IdParticipantePresupuesto";
            this.colIdParticipantePresupuesto.Name = "colIdParticipantePresupuesto";
            this.colIdParticipantePresupuesto.OptionsColumn.ReadOnly = true;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.ReadOnly = true;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.OptionsColumn.ReadOnly = true;
            // 
            // colIdPresupCab
            // 
            this.colIdPresupCab.Caption = "Presupuesto";
            this.colIdPresupCab.FieldName = "PresupCab";
            this.colIdPresupCab.Name = "colIdPresupCab";
            this.colIdPresupCab.OptionsColumn.ReadOnly = true;
            this.colIdPresupCab.Width = 114;
            // 
            // colIdPresupCap
            // 
            this.colIdPresupCap.Caption = "Capítulo";
            this.colIdPresupCap.FieldName = "PresupCap.DesCapPresup";
            this.colIdPresupCap.Name = "colIdPresupCap";
            this.colIdPresupCap.OptionsColumn.ReadOnly = true;
            this.colIdPresupCap.Visible = true;
            this.colIdPresupCap.VisibleIndex = 0;
            this.colIdPresupCap.Width = 106;
            // 
            // colIdPresupDet
            // 
            this.colIdPresupDet.Caption = "Detalle";
            this.colIdPresupDet.FieldName = "PresupDet.NomPresupDet";
            this.colIdPresupDet.Name = "colIdPresupDet";
            this.colIdPresupDet.OptionsColumn.ReadOnly = true;
            this.colIdPresupDet.Visible = true;
            this.colIdPresupDet.VisibleIndex = 1;
            this.colIdPresupDet.Width = 104;
            // 
            // colIdPresupSub
            // 
            this.colIdPresupSub.Caption = "Subdetalle";
            this.colIdPresupSub.FieldName = "PresupSub.NomPresupSub";
            this.colIdPresupSub.Name = "colIdPresupSub";
            this.colIdPresupSub.OptionsColumn.ReadOnly = true;
            this.colIdPresupSub.Visible = true;
            this.colIdPresupSub.VisibleIndex = 2;
            this.colIdPresupSub.Width = 132;
            // 
            // colNombrePartida
            // 
            this.colNombrePartida.FieldName = "NombrePartida";
            this.colNombrePartida.Name = "colNombrePartida";
            this.colNombrePartida.OptionsColumn.ReadOnly = true;
            this.colNombrePartida.Width = 260;
            // 
            // colIdParticipante
            // 
            this.colIdParticipante.Caption = "Paricipante";
            this.colIdParticipante.ColumnEdit = this.cbParticipante;
            this.colIdParticipante.FieldName = "IdParticipante";
            this.colIdParticipante.Name = "colIdParticipante";
            this.colIdParticipante.Visible = true;
            this.colIdParticipante.VisibleIndex = 3;
            this.colIdParticipante.Width = 149;
            // 
            // colEsServicio
            // 
            this.colEsServicio.Caption = "Servicio";
            this.colEsServicio.FieldName = "EsServicio";
            this.colEsServicio.Name = "colEsServicio";
            this.colEsServicio.Visible = true;
            this.colEsServicio.VisibleIndex = 4;
            this.colEsServicio.Width = 47;
            // 
            // colFechaCrea
            // 
            this.colFechaCrea.FieldName = "FechaCrea";
            this.colFechaCrea.Name = "colFechaCrea";
            this.colFechaCrea.OptionsColumn.ReadOnly = true;
            // 
            // colFechaModifica
            // 
            this.colFechaModifica.FieldName = "FechaModifica";
            this.colFechaModifica.Name = "colFechaModifica";
            this.colFechaModifica.OptionsColumn.ReadOnly = true;
            // 
            // colIdProveedor1
            // 
            this.colIdProveedor1.Caption = "Proveedor1";
            this.colIdProveedor1.ColumnEdit = this.cbProveedores;
            this.colIdProveedor1.FieldName = "IdProveedor1";
            this.colIdProveedor1.Name = "colIdProveedor1";
            this.colIdProveedor1.Visible = true;
            this.colIdProveedor1.VisibleIndex = 5;
            this.colIdProveedor1.Width = 103;
            // 
            // cbProveedores
            // 
            this.cbProveedores.AutoHeight = false;
            this.cbProveedores.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProveedores.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesProveedor", "Proveedor", 81, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cbProveedores.DataSource = this.proveedoresBindingSource;
            this.cbProveedores.DisplayMember = "DesProveedor";
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.ValueMember = "IdProveedor";
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataSource = typeof(GestionData.Modelos.Proveedores);
            // 
            // colIdProveedor2
            // 
            this.colIdProveedor2.Caption = "Proveedor2";
            this.colIdProveedor2.ColumnEdit = this.cbProveedores;
            this.colIdProveedor2.FieldName = "IdProveedor2";
            this.colIdProveedor2.Name = "colIdProveedor2";
            this.colIdProveedor2.Visible = true;
            this.colIdProveedor2.VisibleIndex = 8;
            this.colIdProveedor2.Width = 90;
            // 
            // colIdProveedor3
            // 
            this.colIdProveedor3.Caption = "Proveedor3";
            this.colIdProveedor3.ColumnEdit = this.cbProveedores;
            this.colIdProveedor3.FieldName = "IdProveedor3";
            this.colIdProveedor3.Name = "colIdProveedor3";
            this.colIdProveedor3.Visible = true;
            this.colIdProveedor3.VisibleIndex = 11;
            this.colIdProveedor3.Width = 84;
            // 
            // colPrecio1
            // 
            this.colPrecio1.DisplayFormat.FormatString = "C2";
            this.colPrecio1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecio1.FieldName = "Precio1";
            this.colPrecio1.Name = "colPrecio1";
            this.colPrecio1.Visible = true;
            this.colPrecio1.VisibleIndex = 6;
            this.colPrecio1.Width = 52;
            // 
            // colPrecio2
            // 
            this.colPrecio2.DisplayFormat.FormatString = "C2";
            this.colPrecio2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecio2.FieldName = "Precio2";
            this.colPrecio2.Name = "colPrecio2";
            this.colPrecio2.Visible = true;
            this.colPrecio2.VisibleIndex = 9;
            this.colPrecio2.Width = 53;
            // 
            // colPrecio3
            // 
            this.colPrecio3.DisplayFormat.FormatString = "C2";
            this.colPrecio3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecio3.FieldName = "Precio3";
            this.colPrecio3.Name = "colPrecio3";
            this.colPrecio3.Visible = true;
            this.colPrecio3.VisibleIndex = 12;
            this.colPrecio3.Width = 68;
            // 
            // colSeleccionado1
            // 
            this.colSeleccionado1.Caption = " ";
            this.colSeleccionado1.FieldName = "Seleccionado1";
            this.colSeleccionado1.Name = "colSeleccionado1";
            this.colSeleccionado1.Visible = true;
            this.colSeleccionado1.VisibleIndex = 7;
            this.colSeleccionado1.Width = 46;
            // 
            // colSeleccionado2
            // 
            this.colSeleccionado2.Caption = " ";
            this.colSeleccionado2.FieldName = "Seleccionado2";
            this.colSeleccionado2.Name = "colSeleccionado2";
            this.colSeleccionado2.Visible = true;
            this.colSeleccionado2.VisibleIndex = 10;
            this.colSeleccionado2.Width = 44;
            // 
            // colSeleccionado3
            // 
            this.colSeleccionado3.Caption = " ";
            this.colSeleccionado3.FieldName = "Seleccionado3";
            this.colSeleccionado3.Name = "colSeleccionado3";
            this.colSeleccionado3.Visible = true;
            this.colSeleccionado3.VisibleIndex = 13;
            this.colSeleccionado3.Width = 51;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.participantesPresupuestosBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 70);
            this.gridControl1.MainView = this.gvParticipantesPresupuestos;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbParticipante,
            this.cbProveedores});
            this.gridControl1.Size = new System.Drawing.Size(1194, 399);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvParticipantesPresupuestos});
            // 
            // chkMostrarTodoPresupuesto
            // 
            this.chkMostrarTodoPresupuesto.Location = new System.Drawing.Point(498, 13);
            this.chkMostrarTodoPresupuesto.Name = "chkMostrarTodoPresupuesto";
            this.chkMostrarTodoPresupuesto.Properties.Caption = "Mostrar Todo los participantes del Presupuesto";
            this.chkMostrarTodoPresupuesto.Size = new System.Drawing.Size(268, 19);
            this.chkMostrarTodoPresupuesto.TabIndex = 5;
            this.chkMostrarTodoPresupuesto.CheckedChanged += new System.EventHandler(this.chkMostrarTodoPresupuesto_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkMostrarTodoPresupuesto);
            this.panel1.Controls.Add(nomPresupLabel);
            this.panel1.Controls.Add(this.nomPresupTextEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 45);
            this.panel1.TabIndex = 6;
            // 
            // frmParticipantesPresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 469);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.participantesPresupuestosBindingNavigator);
            this.Name = "frmParticipantesPresupuestos";
            this.Text = "frmParticipantesPresupuestos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmParticipantesPresupuestos_FormClosing);
            this.Load += new System.EventHandler(this.frmParticipantesPresupuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.participantesPresupuestosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantesPresupuestosBindingNavigator)).EndInit();
            this.participantesPresupuestosBindingNavigator.ResumeLayout(false);
            this.participantesPresupuestosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresParticipantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomPresupTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbParticipante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvParticipantesPresupuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMostrarTodoPresupuesto.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource participantesPresupuestosBindingSource;
        private System.Windows.Forms.BindingNavigator participantesPresupuestosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton participantesPresupuestosBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource proveedoresParticipantesBindingSource;
        private System.Windows.Forms.BindingSource participantesBindingSource;
        private DevExpress.XtraEditors.TextEdit nomPresupTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbParticipante;
        private DevExpress.XtraGrid.Views.Grid.GridView gvParticipantesPresupuestos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdParticipantePresupuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresupCab;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresupCap;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresupDet;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresupSub;
        private DevExpress.XtraGrid.Columns.GridColumn colNombrePartida;
        private DevExpress.XtraGrid.Columns.GridColumn colIdParticipante;
        private DevExpress.XtraGrid.Columns.GridColumn colEsServicio;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCrea;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModifica;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor3;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio1;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio2;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio3;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionado1;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionado2;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionado3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbProveedores;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private DevExpress.XtraEditors.CheckEdit chkMostrarTodoPresupuesto;
        private System.Windows.Forms.Panel panel1;
    }
}