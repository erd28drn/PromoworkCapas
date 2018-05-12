using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionData.Modelos;
using GestionData.Entities;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using Newtonsoft.Json;

namespace GestionData.Repositorios
{
    public class RepositorioEmpresa
    {
        GeneralesDataModel contextoGenerales = new GeneralesDataModel();
        
        public Empresas GetOne(int idEmpresa)
        {
            return contextoGenerales.Empresas.First(e => e.IdEmpresa == idEmpresa);

        }

        public ObjectSet<Empresas> GetAll()
        {
            return contextoGenerales.Empresas;

        }
       
        public List<Empresas> GetEmpresasUsuario(int idUsuario)
        {
            var empresas = contextoGenerales.Empresas    // your starting point - table in the "from" statement
               .Join(contextoGenerales.AccesosEmpresas, // the source table of the inner join
                  empresa => empresa.IdEmpresa,        // Select the primary key (the first part of the "on" clause in an sql "join" statement)
                  acceso => acceso.IdEmpresa,   // Select the foreign key (the second part of the "on" clause)
                  (empresa, acceso) => new { Empresa = empresa, Acceso = acceso }) // selection
               .Where(empresaAcceso => empresaAcceso.Acceso.IdUsuario == idUsuario && empresaAcceso.Acceso.Acceso == true).Select(ea => ea.Empresa).ToList();    // where statement

            return empresas;
        }

        public ConfiguracionEmpresa GetConfiguracionEmpresa(int idEmpresa)
        {
            ConfiguracionEmpresa configuracionEmpresa = new ConfiguracionEmpresa();
            var empresa = contextoGenerales.Empresas.FirstOrDefault(e => e.IdEmpresa == idEmpresa);
            if (empresa != null && empresa.ConfiguracionEmpresa!=null)
            {
                try
                {
                    configuracionEmpresa = JsonConvert.DeserializeObject<ConfiguracionEmpresa>(empresa.ConfiguracionEmpresa);
                }
                catch { }
            }
            return configuracionEmpresa;
        }

        public bool GuardarConfiguracionEmpresa(ConfiguracionEmpresa configuracionEmpresa)
        {
            var empresaActual = contextoGenerales.Empresas.FirstOrDefault(e => e.IdEmpresa == configuracionEmpresa.idEmpresa);
            string configuracionEmpresaJson = JsonConvert.SerializeObject(configuracionEmpresa);

            empresaActual.ConfiguracionEmpresa = configuracionEmpresaJson;
            contextoGenerales.SaveChanges();
            return true;
        }
        

    }
}
