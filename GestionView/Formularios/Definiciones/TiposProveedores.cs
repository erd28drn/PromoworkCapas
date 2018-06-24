using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionServices.Generales;

namespace Promowork.Formularios.Definiciones
{
    public partial class TiposProveedores : Form
    {
        public TiposProveedores()
        {
            InitializeComponent();
        }

        private void participantesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.participantesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.promowork_dataDataSet);
            }
                catch (DBConcurrencyException)
                {

                    MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.participantesTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Participantes, VariablesGlobales.nIdEmpresaActual);
                }
                catch (SqlException ex)
                {
                    if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                        this.participantesTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Participantes, VariablesGlobales.nIdEmpresaActual);

                    }

                }
        }

        private void TiposProveedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Participantes' table. You can move, or remove it, as needed.
            this.participantesTableAdapter.FillByEmpresa(this.promowork_dataDataSet.Participantes, VariablesGlobales.nIdEmpresaActual);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.participantesBindingSource.RemoveCurrent();
            }
        }

       private void participantesBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            DataRowView participante = (DataRowView)e.NewObject;
            participante["IdEmpresa"] = VariablesGlobales.nIdEmpresaActual;
        }
    }
}
