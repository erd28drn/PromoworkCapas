﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Promowork
{
    public class ComboBoxItem
    {
        public string Name { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
