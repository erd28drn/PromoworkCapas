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

namespace Promowork.Formularios.Operaciones
{
    public partial class FacturasIncorrectas : Form
    {
        public FacturasIncorrectas()
        {
            InitializeComponent();
        }

        internal void LoadParametros(DataTable tmpFacturas)
        {
            gridFacturas.DataSource = tmpFacturas;
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
