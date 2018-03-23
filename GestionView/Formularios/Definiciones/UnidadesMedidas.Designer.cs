﻿namespace Promowork.Formularios.Definiciones
{
    partial class UnidadesMedidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnidadesMedidas));
            this.Promowork_dataDataSetCombustible = new GestionData.Promowork_dataDataSetCombustible();
            this.combustiblesTiposDataGridView = new System.Windows.Forms.DataGridView();
            this.uMedidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uMedidasTableAdapter = new GestionData.Promowork_dataDataSetCombustibleTableAdapters.UMedidasTableAdapter();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.combustiblesTiposBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.combustiblesTiposBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.CodUmedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesUmedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivaUM = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idUmedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSetCombustible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combustiblesTiposDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMedidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combustiblesTiposBindingNavigator)).BeginInit();
            this.combustiblesTiposBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // GestionData.Promowork_dataDataSetCombustible
            // 
            this.Promowork_dataDataSetCombustible.DataSetName = "GestionData.Promowork_dataDataSetCombustible";
            this.Promowork_dataDataSetCombustible.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combustiblesTiposDataGridView
            // 
            this.combustiblesTiposDataGridView.AutoGenerateColumns = false;
            this.combustiblesTiposDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.combustiblesTiposDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodUmedida,
            this.DesUmedida,
            this.ActivaUM,
            this.idUmedidaDataGridViewTextBoxColumn});
            this.combustiblesTiposDataGridView.DataSource = this.uMedidasBindingSource;
            this.combustiblesTiposDataGridView.Location = new System.Drawing.Point(12, 28);
            this.combustiblesTiposDataGridView.Name = "combustiblesTiposDataGridView";
            this.combustiblesTiposDataGridView.RowHeadersWidth = 25;
            this.combustiblesTiposDataGridView.Size = new System.Drawing.Size(352, 220);
            this.combustiblesTiposDataGridView.TabIndex = 1;
            this.combustiblesTiposDataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.combustiblesTiposDataGridView_UserAddedRow);
            // 
            // uMedidasBindingSource
            // 
            this.uMedidasBindingSource.DataMember = "UMedidas";
            this.uMedidasBindingSource.DataSource = this.Promowork_dataDataSetCombustible;
            // 
            // uMedidasTableAdapter
            // 
            this.uMedidasTableAdapter.ClearBeforeFill = true;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // combustiblesTiposBindingNavigatorSaveItem
            // 
            this.combustiblesTiposBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.combustiblesTiposBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("combustiblesTiposBindingNavigatorSaveItem.Image")));
            this.combustiblesTiposBindingNavigatorSaveItem.Name = "combustiblesTiposBindingNavigatorSaveItem";
            this.combustiblesTiposBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.combustiblesTiposBindingNavigatorSaveItem.Text = "Save Data";
            this.combustiblesTiposBindingNavigatorSaveItem.Click += new System.EventHandler(this.combustiblesTiposBindingNavigatorSaveItem_Click);
            // 
            // combustiblesTiposBindingNavigator
            // 
            this.combustiblesTiposBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.combustiblesTiposBindingNavigator.BindingSource = this.uMedidasBindingSource;
            this.combustiblesTiposBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.combustiblesTiposBindingNavigator.DeleteItem = null;
            this.combustiblesTiposBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.combustiblesTiposBindingNavigatorSaveItem});
            this.combustiblesTiposBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.combustiblesTiposBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.combustiblesTiposBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.combustiblesTiposBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.combustiblesTiposBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.combustiblesTiposBindingNavigator.Name = "combustiblesTiposBindingNavigator";
            this.combustiblesTiposBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.combustiblesTiposBindingNavigator.Size = new System.Drawing.Size(377, 25);
            this.combustiblesTiposBindingNavigator.TabIndex = 0;
            this.combustiblesTiposBindingNavigator.Text = "bindingNavigator1";
            // 
            // CodUmedida
            // 
            this.CodUmedida.DataPropertyName = "CodUmedida";
            this.CodUmedida.HeaderText = "Código";
            this.CodUmedida.MaxInputLength = 4;
            this.CodUmedida.Name = "CodUmedida";
            this.CodUmedida.Width = 50;
            // 
            // DesUmedida
            // 
            this.DesUmedida.DataPropertyName = "DesUmedida";
            this.DesUmedida.HeaderText = "Descripción";
            this.DesUmedida.MaxInputLength = 50;
            this.DesUmedida.Name = "DesUmedida";
            this.DesUmedida.Width = 200;
            // 
            // ActivaUM
            // 
            this.ActivaUM.DataPropertyName = "ActivaUM";
            this.ActivaUM.HeaderText = "Activa";
            this.ActivaUM.Name = "ActivaUM";
            this.ActivaUM.Width = 59;
            // 
            // idUmedidaDataGridViewTextBoxColumn
            // 
            this.idUmedidaDataGridViewTextBoxColumn.DataPropertyName = "IdUmedida";
            this.idUmedidaDataGridViewTextBoxColumn.HeaderText = "IdUmedida";
            this.idUmedidaDataGridViewTextBoxColumn.Name = "idUmedidaDataGridViewTextBoxColumn";
            this.idUmedidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUmedidaDataGridViewTextBoxColumn.Visible = false;
            // 
            // UnidadesMedidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 262);
            this.Controls.Add(this.combustiblesTiposDataGridView);
            this.Controls.Add(this.combustiblesTiposBindingNavigator);
            this.Name = "UnidadesMedidas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unidades de Medida";
            this.Load += new System.EventHandler(this.TiposCombustibles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSetCombustible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combustiblesTiposDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMedidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combustiblesTiposBindingNavigator)).EndInit();
            this.combustiblesTiposBindingNavigator.ResumeLayout(false);
            this.combustiblesTiposBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GestionData.Promowork_dataDataSetCombustible Promowork_dataDataSetCombustible;
        private System.Windows.Forms.DataGridView combustiblesTiposDataGridView;
        private System.Windows.Forms.BindingSource uMedidasBindingSource;
        private GestionData.Promowork_dataDataSetCombustibleTableAdapters.UMedidasTableAdapter uMedidasTableAdapter;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton combustiblesTiposBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator combustiblesTiposBindingNavigator;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodUmedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesUmedida;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ActivaUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUmedidaDataGridViewTextBoxColumn;
    }
}