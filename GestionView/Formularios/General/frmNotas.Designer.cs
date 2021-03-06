﻿namespace Promowork.Formularios.General
{
    partial class frmNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotas));
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.notasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btImportTxt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gvNotas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTituloNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colFechaCrea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModifica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioCrea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioModifica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioPertenece = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbUsuarios = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ofTextoNota = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingNavigator)).BeginInit();
            this.notasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // notasBindingSource
            // 
            this.notasBindingSource.DataSource = typeof(GestionData.Modelos.Notas);
            // 
            // notasBindingNavigator
            // 
            this.notasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.notasBindingNavigator.BindingSource = this.notasBindingSource;
            this.notasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.notasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.notasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.notasBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.btImportTxt,
            this.toolStripSeparator2});
            this.notasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.notasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.notasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.notasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.notasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.notasBindingNavigator.Name = "notasBindingNavigator";
            this.notasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.notasBindingNavigator.Size = new System.Drawing.Size(1057, 25);
            this.notasBindingNavigator.TabIndex = 0;
            this.notasBindingNavigator.Text = "bindingNavigator1";
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
            // notasBindingNavigatorSaveItem
            // 
            this.notasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.notasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("notasBindingNavigatorSaveItem.Image")));
            this.notasBindingNavigatorSaveItem.Name = "notasBindingNavigatorSaveItem";
            this.notasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.notasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.notasBindingNavigatorSaveItem.Click += new System.EventHandler(this.notasBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btImportTxt
            // 
            this.btImportTxt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btImportTxt.Image = global::Promowork.Properties.Resources.Duplicar;
            this.btImportTxt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btImportTxt.Name = "btImportTxt";
            this.btImportTxt.Size = new System.Drawing.Size(23, 22);
            this.btImportTxt.Text = "Importar";
            this.btImportTxt.ToolTipText = "Crea nuevas Notas desde Ficheros Texto";
            this.btImportTxt.Click += new System.EventHandler(this.btImportTxt_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.notasBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 25);
            this.gridControl1.MainView = this.gvNotas;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1,
            this.cbUsuarios});
            this.gridControl1.Size = new System.Drawing.Size(1057, 303);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNotas});
            // 
            // gvNotas
            // 
            this.gvNotas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdNota,
            this.colTituloNota,
            this.colNombreNota,
            this.colDescripcionNota,
            this.colFechaCrea,
            this.colFechaModifica,
            this.colIdUsuarioCrea,
            this.colIdUsuarioModifica,
            this.colIdUsuarioPertenece});
            this.gvNotas.GridControl = this.gridControl1;
            this.gvNotas.Name = "gvNotas";
            this.gvNotas.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvNotas.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvNotas.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvNotas.OptionsCustomization.AllowRowSizing = true;
            this.gvNotas.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvNotas.OptionsView.RowAutoHeight = true;
            this.gvNotas.OptionsView.ShowAutoFilterRow = true;
            // 
            // colIdNota
            // 
            this.colIdNota.FieldName = "IdNota";
            this.colIdNota.Name = "colIdNota";
            // 
            // colTituloNota
            // 
            this.colTituloNota.Caption = "Título";
            this.colTituloNota.FieldName = "TituloNota";
            this.colTituloNota.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colTituloNota.Name = "colTituloNota";
            this.colTituloNota.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTituloNota.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            this.colTituloNota.Visible = true;
            this.colTituloNota.VisibleIndex = 0;
            this.colTituloNota.Width = 123;
            // 
            // colNombreNota
            // 
            this.colNombreNota.Caption = "Nombre";
            this.colNombreNota.FieldName = "NombreNota";
            this.colNombreNota.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colNombreNota.Name = "colNombreNota";
            this.colNombreNota.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNombreNota.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            this.colNombreNota.Visible = true;
            this.colNombreNota.VisibleIndex = 1;
            this.colNombreNota.Width = 222;
            // 
            // colDescripcionNota
            // 
            this.colDescripcionNota.Caption = "Descripción";
            this.colDescripcionNota.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colDescripcionNota.FieldName = "DescripcionNota";
            this.colDescripcionNota.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colDescripcionNota.Name = "colDescripcionNota";
            this.colDescripcionNota.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDescripcionNota.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            this.colDescripcionNota.Visible = true;
            this.colDescripcionNota.VisibleIndex = 2;
            this.colDescripcionNota.Width = 343;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemMemoEdit1.MaxLength = 4000;
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
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
            // colIdUsuarioCrea
            // 
            this.colIdUsuarioCrea.FieldName = "IdUsuarioCrea";
            this.colIdUsuarioCrea.Name = "colIdUsuarioCrea";
            // 
            // colIdUsuarioModifica
            // 
            this.colIdUsuarioModifica.FieldName = "IdUsuarioModifica";
            this.colIdUsuarioModifica.Name = "colIdUsuarioModifica";
            // 
            // colIdUsuarioPertenece
            // 
            this.colIdUsuarioPertenece.Caption = "Pertenece a:";
            this.colIdUsuarioPertenece.ColumnEdit = this.cbUsuarios;
            this.colIdUsuarioPertenece.FieldName = "IdUsuarioPertenece";
            this.colIdUsuarioPertenece.Name = "colIdUsuarioPertenece";
            this.colIdUsuarioPertenece.Visible = true;
            this.colIdUsuarioPertenece.VisibleIndex = 3;
            this.colIdUsuarioPertenece.Width = 106;
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.AutoHeight = false;
            this.cbUsuarios.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUsuarios.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NomUsuario", "Usuario", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AdminUsuario", "Admin", 78, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cbUsuarios.DataSource = this.usuariosBindingSource;
            this.cbUsuarios.DisplayMember = "NomUsuario";
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.ValueMember = "IdUsuario";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataSource = typeof(GestionData.Modelos.Usuarios);
            // 
            // ofTextoNota
            // 
            this.ofTextoNota.DefaultExt = "txt";
            this.ofTextoNota.FileName = "Nota";
            this.ofTextoNota.Filter = "\"Archivos de Texto|*.txt|Todos los Archivos|*.*\"";
            this.ofTextoNota.Multiselect = true;
            this.ofTextoNota.Title = "Selecciones los ficheso que desea importar a Notas";
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 328);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.notasBindingNavigator);
            this.Name = "frmNotas";
            this.Text = "Notas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNotas_FormClosing);
            this.Load += new System.EventHandler(this.frmNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingNavigator)).EndInit();
            this.notasBindingNavigator.ResumeLayout(false);
            this.notasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource notasBindingSource;
        private System.Windows.Forms.BindingNavigator notasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton notasBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNotas;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNota;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreNota;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionNota;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCrea;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModifica;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioCrea;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioModifica;
        private DevExpress.XtraGrid.Columns.GridColumn colTituloNota;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioPertenece;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbUsuarios;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btImportTxt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.OpenFileDialog ofTextoNota;
    }
}