using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionData.Entities
{
    public class TrabajadorConEmail
    {
        public int IdTrabajador { get; set; }
        public int NumeroTRabajador { get; set; }
        public string NombreTrabajador { get; set; }
        public string EmailTrabajador { get; set; }
        public string NombreEmailTrabajador
        {
            get
            {
                return NombreTrabajador + " (" + EmailTrabajador + ")";
            }
        }
    }
}
