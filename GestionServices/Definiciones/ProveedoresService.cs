using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionData;
using GestionData.Entities;
using GestionData.Modelos;
using GestionServices.Generales;
using GestionData.Promowork_dataDataSetTableAdapters;


namespace GestionServices.Definiciones
{
    public class ProveedoresService
    {
        #region GESTORES CON EMAIL

        DefinicionesDataModel contextoDefiniciones = new DefinicionesDataModel();

        public List<GestorConEmail> ObtenerGestoresConEmail(int idEmpresa, bool primeroVacio)
        {
            //string codGrupoGestor = "052";
            //OperacionesDataModel contextoOperaciones = new OperacionesDataModel();
            
            //int idGrupoGestor = contexto.GruposProducto.FirstOrDefault(g => g.IdEmpresa == idEmpresa && g.CodGrupo == codGrupoGestor).IdGrupo;
            var gestoresConEmail = contextoDefiniciones.Proveedores.Where(p => p.IdEmpresa == idEmpresa && p.EsGestor==true && !string.IsNullOrEmpty(p.EmailProveedor))
            .Select(t => new GestorConEmail()
            {
                IdGestor = t.IdProveedor,
                NumGestor = t.NumProveedor,
                NomGestor = t.DesProveedor,
                EmailGestor = t.EmailProveedor
            }).ToList();

            var gestoresConEmailValido= gestoresConEmail.Where(g => Utilidades.ValidarEmail(g.EmailGestor)).ToList();  

            if (primeroVacio)
            {
                gestoresConEmailValido.Add(new GestorConEmail { IdGestor = 0, NomGestor = "" });
            }

            return gestoresConEmailValido.OrderBy(g => g.NomGestor).ToList(); 
        }

        #endregion GESTORES CON EMAIL
    }
}
