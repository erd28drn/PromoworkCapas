using System;
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


namespace Promowork.Formularios.Reportes.Viewer
{
    public partial class RptPendienteFacturarConResumen : Form
    {
        public RptPendienteFacturarConResumen()
        {
            InitializeComponent();
        }

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



            var obras = ((GestionData.Promowork_dataDataSet)HorasPendientesFacturarBindingSource.DataSource).HorasPendientesFacturar.GroupBy(o => o.IdObra).Select(o=>o.First())
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

        }

      
       
    }
}
