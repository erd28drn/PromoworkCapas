using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionData.Entities
{
    public class GestorConEmail
    {
        public int IdGestor { get; set; }
        public int NumGestor { get; set; }
        public string NomGestor { get; set; }
        public string EmailGestor { get; set; }
        public string NombreEmailGestor
        {
            get
            {
                return string.IsNullOrWhiteSpace(EmailGestor)? "" : NomGestor + " (" + EmailGestor + ")";
            }
        }
    }
}
