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

        public bool SetPartesFinalizados(List<int> idsPartes, bool valor=true)
        {
            var partesAFinalizar = contextoOperaciones.HorasTrabajadas.Where(h => idsPartes.Contains(h.IdHoras));
            if (partesAFinalizar.Any())
            {
                foreach (var parte in partesAFinalizar)
                {
                    parte.TrabajoFinalizado = valor;
                }
                contextoOperaciones.SaveChanges();
            }
            return true;
        }
    }
}
