namespace Promowork.Formularios.Reportes.Viewer
{
    partial class rptFacturasClientesAddEmail
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            this.tbCliente = new DevExpress.XtraEditors.TextEdit();
            this.tbEmail = new DevExpress.XtraEditors.TextEdit();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(8, 16);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(42, 13);
            label2.TabIndex = 15;
            label2.Text = "Cliente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(15, 42);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 13);
            label1.TabIndex = 17;
            label1.Text = "Email:";
            // 
            // tbCliente
            // 
            this.tbCliente.Location = new System.Drawing.Point(56, 12);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Properties.ReadOnly = true;
            this.tbCliente.Size = new System.Drawing.Size(411, 20);
            this.tbCliente.TabIndex = 14;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(56, 38);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(411, 20);
            this.tbEmail.TabIndex = 16;
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(311, 78);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 18;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(392, 78);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 19;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // rptFacturasClientesAddEmail
            // 
            this.AcceptButton = this.btAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(476, 111);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(label1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(label2);
            this.Controls.Add(this.tbCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rptFacturasClientesAddEmail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Agregar Email";
            this.Load += new System.EventHandler(this.rptFacturasClientesAddEmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmail.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tbCliente;
        private DevExpress.XtraEditors.TextEdit tbEmail;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
    }
}