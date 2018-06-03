using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionData.Entities;

namespace Promowork.Formularios.Reportes.Viewer
{
    public partial class RptListadoPresupuestos : Form
    {
        public RptListadoPresupuestos()
        {
            InitializeComponent();
        }

        internal void LoadFiltro(List<ListadoPresupuestos> presupuestos)
        {
            this.WindowState = FormWindowState.Maximized;

            ListadoPresupuestosBindingSource.DataSource = presupuestos.OrderBy(p=> p.NumPresup);
            
            string nombre = "LISTADO DE PRESUPUESTOS";
            this.Text = nombre;
            this.reportViewer1.LocalReport.DisplayName = nombre;
            this.reportViewer1.LocalReport.EnableExternalImages = true;

            this.reportViewer1.RefreshReport();
        }
       
    }
}
