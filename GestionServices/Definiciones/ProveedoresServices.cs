using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionData;
using GestionData.Entities;
using GestionServices.Generales;


namespace GestionServices.Definiciones
{
    public static class ProveedoresServices
    {
        #region GESTORES CON EMAIL

        

        public static List<GestorConEmail> ObtenerGestoresConEmail(int idEmpresa)
        {
            int idGrupoGestor = 47;
            Promowork_dataEntities contexto = new Promowork_dataEntities();

            var gestoresConEmail = contexto.Proveedores.Where(p => p.IdEmpresa == idEmpresa && p.Idgrupo == idGrupoGestor && !string.IsNullOrEmpty(p.EmailProveedor))
            .Select(t => new GestorConEmail()
            {
                IdGestor = t.IdProveedor,
                NumGestor = t.NumProveedor,
                NomGestor = t.DesProveedor,
                EmailGestor = t.EmailProveedor
            }).ToList();

            return gestoresConEmail.Where(g=> Utilidades.ValidarEmail(g.EmailGestor)).ToList();
        }

        #endregion GESTORES CON EMAIL
    }
}
