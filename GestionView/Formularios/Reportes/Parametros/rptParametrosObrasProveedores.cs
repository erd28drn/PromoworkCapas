﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using Microsoft.Reporting.WinForms;
using GestionServices.Generales;
using GestionData.Entities;
using GestionServices.Definiciones;
using GestionData.Helpers;
using GestionData.Repositorios;

namespace Promowork.Formularios.Reportes.Parametros
{
    public partial class rptParametrosObrasProveedores : Form
    {
        public rptParametrosObrasProveedores()
        {
            InitializeComponent();
        }

        int nMes;
        int nAno;
        int nDiasFin;
        DateTime FechaIni;
        DateTime FechaFin;
        IEnumerable<ResumenEnvioCorreos> proveedores;
        IEnumerable<ObrasEnviar> obras;

        RepositorioUsuario repoUsuario = new RepositorioUsuario();
        RepositorioEmpresa repoEmpresa = new RepositorioEmpresa();
        RepositorioTrabajador repoTrabajador = new RepositorioTrabajador();
        ConfiguracionUsuario configuracionUsuario;
        ConfiguracionEmpresa configuracionEmpresa;
        int? idTrabajador = null;

        private void rptParametrosSinAlbaran_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Promowork_dataDataSet.Obras' Puede moverla o quitarla según sea necesario.
            this.ObrasTableAdapter.Fill(this.Promowork_dataDataSet.Obras);
            nMes = VariablesGlobales.nMesActual;
            nAno = VariablesGlobales.nAnoActual;
            nDiasFin = DateTime.DaysInMonth(nAno, nMes);
            FechaIni = new DateTime(nAno, nMes, 1);
            FechaFin = new DateTime(nAno, nMes, nDiasFin);

            dateTimePicker1.Value = FechaIni;
            dateTimePicker2.Value = FechaFin;
            dateTimePicker2.MinDate = FechaIni;

            configuracionUsuario = repoUsuario.GetConfiguracionUsuario(VariablesGlobales.nIdUsuarioActual) ?? new ConfiguracionUsuario();
            configuracionEmpresa = repoEmpresa.GetConfiguracionEmpresa(VariablesGlobales.nIdEmpresaActual) ?? new ConfiguracionEmpresa();

            this.EmpresasActualTableAdapter.FillByEmpresa(this.Promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);

            var trabajadores = repoTrabajador.GetTrabajadoresConEmail(VariablesGlobales.nIdEmpresaActual);
            cbTrabajadores.Properties.DataSource = trabajadores;

            cbTrabajadores.EditValue = configuracionUsuario.responderASeleccionado;

            tbAsuntoObrasProveedores.Text = configuracionEmpresa.asuntoObrasProveedores;
            tbCuerpoCorreo.Text = configuracionEmpresa.cuerpoMensajeObrasProveedores;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            tabControl1.SelectedTab = tabControl1.TabPages[1];
            CrearReporte();
            Cursor.Current = Cursors.Default;
        }

        private void CrearReporte()
        {
            ReportParameter[] Parametros = new ReportParameter[1];
            //Establecemos el valor de los parámetros

            //this.ObrasTableAdapter.FillByFechaObra(this.Promowork_dataDataSet.Obras, VariablesGlobales.nIdEmpresaActual);
            if (obras == null || !obras.Any())
            {
                CargarObras();
            }
            ObrasBindingSource.DataSource = obras.Where(o => o.Marca).ToList();
            Parametros[0] = new ReportParameter("Activas", "true");
            this.reportViewer1.LocalReport.SetParameters(Parametros);
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.RefreshReport();
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
            tabControl1.SelectedTab = tabControl1.TabPages[2];

            CargarProveedores();

        }

        private void CargarProveedores()
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                this.ObrasTableAdapter.FillByFechaObra(this.Promowork_dataDataSet.Obras, VariablesGlobales.nIdEmpresaActual);
                proveedores = proveedoresComprasAlbaranesTableAdapter.GetDataByProveedoresComprasAlbaranes(VariablesGlobales.nIdEmpresaActual, FechaIni, FechaFin)
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
                button3.Enabled = true;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                button3.Enabled = false;
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Error al validar los proveedores. " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[2];
            Cursor.Current = Cursors.WaitCursor;
            GuardarAsuntoCuerpoMensaje();

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

            CrearReporte();

            var cuerpoCorreo = tbCuerpoCorreo.Text.Replace("\n","<br>");
                
            if (!Directory.Exists("ENVIADOS/OBRAS"))
            {
                Directory.CreateDirectory("ENVIADOS/OBRAS");
            }
            string nombreFichero = "ENVIADOS/OBRAS/" +/*DateTime.Today.ToString("yyyyMMdd")+*/"LISTADO DE OBRAS ACTIVAS";
            var RespuestaCrearFichero = Utilidades.ExportarReporte(reportViewer1, nombreFichero, ".PDF", "PDF");
            
