using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionData.Modelos;
using GestionData.Repositorios;

namespace Promowork.Formularios.General
{
    public partial class frmTareas : Form
    {
        public frmTareas()
        {
            InitializeComponent();
        }

        private int? idEmpresa = null;
        private int idUsuario = VariablesGlobales.nIdUsuarioActual;
        private List<vTareas> tareas= new List<vTareas>();
        private List<Tareas> tareasInsert= new List<Tareas>();
        private List<Tareas> tareasUpdate= new List<Tareas>();
        private List<Tareas> tareasDelete= new List<Tareas>();

        RepositorioEmpresa repoEmpresa = new RepositorioEmpresa();
        RepositorioUsuario repoUsuario = new RepositorioUsuario();
        RepositorioTrabajador repoTrabajador = new RepositorioTrabajador();
        RepositorioTareas repoTareas = new RepositorioTareas();
        //Sincronizador sincronizador= new Sincronizador();
        private void frmTareas_Load(object sender, EventArgs e)
        {
            var empresas = repoEmpresa.GetAll();
            if (empresas.Any())
            {
                empresasBindingSource.DataSource = empresas;
            }

            //var trabajadoresTodos = repoTrabajador.GetAll();
            //if (trabajadoresTodos.Any())
            //{
            //    trabajadoresBindingSource1.DataSource = trabajadoresTodos;
            //}

            var trabajadores = repoTrabajador.GetTrabajadoresActivos(idEmpresa);
            if (trabajadores.Any())
            {
                trabajadoresBindingSource.DataSource = trabajadores;
            }

            CargarTareas();
        }

        private void btAddTarea_Click(object sender, EventArgs e)
        {
            vTareasBindingSource.AddNew();
            var vTareaNueva = (vTareas)vTareasBindingSource.Current;
            var nuevaTarea = repoTareas.MapTarea(vTareaNueva);
            nuevaTarea.IdUsuarioCreacion = idUsuario;
            nuevaTarea.IdUsuarioModificacion = idUsuario;
            tareasInsert.Add(nuevaTarea);
            
        }

        private void btSaveTarea_Click(object sender, EventArgs e)
        {
            foreach (var tarea in tareasInsert)
            {
                repoTareas.InsertTarea(tarea);
            }

            foreach (var tarea in tareasUpdate)
            {
                repoTareas.UpdateTarea(tarea);
            }

            foreach (var tarea in tareasDelete)
            {
                repoTareas.DeleteTarea(tarea);
            }

            tareasInsert.Clear();
            tareasUpdate.Clear();
            tareasDelete.Clear();

            //tareasBindingSource.DataSource = tareas;
            gvTareas.RefreshData();
            

        }

        private void cbEmpresa_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbEmpresa.SelectedIndex != -1)
            {
                idEmpresa = (int)cbEmpresa.SelectedValue;
            }
            else
            {
                idEmpresa = null;
            }
            var trabajadores = repoTrabajador.GetTrabajadoresActivos(idEmpresa);
                trabajadoresBindingSource.DataSource = trabajadores;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            var vTareaEliminar = (vTareas)vTareasBindingSource.Current;
            var tareaDelete = repoTareas.MapTarea(vTareaEliminar);

