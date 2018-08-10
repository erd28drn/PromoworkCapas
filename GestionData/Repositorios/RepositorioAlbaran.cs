using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionData.Modelos;
using GestionData.Entities;

namespace GestionData.Repositorios
{
    public class RepositorioAlbaran
    {
        OperacionesDataModel contextoOperaciones = new OperacionesDataModel();
  
        public AlbaranesCab GetAlbaranCab(int idAlbaranCab)
        {
           var albaranCab= contextoOperaciones.AlbaranesCab.FirstOrDefault(a => a.IdAlbaranCab == idAlbaranCab);
           return albaranCab;
        }

        public List<AlbaranesDet> GetAlbaranesDet(int idAlbaranCab)
        {
            var albaranesDet = contextoOperaciones.AlbaranesDet.Where(a => a.IdAlbaranCab == idAlbaranCab).ToList();

            return albaranesDet;
        }
    }
}
