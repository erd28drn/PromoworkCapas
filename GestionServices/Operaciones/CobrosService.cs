using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using GestionData.Entities;
using GestionData.Modelos;
using GestionData.Repositorios;

namespace GestionServices.Operaciones
{
    public class CobrosService
    {
        RepositorioCobro repoCobro = new RepositorioCobro();
        RepositorioFacturasCab repoFactCab = new RepositorioFacturasCab();
        
        public bool ValidaActualizaVinculacionFacturasCobros(int empresa, int periodo)
        {
            bool ok = false;
            var cobrosSinVincular = repoCobro.GetCobrosSinFactura(empresa, periodo);

            foreach (var cobro in cobrosSinVincular)
            {
                var factura = repoFactCab.GetFacturaFromNumeroFactura(empresa, cobro.Factura);

                if (factura != null)
                {
                    cobro.IdFactCab = factura.IdFactCab;
                    cobro.FechaFactura = cobro.FechaFactura ?? factura.FechaFactura;
                    repoCobro.UpdateCobro(cobro);
                    ok = true;
                }
            }
           
            return ok;
            
        }

    }
}
