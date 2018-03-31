using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionData.Entities
{
    public class ResumenEnvioCorreos
    {
        public int IdProveedor { get; set; }
        public bool Marca { get; set; }
        public string Proveedor { get; set; }
        public string Email { get; set; }
        public bool Valido { get; set; }
        public bool Enviado { get; set; }
        public string Respuesta { get; set; }
    }
}
