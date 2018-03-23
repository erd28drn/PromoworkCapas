using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Promowork.Formularios.Operaciones
{
    public partial class EntradasCombustible : Form
    {
        public EntradasCombustible()
        {
            InitializeComponent();
        }

        int nIdCompra = 0;
        private void entradasCombustibleCabBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           try
           {
            this.Validate();
            this.entradasCombustibleDetBindingSource.EndEdit();
            this.entradasCombustibleDetTableAdapter.Update(this.Promowork_dataDataSetCombustible.EntradasCombustibleDet);
            }
                catch (DBConcurrencyException)
                {

                    MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                     this.entradasCombustibleDetTableAdapter.Fill(this.Promowork_dataDataSetCombustible.EntradasCombustibleDet);
                }
                catch (SqlException ex)
                {
                    if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                         this.entradasCombustibleDetTableAdapter.Fill(this.Promowork_dataDataSetCombustible.EntradasCombustibleDet);
                    }
                    
                }
        }

       private void EntradasCombustible_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: esta línea de código carga datos en la tabla 'GestionData.Promowork_dataDataSetCombustible.TiposServicios' Puede moverla o quitarla según sea necesario.
            this.tiposServiciosTableAdapter.FillByCombustibles(this.Promowork_dataDataSetCombustible.TiposServicios);
            // TODO: esta línea de código carga datos en la tabla 'GestionData.Promowork_dataDataSetCombustible.FormasPago' Puede moverla o quitarla según sea necesario.
            this.uMedidasTableAdapter.Fill(this.Promowork_dataDataSetCombustible.UMedidas);
            // TODO: esta línea de código carga datos en la tabla 'GestionData.Promowork_dataDataSetCombustible.EntradasCombustibleDet' Puede moverla o quitarla según sea necesario.
            //this.entradasCombustibleDetTableAdapter.Fill(this.Promowork_dataDataSetCombustible.EntradasCombustibleDet);
            this.entradasCombustibleCabTableAdapter.Fill(GestionData.Promowork_dataDataSetCombustible.EntradasCombustibleCab, VariablesGlobales.nIdEmpresaActual);

            entradasCombustibleCabBindingSource.MoveLast();

        }

       private void entradasCombustibleDetDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
       {
           MessageBox.Show("Error de Formato", this.Text);
       }

       private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
       {
           if (MessageBox.Show("Confirma que desea Eliminar?.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
           {
               this.entradasCombustibleDetBindingSource.RemoveCurrent();
           }
       }

       private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
       {
           
           nIdCompra= (int)gridView1.GetFocusedRowCellValue("IdCompra");
           this.entradasCombustibleDetTableAdapter.FillByCompra(this.Promowork_dataDataSetCombustible.EntradasCombustibleDet, nIdCompra);

           
       }

       private void toolStripButton1_Click(object sender, EventArgs e)
       {
           gridView2.SetFocusedRowCellValue("IdCompra", nIdCompra);
       }

       private void Servicio_EditValueChanged(object sender, EventArgs e)
       {
         
       }

       private void Servicio_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
       {
           var servicio = GestionData.Promowork_dataDataSetCombustible.TiposServicios.FindByIdServicio((int)e.NewValue);
           try
           {
               gridView2.SetFocusedRowCellValue("Precio", servicio.PrecioServicio);
           }
           catch 
           { 
               gridView2.SetFocusedRowCellValue("Precio", 0); 
           }
       }

      
    }
}
