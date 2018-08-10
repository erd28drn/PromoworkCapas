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
    public class CombustibleService
    {
        RepositorioCombustible repoCombustible = new RepositorioCombustible();
        RepositorioAlbaran repoAlbaran = new RepositorioAlbaran();
        RepositorioProveedor repoProveedor = new RepositorioProveedor();
        RepositorioProducto repoProducto = new RepositorioProducto();
        
        public bool ValidaInsertaDetalleCombustible(int idCompra, int idAlbaranCab, decimal IVA)
        {
            bool insertado = false;
            var albaranCab = repoAlbaran.GetAlbaranCab(idAlbaranCab);

            if (repoProveedor.EsProveedorCombustible(albaranCab.IdProveedor ?? 0))
            {
                var albaranesDet = repoAlbaran.GetAlbaranesDet(idAlbaranCab);
                foreach (var albaranDet in albaranesDet)
                {
                    if (!repoCombustible.DetalleAlbaranInsertado(albaranDet.IdAlbaranDet))
                    {
                        var idUM = repoProducto.GertOne(albaranDet.IdProducto ?? 0).IdUMedida;

                        decimal impIVA = Math.Round(albaranDet.Cantidad.Value * albaranDet.Precio.Value * IVA / 100, 2);
                        int idServicio = 5;//Diesel A

                        var detalleCombustible = new EntradasCombustibleDet
                        {
                            IdCompra = idCompra,
                            Albaran = albaranCab.NumAlbaran,
                            Cantidad = albaranDet.Cantidad,
                            Precio = albaranDet.Precio,
                            IdUmedida = idUM,
                            ImpIVA = impIVA,
                            IdServicio = idServicio,
                            IdProducto = albaranDet.IdProducto,
                            IdAlbaranDet = albaranDet.IdAlbaranDet
                        };

                        repoCombustible.InsertCombustibleDet(detalleCombustible);
                        insertado = true;
                    }
                }
            }
            return insertado;
            
        }


        public bool ValidaEliminarDetalleCombustible(int idAlbaranCab)
        {
            bool eliminado = false;
            var albaranCab = repoAlbaran.GetAlbaranCab(idAlbaranCab);

            if (repoProveedor.EsProveedorCombustible(albaranCab.IdProveedor ?? 0))
            {
                var albaranesDet = repoAlbaran.GetAlbaranesDet(idAlbaranCab);
                foreach (var albaranDet in albaranesDet)
                {
                    repoCombustible.EliminaCombustibleDetByIdAlbaranDet(albaranDet.IdAlbaranDet);
                    eliminado = true;
                }
            }

            return eliminado;
        }
    }
}
