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


        public bool GuardarConfiguracionUsuario(ConfiguracionUsuario configuracionUsuario)
        {
            var usuarioActual = contextoGenerales.Usuarios.FirstOrDefault(u => u.IdUsuario == configuracionUsuario.idUsuario);
            string configuracionUsuarioJson = JsonConvert.SerializeObject(configuracionUsuario);

            usuarioActual.ConfiguracionUsuario = configuracionUsuarioJson;
            contextoGenerales.SaveChanges();
            return true;
        }

        
    }
}
