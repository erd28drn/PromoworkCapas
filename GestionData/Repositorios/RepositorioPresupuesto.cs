using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionData.Modelos;
using GestionData.Entities;

namespace GestionData.Repositorios
{
    public class RepositorioPresupuesto
    {
        OperacionesDataModel contextoOperaciones = new OperacionesDataModel();
        DefinicionesDataModel contextoDefiniciones = new DefinicionesDataModel();

        public List<Participantes> GetParticipantes(int idEmpresa)
        {
           return contextoDefiniciones.Participantes.Where(p => p.IdEmpresa == idEmpresa).ToList();
        }

        public string GetNombrePartidaPresupuesto(int idPresupDet, int? idPresupSub)
        {
            string nombrePartida = "";
            if (idPresupSub != null)
            {
                nombrePartida = contextoOperaciones.PresupSub.FirstOrDefault(p => p.IdPresupSub == idPresupSub).NomPresupSub;
            }
            else
            {
                nombrePartida = contextoOperaciones.PresupDet.FirstOrDefault(p => p.IdPresupDet == idPresupDet).NomPresupDet;
            }
            return nombrePartida;
        }
        /// <summary>
        /// Carga el particpante de la partida indicada y en caso de no existir lo crea.
        /// </summary>
        /// <param name="idEmpresa"></param>
        /// <param name="idUsuario"></param>
        /// <param name="idPresupCab"></param>
        /// <param name="idPresupCap"></param>
        /// <param name="idPresupDet"></param>
        /// <param name="idPresupSub"></param>
        /// <returns></returns>
        public ParticipantesPresupuestos GetOrCreateParticipantePartidaPresupuesto(int idEmpresa, int idUsuario, int idPresupCab, int idPresupCap, int idPresupDet, int? idPresupSub)
        {
            ParticipantesPresupuestos participante;
            if (idPresupSub == null)
            {
                participante = contextoOperaciones.ParticipantesPresupuestos.FirstOrDefault(p => p.IdEmpresa == idEmpresa
                    && p.IdPresupCab == idPresupCab && p.IdPresupCap == idPresupCap && p.IdPresupDet == idPresupDet && p.IdPresupSub == null);
            }
            else
            {
                participante = contextoOperaciones.ParticipantesPresupuestos.FirstOrDefault(p => p.IdEmpresa == idEmpresa
                        && p.IdPresupCab == idPresupCab && p.IdPresupCap == idPresupCap && p.IdPresupDet == idPresupDet && p.IdPresupSub == idPresupSub);
            }

            if (participante == null)
            {
                participante = new ParticipantesPresupuestos
                {
                    IdEmpresa = idEmpresa,
                    IdUsuario = idUsuario,
                    IdPresupCab = idPresupCab,
                    IdPresupCap = idPresupCap,
                    IdPresupDet = idPresupDet,
                    IdPresupSub = idPresupSub,
                    NombrePartida = GetNombrePartidaPresupuesto(idPresupDet, idPresupSub),
                    EsServicio = false,
                    FechaCrea = DateTime.Now,
                    FechaModifica = DateTime.Now
                };
                contextoOperaciones.ParticipantesPresupuestos.AddObject(participante);
                contextoOperaciones.SaveChanges();
                GetOrCreateParticipantePartidaPresupuesto(idEmpresa, idUsuario, idPresupCab, idPresupCap, idPresupDet, idPresupSub);
            }

            return participante;
        }

        public List<ProveedoresParticipantes> GetOrCreateProveedoresParticipantes(int idParticipantePresupuesto, int numProveedores)
        {
            var proveedores = contextoOperaciones.ProveedoresParticipantes.Where(p => p.IdParticipantePresupuesto == idParticipantePresupuesto).ToList();

            if (!proveedores.Any())
            {
                proveedores = new List<ProveedoresParticipantes>();
                for (int i = 1; i <= numProveedores; i++)
                {
                    var proveedor = new ProveedoresParticipantes
                    {
                        IdParticipantePresupuesto = idParticipantePresupuesto,
                        Seleccionado = false
                    };
                    contextoOperaciones.ProveedoresParticipantes.AddObject(proveedor);
                }
                contextoOperaciones.SaveChanges();
                proveedores = contextoOperaciones.ProveedoresParticipantes.Where(p => p.IdParticipantePresupuesto == idParticipantePresupuesto).ToList();
            }

            return proveedores;
        }
    }
}
