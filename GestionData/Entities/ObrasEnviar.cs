using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionData.Entities
{
    public class ObrasEnviar
    {
        public int IdObra { get; set; }
        public bool Marca { get; set; }
        public int? Matriz { get; set; }
        public int NumObra { get; set; }
        public string SerieObra { get; set; }
        public string NumObraStr { get; set; }
        public string DesObra { get; set; }
        //public bool EnviarProveedor { get; set; }
        public string NumeroDescripcion { get; set; }
        public string MatrizNumeroDescripcion { get; set; }
    }
}
