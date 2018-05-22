using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionData.Repositorios;

namespace Promowork.Formularios.Reportes.Viewer
{
    public partial class rptFacturasClientesAddEmail : Form
    {
        DataRowView Factura;
        RepositorioCliente repoCliente = new RepositorioCliente();
        public rptFacturasClientesAddEmail(DataRowView factura)
        {
            InitializeComponent();
            Factura = factura;
        }

        private void rptFacturasClientesAddEmail_Load(object sender, EventArgs e)
        {
            tbCliente.Text = Factura["DesCliente"].ToString();
            tbEmail.Text = Factura["EmailCliente"].ToString();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            repoCliente.UpdateEmailCliente((int)Factura["IdCliente"], tbEmail.Text);
            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
