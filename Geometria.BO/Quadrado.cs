﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.BO
{
    public class Quadrado : Formas
    {
        public decimal Perimetro(decimal valor)
        {
            return valor * 4;
        }
        public decimal Area(decimal valor1)
        {
            return valor1 * valor1;
        }
    }
}
