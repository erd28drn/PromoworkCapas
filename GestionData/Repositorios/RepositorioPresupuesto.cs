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
        public List<ParticipantesPresupuestos> GetOrCreateParticipantesPartidaPresupuesto(int idEmpresa, int idUsuario, int idPresupCab, int idPresupCap, int idPresupDet, int? idPresupSub)
        {
            List<ParticipantesPresupuestos> participantes;
            if (idPresupSub == null)
            {
                participantes = contextoOperaciones.ParticipantesPresupuestos.Where(p => p.IdEmpresa == idEmpresa
                    && p.IdPresupCab == idPresupCab && p.IdPresupCap == idPresupCap && p.IdPresupDet == idPresupDet && p.IdPresupSub == null).ToList();
            }
            else
            {
                participantes = contextoOperaciones.ParticipantesPresupuestos.Where(p => p.IdEmpresa == idEmpresa
                        && p.IdPresupCab == idPresupCab && p.IdPresupCap == idPresupCap && p.IdPresupDet == idPresupDet && p.IdPresupSub == idPresupSub).ToList();
            }

            if (!participantes.Any())
            {
               var participantePresupuesto= CreateParticipantesPartidaPresupuesto(idEmpresa, idUsuario, idPresupCab, idPresupCap, idPresupDet, idPresupSub);
               
                GetOrCreateParticipantesPartidaPresupuesto(idEmpresa, idUsuario, idPresupCab, idPresupCap, idPresupDet, idPresupSub);
            }

            return participantes;
        }

        public ParticipantesPresupuestos CreateParticipantesPartidaPresupuesto(int idEmpresa, int idUsuario, int idPresupCab, int idPresupCap, int idPresupDet, int? idPresupSub)
        {
            var participantePresupuesto=new ParticipantesPresupuestos
                {
                    IdEmpresa = idEmpresa,
                    IdUsuario = idUsuario,
                    IdPresupCab = idPresupCab,
                    IdPresupCap = idPresupCap,
                    IdPresupDet = idPresupDet,
                    IdPresupSub = idPresupSub,
                    NombrePartida = GetNombrePartidaPresupuesto(idPresupDet, idPresupSub),
                    EsServicio = false,
                    Seleccionado1 = false,
                    Seleccionado2 = false,
                    Seleccionado3 = false,
                    FechaCrea = DateTime.Now,
                    FechaModifica = DateTime.Now
                };
            contextoOperaciones.ParticipantesPresupuestos.AddObject(participantePresupuesto);
            contextoOperaciones.SaveChanges();

            return participantePresupuesto;
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

        public ParticipantesPresupuestos UpdateParticipantePartidaPresupuesto(ParticipantesPresupuestos participantePresupuesto)
        {
            participantePresupuesto.FechaModifica = DateTime.Now;
            var participantePresupuestoUpdated = contextoOperaciones.ParticipantesPresupuestos.ApplyCurrentValues(participantePresupuesto);
            //var participantePresupuestoToUpdate = contextoOperaciones.ParticipantesPresupuestos.FirstOrDefault(p=> p.IdParticipantePresupuesto==participantePresupuesto.IdParticipantePresupuesto);
            //participantePresupuestoToUpdate = participantePresupuesto;
            //participantePresupuestoToUpdate.FechaModifica = DateTime.Now;
            contextoOperaciones.SaveChanges();
            return participantePresupuestoUpdated;
        }

        public bool DeleteParticipantePartidaPresupuesto(ParticipantesPresupuestos participantePresupuesto)
        {
            contextoOperaciones.ParticipantesPresupuestos.DeleteObject(participantePresupuesto);
            contextoOperaciones.SaveChanges();
            return true;
        }

        public List<ParticipantesPresupuestos> GetParticipantesPresupuesto(int idPresupCab)
        {
              var  participantes = contextoOperaciones.ParticipantesPresupuestos.Where(p => p.IdPresupCab == idPresupCab).ToList();
              return participantes;
        }

        public bool AddParticipantePartidaPresupuesto(ParticipantesPresupuestos participantePresupuesto)
        {
            contextoOperaciones.ParticipantesPresupuestos.AddObject(participantePresupuesto);
            contextoOperaciones.SaveChanges();
            return true;
        }
    }
}
