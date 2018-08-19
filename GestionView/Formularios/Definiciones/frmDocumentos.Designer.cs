namespace Promowork.Formularios.Definiciones
{
    partial class frmDocumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocumentos));
            this.documentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.documentosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gvDocumentos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiasValidez = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCrea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModifica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioCrea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioModifica = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.documentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosBindingNavigator)).BeginInit();
            this.documentosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // documentosBindingSource
            // 
            this.documentosBindingSource.DataSource = typeof(GestionData.Modelos.Documentos);
            // 
            // documentosBindingNavigator
            // 
            this.documentosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.documentosBindingNavigator.BindingSource = this.documentosBindingSource;
            this.documentosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.documentosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.documentosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.documentosBindingNavigatorSaveItem});
            this.documentosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.documentosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.documentosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.documentosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.documentosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.documentosBindingNavigator.Name = "documentosBindingNavigator";
            this.documentosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.documentosBindingNavigator.Size = new System.Drawing.Size(510, 25);
            this.documentosBindingNavigator.TabIndex = 0;
            this.documentosBindingNavigator.Text = "bindingNavigator1";
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
            // documentosBindingNavigatorSaveItem
            // 
            this.documentosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.documentosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("documentosBindingNavigatorSaveItem.Image")));
            this.documentosBindingNavigatorSaveItem.Name = "documentosBindingNavigatorSaveItem";
            this.documentosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.documentosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.documentosBindingNavigatorSaveItem.Click += new System.EventHandler(this.documentosBindingNavigatorSaveItem_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.documentosBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 25);
            this.gridControl1.MainView = this.gvDocumentos;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(510, 353);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDocumentos});
            // 
            // gvDocumentos
            // 
            this.gvDocumentos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdDocumento,
            this.colNomDocumento,
            this.colDiasValidez,
            this.colFechaCrea,
            this.colFechaModifica,
            this.colUsuarioCrea,
            this.colUsuarioModifica});
            this.gvDocumentos.GridControl = this.gridControl1;
            this.gvDocumentos.Name = "gvDocumentos";
            this.gvDocumentos.OptionsLayout.Columns.StoreAllOptions = true;
            this.gvDocumentos.OptionsLayout.Columns.StoreAppearance = true;
            this.gvDocumentos.OptionsLayout.StoreAllOptions = true;
            this.gvDocumentos.OptionsLayout.StoreAppearance = true;
            this.gvDocumentos.OptionsNavigation.AutoFocusNewRow = true;
            this.gvDocumentos.OptionsView.ShowAutoFilterRow = true;
            this.gvDocumentos.OptionsView.ShowGroupPanel = false;
            this.gvDocumentos.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvDocumentos_CellValueChanged);
            // 
            // colIdDocumento
            // 
            this.colIdDocumento.FieldName = "IdDocumento";
            this.colIdDocumento.Name = "colIdDocumento";
            this.colIdDocumento.OptionsColumn.ReadOnly = true;
            // 
            // colNomDocumento
            // 
            this.colNomDocumento.Caption = "Nombre Documento";
            this.colNomDocumento.FieldName = "NomDocumento";
            this.colNomDocumento.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colNomDocumento.Name = "colNomDocumento";
            this.colNomDocumento.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNomDocumento.Visible = true;
            this.colNomDocumento.VisibleIndex = 0;
            this.colNomDocumento.Width = 550;
            // 
            // colDiasValidez
            // 
            this.colDiasValidez.AppearanceHeader.Options.UseTextOptions = true;
            this.colDiasValidez.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDiasValidez.Caption = "Días Validez";
            this.colDiasValidez.FieldName = "DiasValidez";
            this.colDiasValidez.Name = "colDiasValidez";
            this.colDiasValidez.Visible = true;
            this.colDiasValidez.VisibleIndex = 1;
            this.colDiasValidez.Width = 156;
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
            // colUsuarioCrea
            // 
            this.colUsuarioCrea.FieldName = "UsuarioCrea";
            this.colUsuarioCrea.Name = "colUsuarioCrea";
            this.colUsuarioCrea.OptionsColumn.ReadOnly = true;
            // 
            // colUsuarioModifica
            // 
            this.colUsuarioModifica.FieldName = "UsuarioModifica";
            this.colUsuarioModifica.Name = "colUsuarioModifica";
            this.colUsuarioModifica.OptionsColumn.ReadOnly = true;
            // 
            // frmDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 378);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.documentosBindingNavigator);
            this.Name = "frmDocumentos";
            this.Text = "Documentos";
            this.Load += new System.EventHandler(this.frmDocumentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosBindingNavigator)).EndInit();
            this.documentosBindingNavigator.ResumeLayout(false);
            this.documentosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocumentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource documentosBindingSource;
        private System.Windows.Forms.BindingNavigator documentosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton documentosBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDocumentos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colNomDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colDiasValidez;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCrea;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModifica;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioCrea;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioModifica;
    }
}