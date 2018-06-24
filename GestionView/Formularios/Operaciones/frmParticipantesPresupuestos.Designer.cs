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
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.participantesPresupuestosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.proveedoresParticipantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.participantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomPresupTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProveedorParticipante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdParticipantePresupuesto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.cbParticipante = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.colIdProveedor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionado2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionado3 = new DevExpress.XtraGrid.Columns.GridColumn();
            nomPresupLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.participantesPresupuestosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantesPresupuestosBindingNavigator)).BeginInit();
            this.participantesPresupuestosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresParticipantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomPresupTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbParticipante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // nomPresupLabel
            // 
            nomPresupLabel.AutoSize = true;
            nomPresupLabel.Location = new System.Drawing.Point(21, 48);
            nomPresupLabel.Name = "nomPresupLabel";
            nomPresupLabel.Size = new System.Drawing.Size(68, 13);
            nomPresupLabel.TabIndex = 3;
            nomPresupLabel.Text = "Nom Presup:";
            // 
            // participantesPresupuestosBindingSource
            // 
            this.participantesPresupuestosBindingSource.DataSource = typeof(GestionData.Modelos.ParticipantesPresupuestos);
            // 
            // participantesPresupuestosBindingNavigator
            // 
            this.participantesPresupuestosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.participantesPresupuestosBindingNavigator.BindingSource = this.participantesPresupuestosBindingSource;
            this.participantesPresupuestosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.participantesPresupuestosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
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
            // participantesPresupuestosBindingNavigatorSaveItem
            // 
            this.participantesPresupuestosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.participantesPresupuestosBindingNavigatorSaveItem.Enabled = false;
            this.participantesPresupuestosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("participantesPresupuestosBindingNavigatorSaveItem.Image")));
            this.participantesPresupuestosBindingNavigatorSaveItem.Name = "participantesPresupuestosBindingNavigatorSaveItem";
            this.participantesPresupuestosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.participantesPresupuestosBindingNavigatorSaveItem.Text = "Guardar datos";
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
            this.nomPresupTextEdit.Location = new System.Drawing.Point(95, 45);
            this.nomPresupTextEdit.Name = "nomPresupTextEdit";
            this.nomPresupTextEdit.Size = new System.Drawing.Size(378, 20);
            this.nomPresupTextEdit.TabIndex = 4;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProveedorParticipante,
            this.colIdParticipantePresupuesto1,
            this.colIdProveedor,
            this.colPrecio,
            this.colSeleccionado});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colIdProveedorParticipante
            // 
            this.colIdProveedorParticipante.FieldName = "IdProveedorParticipante";
            this.colIdProveedorParticipante.Name = "colIdProveedorParticipante";
            // 
            // colIdParticipantePresupuesto1
            // 
            this.colIdParticipantePresupuesto1.FieldName = "IdParticipantePresupuesto";
            this.colIdParticipantePresupuesto1.Name = "colIdParticipantePresupuesto1";
            // 
            // colIdProveedor
            // 
            this.colIdProveedor.FieldName = "IdProveedor";
            this.colIdProveedor.Name = "colIdProveedor";
            this.colIdProveedor.Visible = true;
            this.colIdProveedor.VisibleIndex = 0;
            // 
            // colPrecio
            // 
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 1;
            // 
            // colSeleccionado
            // 
            this.colSeleccionado.FieldName = "Seleccionado";
            this.colSeleccionado.Name = "colSeleccionado";
            this.colSeleccionado.Visible = true;
            this.colSeleccionado.VisibleIndex = 2;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.proveedoresParticipantesBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(12, 247);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(329, 152);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colIdParticipantePresupuesto
            // 
            this.colIdParticipantePresupuesto.FieldName = "IdParticipantePresupuesto";
            this.colIdParticipantePresupuesto.Name = "colIdParticipantePresupuesto";
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // colIdPresupCab
            // 
            this.colIdPresupCab.Caption = "Presupuesto";
            this.colIdPresupCab.FieldName = "PresupCab";
            this.colIdPresupCab.Name = "colIdPresupCab";
            this.colIdPresupCab.Width = 114;
            // 
            // colIdPresupCap
            // 
            this.colIdPresupCap.Caption = "Capítulo";
            this.colIdPresupCap.FieldName = "PresupCap.DesCapPresup";
            this.colIdPresupCap.Name = "colIdPresupCap";
            this.colIdPresupCap.Visible = true;
            this.colIdPresupCap.VisibleIndex = 0;
            this.colIdPresupCap.Width = 128;
            // 
            // colIdPresupDet
            // 
            this.colIdPresupDet.Caption = "Detalle";
            this.colIdPresupDet.FieldName = "PresupDet.NomPresupDet";
            this.colIdPresupDet.Name = "colIdPresupDet";
            this.colIdPresupDet.Visible = true;
            this.colIdPresupDet.VisibleIndex = 1;
            this.colIdPresupDet.Width = 125;
            // 
            // colIdPresupSub
            // 
            this.colIdPresupSub.Caption = "Subdetalle";
            this.colIdPresupSub.FieldName = "PresupSub.NomPresupSub";
            this.colIdPresupSub.Name = "colIdPresupSub";
            this.colIdPresupSub.Visible = true;
            this.colIdPresupSub.VisibleIndex = 2;
            this.colIdPresupSub.Width = 158;
            // 
            // colNombrePartida
            // 
            this.colNombrePartida.FieldName = "NombrePartida";
            this.colNombrePartida.Name = "colNombrePartida";
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
            this.colIdParticipante.Width = 209;
            // 
            // colEsServicio
            // 
            this.colEsServicio.FieldName = "EsServicio";
            this.colEsServicio.Name = "colEsServicio";
            this.colEsServicio.Visible = true;
            this.colEsServicio.VisibleIndex = 4;
            this.colEsServicio.Width = 56;
            // 
            // colFechaCrea
            // 
            this.colFechaCrea.FieldName = "FechaCrea";
            this.colFechaCrea.Name = "colFechaCrea";
            // 
            // colFechaModifica
            // 
            this.colFechaModifica.FieldName = "FechaModifica";
            this.colFechaModifica.Name = "colFechaModifica";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.participantesPresupuestosBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 90);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbParticipante});
            this.gridControl1.Size = new System.Drawing.Size(1147, 142);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // colIdProveedor1
            // 
            this.colIdProveedor1.FieldName = "IdProveedor1";
            this.colIdProveedor1.Name = "colIdProveedor1";
            this.colIdProveedor1.Visible = true;
            this.colIdProveedor1.VisibleIndex = 5;
            // 
            // colIdProveedor2
            // 
            this.colIdProveedor2.FieldName = "IdProveedor2";
            this.colIdProveedor2.Name = "colIdProveedor2";
            this.colIdProveedor2.Visible = true;
            this.colIdProveedor2.VisibleIndex = 6;
            // 
            // colIdProveedor3
            // 
            this.colIdProveedor3.FieldName = "IdProveedor3";
            this.colIdProveedor3.Name = "colIdProveedor3";
            this.colIdProveedor3.Visible = true;
            this.colIdProveedor3.VisibleIndex = 7;
            // 
            // colPrecio1
            // 
            this.colPrecio1.FieldName = "Precio1";
            this.colPrecio1.Name = "colPrecio1";
            this.colPrecio1.Visible = true;
            this.colPrecio1.VisibleIndex = 8;
            // 
            // colPrecio2
            // 
            this.colPrecio2.FieldName = "Precio2";
            this.colPrecio2.Name = "colPrecio2";
            this.colPrecio2.Visible = true;
            this.colPrecio2.VisibleIndex = 9;
            // 
            // colPrecio3
            // 
            this.colPrecio3.FieldName = "Precio3";
            this.colPrecio3.Name = "colPrecio3";
            this.colPrecio3.Visible = true;
            this.colPrecio3.VisibleIndex = 10;
            // 
            // colSeleccionado1
            // 
            this.colSeleccionado1.FieldName = "Seleccionado1";
            this.colSeleccionado1.Name = "colSeleccionado1";
            this.colSeleccionado1.Visible = true;
            this.colSeleccionado1.VisibleIndex = 11;
            // 
            // colSeleccionado2
            // 
            this.colSeleccionado2.FieldName = "Seleccionado2";
            this.colSeleccionado2.Name = "colSeleccionado2";
            this.colSeleccionado2.Visible = true;
            this.colSeleccionado2.VisibleIndex = 12;
            // 
            // colSeleccionado3
            // 
            this.colSeleccionado3.FieldName = "Seleccionado3";
            this.colSeleccionado3.Name = "colSeleccionado3";
            this.colSeleccionado3.Visible = true;
            this.colSeleccionado3.VisibleIndex = 13;
            // 
            // frmParticipantesPresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 469);
            this.Controls.Add(nomPresupLabel);
            this.Controls.Add(this.nomPresupTextEdit);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.participantesPresupuestosBindingNavigator);
            this.Name = "frmParticipantesPresupuestos";
            this.Text = "frmParticipantesPresupuestos";
            this.Load += new System.EventHandler(this.frmParticipantesPresupuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.participantesPresupuestosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantesPresupuestosBindingNavigator)).EndInit();
            this.participantesPresupuestosBindingNavigator.ResumeLayout(false);
            this.participantesPresupuestosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresParticipantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomPresupTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbParticipante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
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
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedorParticipante;
        private DevExpress.XtraGrid.Columns.GridColumn colIdParticipantePresupuesto1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionado;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbParticipante;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
    }
}