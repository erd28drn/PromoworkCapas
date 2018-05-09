using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionData.Modelos;
using GestionData.Entities;

namespace GestionData.Repositorios
{
    public class RepositorioFacturasCab
    {
        OperacionesDataModel contextoOperaciones = new OperacionesDataModel();

        public string GetUltimaFactura(int empresa, int anoFactura, bool esFactura)
        {
            string ultimaFactura = "";
            var facturasEmpresaAno = contextoOperaciones.FacturasCab.Where(f => f.IdEmpresa == empresa && f.FechaFactura.Year == anoFactura && f.EsPrevision == false && f.Factura == true);
            //contexto.Refresh(System.Data.Objects.RefreshMode.StoreWins, facturasEmpresaAno);
            if (facturasEmpresaAno.Any())
            {
                ultimaFactura = facturasEmpresaAno.Max(f => f.NumFactura).ToString(); ;
            }
            facturasEmpresaAno = contextoOperaciones.FacturasCab.Where(f => f.IdEmpresa == empresa && f.FechaFactura.Year == anoFactura && f.EsPrevision == false && f.Factura == false);
            //contexto.Refresh(System.Data.Objects.RefreshMode.StoreWins, facturasEmpresaAno);
            if (facturasEmpresaAno.Any())
            {
                ultimaFactura = ultimaFactura +" - "+facturasEmpresaAno.Max(f => f.NumFactura).ToString(); ;
            }


            return ultimaFactura;
        }

        public DateTime? GetFechaEnvioCliente(int idFactura)
        {
           return contextoOperaciones.FacturasCab.FirstOrDefault(f => f.IdFactCab == idFactura).FechaEnvioCliente;
        }

        public bool GuardarFechaEnvioFacturaCliente(int idFactura, DateTime? fechaEnvioFactura)
        {
            var facturaActual = contextoOperaciones.FacturasCab.FirstOrDefault(f => f.IdFactCab == idFactura);

            facturaActual.FechaEnvioCliente = fechaEnvioFactura;
            facturaActual.Entregada = true;
            contextoOperaciones.SaveChanges();
            return true;
        }
    }
}
