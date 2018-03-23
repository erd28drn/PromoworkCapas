﻿namespace Promowork.Formularios.Definiciones
{
    partial class frmLugaresUsoMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLugaresUsoMaterial));
            this.datosAlbaranes = new GestionData.DatosAlbaranes();
            this.lugaresUsoMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lugaresUsoMaterialTableAdapter = new GestionData.DatosAlbaranesTableAdapters.LugaresUsoMaterialTableAdapter();
            this.tableAdapterManager = new GestionData.DatosAlbaranesTableAdapters.TableAdapterManager();
            this.lugaresUsoMaterialBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.lugaresUsoMaterialBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lugaresUsoMaterialGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdLugarUso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesLugarUso = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datosAlbaranes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresUsoMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresUsoMaterialBindingNavigator)).BeginInit();
            this.lugaresUsoMaterialBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresUsoMaterialGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // datosAlbaranes
            // 
            this.datosAlbaranes.DataSetName = "DatosAlbaranes";
            this.datosAlbaranes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lugaresUsoMaterialBindingSource
            // 
            this.lugaresUsoMaterialBindingSource.DataMember = "LugaresUsoMaterial";
            this.lugaresUsoMaterialBindingSource.DataSource = this.datosAlbaranes;
            // 
            // lugaresUsoMaterialTableAdapter
            // 
            this.lugaresUsoMaterialTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlbaranesCabTableAdapter = null;
            this.tableAdapterManager.AlbaranesDetTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LugaresUsoMaterialTableAdapter = this.lugaresUsoMaterialTableAdapter;
            this.tableAdapterManager.ObrasTableAdapter = null;
            this.tableAdapterManager.ObservacionesProveedoresTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.TrabajadoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionData.Promowork_dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lugaresUsoMaterialBindingNavigator
            // 
            this.lugaresUsoMaterialBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lugaresUsoMaterialBindingNavigator.BindingSource = this.lugaresUsoMaterialBindingSource;
            this.lugaresUsoMaterialBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lugaresUsoMaterialBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lugaresUsoMaterialBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lugaresUsoMaterialBindingNavigatorSaveItem});
            this.lugaresUsoMaterialBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lugaresUsoMaterialBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lugaresUsoMaterialBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lugaresUsoMaterialBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lugaresUsoMaterialBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lugaresUsoMaterialBindingNavigator.Name = "lugaresUsoMaterialBindingNavigator";
            this.lugaresUsoMaterialBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lugaresUsoMaterialBindingNavigator.Size = new System.Drawing.Size(591, 25);
            this.lugaresUsoMaterialBindingNavigator.TabIndex = 0;
            this.lugaresUsoMaterialBindingNavigator.Text = "bindingNavigator1";
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
            // lugaresUsoMaterialBindingNavigatorSaveItem
            // 
            this.lugaresUsoMaterialBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lugaresUsoMaterialBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lugaresUsoMaterialBindingNavigatorSaveItem.Image")));
            this.lugaresUsoMaterialBindingNavigatorSaveItem.Name = "lugaresUsoMaterialBindingNavigatorSaveItem";
            this.lugaresUsoMaterialBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.lugaresUsoMaterialBindingNavigatorSaveItem.Text = "Guardar datos";
            this.lugaresUsoMaterialBindingNavigatorSaveItem.Click += new System.EventHandler(this.lugaresUsoMaterialBindingNavigatorSaveItem_Click);
            // 
            // lugaresUsoMaterialGridControl
            // 
            this.lugaresUsoMaterialGridControl.DataSource = this.lugaresUsoMaterialBindingSource;
            this.lugaresUsoMaterialGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lugaresUsoMaterialGridControl.Location = new System.Drawing.Point(0, 25);
            this.lugaresUsoMaterialGridControl.MainView = this.gridView1;
            this.lugaresUsoMaterialGridControl.Name = "lugaresUsoMaterialGridControl";
            this.lugaresUsoMaterialGridControl.Size = new System.Drawing.Size(591, 491);
            this.lugaresUsoMaterialGridControl.TabIndex = 2;
            this.lugaresUsoMaterialGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdLugarUso,
            this.colIdEmpresa,
            this.colDesLugarUso});
            this.gridView1.GridControl = this.lugaresUsoMaterialGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            // 
            // colIdLugarUso
            // 
            this.colIdLugarUso.FieldName = "IdLugarUso";
            this.colIdLugarUso.Name = "colIdLugarUso";
            this.colIdLugarUso.OptionsColumn.ReadOnly = true;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colDesLugarUso
            // 
            this.colDesLugarUso.FieldName = "DesLugarUso";
            this.colDesLugarUso.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colDesLugarUso.Name = "colDesLugarUso";
            this.colDesLugarUso.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDesLugarUso.Visible = true;
            this.colDesLugarUso.VisibleIndex = 0;
            // 
            // frmLugaresUsoMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 516);
            this.Controls.Add(this.lugaresUsoMaterialGridControl);
            this.Controls.Add(this.lugaresUsoMaterialBindingNavigator);
            this.Name = "frmLugaresUsoMaterial";
            this.Text = "Lugares Uso Material";
            this.Load += new System.EventHandler(this.frmLugaresUsoMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosAlbaranes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresUsoMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresUsoMaterialBindingNavigator)).EndInit();
            this.lugaresUsoMaterialBindingNavigator.ResumeLayout(false);
            this.lugaresUsoMaterialBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresUsoMaterialGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GestionData.DatosAlbaranes datosAlbaranes;
        private System.Windows.Forms.BindingSource lugaresUsoMaterialBindingSource;
        private GestionData.DatosAlbaranesTableAdapters.LugaresUsoMaterialTableAdapter lugaresUsoMaterialTableAdapter;
        private GestionData.DatosAlbaranesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lugaresUsoMaterialBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton lugaresUsoMaterialBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl lugaresUsoMaterialGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLugarUso;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colDesLugarUso;
    }
}