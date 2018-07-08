namespace Promowork.Formularios.General
{
    partial class frmTareas
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colFinalizada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaVencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btDelete = new System.Windows.Forms.Button();
            this.dtFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.btSaveTarea = new System.Windows.Forms.Button();
            this.btAddTarea = new System.Windows.Forms.Button();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.tbNombreTarea = new System.Windows.Forms.TextBox();
            this.cbTrabajador = new System.Windows.Forms.ComboBox();
            this.trabajadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btSincronizar = new System.Windows.Forms.Button();
            this.chkMostrarFinalizados = new System.Windows.Forms.CheckBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gvTareas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTarea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEventoExterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreTarea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObsercacionesTarea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descripción = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colIdUsuarioCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTrabajador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vTareasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colResponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Descripción)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTareasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // colFinalizada
            // 
            this.colFinalizada.AppearanceHeader.Options.UseTextOptions = true;
            this.colFinalizada.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFinalizada.Caption = "Finalizada";
            this.colFinalizada.FieldName = "Finalizada";
            this.colFinalizada.Name = "colFinalizada";
            this.colFinalizada.Visible = true;
            this.colFinalizada.VisibleIndex = 6;
            this.colFinalizada.Width = 68;
            // 
            // colFechaVencimiento
            // 
            this.colFechaVencimiento.AppearanceCell.Options.UseTextOptions = true;
            this.colFechaVencimiento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaVencimiento.AppearanceHeader.Options.UseTextOptions = true;
            this.colFechaVencimiento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaVencimiento.Caption = "Vencimiento";
            this.colFechaVencimiento.FieldName = "FechaVencimiento";
            this.colFechaVencimiento.Name = "colFechaVencimiento";
            this.colFechaVencimiento.Visible = true;
            this.colFechaVencimiento.VisibleIndex = 5;
            this.colFechaVencimiento.Width = 84;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.dtFechaVencimiento);
            this.panel1.Controls.Add(this.btSaveTarea);
            this.panel1.Controls.Add(this.btAddTarea);
            this.panel1.Controls.Add(this.tbObservaciones);
            this.panel1.Controls.Add(this.tbNombreTarea);
            this.panel1.Controls.Add(this.cbTrabajador);
            this.panel1.Controls.Add(this.cbEmpresa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 457);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 140);
            this.panel1.TabIndex = 1;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(1031, 50);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 7;
            this.btDelete.Text = "Eliminar";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // dtFechaVencimiento
            // 
            this.dtFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaVencimiento.Location = new System.Drawing.Point(552, 25);
            this.dtFechaVencimiento.Name = "dtFechaVencimiento";
            this.dtFechaVencimiento.Size = new System.Drawing.Size(97, 20);
            this.dtFechaVencimiento.TabIndex = 6;
            // 
            // btSaveTarea
            // 
            this.btSaveTarea.Location = new System.Drawing.Point(1031, 82);
            this.btSaveTarea.Name = "btSaveTarea";
            this.btSaveTarea.Size = new System.Drawing.Size(75, 23);
            this.btSaveTarea.TabIndex = 5;
            this.btSaveTarea.Text = "Salvar";
            this.btSaveTarea.UseVisualStyleBackColor = true;
            this.btSaveTarea.Click += new System.EventHandler(this.btSaveTarea_Click);
            // 
            // btAddTarea
            // 
            this.btAddTarea.Location = new System.Drawing.Point(1031, 21);
            this.btAddTarea.Name = "btAddTarea";
            this.btAddTarea.Size = new System.Drawing.Size(75, 23);
            this.btAddTarea.TabIndex = 4;
            this.btAddTarea.Text = "Agregar";
            this.btAddTarea.UseVisualStyleBackColor = true;
            this.btAddTarea.Click += new System.EventHandler(this.btAddTarea_Click);
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.Location = new System.Drawing.Point(233, 52);
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(260, 53);
            this.tbObservaciones.TabIndex = 3;
            // 
            // tbNombreTarea
            // 
            this.tbNombreTarea.Location = new System.Drawing.Point(233, 25);
            this.tbNombreTarea.Name = "tbNombreTarea";
            this.tbNombreTarea.Size = new System.Drawing.Size(260, 20);
            this.tbNombreTarea.TabIndex = 2;
            // 
            // cbTrabajador
            // 
            this.cbTrabajador.DataSource = this.trabajadoresBindingSource;
            this.cbTrabajador.DisplayMember = "NomTrabajador";
            this.cbTrabajador.FormattingEnabled = true;
            this.cbTrabajador.Location = new System.Drawing.Point(794, 25);
            this.cbTrabajador.Name = "cbTrabajador";
            this.cbTrabajador.Size = new System.Drawing.Size(192, 21);
            this.cbTrabajador.TabIndex = 1;
            this.cbTrabajador.ValueMember = "IdTrabajador";
            // 
            // trabajadoresBindingSource
            // 
            this.trabajadoresBindingSource.DataSource = typeof(GestionData.Modelos.Trabajadores);
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.DataSource = this.empresasBindingSource;
            this.cbEmpresa.DisplayMember = "DesEmpresa";
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Location = new System.Drawing.Point(26, 24);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(187, 21);
            this.cbEmpresa.TabIndex = 0;
            this.cbEmpresa.ValueMember = "IdEmpresa";
            this.cbEmpresa.SelectedValueChanged += new System.EventHandler(this.cbEmpresa_SelectedValueChanged);
            // 
            // empresasBindingSource
            // 
            this.empresasBindingSource.DataSource = typeof(GestionData.Modelos.Empresas);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btSincronizar);
            this.panel2.Controls.Add(this.chkMostrarFinalizados);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 50);
            this.panel2.TabIndex = 2;
            // 
            // btSincronizar
            // 
            this.btSincronizar.Location = new System.Drawing.Point(315, 13);
            this.btSincronizar.Name = "btSincronizar";
            this.btSincronizar.Size = new System.Drawing.Size(75, 23);
            this.btSincronizar.TabIndex = 1;
            this.btSincronizar.Text = "Sincronizar";
            this.btSincronizar.UseVisualStyleBackColor = true;
            this.btSincronizar.Visible = false;
            // 
            // chkMostrarFinalizados
            // 
            this.chkMostrarFinalizados.AutoSize = true;
            this.chkMostrarFinalizados.Location = new System.Drawing.Point(13, 13);
            this.chkMostrarFinalizados.Name = "chkMostrarFinalizados";
            this.chkMostrarFinalizados.Size = new System.Drawing.Size(116, 17);
            this.chkMostrarFinalizados.TabIndex = 0;
            this.chkMostrarFinalizados.Text = "Mostrar Finalizados";
            this.chkMostrarFinalizados.UseVisualStyleBackColor = true;
            this.chkMostrarFinalizados.CheckedChanged += new System.EventHandler(this.chkMostrarFinalizados_CheckedChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.vTareasBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 50);
            this.gridControl1.MainView = this.gvTareas;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Descripción});
            this.gridControl1.Size = new System.Drawing.Size(1155, 407);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTareas});
            // 
            // gvTareas
            // 
            this.gvTareas.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvTareas.Appearance.Row.Options.UseFont = true;
            this.gvTareas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTarea,
            this.colIdEventoExterno,
            this.colIdEmpresa,
            this.colNombreTarea,
            this.colObsercacionesTarea,
            this.colIdUsuarioCreacion,
            this.colIdUsuarioModificacion,
            this.colIdTrabajador,
            this.colFechaCreacion,
            this.colFechaModificacion,
            this.colFechaVencimiento,
            this.colFinalizada,
            this.colResponsable,
            this.colUsuarioCreacion,
            this.colUsuarioModificacion,
            this.colDesEmpresa});
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Blue;
            styleFormatCondition1.Appearance.Options.HighPriority = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colFinalizada;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = true;
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition2.Appearance.Options.HighPriority = true;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colFechaVencimiento;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition2.Expression = "LocalDateTimeNow()";
            this.gvTareas.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.gvTareas.GridControl = this.gridControl1;
            this.gvTareas.Name = "gvTareas";
            this.gvTareas.OptionsView.RowAutoHeight = true;
            this.gvTareas.OptionsView.ShowGroupPanel = false;
            this.gvTareas.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colFechaVencimiento, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvTareas.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvTareas_CellValueChanged);
            // 
            // colIdTarea
            // 
            this.colIdTarea.FieldName = "IdTarea";
            this.colIdTarea.Name = "colIdTarea";
            this.colIdTarea.OptionsColumn.ReadOnly = true;
            // 
            // colIdEventoExterno
            // 
            this.colIdEventoExterno.FieldName = "IdEventoExterno";
            this.colIdEventoExterno.Name = "colIdEventoExterno";
            this.colIdEventoExterno.OptionsColumn.ReadOnly = true;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.Caption = "Empresa";
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.ReadOnly = true;
            this.colIdEmpresa.Width = 166;
            // 
            // colNombreTarea
            // 
            this.colNombreTarea.Caption = "Nombre Tarea";
            this.colNombreTarea.FieldName = "NombreTarea";
            this.colNombreTarea.Name = "colNombreTarea";
            this.colNombreTarea.Visible = true;
            this.colNombreTarea.VisibleIndex = 1;
            this.colNombreTarea.Width = 181;
            // 
            // colObsercacionesTarea
            // 
            this.colObsercacionesTarea.Caption = "Descripción Tarea";
            this.colObsercacionesTarea.ColumnEdit = this.Descripción;
            this.colObsercacionesTarea.FieldName = "ObsercacionesTarea";
            this.colObsercacionesTarea.Name = "colObsercacionesTarea";
            this.colObsercacionesTarea.Visible = true;
            this.colObsercacionesTarea.VisibleIndex = 2;
            this.colObsercacionesTarea.Width = 320;
            // 
            // Descripción
            // 
            this.Descripción.Name = "Descripción";
            // 
            // colIdUsuarioCreacion
            // 
            this.colIdUsuarioCreacion.FieldName = "IdUsuarioCreacion";
            this.colIdUsuarioCreacion.Name = "colIdUsuarioCreacion";
            this.colIdUsuarioCreacion.OptionsColumn.ReadOnly = true;
            // 
            // colIdUsuarioModificacion
            // 
            this.colIdUsuarioModificacion.FieldName = "IdUsuarioModificacion";
            this.colIdUsuarioModificacion.Name = "colIdUsuarioModificacion";
            this.colIdUsuarioModificacion.OptionsColumn.ReadOnly = true;
            // 
            // colIdTrabajador
            // 
            this.colIdTrabajador.FieldName = "IdTrabajador";
            this.colIdTrabajador.Name = "colIdTrabajador";
            this.colIdTrabajador.OptionsColumn.ReadOnly = true;
            this.colIdTrabajador.Width = 127;
            // 
            // colFechaCreacion
            // 
            this.colFechaCreacion.AppearanceCell.Options.UseTextOptions = true;
            this.colFechaCreacion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaCreacion.AppearanceHeader.Options.UseTextOptions = true;
            this.colFechaCreacion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaCreacion.Caption = "Creada";
            this.colFechaCreacion.FieldName = "FechaCreacion";
            this.colFechaCreacion.Name = "colFechaCreacion";
            this.colFechaCreacion.OptionsColumn.ReadOnly = true;
            this.colFechaCreacion.Visible = true;
            this.colFechaCreacion.VisibleIndex = 3;
            this.colFechaCreacion.Width = 77;
            // 
            // colFechaModificacion
            // 
            this.colFechaModificacion.AppearanceCell.Options.UseTextOptions = true;
            this.colFechaModificacion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaModificacion.AppearanceHeader.Options.UseTextOptions = true;
            this.colFechaModificacion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaModificacion.Caption = "Modificada";
            this.colFechaModificacion.FieldName = "FechaModificacion";
            this.colFechaModificacion.Name = "colFechaModificacion";
            this.colFechaModificacion.OptionsColumn.ReadOnly = true;
            this.colFechaModificacion.Visible = true;
            this.colFechaModificacion.VisibleIndex = 4;
            this.colFechaModificacion.Width = 83;
            // 
            // vTareasBindingSource
            // 
            this.vTareasBindingSource.DataSource = typeof(GestionData.Modelos.vTareas);
            // 
            // colResponsable
            // 
            this.colResponsable.Caption = "Responsable";
            this.colResponsable.FieldName = "Responsable";
            this.colResponsable.Name = "colResponsable";
            this.colResponsable.Visible = true;
            this.colResponsable.VisibleIndex = 7;
            this.colResponsable.Width = 72;
            // 
            // colUsuarioCreacion
            // 
            this.colUsuarioCreacion.Caption = "Usuario Creación";
            this.colUsuarioCreacion.FieldName = "UsuarioCreacion";
            this.colUsuarioCreacion.Name = "colUsuarioCreacion";
            this.colUsuarioCreacion.Visible = true;
            this.colUsuarioCreacion.VisibleIndex = 8;
            this.colUsuarioCreacion.Width = 72;
            // 
            // colUsuarioModificacion
            // 
            this.colUsuarioModificacion.Caption = "Usuario Modificación";
            this.colUsuarioModificacion.FieldName = "UsuarioModificacion";
            this.colUsuarioModificacion.Name = "colUsuarioModificacion";
            this.colUsuarioModificacion.Visible = true;
            this.colUsuarioModificacion.VisibleIndex = 9;
            this.colUsuarioModificacion.Width = 77;
            // 
            // colDesEmpresa
            // 
            this.colDesEmpresa.Caption = "Empresa";
            this.colDesEmpresa.FieldName = "DesEmpresa";
            this.colDesEmpresa.Name = "colDesEmpresa";
            this.colDesEmpresa.Visible = true;
            this.colDesEmpresa.VisibleIndex = 0;
            this.colDesEmpresa.Width = 103;
            // 
            // frmTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 597);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmTareas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmTareas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTareas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Descripción)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTareasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btAddTarea;
        private System.Windows.Forms.TextBox tbObservaciones;
        private System.Windows.Forms.TextBox tbNombreTarea;
        private System.Windows.Forms.ComboBox cbTrabajador;
        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.BindingSource trabajadoresBindingSource;
        private System.Windows.Forms.BindingSource empresasBindingSource;
        private System.Windows.Forms.Button btSaveTarea;
        private System.Windows.Forms.DateTimePicker dtFechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTareaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTareaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obsercacionesTareaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTrabajadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTrabajadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaModificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn finalizadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkMostrarFinalizados;
        private System.Windows.Forms.Button btSincronizar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTareas;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTarea;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEventoExterno;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreTarea;
        private DevExpress.XtraGrid.Columns.GridColumn colObsercacionesTarea;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTrabajador;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaVencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colFinalizada;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit Descripción;
        private System.Windows.Forms.BindingSource vTareasBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colResponsable;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colDesEmpresa;
    }
}

