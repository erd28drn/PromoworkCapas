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


namespace Promowork.Formularios.Definiciones
{
    public partial class frmParticipantesDocumentos : Form
    {
        public frmParticipantesDocumentos()
        {
            InitializeComponent();
        }

        int idParticipante = -1;
        int idDocumento = -1;
        int idDocumentoParticipante = -1;

        RepositorioParticipante repoParticipante = new RepositorioParticipante();
        RepositorioDocumentosParticipante repoDocParticipante = new RepositorioDocumentosParticipante();

        private void frmParticipantesDocumentos_Load(object sender, EventArgs e)
        {
            var participantes = repoParticipante.GetAllParticipantesEmpresa(VariablesGlobales.nIdEmpresaActual);
            participantesBindingSource.DataSource = participantes;
        }

        private void gvParticipantes_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CargarDocumentos();
        }

        private void btAddDocumentoParticipante_Click(object sender, EventArgs e)
        {
            try
            {
                idDocumento = (int)gvDocumentosDisponibles.GetFocusedRowCellValue(colIdDocumentoDisponible);
            }
            catch
            {
                idDocumento = -1;
            }

            AgregaDocumentoParticipante();
        }

        private void AgregaDocumentoParticipante()
        {
            DocumentosParticipantes documentoParticipante = new DocumentosParticipantes();
            documentoParticipante.IdDocumento = idDocumento;
            documentoParticipante.IdEmpresa = VariablesGlobales.nIdEmpresaActual;
            documentoParticipante.IdParticipante = idParticipante;
            documentoParticipante.UsuarioCrea = VariablesGlobales.nIdUsuarioActual;
            documentoParticipante.FechaCrea = DateTime.Now;

            var respuesta = repoDocParticipante.AddDocumentoParticipante(documentoParticipante);

            if (respuesta.ResultadoOk == false)
            {
                Mensajes.Error(respuesta.Mensaje);
            }
            else
            {
                CargarDocumentos();
            }
        }

        private void CargarDocumentos()
        {
            try
            {
                idParticipante = (int)gvParticipantes.GetFocusedRowCellValue(colIdParticipantegvParticipantes);
            }
            catch
            {
                idParticipante = -1;
            }

            var documentosParticipante = repoDocParticipante.GetDocumentosParticipante(idParticipante);
            documentosParticipantesBindingSource.DataSource = documentosParticipante;

            var documentoDisponibles = repoDocParticipante.GetDocumentosDisponibles(idParticipante);
            DocumentosDisponibleBindingSource.DataSource = documentoDisponibles;

            EnableDisableControls();
        }
       
        private void btRemoveDocumentoParticipante_Click(object sender, EventArgs e)
        {
            try
            {
                idDocumentoParticipante = (int)gvDocumentosParticipante.GetFocusedRowCellValue(colIdDocumentoParticipante);
            }
            catch
            {
                idDocumentoParticipante = -1;
            }

            EliminaDocumentoParticipante();
        }

        private void EliminaDocumentoParticipante()
        {
            var respuesta = repoDocParticipante.RemoveDocumentoParticipante(idDocumentoParticipante);

            if (respuesta.ResultadoOk == false)
            {
                Mensajes.Error(respuesta.Mensaje);
            }
            else
            {
                CargarDocumentos();
            }
        }

        private void gvDocumentosParticipante_DoubleClick(object sender, EventArgs e)
        {
            EliminaDocumentoParticipante();
        }

        private void gvDocumentosDisponibles_DoubleClick(object sender, EventArgs e)
        {
            AgregaDocumentoParticipante();
        }

        private void EnableDisableControls()
        {
            btAddDocumentoParticipante.Enabled = idParticipante > 0 && DocumentosDisponibleBindingSource.Count > 0;
            btRemoveDocumentoParticipante.Enabled = idParticipante > 0 && documentosParticipantesBindingSource.Count > 0;
        }

        private void documentosParticipantesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.participantesBindingSource.EndEdit();
            var respuesta = repoParticipante.GuardarCambios();


            if (respuesta.ResultadoOk == false)
            {
                Mensajes.Error(respuesta.Mensaje);
            }
            else
            {
                gvParticipantes.RefreshData();

                EnableDisableControls();
            }
            CargarDocumentos();

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Participantes participante = (Participantes)gvParticipantes.GetFocusedRow();
            participante.IdEmpresa = VariablesGlobales.nIdEmpresaActual;
            participante.UsuarioCrea = VariablesGlobales.nIdUsuarioActual;
            participante.UsuarioModifica = VariablesGlobales.nIdUsuarioActual;
            participante.FechaCrea = DateTime.Now;
            participante.FechaModifica = DateTime.Now;
            participante.ActivoParticipante = true;

        }

        private void gvParticipantes_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Participantes participante = (Participantes)gvParticipantes.GetFocusedRow();
            participante.UsuarioModifica = VariablesGlobales.nIdUsuarioActual;
            participante.FechaModifica = DateTime.Now;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            gvParticipantes.RefreshEditor(true);
            gvParticipantes.RefreshData();

            CargarDocumentos();

        }
    }
}
