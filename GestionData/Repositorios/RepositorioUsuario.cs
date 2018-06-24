using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionData.Entities;
using GestionData.Modelos;
using Newtonsoft.Json;
using GestionData.Promowork_dataDataSetTableAdapters;

namespace GestionData.Repositorios
{
    public class RepositorioUsuario
    {
        GeneralesDataModel contextoGenerales = new GeneralesDataModel();
        public Usuarios GetOne(int idUsuario)
        {
            return contextoGenerales.Usuarios.FirstOrDefault(u => u.IdUsuario == idUsuario);
        }

        public List<Usuarios> GetAll()
        {
            return contextoGenerales.Usuarios.ToList();
        }

        public List<Usuarios> GetAllActivos()
        {
            return contextoGenerales.Usuarios.Where(u => u.ActivoUsuario.Value == true).OrderByDescending(u => u.UltimoUsuario.Value).ToList();
        }

        public void SetAllUltimoUsuarioFalse()
        {
            foreach (var usuario in contextoGenerales.Usuarios)
            {
                usuario.UltimoUsuario = false;
            }
            contextoGenerales.SaveChanges();
        }

        public void SetUltimoUsuario(int idUsuario)
        {
            contextoGenerales.Usuarios.FirstOrDefault(u => u.IdUsuario == idUsuario).UltimoUsuario = true;
            contextoGenerales.SaveChanges();
        }

        public ConfiguracionUsuario GetConfiguracionUsuario(int idUsuario)
        {
            ConfiguracionUsuario configuracionUsuario = new ConfiguracionUsuario();
            var usuario =contextoGenerales.Usuarios.FirstOrDefault(u=> u.IdUsuario==idUsuario);
            if (usuario != null && usuario.ConfiguracionUsuario!=null)
            {
                try
                {
                    configuracionUsuario = JsonConvert.DeserializeObject<ConfiguracionUsuario>(usuario.ConfiguracionUsuario);
                }
                catch { }
            }
            return configuracionUsuario;
        }

        public bool GuardarConfiguracionUsuario(ConfiguracionUsuario configuracionUsuario)
        {
            var usuarioActual = contextoGenerales.Usuarios.FirstOrDefault(u => u.IdUsuario == configuracionUsuario.idUsuario);
            string configuracionUsuarioJson = JsonConvert.SerializeObject(configuracionUsuario);

            usuarioActual.ConfiguracionUsuario = configuracionUsuarioJson;
            //ES NECESARIO ACTUALIZAR ESTOS CAMPOS DE LA TABLA USUSARIO, 
            //PORQUE EL TRIGGER QUE CREA LOS FESTIVOS DE LA EMPRESA Y LAS OBRAS LO HACE A PARTIR DE ESTOS CAMPOS.
            //HABRIA QUE CREAR UN METODO PARA CREAR LOS FESTIVOS Y DESACTIVAR EL TRIGGER.
            usuarioActual.AnoUsuario = configuracionUsuario.anoSeleccionado;
            usuarioActual.MesUsuario = configuracionUsuario.mesSeleccionado;
            //////////////
            contextoGenerales.SaveChanges();
            return true;
        }

        
    }
}
