using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionData.Modelos;
using GestionData.Entities;
using GestionData.Helpers;
using System.Data;
using System.Data.Objects;

namespace GestionData.Repositorios
{
    public class RepositorioParticipante
    {
        DefinicionesDataModel contextoDefiniciones = new DefinicionesDataModel();

        public IQueryable<Participantes> GetAllParticipantesEmpresa(int idEmpresa)
        {
            var paricipantes = contextoDefiniciones.Participantes.Where(p => p.IdEmpresa == idEmpresa);
            return paricipantes;
        }

        public RespuestasServicios GuardarCambios()
        {
            return DataHelper.GuardarContexto(contextoDefiniciones, "Participantes");
        }


    }
}
