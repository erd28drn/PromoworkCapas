using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using GestionData;
using GestionData.Entities;
using GestionServices.Generales;
using GestionServices.Definiciones;
using System.IO;
using GestionData.Repositorios;

namespace Promowork.Formularios.Reportes.Viewer
{
    public partial class RptFacturasClientes : Form
    {
        public RptFacturasClientes()
        {
            InitializeComponent();

            //LoadFiltro(20574, "Promowork.Reportes.FacturaPresupImp2.rdlc");
        }

        DataRowView factura;
        string nombreFactura;
        RepositorioUsuario repoUsuario = new RepositorioUsuario();
        RepositorioEmpresa repoEmpresa = new RepositorioEmpresa();
        RepositorioFacturasCab repoFacturasCab = new RepositorioFacturasCab();
        public DateTime? fechaEnvioFactura = null;
        ConfiguracionEmpresa configuracionEmpresa;

        internal void LoadFiltro(int nIdFactCab, string reporte, bool facturaHoras = false)
        {
            configuracionEmpresa = repoEmpresa.GetConfiguracionEmpresa(VariablesGlobales.nIdEmpresaActual);

            this.WindowState = FormWindowState.Maximized;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = reporte;

            this.GestoresTableAdapter.FillByConEmail(this.Promowork_dataDataSet.Gestores, VariablesGlobales.nIdEmpresaActual);

            // TODO: This line of code loads data into the 'Promowork_dataDataSet.PresupuestoActual' table. You can move, or remove it, as needed.
            this.FacturasDetImpTableAdapter.FillByFactura(this.Promowork_dataDataSet.FacturasDetImp, nIdFactCab);
            this.FacturasCabImpTableAdapter.FillByFactura(this.Promowork_dataDataSet.FacturasCabImp, nIdFactCab);
            this.vComprasDirectasTableAdapter.FillByFactura(this.DatosPresupuestos.vComprasDirectas, nIdFactCab);
            this.FacturasDetHorasImpTableAdapter.FillbyFactura(this.Promowork_dataDataSet.FacturasDetHorasImp, nIdFactCab);
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.EmpresasActual' table. You can move, or remove it, as needed.
            this.empresasPoblacion.FillByEmpresa(this.Promowork_dataDataSet.EmpresasPoblacion, VariablesGlobales.nIdEmpresaActual);
            this.empresasTableAdapter.FillByEmpresa(this.Promowork_dataDataSet.Empresas, VariablesGlobales.nIdEmpresaActual);

            // 
            // reportViewer1
            // 
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource11 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource12 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource13 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource14 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource15 = new Microsoft.Reporting.WinForms.ReportDataSource();

            reportDataSource11.Name = "DataSet1";
            if (facturaHoras)
            {
                reportDataSource11.Value = this.FacturasDetHorasImpBindingSource;
            }
            else
            {
                reportDataSource11.Value = this.FacturasDetImpBindingSource;
            }
            reportDataSource12.Name = "DataSet2";
            reportDataSource12.Value = this.empresasPoblacionBindingSource;
            reportDataSource13.Name = "DataSet3";
            reportDataSource13.Value = this.FacturasCabImpBindingSource;
            reportDataSource14.Name = "ComprasDirectas";
            reportDataSource14.Value = this.vComprasDirectasBindingSource;
            reportDataSource15.Name = "DetallesHoras";
            reportDataSource15.Value = this.FacturasDetHorasImpBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource11);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource12);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource13);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource14);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource15);


            var trabajadores = TrabajadoresService.ObtenerTrabajadoresConEmail(VariablesGlobales.nIdEmpresaActual);
            cbTrabajadores.Properties.DataSource = trabajadores;
            cbTrabajadores.EditValue = VariablesGlobales.ConfiguracionUsuario.responderASeleccionado;

            ProveedoresService servicioProveedores = new ProveedoresService();
            var gestores = servicioProveedores.ObtenerGestoresConEmail(VariablesGlobales.nIdEmpresaActual, true);
            cbGestor.Properties.DataSource = gestores;
            cbGestor.EditValue = VariablesGlobales.ConfiguracionUsuario.gestorSeleccionado;

            factura = (DataRowView)FacturasCabImpBindingSource.Current;
            DateTime Fecha = (DateTime)factura["FechaFactura"];
            nombreFactura = factura["NumFactura"].ToString() + "-" + Fecha.Year.ToString() + " " + factura["DesCliente"].ToString();
            this.Text = nombreFactura;
            this.reportViewer1.LocalReport.DisplayName = nombreFactura;
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.RefreshReport();

           
            
            List<string> destinatarios = factura["EmailCliente"].ToString().Split(';').ToList();
            bool emailOK = false;
            foreach (string destinatario in destinatarios)
            {
                if (Utilidades.ValidarEmail(destinatario))
                {
                    emailOK = true;
                }
                else
                {
                    emailOK = false;
                    break;
                }
            }

            if (emailOK)
            {
                btEnviarFactura.Enabled = true;
                tbCliente.Text = factura["DesCliente"].ToString();// +" (" + factura["EmailCliente"].ToString() + ")";

                foreach (string email in factura["EmailCliente"].ToString().Split(';').ToList())
                {
                    cbEmailsCliente.Properties.Items.Add(email, true);
                }
                cbEmailsCliente.Properties.SelectAllItemVisible = false;
            }
            else
            {
                tbCliente.ForeColor = Color.Red;
                tbCliente.ToolTip = "La dirección de correo electrónico del cliente es incorrecta";
            }



        }

        private void btEnviarFactura_Click(object sender, EventArgs e)
        {
            List<string> responderA = null;
            string nombreRemitente = "";
            if (cbTrabajadores.ItemIndex != -1)
            {
                var trabajador = (TrabajadorConEmail)cbTrabajadores.GetSelectedDataRow();
                responderA = trabajador.EmailTrabajador.Split(';').ToList();
                nombreRemitente = trabajador.NombreTrabajador;

                VariablesGlobales.ConfiguracionUsuario.responderASeleccionado = (int)cbTrabajadores.EditValue;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un valor en Remitente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<string> destinatarios = new List<string>();
            foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in cbEmailsCliente.Properties.GetItems())
            {
                if (item.CheckState == CheckState.Checked)
                {
                    destinatarios.Add(item.Value.ToString());
                }
            }

            if (destinatarios.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un Email del cliente, para enviar la Factura", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            VariablesGlobales.ConfiguracionUsuario.gestorSeleccionado = (int)cbGestor.EditValue;

            this.Validate();
            this.empresasBindingSource.EndEdit();
            empresasTableAdapter.Update(Promowork_dataDataSet.Empresas);

            List<string> ccos = null;
            if (cbGestor.ItemIndex != -1)
            {
                var gestorSeleccionado = (GestorConEmail)cbGestor.GetSelectedDataRow();
                if (!string.IsNullOrWhiteSpace(gestorSeleccionado.EmailGestor))
                {
                    ccos = gestorSeleccionado.EmailGestor.Split(';').ToList();
                }
            }

            if (!Directory.Exists("ENVIADOS/FACTURAS"))
            {
                Directory.CreateDirectory("ENVIADOS/FACTURAS");
            }


            string nombreFichero = "ENVIADOS/FACTURAS/" + nombreFactura;
            var respuesta = Utilidades.ExportarReporte(reportViewer1, nombreFichero, ".PDF", "PDF");
            if (respuesta == string.Empty)
            {
                

                 //destinatarios = factura["EmailCliente"].ToString().Split(';').ToList();
                
                ////////////////////////////////
                //destinatarios = new List<string>();
                //destinatarios.Add("erd28drn@gmail.com");

                //ccos = new List<string>();
                //ccos.Add("erd28drn@gmail.com");
                ////////////////////////////////

                var asunto = tbAsuntoMensaje.Text;
                var cuerpoCorreo = tbCuerpoMensaje.Text.Replace("\n", "<br>");
                List<string> adjuntos = new List<string>();
                adjuntos.Add(nombreFichero + ".PDF");
                respuesta = Utilidades.EnviaCorreo(VariablesGlobales.nIdEmpresaActual, destinatarios, asunto, adjuntos, cuerpoCorreo, responderA, ccos, nombreRemitente);
                if (respuesta.Trim().ToUpper().Equals("OK"))
                {
                    tbResultado.ForeColor = Color.Green;
                    fechaEnvioFactura = DateTime.Now;
                    cbFechaEnvio.Text = fechaEnvioFactura.ToString();

                    repoUsuario.GuardarConfiguracionUsuario(VariablesGlobales.ConfiguracionUsuario);

                    configuracionEmpresa.idEmpresa = VariablesGlobales.nIdEmpresaActual;
                    configuracionEmpresa.asuntoEnvioFacturas = tbAsuntoMensaje.Text;
                    configuracionEmpresa.CuerpoEnvioFacturas = tbCuerpoMensaje.Text;
                    repoEmpresa.GuardarConfiguracionEmpresa(configuracionEmpresa);

                }
                else
                {
                    tbResultado.ForeColor = Color.Red;
                }
                tbResultado.Text = respuesta;
                
            }

        }

    }
}
