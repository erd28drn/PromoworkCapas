namespace Promowork.Formularios.Definiciones
{
    partial class frmParticipantesDocumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParticipantesDocumentos));
            this.documentosParticipantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentosParticipantesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.participantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.documentosParticipantesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gvParticipantes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdParticipantegvParticipantes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesParticipante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActivoParticipante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gvDocumentosParticipante = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdDocumentoParticipante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdParticipante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioCrea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCrea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumentos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.DocumentosDisponibleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvDocumentosDisponibles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdDocumentoDisponible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btAddDocumentoParticipante = new System.Windows.Forms.ToolStripButton();
            this.btRemoveDocumentoParticipante = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.documentosParticipantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosParticipantesBindingNavigator)).BeginInit();
            this.documentosParticipantesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.participantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvParticipantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocumentosParticipante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentosDisponibleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocumentosDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // documentosParticipantesBindingSource
            // 
            this.documentosParticipantesBindingSource.DataSource = typeof(GestionData.Modelos.DocumentosParticipantes);
            // 
            // documentosParticipantesBindingNavigator
            // 
            this.documentosParticipantesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.documentosParticipantesBindingNavigator.BindingSource = this.participantesBindingSource;
            this.documentosParticipantesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.documentosParticipantesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.documentosParticipantesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.documentosParticipantesBindingNavigatorSaveItem});
            this.documentosParticipantesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.documentosParticipantesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.documentosParticipantesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.documentosParticipantesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.documentosParticipantesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.documentosParticipantesBindingNavigator.Name = "documentosParticipantesBindingNavigator";
            this.documentosParticipantesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.documentosParticipantesBindingNavigator.Size = new System.Drawing.Size(500, 25);
            this.documentosParticipantesBindingNavigator.TabIndex = 0;
            this.documentosParticipantesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // participantesBindingSource
            // 
            this.participantesBindingSource.DataSource = typeof(GestionData.Modelos.Participantes);
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // documentosParticipantesBindingNavigatorSaveItem
            // 
            this.documentosParticipantesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.documentosParticipantesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("documentosParticipantesBindingNavigatorSaveItem.Image")));
            this.documentosParticipantesBindingNavigatorSaveItem.Name = "documentosParticipantesBindingNavigatorSaveItem";
            this.documentosParticipantesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.documentosParticipantesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.documentosParticipantesBindingNavigatorSaveItem.Click += new System.EventHandler(this.documentosParticipantesBindingNavigatorSaveItem_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.participantesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 25);
            this.gridControl1.MainView = this.gvParticipantes;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(500, 439);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvParticipantes});
            // 
            // gvParticipantes
            // 
            this.gvParticipantes.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvParticipantes.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvParticipantes.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvParticipantes.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvParticipantes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdParticipantegvParticipantes,
            this.colDesParticipante,
            this.colActivoParticipante,
            this.colIdEmpresa1});
            this.gvParticipantes.GridControl = this.gridControl1;
            this.gvParticipantes.Name = "gvParticipantes";
            this.gvParticipantes.OptionsView.ShowAutoFilterRow = true;
            this.gvParticipantes.OptionsView.ShowGroupPanel = false;
            this.gvParticipantes.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvParticipantes_FocusedRowChanged);
            this.gvParticipantes.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvParticipantes_CellValueChanged);
            // 
            // colIdParticipantegvParticipantes
            // 
            this.colIdParticipantegvParticipantes.FieldName = "IdParticipante";
            this.colIdParticipantegvParticipantes.Name = "colIdParticipantegvParticipantes";
            this.colIdParticipantegvParticipantes.OptionsColumn.ReadOnly = true;
            // 
            // colDesParticipante
            // 
            this.colDesParticipante.Caption = "Participante";
            this.colDesParticipante.FieldName = "DesParticipante";
            this.colDesParticipante.Name = "colDesParticipante";
            this.colDesParticipante.Visible = true;
            this.colDesParticipante.VisibleIndex = 0;
            // 
            // colActivoParticipante
            // 
            this.colActivoParticipante.FieldName = "ActivoParticipante";
            this.colActivoParticipante.Name = "colActivoParticipante";
            // 
            // colIdEmpresa1
            // 
            this.colIdEmpresa1.FieldName = "IdEmpresa";
            this.colIdEmpresa1.Name = "colIdEmpresa1";
            this.colIdEmpresa1.OptionsColumn.ReadOnly = true;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.documentosParticipantesBindingNavigator);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1020, 464);
            this.splitContainerControl1.SplitterPosition = 500;
            this.splitContainerControl1.TabIndex = 3;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.gridControl2);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.gridControl3);
            this.splitContainerControl2.Panel2.Controls.Add(this.bindingNavigator1);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(515, 464);
            this.splitContainerControl2.SplitterPosition = 212;
            this.splitContainerControl2.TabIndex = 4;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.documentosParticipantesBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gvDocumentosParticipante;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(515, 212);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDocumentosParticipante});
            // 
            // gvDocumentosParticipante
            // 
            this.gvDocumentosParticipante.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvDocumentosParticipante.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvDocumentosParticipante.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvDocumentosParticipante.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvDocumentosParticipante.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdDocumentoParticipante,
            this.colIdEmpresa,
            this.colIdParticipante,
            this.colIdDocumento,
            this.colUsuarioCrea,
            this.colFechaCrea,
            this.colDocumentos});
            this.gvDocumentosParticipante.GridControl = this.gridControl2;
            this.gvDocumentosParticipante.Name = "gvDocumentosParticipante";
            this.gvDocumentosParticipante.OptionsBehavior.Editable = false;
            this.gvDocumentosParticipante.OptionsBehavior.ReadOnly = true;
            this.gvDocumentosParticipante.OptionsNavigation.AutoFocusNewRow = true;
            this.gvDocumentosParticipante.OptionsView.ShowAutoFilterRow = true;
            this.gvDocumentosParticipante.OptionsView.ShowGroupPanel = false;
            this.gvDocumentosParticipante.DoubleClick += new System.EventHandler(this.gvDocumentosParticipante_DoubleClick);
            // 
            // colIdDocumentoParticipante
            // 
            this.colIdDocumentoParticipante.FieldName = "IdDocumentoParticipante";
            this.colIdDocumentoParticipante.Name = "colIdDocumentoParticipante";
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdParticipante
            // 
            this.colIdParticipante.FieldName = "IdParticipante";
            this.colIdParticipante.Name = "colIdParticipante";
            // 
            // colIdDocumento
            // 
            this.colIdDocumento.FieldName = "IdDocumento";
            this.colIdDocumento.Name = "colIdDocumento";
            // 
            // colUsuarioCrea
            // 
            this.colUsuarioCrea.FieldName = "UsuarioCrea";
            this.colUsuarioCrea.Name = "colUsuarioCrea";
            // 
            // colFechaCrea
            // 
            this.colFechaCrea.FieldName = "FechaCrea";
            this.colFechaCrea.Name = "colFechaCrea";
            // 
            // colDocumentos
            // 
            this.colDocumentos.Caption = "Documentos Participante";
            this.colDocumentos.FieldName = "Documentos.NomDocumento";
            this.colDocumentos.Name = "colDocumentos";
            this.colDocumentos.Visible = true;
            this.colDocumentos.VisibleIndex = 0;
            // 
            // gridControl3
            // 
            this.gridControl3.DataSource = this.DocumentosDisponibleBindingSource;
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.Location = new System.Drawing.Point(0, 25);
            this.gridControl3.MainView = this.gvDocumentosDisponibles;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(515, 222);
            this.gridControl3.TabIndex = 3;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDocumentosDisponibles});
            // 
            // DocumentosDisponibleBindingSource
            // 
            this.DocumentosDisponibleBindingSource.DataSource = typeof(GestionData.Modelos.Documentos);
            // 
            // gvDocumentosDisponibles
            // 
            this.gvDocumentosDisponibles.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvDocumentosDisponibles.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvDocumentosDisponibles.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvDocumentosDisponibles.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvDocumentosDisponibles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdDocumentoDisponible,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gvDocumentosDisponibles.GridControl = this.gridControl3;
            this.gvDocumentosDisponibles.Name = "gvDocumentosDisponibles";
            this.gvDocumentosDisponibles.OptionsBehavior.Editable = false;
            this.gvDocumentosDisponibles.OptionsBehavior.ReadOnly = true;
            this.gvDocumentosDisponibles.OptionsView.ShowAutoFilterRow = true;
            this.gvDocumentosDisponibles.OptionsView.ShowGroupPanel = false;
            this.gvDocumentosDisponibles.DoubleClick += new System.EventHandler(this.gvDocumentosDisponibles_DoubleClick);
            // 
            // colIdDocumentoDisponible
            // 
            this.colIdDocumentoDisponible.FieldName = "IdDocumento";
            this.colIdDocumentoDisponible.Name = "colIdDocumentoDisponible";
            this.colIdDocumentoDisponible.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Documentos Disponibles";
            this.gridColumn2.FieldName = "NomDocumento";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "DiasValidez";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "FechaCrea";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "FechaModifica";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "UsuarioCrea";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "UsuarioModifica";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btAddDocumentoParticipante,
            this.btRemoveDocumentoParticipante});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(515, 25);
            this.bindingNavigator1.TabIndex = 4;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btAddDocumentoParticipante
            // 
            this.btAddDocumentoParticipante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAddDocumentoParticipante.Image = global::Promowork.Properties.Resources.FlechaArriba16;
            this.btAddDocumentoParticipante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAddDocumentoParticipante.Name = "btAddDocumentoParticipante";
            this.btAddDocumentoParticipante.Size = new System.Drawing.Size(23, 22);
            this.btAddDocumentoParticipante.Text = "toolStripButton1";
            this.btAddDocumentoParticipante.ToolTipText = "Agrega Documento a Participante";
            this.btAddDocumentoParticipante.Click += new System.EventHandler(this.btAddDocumentoParticipante_Click);
            // 
            // btRemoveDocumentoParticipante
            // 
            this.btRemoveDocumentoParticipante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btRemoveDocumentoParticipante.Image = global::Promowork.Properties.Resources.FlechaAbajo16;
            this.btRemoveDocumentoParticipante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btRemoveDocumentoParticipante.Name = "btRemoveDocumentoParticipante";
            this.btRemoveDocumentoParticipante.Size = new System.Drawing.Size(23, 22);
            this.btRemoveDocumentoParticipante.Text = "toolStripButton2";
            this.btRemoveDocumentoParticipante.ToolTipText = "Elimina Documento de Participante";
            this.btRemoveDocumentoParticipante.Click += new System.EventHandler(this.btRemoveDocumentoParticipante_Click);
            // 
            // frmParticipantesDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 464);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmParticipantesDocumentos";
            this.Text = "Participantes Documentos";
            this.Load += new System.EventHandler(this.frmParticipantesDocumentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documentosParticipantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosParticipantesBindingNavigator)).EndInit();
            this.documentosParticipantesBindingNavigator.ResumeLayout(false);
            this.documentosParticipantesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.participantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvParticipantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocumentosParticipante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentosDisponibleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocumentosDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource documentosParticipantesBindingSource;
        private System.Windows.Forms.BindingNavigator documentosParticipantesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton documentosParticipantesBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource participantesBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvParticipantes;
        private DevExpress.XtraGrid.Columns.GridColumn colIdParticipantegvParticipantes;
        private DevExpress.XtraGrid.Columns.GridColumn colDesParticipante;
        private DevExpress.XtraGrid.Columns.GridColumn colActivoParticipante;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDocumentosParticipante;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDocumentosDisponibles;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDocumentoDisponible;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.BindingSource DocumentosDisponibleBindingSource;
        private System.Windows.Forms.ToolStripButton btAddDocumentoParticipante;
        private System.Windows.Forms.ToolStripButton btRemoveDocumentoParticipante;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDocumentoParticipante;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdParticipante;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioCrea;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCrea;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentos;
    }
}