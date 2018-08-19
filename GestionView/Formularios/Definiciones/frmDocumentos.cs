using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionData.Repositorios;
using GestionData.Modelos;

namespace Promowork.Formularios.Definiciones
{
    public partial class frmDocumentos : Form
    {
        public frmDocumentos()
        {
            InitializeComponent();
        }

        RepositorioDocumento repoDocumento = new RepositorioDocumento();

        private void documentosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.documentosBindingSource.EndEdit();
            
            var respuesta = repoDocumento.GuardarCambios();

            if (respuesta.ResultadoOk == false)
            {
                Mensajes.Error(respuesta.Mensaje);
            }
        }

        private void frmDocumentos_Load(object sender, EventArgs e)
        {
            var documentos = repoDocumento.GetAllDocumentos();
            documentosBindingSource.DataSource = documentos;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Documentos documento = (Documentos)gvDocumentos.GetFocusedRow();
            documento.UsuarioCrea = VariablesGlobales.nIdUsuarioActual;
            documento.UsuarioModifica = VariablesGlobales.nIdUsuarioActual;
            documento.FechaCrea = DateTime.Now;
            documento.FechaModifica = DateTime.Now;
        }

        private void gvDocumentos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Documentos documento = (Documentos)gvDocumentos.GetFocusedRow();
            documento.UsuarioModifica = VariablesGlobales.nIdUsuarioActual;
            documento.FechaModifica = DateTime.Now;
        }
    }
}
