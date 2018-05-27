using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionData.Modelos;
using GestionData.Entities;

namespace GestionData.Repositorios
{
    public class RepositorioHorasTrabajadas
    {
        OperacionesDataModel contextoOperaciones = new OperacionesDataModel();

        public bool SetFacturada(int idHora, bool valor)
        {
            var hora = contextoOperaciones.HorasTrabajadas.FirstOrDefault(h => h.IdHoras == idHora);
            hora.Facturado = valor;
            contextoOperaciones.SaveChanges();
            return true;
        }
    }
}
