﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    class veiculo
    {
        public string Cor { get; set; }

        public virtual string Buzinar()
        {
            return "Biiii";
        }
    }
}
