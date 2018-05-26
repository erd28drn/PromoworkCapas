using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using GestionServices.Generales;
using GestionServices.Definiciones;
using GestionData.Entities;
using GestionData.Repositorios;
using GestionData.Helpers;

namespace Promowork.Formularios.Reportes.Parametros
{
    public partial class rptParametrosSinAlbaran : Form
    {
        public rptParametrosSinAlbaran()
        {
            InitializeComponent();
        }

        int nMes;
        int nAno;
        int nDiasFin;
        DateTime FechaIni;
        DateTime FechaFin;
        IEnumerable<ResumenEnvioCorreos> proveedores;

        RepositorioUsuario repoUsuario = new RepositorioUsuario();
        RepositorioEmpresa repoEmpresa = new RepositorioEmpresa();
        RepositorioTrabajador repoTrabajador = new RepositorioTrabajador();
        ConfiguracionUsuario configuracionUsuario;
        ConfiguracionEmpresa configuracionEmpresa;
        int? idTrabajador = null;

        private void rptParametrosSinAlbaran_Load(object sender, EventArgs e)
        {
             nMes = VariablesGlobales.nMesActual;
            nAno = VariablesGlobales.nAnoActual;
            nDiasFin = DateTime.DaysInMonth(nAno, nMes);
            FechaIni = new DateTime(nAno, nMes, 1);
            FechaFin = new DateTime(nAno, nMes, nDiasFin);

            dateTimePicker1.Value = FechaIni;
            dateTimePicker2.Value = FechaFin;
            dateTimePicker2.MinDate = FechaIni;

            configuracionUsuario = repoUsuario.GetConfiguracionUsuario(VariablesGlobales.nIdUsuarioActual)??new ConfiguracionUsuario();
            configuracionEmpresa = repoEmpresa.GetConfiguracionEmpresa(VariablesGlobales.nIdEmpresaActual)??new ConfiguracionEmpresa();
            
            this.EmpresasActualTableAdapter.FillByEmpresa(this.Promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);

            var trabajadores = repoTrabajador.GetTrabajadoresConEmail(VariablesGlobales.nIdEmpresaActual);
            cbTrabajadores.Properties.DataSource = trabajadores;
            cbTrabajadores.EditValue = configuracionUsuario.responderASeleccionado;

            asuntoSinAlbaranTextEdit.Text = configuracionEmpresa.asuntoSinAlbaran;
            cuerpoMensajeSinAlbaranTextEdit.Text = configuracionEmpresa.cuerpoMensajeSinAlbaran;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            tabControl1.SelectedTab = tabControl1.TabPages[0];
            this.vAlbaranesTableAdapter.FillBySinAlbaran(this.DatosReportesNuevos.vAlbaranes, VariablesGlobales.nIdEmpresaActual, FechaIni, FechaFin);
            this.reportViewer1.RefreshReport();
            Cursor.Current = Cursors.Default;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FechaIni = dateTimePicker1.Value;
            dateTimePicker2.MinDate = FechaIni;
            button3.Enabled = false;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            FechaFin = dateTimePicker2.Value;
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            tabControl1.SelectedTab = tabControl1.TabPages[1];

            try
            {
                this.vAlbaranesTableAdapter.FillBySinAlbaran(this.DatosReportesNuevos.vAlbaranes, VariablesGlobales.nIdEmpresaActual, FechaIni, FechaFin);
                proveedores = proveedoresSinAlbaranTableAdapter.GetData(VariablesGlobales.nIdEmpresaActual, FechaIni, FechaFin)
                    .Select(p => new ResumenEnvioCorreos
                    {
                        IdProveedor = p.IdProveedor,
                        Marca = GeneralHelper.ValidarEmail(p.EmailProveedor),
                        Proveedor = p.DesProveedor,
                        Email = p.EmailProveedor,
                        Valido = GeneralHelper.ValidarEmail(p.EmailProveedor),
                        Enviado = false
                    }).ToList();
                 
                gridControl1.DataSource = proveedores;
                button3.Enabled = proveedores.Where(p=> p.Valido).Any();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                button3.Enabled = false;
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Error al validar los proveedores." + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            GuardarAsuntoCuerpoMensaje();

            var cuerpoCorreo = cuerpoMensajeSinAlbaranTextEdit.Text.Replace("\n", "<br>"); 
            
            List<string> responderA=null;
            string nombreRemitente = "";
            if (cbTrabajadores.ItemIndex != -1)
            {
                var trabajador = (TrabajadorConEmail)cbTrabajadores.GetSelectedDataRow();

                responderA = trabajador.EmailTrabajador.Split(';').ToList();
                nombreRemitente = trabajador.NombreTrabajador;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un valor en Responder A", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            foreach (var proveedor in proveedores.Where(p => p.Marca))
            {
                if (!Directory.Exists("ENVIADOS/SIN ALBARAN"))
                {
                    Directory.CreateDirectory("ENVIADOS/SIN ALBARAN");
                }
                vAlbaranesBindingSource.Filter = "IdProveedor=" + proveedor.IdProveedor.ToString();
                this.reportViewer1.RefreshReport();
                string nombreFichero= "ENVIADOS/SIN ALBARAN/"+/*DateTime.Today.ToString("yyyyMMdd")+*/"ALBARANES PENDIENTES " + proveedor.Proveedor;
                var RespuestaCrearFichero= Utilidades.ExportarReporte(reportViewer1, nombreFichero, ".PDF", "PDF");
                if (RespuestaCrearFichero == string.Empty)
                {
                    //List<string> destinatarios = new List<string>();
                    //destinatarios.Add("erd28drn@gmail.com");

                    List<string> destinatarios= proveedor.Email.Split(';').ToList();
                    string asunto = asuntoSinAlbaranTextEdit.Text;// "Albaranes Pendientes";
                    List<string> adjuntos= new List<string>();
                    adjuntos.Add(nombreFichero+ ".PDF");
                    string respuestaEnviarCorreo = Utilidades.EnviaCorreo(VariablesGlobales.nIdEmpresaActual, destinatarios, asunto, adjuntos, cuerpoCorreo, responderA, null, nombreRemitente);
                    proveedor.Enviado = true;
                    proveedor.Respuesta = respuestaEnviarCorreo;
                }
                else
                {
                    proveedor.Enviado = false;
                    proveedor.Respuesta = RespuestaCrearFichero;
                }
            }
            gridControl1.RefreshDataSource();

            EnviarResumenCorreosEnviados(responderA, nombreRemitente);

            Cursor.Current = Cursors.Default;

        }

        private void EnviarResumenCorreosEnviados(List<string> responderA, string nombreRemitente)
        {
            string tablaHTML = Utilidades.CrearTablaHTMLDesdeGridView(gridView1);

            string cuerpoMensaje = "<p><h3>RESUMEN ENVIO DE ALBARANES PENDEIENTES A PROVEEDORES.</p></h3>" + tablaHTML;

            vAlbaranesBindingSource.Filter = "";
            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
            string nombreFichero = "ENVIADOS/SIN ALBARAN/" +/*DateTime.Today.ToString("yyyyMMdd")+*/"RESUMEN SIN ALBARAN";
            var RespuestaCrearFichero = Utilidades.ExportarReporte(reportViewer1, nombreFichero, ".PDF", "PDF");
            if (RespuestaCrearFichero == string.Empty)
            {
                List<string> adjuntos = new List<string>();
                adjuntos.Add(nombreFichero + ".PDF");

                //List<string> destinatarios = new List<string>();
                //destinatarios.Add(responderA);
                Utilidades.EnviaCorreo(VariablesGlobales.nIdEmpresaActual, responderA, "Resumen Albaranes pendientes Enviados a Proveedores", adjuntos, cuerpoMensaje, responderA, null, nombreRemitente);
            }

        }

        private void GuardarAsuntoCuerpoMensaje()
        {

            //this.Validate();
            //this.EmpresasActualBindingSource.EndEdit();
            //this.EmpresasActualTableAdapter.Update(Promowork_dataDataSet.EmpresasActual);

            configuracionUsuario.responderASeleccionado = idTrabajador;
            configuracionEmpresa.asuntoSinAlbaran = asuntoSinAlbaranTextEdit.Text;
            configuracionEmpresa.cuerpoMensajeSinAlbaran = cuerpoMensajeSinAlbaranTextEdit.Text;

            repoUsuario.GuardarConfiguracionUsuario(configuracionUsuario);
            repoEmpresa.GuardarConfiguracionEmpresa(configuracionEmpresa);
        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            var valido = (bool)gridView1.GetFocusedRowCellValue(colValido);
            if (!valido)
            {
                e.Cancel = true;
            }
        }

        private void GenerarReporteProveedor(int idProvedor)
        {
            
            this.reportViewer1.RefreshReport();
        }

        private void cbTrabajadores_EditValueChanged(object sender, EventArgs e)
        {
            if (cbTrabajadores.ItemIndex != -1)
            {
                idTrabajador = (int)cbTrabajadores.EditValue;
            }
            else
            {
                idTrabajador = null;
            }
        }

     
    }
}
