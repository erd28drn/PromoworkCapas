using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections;

namespace GestionData.Enumeradores
{
     [TypeConverter(typeof(CustomEnumConverter))]
    public enum EnumCargaAlbaranes
    {
        [Description("Mismo período que Factura")]
        mismoPeriodo = 1,
        [Description("Todos los pendientes")]
        todos = 2
    }

}
