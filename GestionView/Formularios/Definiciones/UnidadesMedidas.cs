﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Promowork.Formularios.Definiciones
{
    public partial class UnidadesMedidas : Form
    {
        public UnidadesMedidas()
        {
            InitializeComponent();
        }

        private void combustiblesTiposBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try{
            this.Validate();
            this.uMedidasBindingSource.EndEdit();
            this.uMedidasTableAdapter.Update(this.Promowork_dataDataSetCombustible.UMedidas);
             }
            catch (DBConcurrencyException)
            {

                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.uMedidasTableAdapter.Fill(this.Promowork_dataDataSetCombustible.UMedidas);
            }
            catch (SqlException ex)
            {
                if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                {
                    this.uMedidasTableAdapter.Fill(this.Promowork_dataDataSetCombustible.UMedidas);
                }
                
            }
        }

        private void TiposCombustibles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GestionData.Promowork_dataDataSetCombustible.UMedidas' table. You can move, or remove it, as needed.
            this.uMedidasTableAdapter.Fill(this.Promowork_dataDataSetCombustible.UMedidas);

        }

        private void combustiblesTiposDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            combustiblesTiposDataGridView.CurrentRow.Cells["activaUM"].Value = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            combustiblesTiposDataGridView.CurrentRow.Cells["activaUM"].Value = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.uMedidasBindingSource.RemoveCurrent();
            }
        }
    }
}
