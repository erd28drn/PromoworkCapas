using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionData;
using GestionData.Entities;
using GestionServices.Generales;


namespace GestionServices.Definiciones
{
    public static class ProveedoresService
    {
        #region GESTORES CON EMAIL

        

        public static List<GestorConEmail> ObtenerGestoresConEmail(int idEmpresa)
        {
            string codGrupoGestor = "052";
            Promowork_dataEntities contexto = new Promowork_dataEntities();

            int idGrupoGestor = contexto.GruposProductos.FirstOrDefault(g => g.IdEmpresa == idEmpresa && g.CodGrupo == codGrupoGestor).IdGrupo;
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
