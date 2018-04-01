﻿using System;
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
    public partial class TiposServicios : Form
    {
        public TiposServicios()
        {
            InitializeComponent();
        }

       
        private void TiposCombustibles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GestionData.Promowork_dataDataSetCombustible.UMedidas' table. You can move, or remove it, as needed.
            this.uMedidasTableAdapter.Fill(this.Promowork_dataDataSetCombustible.UMedidas);
            // TODO: This line of code loads data into the 'GestionData.Promowork_dataDataSetCombustible.tiposServicios' table. You can move, or remove it, as needed.
            this.TiposServiciosTableAdapter.FillByServicios(this.Promowork_dataDataSetCombustible.TiposServicios);

        }

       
        private void TiposServiciosDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            bindingNavigatorAddNewItem_Click(null, null);
        }

        private void TiposServiciosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.TiposServiciosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.Promowork_dataDataSetCombustible);
            }
            catch (DBConcurrencyException)
            {

                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.TiposServiciosTableAdapter.FillByServicios(this.Promowork_dataDataSetCombustible.TiposServicios);
            }
            catch (SqlException ex)
            {
                if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                {
                    this.TiposServiciosTableAdapter.FillByServicios(this.Promowork_dataDataSetCombustible.TiposServicios);
                }

            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            TiposServiciosDataGridView.CurrentRow.Cells["activoServicio"].Value = true;
            TiposServiciosDataGridView.CurrentRow.Cells["Combustible"].Value = false;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.TiposServiciosBindingSource.RemoveCurrent();
            }
        }
    }
}
