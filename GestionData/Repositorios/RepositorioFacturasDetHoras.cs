using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionData.Modelos;
using GestionData.Entities;

namespace GestionData.Repositorios
{
    public class RepositorioFacturasDetHoras
    {
        OperacionesDataModel contextoOperaciones = new OperacionesDataModel();

        public int InsertFacturaDetHoras(FacturasDetHoras facturasDetHoras)
        {
            contextoOperaciones.FacturasDetHoras.AddObject(facturasDetHoras);
            contextoOperaciones.SaveChanges();
            return facturasDetHoras.IdFactDetHoras;
        }
    }
}
