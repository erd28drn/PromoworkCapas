using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionData.Modelos;
using GestionData.Entities;

namespace GestionData.Repositorios
{
    public class RepositorioObra
    {
        DefinicionesDataModel contextoDefiniciones = new DefinicionesDataModel();
  
        public Obras GetOneObra(int idObra)
        {
            var obra = contextoDefiniciones.Obras.FirstOrDefault(a => a.IdObra == idObra);
            return obra;
        }
    }
}
