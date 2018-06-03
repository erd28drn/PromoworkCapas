using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionData.Entities
{
    public class ListadoPresupuestos
    {
        public int IdEmpresa { get; set; }
        public int IdPresupCab { get; set; }
        public int NumPresup { get; set; }
        public string NomPresup { get; set; }
        public string DesPresup { get; set; }
        public int IdCliente { get; set; }
        public string DesCliente { get; set; }
        public int IdObra { get; set; }
        public string DesObra { get; set; }
    }
}
