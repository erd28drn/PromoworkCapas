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

namespace Promowork.Formularios.Reportes.Viewer
{
    public partial class RptFacturasPresupImp2 : Form
    {
        public RptFacturasPresupImp2()
        {
            InitializeComponent();

            //LoadFiltro(20574, "Promowork.Reportes.FacturaPresupImp2.rdlc");
        }

        DataRowView factura;
        string nombreFactura;

        internal void LoadFiltro(int nIdFactCab, string reporte)
        {
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

            var trabajadores = TrabajadoresServices.ObtenerTrabajadoresConEmail(VariablesGlobales.nIdEmpresaActual);
            cbTrabajadores.Properties.DataSource = trabajadores;

            var gestores = ProveedoresServices.ObtenerGestoresConEmail(VariablesGlobales.nIdEmpresaActual);
            cbGestor.Properties.DataSource = gestores;

            factura = (DataRowView)FacturasCabImpBindingSource.Current;
            DateTime Fecha = (DateTime)factura["FechaFactura"];
            nombreFactura = factura["NumFactura"].ToString() + "-" + Fecha.Year.ToString() + " " + factura["DesCliente"].ToString();
            this.Text = nombreFactura;
            this.reportViewer1.LocalReport.DisplayName = nombreFactura;
            this.reportViewer1.LocalReport.EnableExternalImages=true;
            this.reportViewer1.RefreshReport();

            tbCliente.Text = factura["DesCliente"].ToString() + " (" + factura["EmailCliente"].ToString() + ")";

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
            }
            else
            {
                tbCliente.ForeColor = Color.Red;
                tbCliente.ToolTip = "La dirección de correo electrónico del cliente es incorrecta";
            }

            

        }

        private void btEnviarFactura_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empresasBindingSource.EndEdit();
            empresasTableAdapter.Update(Promowork_dataDataSet.Empresas);

            List<string> responderA = null;
            if (cbTrabajadores.ItemIndex != -1)
            {
                var trabajador = (TrabajadorConEmail)cbTrabajadores.GetSelectedDataRow();
                responderA = trabajador.EmailTrabajador.Split(';').ToList();
            }
            else
            {
                //MessageBox.Show("Debe seleccionar un valor en Responder A", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //return;
            }

            List<string> ccos = null;
            if (cbGestor.ItemIndex != -1)
            {
                var gestorSeleccionado = (GestorConEmail)cbGestor.GetSelectedDataRow();
                ccos = gestorSeleccionado.EmailGestor.Split(';').ToList();
            }

            if (!Directory.Exists("ENVIADOS/FACTURAS"))
            {
                Directory.CreateDirectory("ENVIADOS/FACTURAS");
            }

            
            string nombreFichero = "ENVIADOS/FACTURAS/" + nombreFactura;
            var RespuestaCrearFichero = Utilidades.ExportarReporte(reportViewer1, nombreFichero, ".PDF", "PDF");
            if (RespuestaCrearFichero == string.Empty)
            {
                List<string> destinatarios = factura["EmailCliente"].ToString().Split(';').ToList();
                //destinatarios = new List<string>();
                //destinatarios.Add("erd28drn@gmail.com");
                
                var asunto = tbAsuntoMensaje.Text;
                var cuerpoCorreo = tbCuerpoMensaje.Text.Replace("\n", "<br>"); 
                List<string> adjuntos = new List<string>();
                adjuntos.Add(nombreFichero + ".PDF");
                string respuestaEnviarCorreo = Utilidades.EnviaCorreo(VariablesGlobales.nIdEmpresaActual, destinatarios, asunto, adjuntos, cuerpoCorreo, responderA, ccos);

                tbResultado.Text = respuestaEnviarCorreo;
            }
        }

    }
}
