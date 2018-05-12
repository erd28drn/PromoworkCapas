using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionData.Entities
{
   public class ConfiguracionEmpresa
    {
        public int idEmpresa { get; set; }
        public string asuntoSinAlbaran { get; set; }
        public string cuerpoMensajeSinAlbaran { get; set; }
        public string asuntoObrasProveedores { get; set; }
        public string cuerpoMensajeObrasProveedores { get; set; }
        public string asuntoEnvioFacturas { get; set; }
        public string CuerpoEnvioFacturas { get; set; }

    }

}
