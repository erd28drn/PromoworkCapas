namespace Promowork.Formularios.General
{
    partial class EntradaSistema
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
            System.Windows.Forms.Label mesEmpresaLabel;
            System.Windows.Forms.Label anoEmpresaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradaSistema));
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbClave = new System.Windows.Forms.TextBox();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbMes = new System.Windows.Forms.NumericUpDown();
            this.tbAno = new System.Windows.Forms.NumericUpDown();
            mesEmpresaLabel = new System.Windows.Forms.Label();
            anoEmpresaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAno)).BeginInit();
            this.SuspendLayout();
            // 
            // mesEmpresaLabel
            // 
            mesEmpresaLabel.AutoSize = true;
            mesEmpresaLabel.Location = new System.Drawing.Point(36, 132);
            mesEmpresaLabel.Name = "mesEmpresaLabel";
            mesEmpresaLabel.Size = new System.Drawing.Size(30, 13);
            mesEmpresaLabel.TabIndex = 8;
            mesEmpresaLabel.Text = "Mes:";
            // 
            // anoEmpresaLabel
            // 
            anoEmpresaLabel.AutoSize = true;
            anoEmpresaLabel.Location = new System.Drawing.Point(148, 132);
            anoEmpresaLabel.Name = "anoEmpresaLabel";
            anoEmpresaLabel.Size = new System.Drawing.Size(29, 13);
            anoEmpresaLabel.TabIndex = 9;
            anoEmpresaLabel.Text = "Año:";
            // 
            // cbUsuario
            // 
            this.cbUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUsuario.DataSource = this.usuariosBindingSource;
            this.cbUsuario.DisplayMember = "NomUsuario";
            this.cbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(69, 18);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(174, 21);
            this.cbUsuario.TabIndex = 0;
            this.cbUsuario.ValueMember = "IdUsuario";
            this.cbUsuario.SelectedValueChanged += new System.EventHandler(this.cbUsuario_SelectedValueChanged);
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataSource = typeof(GestionData.Modelos.Usuarios);
            // 
            // tbClave
            // 
            this.tbClave.Location = new System.Drawing.Point(69, 52);
            this.tbClave.MaxLength = 20;
            this.tbClave.Name = "tbClave";
            this.tbClave.PasswordChar = '*';
            this.tbClave.Size = new System.Drawing.Size(100, 20);
            this.tbClave.TabIndex = 1;
            this.tbClave.TextChanged += new System.EventHandler(this.tbClave_TextChanged);
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEmpresa.DataSource = this.empresasBindingSource;
            this.cbEmpresa.DisplayMember = "DesEmpresa";
            this.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Location = new System.Drawing.Point(69, 94);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(174, 21);
            this.cbEmpresa.TabIndex = 2;
            this.cbEmpresa.ValueMember = "IdEmpresa";
            this.cbEmpresa.SelectedValueChanged += new System.EventHandler(this.cbEmpresa_SelectedValueChanged);
            // 
            // empresasBindingSource
            // 
            this.empresasBindingSource.DataSource = typeof(GestionData.Modelos.Empresas);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Clave:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Empresa:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(94, 180);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(181, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbMes
            // 
            this.tbMes.Location = new System.Drawing.Point(69, 128);
            this.tbMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.tbMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbMes.Name = "tbMes";
            this.tbMes.Size = new System.Drawing.Size(48, 20);
            this.tbMes.TabIndex = 10;
            this.tbMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(181, 128);
            this.tbAno.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.tbAno.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(62, 20);
            this.tbAno.TabIndex = 11;
            this.tbAno.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EntradaSistema
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(269, 215);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.tbMes);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(anoEmpresaLabel);
            this.Controls.Add(mesEmpresaLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEmpresa);
            this.Controls.Add(this.tbClave);
            this.Controls.Add(this.cbUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EntradaSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso al Sistema";
            this.Load += new System.EventHandler(this.Accesos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.BindingSource empresasBindingSource;
        private System.Windows.Forms.NumericUpDown tbMes;
        private System.Windows.Forms.NumericUpDown tbAno;
    }
}