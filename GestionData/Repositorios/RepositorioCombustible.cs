using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionData.Modelos;
using GestionData.Entities;

namespace GestionData.Repositorios
{
    public class RepositorioCombustible//: IDisposable
    {
        OperacionesDataModel contextoOperaciones = new OperacionesDataModel();

        public bool InsertCombustibleDet(EntradasCombustibleDet detalleCombustible)
        {
            contextoOperaciones.EntradasCombustibleDet.AddObject(detalleCombustible);
            contextoOperaciones.SaveChanges();
            return true;
        }

        public bool EliminaCombustibleDetByIdAlbaranDet(int idAlbaranDet)
        {
            var detallesCombustible = GetEntradasCombustibleDetByAlbaran(idAlbaranDet);
            foreach (var detalleCombustible in detallesCombustible)
            {
                EliminaCombustibleDet(detalleCombustible);
            }
            return true;
        }

        public List<EntradasCombustibleDet> GetEntradasCombustibleDetByAlbaran(int idAlbaranDet)
        {
            return contextoOperaciones.EntradasCombustibleDet.Where(d => d.IdAlbaranDet == idAlbaranDet).ToList();
        }

        public bool EliminaCombustibleDet(EntradasCombustibleDet detalleDelete)
        {
            contextoOperaciones.EntradasCombustibleDet.DeleteObject(detalleDelete);
            contextoOperaciones.SaveChanges();
            return true;

        }

        public bool DetalleAlbaranInsertado(int idAlbaranDet)
        {
            return contextoOperaciones.EntradasCombustibleDet.Any(c => c.IdAlbaranDet == idAlbaranDet);
        }
    }
}
