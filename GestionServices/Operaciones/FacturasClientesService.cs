using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionData.Entities;

namespace GestionServices.Operaciones
{
    public static class FacturasClientesService
    {
        public static int GetUltimaFactura(int empresa, int anoFactura, bool esFactura)
        {
            int ultimaFactura = 0;
            Promowork_dataEntities contexto = new Promowork_dataEntities();
            var facturasEmpresaAno = contexto.FacturasCabs.Where(f => f.IdEmpresa == empresa && f.FechaFactura.Year == anoFactura && f.EsPrevision == false && f.Factura == esFactura);
            //contexto.Refresh(System.Data.Objects.RefreshMode.StoreWins, facturasEmpresaAno);
            if (facturasEmpresaAno.Any())
            {
                ultimaFactura = facturasEmpresaAno.Max(f => f.NumFactura);
            }
            return ultimaFactura;
        }
    }
}
