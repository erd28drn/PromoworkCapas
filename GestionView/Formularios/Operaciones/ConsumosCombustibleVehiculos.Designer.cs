﻿namespace Promowork.Formularios.Operaciones
{
    partial class ConsumosCombustibleVehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsumosCombustibleVehiculos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Promowork_dataDataSetCombustible = new GestionData.Promowork_dataDataSetCombustible();
            this.consumosVehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consumosVehiculosTableAdapter = new GestionData.Promowork_dataDataSetCombustibleTableAdapters.ConsumosVehiculosTableAdapter();
            this.tableAdapterManager = new GestionData.Promowork_dataDataSetCombustibleTableAdapters.TableAdapterManager();
            this.consumosVehiculosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.consumosVehiculosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.consumosVehiculosDataGridView = new System.Windows.Forms.DataGridView();
            this.vehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiposServiciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trabajadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculosTableAdapter = new GestionData.Promowork_dataDataSetCombustibleTableAdapters.VehiculosTableAdapter();
            this.tiposServiciosTableAdapter = new GestionData.Promowork_dataDataSetCombustibleTableAdapters.TiposServiciosTableAdapter();
            this.trabajadoresTableAdapter = new GestionData.Promowork_dataDataSetCombustibleTableAdapters.TrabajadoresTableAdapter();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdServico = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CantIni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTrabajador = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IdEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Combustible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSetCombustible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumosVehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumosVehiculosBindingNavigator)).BeginInit();
            this.consumosVehiculosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consumosVehiculosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposServiciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GestionData.Promowork_dataDataSetCombustible
            // 
            this.Promowork_dataDataSetCombustible.DataSetName = "GestionData.Promowork_dataDataSetCombustible";
            this.Promowork_dataDataSetCombustible.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consumosVehiculosBindingSource
            // 
            this.consumosVehiculosBindingSource.DataMember = "ConsumosVehiculos";
            this.consumosVehiculosBindingSource.DataSource = this.Promowork_dataDataSetCombustible;
            // 
            // consumosVehiculosTableAdapter
            // 
            this.consumosVehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsumosVehiculosTableAdapter = this.consumosVehiculosTableAdapter;
            this.tableAdapterManager.EmpresasTableAdapter = null;
            this.tableAdapterManager.EntradasCombustibleDetTableAdapter = null;
            this.tableAdapterManager.FormasPagoTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.ServiciosVehiculosTableAdapter = null;
            this.tableAdapterManager.TiposServiciosTableAdapter = null;
            this.tableAdapterManager.TrabajadoresTableAdapter = null;
            this.tableAdapterManager.UMedidasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionData.Promowork_dataDataSetCombustibleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiculosTableAdapter = null;
            // 
            // consumosVehiculosBindingNavigator
            // 
            this.consumosVehiculosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.consumosVehiculosBindingNavigator.BindingSource = this.consumosVehiculosBindingSource;
            this.consumosVehiculosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.consumosVehiculosBindingNavigator.DeleteItem = null;
            this.consumosVehiculosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.consumosVehiculosBindingNavigatorSaveItem});
            this.consumosVehiculosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.consumosVehiculosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.consumosVehiculosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.consumosVehiculosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.consumosVehiculosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.consumosVehiculosBindingNavigator.Name = "consumosVehiculosBindingNavigator";
            this.consumosVehiculosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.consumosVehiculosBindingNavigator.Size = new System.Drawing.Size(1500, 25);
            this.consumosVehiculosBindingNavigator.TabIndex = 0;
            this.consumosVehiculosBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
            // consumosVehiculosBindingNavigatorSaveItem
            // 
            this.consumosVehiculosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.consumosVehiculosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("consumosVehiculosBindingNavigatorSaveItem.Image")));
            this.consumosVehiculosBindingNavigatorSaveItem.Name = "consumosVehiculosBindingNavigatorSaveItem";
            this.consumosVehiculosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.consumosVehiculosBindingNavigatorSaveItem.Text = "Save Data";
            this.consumosVehiculosBindingNavigatorSaveItem.Click += new System.EventHandler(this.consumosVehiculosBindingNavigatorSaveItem_Click);
            // 
            // consumosVehiculosDataGridView
            // 
            this.consumosVehiculosDataGridView.AutoGenerateColumns = false;
            this.consumosVehiculosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.consumosVehiculosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consumosVehiculosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.IdServico,
            this.CantIni,
            this.CantFin,
            this.dataGridViewTextBoxColumn5,
            this.Precio,
            this.IdTrabajador,
            this.IdEmpresa,
            this.Combustible});
            this.consumosVehiculosDataGridView.DataSource = this.consumosVehiculosBindingSource;
            this.consumosVehiculosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consumosVehiculosDataGridView.Location = new System.Drawing.Point(0, 25);
            this.consumosVehiculosDataGridView.Name = "consumosVehiculosDataGridView";
            this.consumosVehiculosDataGridView.Size = new System.Drawing.Size(1500, 634);
            this.consumosVehiculosDataGridView.TabIndex = 1;
            this.consumosVehiculosDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.consumosVehiculosDataGridView_DataError);
            this.consumosVehiculosDataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.consumosVehiculosDataGridView_UserAddedRow);
            // 
            // vehiculosBindingSource
            // 
            this.vehiculosBindingSource.DataMember = "Vehiculos";
            this.vehiculosBindingSource.DataSource = this.Promowork_dataDataSetCombustible;
            // 
            // tiposServiciosBindingSource
            // 
            this.tiposServiciosBindingSource.DataMember = "TiposServicios";
            this.tiposServiciosBindingSource.DataSource = this.Promowork_dataDataSetCombustible;
            // 
            // trabajadoresBindingSource
            // 
            this.trabajadoresBindingSource.DataMember = "Trabajadores";
            this.trabajadoresBindingSource.DataSource = this.Promowork_dataDataSetCombustible;
            // 
            // vehiculosTableAdapter
            // 
            this.vehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // tiposServiciosTableAdapter
            // 
            this.tiposServiciosTableAdapter.ClearBeforeFill = true;
            // 
            // trabajadoresTableAdapter
            // 
            this.trabajadoresTableAdapter.ClearBeforeFill = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "FechaServicio";
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle6;
            this.Fecha.FillWeight = 10F;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdVehiculo";
            this.dataGridViewTextBoxColumn3.DataSource = this.vehiculosBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Vehiculo";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewTextBoxColumn3.DisplayStyleForCurrentCellOnly = true;
            this.dataGridViewTextBoxColumn3.FillWeight = 25F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Vehículo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "IdVehiculo";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "KMVehiculo";
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn4.FillWeight = 5F;
            this.dataGridViewTextBoxColumn4.HeaderText = "KMs";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // IdServico
            // 
            this.IdServico.DataPropertyName = "IdServico";
            this.IdServico.DataSource = this.tiposServiciosBindingSource;
            this.IdServico.DisplayMember = "DesServicio";
            this.IdServico.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.IdServico.DisplayStyleForCurrentCellOnly = true;
            this.IdServico.FillWeight = 10F;
            this.IdServico.HeaderText = "Tipo Combustible";
            this.IdServico.Name = "IdServico";
            this.IdServico.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdServico.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IdServico.ValueMember = "IdServicio";
            // 
            // CantIni
            // 
            this.CantIni.DataPropertyName = "CantIni";
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = null;
            this.CantIni.DefaultCellStyle = dataGridViewCellStyle8;
            this.CantIni.FillWeight = 5F;
            this.CantIni.HeaderText = "Lt. Inicio";
            this.CantIni.Name = "CantIni";
            // 
            // CantFin
            // 
            this.CantFin.DataPropertyName = "CantFin";
            dataGridViewCellStyle9.Format = "N0";
            this.CantFin.DefaultCellStyle = dataGridViewCellStyle9;
            this.CantFin.FillWeight = 5F;
            this.CantFin.HeaderText = "Lt. Final";
            this.CantFin.Name = "CantFin";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cantidad1";
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn5.FillWeight = 5F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.FillWeight = 5F;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ToolTipText = "Si se ,deja en Cero se tomará el precio por las entradas, si existen.";
            // 
            // IdTrabajador
            // 
            this.IdTrabajador.DataPropertyName = "IdTrabajador";
            this.IdTrabajador.DataSource = this.trabajadoresBindingSource;
            this.IdTrabajador.DisplayMember = "Trabajador";
            this.IdTrabajador.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.IdTrabajador.DisplayStyleForCurrentCellOnly = true;
            this.IdTrabajador.FillWeight = 20F;
            this.IdTrabajador.HeaderText = "Trabajador";
            this.IdTrabajador.Name = "IdTrabajador";
            this.IdTrabajador.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdTrabajador.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IdTrabajador.ValueMember = "IdTrabajador";
            // 
            // IdEmpresa
            // 
            this.IdEmpresa.DataPropertyName = "IdEmpresa";
            this.IdEmpresa.HeaderText = "IdEmpresa";
            this.IdEmpresa.Name = "IdEmpresa";
            this.IdEmpresa.Visible = false;
            // 
            // Combustible
            // 
            this.Combustible.DataPropertyName = "Combustible";
            this.Combustible.HeaderText = "Combustible";
            this.Combustible.Name = "Combustible";
            this.Combustible.Visible = false;
            // 
            // ConsumosCombustibleVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 659);
            this.Controls.Add(this.consumosVehiculosDataGridView);
            this.Controls.Add(this.consumosVehiculosBindingNavigator);
            this.Name = "ConsumosCombustibleVehiculos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumos Combustible por Vehículos";
            this.Load += new System.EventHandler(this.ConsumosVehiculos_Load);
            this.ResizeEnd += new System.EventHandler(this.ConsumosCombustibleVehiculos_ResizeEnd);
            this.Resize += new System.EventHandler(this.ConsumosCombustibleVehiculos_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSetCombustible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumosVehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumosVehiculosBindingNavigator)).EndInit();
            this.consumosVehiculosBindingNavigator.ResumeLayout(false);
            this.consumosVehiculosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consumosVehiculosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposServiciosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GestionData.Promowork_dataDataSetCombustible Promowork_dataDataSetCombustible;
        private System.Windows.Forms.BindingSource consumosVehiculosBindingSource;
        private GestionData.Promowork_dataDataSetCombustibleTableAdapters.ConsumosVehiculosTableAdapter consumosVehiculosTableAdapter;
        private GestionData.Promowork_dataDataSetCombustibleTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator consumosVehiculosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton consumosVehiculosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView consumosVehiculosDataGridView;
        private System.Windows.Forms.BindingSource vehiculosBindingSource;
        private GestionData.Promowork_dataDataSetCombustibleTableAdapters.VehiculosTableAdapter vehiculosTableAdapter;
        private System.Windows.Forms.BindingSource tiposServiciosBindingSource;
        private GestionData.Promowork_dataDataSetCombustibleTableAdapters.TiposServiciosTableAdapter tiposServiciosTableAdapter;
        private System.Windows.Forms.BindingSource trabajadoresBindingSource;
        private GestionData.Promowork_dataDataSetCombustibleTableAdapters.TrabajadoresTableAdapter trabajadoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantIni;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdTrabajador;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpresa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Combustible;
    }
}