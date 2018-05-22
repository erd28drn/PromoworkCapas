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
