using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionData.Modelos;
using GestionData.Entities;
using GestionData.Helpers;

namespace GestionData.Repositorios
{
    public class RepositorioTrabajador
    {
        DefinicionesDataModel contextoDefiniciones = new DefinicionesDataModel();

        public List<Trabajadores> GetAll()
        {
            List<Trabajadores> trabajadores = contextoDefiniciones.Trabajadores.ToList();
            
            return trabajadores;
        }
        
        public List<Trabajadores> GetTrabajadoresActivos(int? idEmpresa)
        {
            List<Trabajadores> trabajadores;
            if (idEmpresa == null)
            {
                trabajadores = contextoDefiniciones.Trabajadores.Where(t => t.ActivoTrabajador == true).ToList();
            }
            else
            {
                trabajadores = contextoDefiniciones.Trabajadores.Where(t => t.ActivoTrabajador == true && t.IdEmpresa == idEmpresa)
                    .ToList();
            }
            return trabajadores;
        }

        #region TRABAJADORES CON EMAIL
        public List<TrabajadorConEmail> GetTrabajadoresConEmail(int idEmpresa)
        {
            List<TrabajadorConEmail> trabajadoresConEmail = contextoDefiniciones.Trabajadores.Where(t => t.IdEmpresa == idEmpresa && t.ActivoTrabajador.Value && t.EmailTrabajador != null).ToList().Where(t => GeneralHelper.ValidarEmail(t.EmailTrabajador))
            .Select(t => new TrabajadorConEmail()
            {
                IdTrabajador = t.IdTrabajador,
                NumeroTRabajador = t.NumTrabajador,
                NombreTrabajador = t.NomTrabajador + " " + t.ApeTrabajador,
                EmailTrabajador = t.EmailTrabajador
            }).ToList();

            return trabajadoresConEmail;
        }
        #endregion TRABAJADORES CON EMAIL
    }
}
