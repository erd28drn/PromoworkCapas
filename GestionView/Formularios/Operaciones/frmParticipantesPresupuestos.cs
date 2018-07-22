using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionData.Repositorios;
using GestionData.Modelos;
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
        RepositorioProveedor repoProveedor = new RepositorioProveedor();

        List<ParticipantesPresupuestos> participantesEliminar = new List<ParticipantesPresupuestos>();

        string AparienciaGridParticipantes = "";

        public frmParticipantesPresupuestos(int idPresupCab, int idPresupCap, int idPresupDet, int? idPresupSub)
        {
            InitializeComponent();
            IdPresupCab = idPresupCab;
            IdPresupCap = idPresupCap;
            IdPresupDet = idPresupDet;
            IdPresupSub = idPresupSub;
        }

        private void frmParticipantesPresupuestos_Load(object sender, EventArgs e)
        {
            var participantes = repoProveedor.GetParticipantes(VariablesGlobales.nIdEmpresaActual);
            var proveedores = repoProveedor.GetProveedores(VariablesGlobales.nIdEmpresaActual);
            //var participantePresupuesto = repoPresupuestos.GetOrCreateParticipantesPartidaPresupuesto(VariablesGlobales.nIdEmpresaActual,
            //    VariablesGlobales.nIdUsuarioActual, IdPresupCab, IdPresupCap, IdPresupDet, IdPresupSub);

           // var proveedores = repoPresupuestos.GetOrCreateProveedoresParticipantes(participantePresupuesto.IdParticipantePresupuesto, 3);

            participantesBindingSource.DataSource = participantes;
            proveedoresBindingSource.DataSource = proveedores;

            AparienciaGridParticipantes = this.Name + gvParticipantesPresupuestos.Name + VariablesGlobales.nIdEmpresaActual.ToString() + VariablesGlobales.nIdUsuarioActual.ToString() + ".xml";

            try
            {
               gvParticipantesPresupuestos.RestoreLayoutFromXml(AparienciaGridParticipantes);
            }
            catch { }

            CargarParticipantes();
            //participantesPresupuestosBindingSource.DataSource = participantePresupuesto;

        }

        private void participantesPresupuestosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            participantesPresupuestosBindingSource.EndEdit();

            foreach (var participanteEliminar in participantesEliminar)
            {
                repoPresupuestos.DeleteParticipantePartidaPresupuesto(participanteEliminar);
            }

            if (participantesPresupuestosBindingSource.Count > 1)
            {
                var participantesPresupuesto = (List<ParticipantesPresupuestos>)participantesPresupuestosBindingSource.DataSource;
                foreach (var participantePresupuesto in participantesPresupuesto)
                {
                    repoPresupuestos.UpdateParticipantePartidaPresupuesto(participantePresupuesto);
                }
                CargarParticipantes();
            }

            if (participantesPresupuestosBindingSource.Count == 1)
            {
                var participantePresupuesto = (ParticipantesPresupuestos)participantesPresupuestosBindingSource.DataSource;
                participantePresupuesto = repoPresupuestos.UpdateParticipantePartidaPresupuesto(participantePresupuesto);
                participantesPresupuestosBindingSource.DataSource = participantePresupuesto;
            }
        }

        private void chkMostrarTodoPresupuesto_CheckedChanged(object sender, EventArgs e)
        {
            CargarParticipantes();
        }

        private void CargarParticipantes()
        {
            if (chkMostrarTodoPresupuesto.CheckState == CheckState.Checked)
            {
                var participantesPresupuesto = repoPresupuestos.GetParticipantesPresupuesto(IdPresupCab);
                participantesPresupuestosBindingSource.DataSource = participantesPresupuesto;
            }
            else
            {
                var participantePresupuesto = repoPresupuestos.GetOrCreateParticipantesPartidaPresupuesto(VariablesGlobales.nIdEmpresaActual,
                        VariablesGlobales.nIdUsuarioActual, IdPresupCab, IdPresupCap, IdPresupDet, IdPresupSub);
                participantesPresupuestosBindingSource.DataSource = participantePresupuesto;
            }
        }

       private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var participanteEliminar = (ParticipantesPresupuestos)participantesPresupuestosBindingSource.Current;
            participantesEliminar.Add(participanteEliminar);
            participantesPresupuestosBindingSource.RemoveCurrent();

        }

       private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
       {
           var participantePresupuesto = (ParticipantesPresupuestos)participantesPresupuestosBindingSource.Current;
           participantePresupuesto.IdParticipantePresupuesto = 0;
           repoPresupuestos.AddParticipantePartidaPresupuesto(participantePresupuesto);

           CargarParticipantes();
       }

       private void frmParticipantesPresupuestos_FormClosing(object sender, FormClosingEventArgs e)
       {
          gvParticipantesPresupuestos.SaveLayoutToXml(AparienciaGridTareas);
       }
    }
}
