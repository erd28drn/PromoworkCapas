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
    public partial class VehiculosNotificaciones : Form
    {
        public VehiculosNotificaciones()
        {
            InitializeComponent();
        }

        private void vehiculosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.vehiculosBindingSource.EndEdit();
                this.vehiculosTableAdapter.Update(Promowork_dataDataSetCombustible.Vehiculos);
              //  this.tableAdapterManager.UpdateAll(this.Promowork_dataDataSetCombustible);
                serviciosVehiculosDataGridView.AllowUserToAddRows = true;
                toolStripButton1.Enabled = true;
            }
            catch (DBConcurrencyException)
            {

                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.vehiculosTableAdapter.Fill(this.Promowork_dataDataSetCombustible.Vehiculos, VariablesGlobales.nIdEmpresaActual);
            }
            catch (SqlException ex)
            {
                if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                {
                    this.vehiculosTableAdapter.Fill(this.Promowork_dataDataSetCombustible.Vehiculos, VariablesGlobales.nIdEmpresaActual);
                }

            }
        }

        private void Vehiculos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GestionData.Promowork_dataDataSetCombustible.TiposServicios' table. You can move, or remove it, as needed.
            this.tiposServiciosTableAdapter.FillByServicios(this.Promowork_dataDataSetCombustible.TiposServicios);
            // TODO: This line of code loads data into the 'GestionData.Promowork_dataDataSetCombustible.ServiciosVehiculos' table. You can move, or remove it, as needed.
            this.serviciosVehiculosTableAdapter.Fill(this.Promowork_dataDataSetCombustible.ServiciosVehiculos);
            // TODO: This line of code loads data into the 'GestionData.Promowork_dataDataSetCombustible.Vehiculos' table. You can move, or remove it, as needed.
            this.vehiculosTableAdapter.Fill(this.Promowork_dataDataSetCombustible.Vehiculos, VariablesGlobales.nIdEmpresaActual);

        }

        private void vehiculosDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            serviciosVehiculosDataGridView.AllowUserToAddRows = false;
            toolStripButton1.Enabled = false;
            vehiculosDataGridView.CurrentRow.Cells["ActivoVehiculo"].Value = true;
            vehiculosDataGridView.CurrentRow.Cells["IdEmpresa"].Value = VariablesGlobales.nIdEmpresaActual;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            serviciosVehiculosDataGridView.AllowUserToAddRows = false;
            toolStripButton1.Enabled = false;
            vehiculosDataGridView.CurrentRow.Cells["ActivoVehiculo"].Value = true;
            vehiculosDataGridView.CurrentRow.Cells["IdEmpresa"].Value = VariablesGlobales.nIdEmpresaActual;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            queriesTableAdapter1.AgregaServiciosVehiculos(VariablesGlobales.nIdEmpresaActual, Convert.ToInt32(vehiculosDataGridView.CurrentRow.Cells["IdVehiculo1"].Value));
            this.serviciosVehiculosTableAdapter.Fill(this.Promowork_dataDataSetCombustible.ServiciosVehiculos);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.serviciosVehiculosBindingSource.EndEdit();
                this.serviciosVehiculosTableAdapter.Update(Promowork_dataDataSetCombustible.ServiciosVehiculos);
                //  this.tableAdapterManager.UpdateAll(this.Promowork_dataDataSetCombustible);
            }
            catch (DBConcurrencyException)
            {

                MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.serviciosVehiculosTableAdapter.Fill(this.Promowork_dataDataSetCombustible.ServiciosVehiculos);
            }
            catch (SqlException ex)
            {
                if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                {
                    this.serviciosVehiculosTableAdapter.Fill(this.Promowork_dataDataSetCombustible.ServiciosVehiculos);
                }

            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.vehiculosBindingSource.RemoveCurrent();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.serviciosVehiculosBindingSource.RemoveCurrent();
            }
        }
    }
}
