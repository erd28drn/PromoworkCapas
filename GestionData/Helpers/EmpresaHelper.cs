using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionData;

namespace GestionData.Helpers
{
    public class EmpresaHelper
    {
        
        public bool GuardarCambios(Promowork_dataDataSet.EmpresasDataTable empresaDataTable)
        { 
            Promowork_dataDataSetTableAdapters.EmpresasTableAdapter empresTableAdapter= new Promowork_dataDataSetTableAdapters.EmpresasTableAdapter();
            empresTableAdapter.Update(empresaDataTable);

            return true;
        }
    }
}
