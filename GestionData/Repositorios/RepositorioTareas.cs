using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionData.Modelos;

namespace GestionData.Repositorios
{
    public class RepositorioTareas
    {
        GeneralesDataModel contextoGeneral= new GeneralesDataModel();
        VistasGeneralesDataModel contectoVistasGenerales = new VistasGeneralesDataModel();

        public List<vTareas> GetTareasPendientes()
        {
            var tareas = contectoVistasGenerales.vTareas.AsNoTracking().Where(t => t.Finalizada != true).OrderBy(t => t.FechaVencimiento).ToList();
            contectoVistasGenerales.Refresh( System.Data.Objects.RefreshMode.StoreWins, tareas);
            return tareas;
        }

        public List<vTareas> GetAllTareas()
        {
            var tareas = contectoVistasGenerales.vTareas.AsNoTracking().OrderBy(t => t.FechaVencimiento).ToList();
            contectoVistasGenerales.Refresh(System.Data.Objects.RefreshMode.StoreWins, tareas);
            return tareas;
        }

        public bool InsertTarea(Tareas tarea)
        {
            //tarea.IdUsuarioCreacion = idUsuario;
            tarea.FechaCreacion = DateTime.Now;
            tarea.FechaModificacion = DateTime.Now;
            tarea.Finalizada = false;
            contextoGeneral.Tareas.AddObject(tarea);
            contextoGeneral.SaveChanges();
            return true;
        }

        public bool UpdateTarea(Tareas tarea)
        {
            var tareaToUpdate = contextoGeneral.Tareas.FirstOrDefault(t => t.IdTarea == tarea.IdTarea);
            tarea.FechaModificacion = DateTime.Now;
            //tarea.IdUsuarioModificacion = idUsuario;
            tareaToUpdate = tarea;
            contextoGeneral.SaveChanges();
            return true;
        }

        public bool DeleteTarea(Tareas tarea)
        {
            contextoGeneral.Tareas.DeleteObject(tarea);
            contextoGeneral.SaveChanges();
            return true;
        }

        public bool InsertUpdateDelete(List<Tareas> tareas)
        {
            var tareasInsert = tareas.Where(t => t.IdTarea == 0);
            var tareasUpdate = tareas.Where(t => t.IdTarea > 0);
            var tareasdelete = contextoGeneral.Tareas.Except(tareasUpdate);

            return true;
        }

        public Tareas MapTarea(vTareas vTarea)
        {
            Tareas tarea = contextoGeneral.Tareas.FirstOrDefault(T => T.IdTarea == vTarea.IdTarea);

            if (tarea != null)
            {
                tarea.FechaVencimiento = vTarea.FechaVencimiento;
                tarea.Finalizada = vTarea.Finalizada;
                tarea.IdEmpresa = vTarea.IdEmpresa;
                tarea.IdEventoExterno = vTarea.IdEventoExterno;
                tarea.IdTrabajador = vTarea.IdTrabajador;
                tarea.IdUsuarioModificacion = vTarea.IdUsuarioModificacion;
                tarea.NombreTarea = vTarea.NombreTarea;
                tarea.ObsercacionesTarea = vTarea.ObsercacionesTarea;
                
            }
            else
            {
                tarea = new Tareas();
                tarea.FechaVencimiento = vTarea.FechaVencimiento;
                tarea.Finalizada = vTarea.Finalizada;
                tarea.IdEmpresa = vTarea.IdEmpresa;
                tarea.IdEventoExterno = vTarea.IdEventoExterno;
                tarea.IdTrabajador = vTarea.IdTrabajador;
                tarea.IdUsuarioCreacion = vTarea.IdUsuarioCreacion;
                tarea.IdUsuarioModificacion = vTarea.IdUsuarioModificacion;
                tarea.NombreTarea = vTarea.NombreTarea;
                tarea.ObsercacionesTarea = vTarea.ObsercacionesTarea;
                
            }

            return tarea;
        }

    }
}
