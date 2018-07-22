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
            this.colVencida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinalizada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaVencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pAgregarTareas = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.finalizadaCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.vTareasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTrabajador = new System.Windows.Forms.ComboBox();
            this.trabajadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tbNombreTarea = new System.Windows.Forms.TextBox();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btSaveTarea = new System.Windows.Forms.Button();
            this.btAddTarea = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkOcultarPanelEdicion = new System.Windows.Forms.CheckBox();
            this.chkRecargar = new System.Windows.Forms.CheckBox();
            this.lbSegundos = new DevExpress.XtraEditors.LabelControl();
            this.spTiempoRecargar = new DevExpress.XtraEditors.SpinEdit();
            this.lbRecargar = new DevExpress.XtraEditors.LabelControl();
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
            this.colResponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tmTemporizador = new System.Windows.Forms.Timer(this.components);
            this.pAgregarTareas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finalizadaCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTareasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spTiempoRecargar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Descripción)).BeginInit();
            this.SuspendLayout();
            // 
            // colVencida
            // 
            this.colVencida.FieldName = "Vencida";
            this.colVencida.Name = "colVencida";
            this.colVencida.OptionsColumn.ReadOnly = true;
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
            // pAgregarTareas
            // 
            this.pAgregarTareas.Controls.Add(this.splitContainer1);
            this.pAgregarTareas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pAgregarTareas.Location = new System.Drawing.Point(0, 597);
            this.pAgregarTareas.Name = "pAgregarTareas";
            this.pAgregarTareas.Size = new System.Drawing.Size(1236, 111);
            this.pAgregarTareas.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.finalizadaCheckEdit);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.dtFechaVencimiento);
            this.splitContainer1.Panel1.Controls.Add(this.cbEmpresa);
            this.splitContainer1.Panel1.Controls.Add(this.cbTrabajador);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1236, 111);
            this.splitContainer1.SplitterDistance = 499;
            this.splitContainer1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Descripción:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nombre:";
            // 
            // finalizadaCheckEdit
            // 
            this.finalizadaCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vTareasBindingSource, "Finalizada", true));
            this.finalizadaCheckEdit.Location = new System.Drawing.Point(315, 71);
            this.finalizadaCheckEdit.Name = "finalizadaCheckEdit";
            this.finalizadaCheckEdit.Properties.Caption = "Finalizada";
            this.finalizadaCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.finalizadaCheckEdit.TabIndex = 10;
            // 
            // vTareasBindingSource
            // 
            this.vTareasBindingSource.DataSource = typeof(GestionData.Modelos.vTareas);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Vencimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Responsable:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Empresa:";
            // 
            // dtFechaVencimiento
            // 
            this.dtFechaVencimiento.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vTareasBindingSource, "FechaVencimiento", true));
            this.dtFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaVencimiento.Location = new System.Drawing.Point(94, 70);
            this.dtFechaVencimiento.Name = "dtFechaVencimiento";
            this.dtFechaVencimiento.Size = new System.Drawing.Size(97, 20);
            this.dtFechaVencimiento.TabIndex = 6;
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vTareasBindingSource, "IdEmpresa", true));
            this.cbEmpresa.DataSource = this.empresasBindingSource;
            this.cbEmpresa.DisplayMember = "DesEmpresa";
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Location = new System.Drawing.Point(94, 9);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(296, 21);
            this.cbEmpresa.TabIndex = 0;
            this.cbEmpresa.ValueMember = "IdEmpresa";
            this.cbEmpresa.SelectedValueChanged += new System.EventHandler(this.cbEmpresa_SelectedValueChanged);
            // 
            // empresasBindingSource
            // 
            this.empresasBindingSource.DataSource = typeof(GestionData.Modelos.Empresas);
            // 
            // cbTrabajador
            // 
            this.cbTrabajador.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vTareasBindingSource, "IdTrabajador", true));
            this.cbTrabajador.DataSource = this.trabajadoresBindingSource;
            this.cbTrabajador.DisplayMember = "NomTrabajador";
            this.cbTrabajador.FormattingEnabled = true;
            this.cbTrabajador.Location = new System.Drawing.Point(94, 37);
            this.cbTrabajador.Name = "cbTrabajador";
            this.cbTrabajador.Size = new System.Drawing.Size(296, 21);
            this.cbTrabajador.TabIndex = 1;
            this.cbTrabajador.ValueMember = "IdTrabajador";
            // 
            // trabajadoresBindingSource
            // 
            this.trabajadoresBindingSource.DataSource = typeof(GestionData.Modelos.Trabajadores);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btDelete);
            this.splitContainer2.Panel2.Controls.Add(this.btSaveTarea);
            this.splitContainer2.Panel2.Controls.Add(this.btAddTarea);
            this.splitContainer2.Size = new System.Drawing.Size(733, 111);
            this.splitContainer2.SplitterDistance = 629;
            this.splitContainer2.TabIndex = 8;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tbNombreTarea);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tbObservaciones);
            this.splitContainer3.Size = new System.Drawing.Size(629, 111);
            this.splitContainer3.SplitterDistance = 31;
            this.splitContainer3.TabIndex = 0;
            // 
            // tbNombreTarea
            // 
            this.tbNombreTarea.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vTareasBindingSource, "NombreTarea", true));
            this.tbNombreTarea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbNombreTarea.Location = new System.Drawing.Point(0, 11);
            this.tbNombreTarea.Name = "tbNombreTarea";
            this.tbNombreTarea.Size = new System.Drawing.Size(629, 20);
            this.tbNombreTarea.TabIndex = 2;
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vTareasBindingSource, "ObsercacionesTarea", true));
            this.tbObservaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbObservaciones.Location = new System.Drawing.Point(0, 0);
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbObservaciones.Size = new System.Drawing.Size(629, 68);
            this.tbObservaciones.TabIndex = 3;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(10, 44);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 7;
            this.btDelete.Text = "Eliminar";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSaveTarea
            // 
            this.btSaveTarea.Location = new System.Drawing.Point(10, 76);
            this.btSaveTarea.Name = "btSaveTarea";
            this.btSaveTarea.Size = new System.Drawing.Size(75, 23);
            this.btSaveTarea.TabIndex = 5;
            this.btSaveTarea.Text = "Salvar";
            this.btSaveTarea.UseVisualStyleBackColor = true;
            this.btSaveTarea.Click += new System.EventHandler(this.btSaveTarea_Click);
            // 
            // btAddTarea
            // 
            this.btAddTarea.Location = new System.Drawing.Point(10, 15);
            this.btAddTarea.Name = "btAddTarea";
            this.btAddTarea.Size = new System.Drawing.Size(75, 23);
            this.btAddTarea.TabIndex = 4;
            this.btAddTarea.Text = "Agregar";
            this.btAddTarea.UseVisualStyleBackColor = true;
            this.btAddTarea.Click += new System.EventHandler(this.btAddTarea_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkOcultarPanelEdicion);
            this.panel2.Controls.Add(this.chkRecargar);
            this.panel2.Controls.Add(this.lbSegundos);
            this.panel2.Controls.Add(this.spTiempoRecargar);
            this.panel2.Controls.Add(this.lbRecargar);
            this.panel2.Controls.Add(this.btSincronizar);
            this.panel2.Controls.Add(this.chkMostrarFinalizados);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1236, 44);
            this.panel2.TabIndex = 2;
            // 
            // chkOcultarPanelEdicion
            // 
            this.chkOcultarPanelEdicion.AutoSize = true;
            this.chkOcultarPanelEdicion.Location = new System.Drawing.Point(176, 13);
            this.chkOcultarPanelEdicion.Name = "chkOcultarPanelEdicion";
            this.chkOcultarPanelEdicion.Size = new System.Drawing.Size(183, 17);
            this.chkOcultarPanelEdicion.TabIndex = 7;
            this.chkOcultarPanelEdicion.Text = "Mostrar en modo de visualización";
            this.chkOcultarPanelEdicion.UseVisualStyleBackColor = true;
            this.chkOcultarPanelEdicion.CheckedChanged += new System.EventHandler(this.chkOcultarPanelEdicion_CheckedChanged);
            // 
            // chkRecargar
            // 
            this.chkRecargar.AutoSize = true;
            this.chkRecargar.Checked = true;
            this.chkRecargar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRecargar.Location = new System.Drawing.Point(412, 14);
            this.chkRecargar.Name = "chkRecargar";
            this.chkRecargar.Size = new System.Drawing.Size(15, 14);
            this.chkRecargar.TabIndex = 6;
            this.chkRecargar.UseVisualStyleBackColor = true;
            this.chkRecargar.CheckedChanged += new System.EventHandler(this.chkRecargar_CheckedChanged);
            // 
            // lbSegundos
            // 
            this.lbSegundos.Location = new System.Drawing.Point(673, 15);
            this.lbSegundos.Name = "lbSegundos";
            this.lbSegundos.Size = new System.Drawing.Size(47, 13);
            this.lbSegundos.TabIndex = 5;
            this.lbSegundos.Text = "Segundos";
            // 
            // spTiempoRecargar
            // 
            this.spTiempoRecargar.EditValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.spTiempoRecargar.Location = new System.Drawing.Point(595, 11);
            this.spTiempoRecargar.Name = "spTiempoRecargar";
            this.spTiempoRecargar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spTiempoRecargar.Size = new System.Drawing.Size(67, 20);
            this.spTiempoRecargar.TabIndex = 4;
            this.spTiempoRecargar.EditValueChanged += new System.EventHandler(this.spTiempoRecargar_EditValueChanged);
            // 
            // lbRecargar
            // 
            this.lbRecargar.Location = new System.Drawing.Point(433, 15);
            this.lbRecargar.Name = "lbRecargar";
            this.lbRecargar.Size = new System.Drawing.Size(156, 13);
            this.lbRecargar.TabIndex = 3;
            this.lbRecargar.Text = "Recargar automaticamente cada";
            // 
            // btSincronizar
            // 
            this.btSincronizar.Location = new System.Drawing.Point(770, 12);
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
            this.chkMostrarFinalizados.Text = "Mostrar Finalizadas";
            this.chkMostrarFinalizados.UseVisualStyleBackColor = true;
            this.chkMostrarFinalizados.CheckedChanged += new System.EventHandler(this.chkMostrarFinalizados_CheckedChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.vTareasBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 44);
            this.gridControl1.MainView = this.gvTareas;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Descripción});
            this.gridControl1.Size = new System.Drawing.Size(1236, 553);
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
            this.colDesEmpresa,
            this.colVencida});
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.HighPriority = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colVencida;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = true;
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Blue;
            styleFormatCondition2.Appearance.Options.HighPriority = true;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colFinalizada;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = true;
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
            // colResponsable
            // 
            this.colResponsable.Caption = "Responsable";
            this.colResponsable.FieldName = "Responsable";
            this.colResponsable.Name = "colResponsable";
            this.colResponsable.OptionsColumn.ReadOnly = true;
            this.colResponsable.Visible = true;
            this.colResponsable.VisibleIndex = 7;
            this.colResponsable.Width = 72;
            // 
            // colUsuarioCreacion
            // 
            this.colUsuarioCreacion.Caption = "Creada por";
            this.colUsuarioCreacion.FieldName = "UsuarioCreacion";
            this.colUsuarioCreacion.Name = "colUsuarioCreacion";
            this.colUsuarioCreacion.OptionsColumn.ReadOnly = true;
            this.colUsuarioCreacion.Visible = true;
            this.colUsuarioCreacion.VisibleIndex = 8;
            this.colUsuarioCreacion.Width = 72;
            // 
            // colUsuarioModificacion
            // 
            this.colUsuarioModificacion.Caption = "Modificada por";
            this.colUsuarioModificacion.FieldName = "UsuarioModificacion";
            this.colUsuarioModificacion.Name = "colUsuarioModificacion";
            this.colUsuarioModificacion.OptionsColumn.ReadOnly = true;
            this.colUsuarioModificacion.Visible = true;
            this.colUsuarioModificacion.VisibleIndex = 9;
            this.colUsuarioModificacion.Width = 77;
            // 
            // colDesEmpresa
            // 
            this.colDesEmpresa.Caption = "Empresa";
            this.colDesEmpresa.FieldName = "DesEmpresa";
            this.colDesEmpresa.Name = "colDesEmpresa";
            this.colDesEmpresa.OptionsColumn.ReadOnly = true;
            this.colDesEmpresa.Visible = true;
            this.colDesEmpresa.VisibleIndex = 0;
            this.colDesEmpresa.Width = 103;
            // 
            // tmTemporizador
            // 
            this.tmTemporizador.Interval = 10000;
            this.tmTemporizador.Tick += new System.EventHandler(this.tmTemporizador_Tick);
            // 
            // frmTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 708);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.pAgregarTareas);
            this.Controls.Add(this.panel2);
            this.Name = "frmTareas";
            this.Text = "Tareas Pendientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTareas_FormClosing);
            this.Load += new System.EventHandler(this.frmTareas_Load);
            this.pAgregarTareas.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.finalizadaCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTareasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajadoresBindingSource)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spTiempoRecargar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTareas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Descripción)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pAgregarTareas;
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
        private DevExpress.XtraGrid.Columns.GridColumn colVencida;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.CheckEdit finalizadaCheckEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl lbSegundos;
        private DevExpress.XtraEditors.SpinEdit spTiempoRecargar;
        private DevExpress.XtraEditors.LabelControl lbRecargar;
        private System.Windows.Forms.Timer tmTemporizador;
        private System.Windows.Forms.CheckBox chkRecargar;
        private System.Windows.Forms.CheckBox chkOcultarPanelEdicion;
    }
}

