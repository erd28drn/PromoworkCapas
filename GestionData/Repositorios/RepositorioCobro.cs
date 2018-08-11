using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionData.Modelos;
using GestionData.Entities;

namespace GestionData.Repositorios
{
    public class RepositorioCobro
    {
        OperacionesDataModel contextoOperaciones = new OperacionesDataModel();
  
        public Cobros GetOneCobro(int idCobro)
        {
            var cobro = contextoOperaciones.Cobros.FirstOrDefault(a => a.IdCobro == idCobro);
            return cobro;
        }

        public bool UpdateCobro(Cobros cobro)
        {
            var cobroToUpdate = contextoOperaciones.Cobros.FirstOrDefault(a => a.IdCobro == cobro.IdCobro);
            cobroToUpdate = cobro;
            contextoOperaciones.SaveChanges();
            return true;
        }

        public List<Cobros> GetCobrosSinFactura(int empresa, int periodo)
        {
            var cobros = contextoOperaciones.Cobros.Where(c => c.IdEmpresa == empresa && c.FechaAbono.Value.Year == periodo && c.IdFactCab == null && c.Factura != null && c.Factura.Trim() != "").ToList();

            return cobros;
        }
    }
}