            foreach (var proveedor in proveedores.Where(p => p.Marca))
            {
                if (RespuestaCrearFichero == string.Empty)
                {
                    //List<string> destinatarios = new List<string>();
                    //destinatarios.Add("erd28drn@gmail.com");//compras@promowork.es

                    List<string> destinatarios= proveedor.Email.Split(';').ToList();
                    string asunto = tbAsuntoObrasProveedores.Text;// "Listado de Obras Activas";
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
            this.reportViewer1.RefreshReport();

            Cursor.Current = Cursors.Default;

        }

        private void GuardarAsuntoCuerpoMensaje()
        {
            //this.Validate();
            //this.EmpresasActualBindingSource.EndEdit();
            //this.EmpresasActualTableAdapter.Update(Promowork_dataDataSet.EmpresasActual);

            configuracionUsuario.responderASeleccionado = idTrabajador;
            configuracionEmpresa.asuntoObrasProveedores = tbAsuntoObrasProveedores.Text;
            configuracionEmpresa.cuerpoMensajeObrasProveedores = tbCuerpoCorreo.Text;

            repoUsuario.GuardarConfiguracionUsuario(configuracionUsuario);
            repoEmpresa.GuardarConfiguracionEmpresa(configuracionEmpresa);
        }

        private void EnviarResumenCorreosEnviados(List<string> responderA, string nombreRemitente)
        {
            string tablaHTML = Utilidades.CrearTablaHTMLDesdeGridView(gridView1);

            string cuerpoMensaje = "<p><h3>RESUMEN ENVIO DE OBRAS A PROVEEDORES.</p></h3>" + tablaHTML;

            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
            string nombreFichero = "ENVIADOS/OBRAS/" +/*DateTime.Today.ToString("yyyyMMdd")+*/"RESUMEN OBRAS PROVEEDORES";
            var RespuestaCrearFichero = Utilidades.ExportarReporte(reportViewer1, nombreFichero, ".PDF", "PDF");
            if (RespuestaCrearFichero == string.Empty)
            {
                List<string> adjuntos = new List<string>();
                adjuntos.Add(nombreFichero + ".PDF");

                //List<string> destinatarios = new List<string>();
                //destinatarios.Add(responderA);
                Utilidades.EnviaCorreo(VariablesGlobales.nIdEmpresaActual, responderA, "Resumen Obras Enviadas a Proveedores", adjuntos, cuerpoMensaje, responderA, null, nombreRemitente);
            }

        }

        private void GenerarReporteProveedor(int idProvedor)
        {
            
            this.reportViewer1.RefreshReport();
        }

        private void CargarObras()
        {
            Cursor.Current = Cursors.WaitCursor;
            //tabControl1.SelectedTab = tabControl1.TabPages[0];

            try
            {
                obras = ObrasTableAdapter.GetDataBy11(VariablesGlobales.nIdEmpresaActual).OrderBy(o => o.SerieObra).ThenBy(o => o.NumObra)
                    .Select(o => new ObrasEnviar
                    {
                        IdObra = o.IdObra,
                        Marca = o.EnviarProveedores,
                        Matriz = ObtenerMatriz(o.NumObraStr),
                        NumObra= o.NumObra,
                        SerieObra= o.SerieObra,
                        NumObraStr = ObtenerObraSM(o.NumObraStr),
                        DesObra = o.DesObra
                        //EnviarProveedor=o.EnviarProveedores
                        //NumeroDescripcion= o.ObraSM,
                        //MatrizNumeroDescripcion=o.Obra
                    }).ToList();
                obrasGridControl.DataSource = obras;
                button3.Enabled = true;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                button3.Enabled = false;
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Error al cargar las obras. " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string ObtenerObraSM(string numObraStr)
        {
            var posIniObra = numObraStr.LastIndexOf("-");
            if (posIniObra > 0)
            {
                return numObraStr.Substring(posIniObra+1).Trim();
            }
            else
            {
                return numObraStr;
            }
        }
        private int? ObtenerMatriz(string numObraStr)
        {
            var posIniObra = numObraStr.LastIndexOf("-");
            if (posIniObra > 0)
            {
                return int.Parse(numObraStr.Substring(0, posIniObra));
            }
            else
            {
                return null;
            }
        }

        private void btObras_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[0];
            CargarObras();
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


        private void gridView1_ShowingEditor_1(object sender, CancelEventArgs e)
        {
            var valido = (bool)gridView1.GetFocusedRowCellValue(colValido);
            if (!valido)
            {
                e.Cancel = true;
            }
        }

       
    }
}
