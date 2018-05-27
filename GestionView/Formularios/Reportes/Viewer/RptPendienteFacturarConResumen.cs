﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using GestionData.Modelos;
using GestionData.Repositorios;
using GestionData.Entities;
using GestionServices.Operaciones;


namespace Promowork.Formularios.Reportes.Viewer
{
    public partial class RptPendienteFacturarConResumen : Form
    {
        public RptPendienteFacturarConResumen()
        {
            InitializeComponent();
        }

        GestionData.Promowork_dataDataSet.HorasPendientesFacturarDataTable horasPendientes;

        internal void LoadParametros(DateTime fechaini, DateTime fechafin, DataTable  tmpObras, DataTable tmpTRabajadores, int Facturado, bool resumen,  bool agruparDescripcion )
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.EmpresasActual' table. You can move, or remove it, as needed.
            this.EmpresasActualTableAdapter.FillByEmpresa(this.Promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);

            this.HorasPendientesFacturarTableAdapter.Fill(this.Promowork_dataDataSet.HorasPendientesFacturar, tmpObras, tmpTRabajadores, fechaini, fechafin, Facturado);

            if (resumen)
            {
                if (agruparDescripcion)
                {
                    reportViewer1.LocalReport.ReportEmbeddedResource = "Promowork.Reportes.PendienteFacturarConResumen2.rdlc";
                }
                else
                {
                    reportViewer1.LocalReport.ReportEmbeddedResource = "Promowork.Reportes.PendienteFacturarConResumen.rdlc";
                }
            }
            else
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "Promowork.Reportes.PendienteFacturar.rdlc";
            }

            ReportParameter[] Parametros = new ReportParameter[2];
            //Establecemos el valor de los parámetros
            Parametros[0] = new ReportParameter("FechaIni", Convert.ToString(fechaini));
            Parametros[1] = new ReportParameter("FechaFin", Convert.ToString(fechafin));
           
            //Pasamos el array de los parámetros al ReportViewer
            this.reportViewer1.LocalReport.SetParameters(Parametros);

            this.reportViewer1.RefreshReport();



            horasPendientes = ((GestionData.Promowork_dataDataSet)HorasPendientesFacturarBindingSource.DataSource).HorasPendientesFacturar;

            var obras = horasPendientes.GroupBy(o => o.IdObra).Select(o => o.First())
                .Select(o => new ObrasFacturar { IdObra = o.IdObra, NumObra = o.NumObra, DesObra = o.DesObra }).OrderBy(o => o.NumObra).ToList();

            foreach (var obra in obras)
            {
                DevExpress.XtraEditors.Controls.CheckedListBoxItem item = new DevExpress.XtraEditors.Controls.CheckedListBoxItem();
                item.Value = obra.IdObra;
                item.Description = obra.NumeroDescripcion;
                item.CheckState = CheckState.Checked;
                cbObras.Properties.Items.Add(item);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se crearan las facturas de las obras seleccionadas. ¿Desea Continuar?", "Creación de facturas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                List<RespuestasServicios> respuestas = new List<RespuestasServicios>();
                foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in cbObras.Properties.GetItems())
                {
                    if (item.CheckState == CheckState.Checked)
                    {
                        List<GestionData.Promowork_dataDataSet.HorasPendientesFacturarRow> horasFactura = horasPendientes.Where(h => h.IdObra == (int)item.Value && h.Facturado == false).GroupBy(h => h.IdHoras).Select(h => h.First()).ToList();

                        if (horasFactura.Any())
                        {
                            FacturasClientesService facturasServices = new FacturasClientesService();
                            var resultado = facturasServices.CrearFacturaPartes(VariablesGlobales.nIdUsuarioActual, horasFactura);
                            respuestas.Add(resultado);
                        }


                    }
                }
                var errores = respuestas.Where(r => r.ResultadoOk != true);
                if (errores.Any())
                {
                    var mensaje = "";
                    foreach (var error in errores)
                    {
                        mensaje += error.Mensaje;
                    }
                    MessageBox.Show(mensaje, "Creación de Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Facturas Creadas Correctamente.", "Creación de Facturas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
        }

      
       
    }
}
