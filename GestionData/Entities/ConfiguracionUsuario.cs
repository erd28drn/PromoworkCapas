using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionData.Entities
{
   public class ConfiguracionUsuario
    {
        public int? idUsuario { get; set; }
        public bool? esAdmin { get; set; }
        public int? empresaSeleccionada { get; set; }
        public int? anoSeleccionado { get; set; }
        public int? mesSeleccionado { get; set; }
        public int? responderASeleccionado { get; set; }
        public int? gestorSeleccionado { get; set; }

    }

}
