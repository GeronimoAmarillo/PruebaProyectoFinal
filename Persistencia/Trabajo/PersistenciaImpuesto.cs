﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;

namespace Persistencia
{
    class PersistenciaImpuesto:IPersistenciaImpuesto
    {
        public bool RegistrarImpuesto(EntidadesCompartidas.Impuesto impuesto)
        {
            return true;
        }
    }
}
