using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionData.Repositorios;
using DevExpress.XtraGrid.Columns;

namespace Promowork.Formularios.Operaciones
{
    public partial class frmParticipantesPresupuestos : Form
    {
        private int IdPresupCab;
        private int IdPresupCap;
        private int IdPresupDet;
        private int? IdPresupSub;

        RepositorioPresupuesto repoPresupuestos = new RepositorioPresupuesto();

        public frmParticipantesPresupuestos()//int idPresupCab, int idPresupCap, int idPresupDet, int idPresupSub
        {
            InitializeComponent();
            //22773	9464	24451
            IdPresupCab = 1219;// idPresupCab;
            IdPresupCap = 9709;// 9461;// idPresupCap;
            IdPresupDet = 24736;// 24450;// idPresupDet;
            IdPresupSub = null;// 22348;// idPresupSub;
        }

        private void frmParticipantesPresupuestos_Load(object sender, EventArgs e)
        {
            var participantes = repoPresupuestos.GetParticipantes(VariablesGlobales.nIdEmpresaActual);
            var participantePresupuesto = repoPresupuestos.GetOrCreateParticipantePartidaPresupuesto(VariablesGlobales.nIdEmpresaActual,
                VariablesGlobales.nIdUsuarioActual, IdPresupCab, IdPresupCap, IdPresupDet, IdPresupSub);

           // var proveedores = repoPresupuestos.GetOrCreateProveedoresParticipantes(participantePresupuesto.IdParticipantePresupuesto, 3);

            participantesBindingSource.DataSource = participantes;
            participantesPresupuestosBindingSource.DataSource = participantePresupuesto;
           // proveedoresParticipantesBindingSource.DataSource = proveedores;

            //int proveedorIndex=1;
            //foreach (var proveedor in proveedores)
            //{
            //    GridColumn columna = new GridColumn();
            //    columna.Name = "Proveedor" + proveedorIndex.ToString();
            //    columna.Caption = "Proveedor" + proveedorIndex.ToString();
            //    columna.Visible = true;
            //    //columna.FieldName = "IdProveedor";
            //    gridView1.Columns.Add(columna);
            //    gridView1.SetFocusedRowCellValue(columna, proveedor.IdProveedor);

            //    columna = new GridColumn();
            //    columna.Name = "Valor" + proveedorIndex.ToString();
            //    columna.Caption = "Valor" + proveedorIndex.ToString();
            //    columna.Visible = true;
            //    //columna.FieldName = "Precio";
            //    gridView1.Columns.Add(columna);
            //    gridView1.SetFocusedRowCellValue(columna, proveedor.Precio);

            //    columna = new GridColumn();
            //    columna.Name = "Seleccionado" + proveedorIndex.ToString();
            //    columna.Caption = "Seleccionado" + proveedorIndex.ToString();
            //    columna.Visible = true;
            //    //columna.FieldName = "Seleccionado";
            //    gridView1.Columns.Add(columna);
            //    gridView1.SetFocusedRowCellValue(columna, proveedor.Seleccionado);

            //    proveedorIndex += proveedorIndex;
            //}

        }
    }
}
