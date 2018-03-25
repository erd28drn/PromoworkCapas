﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using GestionServices.Generales;

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
            
            this.EmpresasActualTableAdapter.FillByEmpresa(this.Promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);

            var trabajadores= Utilidades.ObtenerTrabajadoresConEmail(VariablesGlobales.nIdEmpresaActual);
            cbTrabajadores.Properties.DataSource = trabajadores;
            
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
                        Marca = Utilidades.ValidarEmail(p.EmailProveedor),
                        Proveedor = p.DesProveedor,
                        Email = p.EmailProveedor,
                        Valido = Utilidades.ValidarEmail(p.EmailProveedor),
                        Enviado = null
                    }).ToList();
                gridControl1.DataSource = proveedores;
                button3.Enabled = true;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                button3.Enabled = false;
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Error al validar los proveedores." + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
        }

        private class ResumenEnvioCorreos
        {
            public int IdProveedor { get; set; }
            public bool Marca { get; set; }
            public string Proveedor {get; set;}
            public string Email {get; set;}
            public bool Valido {get; set;}
            public bool? Enviado {get; set;}
            public string Respuesta { get; set; }
        }

        private void fillbySinAlbaranToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void fillbySinAlbaranToolStripButton_Click_1(object sender, EventArgs e)
        {

        }

        private void fillbySinAlbaranToolStripButton_Click_2(object sender, EventArgs e)
        {

        }

        private void fillbySinAlbaranToolStripButton_Click_3(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            GuardarAsuntoCuerpoMensaje();

            var cuerpoCorreo = cuerpoMensajeSinAlbaranTextEdit.Text.Replace("\n", "<br>"); 
                
                
                //"<p>Con el fin de poder verificar sus facturas, rogamos nos envien copia de los siguientes albaranes a compras@promowork.es " +
                //                "Ya que NO disponemos de ellos. Para ello, será necesario que conste la firma y el DNI de la persona autorizada que realizó " +
                //                "la retirada del material o autorizó la escarga.</p>" +
                //                "<p>Sin otro particular,<br>" +
                //                "Le saludo muy cordialmente,</p>" +
                //                "<p>Oscar Urpi<br>" +
                //                "Dpto.Compras.</p>";

            string responderA="";
            if (cbTrabajadores.ItemIndex != -1)
            {
                var trabajador = (Utilidades.TrabajadorConEmail)cbTrabajadores.GetSelectedDataRow();

                responderA = trabajador.EmailTrabajador;
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
                    List<string> destinatarios = new List<string>();
                    destinatarios.Add("erd28drn@gmail.com");

                    
                    
                    
                    //List<string> destinatarios= proveedor.Email.Split(';').ToList();
                    string asunto = asuntoSinAlbaranTextEdit.Text;// "Albaranes Pendientes";
                    List<string> adjuntos= new List<string>();
                    adjuntos.Add(nombreFichero+ ".PDF");
                    string respuestaEnviarCorreo= Utilidades.EnviaCorreo(VariablesGlobales.nIdEmpresaActual, destinatarios, asunto, adjuntos, cuerpoCorreo, responderA);
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

            EnviarResumenCorreosEnviados("erd28drn@gmail.com");

            

            Cursor.Current = Cursors.Default;

        }

        private void EnviarResumenCorreosEnviados(string responderA)
        {
            string str;
            MemoryStream ms = new MemoryStream();
            try
            {
                //gridView1.ExportToHtml(ms);
                //ms.Seek(0, SeekOrigin.Begin);
                //StreamReader sr = new StreamReader(ms);
                str = Utilidades.CrearTablaDesdeGridView(gridView1); //sr.ReadToEnd();
            }
            finally
            {
                ms.Close();
            }

            string cuerpoMensaje = "<p><h3>RESUMEN ENVIO DE ALBARANES PENDEIENTES A PROVEEDORES.</p></h3>" + str;

            vAlbaranesBindingSource.Filter = "";
            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
                string nombreFichero= "ENVIADOS/SIN ALBARAN/"+/*DateTime.Today.ToString("yyyyMMdd")+*/"RESUMEN SIN ALBARAN";
                var RespuestaCrearFichero= Utilidades.ExportarReporte(reportViewer1, nombreFichero, ".PDF", "PDF");
                if (RespuestaCrearFichero == string.Empty)
                {
                    List<string> adjuntos = new List<string>();
                    adjuntos.Add(nombreFichero + ".PDF");

                    List<string> destinatarios = new List<string>();
                    destinatarios.Add(responderA);
                    Utilidades.EnviaCorreo(VariablesGlobales.nIdEmpresaActual, destinatarios, "Resumen Correos Enviados a Proveedores", adjuntos, cuerpoMensaje, responderA);
                }
        
        }

        private void GuardarAsuntoCuerpoMensaje()
        {
            this.Validate();
            this.EmpresasActualBindingSource.EndEdit();
            this.EmpresasActualTableAdapter.Update(Promowork_dataDataSet.EmpresasActual);
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

     
    }
}
