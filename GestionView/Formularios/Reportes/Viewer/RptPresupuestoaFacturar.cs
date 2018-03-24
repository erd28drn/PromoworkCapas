﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Promowork.Formularios.Reportes.Viewer
{
    public partial class RptPresupuestoaFacturar : Form
    {
        public RptPresupuestoaFacturar()
        {
            InitializeComponent();
        }

        internal void LoadFiltro(int nIdPresupuesto)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.PresupuestoActual' table. You can move, or remove it, as needed.
            this.PresupuestoActualTableAdapter.FillByaFacturar(this.Promowork_dataDataSet.PresupuestoActual, nIdPresupuesto);
            // TODO: This line of code loads data into the 'Promowork_dataDataSet.EmpresasActual' table. You can move, or remove it, as needed.
            this.EmpresasActualTableAdapter.FillByEmpresa(this.Promowork_dataDataSet.EmpresasActual, VariablesGlobales.nIdEmpresaActual);

            this.reportViewer1.RefreshReport();
        }

       
    }
}