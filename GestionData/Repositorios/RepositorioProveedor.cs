using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionData.Modelos;
using GestionData.Entities;

namespace GestionData.Repositorios
{
    public class RepositorioProveedor
    {
        DefinicionesDataModel contextoDefiniciones = new DefinicionesDataModel();

        public List<Proveedores> GetProveedores(int idEmpresa)
        {
            var proveedores = contextoDefiniciones.Proveedores.Where(p=> p.IdEmpresa== idEmpresa).ToList();

            return proveedores;
        }

        public List<Participantes> GetParticipantes(int idEmpresa)
        {
            return contextoDefiniciones.Participantes.Where(p => p.IdEmpresa == idEmpresa).ToList();
        }
    }
}
