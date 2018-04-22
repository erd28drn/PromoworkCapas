using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionData;
using GestionData.Entities;
using GestionServices.Generales;


namespace GestionServices.Definiciones
{
    public static class TrabajadoresServices
    {
        #region TRABAJADORES CON EMAIL
        public static List<TrabajadorConEmail> ObtenerTrabajadoresConEmail(int idEmpresa)
        {
            GestionData.Promowork_dataDataSetTableAdapters.TrabajadoresTableAdapter trabajadoresTableAdapter = new GestionData.Promowork_dataDataSetTableAdapters.TrabajadoresTableAdapter();
            List<TrabajadorConEmail> trabajadoresConEmail = trabajadoresTableAdapter.GetData(idEmpresa).Where(t => t.ActivoTrabajador &&  Utilidades.ValidarEmail(t.EmailTrabajador))
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