            tareasDelete.Add(tareaDelete);
            vTareasBindingSource.RemoveCurrent();;
        }

    
        private void chkMostrarFinalizados_CheckedChanged(object sender, EventArgs e)
        {
            CargarTareas();
        }

        private void CargarTareas()
        {
            if (chkMostrarFinalizados.CheckState == CheckState.Checked)
            {
                tareas = repoTareas.GetAllTareas();
            }
            else
            {
                tareas = repoTareas.GetTareasPendientes();
                
            }
            if (!tareas.Any())
            {
                tareas.Add(new vTareas());
                btDelete.Enabled = false;
            }
            else
            {
                btDelete.Enabled = true;
            }
            vTareasBindingSource.DataSource = tareas;
        }

        private void gvTareas_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.RowHandle != -1)
            {
                var vTareaModificada=(vTareas)vTareasBindingSource.Current;
                var tareaUpdate = repoTareas.MapTarea(vTareaModificada);

                var existeTarea = tareasUpdate.FirstOrDefault(t => t.IdTarea == tareaUpdate.IdTarea);

                if (existeTarea != null)
                {
                    existeTarea = tareaUpdate;
                }
                else
                {
                    tareaUpdate.IdUsuarioModificacion = idUsuario;
                    tareasUpdate.Add(tareaUpdate);
                }
            }
        }

        //private void btSincronizar_Click(object sender, EventArgs e)
        //{
        //    var tareasTodas = repoTareas.GetAllTareas();
        //    var tareasPendientes = repoTareas.GetTareasPendientes();

        //    var tareasSincronizadas = tareasPendientes
        //        .Where(t => !string.IsNullOrWhiteSpace(t.IdEventoExterno)).Select(t => t.IdEventoExterno).ToList();

        //    var tareasNoSincronizadas = tareasTodas
        //        .Where(t => string.IsNullOrWhiteSpace(t.IdEventoExterno)).ToList();

        //    InsertarNuevasTareasDesdeCalendario(tareasSincronizadas);

        //    //var eventosInsertados=InsertarTareasACalendario(tareasNoSincronizadas);
        //    //ActualizaIdEventoEnTareas(tareasNoSincronizadas, eventosInsertados);

        //    btSaveTarea_Click(null, null);
        //}

        //private void InsertarNuevasTareasDesdeCalendario(List<string> tareasSincronizadas)
        //{

        //    List<Event> eventos= sincronizador.GetEventosCalendario().Where(e=> string.IsNullOrWhiteSpace(e.Organizer.Id)).ToList();

        //    foreach (var evento in eventos.Where(ev => !tareasSincronizadas.Contains(ev.Id)))
        //    {
        //        tareasBindingSource.AddNew();

        //        var nuevaTarea = (Tareas)tareasBindingSource.Current;

        //        nuevaTarea.IdEventoExterno = evento.Id;
        //        nuevaTarea.FechaCreacion = evento.Created;
        //        nuevaTarea.FechaModificacion = evento.Updated;
        //        nuevaTarea.FechaVencimiento = evento.End.DateTime ?? DateTime.Parse(evento.End.Date);
        //        nuevaTarea.Finalizada = evento.Locked ?? false;
        //        nuevaTarea.IdUsuarioCreacion = 36;
        //        nuevaTarea.IdUsuarioModificacion = 36;
        //        nuevaTarea.IdTrabajador = null;
        //        nuevaTarea.ObsercacionesTarea = evento.Description;
        //        nuevaTarea.NombreTarea = evento.Summary;

        //        tareasInsert.Add(nuevaTarea);

        //    }
        //}

        //private List<Event> InsertarTareasACalendario(List<Tareas> tareas)
        //{
        //    List<Event> eventos = new List<Event>();

        //    foreach (var tarea in tareas)
        //    {
        //        Event evento = new Event();
        //        evento.Created = tarea.FechaCreacion;
        //        evento.Updated = tarea.FechaModificacion;
        //        evento.Start = new EventDateTime { DateTime = tarea.FechaVencimiento.Value.AddDays(-1) };
        //        evento.End = new EventDateTime { DateTime = tarea.FechaVencimiento };
        //        evento.Description = tarea.ObsercacionesTarea;
        //        evento.Summary = tarea.NombreTarea;
        //        evento.Creator = new Event.CreatorData
        //        {
        //            DisplayName ="Programa Promowork",
        //            Email = "tareas.programadas.promowork@gmail.com",
        //            Id =tarea.IdTarea.ToString(),
        //            Self =true
        //        };
        //        evento.Status = "confirmed";
        //        evento.Locked = tarea.Finalizada??false;
        //        evento.Kind= "calendar#event";
        //        evento.Reminders = new Event.RemindersData { UseDefault = true };

        //        eventos.Add(evento);
        //    }


        //    var eventosInsertados = sincronizador.InsertEventosCalendario(eventos);
        //    return eventosInsertados;
        //}

        //private void ActualizaIdEventoEnTareas(List<Tareas> tareasNoSincronizadas, List<Event> eventosInsertados)
        //{
        //    foreach (var evento in eventosInsertados)
        //    {
        //        var tarea = tareas.FirstOrDefault(t => t.IdTarea.ToString() == evento.Creator.Id);
        //        tareasUpdate.Add(tarea);
        //    }

        //}
    }
}
