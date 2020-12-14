﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_DAMETO._3_LSP.LSP.Solucao
{
    public class Paralelogramo
    {
        protected Paralelogramo(int altura, int largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public double Altura { get; private set; }
        public double Largura { get; private set; }
        public double Area { get { return Altura * Largura; } }
    }
}
