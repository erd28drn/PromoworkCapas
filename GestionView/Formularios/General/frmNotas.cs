using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionData.Modelos;
using GestionData.Repositorios;

namespace Promowork.Formularios.General
{
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        RepositorioNota repoNota = new RepositorioNota();
        List<Notas> notas;

        private void frmNotas_Load(object sender, EventArgs e)
        {
            notas = repoNota.GetAll();
            notasBindingSource.DataSource = notas;
        }

        private void notasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            notasBindingSource.EndEdit();
            notas = (List<Notas>)notasBindingSource.DataSource;
            repoNota.InsertUpdateDelete(notas, VariablesGlobales.nIdUsuarioActual);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
