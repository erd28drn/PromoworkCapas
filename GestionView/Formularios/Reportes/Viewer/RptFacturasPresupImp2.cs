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
using GestionServices.Generales;
using System.IO;

namespace Promowork.Formularios.Reportes.Viewer
{
    public partial class RptFacturasPresupImp2 : Form
    {
        public RptFacturasPresupImp2()
        {
            InitializeComponent();

            LoadFiltro(20574);
        }

        DataRowView factura;
        string nombreFactura;

        internal void LoadFiltro(int nIdFactCab)
        {
            this.WindowState = FormWindowState.Maximized;

            this.GestoresTableAdapter.FillByConEmail(this.Promowork_dataDataSet.Gestores, VariablesGlobales.nIdEmpresaActual);

            // TODO: This line of code loads data into the 'Promowork_dataDataSet.PresupuestoActual' table. You can move, or remove it, as needed.
            this.FacturasDetImpTableAdapter.FillByFactura(this.Promowork_dataDataSet.FacturasDetImp, nIdFactCab);
            this.FacturasCabImpTableAdapter.FillByFactura(this.Promowork_dataDataSet.FacturasCabImp, nIdFactCab);
            this.vComprasDirectasTableAdapter.FillByFactura(this.DatosPresupuestos.vComprasDirectas, nIdFactCab);
            this.FacturasDetHorasImpTableAdapter.FillbyFactura(this.Promowork_dataDataSet.FacturasDetHorasImp, nIdFactCab);
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.EmpresasActual' table. You can move, or remove it, as needed.
            this.empresasPoblacion.FillByEmpresa(this.Promowork_dataDataSet.EmpresasPoblacion, VariablesGlobales.nIdEmpresaActual);
            factura = (DataRowView)FacturasCabImpBindingSource.Current;
            DateTime Fecha = (DateTime)factura["FechaFactura"];
            nombreFactura = factura["NumFactura"].ToString() + "-" + Fecha.Year.ToString() + " " + factura["DesCliente"].ToString();
            this.Text = nombreFactura;
            this.reportViewer1.LocalReport.DisplayName = nombreFactura;
            this.reportViewer1.LocalReport.EnableExternalImages=true;
            this.reportViewer1.RefreshReport();
        }

        private void chkCopiaGestor_CheckedChanged(object sender, EventArgs e)
        {
            cbGestor.Enabled = chkCopiaGestor.Checked;
            lbGestor.Enabled = chkCopiaGestor.Checked;
        }

        private void btEnviarFactura_Click(object sender, EventArgs e)
        {
            List<string> ccos = null;
            if (chkCopiaGestor.Checked)
            {
                DataRowView gestorSeleccionado = (DataRowView)cbGestor.GetSelectedDataRow();
                ccos = gestorSeleccionado["EmailProveedor"].ToString().Split(';').ToList();
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
                destinatarios = new List<string>();
                destinatarios.Add("erd28drn@gmail.com");

                
                //string asunto = asuntoSinAlbaranTextEdit.Text;// "Albaranes Pendientes";
                List<string> adjuntos = new List<string>();
                adjuntos.Add(nombreFichero + ".PDF");
                string respuestaEnviarCorreo = Utilidades.EnviaCorreo(VariablesGlobales.nIdEmpresaActual, destinatarios, "Prueba envio factura", adjuntos, "Prueba Cuerpo mensaje", "erd28drn@gmail.com", ccos);
            }
        }

    }
}
