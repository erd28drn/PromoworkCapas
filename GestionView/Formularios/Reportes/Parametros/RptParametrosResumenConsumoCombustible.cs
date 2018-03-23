using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Promowork.Formularios.Definiciones;
using Promowork.Formularios.General;
using Promowork.Formularios.Reportes.Parametros;
using Promowork.Formularios.Reportes.Viewer;
using Promowork.Formularios.Operaciones;
using GestionData;
using GestionData.Enumeradores;

namespace Promowork.Formularios.Reportes.Parametros
{
    public partial class RptParametrosResumenConsumoCombustible : Form
    {
        public RptParametrosResumenConsumoCombustible()
        {
            InitializeComponent();
        }

        private void RptParametrosResumenConsumoCombustible_Load(object sender, EventArgs e)
        {
           this.empresasTableAdapter.Fill(Promowork_dataDataSetCombustible.Empresas,VariablesGlobales.nIdEmpresaActual);

            dateTimePicker1.Value = new DateTime(VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual, 1);
            dateTimePicker2.Value = new DateTime(VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual, DateTime.DaysInMonth(VariablesGlobales.nAnoActual, VariablesGlobales.nMesActual));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RptResumenConsumoCombustible frm = new RptResumenConsumoCombustible();
            frm.LoadParametros(dateTimePicker1.Value, dateTimePicker2.Value);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

    }
}
