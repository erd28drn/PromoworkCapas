using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionData.Entities
{
    public class TotalesCompra
    {
        public decimal ImporteBase { get; set; }
        public decimal ImporteIVA { get; set; }
        public decimal ImporteIRPF { get; set; }
        public decimal ImporteTotal
        {
            get { return ImporteBase + ImporteIVA - ImporteIRPF; }
            set { value = ImporteTotal; }
        }
    }
}
