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
    public class FacturasClientesService
    {
        RepositorioFacturasCab repoFacturasCab = new RepositorioFacturasCab();
        RepositorioFacturasDetHoras repoFacturasDetHoras = new RepositorioFacturasDetHoras();
        RespuestasServicios respuetaServicio = new RespuestasServicios();
        RepositorioHorasTrabajadas repoHoras = new RepositorioHorasTrabajadas();

        public RespuestasServicios CrearFacturaPartes(int idUsuario, List<GestionData.Promowork_dataDataSet.HorasPendientesFacturarRow> horasFacturar)
        {
            var primeraHoraFacturar= horasFacturar.FirstOrDefault();
            var respuestaFacturaCab = CrearFacturaCab(idUsuario, primeraHoraFacturar);
            if (respuestaFacturaCab.ResultadoOk)
            {
                var respuestaFacturaDet = CrearFacturaDetHoras(respuestaFacturaCab.idRespuesta, horasFacturar);
                if (!respuestaFacturaDet.ResultadoOk)
                {
                    return respuestaFacturaDet;
                }
            }

            return respuestaFacturaCab;
        }

        private RespuestasServicios CrearFacturaCab(int idUsuario, GestionData.Promowork_dataDataSet.HorasPendientesFacturarRow datosEncabezado)
        {
            try
            {
                FacturasCab facturaCab = new FacturasCab
                {
                    NumFactura = 0,
                    IdUsuario = idUsuario,
                    IdEmpresa = datosEncabezado.IdEmpresa,
                    IdCliente = datosEncabezado.IdCliente,
                    IdClienteFact = datosEncabezado.IdCliente,
                    IdObra = datosEncabezado.IdObra,
                    Factura = true,
                    EsPrevision = true,
                    Cobrada = false,
                    Entregada = false,
                    NoDetalle = false,
                    MostrarObra = true,
                    MostrarVcto = true,
                    MostrarSubTot = false,
                    UnificarMaterial = false,
                    FechaFactura = DateTime.Today,
                    FechaVctoFact = DateTime.Today
                };
                respuetaServicio.idRespuesta = repoFacturasCab.InsertFacturaCab(facturaCab);
                respuetaServicio.ResultadoOk = true;
            }
            catch (Exception ex)
            {
                respuetaServicio.ResultadoOk = false;
                respuetaServicio.idRespuesta = -1;
                respuetaServicio.Mensaje = "Error al crear el encabezado en la factura de la obra "+datosEncabezado.DesObra+". " + ex.Message + "\n";
            }
            return respuetaServicio;
            
        }

        private RespuestasServicios CrearFacturaDetHoras(int idFacturaCab, List<GestionData.Promowork_dataDataSet.HorasPendientesFacturarRow> horasFacturar)
        {
            respuetaServicio.ResultadoOk = true;

            foreach (var horaFacturar in horasFacturar)
            {
                try
                {
                    FacturasDetHoras facturaDet = new FacturasDetHoras
                    {
                        IdFactCab = idFacturaCab,
                        IdHoras = horaFacturar.IdHoras,

                    };
                    repoFacturasDetHoras.InsertFacturaDetHoras(facturaDet);
                    repoHoras.SetFacturada(horaFacturar.IdHoras, true);
                }
                catch (Exception ex)
                {
                    respuetaServicio.ResultadoOk = false;
                    respuetaServicio.idRespuesta = -1;
                    respuetaServicio.Mensaje += "Error al crear los detalles en la factura de la obra " + horaFacturar.DesObra + ". " + ex.Message + "\n";
                }
            }
            return respuetaServicio;
        }
    }
}
